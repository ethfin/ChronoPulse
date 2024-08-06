Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmResetAccountSecurity
    Private prevSelectedIndex1 As Integer = -1
    Private prevSelectedIndex2 As Integer = -1 ' Added a separate variable for cmbSecurityQ2

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

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    ' The MouseDown event for the panel to initiate the form dragging.
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogin1.MouseDown, panelLogin2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

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

    Private Sub txtSQA1_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1.TextChanged
        compareAnswer3()
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

    Function compareAnswer3()
        ' Check if the inputs match.
        If txtSQA1Verify.Text = txtSQA1.Text Then
            If ValidateSecurity(txtSQA1Verify.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA1.BorderColor = Color.Green
                txtSQA1Verify.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Answer for Security Question 1 are the same"
            Else
                txtSQA1Verify.Text = txtSQA1.Text
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

    Private Sub txtSQA2_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2.TextChanged
        compareAnswer4()
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

    Function compareAnswer4()
        ' Check if the inputs match.
        If txtSQA2Verify.Text = txtSQA2.Text Then
            If ValidateSecurity(txtSQA2.Text) Then
                ' If the inputs are the same, set the border color to Green.
                txtSQA2.BorderColor = Color.Green
                txtSQA2Verify.BorderColor = Color.Green
                lblError2.ForeColor = Color.Green
                lblError2.Text = "Answer for Security Question 2 are the same"
            Else
                txtSQA2Verify.Text = txtSQA2.Text
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
        If Len(pwd) < 1 Then
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
               Not txtSQA2.Text.Equals(txtSQA2Verify.Text) Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        ' Add more validation as needed (e.g., email format, password strength)

        ' If all validations pass
        Return True
    End Function

    Private Sub frmResetAccountSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim email As String = lblWelcome1.Text.Replace("Email: ", "") ' Extract the email from the label text

        If ValidateInputFields() Then
            Dim conn As MySqlConnection = Common.getDBConnectionX()

            Try
                ' Open the connection
                conn.Open()

                ' SQL query to check if the user exists with the given email and security answers
                Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE email = @email AND securityAnswer1 = @sqa1 AND securityAnswer2 = @sqa2"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

                ' Use parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@sqa1", txtSQA1.Text)
                cmd.Parameters.AddWithValue("@sqa2", txtSQA2.Text)

                ' Execute the query and get the result
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Check if the user exists
                If result > 0 Then
                    ' Proceed to the next form or main application window
                    Me.Hide()
                    frmResetAccountPassword.Show()
                Else
                    lblError.ForeColor = Color.Red
                    lblError.Text = "Invalid Security Questions and Answers."
                    lblError.Show()
                    lblError2.ForeColor = Color.Red
                    lblError2.Text = "Invalid Security Questions and Answers."
                    lblError2.Show()
                End If

            Catch ex As Exception
                ' Handle any errors that occur
                lblError.ForeColor = Color.Red
                lblError.Text = "Error: " & ex.Message
                lblError.Show()
                lblError2.ForeColor = Color.Red
                lblError2.Text = "Error: " & ex.Message
                lblError2.Show()
            Finally
                ' Close the connection whether or not an error occurred
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If
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

    Public Sub SetEmail(email As String)
        lblWelcome1.Text = "Email: " & email
    End Sub
End Class