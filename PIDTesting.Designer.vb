<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIDTesting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.timerAppCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lstRunningApps = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(67, 48)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(180, 45)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Launch"
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(46, 131)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(39, 13)
        Me.lblElapsedTime.TabIndex = 2
        Me.lblElapsedTime.Text = "Label1"
        '
        'timerAppCheck
        '
        '
        'lstRunningApps
        '
        Me.lstRunningApps.FormattingEnabled = True
        Me.lstRunningApps.Location = New System.Drawing.Point(490, 48)
        Me.lstRunningApps.Name = "lstRunningApps"
        Me.lstRunningApps.Size = New System.Drawing.Size(260, 329)
        Me.lstRunningApps.TabIndex = 3
        '
        'PIDTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstRunningApps)
        Me.Controls.Add(Me.lblElapsedTime)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "PIDTesting"
        Me.Text = "PIDTesting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents timerAppCheck As Timer
    Friend WithEvents lstRunningApps As ListBox
End Class
