<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGames
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLoglastTime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTracker = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbApp = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContainer.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlContainer.Controls.Add(Me.Guna2Panel5)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(50)
        Me.pnlContainer.Size = New System.Drawing.Size(1248, 652)
        Me.pnlContainer.TabIndex = 1
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.lblLoglastTime)
        Me.Guna2Panel5.Controls.Add(Me.lblTracker)
        Me.Guna2Panel5.Controls.Add(Me.lbApp)
        Me.Guna2Panel5.Location = New System.Drawing.Point(55, 55)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Padding = New System.Windows.Forms.Padding(25)
        Me.Guna2Panel5.Size = New System.Drawing.Size(1138, 542)
        Me.Guna2Panel5.TabIndex = 2
        '
        'lblLoglastTime
        '
        Me.lblLoglastTime.AutoSize = False
        Me.lblLoglastTime.BackColor = System.Drawing.Color.Transparent
        Me.lblLoglastTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLoglastTime.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoglastTime.ForeColor = System.Drawing.Color.White
        Me.lblLoglastTime.Location = New System.Drawing.Point(25, 247)
        Me.lblLoglastTime.Name = "lblLoglastTime"
        Me.lblLoglastTime.Size = New System.Drawing.Size(801, 267)
        Me.lblLoglastTime.TabIndex = 2
        Me.lblLoglastTime.Text = Nothing
        '
        'lblTracker
        '
        Me.lblTracker.AutoSize = False
        Me.lblTracker.BackColor = System.Drawing.Color.Transparent
        Me.lblTracker.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTracker.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTracker.ForeColor = System.Drawing.Color.White
        Me.lblTracker.Location = New System.Drawing.Point(25, 25)
        Me.lblTracker.Name = "lblTracker"
        Me.lblTracker.Size = New System.Drawing.Size(801, 222)
        Me.lblTracker.TabIndex = 1
        '
        'lbApp
        '
        Me.lbApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lbApp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbApp.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbApp.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApp.ForeColor = System.Drawing.Color.White
        Me.lbApp.FormattingEnabled = True
        Me.lbApp.ItemHeight = 23
        Me.lbApp.Location = New System.Drawing.Point(826, 25)
        Me.lbApp.Name = "lbApp"
        Me.lbApp.Size = New System.Drawing.Size(287, 492)
        Me.lbApp.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 652)
        Me.Controls.Add(Me.pnlContainer)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGames"
        Me.Text = "frmGames"
        Me.pnlContainer.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTracker As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLoglastTime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbApp As ListBox
End Class
