Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class frmSecurityQuestions
    Private Sub frmSecurityQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub cmbSQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSQ1.SelectedIndexChanged
        ' Check if cmbSQ2 has the same selected item as cmbSQ1
        If cmbSQ1.SelectedItem IsNot Nothing AndAlso cmbSQ1.SelectedItem.Equals(cmbSQ2.SelectedItem) Then
            MessageBox.Show("This item is already selected in cmbSQ2. Please choose a different item.")
            ' Optionally, reset the selection
            cmbSQ1.SelectedIndex = -1 ' or set it to the default value
        End If
    End Sub

    Private Function ValidateInputFields() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(cmbSQ1.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSQ2.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA1.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA1Verify.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA2.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA2Verify.Text) Then

            MessageBox.Show("Please fill in all fields.")
            Return False

        End If
        Return True
    End Function

    Private Sub cmbSQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSQ2.SelectedIndexChanged

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If ValidateInputFields() Then
            InsertUserData()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

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
                command.Parameters.AddWithValue("@firstName", frmSignUp.txtFirstName.Text)
                command.Parameters.AddWithValue("@lastName", frmSignUp.txtLastName.Text)
                command.Parameters.AddWithValue("@email", frmSignUp.txtEmail.Text)
                command.Parameters.AddWithValue("@password", frmSignUp.txtPassword.Text) ' Consider hashing the password
                command.Parameters.AddWithValue("@username", frmSignUp.txtUsername.Text)
                command.Parameters.AddWithValue("@securityAnswer1", txtSQA1.Text)
                command.Parameters.AddWithValue("@securityAnswer2", txtSQA2.Text)
                command.Parameters.AddWithValue("@securityQuestion1", cmbSQ1.Text)
                command.Parameters.AddWithValue("@securityQuestion2", cmbSQ2.Text)
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

    Private Sub txtSQA1Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1Verify.TextChanged
        ' Check if the inputs match.
        If txtSQA1.Text = txtSQA1Verify.Text Then
            ' If the inputs are the same, set the border color to Green.
            txtSQA1.BorderColor = Color.Green
            txtSQA1Verify.BorderColor = Color.Green
            lblError.ForeColor = Color.Green
            lblError.Text = "The inputs of both textboxes are the same."
        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA1.BorderColor = Color.Red
            txtSQA1Verify.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "The inputs of both textboxes are different."
        End If
        lblError.Show()
    End Sub

    Private Sub txtSQA2Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2Verify.TextChanged
        ' Check if the inputs match.
        If txtSQA2.Text = txtSQA1Verify.Text Then
            ' If the inputs are the same, set the border color to Green.
            txtSQA2.BorderColor = Color.Green
            txtSQA2Verify.BorderColor = Color.Green
            lblError2.ForeColor = Color.Green
            lblError2.Text = "The inputs of both textboxes are the same."
        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA2.BorderColor = Color.Red
            txtSQA2Verify.BorderColor = Color.Red
            lblError2.ForeColor = Color.Red
            lblError2.Text = "The inputs of both textboxes are different."
        End If
        lblError2.Show()
    End Sub

    Private Sub lblNames_Click(sender As Object, e As EventArgs) Handles lblNames.Click

    End Sub
End Class