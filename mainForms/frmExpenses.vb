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

    Private Sub LoadExpensesData()
        Dim query As String = "SELECT expense_id, dbaccountsID, categoryID, Item, Cost, Description, date FROM user_expenses " &
                              "WHERE dbaccountsID = @userID"
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
            dataGridViewExpenses.Columns("dbaccountsID").Visible = False
            dataGridViewExpenses.Columns("categoryID").Visible = False
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
