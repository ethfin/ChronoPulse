Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class frmMain

    Public Sub changePanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = String.Empty
        Me.DoubleBuffered = True
        Me.MinimumSize = New Size(900, 700)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        changePanel(frmDashboard)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        changePanel(frmLeaderboard)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btnGames.Click
        changePanel(frmGames)
    End Sub
End Class
