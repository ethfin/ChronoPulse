Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class frmSignUp
    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.Checked Then
            ' If the checkbox is checked, set the PasswordChar to an empty string to show the password
            txtPassword.PasswordChar = ""
            txtReenterPassword.PasswordChar = ""
        Else
            ' If the checkbox is unchecked, set the PasswordChar back to "*"
            txtPassword.PasswordChar = "*"
            txtReenterPassword.PasswordChar = "*"
        End If
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
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBackground.MouseDown, pnlSignUp.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

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

    Private Function ValidateInputFields() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtReenterPassword.Text) Then

            MessageBox.Show("Please fill in all fields.")
            Return False

        End If

        ' Check if the passwords match
        If Not txtPassword.Text.Equals(txtReenterPassword.Text) Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        ' Add more validation as needed (e.g., email format, password strength)

        ' If all validations pass
        Return True
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Confirm before closing the application.
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Closes the entire application.
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub htmllblBackToLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles htmllblBackToLogin.LinkClicked
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Validate the input fields
        If ValidateInputFields() AndAlso emailValid() AndAlso ValidatePassword(txtPassword.Text) Then
            ' Check if the username or email already exists
            If CheckExistingUser(txtUsername.Text, txtEmail.Text) Then
                Return
            End If

            Me.Hide()
            frmSecurityQuestions.Show()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ComparePasswords()
    End Sub

    Private Sub txtReenterPassword_TextChanged(sender As Object, e As EventArgs) Handles txtReenterPassword.TextChanged
        ComparePasswords()
    End Sub

    Private Sub ComparePasswords()
        ' First, check if the passwords match.
        If txtPassword.Text = txtReenterPassword.Text Then
            ' Next, validate the password complexity.
            If ValidatePassword(txtPassword.Text) Then
                ' If the password is complex enough, set the border color to Green.
                txtPassword.BorderColor = Color.Green
                txtReenterPassword.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Password matches and meets requirements."
            Else
                ' If the password does not meet complexity requirements, set the border color to Orange.
                txtPassword.BorderColor = Color.Orange
                txtReenterPassword.BorderColor = Color.Orange
                lblError.ForeColor = Color.Orange
                lblError.Text = "Password must be at least 8 characters, contain numbers, and special characters, and should not include : ; "" ' / \\."
            End If
        Else
            ' If passwords don't match, set the border color to Red.
            txtPassword.BorderColor = Color.Red
            txtReenterPassword.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Passwords do not match."
        End If
        lblError.Show()
    End Sub


    ' Include the ValidatePassword function here.
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

    Private Sub lblError_Click(sender As Object, e As EventArgs) Handles lblError.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailValid()
    End Sub

    Function emailValid() As Boolean
        ' Using regular expressions to check if the email is valid
        Dim emailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            lblErrorEmail.Text = "Fill in the field"
            lblErrorEmail.ForeColor = Color.Orange
            txtEmail.BorderColor = Color.Orange
            lblErrorEmail.Show() ' Show the email error label
            Return False
        End If

        If Regex.IsMatch(txtEmail.Text, emailPattern) Then
            lblErrorEmail.Text = "Valid Input"
            lblErrorEmail.ForeColor = Color.Green
            txtEmail.BorderColor = Color.Green
            lblErrorEmail.Show() ' Show the email error label
            Return True
        Else
            lblErrorEmail.Text = "Please enter a valid email"
            lblErrorEmail.ForeColor = Color.Red
            txtEmail.BorderColor = Color.Red
            lblErrorEmail.Show() ' Show the email error label
            Return False
        End If
    End Function


    Private Function CheckExistingUser(username As String, email As String) As Boolean
        ' Use the getDBConnectionX method from Common.vb to get the database connection
        Dim connection As MySqlConnection = Common.getDBConnectionX()

        ' SQL query to check if the username or email already exists
        Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @Username OR email = @Email"

        ' Create a MySqlCommand object with the query and connection
        Using command As New MySqlCommand(query, connection)
            ' Add parameters to the query to prevent SQL injection
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Email", email)

            ' Open the database connection
            connection.Open()

            ' Execute the query and get the result
            Dim count As Integer = CInt(command.ExecuteScalar())

            ' Check if the count is greater than 0, indicating that the username or email already exists
            If count > 0 Then
                lblError.Text = "Error: Username or email has already been taken."
                lblError.ForeColor = Color.Red
                lblError.Show()
                connection.Close()
                Return True
            End If
        End Using

        Return False
    End Function
End Class