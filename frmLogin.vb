Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmLogin

    Public Property Username As String

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_MAXIMIZE Then
            Return
        End If

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

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogin.MouseDown, panelLogin2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Using conn As MySqlConnection = Common.getDBConnectionX()
            Try
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @username AND password = @password"
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If result > 0 Then
                        Me.Username = username
                        frmMain.Show()
                        conn.Close()
                        Me.Close()
                    Else
                        lblIncorrect.Text = "Invalid username or password."
                        lblIncorrect.Show()
                        conn.Close()
                    End If
                End Using
            Catch ex As Exception
                lblIncorrect.Text = "Error: " & ex.Message
                lblIncorrect.Show()
                conn.Close()
            End Try
        End Using

        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmSignUp.Show()
    End Sub

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(cbxShowPassword.Checked, "", "*")
    End Sub

    Private Sub lnklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignUp.LinkClicked
        Me.Hide()
        frmSignUp.Show()
    End Sub

    Private Sub lnklblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblReset.LinkClicked
        Me.Hide()
        frmResetAccount.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Select()
    End Sub
End Class
