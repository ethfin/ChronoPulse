Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Private knownGames As New HashSet(Of String)() ' Use HashSet for faster lookups
    Private userID As Integer

    Private Sub UpdateTotalCost()
        Dim totalCost As Decimal = 0

        ' Query to get the total cost of expenses for the user
        Dim query As String = "SELECT SUM(Cost) AS TotalCost FROM user_expenses WHERE UserID = @userID"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    totalCost = Convert.ToDecimal(result)
                End If
                conn.Close()
            End Using
        End Using

        lblTotalCost.Text = totalCost.ToString("C")
    End Sub

    Private Sub UpdateTotalItems()
        Dim totalItems As Integer = 0

        ' Query to get the total number of items for the user
        Dim query As String = "SELECT COUNT(*) AS TotalItems FROM user_expenses WHERE UserID = @userID"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    totalItems = Convert.ToInt32(result)
                End If
                conn.Close()
            End Using
        End Using

        lblTotalItems.Text = totalItems.ToString()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the UserID from frmMain
        GetUserID()

        ' Populate ListBox1 with known games from the database
        LoadUserGames()

        ' Populate ListBox1 with known games
        ListBox1.Items.AddRange(knownGames.ToArray())

        ' Update the last log time
        UpdateLogLastTime()

        ' Update the total cost
        UpdateTotalCost()

        ' Update the total items
        UpdateTotalItems()

        ' Start the timer
        Timer1.Start()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        ' Subscribe to events from frmGames
        AddHandler frmGames.GameAdded, AddressOf OnGameAdded
        AddHandler frmGames.GameDeleted, AddressOf OnGameDeleted
    End Sub

    Private Sub OnGameAdded(gameName As String)
        If Not ListBox1.Items.Contains(gameName) Then
            ListBox1.Items.Add(gameName)
        End If
    End Sub

    Private Sub OnGameDeleted(gameName As String)
        If ListBox1.Items.Contains(gameName) Then
            ListBox1.Items.Remove(gameName)
        End If
    End Sub

    Public Sub RefreshTotalCost()
        UpdateTotalCost()
    End Sub

    Public Sub RefreshTotalItems()
        UpdateTotalItems()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Task.Run(AddressOf UpdateLogLastTime)
    End Sub

    Private Sub GetUserID()
        Dim username As String = frmMain.lblUsername.Text
        Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using getUserIDCmd As New MySqlCommand(getUserIDQuery, conn)
                getUserIDCmd.Parameters.AddWithValue("@username", username)
                conn.Open()
                userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub LoadUserGames()
        Dim loadGamesQuery As String = "SELECT game_name FROM game_paths WHERE UserID = @UserID"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using loadGamesCmd As New MySqlCommand(loadGamesQuery, conn)
                loadGamesCmd.Parameters.AddWithValue("@UserID", userID)
                conn.Open()
                Using reader As MySqlDataReader = loadGamesCmd.ExecuteReader()
                    While reader.Read()
                        Dim gameName As String = reader("game_name").ToString()
                        knownGames.Add(gameName)
                    End While
                End Using
                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub UpdateLogLastTime()
        Dim getElapsedTimeQuery As String = "SELECT gp.game_name, gt.hours " &
                                            "FROM game_time gt " &
                                            "JOIN game_paths gp ON gt.path_id = gp.path_id " &
                                            "WHERE gt.UserID = @UserID " &
                                            "ORDER BY gt.date DESC LIMIT 1"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using getElapsedTimeCmd As New MySqlCommand(getElapsedTimeQuery, conn)
                getElapsedTimeCmd.Parameters.AddWithValue("@UserID", userID)
                conn.Open()
                Using reader As MySqlDataReader = getElapsedTimeCmd.ExecuteReader()
                    If reader.Read() Then
                        Dim gameName As String = reader("game_name").ToString()
                        Dim elapsedTimeSeconds As Integer = Convert.ToInt32(reader("hours"))
                        Dim formattedElapsedTime As String = FormatElapsedTime(elapsedTimeSeconds)

                        If Not Me.IsDisposed Then
                            BeginInvoke(Sub()
                                            lblLogLastTime.Text = String.Empty ' Clear the label text
                                            lblLogLastTime.Text &= $"{gameName}: Elapsed Time {formattedElapsedTime}" & "<br>"
                                        End Sub)
                        End If
                    End If
                End Using
                conn.Close()
            End Using
        End Using
    End Sub

    Private Function FormatElapsedTime(seconds As Integer) As String
        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(seconds)
        Return $"{timeSpan:hh\:mm\:ss}"
    End Function

End Class