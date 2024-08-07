Imports System.Windows.Forms

Public Class frmMain

    Private notifyIcon As NotifyIcon
    Private contextMenu As ContextMenuStrip

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

        ' Initialize NotifyIcon
        notifyIcon = New NotifyIcon()
        notifyIcon.Icon = My.Resources.ChronoPulse_Logo_v2 'uses Resources folder in order to use the icon
        notifyIcon.Visible = True
        AddHandler notifyIcon.DoubleClick, AddressOf NotifyIcon_DoubleClick

        ' Initialize ContextMenuStrip
        contextMenu = New ContextMenuStrip()
        contextMenu.Items.Add("Show", Nothing, AddressOf ShowMenuItem_Click)
        contextMenu.Items.Add("Exit", Nothing, AddressOf ExitMenuItem_Click)
        notifyIcon.ContextMenuStrip = contextMenu
    End Sub

    ' Handles the Load event of the frmMain control.
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmLogin.Username
        changePanel(frmDashboard)
        frmGames.Show()
        frmGames.Hide()
    End Sub

    ' Handles the Click event of the icon buttons to change the displayed panel.
    Private Sub IconButton_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnGames.Click, btnExpenses.Click
        Select Case DirectCast(sender, Button).Name
            Case btnDashboard.Name
                changePanel(frmDashboard)
            'Case btnLeaderboard.Name
            '    changePanel(frmLeaderboard)
            Case btnGames.Name
                changePanel(frmGames)
            'Case btnCategory.Name
            '    changePanel(frmCategory)
            Case btnExpenses.Name
                changePanel(frmExpenses)
        End Select
    End Sub

    ' Handles the form closing event to minimize to system tray.
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

    ' Handles the Click event of the btnLogout control to log out the user.
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Me.Hide()
        frmLogin.Show()
        CloseChildForms()
        Me.Close()
    End Sub

    Private Sub CloseChildForms()
        frmDashboard.Close()
        'frmCategory.Close()
        frmGames.Close()
        'frmGames.Dispose()
        'frmLeaderboard.Close()
        frmExpenses.Close()
        frmExpenses.Dispose()
    End Sub

    ' Handles the double-click event of the NotifyIcon to restore the form.
    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    ' Handles the Click event of the Show menu item to restore the form.
    Private Sub ShowMenuItem_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    ' Handles the Click event of the Exit menu item to close the application.
    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs)
        notifyIcon.Visible = False
        Application.Exit()
    End Sub

End Class
