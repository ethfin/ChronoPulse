Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

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

    Private Sub InsertUserData()
        ' Use the Common class to get the database connection
        Dim conn As MySqlConnection = Common.getDBConnectionX()

        Try
            ' Define the SQL INSERT statement
            ' Replace 'userTable' and column names with your actual table name and columns
            Dim sql As String = "INSERT INTO dbaccounts (username, password, email, firstName, lastName, securityQuestion1, securityQuestion2, securityAnswer1, securityAnswer2) VALUES (@username, @password, @email, @firstName, @lastName, @securityQuestion1, @securityQuestion2, @securityAnswer1, @securityAnswer2)"

            ' Create a new MySqlCommand using the SQL statement and connection
            Using command As New MySqlCommand(sql, conn)
                ' Add parameters to the command to prevent SQL injection
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                command.Parameters.AddWithValue("@lastName", txtLastName.Text)
                command.Parameters.AddWithValue("@email", txtEmail.Text)
                command.Parameters.AddWithValue("@password", txtPassword.Text) ' Consider hashing the password
                command.Parameters.AddWithValue("@username", txtUsername.Text)

                ' Open the connection
                conn.Open()

                ' Execute the command
                command.ExecuteNonQuery()

                ' Inform the user of success
                MessageBox.Show("Sign-up successful!")
            End Using
        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing Then
                conn.Close()
            End If
            Me.Close()
            frmLogin.Show()
        End Try
    End Sub

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
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Validate the input fields
        If ValidateInputFields() Then
            ' If validation is successful, proceed with the sign-up process
            ' (e.g., save the data to the database)
            InsertUserData()
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
                lblError.Text = "Password match and meets requirements."
            Else
                ' If the password does not meet complexity requirements, set the border color to Orange.
                txtPassword.BorderColor = Color.Orange
                txtReenterPassword.BorderColor = Color.Orange
                lblError.ForeColor = Color.Orange
                lblError.Text = "Password must be at least 8 characters with numbers and special characters."
            End If
            lblError.Show()
        Else
            ' If passwords don't match, set the border color to Red.
            txtPassword.BorderColor = Color.Red
            txtReenterPassword.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Password doesn't match."
            lblError.Show()
        End If
    End Sub

    ' Include the ValidatePassword function here.
    Function ValidatePassword(ByVal pwd As String) As Boolean
        ' Check the length.
        If Len(pwd) < 8 Then
            Return False
        End If

        ' Use regular expressions to check for numbers and special characters.
        Dim hasNumber As New Regex("[0-9]")
        Dim hasSpecial As New Regex("[^a-zA-Z0-9]")

        ' Check for minimum number of occurrences.
        If hasNumber.Matches(pwd).Count < 1 OrElse hasSpecial.Matches(pwd).Count < 1 Then
            Return False
        End If

        ' Passed all checks.
        Return True
    End Function

End Class