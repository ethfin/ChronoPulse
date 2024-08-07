Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' Constants for handling window dragging
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    ' Import the SendMessage function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    ' Import the ReleaseCapture function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    ' Property to store the username of the logged-in user
    Public ReadOnly Property Username As String
        Get
            Return txtUsername.Text
        End Get
    End Property

    ' Override the window procedure to handle custom window messages
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_MAXIMIZE Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    ' Handles the Load event of the frmLogin control to set the initial focus
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Select()
    End Sub

    ' The MouseDown event for the panel to initiate the form dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogin.MouseDown, panelLogin2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    ' Handles the Click event of the btnClose control to close the application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmMain.Close()
            Application.Exit()
        End If
    End Sub

    ' Handles the Click event of the btnMinimize control to minimize the form
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Handles the Click event of the btnLogin control to log in the user
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the username and password from the text boxes
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Create a MySqlConnection object using the createDBConnection method from the Common class
        Using conn As MySqlConnection = Common.createDBConnection()
            Try
                ' Open the database connection
                conn.Open()

                ' Create a SQL query to check if the username and password exist in the database
                Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @username AND password = @password"

                ' Create a MySqlCommand object with the query and connection
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    ' Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    ' Execute the query and get the result as an integer
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' If the result is greater than 0, the username and password are valid
                    If result > 0 Then
                        ' Set the username label in the frmMain form to the logged-in username
                        frmMain.lblUsername.Text = Me.Username
                        ' Show the system tray icon
                        frmMain.notifyIcon.Visible = True
                        ' Restore the frmMain form to its previous size and location
                        frmMain.WindowState = FormWindowState.Normal
                        frmMain.ShowInTaskbar = True
                        ' Change the panel to the dashboard
                        frmMain.changePanel(frmDashboard)
                        ' Show the frmMain form
                        frmMain.Show()
                        ' Close the frmLogin form
                        Me.Close()
                    Else
                        ' Display an error message if the username or password is invalid
                        lblIncorrect.Text = "Invalid username or password."
                        lblIncorrect.Show()
                    End If
                End Using
            Catch ex As Exception
                ' Display an error message if there is an exception during the database operation
                lblIncorrect.Text = "Error: " & ex.Message
                lblIncorrect.Show()
            End Try
        End Using

        ' Clear the text boxes after the login attempt
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    ' Handles the Click event of the btnSignUp control to show the sign-up form
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        ' Hide the frmLogin form
        Me.Hide()
        ' Show the frmSignUp form
        frmSignUp.Show()
    End Sub

    ' Handles the CheckedChanged event of the cbxShowPassword control to toggle password visibility
    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        ' If the checkbox is checked, show the password as plain text
        ' Otherwise, hide the password with asterisks
        txtPassword.PasswordChar = If(cbxShowPassword.Checked, "", "*")
    End Sub

    ' Handles the LinkClicked event of the lnklblSignUp control to show the sign-up form
    Private Sub lnklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignUp.LinkClicked
        ' Hide the frmLogin form
        Me.Hide()
        ' Show the frmSignUp form
        frmSignUp.Show()
    End Sub

    ' Handles the LinkClicked event of the lnklblReset control to show the reset account form
    Private Sub lnklblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblReset.LinkClicked
        ' Hide the frmLogin form
        Me.Hide()
        ' Show the frmResetAccount form
        frmResetAccount.Show()
    End Sub

End Class
