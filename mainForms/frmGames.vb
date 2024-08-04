Imports System.Diagnostics
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Public Class frmGames

    Private previousApplications As New Dictionary(Of String, DateTime)()
    Private knownGames As New HashSet(Of String)() ' Use HashSet for faster lookups
    Private gameStartTimes As New Dictionary(Of String, DateTime)()

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        ' Populate ListBox1 with known games
        ListBox1.Items.AddRange(knownGames.ToArray())
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Task.Run(AddressOf UpdateTracker)
    End Sub

    Private Sub UpdateTracker()
        Dim processes = Process.GetProcesses()
        Dim trackerText As New StringBuilder()
        Dim currentApplications As New Dictionary(Of String, DateTime)()

        For Each proc As Process In processes
            If Not String.IsNullOrEmpty(proc.MainWindowTitle) AndAlso Not IsSystemProcess(proc) AndAlso IsGame(proc) Then
                Dim appTitle = proc.MainWindowTitle
                If Not currentApplications.ContainsKey(appTitle) Then
                    ' Set the start time for the game session if not already set
                    If Not gameStartTimes.ContainsKey(appTitle) Then
                        gameStartTimes(appTitle) = DateTime.Now
                    End If

                    ' Calculate the elapsed time
                    Dim startTime As DateTime = gameStartTimes(appTitle)
                    Dim elapsedTime As TimeSpan = DateTime.Now - startTime

                    trackerText.AppendLine($"{appTitle}: Elapsed Time {elapsedTime:hh\:mm\:ss}")
                    currentApplications(appTitle) = DateTime.Now

                    ' Update the last active time for the running application
                    previousApplications(appTitle) = DateTime.Now
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

                ' Update the UI with the closed application information
                Invoke(Sub()
                           lblLoglastTime.Text &= $"{app}: Elapsed Time {elapsedTime:hh\:mm\:ss}" & "<br>"
                       End Sub)
            End If
        Next

        ' Remove closed applications from the previousApplications and gameStartTimes dictionaries
        For Each app In closedApplications
            previousApplications.Remove(app)
            gameStartTimes.Remove(app)
        Next

        ' Update the tracker text in the UI

        If Not Me.IsDisposed Then
            Invoke(Sub()
                       lblTracker.Text = trackerText.ToString().Replace(Environment.NewLine, "<br>")
                   End Sub)
        End If
    End Sub

    Private Function IsSystemProcess(proc As Process) As Boolean
        Dim systemProcesses As HashSet(Of String) = New HashSet(Of String)({"System", "Idle", "Settings"})
        Return systemProcesses.Contains(proc.ProcessName)
    End Function

    Private Function IsGame(proc As Process) As Boolean
        ' Check if the process title or name matches any known game titles
        Return knownGames.Any(Function(game) proc.MainWindowTitle.Contains(game) OrElse proc.ProcessName.Contains(game))
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

                    ' Extract the icon from the executable file
                    Dim icon As Icon = Icon.ExtractAssociatedIcon(filePath)
                    If icon IsNot Nothing Then
                        ' Convert the icon to an image and display it in the PictureBox
                        picBox.Image = icon.ToBitmap()
                    End If

                    MessageBox.Show($"{fileName} has been added to the known games list.", "Game Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"{fileName} is already in the known games list.", "Duplicate Game", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End Using
    End Sub
End Class
