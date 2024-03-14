<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvents))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optMembers = New System.Windows.Forms.RadioButton
        Me.optLeaders = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.optDistrict = New System.Windows.Forms.RadioButton
        Me.cboFormat = New System.Windows.Forms.ComboBox
        Me.txtTime = New System.Windows.Forms.MaskedTextBox
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.udtDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtFacilator = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvParticipants = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpSelection = New System.Windows.Forms.GroupBox
        Me.grpListAll = New System.Windows.Forms.GroupBox
        Me.txtSearchList = New System.Windows.Forms.TextBox
        Me.dgvList = New System.Windows.Forms.DataGridView
        Me.cmdReset = New System.Windows.Forms.Button
        Me.cmdRemove = New System.Windows.Forms.Button
        Me.cmdSelect = New System.Windows.Forms.Button
        Me.cmdSelectAll = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.tsAdd = New System.Windows.Forms.ToolStripButton
        Me.tsEdit = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsCancel = New System.Windows.Forms.ToolStripButton
        Me.tsAttendance = New System.Windows.Forms.ToolStripButton
        Me.tsPrints = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsDistrict = New System.Windows.Forms.ToolStripMenuItem
        Me.tsLeaders = New System.Windows.Forms.ToolStripMenuItem
        Me.tsMembers = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParticipants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelection.SuspendLayout()
        Me.grpListAll.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsSave, Me.tsCancel, Me.tsAttendance, Me.tsPrints})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(844, 38)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.optMembers)
        Me.GroupBox1.Controls.Add(Me.optLeaders)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.optDistrict)
        Me.GroupBox1.Controls.Add(Me.cboFormat)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.udtDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtFacilator)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 287)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name of Member"
        '
        'optMembers
        '
        Me.optMembers.AutoSize = True
        Me.optMembers.Location = New System.Drawing.Point(236, 229)
        Me.optMembers.Name = "optMembers"
        Me.optMembers.Size = New System.Drawing.Size(83, 17)
        Me.optMembers.TabIndex = 15
        Me.optMembers.Text = "By Members"
        Me.optMembers.UseVisualStyleBackColor = True
        '
        'optLeaders
        '
        Me.optLeaders.AutoSize = True
        Me.optLeaders.Location = New System.Drawing.Point(109, 252)
        Me.optLeaders.Name = "optLeaders"
        Me.optLeaders.Size = New System.Drawing.Size(119, 17)
        Me.optLeaders.TabIndex = 14
        Me.optLeaders.Text = "By Pastoral Leaders"
        Me.optLeaders.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Type"
        '
        'optDistrict
        '
        Me.optDistrict.AutoSize = True
        Me.optDistrict.Checked = True
        Me.optDistrict.Location = New System.Drawing.Point(109, 229)
        Me.optDistrict.Name = "optDistrict"
        Me.optDistrict.Size = New System.Drawing.Size(72, 17)
        Me.optDistrict.TabIndex = 12
        Me.optDistrict.TabStop = True
        Me.optDistrict.Text = "By District"
        Me.optDistrict.UseVisualStyleBackColor = True
        '
        'cboFormat
        '
        Me.cboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormat.FormattingEnabled = True
        Me.cboFormat.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboFormat.Location = New System.Drawing.Point(380, 185)
        Me.cboFormat.Name = "cboFormat"
        Me.cboFormat.Size = New System.Drawing.Size(53, 21)
        Me.cboFormat.TabIndex = 11
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(315, 186)
        Me.txtTime.Mask = "00:00"
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(59, 20)
        Me.txtTime.TabIndex = 10
        '
        'txtLocation
        '
        Me.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocation.Location = New System.Drawing.Point(109, 154)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(324, 20)
        Me.txtLocation.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Location/Venue"
        '
        'udtDate
        '
        Me.udtDate.DateTime = New Date(2015, 7, 18, 0, 0, 0, 0)
        Me.udtDate.Location = New System.Drawing.Point(216, 186)
        Me.udtDate.Name = "udtDate"
        Me.udtDate.Size = New System.Drawing.Size(93, 21)
        Me.udtDate.TabIndex = 9
        Me.udtDate.Value = New Date(2015, 7, 18, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date and Time"
        '
        'txtTitle
        '
        Me.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitle.Location = New System.Drawing.Point(109, 29)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(324, 20)
        Me.txtTitle.TabIndex = 1
        '
        'txtFacilator
        '
        Me.txtFacilator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacilator.Location = New System.Drawing.Point(109, 128)
        Me.txtFacilator.Name = "txtFacilator"
        Me.txtFacilator.Size = New System.Drawing.Size(324, 20)
        Me.txtFacilator.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(109, 55)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(324, 67)
        Me.txtDescription.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Facilitator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description"
        '
        'dgvParticipants
        '
        Me.dgvParticipants.AllowUserToAddRows = False
        Me.dgvParticipants.AllowUserToDeleteRows = False
        Me.dgvParticipants.AllowUserToResizeColumns = False
        Me.dgvParticipants.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvParticipants.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvParticipants.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParticipants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvParticipants.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvParticipants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvParticipants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvParticipants.GridColor = System.Drawing.Color.White
        Me.dgvParticipants.Location = New System.Drawing.Point(3, 16)
        Me.dgvParticipants.Name = "dgvParticipants"
        Me.dgvParticipants.ReadOnly = True
        Me.dgvParticipants.RowHeadersVisible = False
        Me.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParticipants.Size = New System.Drawing.Size(390, 296)
        Me.dgvParticipants.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.HeaderText = "IID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column3
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'grpSelection
        '
        Me.grpSelection.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSelection.Controls.Add(Me.dgvParticipants)
        Me.grpSelection.Location = New System.Drawing.Point(3, 343)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(396, 315)
        Me.grpSelection.TabIndex = 2
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "SELECTED "
        '
        'grpListAll
        '
        Me.grpListAll.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpListAll.Controls.Add(Me.txtSearchList)
        Me.grpListAll.Controls.Add(Me.dgvList)
        Me.grpListAll.Location = New System.Drawing.Point(456, 67)
        Me.grpListAll.Name = "grpListAll"
        Me.grpListAll.Size = New System.Drawing.Size(385, 594)
        Me.grpListAll.TabIndex = 3
        Me.grpListAll.TabStop = False
        Me.grpListAll.Text = "Participants"
        '
        'txtSearchList
        '
        Me.txtSearchList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchList.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearchList.Location = New System.Drawing.Point(3, 16)
        Me.txtSearchList.Name = "txtSearchList"
        Me.txtSearchList.Size = New System.Drawing.Size(379, 20)
        Me.txtSearchList.TabIndex = 9
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvList.GridColor = System.Drawing.Color.White
        Me.dgvList.Location = New System.Drawing.Point(3, 36)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(379, 555)
        Me.dgvList.TabIndex = 0
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(405, 343)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(48, 40)
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(405, 435)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(48, 40)
        Me.cmdRemove.TabIndex = 6
        Me.cmdRemove.Text = ">"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(405, 481)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(48, 40)
        Me.cmdSelect.TabIndex = 7
        Me.cmdSelect.Text = "<"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Location = New System.Drawing.Point(405, 389)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(48, 40)
        Me.cmdSelectAll.TabIndex = 8
        Me.cmdSelectAll.Text = "Select All"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(0, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(844, 20)
        Me.TextBox1.TabIndex = 10
        '
        'tsAdd
        '
        Me.tsAdd.ForeColor = System.Drawing.Color.White
        Me.tsAdd.Image = Global.ABPIS.My.Resources.Resources.add1
        Me.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAdd.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.tsAdd.Name = "tsAdd"
        Me.tsAdd.Size = New System.Drawing.Size(33, 35)
        Me.tsAdd.Text = "Add"
        Me.tsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsEdit
        '
        Me.tsEdit.ForeColor = System.Drawing.Color.White
        Me.tsEdit.Image = Global.ABPIS.My.Resources.Resources.write
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(31, 35)
        Me.tsEdit.Text = "Edit"
        Me.tsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSave
        '
        Me.tsSave.ForeColor = System.Drawing.Color.White
        Me.tsSave.Image = Global.ABPIS.My.Resources.Resources.save
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(35, 35)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCancel
        '
        Me.tsCancel.ForeColor = System.Drawing.Color.White
        Me.tsCancel.Image = Global.ABPIS.My.Resources.Resources._erase
        Me.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCancel.Name = "tsCancel"
        Me.tsCancel.Size = New System.Drawing.Size(47, 35)
        Me.tsCancel.Text = "Cancel"
        Me.tsCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsAttendance
        '
        Me.tsAttendance.ForeColor = System.Drawing.Color.White
        Me.tsAttendance.Image = Global.ABPIS.My.Resources.Resources.attendance
        Me.tsAttendance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAttendance.Name = "tsAttendance"
        Me.tsAttendance.Size = New System.Drawing.Size(72, 35)
        Me.tsAttendance.Text = "Attendance"
        Me.tsAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsAttendance.Visible = False
        '
        'tsPrints
        '
        Me.tsPrints.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttendanceToolStripMenuItem})
        Me.tsPrints.ForeColor = System.Drawing.Color.White
        Me.tsPrints.Image = Global.ABPIS.My.Resources.Resources.printer_1_icon
        Me.tsPrints.Name = "tsPrints"
        Me.tsPrints.Size = New System.Drawing.Size(44, 38)
        Me.tsPrints.Text = "Print"
        Me.tsPrints.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDistrict, Me.tsLeaders, Me.tsMembers})
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AttendanceToolStripMenuItem.Text = "Pre-Attendance Sheet"
        '
        'tsDistrict
        '
        Me.tsDistrict.Name = "tsDistrict"
        Me.tsDistrict.Size = New System.Drawing.Size(175, 22)
        Me.tsDistrict.Text = "By District"
        '
        'tsLeaders
        '
        Me.tsLeaders.Name = "tsLeaders"
        Me.tsLeaders.Size = New System.Drawing.Size(175, 22)
        Me.tsLeaders.Text = "By Pastoral Leaders"
        '
        'tsMembers
        '
        Me.tsMembers.Name = "tsMembers"
        Me.tsMembers.Size = New System.Drawing.Size(175, 22)
        Me.tsMembers.Text = "By Members"
        '
        'frmEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 665)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdSelectAll)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.grpListAll)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Events"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParticipants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelection.ResumeLayout(False)
        Me.grpListAll.ResumeLayout(False)
        Me.grpListAll.PerformLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents udtDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtFacilator As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFormat As System.Windows.Forms.ComboBox
    Friend WithEvents txtTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpSelection As System.Windows.Forms.GroupBox
    Friend WithEvents dgvParticipants As System.Windows.Forms.DataGridView
    Friend WithEvents optMembers As System.Windows.Forms.RadioButton
    Friend WithEvents optLeaders As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents optDistrict As System.Windows.Forms.RadioButton
    Friend WithEvents grpListAll As System.Windows.Forms.GroupBox
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    Friend WithEvents cmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearchList As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tsPrints As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDistrict As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLeaders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMembers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAttendance As System.Windows.Forms.ToolStripButton
End Class
