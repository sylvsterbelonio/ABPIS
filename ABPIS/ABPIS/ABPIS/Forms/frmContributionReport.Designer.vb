<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContributionReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContributionReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMembers = New System.Windows.Forms.TextBox
        Me.cboOtherSpecify = New System.Windows.Forms.ComboBox
        Me.cmdPrint = New PowerNET8.My8Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboTypeReport = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboTypeOfPayment = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboPeriodType = New System.Windows.Forms.ComboBox
        Me.cmdNext = New PowerNET8.My8Button
        Me.cmdPrev = New PowerNET8.My8Button
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.chkBGroup = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.chkBGroup)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMembers)
        Me.GroupBox1.Controls.Add(Me.cboOtherSpecify)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboTypeReport)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboTypeOfPayment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPeriodType)
        Me.GroupBox1.Controls.Add(Me.cmdNext)
        Me.GroupBox1.Controls.Add(Me.cmdPrev)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboMonth)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 204)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Select Member"
        '
        'txtMembers
        '
        Me.txtMembers.Location = New System.Drawing.Point(114, 74)
        Me.txtMembers.Name = "txtMembers"
        Me.txtMembers.ReadOnly = True
        Me.txtMembers.Size = New System.Drawing.Size(233, 20)
        Me.txtMembers.TabIndex = 46
        Me.txtMembers.Visible = False
        '
        'cboOtherSpecify
        '
        Me.cboOtherSpecify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOtherSpecify.FormattingEnabled = True
        Me.cboOtherSpecify.Items.AddRange(New Object() {"By Month", "By Quarter", "By Year"})
        Me.cboOtherSpecify.Location = New System.Drawing.Point(115, 73)
        Me.cboOtherSpecify.Name = "cboOtherSpecify"
        Me.cboOtherSpecify.Size = New System.Drawing.Size(233, 21)
        Me.cboOtherSpecify.TabIndex = 45
        Me.cboOtherSpecify.Visible = False
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
        Me.cmdPrint.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.scroll
        Me.cmdPrint.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdPrint.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdPrint.Location = New System.Drawing.Point(114, 156)
        Me.cmdPrint.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPrint.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPrint.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPrint.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(234, 36)
        Me.cmdPrint.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPrint.TabIndex = 44
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Type of Report"
        '
        'cboTypeReport
        '
        Me.cboTypeReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeReport.FormattingEnabled = True
        Me.cboTypeReport.Items.AddRange(New Object() {"By District", "By Leaders", "By Members", "By Summary", "By OR Members"})
        Me.cboTypeReport.Location = New System.Drawing.Point(115, 18)
        Me.cboTypeReport.Name = "cboTypeReport"
        Me.cboTypeReport.Size = New System.Drawing.Size(233, 21)
        Me.cboTypeReport.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Type of Payment"
        '
        'cboTypeOfPayment
        '
        Me.cboTypeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeOfPayment.FormattingEnabled = True
        Me.cboTypeOfPayment.Items.AddRange(New Object() {"By Month", "By Quarter", "By Year"})
        Me.cboTypeOfPayment.Location = New System.Drawing.Point(115, 45)
        Me.cboTypeOfPayment.Name = "cboTypeOfPayment"
        Me.cboTypeOfPayment.Size = New System.Drawing.Size(233, 21)
        Me.cboTypeOfPayment.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Period Type"
        '
        'cboPeriodType
        '
        Me.cboPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodType.FormattingEnabled = True
        Me.cboPeriodType.Items.AddRange(New Object() {"By Month", "By Quarter", "By Year"})
        Me.cboPeriodType.Location = New System.Drawing.Point(114, 100)
        Me.cboPeriodType.Name = "cboPeriodType"
        Me.cboPeriodType.Size = New System.Drawing.Size(233, 21)
        Me.cboPeriodType.TabIndex = 38
        '
        'cmdNext
        '
        Me.cmdNext.BorderColors = System.Drawing.Color.White
        Me.cmdNext.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNext.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdNext.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdNext.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdNext.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdNext.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdNext.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdNext.Location = New System.Drawing.Point(324, 128)
        Me.cmdNext.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdNext.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdNext.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdNext.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(23, 22)
        Me.cmdNext.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdNext.TabIndex = 37
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        Me.cmdNext.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdPrev
        '
        Me.cmdPrev.BorderColors = System.Drawing.Color.White
        Me.cmdPrev.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrev.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdPrev.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdPrev.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdPrev.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdPrev.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdPrev.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdPrev.Location = New System.Drawing.Point(265, 128)
        Me.cmdPrev.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPrev.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPrev.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPrev.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(23, 22)
        Me.cmdPrev.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPrev.TabIndex = 36
        Me.cmdPrev.Text = "<"
        Me.cmdPrev.UseVisualStyleBackColor = True
        Me.cmdPrev.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(289, 129)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(33, 20)
        Me.txtYear.TabIndex = 35
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Date of Payment"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "-"})
        Me.cboMonth.Location = New System.Drawing.Point(114, 129)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(145, 21)
        Me.cboMonth.TabIndex = 33
        Me.cboMonth.Visible = False
        '
        'chkBGroup
        '
        Me.chkBGroup.AutoSize = True
        Me.chkBGroup.Location = New System.Drawing.Point(115, 47)
        Me.chkBGroup.Name = "chkBGroup"
        Me.chkBGroup.Size = New System.Drawing.Size(76, 17)
        Me.chkBGroup.TabIndex = 48
        Me.chkBGroup.Text = "By Group?"
        Me.chkBGroup.UseVisualStyleBackColor = True
        Me.chkBGroup.Visible = False
        '
        'frmContributionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 217)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmContributionReport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contribution Summary Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTypeOfPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdNext As PowerNET8.My8Button
    Friend WithEvents cmdPrev As PowerNET8.My8Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTypeReport As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPrint As PowerNET8.My8Button
    Friend WithEvents cboOtherSpecify As System.Windows.Forms.ComboBox
    Friend WithEvents txtMembers As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkBGroup As System.Windows.Forms.CheckBox
End Class
