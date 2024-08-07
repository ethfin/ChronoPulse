Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
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
        lblError.Text = "" ' Clear any previous error messages

        If txtPassword.Text = txtVerifyPassword.Text And txtPassword.Text <> "" Then
            If ValidatePassword(txtPassword.Text) Then
                Dim conn As MySqlConnection = Common.getDBConnectionX()
                Try
                    conn.Open()
                    Dim cmd As MySqlCommand = conn.CreateCommand
                    cmd.CommandText = "UPDATE dbaccounts SET password = @password WHERE email = @email"
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@email", frmResetAccountSecurity.lblWelcome1.Text)
                    cmd.ExecuteNonQuery()
                    lblError.Text = "Password has been reset successfully."
                    lblError.ForeColor = Color.Green
                    lblError.Show()
                    frmLogin.Show()
                    frmResetAccount.Close()
                    frmResetAccountSecurity.Close()
                    Me.Close()
                Catch ex As Exception
                    lblError.Text = "An error occurred while resetting the password. Please try again."
                    lblError.ForeColor = Color.Red
                    lblError.Show()
                Finally
                    conn.Close()
                End Try
            Else
                lblError.Text = "Password does not meet the complexity requirements. Please try again."
                lblError.ForeColor = Color.Red
                lblError.Show()
            End If
        Else
            lblError.Text = "Passwords do not match or are empty. Please try again."
            lblError.ForeColor = Color.Red
            lblError.Show()
        End If
    End Sub

    'minimize the form
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'close the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the other active form if it is open
        If frmLogin IsNot Nothing AndAlso Not frmLogin.IsDisposed Then
            frmLogin.Close()
        End If

        ' Ask for confirmation before closing the form
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Close the current form
            frmMain.Close()
            Application.Exit()
        End If
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

    ' TextChanged event handlers for password fields
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ComparePasswords()
    End Sub

    Private Sub txtVerifyPassword_TextChanged(sender As Object, e As EventArgs) Handles txtVerifyPassword.TextChanged
        ComparePasswords()
    End Sub

    Private Sub ComparePasswords()
        ' First, check if the passwords match.
        If txtPassword.Text = txtVerifyPassword.Text Then
            ' Next, validate the password complexity.
            If ValidatePassword(txtPassword.Text) Then
                ' If the password is complex enough, set the border color to Green.
                txtPassword.BorderColor = Color.Green
                txtVerifyPassword.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Password matches and meets requirements."
            Else
                ' If the password does not meet complexity requirements, set the border color to Red.
                txtPassword.BorderColor = Color.Red
                txtVerifyPassword.BorderColor = Color.Red
                lblError.ForeColor = Color.Red
                lblError.Text = "Password must be at least 8 characters, contain numbers, and special characters, and should not include : ; "" ' / \\."
            End If
        Else
            ' If passwords don't match, set the border color to Red.
            txtPassword.BorderColor = Color.Red
            txtVerifyPassword.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Passwords do not match."
        End If
        lblError.Show()
    End Sub

    Function ValidatePassword(ByVal pwd As String) As Boolean
        ' Check the length.
        If Len(pwd) < 8 Then
            Return False
        End If

        ' Use regular expressions to check for numbers, letters, special characters, and invalid characters.
        Dim hasNumber As New Regex("[0-9]")
        Dim hasLetter As New Regex("[a-zA-Z]")
        Dim hasSpecial As New Regex("[^a-zA-Z0-9]")
        Dim invalidChars As New Regex("[ :;""'/\\]")

        ' Check for minimum number of occurrences.
        If hasNumber.Matches(pwd).Count < 1 OrElse hasLetter.Matches(pwd).Count < 1 OrElse hasSpecial.Matches(pwd).Count < 1 Then
            Return False
        End If

        ' Check for invalid characters.
        If invalidChars.Matches(pwd).Count > 0 Then
            Return False
        End If

        ' Passed all checks.
        Return True
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmResetAccountSecurity.Show()
        Me.Close()
    End Sub

    Private Sub frmResetAccountPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Select()
    End Sub
End Class