Imports MySql.Data.MySqlClient

Public Class frmExpenses
    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExpensesData()
    End Sub

    Private Sub LoadExpensesData()
        Dim query As String = "SELECT ID, UserID, category, type, status, date FROM categories"
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            dataGridViewExpenses.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
