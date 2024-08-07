Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmResetAccount
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Function ValidateInputFields() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then

            MessageBox.Show("Please fill in the fields.")
            Return False

        End If

        ' Add more validation as needed (e.g., email format, password strength)

        ' If all validations pass
        Return True
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Validate the input fields
        If ValidateInputFields() AndAlso emailValid() Then
            Me.Hide()
            frmResetAccountSecurity.SetEmail(txtEmail.Text)
            frmResetAccountSecurity.Show()
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailValid()
    End Sub

    Function emailValid() As Boolean
        ' Using regular expressions to check if the email is valid
        Dim emailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            lblErrorEmail.Text = "Fill in the field"
            lblErrorEmail.ForeColor = Color.Red
            txtEmail.BorderColor = Color.Red
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Confirm before closing the application.
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Closes the entire application.
            frmMain.Close()
            Application.Exit()
        End If
    End Sub

    Private Function CheckExistingUser(email As String) As Boolean
        ' Use the getDBConnectionX method from Common.vb to get the database connection
        Dim connection As MySqlConnection = Common.getDBConnectionX()

        ' SQL query to check if the email already exists
        Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE email = @Email"

        ' Create a MySqlCommand object with the query and connection
        Using command As New MySqlCommand(query, connection)
            ' Add parameters to the query to prevent SQL injection
            command.Parameters.AddWithValue("@Email", email)

            ' Open the database connection
            connection.Open()

            ' Execute the query and get the result
            Dim count As Integer = CInt(command.ExecuteScalar())

            ' Check if the count is greater than 0, indicating that the email already exists
            If count > 0 Then
                lblErrorEmail.Text = "Email exists."
                lblErrorEmail.ForeColor = Color.Green
                lblErrorEmail.Show()
                connection.Close()
                Return True
            Else
                lblErrorEmail.Text = "Email does not exist."
                lblErrorEmail.ForeColor = Color.Red
                lblErrorEmail.Show()
                connection.Close()
                Return False
            End If
        End Using
    End Function

    Private Sub txtEmail_Load(sender As Object, e As EventArgs) Handles txtEmail.Load
        txtEmail.Select()
    End Sub
End Class