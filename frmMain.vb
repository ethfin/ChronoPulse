Imports System.Runtime.InteropServices

Public Class frmMain

    Public Sub childForm(ByVal panel As Form)
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

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Define the Windows message constant for system commands
        Const WM_SYSCOMMAND As Integer = &H112
        ' Define the command value for maximizing the window
        Const SC_MAXIMIZE As Integer = &HF030

        ' Check if the message is a system command
        If m.Msg = WM_SYSCOMMAND Then
            ' Check if the command is to maximize the window
            If m.WParam.ToInt32() = SC_MAXIMIZE Then
                ' Prevent the default behavior by not calling the base method
                Return
            End If
        End If

        ' Call the base class method for default processing of other messages
        MyBase.WndProc(m)
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, pnlSidebar.MouseDown, pnlSeparator1.MouseDown, pnlSeparator2.MouseDown
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

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        childForm(frmDashboard)
    End Sub
End Class
