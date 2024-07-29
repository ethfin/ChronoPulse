<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnGames = New FontAwesome.Sharp.IconButton()
        Me.btnLeaderboard = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.IconPictureBox1)
        Me.pnlHeader.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlHeader.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlHeader.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlHeader.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlHeader.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlHeader.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1295, 47)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnGames)
        Me.pnlSidebar.Controls.Add(Me.btnLeaderboard)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlSidebar.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlSidebar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlSidebar.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlSidebar.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 47)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(47, 652)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnGames
        '
        Me.btnGames.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGames.BackColor = System.Drawing.Color.Transparent
        Me.btnGames.FlatAppearance.BorderSize = 0
        Me.btnGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGames.ForeColor = System.Drawing.Color.Transparent
        Me.btnGames.IconChar = FontAwesome.Sharp.IconChar.Gamepad
        Me.btnGames.IconColor = System.Drawing.Color.White
        Me.btnGames.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGames.IconSize = 25
        Me.btnGames.Location = New System.Drawing.Point(4, 94)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(38, 38)
        Me.btnGames.TabIndex = 2
        Me.btnGames.UseVisualStyleBackColor = False
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLeaderboard.BackColor = System.Drawing.Color.Transparent
        Me.btnLeaderboard.FlatAppearance.BorderSize = 0
        Me.btnLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaderboard.ForeColor = System.Drawing.Color.Transparent
        Me.btnLeaderboard.IconChar = FontAwesome.Sharp.IconChar.PieChart
        Me.btnLeaderboard.IconColor = System.Drawing.Color.White
        Me.btnLeaderboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLeaderboard.IconSize = 25
        Me.btnLeaderboard.Location = New System.Drawing.Point(4, 50)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(38, 38)
        Me.btnLeaderboard.TabIndex = 1
        Me.btnLeaderboard.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.Transparent
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House
        Me.btnDashboard.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 25
        Me.btnDashboard.Location = New System.Drawing.Point(4, 6)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(38, 38)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(47, 47)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1248, 652)
        Me.pnlMain.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("DM Sans 14pt Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(47, 7)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(184, 33)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "CHRONOPULSE"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 699)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGames As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLeaderboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
