﻿Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class
