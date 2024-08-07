Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmSecurityQuestions

    ' Store the previously selected item from cmbSecurityQ1
    Private prevSelectedIndex1 As Integer = -1
    Private prevSelectedIndex2 As Integer = -1 ' Added a separate variable for cmbSecurityQ2

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBackground.MouseDown, Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
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
        ' Handle changes in cmbSecurityQ1
        If cmbSQ1.SelectedIndex <> -1 AndAlso prevSelectedIndex2 <> -1 Then
            ' Add the previously selected item back to cmbSecurityQ2
            cmbSQ2.Items.Insert(prevSelectedIndex2, cmbSQ2.Tag)
        End If
        ' Remove the currently selected item of cmbSecurityQ1 from cmbSecurityQ2
        If cmbSQ2.Items.Contains(cmbSQ1.SelectedItem) Then
            prevSelectedIndex2 = cmbSQ2.Items.IndexOf(cmbSQ1.SelectedItem)
            cmbSQ2.Tag = cmbSQ1.SelectedItem ' Store the removed item
            cmbSQ2.Items.Remove(cmbSQ1.SelectedItem)
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

        ' Check if the security questions are the same
        If cmbSQ1.Text = cmbSQ2.Text Then
            MessageBox.Show("Security questions must be different.")
            Return False
        End If

        ' Validate the security answers
        If Not compareAnswer1() OrElse Not compareAnswer2() Then
            Return False
        End If

        Return True
    End Function

    Private Sub cmbSQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSQ2.SelectedIndexChanged
        ' Handle changes in cmbSecurityQ2
        If cmbSQ2.SelectedIndex <> -1 AndAlso prevSelectedIndex1 <> -1 Then
            ' Add the previously selected item back to cmbSecurityQ1
            cmbSQ1.Items.Insert(prevSelectedIndex1, cmbSQ1.Tag)
        End If
        ' Remove the currently selected item of cmbSecurityQ2 from cmbSecurityQ1
        If cmbSQ1.Items.Contains(cmbSQ2.SelectedItem) Then
            prevSelectedIndex1 = cmbSQ1.Items.IndexOf(cmbSQ2.SelectedItem)
            cmbSQ1.Tag = cmbSQ2.SelectedItem ' Store the removed item
            cmbSQ1.Items.Remove(cmbSQ2.SelectedItem)
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If ValidateInputFields() Then
            InsertUserData()
            frmLogin.Show()
            frmSignUp.Close()
            Me.Close()
        End If
    End Sub

    Private Sub InsertUserData()
        ' Use the Common class to create a new instance of the database connection
        Dim conn As MySqlConnection = Common.createDBConnection()

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
                ' Open the connection if it's not already open
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

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
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Me.Close()
            frmLogin.Show()
        End Try
    End Sub

    Private Sub txtSQA1Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1Verify.TextChanged
        compareAnswer1()
    End Sub

    Private Sub txtSQA3_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1.TextChanged
        compareAnswer3()
    End Sub

    Function compareAnswer1() As Boolean
        ' Check if the inputs match.
        If txtSQA1.Text = txtSQA1Verify.Text Then
            If ValidateSecurity(txtSQA1.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA1.BorderColor = Color.Green
                txtSQA1Verify.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Answer for Security Question 1 are the same"
                lblError.Show()
                Return True
            Else
                txtSQA1.Text = txtSQA1Verify.Text
                ' If the inputs are blank, set the border color to Red.
                txtSQA1.BorderColor = Color.Red
                txtSQA1Verify.BorderColor = Color.Red
                lblError.ForeColor = Color.Red
                lblError.Text = "Fill in the the following fields"
                lblError.Show()
                Return False
            End If
        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA1.BorderColor = Color.Red
            txtSQA1Verify.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Answer for Security Question 1 are different"
            lblError.Show()
            Return False
        End If
    End Function

    Function compareAnswer3() As Boolean
        ' Check if the inputs match.
        If txtSQA1Verify.Text = txtSQA1.Text Then
            If ValidateSecurity(txtSQA1Verify.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA1.BorderColor = Color.Green
                txtSQA1Verify.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Answer for Security Question 1 are the same"
                lblError.Show()
                Return True
            Else
                txtSQA1Verify.Text = txtSQA1.Text
                ' If the inputs are blank, set the border color to Red.
                txtSQA1.BorderColor = Color.Red
                txtSQA1Verify.BorderColor = Color.Red
                lblError.ForeColor = Color.Red
                lblError.Text = "Fill in the the following fields"
                lblError.Show()
                Return False
            End If
        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA1.BorderColor = Color.Red
            txtSQA1Verify.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Answer for Security Question 1 are different"
            lblError.Show()
            Return False
        End If
    End Function


    Private Sub txtSQA2Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2Verify.TextChanged
        compareAnswer2()
    End Sub

    Private Sub txtSQA4_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2.TextChanged
        compareAnswer4()
    End Sub

    Function compareAnswer2() As Boolean
        ' Check if the inputs match.
        If txtSQA2.Text = txtSQA2Verify.Text Then
            If ValidateSecurity(txtSQA2.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA2.BorderColor = Color.Green
                txtSQA2Verify.BorderColor = Color.Green
                lblError2.ForeColor = Color.Green
                lblError2.Text = "Answer for Security Question 2 are the same"
                lblError2.Show()
                Return True
            Else
                txtSQA2.Text = txtSQA2Verify.Text
                ' If the inputs are blank, set the border color to Red.
                txtSQA2.BorderColor = Color.Red
                txtSQA2Verify.BorderColor = Color.Red
                lblError2.ForeColor = Color.Red
                lblError2.Text = "Fill in the the following fields"
                lblError2.Show()
                Return False
            End If
        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA2.BorderColor = Color.Red
            txtSQA2Verify.BorderColor = Color.Red
            lblError2.ForeColor = Color.Red
            lblError2.Text = "Answer for Security Question 2 are different"
            lblError2.Show()
            Return False
        End If
    End Function

    Function compareAnswer4() As Boolean
        ' Check if the inputs match.
        If txtSQA2Verify.Text = txtSQA2.Text Then
            If ValidateSecurity(txtSQA2.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA2.BorderColor = Color.Green
                txtSQA2Verify.BorderColor = Color.Green
                lblError2.ForeColor = Color.Green
                lblError2.Text = "Answer for Security Question 2 are the same"
                lblError2.Show()
                Return True
            Else
                txtSQA2Verify.Text = txtSQA2.Text
                ' If the inputs are blank, set the border color to Red.
                txtSQA2.BorderColor = Color.Red
                txtSQA2Verify.BorderColor = Color.Red
                lblError2.ForeColor = Color.Red
                lblError2.Text = "Fill in the the following fields"
                lblError2.Show()
                Return False
            End If
        Else
            ' If the inputs don't match, set the border color to Red.
            txtSQA2.BorderColor = Color.Red
            txtSQA2Verify.BorderColor = Color.Red
            lblError2.ForeColor = Color.Red
            lblError2.Text = "Answer for Security Question 2 are different"
            lblError2.Show()
            Return False
        End If
    End Function

    Function ValidateSecurity(ByVal pwd As String) As Boolean
        ' Check the length.
        If Len(pwd) < 3 Then
            Return False
        End If

        ' Passed all checks.
        Return True
    End Function

    Private Sub lblNames_Click(sender As Object, e As EventArgs) Handles lblNames.Click

    End Sub

    Private Sub htmllblBackToLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles htmllblBackToLogin.LinkClicked
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmSignUp.Show()
    End Sub

    Private Sub txtSQA1_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1.TextChanged
        compareAnswer1()
    End Sub

    Private Sub txtSQA2_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2.TextChanged
        compareAnswer2()
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

End Class