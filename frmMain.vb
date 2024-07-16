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
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MinimumSize = New Size(900, 700)

    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        changePanel(frmDashboard)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnGames.Click

        changePanel(frmGames)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        changePanel(frmLeaderboard)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnFontAwsomeRoundCorner(sender As Object, e As PaintEventArgs) Handles btnGames.Paint, btnLogout.Paint, btnDashboard.Paint, btnLeaderboard.Paint
        Dim button As Button = CType(sender, Button)
        Dim radius As Integer = 15
        Dim buttonPath As New GraphicsPath()

        ' Create a rounded rectangle for the button's region
        buttonPath.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        buttonPath.AddLine(radius, 0, button.Width - radius, 0)
        buttonPath.AddArc(New Rectangle(button.Width - radius, 0, radius, radius), -90, 90)
        buttonPath.AddLine(button.Width, radius, button.Width, button.Height - radius)
        buttonPath.AddArc(New Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90)
        buttonPath.AddLine(button.Width - radius, button.Height, radius, button.Height)
        buttonPath.AddArc(New Rectangle(0, button.Height - radius, radius, radius), 90, 90)
        buttonPath.CloseFigure()

        ' Apply the rounded rectangle to the button's region
        button.Region = New Region(buttonPath)
    End Sub

End Class
