Imports MySql.Data.MySqlClient

Public Class frmExpenses
    Private userID As Integer

    ' Method to set the user ID
    Public Sub SetUserID(ByVal id As Integer)
        userID = id
    End Sub

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserID()
        LoadExpensesData()
    End Sub

    ' Method to get the user ID based on the username from frmMain
    Private Sub GetUserID()
        Dim username As String = frmMain.lblUsername.Text
        Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

        Using getUserIDCmd As New MySqlCommand(getUserIDQuery, Common.getDBConnectionX())
            getUserIDCmd.Parameters.AddWithValue("@username", username)
            Common.getDBConnectionX().Open()
            userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
            Common.getDBConnectionX().Close()
        End Using
    End Sub

    ' Make LoadExpensesData public so it can be accessed from frmAddExpense
    Public Sub LoadExpensesData()
        Dim query As String = "SELECT expense_id, UserID, Item, Cost, Description, date_format(date, '%M %e, %Y %h:%i:%s%p') AS formatted_date FROM user_expenses " &
                              "WHERE UserID = @userID"
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim adapter As New MySqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@userID", userID)
        Dim table As New DataTable()

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

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
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
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
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddExpense()
    End Sub

    Private Sub dataGridViewExpenses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewExpenses.CellContentClick
        ' Call the CellClick event handler to update the textboxes and DateTimePicker
        dataGridViewExpenses_CellClick(sender, e)
    End Sub

    ' Function to add a new expense to the database
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

        Using connection As MySqlConnection = Common.getDBConnectionX()
            Using insertCmd As New MySqlCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("@userID", userID)
                insertCmd.Parameters.AddWithValue("@item", item)
                insertCmd.Parameters.AddWithValue("@cost", cost)
                insertCmd.Parameters.AddWithValue("@description", description)
                insertCmd.Parameters.AddWithValue("@date", dateValue)

                Try
                    connection.Open()
                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Expense added successfully.")
                    LoadExpensesData() ' Refresh the data grid view
                Catch ex As MySqlException
                    MessageBox.Show("Error adding expense: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    ' Event handler to ensure txtCost only accepts numbers
    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
        ' Allow control keys, digits, and one decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        ' Only allow one decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub
End Class
