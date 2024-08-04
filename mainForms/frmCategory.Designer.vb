<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlCategoryContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDisable = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvCategories = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlContainer.SuspendLayout()
        Me.pnlCategoryContainer.SuspendLayout()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlContainer.Controls.Add(Me.pnlCategoryContainer)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(50)
        Me.pnlContainer.Size = New System.Drawing.Size(1248, 652)
        Me.pnlContainer.TabIndex = 2
        '
        'pnlCategoryContainer
        '
        Me.pnlCategoryContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCategoryContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlCategoryContainer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlCategoryContainer.BorderThickness = 1
        Me.pnlCategoryContainer.Controls.Add(Me.btnDisable)
        Me.pnlCategoryContainer.Controls.Add(Me.btnClear)
        Me.pnlCategoryContainer.Controls.Add(Me.btnUpdate)
        Me.pnlCategoryContainer.Controls.Add(Me.btnAdd)
        Me.pnlCategoryContainer.Controls.Add(Me.txtStatus)
        Me.pnlCategoryContainer.Controls.Add(Me.lblStatus)
        Me.pnlCategoryContainer.Controls.Add(Me.txtType)
        Me.pnlCategoryContainer.Controls.Add(Me.lblType)
        Me.pnlCategoryContainer.Controls.Add(Me.txtCategory)
        Me.pnlCategoryContainer.Controls.Add(Me.lblCategory)
        Me.pnlCategoryContainer.Controls.Add(Me.dgvCategories)
        Me.pnlCategoryContainer.Location = New System.Drawing.Point(55, 55)
        Me.pnlCategoryContainer.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlCategoryContainer.Name = "pnlCategoryContainer"
        Me.pnlCategoryContainer.Padding = New System.Windows.Forms.Padding(25)
        Me.pnlCategoryContainer.Size = New System.Drawing.Size(1138, 542)
        Me.pnlCategoryContainer.TabIndex = 2
        '
        'btnDisable
        '
        Me.btnDisable.BorderRadius = 5
        Me.btnDisable.BorderThickness = 1
        Me.btnDisable.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDisable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDisable.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDisable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDisable.Font = New System.Drawing.Font("DM Sans 14pt", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDisable.ForeColor = System.Drawing.Color.White
        Me.btnDisable.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnDisable.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnDisable.IndicateFocus = True
        Me.btnDisable.Location = New System.Drawing.Point(139, 349)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(105, 45)
        Me.btnDisable.TabIndex = 6
        Me.btnDisable.Text = "Disable"
        '
        'btnClear
        '
        Me.btnClear.BorderRadius = 5
        Me.btnClear.BorderThickness = 1
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("DM Sans 14pt", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.FillColor = System.Drawing.Color.White
        Me.btnClear.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnClear.IndicateFocus = True
        Me.btnClear.Location = New System.Drawing.Point(28, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 45)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 5
        Me.btnUpdate.BorderThickness = 1
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("DM Sans 14pt", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.IndicateFocus = True
        Me.btnUpdate.Location = New System.Drawing.Point(139, 298)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 45)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        '
        'btnAdd
        '
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("DM Sans 14pt", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.Lime
        Me.btnAdd.IndicateFocus = True
        Me.btnAdd.Location = New System.Drawing.Point(28, 298)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 45)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        '
        'txtStatus
        '
        Me.txtStatus.BorderColor = System.Drawing.Color.Transparent
        Me.txtStatus.BorderThickness = 0
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatus.DefaultText = ""
        Me.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.Font = New System.Drawing.Font("Inter", 14.25!)
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.Location = New System.Drawing.Point(29, 255)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PlaceholderText = "..."
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.Size = New System.Drawing.Size(248, 36)
        Me.txtStatus.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("DM Sans 14pt", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(28, 208)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(97, 40)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.TabStop = False
        Me.lblStatus.Text = "Status"
        '
        'txtType
        '
        Me.txtType.BorderColor = System.Drawing.Color.Transparent
        Me.txtType.BorderThickness = 0
        Me.txtType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtType.DefaultText = ""
        Me.txtType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtType.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtType.Font = New System.Drawing.Font("Inter", 14.25!)
        Me.txtType.ForeColor = System.Drawing.Color.White
        Me.txtType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtType.Location = New System.Drawing.Point(29, 165)
        Me.txtType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtType.Name = "txtType"
        Me.txtType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtType.PlaceholderText = "..."
        Me.txtType.SelectedText = ""
        Me.txtType.Size = New System.Drawing.Size(248, 36)
        Me.txtType.TabIndex = 1
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("DM Sans 14pt", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(28, 118)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(74, 40)
        Me.lblType.TabIndex = 3
        Me.lblType.TabStop = False
        Me.lblType.Text = "Type"
        '
        'txtCategory
        '
        Me.txtCategory.BorderColor = System.Drawing.Color.Transparent
        Me.txtCategory.BorderThickness = 0
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.DefaultText = ""
        Me.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ForeColor = System.Drawing.Color.White
        Me.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(29, 75)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.PlaceholderText = "..."
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.Size = New System.Drawing.Size(248, 36)
        Me.txtCategory.TabIndex = 0
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("DM Sans 14pt", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(28, 28)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(136, 40)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.TabStop = False
        Me.lblCategory.Text = "Category"
        '
        'dgvCategories
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvCategories.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Inter Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategories.ColumnHeadersHeight = 50
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategories.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCategories.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategories.Location = New System.Drawing.Point(284, 28)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.ReadOnly = True
        Me.dgvCategories.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Inter Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvCategories.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCategories.Size = New System.Drawing.Size(826, 486)
        Me.dgvCategories.TabIndex = 0
        Me.dgvCategories.TabStop = False
        Me.dgvCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCategories.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCategories.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCategories.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCategories.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvCategories.ThemeStyle.ReadOnly = True
        Me.dgvCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCategories.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCategories.ThemeStyle.RowsStyle.Height = 22
        Me.dgvCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 652)
        Me.Controls.Add(Me.pnlContainer)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategory"
        Me.Text = "frmCategory"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlCategoryContainer.ResumeLayout(False)
        Me.pnlCategoryContainer.PerformLayout()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlCategoryContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvCategories As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDisable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
End Class
