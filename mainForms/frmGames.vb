Imports System.Diagnostics
Imports System.Text
Imports System.Threading.Tasks

Public Class frmGames

    Private previousApplications As New Dictionary(Of String, DateTime)()

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Task.Run(AddressOf UpdateTracker)
    End Sub

    Private Sub UpdateTracker()
        Dim processes = Process.GetProcesses()
        Dim trackerText As New StringBuilder()
        Dim currentApplications As New Dictionary(Of String, DateTime)()

        For Each proc As Process In processes
            If Not String.IsNullOrEmpty(proc.MainWindowTitle) AndAlso Not IsSystemProcess(proc) Then
                Dim appTitle = proc.MainWindowTitle
                If Not currentApplications.ContainsKey(appTitle) Then
                    trackerText.AppendLine($"{appTitle}: Last active at {DateTime.Now:hh\:mm\:ss}")
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
                Invoke(Sub()
                           lblLoglastTime.Text &= $"{app} was last active at {lastActiveTime:hh\:mm\:ss}" & "<br>"
                       End Sub)
                closedApplications.Add(app)
            End If
        Next

        ' Remove closed applications from the previousApplications dictionary
        For Each app In closedApplications
            previousApplications.Remove(app)
        Next

        Invoke(Sub()
                   lblTracker.Text = trackerText.ToString().Replace(Environment.NewLine, "<br>")
               End Sub)
    End Sub

    Private Function IsSystemProcess(proc As Process) As Boolean
        Dim systemProcesses As String() = {"System", "Idle", "Settings"}
        Return systemProcesses.Contains(proc.ProcessName)
    End Function
End Class
