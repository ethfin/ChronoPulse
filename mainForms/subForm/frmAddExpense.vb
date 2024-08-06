Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class frmAddExpense
    Private userID As Integer
    Private parentForm As frmExpenses ' Reference to the parent form

    ' Method to set the user ID and parent form
    Public Sub Initialize(ByVal id As Integer, ByVal parent As frmExpenses)
        userID = id
        parentForm = parent
    End Sub

    Private Sub frmAddExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial setup if needed
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate input fields
        If String.IsNullOrEmpty(txtItem.Text) OrElse String.IsNullOrEmpty(txtCost.Text) OrElse String.IsNullOrEmpty(txtDesc.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim item As String = txtItem.Text
        Dim cost As Decimal
        Dim description As String = txtDesc.Text
        Dim dates As DateTime = DTP.Value ' Use DateTime Picker's value

        ' Validate cost as a decimal number
        If Not Decimal.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("Please enter a valid cost.")
            Return
        End If

        ' Insert data into database
        Dim insertQuery As String = "INSERT INTO user_expenses (UserID, Item, Cost, Description, Date) VALUES (@userID, @item, @cost, @description, @date)"
        Using connection As MySqlConnection = Common.getDBConnectionX()
            Using command As New MySqlCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@userID", userID)
                command.Parameters.AddWithValue("@item", item)
                command.Parameters.AddWithValue("@cost", cost)
                command.Parameters.AddWithValue("@description", description)
                command.Parameters.AddWithValue("@date", dates)

                Try
                    connection.Open()
                    Dim result As Integer = command.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Expense added successfully.")
                        If parentForm IsNot Nothing Then
                            parentForm.LoadExpensesData() ' Refresh the data grid in the parent form
                        End If
                        Me.Close() ' Close the add expense form
                        connection.Close()
                    Else
                        MessageBox.Show("Failed to add expense.")
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error adding expense: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class
