<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewsLetter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewsLetter))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsAdd = New System.Windows.Forms.ToolStripButton
        Me.tsEdit = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsCancel = New System.Windows.Forms.ToolStripButton
        Me.tsPrint = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtmsgFrom = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.udDtPublished = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtHeadings = New System.Windows.Forms.TextBox
        Me.txtEncodedBy = New System.Windows.Forms.TextBox
        Me.txtSubHeadings = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rtbContent = New System.Windows.Forms.RichTextBox
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.cmdUpload = New System.Windows.Forms.Button
        Me.txtFromSource = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udDtPublished, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsSave, Me.tsCancel, Me.tsPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(454, 38)
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
        Me.tsPrint.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rtbContent)
        Me.GroupBox1.Controls.Add(Me.txtFromSource)
        Me.GroupBox1.Controls.Add(Me.cmdUpload)
        Me.GroupBox1.Controls.Add(Me.txtFileName)
        Me.GroupBox1.Controls.Add(Me.txtmsgFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.udDtPublished)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHeadings)
        Me.GroupBox1.Controls.Add(Me.txtEncodedBy)
        Me.GroupBox1.Controls.Add(Me.txtSubHeadings)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 262)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name of Member"
        '
        'txtmsgFrom
        '
        Me.txtmsgFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmsgFrom.Location = New System.Drawing.Point(109, 96)
        Me.txtmsgFrom.Name = "txtmsgFrom"
        Me.txtmsgFrom.Size = New System.Drawing.Size(324, 20)
        Me.txtmsgFrom.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Message From"
        '
        'udDtPublished
        '
        Me.udDtPublished.DateTime = New Date(2015, 7, 18, 0, 0, 0, 0)
        Me.udDtPublished.Location = New System.Drawing.Point(340, 153)
        Me.udDtPublished.Name = "udDtPublished"
        Me.udDtPublished.Size = New System.Drawing.Size(93, 21)
        Me.udDtPublished.TabIndex = 9
        Me.udDtPublished.Value = New Date(2015, 7, 18, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date Published"
        '
        'txtHeadings
        '
        Me.txtHeadings.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHeadings.Location = New System.Drawing.Point(109, 18)
        Me.txtHeadings.Name = "txtHeadings"
        Me.txtHeadings.Size = New System.Drawing.Size(324, 20)
        Me.txtHeadings.TabIndex = 1
        '
        'txtEncodedBy
        '
        Me.txtEncodedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEncodedBy.Location = New System.Drawing.Point(109, 70)
        Me.txtEncodedBy.Name = "txtEncodedBy"
        Me.txtEncodedBy.Size = New System.Drawing.Size(324, 20)
        Me.txtEncodedBy.TabIndex = 5
        '
        'txtSubHeadings
        '
        Me.txtSubHeadings.Location = New System.Drawing.Point(109, 44)
        Me.txtSubHeadings.Name = "txtSubHeadings"
        Me.txtSubHeadings.Size = New System.Drawing.Size(324, 20)
        Me.txtSubHeadings.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Encoded By"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Headings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sub-Headings"
        '
        'rtbContent
        '
        Me.rtbContent.Location = New System.Drawing.Point(109, 181)
        Me.rtbContent.Margin = New System.Windows.Forms.Padding(10)
        Me.rtbContent.Name = "rtbContent"
        Me.rtbContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtbContent.Size = New System.Drawing.Size(325, 66)
        Me.rtbContent.TabIndex = 0
        Me.rtbContent.Text = ""
        Me.rtbContent.WordWrap = False
        '
        'txtFileName
        '
        Me.txtFileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFileName.Location = New System.Drawing.Point(109, 122)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(222, 20)
        Me.txtFileName.TabIndex = 10
        '
        'cmdUpload
        '
        Me.cmdUpload.Location = New System.Drawing.Point(340, 121)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(93, 23)
        Me.cmdUpload.TabIndex = 11
        Me.cmdUpload.Text = "Upload"
        Me.cmdUpload.UseVisualStyleBackColor = True
        '
        'txtFromSource
        '
        Me.txtFromSource.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFromSource.Location = New System.Drawing.Point(109, 148)
        Me.txtFromSource.Name = "txtFromSource"
        Me.txtFromSource.Size = New System.Drawing.Size(120, 20)
        Me.txtFromSource.TabIndex = 12
        Me.txtFromSource.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Remarks"
        '
        'frmNewsLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewsLetter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "News Letter"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udDtPublished, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeadings As System.Windows.Forms.TextBox
    Friend WithEvents txtEncodedBy As System.Windows.Forms.TextBox
    Friend WithEvents txtSubHeadings As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmsgFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents udDtPublished As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rtbContent As System.Windows.Forms.RichTextBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpload As System.Windows.Forms.Button
    Friend WithEvents txtFromSource As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
