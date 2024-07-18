Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmResetAccountPassword

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Define the Windows message constant for system commands
        Const WM_SYSCOMMAND As Integer = &H112
        ' Define the command value for maximizing the window
        Const SC_MAXIMIZE As Integer = &HF030

        ' Check if the message is a system command
        If m.Msg = WM_SYSCOMMAND Then
            ' Check if the command is to maximize the window
            If m.WParam.ToInt32() = SC_MAXIMIZE Then
                ' Prevent the default behavior by not calling the base method
                Return
            End If
        End If

        ' Call the base class method for default processing of other messages
        MyBase.WndProc(m)
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    ' The MouseDown event for the panel to initiate the form dragging.
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogin1.MouseDown, panelLogin2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtPassword.Text = txtVerifyPassword.Text And txtPassword.Text <> "" Then
            Dim conn As MySqlConnection = Common.getDBConnectionX()
            Try
                conn.Open()
                Dim cmd As MySqlCommand = conn.CreateCommand
                cmd.CommandText = "UPDATE dbaccounts SET password = @password WHERE email = @email"
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@email", frmResetAccountSecurity.lblWelcome1.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmLogin.Show()
            Catch ex As Exception
                MessageBox.Show("An error occurred while resetting the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Passwords do not match or are empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'minimize the form
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'close the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    'show password for txtPassword
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    'show password for txtVerifyPassword
    Private Sub chkShowVerifyPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        If chkShowPassword2.Checked Then
            txtVerifyPassword.PasswordChar = ""
        Else
            txtVerifyPassword.PasswordChar = "*"
        End If
    End Sub
End Class