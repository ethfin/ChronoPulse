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
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel5.Location = New System.Drawing.Point(55, 55)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Padding = New System.Windows.Forms.Padding(25)
        Me.Guna2Panel5.Size = New System.Drawing.Size(1138, 542)
        Me.Guna2Panel5.TabIndex = 2
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(30, 52)
        Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(79, 41)
        Me.Guna2HtmlLabel7.TabIndex = 1
        Me.Guna2HtmlLabel7.Text = "0.00"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("DM Sans 14pt", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(30, 30)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(117, 22)
        Me.Guna2HtmlLabel8.TabIndex = 0
        Me.Guna2HtmlLabel8.Text = "TOTAL EXPENSE:"
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
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
