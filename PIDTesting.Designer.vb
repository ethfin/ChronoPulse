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
        Me.cmbApplications = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.timerAppCheck = New System.Windows.Forms.Timer(Me.components)
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
        Me.btnStart.Location = New System.Drawing.Point(78, 109)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(180, 45)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Guna2Button1"
        '
        'cmbApplications
        '
        Me.cmbApplications.BackColor = System.Drawing.Color.Transparent
        Me.cmbApplications.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbApplications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbApplications.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbApplications.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbApplications.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbApplications.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbApplications.ItemHeight = 30
        Me.cmbApplications.Location = New System.Drawing.Point(386, 129)
        Me.cmbApplications.Name = "cmbApplications"
        Me.cmbApplications.Size = New System.Drawing.Size(140, 36)
        Me.cmbApplications.TabIndex = 1
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(249, 243)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(39, 13)
        Me.lblElapsedTime.TabIndex = 2
        Me.lblElapsedTime.Text = "Label1"
        '
        'timerAppCheck
        '
        '
        'PIDTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblElapsedTime)
        Me.Controls.Add(Me.cmbApplications)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "PIDTesting"
        Me.Text = "PIDTesting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbApplications As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents timerAppCheck As Timer
End Class
