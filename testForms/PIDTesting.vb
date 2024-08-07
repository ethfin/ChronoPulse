Imports System.Diagnostics
Imports System.IO

Public Class PIDTesting
    Private appStartTime As DateTime
    Private selectedProcess As Process
    Private Const lastAppPathFile As String = "lastAppPath.txt"

    Private Sub PIDTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the ListBox
        lstRunningApps.Items.Clear()

        ' Add global exception handlers
        AddHandler Application.ThreadException, AddressOf Application_ThreadException
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

        ' Check if there is a previously saved application path
        If File.Exists(lastAppPathFile) Then
            Dim lastAppPath As String = File.ReadAllText(lastAppPathFile)
            If Not String.IsNullOrWhiteSpace(lastAppPath) Then
                ' Check if the previously run application is still running
                StartApplication(lastAppPath, autoStart:=True)
            End If
        End If
    End Sub

    Private Sub StartApplication(selectedApp As String, Optional autoStart As Boolean = False)
        Try
            Dim processName As String = Path.GetFileNameWithoutExtension(selectedApp)
            Dim processes() As Process = Process.GetProcessesByName(processName)

            If processes.Length = 0 And Not autoStart Then
                ' Configure process start information
                Dim startInfo As New ProcessStartInfo() With {
                    .FileName = selectedApp,
                    .WorkingDirectory = Path.GetDirectoryName(selectedApp),
                    .UseShellExecute = True, ' UseShellExecute mimics the behavior of launching manually
                    .WindowStyle = ProcessWindowStyle.Normal ' Open with a normal window
                }

                ' Launch the application
                selectedProcess = Process.Start(startInfo)
                File.WriteAllText(lastAppPathFile, selectedApp) ' Save the path of the executable
                MessageBox.Show("Application launched successfully.")
                appStartTime = DateTime.Now
                lblElapsedTime.Text = "Application PID: " & selectedProcess.Id & " started at: " & appStartTime.ToString()
                AddRunningAppToList(selectedProcess) ' Add to list of running apps
                timerAppCheck.Start()
            ElseIf processes.Length > 0 Then
                ' Handle running instances
                Dim processFound As Boolean = False
                For Each process In processes
                    If process.MainWindowTitle.Contains(processName) OrElse selectedProcess Is Nothing Then
                        selectedProcess = process
                        appStartTime = DateTime.Now
                        lblElapsedTime.Text = "Application PID: " & selectedProcess.Id & " detected as running at: " & appStartTime.ToString()
                        AddRunningAppToList(selectedProcess) ' Add to list of running apps
                        timerAppCheck.Start()
                        processFound = True
                        Exit For
                    End If
                Next

                If Not processFound Then
                    MessageBox.Show("No matching application window found.")
                End If
            End If

            ' Attach an Exited event handler to the process
            If selectedProcess IsNot Nothing Then
                AddHandler selectedProcess.Exited, AddressOf Process_Exited
                selectedProcess.EnableRaisingEvents = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error starting application: " & ex.Message)
        End Try
    End Sub

    Private Sub Process_Exited(sender As Object, e As EventArgs)
        ' Handle process exit event
        Dim exitedProcess As Process = CType(sender, Process)
        MessageBox.Show($"Application with PID {exitedProcess.Id} has exited.")

        ' Stop the timer and update the list
        timerAppCheck.Stop()
        If lstRunningApps.Items.Contains($"{exitedProcess.ProcessName} (PID: {exitedProcess.Id})") Then
            lstRunningApps.Items.Remove($"{exitedProcess.ProcessName} (PID: {exitedProcess.Id})")
        End If
        selectedProcess = Nothing
    End Sub

    Private Sub AddRunningAppToList(process As Process)
        ' Add the application to the ListBox
        Dim entry As String = $"{process.ProcessName} (PID: {process.Id})"
        If Not lstRunningApps.Items.Contains(entry) Then
            lstRunningApps.Items.Add(entry)
        End If
    End Sub

    Private Sub timerAppCheck_Tick(sender As Object, e As EventArgs) Handles timerAppCheck.Tick
        Try
            If selectedProcess IsNot Nothing AndAlso Not selectedProcess.HasExited Then
                Dim elapsed As TimeSpan = DateTime.Now - appStartTime
                lblElapsedTime.Text = "Elapsed Time: " & elapsed.ToString("hh\:mm\:ss")
            Else
                timerAppCheck.Stop()
                MessageBox.Show("Application has exited.")
                If selectedProcess IsNot Nothing Then
                    lstRunningApps.Items.Remove($"{selectedProcess.ProcessName} (PID: {selectedProcess.Id})")
                End If
                ' Reset selectedProcess to avoid further checks on a dead process
                selectedProcess = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error during timer check: " & ex.Message)
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*"
            openFileDialog.Title = "Select an Application to Run"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim selectedApp As String = openFileDialog.FileName
                StartApplication(selectedApp)
            End If
        End Using
    End Sub

    Private Sub Application_ThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
        MessageBox.Show("An error occurred: " & e.Exception.Message)
    End Sub

    Private Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        MessageBox.Show("A fatal error occurred: " & CType(e.ExceptionObject, Exception).Message)
    End Sub
End Class
