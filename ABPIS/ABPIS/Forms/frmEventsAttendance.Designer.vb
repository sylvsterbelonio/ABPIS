<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventsAttendance
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventsAttendance))
        Me.dgvDistrict = New System.Windows.Forms.DataGridView
        Me.dgvGroup = New System.Windows.Forms.DataGridView
        Me.dgvMember = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.txtDistrict = New System.Windows.Forms.TextBox
        Me.txtGroup = New System.Windows.Forms.TextBox
        Me.cmdUpdate = New PowerNET8.My8Button
        Me.cboMode = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblGroup = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSGroup = New System.Windows.Forms.Label
        Me.lblSDistrict = New System.Windows.Forms.Label
        Me.cmdPrint = New PowerNET8.My8Button
        CType(Me.dgvDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDistrict
        '
        Me.dgvDistrict.AllowUserToAddRows = False
        Me.dgvDistrict.AllowUserToDeleteRows = False
        Me.dgvDistrict.AllowUserToResizeColumns = False
        Me.dgvDistrict.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDistrict.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDistrict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDistrict.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDistrict.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvDistrict.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDistrict.GridColor = System.Drawing.Color.White
        Me.dgvDistrict.Location = New System.Drawing.Point(3, 31)
        Me.dgvDistrict.MultiSelect = False
        Me.dgvDistrict.Name = "dgvDistrict"
        Me.dgvDistrict.ReadOnly = True
        Me.dgvDistrict.RowHeadersVisible = False
        Me.dgvDistrict.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDistrict.Size = New System.Drawing.Size(268, 347)
        Me.dgvDistrict.TabIndex = 1
        '
        'dgvGroup
        '
        Me.dgvGroup.AllowUserToAddRows = False
        Me.dgvGroup.AllowUserToDeleteRows = False
        Me.dgvGroup.AllowUserToResizeColumns = False
        Me.dgvGroup.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.dgvGroup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGroup.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvGroup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGroup.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvGroup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGroup.GridColor = System.Drawing.Color.White
        Me.dgvGroup.Location = New System.Drawing.Point(277, 31)
        Me.dgvGroup.MultiSelect = False
        Me.dgvGroup.Name = "dgvGroup"
        Me.dgvGroup.ReadOnly = True
        Me.dgvGroup.RowHeadersVisible = False
        Me.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGroup.Size = New System.Drawing.Size(268, 347)
        Me.dgvGroup.TabIndex = 2
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        Me.dgvMember.AllowUserToResizeColumns = False
        Me.dgvMember.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvMember.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMember.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvMember.GridColor = System.Drawing.Color.White
        Me.dgvMember.Location = New System.Drawing.Point(551, 5)
        Me.dgvMember.MultiSelect = False
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.Size = New System.Drawing.Size(385, 373)
        Me.dgvMember.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 192
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 310
        '
        'Column3
        '
        Me.Column3.HeaderText = "Attended"
        Me.Column3.MinimumWidth = 10
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'txtDistrict
        '
        Me.txtDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDistrict.Location = New System.Drawing.Point(3, 5)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(268, 20)
        Me.txtDistrict.TabIndex = 4
        '
        'txtGroup
        '
        Me.txtGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGroup.Location = New System.Drawing.Point(277, 5)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(268, 20)
        Me.txtGroup.TabIndex = 5
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BorderColors = System.Drawing.Color.White
        Me.cmdUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpdate.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdUpdate.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdUpdate.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.disk
        Me.cmdUpdate.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdUpdate.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdUpdate.Location = New System.Drawing.Point(844, 383)
        Me.cmdUpdate.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdUpdate.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdUpdate.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdUpdate.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(92, 36)
        Me.cmdUpdate.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdUpdate.TabIndex = 14
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cboMode
        '
        Me.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMode.FormattingEnabled = True
        Me.cboMode.Items.AddRange(New Object() {"Selection Mode"})
        Me.cboMode.Location = New System.Drawing.Point(598, 392)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(121, 21)
        Me.cboMode.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(553, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "MODE"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(277, 383)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(108, 13)
        Me.lblGroup.TabIndex = 17
        Me.lblGroup.Text = "SELECTED GROUP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "SELECTED DISTRICT:"
        '
        'lblSGroup
        '
        Me.lblSGroup.AutoSize = True
        Me.lblSGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSGroup.Location = New System.Drawing.Point(289, 400)
        Me.lblSGroup.Name = "lblSGroup"
        Me.lblSGroup.Size = New System.Drawing.Size(11, 13)
        Me.lblSGroup.TabIndex = 19
        Me.lblSGroup.Text = "-"
        '
        'lblSDistrict
        '
        Me.lblSDistrict.AutoSize = True
        Me.lblSDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDistrict.Location = New System.Drawing.Point(23, 400)
        Me.lblSDistrict.Name = "lblSDistrict"
        Me.lblSDistrict.Size = New System.Drawing.Size(11, 13)
        Me.lblSDistrict.TabIndex = 20
        Me.lblSDistrict.Text = "-"
        '
        'cmdPrint
        '
        Me.cmdPrint.BorderColors = System.Drawing.Color.White
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdPrint.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdPrint.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.print
        Me.cmdPrint.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdPrint.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdPrint.Location = New System.Drawing.Point(746, 383)
        Me.cmdPrint.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPrint.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPrint.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPrint.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(92, 36)
        Me.cmdPrint.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPrint.TabIndex = 21
        Me.cmdPrint.Text = "Preview"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'frmEventsAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 423)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.lblSDistrict)
        Me.Controls.Add(Me.lblSGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.txtDistrict)
        Me.Controls.Add(Me.dgvMember)
        Me.Controls.Add(Me.dgvGroup)
        Me.Controls.Add(Me.dgvDistrict)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEventsAttendance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Editor"
        CType(Me.dgvDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDistrict As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGroup As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMember As System.Windows.Forms.DataGridView
    Friend WithEvents txtDistrict As System.Windows.Forms.TextBox
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpdate As PowerNET8.My8Button
    Friend WithEvents cboMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSGroup As System.Windows.Forms.Label
    Friend WithEvents lblSDistrict As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As PowerNET8.My8Button
End Class
