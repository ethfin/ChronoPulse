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
            Application.Exit()
        End If
    End Sub

    ' Handles the Click event of the btnMinimize control to minimize the form
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Handles the Click event of the btnLogin control to log in the user
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Using conn As MySqlConnection = Common.createDBConnection()
            Try
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @username AND password = @password"
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If result > 0 Then
                        frmMain.lblUsername.Text = Me.Username
                        frmMain.Show()
                        Me.Close()
                    Else
                        lblIncorrect.Text = "Invalid username or password."
                        lblIncorrect.Show()
                    End If
                End Using
            Catch ex As Exception
                lblIncorrect.Text = "Error: " & ex.Message
                lblIncorrect.Show()
            End Try
        End Using

        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    ' Handles the Click event of the btnSignUp control to show the sign-up form
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmSignUp.Show()
    End Sub

    ' Handles the CheckedChanged event of the cbxShowPassword control to toggle password visibility
    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(cbxShowPassword.Checked, "", "*")
    End Sub

    ' Handles the LinkClicked event of the lnklblSignUp control to show the sign-up form
    Private Sub lnklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignUp.LinkClicked
        Me.Hide()
        frmSignUp.Show()
    End Sub

    ' Handles the LinkClicked event of the lnklblReset control to show the reset account form
    Private Sub lnklblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblReset.LinkClicked
        Me.Hide()
        frmResetAccount.Show()
    End Sub

End Class
