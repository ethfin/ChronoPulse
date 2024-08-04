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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblHeaderTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.picLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picUserIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnExpenses = New FontAwesome.Sharp.IconButton()
        Me.btnCategory = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnGames = New FontAwesome.Sharp.IconButton()
        Me.btnLeaderboard = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblUsername)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Controls.Add(Me.picUserIcon)
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
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = False
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("DM Sans 14pt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1078, 12)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblUsername.Size = New System.Drawing.Size(163, 29)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "USER#0001"
        Me.lblUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = False
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderTitle.Font = New System.Drawing.Font("DM Sans 14pt Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(53, 7)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(228, 33)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "CHRONOPULSE"
        Me.lblHeaderTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.picLogo.Image = Global.ChronoPulse.My.Resources.Resources.ChronoPulse_Logo
        Me.picLogo.ImageRotate = 0!
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(47, 47)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'picUserIcon
        '
        Me.picUserIcon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picUserIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.picUserIcon.IconChar = FontAwesome.Sharp.IconChar.User
        Me.picUserIcon.IconColor = System.Drawing.Color.White
        Me.picUserIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.picUserIcon.Location = New System.Drawing.Point(1249, 6)
        Me.picUserIcon.Margin = New System.Windows.Forms.Padding(5)
        Me.picUserIcon.Name = "picUserIcon"
        Me.picUserIcon.Size = New System.Drawing.Size(32, 35)
        Me.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUserIcon.TabIndex = 0
        Me.picUserIcon.TabStop = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnExpenses)
        Me.pnlSidebar.Controls.Add(Me.btnCategory)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
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
        'btnExpenses
        '
        Me.btnExpenses.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExpenses.BackColor = System.Drawing.Color.Transparent
        Me.btnExpenses.FlatAppearance.BorderSize = 0
        Me.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpenses.ForeColor = System.Drawing.Color.Transparent
        Me.btnExpenses.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.btnExpenses.IconColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExpenses.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExpenses.IconSize = 25
        Me.btnExpenses.Location = New System.Drawing.Point(4, 182)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(38, 38)
        Me.btnExpenses.TabIndex = 5
        Me.btnExpenses.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCategory.BackColor = System.Drawing.Color.Transparent
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.ForeColor = System.Drawing.Color.Transparent
        Me.btnCategory.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnCategory.IconColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCategory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCategory.IconSize = 25
        Me.btnCategory.Location = New System.Drawing.Point(4, 138)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(38, 38)
        Me.btnCategory.TabIndex = 4
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.btnLogout.IconColor = System.Drawing.Color.Red
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 25
        Me.btnLogout.Location = New System.Drawing.Point(4, 602)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(38, 38)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.btnGames.IconColor = System.Drawing.SystemColors.MenuHighlight
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
        Me.btnLeaderboard.IconColor = System.Drawing.SystemColors.MenuHighlight
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
        Me.btnDashboard.IconColor = System.Drawing.SystemColors.MenuHighlight
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
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlMain.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.Transparent
        Me.pnlMain.FillColor2 = System.Drawing.Color.Transparent
        Me.pnlMain.FillColor3 = System.Drawing.Color.Transparent
        Me.pnlMain.FillColor4 = System.Drawing.Color.Transparent
        Me.pnlMain.Location = New System.Drawing.Point(47, 47)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1248, 652)
        Me.pnlMain.TabIndex = 2
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
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGames As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLeaderboard As FontAwesome.Sharp.IconButton
    Friend WithEvents lblHeaderTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents picUserIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExpenses As FontAwesome.Sharp.IconButton
End Class
