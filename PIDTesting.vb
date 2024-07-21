Public Class PIDTesting
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add your application names to the ComboBox
        cmbApplications.Items.Add("notepad")
        cmbApplications.Items.Add("Calculator")
        cmbApplications.Items.Add("Steam")
        ' Add more applications as needed
    End Sub

    Private appStartTime As DateTime

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim selectedApp As String = cmbApplications.SelectedItem.ToString()
        Dim processes() As Process = Process.GetProcessesByName(selectedApp)

        If processes.Length > 0 Then
            Dim pid As Integer = processes(0).Id
            appStartTime = DateTime.Now
            lblElapsedTime.Text = "Application PID: " & pid & " started at: " & appStartTime.ToString()
            timerAppCheck.Start()
        Else
            MessageBox.Show("Application is not running.")
        End If
    End Sub

    Private Sub timerAppCheck_Tick(sender As Object, e As EventArgs) Handles timerAppCheck.Tick
        Dim selectedApp As String = cmbApplications.SelectedItem.ToString()
        Dim processes() As Process = Process.GetProcessesByName(selectedApp)

        If processes.Length > 0 Then
            Dim elapsed As TimeSpan = DateTime.Now - appStartTime
            lblElapsedTime.Text = "Elapsed Time: " & elapsed.ToString("hh\:mm\:ss")
        Else
            timerAppCheck.Stop()
            MessageBox.Show("Application has exited.")
        End If
    End Sub


End Class