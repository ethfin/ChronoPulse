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
            connection.Open()
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
            connection.Close()
        End Try
    End Sub

    Private Sub dataGridViewExpenses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewExpenses.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridViewExpenses.Rows(e.RowIndex)
            lblItem.Text = row.Cells("Item").Value.ToString()
            lblCost.Text = row.Cells("Cost").Value.ToString()
            lblDescription.Text = row.Cells("Description").Value.ToString()
            lblDate.Text = row.Cells("formatted_date").Value.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addExpenseForm As New frmAddExpense()
        addExpenseForm.Initialize(userID, Me) ' Pass the user ID and reference to this form
        addExpenseForm.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' You can use this to clear selection or clear form inputs, depending on your UI logic.
    End Sub
End Class
