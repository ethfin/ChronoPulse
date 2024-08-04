﻿Imports MySql.Data.MySqlClient

Public Class frmFinance
    Private Sub frmFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim userID As Integer
        Dim username As String = frmMain.lblUsername.Text
        Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

        Using getUserIDCmd As New MySqlCommand(getUserIDQuery, Common.getDBConnectionX())
            getUserIDCmd.Parameters.AddWithValue("@username", username)
            Common.getDBConnectionX().Open()
            userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
            Common.getDBConnectionX().Close()
        End Using

        Dim query As String = "SELECT ID, category, type, status, date FROM categories WHERE UserID = @userID"
        Dim adapter As New MySqlDataAdapter(query, Common.getDBConnectionX())
        adapter.SelectCommand.Parameters.AddWithValue("@userID", userID)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvCategories.DataSource = table
        dgvCategories.Columns("ID").Visible = False ' Hide the ID column
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim userID As Integer
        Dim username As String = frmMain.lblUsername.Text
        Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

        Using getUserIDCmd As New MySqlCommand(getUserIDQuery, Common.getDBConnectionX())
            getUserIDCmd.Parameters.AddWithValue("@username", username)
            Common.getDBConnectionX().Open()
            userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
            Common.getDBConnectionX().Close()
        End Using

        Dim query As String = "INSERT INTO categories (UserID, category, type, status) VALUES (@userID, @category, @type, @status)"
        Using cmd As New MySqlCommand(query, Common.getDBConnectionX())
            cmd.Parameters.AddWithValue("@userID", userID)
            cmd.Parameters.AddWithValue("@category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@type", txtType.Text)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text)
            Common.getDBConnectionX().Open()
            cmd.ExecuteNonQuery()
            Common.getDBConnectionX().Close()
        End Using
        LoadData()
    End Sub
    Private Sub dgvCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCategories.Rows(e.RowIndex)
            txtCategory.Text = row.Cells("category").Value.ToString()
            txtType.Text = row.Cells("type").Value.ToString()
            txtStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCategories.SelectedRows.Count > 0 Then
            Dim userID As Integer
            Dim username As String = frmMain.lblUsername.Text
            Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

            Using getUserIDCmd As New MySqlCommand(getUserIDQuery, Common.getDBConnectionX())
                getUserIDCmd.Parameters.AddWithValue("@username", username)
                Common.getDBConnectionX().Open()
                userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
                Common.getDBConnectionX().Close()
            End Using

            Dim id As Integer = Convert.ToInt32(dgvCategories.SelectedRows(0).Cells("ID").Value)
            Dim query As String = "UPDATE categories SET category = @category, type = @type, status = @status WHERE ID = @id AND UserID = @userID"
            Using cmd As New MySqlCommand(query, Common.getDBConnectionX())
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.Parameters.AddWithValue("@category", txtCategory.Text)
                cmd.Parameters.AddWithValue("@type", txtType.Text)
                cmd.Parameters.AddWithValue("@status", txtStatus.Text)
                Common.getDBConnectionX().Open()
                cmd.ExecuteNonQuery()
                Common.getDBConnectionX().Close()
            End Using
            LoadData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCategory.Clear()
        txtType.Clear()
        txtStatus.Clear()
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        If dgvCategories.SelectedRows.Count > 0 Then
            Dim userID As Integer
            Dim username As String = frmMain.lblUsername.Text
            Dim getUserIDQuery As String = "SELECT UserID FROM dbaccounts WHERE Username = @username"

            Using getUserIDCmd As New MySqlCommand(getUserIDQuery, Common.getDBConnectionX())
                getUserIDCmd.Parameters.AddWithValue("@username", username)
                Common.getDBConnectionX().Open()
                userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar())
                Common.getDBConnectionX().Close()
            End Using

            Dim id As Integer = Convert.ToInt32(dgvCategories.SelectedRows(0).Cells("ID").Value)
            Dim query As String = "UPDATE categories SET status = 'Disabled' WHERE ID = @id AND UserID = @userID"
            Using cmd As New MySqlCommand(query, Common.getDBConnectionX())
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@userID", userID)
                Common.getDBConnectionX().Open()
                cmd.ExecuteNonQuery()
                Common.getDBConnectionX().Close()
            End Using
            LoadData()
        End If
    End Sub
End Class
