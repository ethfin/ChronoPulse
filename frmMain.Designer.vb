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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnGames = New FontAwesome.Sharp.IconButton()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.pnlSeparator1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlSeparator2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnMinimize)
        Me.pnlHeader.Controls.Add(Me.btnMaximize)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1295, 42)
        Me.pnlHeader.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.White
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 15
        Me.btnMinimize.Location = New System.Drawing.Point(1181, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(38, 42)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.Color.White
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 15
        Me.btnMaximize.Location = New System.Drawing.Point(1219, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(38, 42)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 15
        Me.btnClose.Location = New System.Drawing.Point(1257, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 42)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.Transparent
        Me.pnlSidebar.BorderRadius = 10
        Me.pnlSidebar.Controls.Add(Me.IconButton3)
        Me.pnlSidebar.Controls.Add(Me.IconButton2)
        Me.pnlSidebar.Controls.Add(Me.IconButton1)
        Me.pnlSidebar.Controls.Add(Me.btnGames)
        Me.pnlSidebar.Controls.Add(Me.Guna2Separator3)
        Me.pnlSidebar.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlSidebar.Controls.Add(Me.Guna2Separator4)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlSidebar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlSidebar.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlSidebar.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlSidebar.Location = New System.Drawing.Point(15, 42)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(232, 642)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnGames
        '
        Me.btnGames.BackColor = System.Drawing.Color.Transparent
        Me.btnGames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGames.FlatAppearance.BorderSize = 0
        Me.btnGames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGames.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGames.IconChar = FontAwesome.Sharp.IconChar.Gamepad
        Me.btnGames.IconColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnGames.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGames.IconSize = 40
        Me.btnGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGames.Location = New System.Drawing.Point(32, 241)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(168, 52)
        Me.btnGames.TabIndex = 0
        Me.btnGames.Text = "Games"
        Me.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGames.UseVisualStyleBackColor = False
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(0, 146)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(232, 31)
        Me.Guna2Separator3.TabIndex = 5
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(0, 31)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(232, 115)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Separator4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(232, 31)
        Me.Guna2Separator4.TabIndex = 9
        '
        'pnlSeparator1
        '
        Me.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSeparator1.Location = New System.Drawing.Point(0, 42)
        Me.pnlSeparator1.Name = "pnlSeparator1"
        Me.pnlSeparator1.Size = New System.Drawing.Size(15, 657)
        Me.pnlSeparator1.TabIndex = 0
        '
        'pnlSeparator2
        '
        Me.pnlSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSeparator2.Location = New System.Drawing.Point(15, 684)
        Me.pnlSeparator2.Name = "pnlSeparator2"
        Me.pnlSeparator2.Size = New System.Drawing.Size(1280, 15)
        Me.pnlSeparator2.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(247, 42)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(15, 642)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.Location = New System.Drawing.Point(1280, 42)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(15, 642)
        Me.Guna2Panel2.TabIndex = 4
        '
        'pnlMain
        '
        Me.pnlMain.BorderRadius = 10
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlMain.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlMain.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlMain.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(262, 42)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1018, 642)
        Me.pnlMain.TabIndex = 5
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Bolt
        Me.IconButton1.IconColor = System.Drawing.Color.Gold
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(32, 183)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(168, 52)
        Me.IconButton1.TabIndex = 14
        Me.IconButton1.Text = "Dashboard"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Chess
        Me.IconButton2.IconColor = System.Drawing.Color.LimeGreen
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(32, 295)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(168, 52)
        Me.IconButton2.TabIndex = 15
        Me.IconButton2.Text = "Leaderboard"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.RightToBracket
        Me.IconButton3.IconColor = System.Drawing.Color.Firebrick
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 40
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(32, 584)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(168, 52)
        Me.IconButton3.TabIndex = 16
        Me.IconButton3.Text = "Leaderboard"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 699)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlSeparator2)
        Me.Controls.Add(Me.pnlSeparator1)
        Me.Controls.Add(Me.pnlHeader)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents pnlSeparator1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlSeparator2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnGames As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
