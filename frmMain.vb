Public Class frmMain

    ' Changes the panel displayed in the main panel container.
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

    ' Initializes a new instance of the frmMain class.
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = String.Empty
        Me.DoubleBuffered = True
        Me.MinimumSize = New Size(1200, 700)
    End Sub

    ' Handles the Load event of the frmMain control.
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmLogin.Username
    End Sub

    ' Handles the Click event of the icon buttons to change the displayed panel.
    Private Sub IconButton_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnLeaderboard.Click, btnGames.Click, btnCategory.Click, btnExpenses.Click
        Select Case DirectCast(sender, Button).Name
            Case btnDashboard.Name
                changePanel(frmDashboard)
            Case btnLeaderboard.Name
                changePanel(frmLeaderboard)
            Case btnGames.Name
                changePanel(frmGames)
            Case btnCategory.Name
                changePanel(frmCategory)
            Case btnExpenses.Name
                changePanel(frmExpenses)
        End Select
    End Sub

    ' Handles the form closing event to exit the application.
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        frmDashboard.Close()
        frmCategory.Close()
        frmGames.Close()
        frmGames.Dispose()
        frmLeaderboard.Close()
        frmExpenses.Close()
    End Sub

    ' Handles the Click event of the btnLogout control to log out the user.
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Me.Hide()
        frmLogin.Show()
        frmDashboard.Close()
        frmCategory.Close()
        frmGames.Close()
        frmGames.Dispose()
        frmLeaderboard.Close()
        frmExpenses.Close()
        Me.Close()
    End Sub
End Class
