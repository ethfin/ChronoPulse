﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSecurityQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecurityQuestions))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlBackground = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSQA1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSQA1Verify = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSQA2Verify = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSQA2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSQ1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbSQ2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.lblError = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblError2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNames = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.htmllblBackToLogin = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblQ1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQ2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbxShowPassword2 = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(839, 14)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(144, 73)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 44
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.CheckedState.ForeColor = System.Drawing.Color.Red
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Maroon
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClose.IndicateFocus = True
        Me.btnClose.Location = New System.Drawing.Point(1253, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 43
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseTransparentBackground = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinimize.FillColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMinimize.ForeColor = System.Drawing.Color.DimGray
        Me.btnMinimize.HoverState.FillColor = System.Drawing.Color.GhostWhite
        Me.btnMinimize.IndicateFocus = True
        Me.btnMinimize.Location = New System.Drawing.Point(1216, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 37)
        Me.btnMinimize.TabIndex = 42
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseTransparentBackground = True
        '
        'pnlBackground
        '
        Me.pnlBackground.BackgroundImage = CType(resources.GetObject("pnlBackground.BackgroundImage"), System.Drawing.Image)
        Me.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBackground.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBackground.Location = New System.Drawing.Point(0, 0)
        Me.pnlBackground.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(544, 582)
        Me.pnlBackground.TabIndex = 41
        '
        'txtSQA1
        '
        Me.txtSQA1.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA1.BorderRadius = 2
        Me.txtSQA1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA1.DefaultText = ""
        Me.txtSQA1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1.Location = New System.Drawing.Point(989, 193)
        Me.txtSQA1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSQA1.MaxLength = 20
        Me.txtSQA1.Name = "txtSQA1"
        Me.txtSQA1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA1.PlaceholderText = "Answer"
        Me.txtSQA1.SelectedText = ""
        Me.txtSQA1.Size = New System.Drawing.Size(288, 47)
        Me.txtSQA1.TabIndex = 1
        '
        'txtSQA1Verify
        '
        Me.txtSQA1Verify.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA1Verify.BorderRadius = 2
        Me.txtSQA1Verify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA1Verify.DefaultText = ""
        Me.txtSQA1Verify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA1Verify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA1Verify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1Verify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1Verify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1Verify.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA1Verify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1Verify.Location = New System.Drawing.Point(989, 247)
        Me.txtSQA1Verify.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSQA1Verify.MaxLength = 20
        Me.txtSQA1Verify.Name = "txtSQA1Verify"
        Me.txtSQA1Verify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA1Verify.PlaceholderText = "Re-enter Answer"
        Me.txtSQA1Verify.SelectedText = ""
        Me.txtSQA1Verify.Size = New System.Drawing.Size(288, 47)
        Me.txtSQA1Verify.TabIndex = 2
        '
        'txtSQA2Verify
        '
        Me.txtSQA2Verify.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA2Verify.BorderRadius = 2
        Me.txtSQA2Verify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA2Verify.DefaultText = ""
        Me.txtSQA2Verify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA2Verify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA2Verify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2Verify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2Verify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2Verify.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA2Verify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2Verify.Location = New System.Drawing.Point(989, 411)
        Me.txtSQA2Verify.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSQA2Verify.MaxLength = 20
        Me.txtSQA2Verify.Name = "txtSQA2Verify"
        Me.txtSQA2Verify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA2Verify.PlaceholderText = "Re-enter Answer"
        Me.txtSQA2Verify.SelectedText = ""
        Me.txtSQA2Verify.Size = New System.Drawing.Size(288, 47)
        Me.txtSQA2Verify.TabIndex = 5
        '
        'txtSQA2
        '
        Me.txtSQA2.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA2.BorderRadius = 2
        Me.txtSQA2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA2.DefaultText = ""
        Me.txtSQA2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2.Location = New System.Drawing.Point(989, 357)
        Me.txtSQA2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSQA2.MaxLength = 20
        Me.txtSQA2.Name = "txtSQA2"
        Me.txtSQA2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA2.PlaceholderText = "Answer"
        Me.txtSQA2.SelectedText = ""
        Me.txtSQA2.Size = New System.Drawing.Size(288, 47)
        Me.txtSQA2.TabIndex = 4
        '
        'cmbSQ1
        '
        Me.cmbSQ1.BackColor = System.Drawing.Color.Transparent
        Me.cmbSQ1.BorderColor = System.Drawing.Color.Gray
        Me.cmbSQ1.BorderRadius = 2
        Me.cmbSQ1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSQ1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSQ1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSQ1.ItemHeight = 30
        Me.cmbSQ1.Items.AddRange(New Object() {"What's your pet's name?", "What's your favorite color?", "What's your lucky number?"})
        Me.cmbSQ1.Location = New System.Drawing.Point(552, 193)
        Me.cmbSQ1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSQ1.Name = "cmbSQ1"
        Me.cmbSQ1.Size = New System.Drawing.Size(428, 36)
        Me.cmbSQ1.TabIndex = 0
        '
        'cmbSQ2
        '
        Me.cmbSQ2.BackColor = System.Drawing.Color.Transparent
        Me.cmbSQ2.BorderColor = System.Drawing.Color.Gray
        Me.cmbSQ2.BorderRadius = 2
        Me.cmbSQ2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSQ2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSQ2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSQ2.ItemHeight = 30
        Me.cmbSQ2.Items.AddRange(New Object() {"What's your pet's name?", "What's your favorite color?", "What's your lucky number?"})
        Me.cmbSQ2.Location = New System.Drawing.Point(552, 359)
        Me.cmbSQ2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSQ2.Name = "cmbSQ2"
        Me.cmbSQ2.Size = New System.Drawing.Size(428, 36)
        Me.cmbSQ2.TabIndex = 3
        '
        'btnSignUp
        '
        Me.btnSignUp.BorderRadius = 2
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.MediumTurquoise
        Me.btnSignUp.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(791, 507)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(240, 55)
        Me.btnSignUp.TabIndex = 7
        Me.btnSignUp.Text = "Sign Up"
        '
        'lblError
        '
        Me.lblError.AutoSize = False
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(589, 247)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(341, 34)
        Me.lblError.TabIndex = 52
        Me.lblError.TabStop = False
        Me.lblError.Text = "Error"
        Me.lblError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'lblError2
        '
        Me.lblError2.AutoSize = False
        Me.lblError2.BackColor = System.Drawing.Color.Transparent
        Me.lblError2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError2.ForeColor = System.Drawing.Color.Red
        Me.lblError2.Location = New System.Drawing.Point(589, 411)
        Me.lblError2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(341, 34)
        Me.lblError2.TabIndex = 53
        Me.lblError2.TabStop = False
        Me.lblError2.Text = "Error"
        Me.lblError2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError2.Visible = False
        '
        'lblNames
        '
        Me.lblNames.AutoSize = False
        Me.lblNames.BackColor = System.Drawing.Color.Transparent
        Me.lblNames.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.Location = New System.Drawing.Point(552, 105)
        Me.lblNames.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(725, 30)
        Me.lblNames.TabIndex = 54
        Me.lblNames.Text = "Security Question"
        Me.lblNames.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'htmllblBackToLogin
        '
        Me.htmllblBackToLogin.AutoSize = True
        Me.htmllblBackToLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htmllblBackToLogin.LinkColor = System.Drawing.Color.Gray
        Me.htmllblBackToLogin.Location = New System.Drawing.Point(552, 553)
        Me.htmllblBackToLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.htmllblBackToLogin.Name = "htmllblBackToLogin"
        Me.htmllblBackToLogin.Size = New System.Drawing.Size(201, 20)
        Me.htmllblBackToLogin.TabIndex = 8
        Me.htmllblBackToLogin.TabStop = True
        Me.htmllblBackToLogin.Text = "Already have an account?"
        Me.htmllblBackToLogin.VisitedLinkColor = System.Drawing.Color.White
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(1184, 553)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "← Previous"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = False
        Me.lblQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblQ1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(555, 154)
        Me.lblQ1.Margin = New System.Windows.Forms.Padding(4)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(288, 30)
        Me.lblQ1.TabIndex = 55
        Me.lblQ1.Text = "Question 1:"
        Me.lblQ1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = False
        Me.lblQ2.BackColor = System.Drawing.Color.Transparent
        Me.lblQ2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(556, 321)
        Me.lblQ2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(288, 30)
        Me.lblQ2.TabIndex = 56
        Me.lblQ2.Text = "Question 2:"
        Me.lblQ2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxShowPassword
        '
        Me.cbxShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword.CheckedState.BorderRadius = 0
        Me.cbxShowPassword.CheckedState.BorderThickness = 0
        Me.cbxShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShowPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbxShowPassword.Location = New System.Drawing.Point(1093, 303)
        Me.cbxShowPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(199, 26)
        Me.cbxShowPassword.TabIndex = 68
        Me.cbxShowPassword.Text = "Show Password"
        Me.cbxShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword.UncheckedState.BorderRadius = 0
        Me.cbxShowPassword.UncheckedState.BorderThickness = 0
        Me.cbxShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'cbxShowPassword2
        '
        Me.cbxShowPassword2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword2.CheckedState.BorderRadius = 0
        Me.cbxShowPassword2.CheckedState.BorderThickness = 0
        Me.cbxShowPassword2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShowPassword2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbxShowPassword2.Location = New System.Drawing.Point(1093, 466)
        Me.cbxShowPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxShowPassword2.Name = "cbxShowPassword2"
        Me.cbxShowPassword2.Size = New System.Drawing.Size(199, 26)
        Me.cbxShowPassword2.TabIndex = 69
        Me.cbxShowPassword2.Text = "Show Password"
        Me.cbxShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword2.UncheckedState.BorderRadius = 0
        Me.cbxShowPassword2.UncheckedState.BorderThickness = 0
        Me.cbxShowPassword2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'frmSecurityQuestions
        '
        Me.AcceptButton = Me.btnSignUp
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1293, 582)
        Me.Controls.Add(Me.cbxShowPassword2)
        Me.Controls.Add(Me.cbxShowPassword)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.lblQ1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.htmllblBackToLogin)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.lblError2)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.cmbSQ2)
        Me.Controls.Add(Me.cmbSQ1)
        Me.Controls.Add(Me.txtSQA2Verify)
        Me.Controls.Add(Me.txtSQA2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.pnlBackground)
        Me.Controls.Add(Me.txtSQA1)
        Me.Controls.Add(Me.txtSQA1Verify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSecurityQuestions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSecurityQuestions"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlBackground As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSQA1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSQA1Verify As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSQA2Verify As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSQA2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSQ1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSQ2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblError As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblError2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNames As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents htmllblBackToLogin As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblQ1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQ2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbxShowPassword2 As Guna.UI2.WinForms.Guna2CheckBox
End Class
