Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' Property to store the username of the logged-in user
    Public ReadOnly Property Username As String
        Get
            ' Return the username entered by the user
            Return txtUsername.Text
        End Get
    End Property

    ' Override the window procedure to handle custom window messages
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

    ' Constants for handling window dragging
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    ' Import the SendMessage function from user32.dll
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    ' Import the ReleaseCapture function from user32.dll
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    ' The MouseDown event for the panel to initiate the form dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogin.MouseDown, panelLogin2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    ' Handles the Click event of the btnClose control to close the application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Confirm before closing the application
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Closes the entire application
            Application.Exit()
        End If
    End Sub

    ' Handles the Click event of the btnMinimize control to minimize the form
    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Handles the Click event of the btnLogin control to log in the user
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Get the database connection
        Dim conn As MySqlConnection = Common.createDBConnection()

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to check if the user exists with the given username and password
            Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @username AND password = @password"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

            ' Use parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            ' Execute the query and get the result
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check if the user exists
            If result > 0 Then
                frmMain.lblUsername.Text = Me.Username
                frmMain.Show()
                Me.Close()
            Else
                lblIncorrect.Text = "Invalid username or password."
                lblIncorrect.Show()
            End If

        Catch ex As Exception
            ' Handle any errors that occur
            lblIncorrect.Text = "Error: " & ex.Message
            lblIncorrect.Show()
        Finally
            ' Close the connection whether or not an error occurred
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

        ' Clear the username and password fields
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
        If cbxShowPassword.Checked Then
            ' If the checkbox is checked, set the PasswordChar to an empty string to show the password
            txtPassword.PasswordChar = ""
        Else
            ' If the checkbox is unchecked, set the PasswordChar back to "*"
            txtPassword.PasswordChar = "*"
        End If
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

    ' Handles the Load event of the frmLogin control to set the initial focus
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Select()
    End Sub
End Class
