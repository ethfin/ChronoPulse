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

        ' Add handler for form closing event
        AddHandler Me.FormClosing, AddressOf frmGames_FormClosing
    End Sub

    Private Sub frmGames_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Log and update game time for any running games
        UpdateTracker()
    End Sub

    Private Sub LoadExistingGameTimes()
        Dim getElapsedTimeQuery As String = "SELECT gp.game_name, SUM(gt.hours) AS total_hours " &
                                            "FROM game_time gt " &
                                            "JOIN game_paths gp ON gt.path_id = gp.path_id " &
                                            "WHERE gt.UserID = @UserID " &
                                            "GROUP BY gp.game_name"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using getElapsedTimeCmd As New MySqlCommand(getElapsedTimeQuery, conn)
                getElapsedTimeCmd.Parameters.AddWithValue("@UserID", userID)
                conn.Open()
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
                conn.Close()
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
                    ListBox1.Items.Add(fileName) ' Add the game to ListBox1

                    ' Insert the game details into the database
                    InsertGameDetails(fileName, filePath)

                    MessageBox.Show($"{fileName} has been added to the known games list.", "Game Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"{fileName} is already in the known games list.", "Duplicate Game", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End Using
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

    Private Sub InsertGameDetails(gameName As String, exePath As String)
        Dim insertQuery As String = "INSERT INTO game_paths (UserID, game_name, exe_path, date_added) VALUES (@UserID, @game_name, @exe_path, @date_added)"

        Using conn As MySqlConnection = Common.createDBConnection()
            Using insertCmd As New MySqlCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@UserID", userID)
                insertCmd.Parameters.AddWithValue("@game_name", gameName)
                insertCmd.Parameters.AddWithValue("@exe_path", exePath)
                insertCmd.Parameters.AddWithValue("@date_added", DateTime.Now)

                conn.Open()
                insertCmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub InsertGameTime(gameName As String, elapsedTime As TimeSpan)
        Dim pathID As Integer = GetPathID(gameName)
        Dim elapsedTimeSeconds As Integer = Convert.ToInt32(elapsedTime.TotalSeconds)
        Dim insertQuery As String = "INSERT INTO game_time (UserID, path_id, hours, date) VALUES (@UserID, @path_id, @hours, @date)"

        Using insertCmd As New MySqlCommand(insertQuery, Common.getDBConnectionX())
            insertCmd.Parameters.AddWithValue("@UserID", userID)
            insertCmd.Parameters.AddWithValue("@path_id", pathID)
            insertCmd.Parameters.AddWithValue("@hours", elapsedTimeSeconds)
            insertCmd.Parameters.AddWithValue("@date", DateTime.Now)

            Common.getDBConnectionX().Open()
            insertCmd.ExecuteNonQuery()
            Common.getDBConnectionX().Close()
        End Using
    End Sub

    Private Function GetPathID(gameName As String) As Integer
        Dim getPathIDQuery As String = "SELECT path_id FROM game_paths WHERE UserID = @UserID AND game_name = @game_name"
        Dim pathID As Integer

        Using conn As MySqlConnection = Common.createDBConnection()
            Using getPathIDCmd As New MySqlCommand(getPathIDQuery, conn)
                getPathIDCmd.Parameters.AddWithValue("@UserID", userID)
                getPathIDCmd.Parameters.AddWithValue("@game_name", gameName)
                conn.Open()
                pathID = Convert.ToInt32(getPathIDCmd.ExecuteScalar())
                conn.Close()
            End Using
        End Using

        Return pathID
    End Function

    Private Function FormatElapsedTime(seconds As Integer) As String
        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(seconds)
        Return $"{timeSpan:hh\:mm\:ss}"
    End Function

    Private Sub UpdateLogLastTime()
        Dim getElapsedTimeQuery As String = "SELECT gp.game_name, gt.hours " &
                                        "FROM game_time gt " &
                                        "JOIN game_paths gp ON gt.path_id = gp.path_id " &
                                        "WHERE gt.UserID = @UserID " &
                                        "ORDER BY gt.date DESC LIMIT 1"

        Using getElapsedTimeCmd As New MySqlCommand(getElapsedTimeQuery, Common.getDBConnectionX())
            getElapsedTimeCmd.Parameters.AddWithValue("@UserID", userID)
            Common.getDBConnectionX().Open()
            Using reader As MySqlDataReader = getElapsedTimeCmd.ExecuteReader()
                If reader.Read() Then
                    Dim gameName As String = reader("game_name").ToString()
                    Dim elapsedTimeSeconds As Integer = Convert.ToInt32(reader("hours"))
                    Dim formattedElapsedTime As String = FormatElapsedTime(elapsedTimeSeconds)

                    If Not Me.IsDisposed Then
                        BeginInvoke(Sub()
                                        lblLoglastTime.Text = String.Empty ' Clear the label text
                                        lblLoglastTime.Text &= $"{gameName}: Elapsed Time {formattedElapsedTime}" & "<br>"
                                    End Sub)
                    End If
                End If
            End Using
            Common.getDBConnectionX().Close()
        End Using
    End Sub

    Private Sub InsertOrUpdateGameTime(gameName As String, elapsedTime As TimeSpan)
        Dim pathID As Integer = GetPathID(gameName)
        Dim elapsedTimeSeconds As Integer = Convert.ToInt32(elapsedTime.TotalSeconds)

        ' Check if a record already exists
        Dim existingTime As Integer = GetExistingElapsedTime(pathID)

        If existingTime > 0 Then
            ' Update the existing record
            Dim updateQuery As String = "UPDATE game_time SET hours = hours + @hours, date = @date WHERE UserID = @UserID AND path_id = @path_id"

            Using updateCmd As New MySqlCommand(updateQuery, Common.getDBConnectionX())
                updateCmd.Parameters.AddWithValue("@UserID", userID)
                updateCmd.Parameters.AddWithValue("@path_id", pathID)
                updateCmd.Parameters.AddWithValue("@hours", elapsedTimeSeconds)
                updateCmd.Parameters.AddWithValue("@date", DateTime.Now)

                Common.getDBConnectionX().Open()
                updateCmd.ExecuteNonQuery()
                Common.getDBConnectionX().Close()
            End Using
        Else
            ' Insert a new record
            Dim insertQuery As String = "INSERT INTO game_time (UserID, path_id, hours, date) VALUES (@UserID, @path_id, @hours, @date)"

            Using insertCmd As New MySqlCommand(insertQuery, Common.getDBConnectionX())
                insertCmd.Parameters.AddWithValue("@UserID", userID)
                insertCmd.Parameters.AddWithValue("@path_id", pathID)
                insertCmd.Parameters.AddWithValue("@hours", elapsedTimeSeconds)
                insertCmd.Parameters.AddWithValue("@date", DateTime.Now)

                Common.getDBConnectionX().Open()
                insertCmd.ExecuteNonQuery()
                Common.getDBConnectionX().Close()
            End Using
        End If
    End Sub

    Private Function GetExistingElapsedTime(pathID As Integer) As Integer
        Dim getElapsedTimeQuery As String = "SELECT SUM(hours) FROM game_time WHERE UserID = @UserID AND path_id = @path_id"
        Dim existingTime As Integer = 0

        Using getElapsedTimeCmd As New MySqlCommand(getElapsedTimeQuery, Common.getDBConnectionX())
            getElapsedTimeCmd.Parameters.AddWithValue("@UserID", userID)
            getElapsedTimeCmd.Parameters.AddWithValue("@path_id", pathID)
            Common.getDBConnectionX().Open()
            Dim result = getElapsedTimeCmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                existingTime = Convert.ToInt32(result)
            End If
            Common.getDBConnectionX().Close()
        End Using

        Return existingTime
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

        Using conn As MySqlConnection = Common.getDBConnectionX()
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
