Imports MySql.Data.MySqlClient
Public Class frmResetAccountPassword
    'verify the two password textbox if they are the same and if they are not empty then update the password in the database using the email from the previous form
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtPassword.Text = txtVerifyPassword.Text And txtPassword.Text <> "" Then
            Dim conn As MySqlConnection = Common.getDBConnectionX()
            Try
                conn.Open()
                Dim cmd As MySqlCommand = conn.CreateCommand
                cmd.CommandText = "UPDATE users SET password = @password WHERE email = @email"
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@email", frmResetAccountSecurity.lblWelcome1)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmLogin.Show()
            Catch ex As Exception
                MessageBox.Show("An error occurred while resetting the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Passwords do not match or are empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class