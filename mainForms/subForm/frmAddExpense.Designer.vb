<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddExpense
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
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.ComboBox()
        Me.lblCost = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDesc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItem = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlContainer.Controls.Add(Me.DTP)
        Me.pnlContainer.Controls.Add(Me.lblDate)
        Me.pnlContainer.Controls.Add(Me.btnAdd)
        Me.pnlContainer.Controls.Add(Me.txtCost)
        Me.pnlContainer.Controls.Add(Me.txtItem)
        Me.pnlContainer.Controls.Add(Me.txtDesc)
        Me.pnlContainer.Controls.Add(Me.lblCost)
        Me.pnlContainer.Controls.Add(Me.lblDesc)
        Me.pnlContainer.Controls.Add(Me.lblItem)
        Me.pnlContainer.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(67, 62, 67, 62)
        Me.pnlContainer.Size = New System.Drawing.Size(644, 353)
        Me.pnlContainer.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(111, 232)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(73, 34)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Date:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.SystemColors.Highlight
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.Lime
        Me.btnAdd.IndicateFocus = True
        Me.btnAdd.Location = New System.Drawing.Point(267, 291)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 36)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(190, 143)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(341, 22)
        Me.txtCost.TabIndex = 20
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(190, 88)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(341, 22)
        Me.txtItem.TabIndex = 19
        '
        'txtDesc
        '
        Me.txtDesc.FormattingEnabled = True
        Me.txtDesc.Location = New System.Drawing.Point(188, 194)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(343, 24)
        Me.txtDesc.TabIndex = 18
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.Color.Transparent
        Me.lblCost.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.White
        Me.lblCost.Location = New System.Drawing.Point(115, 134)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(69, 34)
        Me.lblCost.TabIndex = 17
        Me.lblCost.Text = "Cost:"
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(29, 184)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(156, 34)
        Me.lblDesc.TabIndex = 16
        Me.lblDesc.Text = "Description:"
        '
        'lblItem
        '
        Me.lblItem.BackColor = System.Drawing.Color.Transparent
        Me.lblItem.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.Color.White
        Me.lblItem.Location = New System.Drawing.Point(115, 78)
        Me.lblItem.Margin = New System.Windows.Forms.Padding(0)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(69, 34)
        Me.lblItem.TabIndex = 15
        Me.lblItem.Text = "Item:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(29, 23)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(188, 34)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "Add Expenses"
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(190, 244)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(341, 22)
        Me.DTP.TabIndex = 23
        '
        'frmAddExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 353)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Expenses"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItem As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDesc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCost As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtDesc As ComboBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DTP As DateTimePicker
End Class
