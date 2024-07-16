Public Class frmResetAccount
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmLogin.Show()
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

        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' Regular expression pattern for a valid email address
        Dim emailPattern As String = "^\S+@\S+\.\S+$"

        ' Using Regex.IsMatch to check if the email is valid
        If System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern) Then
            lblErrorEmail.Text = "Valid input."
            lblErrorEmail.ForeColor = Color.Green
            txtEmail.BorderColor = Color.Green
        Else
            lblErrorEmail.Text = "Please enter a valid email."
            lblErrorEmail.ForeColor = Color.Red
            txtEmail.BorderColor = Color.Red
        End If
        ' Show the email error label regardless of the result
        lblErrorEmail.Show()
    End Sub

    Function emailValid() As Boolean
        ' Regular expression pattern for a valid email address
        Dim emailPattern As String = "^\S+@\S+\.\S+$"

        ' Using Regex.IsMatch to check if the email is valid
        If System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern) Then
            lblErrorEmail.Text = "Valid input."
            lblErrorEmail.ForeColor = Color.Green
            txtEmail.BorderColor = Color.Green
            Return True
        Else
            lblErrorEmail.Text = "Please enter a valid email."
            lblErrorEmail.ForeColor = Color.Red
            txtEmail.BorderColor = Color.Red
            Return False
        End If
        ' Show the email error label regardless of the result
        lblErrorEmail.Show()
    End Function

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
End Class