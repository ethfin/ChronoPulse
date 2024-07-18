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

    Private Sub txtSQA1Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1Verify.TextChanged
        compareAnswer1()
    End Sub

    Function compareAnswer1()
        ' Check if the inputs match.
        If txtSQA1.Text = txtSQA1Verify.Text Then
            If ValidateSecurity(txtSQA1.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA1.BorderColor = Color.Green
                txtSQA1Verify.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Answer for Security Question 1 are the same"
            Else
                txtSQA1.Text = txtSQA1Verify.Text
                ' If the inputs are blank, set the border color to Orange.
                txtSQA1.BorderColor = Color.Orange
                txtSQA1Verify.BorderColor = Color.Orange
                lblError.ForeColor = Color.Orange
                lblError.Text = "Fill in the the following fields"
                lblError.Show()
            End If

        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA1.BorderColor = Color.Red
            txtSQA1Verify.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Answer for Security Question 1 are different"
        End If
        lblError.Show()
    End Function

    Private Sub txtSQA2Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2Verify.TextChanged
        compareAnswer2()
    End Sub

    Function compareAnswer2()
        ' Check if the inputs match.
        If txtSQA2.Text = txtSQA2Verify.Text Then
            If ValidateSecurity(txtSQA2.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA2.BorderColor = Color.Green
                txtSQA2Verify.BorderColor = Color.Green
                lblError2.ForeColor = Color.Green
                lblError2.Text = "Answer for Security Question 2 are the same"
            Else
                txtSQA2.Text = txtSQA2Verify.Text
                ' If the inputs are blank, set the border color to Orange.
                txtSQA2.BorderColor = Color.Orange
                txtSQA2Verify.BorderColor = Color.Orange
                lblError2.ForeColor = Color.Orange
                lblError2.Text = "Fill in the the following fields"
                lblError2.Show()
            End If

        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA2.BorderColor = Color.Red
            txtSQA2Verify.BorderColor = Color.Red
            lblError2.ForeColor = Color.Red
            lblError2.Text = "Answer for Security Question 2 are different"
        End If
        lblError2.Show()
    End Function

    Function ValidateSecurity(ByVal pwd As String) As Boolean
        ' Check the length.
        If Len(pwd) < 3 Then
            Return False
        End If

        ' Passed all checks.
        Return True
    End Function

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


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub
End Class