Public Class frmMain

    Public Sub changePanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        With panel
            .TopLevel = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = String.Empty
        Me.DoubleBuffered = True
        Me.MinimumSize = New Size(1200, 700)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmLogin.Username
    End Sub

    Private Sub IconButton_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnLeaderboard.Click, btnGames.Click, btnFinance.Click
        Select Case DirectCast(sender, Button).Name
            Case btnDashboard.Name
                changePanel(frmDashboard)
            Case btnLeaderboard.Name
                changePanel(frmLeaderboard)
            Case btnGames.Name
                changePanel(frmGames)
            Case btnFinance.Name
                changePanel(frmFinance)
        End Select
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class
