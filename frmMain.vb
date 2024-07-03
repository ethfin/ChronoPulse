﻿Imports System.Runtime.InteropServices

Public Class frmMain

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

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMain.MouseDown, pnlLogo.MouseDown, pnlHeader.MouseDown, pnlContent.MouseDown
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Application.Exit()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
