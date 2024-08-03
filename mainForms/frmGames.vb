Imports System.Diagnostics
Imports System.Text

Public Class frmGames

    Private previousApplications As New Dictionary(Of String, DateTime)()

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        AddHandler Timer1.Tick, AddressOf UpdateTracker
    End Sub

    Private Sub UpdateTracker(sender As Object, e As EventArgs)
        Dim processes = Process.GetProcesses()
        Dim trackerText As New StringBuilder()
        Dim currentApplications As New Dictionary(Of String, DateTime)()

        For Each proc As Process In processes
            If Not String.IsNullOrEmpty(proc.MainWindowTitle) AndAlso Not IsSystemProcess(proc) Then
                If Not currentApplications.ContainsKey(proc.MainWindowTitle) Then
                    Dim elapsedTime = DateTime.Now - proc.StartTime
                    trackerText.AppendLine($"{proc.MainWindowTitle}: {elapsedTime:hh\:mm\:ss}")
                    currentApplications(proc.MainWindowTitle) = DateTime.Now

                    ' Update the last active time for the running application
                    previousApplications(proc.MainWindowTitle) = DateTime.Now
                End If
            End If
        Next

        ' Check for closed applications
        For Each app In previousApplications.Keys.ToList()
            If Not currentApplications.ContainsKey(app) Then
                Dim lastActiveTime = previousApplications(app)
                lblLoglastTime.Text &= $"{app} was last active at {lastActiveTime:hh\:mm\:ss}" & "<br>"
                previousApplications.Remove(app) ' Remove the closed application from tracking
            End If
        Next

        lblTracker.Text = trackerText.ToString().Replace(Environment.NewLine, "<br>") ' Ensure new lines in the label text
    End Sub

    Private Function IsSystemProcess(proc As Process) As Boolean
        ' Add logic to filter out system processes or background applications
        ' For example, you can filter out processes with no main window title or specific known system processes
        Dim systemProcesses As String() = {"System", "Idle", "Settings"}
        Return systemProcesses.Contains(proc.ProcessName)
    End Function
End Class
