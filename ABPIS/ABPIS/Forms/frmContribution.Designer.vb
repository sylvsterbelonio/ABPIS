<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContribution
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContribution))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsAdd = New System.Windows.Forms.ToolStripButton
        Me.tsEdit = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsCancel = New System.Windows.Forms.ToolStripButton
        Me.tsPrint = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvList = New System.Windows.Forms.DataGridView
        Me.txtOrNo = New System.Windows.Forms.TextBox
        Me.txtNameMember = New System.Windows.Forms.TextBox
        Me.udDtpayment = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udDtpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsSave, Me.tsCancel, Me.tsPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(458, 38)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'tsPrint
        '
        Me.tsPrint.ForeColor = System.Drawing.Color.White
        Me.tsPrint.Image = Global.ABPIS.My.Resources.Resources.printer_1_icon
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(36, 35)
        Me.tsPrint.Text = "Print"
        Me.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.dgvList)
        Me.GroupBox1.Controls.Add(Me.txtOrNo)
        Me.GroupBox1.Controls.Add(Me.txtNameMember)
        Me.GroupBox1.Controls.Add(Me.udDtpayment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name of Member"
        '
        'dgvList
        '
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvList.GridColor = System.Drawing.Color.White
        Me.dgvList.Location = New System.Drawing.Point(16, 94)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.Size = New System.Drawing.Size(416, 196)
        Me.dgvList.TabIndex = 18
        '
        'txtOrNo
        '
        Me.txtOrNo.Location = New System.Drawing.Point(109, 29)
        Me.txtOrNo.Name = "txtOrNo"
        Me.txtOrNo.Size = New System.Drawing.Size(139, 20)
        Me.txtOrNo.TabIndex = 14
        '
        'txtNameMember
        '
        Me.txtNameMember.Location = New System.Drawing.Point(109, 64)
        Me.txtNameMember.Name = "txtNameMember"
        Me.txtNameMember.ReadOnly = True
        Me.txtNameMember.Size = New System.Drawing.Size(324, 20)
        Me.txtNameMember.TabIndex = 12
        '
        'udDtpayment
        '
        Me.udDtpayment.DateTime = New Date(2015, 7, 18, 0, 0, 0, 0)
        Me.udDtpayment.Location = New System.Drawing.Point(341, 29)
        Me.udDtpayment.Name = "udDtpayment"
        Me.udDtpayment.Size = New System.Drawing.Size(93, 21)
        Me.udDtpayment.TabIndex = 3
        Me.udDtpayment.Value = New Date(2015, 7, 18, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date of Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "O.R. No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name of Member"
        '
        'Column1
        '
        DataGridViewCellStyle2.NullValue = " "
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Type of Payment"
        Me.Column1.Items.AddRange(New Object() {"Community Financial Support - Tithes", "Resource Center Fund - Buiding", "Mission Fund", "CYA Donation", "Donation", "Mortuary", "Membership Mortuary", "Coop Membership", "Outreach Donation", "Church Donation", "Loan Payment - GF", "Loan Payment - COOP", "Interest", "Service Charge", "Alms Fund", "Others", " "})
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Other Speciry"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle3.NullValue = " "
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Journal Entry"
        Me.Column3.Items.AddRange(New Object() {"Debit", "Credit", " "})
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 67
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 85
        '
        'frmContribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(458, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contribution"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udDtpayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents udDtpayment As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNameMember As System.Windows.Forms.TextBox
    Friend WithEvents txtOrNo As System.Windows.Forms.TextBox
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
