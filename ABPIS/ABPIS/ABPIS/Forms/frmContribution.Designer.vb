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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContribution))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsAdd = New System.Windows.Forms.ToolStripButton
        Me.tsEdit = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsCancel = New System.Windows.Forms.ToolStripButton
        Me.tsPrint = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOrNo = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtNameMember = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtOther = New PowerNET8.My8TextBox
        Me.lblOther = New System.Windows.Forms.Label
        Me.udDtpayment = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udDtpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsSave, Me.tsCancel, Me.tsPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(483, 38)
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
        Me.GroupBox1.Controls.Add(Me.txtOrNo)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtNameMember)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtOther)
        Me.GroupBox1.Controls.Add(Me.lblOther)
        Me.GroupBox1.Controls.Add(Me.udDtpayment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name of Member"
        '
        'txtOrNo
        '
        Me.txtOrNo.Location = New System.Drawing.Point(109, 29)
        Me.txtOrNo.Name = "txtOrNo"
        Me.txtOrNo.Size = New System.Drawing.Size(139, 20)
        Me.txtOrNo.TabIndex = 14
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(109, 129)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(324, 20)
        Me.txtAmount.TabIndex = 13
        '
        'txtNameMember
        '
        Me.txtNameMember.Location = New System.Drawing.Point(109, 64)
        Me.txtNameMember.Name = "txtNameMember"
        Me.txtNameMember.ReadOnly = True
        Me.txtNameMember.Size = New System.Drawing.Size(324, 20)
        Me.txtNameMember.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Amount"
        '
        'txtOther
        '
        Me.txtOther.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtOther.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtOther.BackColor = System.Drawing.SystemColors.Window
        Me.txtOther.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOther.Location = New System.Drawing.Point(311, 92)
        Me.txtOther.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtOther.MaxLength = 32767
        Me.txtOther.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtOther.My_AllowCustom_Colors = False
        Me.txtOther.My_ClearButton = False
        Me.txtOther.My_GotFocus_Backcolor = System.Drawing.Color.Beige
        Me.txtOther.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtOther.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtOther.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtOther.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtOther.My_SearchButton_AutoClear = True
        Me.txtOther.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtOther.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtOther.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOther.ReadOnly_ = False
        Me.txtOther.Size = New System.Drawing.Size(122, 26)
        Me.txtOther.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtOther.TabIndex = 9
        Me.txtOther.Text_ = ""
        Me.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtOther.Visible = False
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(254, 97)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(42, 13)
        Me.lblOther.TabIndex = 8
        Me.lblOther.Text = "Specify"
        Me.lblOther.Visible = False
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
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"CFS", "RCF", "MF", "Donation", "Outreach Donation", "Church Donation", "Loan Payment", "Others"})
        Me.cboStatus.Location = New System.Drawing.Point(108, 94)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(325, 21)
        Me.cboStatus.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type of Payment"
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
        'frmContribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(483, 226)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOther As PowerNET8.My8TextBox
    Friend WithEvents lblOther As System.Windows.Forms.Label
    Friend WithEvents udDtpayment As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNameMember As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtOrNo As System.Windows.Forms.TextBox
End Class
