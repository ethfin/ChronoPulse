Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmGames

    Private previousApplications As New Dictionary(Of String, DateTime)()
    Private knownGames As New HashSet(Of String)() ' Use HashSet for faster lookups
    Private gameStartTimes As New Dictionary(Of String, DateTime)()
    Private userID As Integer

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        ' Get the UserID from frmExpenses
        GetUserID()

        ' Populate ListBox1 with known games from the database
        LoadUserGames()

        ' Populate ListBox1 with known games
        ListBox1.Items.AddRange(knownGames.ToArray())

        ' Load existing game times
        LoadExistingGameTimes()
        AddHandler Me.FormClosing, AddressOf frmGames_FormClosing
    End Sub

    Private Sub frmGames_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Save elapsed time for all tracked games
        For Each app In previousApplications.Keys.ToList()
            Dim startTime As DateTime = gameStartTimes(app)
            Dim elapsedTime As TimeSpan = DateTime.Now - startTime

            ' Insert or update the elapsed time in the database
            InsertOrUpdateGameTime(app, elapsedTime)
        Next
    End Sub

    Private Sub LoadExistingGameTimes()
        Dim getElapsedTimeQuery As String = "SELECT gp.game_name, SUM(gt.hours) AS total_hours " &
                                        "FROM game_time gt " &
                                        "JOIN game_paths gp ON gt.path_id = gp.path_id " &
                                        "WHERE gt.UserID = @UserID " &
                                        "GROUP BY gp.game_name"

        Using connection As MySqlConnection = Common.createDBConnection()
            Using getElapsedTimeCmd As New MySqlCommand(getElapsedTimeQuery, connection)
                getElapsedTimeCmd.Parameters.AddWithValue("@UserID", userID)
                connection.Open()
                Using reader As MySqlDataReader = getElapsedTimeCmd.ExecuteReader()
                    If Not Me.IsDisposed Then
                        BeginInvoke(Sub()
                                        lblLoglastTime.Text = String.Empty ' Clear the label text
                                    End Sub)
                    End If

                    While reader.Read()
                        Dim gameName As String = reader("game_name").ToString()
                        Dim totalElapsedTimeSeconds As Integer = Convert.ToInt32(reader("total_hours"))
                        Dim formattedElapsedTime As String = FormatElapsedTime(totalElapsedTimeSeconds)

                        If Not Me.IsDisposed Then
                            BeginInvoke(Sub()
                                            lblLoglastTime.Text &= $"{gameName}: Total Elapsed Time {formattedElapsedTime}" & "<br>"
                                        End Sub)
                        End If
                    End While
                End Using
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Task.Run(AddressOf UpdateTracker)
    End Sub

    Private Sub UpdateTracker()
        Dim processes = Process.GetProcesses()
        Dim trackerText As New StringBuilder()
        Dim currentApplications As New Dictionary(Of String, DateTime)()

        For Each proc As Process In processes
            If Not IsSystemProcess(proc) AndAlso IsGame(proc) Then
                Dim appName = proc.ProcessName
                If Not currentApplications.ContainsKey(appName) Then
                    ' Set the start time for the game session if not already set
                    If Not gameStartTimes.ContainsKey(appName) Then
                        gameStartTimes(appName) = DateTime.Now
                    End If

                    ' Calculate the elapsed time
                    Dim startTime As DateTime = gameStartTimes(appName)
                    Dim elapsedTime As TimeSpan = DateTime.Now - startTime

                    trackerText.AppendLine($"{appName}: Elapsed Time {elapsedTime:hh\:mm\:ss}")
                    currentApplications(appName) = DateTime.Now

                    ' Update the last active time for the running application
                    previousApplications(appName) = DateTime.Now
                End If
            End If
        Next

        ' Check for closed applications
        Dim closedApplications As New List(Of String)()
        For Each app In previousApplications.Keys.ToList()
            If Not currentApplications.ContainsKey(app) Then
                Dim startTime As DateTime = gameStartTimes(app)
                Dim elapsedTime As TimeSpan = DateTime.Now - startTime

                closedApplications.Add(app)

                ' Insert or update the elapsed time in the database
                InsertOrUpdateGameTime(app, elapsedTime)

                LoadExistingGameTimes()
            End If
        Next

        ' Remove closed applications from the previousApplications and gameStartTimes dictionaries
        For Each app In closedApplications
            previousApplications.Remove(app)
            gameStartTimes.Remove(app)
        Next

        ' Update the tracker text in the UI
        If Not Me.IsDisposed Then
            BeginInvoke(Sub()
                            lblTracker.Text = trackerText.ToString().Replace(Environment.NewLine, "<br>")
                        End Sub)
        End If
    End Sub

    Private Function IsSystemProcess(proc As Process) As Boolean
        Dim systemProcesses As HashSet(Of String) = New HashSet(Of String)({"System", "Idle", "Settings"})
        Return systemProcesses.Contains(proc.ProcessName)
    End Function

    Private Function IsGame(proc As Process) As Boolean
        ' Check if the process name matches any known game titles
        Return knownGames.Contains(proc.ProcessName)
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Executable Files|*.exe"
            openFileDialog.Title = "Select a Game Executable"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Dim fileName As String = Path.GetFileNameWithoutExtension(filePath)

                If knownGames.Add(fileName) Then ' HashSet.Add returns false if item already exists
                    ' Add the game to the ListBox
                    ListBox1.Items.Add(fileName)

                    ' Insert the game into the database
                    InsertGame(fileName, filePath)
                End If
            End If
        End Using
    End Sub

    Private Sub InsertGame(gameName As String, gamePath As String)
        Dim insertGameQuery As String = "INSERT INTO game_paths (game_name, exe_path, UserID) VALUES (@gameName, @gamePath, @userID)"

        Using connection As MySqlConnection = Common.createDBConnection()
            Using insertGameCmd As New MySqlCommand(insertGameQuery, connection)
                insertGameCmd.Parameters.AddWithValue("@userID", userID)
                insertGameCmd.Parameters.AddWithValue("@gameName", gameName)
                insertGameCmd.Parameters.AddWithValue("@gamePath", gamePath)
                connection.Open()
                insertGameCmd.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub InsertOrUpdateGameTime(gameName As String, elapsedTime As TimeSpan)
        Dim getPathIdQuery As String = "SELECT path_id FROM game_paths WHERE game_name = @gameName"
        Dim pathId As Integer

        Using connection As MySqlConnection = Common.createDBConnection()
            Using getPathIdCmd As New MySqlCommand(getPathIdQuery, connection)
                getPathIdCmd.Parameters.AddWithValue("@gameName", gameName)
                connection.Open()
                pathId = Convert.ToInt32(getPathIdCmd.ExecuteScalar())
                connection.Close()
            End Using
        End Using

        Dim insertOrUpdateTimeQuery As String = "INSERT INTO game_time (UserID, path_id, hours) VALUES (@UserID, @pathId, @hours) " &
                                                "ON DUPLICATE KEY UPDATE hours = hours + @hours"

        Using connection As MySqlConnection = Common.createDBConnection()
            Using insertOrUpdateTimeCmd As New MySqlCommand(insertOrUpdateTimeQuery, connection)
                insertOrUpdateTimeCmd.Parameters.AddWithValue("@UserID", userID)
                insertOrUpdateTimeCmd.Parameters.AddWithValue("@pathId", pathId)
                insertOrUpdateTimeCmd.Parameters.AddWithValue("@hours", elapsedTime.TotalHours)
                connection.Open()
                insertOrUpdateTimeCmd.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub GetUserID()
        ' Assuming you have a way to get the username from frmMain
        Dim username As String = frmMain.lblUsername.Text
        Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

        Using connection As MySqlConnection = Common.createDBConnection()
            Using getUserIDCmd As New MySqlCommand(getUserIDQuery, connection)
                getUserIDCmd.Parameters.AddWithValue("@username", username)
                connection.Open()
                userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub LoadUserGames()
        Dim getUserGamesQuery As String = "SELECT game_name FROM game_paths"

        Using connection As MySqlConnection = Common.createDBConnection()
            Using getUserGamesCmd As New MySqlCommand(getUserGamesQuery, connection)
                connection.Open()
                Using reader As MySqlDataReader = getUserGamesCmd.ExecuteReader()
                    While reader.Read()
                        knownGames.Add(reader("game_name").ToString())
                    End While
                End Using
                connection.Close()
            End Using
        End Using
    End Sub

    Private Function FormatElapsedTime(totalElapsedTimeSeconds As Integer) As String
        Dim hours As Integer = totalElapsedTimeSeconds \ 3600
        Dim minutes As Integer = (totalElapsedTimeSeconds Mod 3600) \ 60
        Dim seconds As Integer = totalElapsedTimeSeconds Mod 60
        Return $"{hours:D2}:{minutes:D2}:{seconds:D2}"
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedGame As String = ListBox1.SelectedItem.ToString()

            ' Remove the game from the knownGames collection
            If knownGames.Remove(selectedGame) Then
                ' Remove the game from the ListBox
                ListBox1.Items.Remove(selectedGame)

                ' Delete the game from the database
                DeleteGameDetails(selectedGame)

                MessageBox.Show($"{selectedGame} has been deleted from the known games list.", "Game Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"{selectedGame} could not be found in the known games list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a game to delete.", "No Game Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteGameDetails(gameName As String)
        Dim deleteGameTimeQuery As String = "DELETE FROM game_time WHERE path_id IN (SELECT path_id FROM game_paths WHERE UserID = @UserID AND game_name = @game_name)"
        Dim deleteGamePathsQuery As String = "DELETE FROM game_paths WHERE UserID = @UserID AND game_name = @game_name"

        Using conn As MySqlConnection = Common.createDBConnection()
            conn.Open()

            Using deleteGameTimeCmd As New MySqlCommand(deleteGameTimeQuery, conn)
                deleteGameTimeCmd.Parameters.AddWithValue("@UserID", userID)
                deleteGameTimeCmd.Parameters.AddWithValue("@game_name", gameName)
                deleteGameTimeCmd.ExecuteNonQuery()
            End Using

            Using deleteGamePathsCmd As New MySqlCommand(deleteGamePathsQuery, conn)
                deleteGamePathsCmd.Parameters.AddWithValue("@UserID", userID)
                deleteGamePathsCmd.Parameters.AddWithValue("@game_name", gameName)
                deleteGamePathsCmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
