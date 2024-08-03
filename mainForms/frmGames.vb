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
                Dim appTitle = proc.MainWindowTitle
                If Not currentApplications.ContainsKey(appTitle) Then
                    Dim elapsedTime = DateTime.Now - proc.StartTime
                    trackerText.AppendLine($"{appTitle}: {elapsedTime:hh\:mm\:ss}")
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
                Dim lastActiveTime = previousApplications(app)
                lblLoglastTime.Text &= $"{app} was last active at {lastActiveTime:hh\:mm\:ss}" & "<br>"
                closedApplications.Add(app)
            End If
        Next

        For Each app In closedApplications
            previousApplications.Remove(app)
        Next

        lblTracker.Text = trackerText.ToString().Replace(Environment.NewLine, "<br>")
    End Sub

    Private Function IsSystemProcess(proc As Process) As Boolean
        Dim systemProcesses As String() = {"System", "Idle", "Settings"}
        Return systemProcesses.Contains(proc.ProcessName)
    End Function
End Class
