Imports MySql.Data.MySqlClient

Public Class frmExpenses
    Private userID As Integer
    Private connection As MySqlConnection

    ' Method to set the user ID
    Public Sub SetUserID(ByVal id As Integer)
        userID = id
    End Sub

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = Common.createDBConnection()
        connection.Open()
        GetUserID()
        LoadExpensesData()

        ' Disable the Edit button initially
        btnEdit.Enabled = False

        ' Prevent extra empty rows in the DataGridView
        dataGridViewExpenses.AllowUserToAddRows = False
    End Sub

    Private Sub frmExpenses_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Method to get the user ID based on the username from frmMain
    Private Sub GetUserID()
        Dim username As String = frmMain.lblUsername.Text
        Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

        Using getUserIDCmd As New MySqlCommand(getUserIDQuery, connection)
            getUserIDCmd.Parameters.AddWithValue("@username", username)
            userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
        End Using
    End Sub

    ' Make LoadExpensesData public so it can be accessed from frmAddExpense
    Public Sub LoadExpensesData()
        Dim query As String = "SELECT expense_id, UserID, Item, Cost, Description, date_format(date, '%M %e, %Y %h:%i:%s%p') AS formatted_date FROM user_expenses " &
                              "WHERE UserID = @userID"
        Dim adapter As New MySqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@userID", userID)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dataGridViewExpenses.DataSource = table

            ' Hide ID columns
            dataGridViewExpenses.Columns("expense_id").Visible = False
            dataGridViewExpenses.Columns("UserID").Visible = False

            ' Rename column headers to all caps
            dataGridViewExpenses.Columns("Item").HeaderText = "ITEM"
            dataGridViewExpenses.Columns("Cost").HeaderText = "COST"
            dataGridViewExpenses.Columns("Description").HeaderText = "DESCRIPTION"
            dataGridViewExpenses.Columns("formatted_date").HeaderText = "DATE"

            ' Update total cost
            UpdateTotalCost()
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateTotalCost()
        Dim totalCost As Decimal = 0

        For Each row As DataGridViewRow In dataGridViewExpenses.Rows
            totalCost += Convert.ToDecimal(row.Cells("Cost").Value)
        Next

        lblTotalCost.Text = totalCost.ToString("C")
    End Sub

    Private Sub AddExpense()
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtItem.Text) OrElse
           String.IsNullOrWhiteSpace(txtCost.Text) OrElse
           String.IsNullOrWhiteSpace(txtDescription.Text) Then
            MessageBox.Show("Please fill in all fields before adding an expense.")
            Return
        End If

        Dim item As String = txtItem.Text
        Dim cost As Decimal

        ' Validate cost input
        If Not Decimal.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("Please enter a valid cost.")
            Return
        End If

        Dim description As String = txtDescription.Text
        Dim dateValue As DateTime = dtpDate.Value

        Dim insertQuery As String = "INSERT INTO user_expenses (UserID, Item, Cost, Description, date) VALUES (@userID, @item, @cost, @description, @date)"

        Using insertCmd As New MySqlCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@userID", userID)
            insertCmd.Parameters.AddWithValue("@item", item)
            insertCmd.Parameters.AddWithValue("@cost", cost)
            insertCmd.Parameters.AddWithValue("@description", description)
            insertCmd.Parameters.AddWithValue("@date", dateValue)

            Try
                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Expense added successfully.")
                LoadExpensesData() ' Refresh the data grid view

                ' Update the total cost and total items in frmDashboard
                frmDashboard.RefreshTotalCost()
                frmDashboard.RefreshTotalItems()
            Catch ex As MySqlException
                MessageBox.Show("Error adding expense: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub EditExpense()
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtItem.Text) OrElse
           String.IsNullOrWhiteSpace(txtCost.Text) OrElse
           String.IsNullOrWhiteSpace(txtDescription.Text) Then
            MessageBox.Show("Please fill in all fields before editing an expense.")
            Return
        End If

        Dim item As String = txtItem.Text
        Dim cost As Decimal

        ' Validate cost input
        If Not Decimal.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("Please enter a valid cost.")
            Return
        End If

        Dim description As String = txtDescription.Text
        Dim dateValue As DateTime = dtpDate.Value

        Dim updateQuery As String = "UPDATE user_expenses SET Item = @item, Cost = @cost, Description = @description, date = @date WHERE expense_id = @expenseID"

        Using updateCmd As New MySqlCommand(updateQuery, connection)
            updateCmd.Parameters.AddWithValue("@item", item)
            updateCmd.Parameters.AddWithValue("@cost", cost)
            updateCmd.Parameters.AddWithValue("@description", description)
            updateCmd.Parameters.AddWithValue("@date", dateValue)
            updateCmd.Parameters.AddWithValue("@expenseID", dataGridViewExpenses.SelectedRows(0).Cells("expense_id").Value)

            Try
                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Expense updated successfully.")
                LoadExpensesData() ' Refresh the data grid view

                ' Update the total cost and total items in frmDashboard
                frmDashboard.RefreshTotalCost()
                frmDashboard.RefreshTotalItems()
            Catch ex As MySqlException
                MessageBox.Show("Error updating expense: " & ex.Message)
            End Try
        End Using

        ' Clear fields and unselect DataGridView
        ClearFieldsAndUnselect()
    End Sub

    Private Sub DeleteSelectedExpenses()
        ' Check if any rows are selected
        If dataGridViewExpenses.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one row to delete.")
            Return
        End If

        ' Confirm the deletion with the user
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected expenses?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Delete the selected expenses from the database
            Dim deleteQuery As String = "DELETE FROM user_expenses WHERE expense_id IN ("

            ' Build the parameterized query with placeholders for each selected expense ID
            Dim parameterNames As New List(Of String)()
            For Each row As DataGridViewRow In dataGridViewExpenses.SelectedRows
                Dim expenseID As Integer = Convert.ToInt32(row.Cells("expense_id").Value)
                Dim parameterName As String = "@expenseID" & expenseID.ToString()
                deleteQuery &= parameterName & ","
                parameterNames.Add(parameterName)
            Next

            ' Remove the trailing comma and close the parentheses
            deleteQuery = deleteQuery.TrimEnd(","c) & ")"

            Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                ' Add the expense ID parameters to the command
                For i As Integer = 0 To parameterNames.Count - 1
                    deleteCmd.Parameters.AddWithValue(parameterNames(i), Convert.ToInt32(dataGridViewExpenses.SelectedRows(i).Cells("expense_id").Value))
                Next

                Try
                    deleteCmd.ExecuteNonQuery()
                    MessageBox.Show("Selected expenses deleted successfully.")
                    LoadExpensesData() ' Refresh the data grid view

                    ' Update the total cost and total items in frmDashboard
                    frmDashboard.RefreshTotalCost()
                    frmDashboard.RefreshTotalItems()
                Catch ex As MySqlException
                    MessageBox.Show("Error deleting expenses: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub ClearFieldsAndUnselect()
        ' Clear all input fields
        txtItem.Clear()
        txtCost.Clear()
        txtDescription.Clear()
        dtpDate.Value = DateTime.Now

        ' Unselect any selected rows in the DataGridView
        dataGridViewExpenses.ClearSelection()

        ' Disable the Edit button
        btnEdit.Enabled = False
    End Sub

    Private Sub dataGridViewExpenses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewExpenses.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridViewExpenses.Rows(e.RowIndex)
            txtItem.Text = row.Cells("Item").Value.ToString()
            txtCost.Text = row.Cells("Cost").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()

            Dim dateValue As DateTime
            If DateTime.TryParse(row.Cells("formatted_date").Value.ToString(), dateValue) Then
                dtpDate.Value = dateValue
            Else
                MessageBox.Show("Invalid date format in the selected row.")
            End If

            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub dataGridViewExpenses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewExpenses.CellContentClick
        ' Call the CellClick event handler to update the textboxes and DateTimePicker
        dataGridViewExpenses_CellClick(sender, e)
    End Sub

    Private Sub dataGridViewExpenses_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridViewExpenses.CellMouseDown
        ' Check if the user shift-clicked multiple items
        If e.Button = MouseButtons.Left AndAlso (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
            ' Select the clicked row
            dataGridViewExpenses.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddExpense()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditExpense()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSelectedExpenses()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFieldsAndUnselect()
    End Sub

    ' Event handler to ensure txtCost only accepts numbers
    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
        ' Allow control keys, digits, and one decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        ' Only allow one decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub
End Class
