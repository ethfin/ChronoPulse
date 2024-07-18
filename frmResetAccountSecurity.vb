Public Class frmResetAccountSecurity
    Private Sub lblWelcome1_Click(sender As Object, e As EventArgs) Handles lblWelcome1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmResetAccount.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Confirm before closing the application.
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Closes the entire application.
            Application.Exit()
        End If
    End Sub

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.Checked Then
            ' If the checkbox is checked, set the PasswordChar to an empty string to show the password
            txtSQA1.PasswordChar = ""
            txtSQA1Verify.PasswordChar = ""
        Else
            ' If the checkbox is unchecked, set the PasswordChar back to "*"
            txtSQA1.PasswordChar = "*"
            txtSQA1Verify.PasswordChar = "*"
        End If
    End Sub

    Private Sub cbxShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword2.CheckedChanged
        If cbxShowPassword2.Checked Then
            ' If the checkbox is checked, set the PasswordChar to an empty string to show the password
            txtSQA2.PasswordChar = ""
            txtSQA2Verify.PasswordChar = ""
        Else
            ' If the checkbox is unchecked, set the PasswordChar back to "*"
            txtSQA2.PasswordChar = "*"
            txtSQA2Verify.PasswordChar = "*"
        End If
    End Sub


    Private Function ValidateInputFields() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(txtSQA1.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA1Verify.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA2.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA2Verify.Text) Then

            MessageBox.Show("Please fill in all fields.")
            Return False

        End If

        ' Check if the passwords match
        If Not txtSQA1.Text.Equals(txtSQA1Verify.Text) OrElse
               txtSQA2.Text.Equals(txtSQA2Verify.Text) Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        ' Add more validation as needed (e.g., email format, password strength)

        ' If all validations pass
        Return True
    End Function
End Class