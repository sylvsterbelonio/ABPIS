<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfilePicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfilePicker))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.cmdSearch = New PowerNET8.My8Button
        Me.gbString = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtStringBox = New System.Windows.Forms.TextBox
        Me.cboOrder = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.gbDate = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttyear = New System.Windows.Forms.MaskedTextBox
        Me.cbotmonth = New System.Windows.Forms.ComboBox
        Me.txtfyear = New System.Windows.Forms.MaskedTextBox
        Me.cbofmonth = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbSelect = New System.Windows.Forms.GroupBox
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.gbNumber = New System.Windows.Forms.GroupBox
        Me.chkreupdate = New System.Windows.Forms.CheckBox
        Me.txttNum = New System.Windows.Forms.NumericUpDown
        Me.txtfNum = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gbSuggest = New System.Windows.Forms.GroupBox
        Me.txtSuggest = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbYears = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.optYes = New System.Windows.Forms.RadioButton
        Me.optNo = New System.Windows.Forms.RadioButton
        Me.optAll = New System.Windows.Forms.RadioButton
        Me.gbString.SuspendLayout()
        Me.gbDate.SuspendLayout()
        Me.gbSelect.SuspendLayout()
        Me.gbNumber.SuspendLayout()
        CType(Me.txttNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSuggest.SuspendLayout()
        Me.gbYears.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report Field Type"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"surName", "firstName", "middleName", "nickname", "homeAddress", "resPhone", "cellPhone", "birthdate", "status", "age", "birthplace", "gender", "bloodType", "educAttainment", "employer", "occupation", "profession", "workPhone", "officeAddress", "lineAddress", "curDistrict", "yrAttended", "yrComWeek", "yrUnderCom", "yrCovenant", "invitedBy", "curPLeader", "Parish Organization", "Services and Ministries", "dtAccomplished", "whenJoined", "isActive"})
        Me.cboType.Location = New System.Drawing.Point(120, 14)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(257, 21)
        Me.cboType.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.BorderColors = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdSearch.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdSearch.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.print
        Me.cmdSearch.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdSearch.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdSearch.Location = New System.Drawing.Point(271, 154)
        Me.cmdSearch.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdSearch.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(103, 36)
        Me.cmdSearch.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.Text = "Generate"
        Me.cmdSearch.UseVisualStyleBackColor = True
        Me.cmdSearch.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'gbString
        '
        Me.gbString.Controls.Add(Me.Label2)
        Me.gbString.Controls.Add(Me.txtStringBox)
        Me.gbString.ForeColor = System.Drawing.Color.White
        Me.gbString.Location = New System.Drawing.Point(12, 41)
        Me.gbString.Name = "gbString"
        Me.gbString.Size = New System.Drawing.Size(371, 52)
        Me.gbString.TabIndex = 4
        Me.gbString.TabStop = False
        Me.gbString.Text = "Filter Box"
        Me.gbString.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search Name"
        '
        'txtStringBox
        '
        Me.txtStringBox.Location = New System.Drawing.Point(108, 19)
        Me.txtStringBox.Name = "txtStringBox"
        Me.txtStringBox.Size = New System.Drawing.Size(254, 20)
        Me.txtStringBox.TabIndex = 5
        '
        'cboOrder
        '
        Me.cboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrder.FormattingEnabled = True
        Me.cboOrder.Items.AddRange(New Object() {"Ascending", "Descending", "No Order"})
        Me.cboOrder.Location = New System.Drawing.Point(120, 158)
        Me.cboOrder.Name = "cboOrder"
        Me.cboOrder.Size = New System.Drawing.Size(115, 21)
        Me.cboOrder.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Order By"
        '
        'gbDate
        '
        Me.gbDate.Controls.Add(Me.Label5)
        Me.gbDate.Controls.Add(Me.txttyear)
        Me.gbDate.Controls.Add(Me.cbotmonth)
        Me.gbDate.Controls.Add(Me.txtfyear)
        Me.gbDate.Controls.Add(Me.cbofmonth)
        Me.gbDate.Controls.Add(Me.Label4)
        Me.gbDate.ForeColor = System.Drawing.Color.White
        Me.gbDate.Location = New System.Drawing.Point(12, 41)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(371, 58)
        Me.gbDate.TabIndex = 7
        Me.gbDate.TabStop = False
        Me.gbDate.Text = "Filter Box"
        Me.gbDate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(228, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "-"
        '
        'txttyear
        '
        Me.txttyear.Location = New System.Drawing.Point(315, 22)
        Me.txttyear.Mask = "0000"
        Me.txttyear.Name = "txttyear"
        Me.txttyear.Size = New System.Drawing.Size(44, 20)
        Me.txttyear.TabIndex = 9
        Me.txttyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbotmonth
        '
        Me.cbotmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotmonth.FormattingEnabled = True
        Me.cbotmonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cbotmonth.Location = New System.Drawing.Point(244, 21)
        Me.cbotmonth.Name = "cbotmonth"
        Me.cbotmonth.Size = New System.Drawing.Size(65, 21)
        Me.cbotmonth.TabIndex = 8
        '
        'txtfyear
        '
        Me.txtfyear.Location = New System.Drawing.Point(176, 22)
        Me.txtfyear.Mask = "0000"
        Me.txtfyear.Name = "txtfyear"
        Me.txtfyear.Size = New System.Drawing.Size(44, 20)
        Me.txtfyear.TabIndex = 7
        Me.txtfyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbofmonth
        '
        Me.cbofmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofmonth.FormattingEnabled = True
        Me.cbofmonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cbofmonth.Location = New System.Drawing.Point(105, 21)
        Me.cbofmonth.Name = "cbofmonth"
        Me.cbofmonth.Size = New System.Drawing.Size(65, 21)
        Me.cbofmonth.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Search Date"
        '
        'gbSelect
        '
        Me.gbSelect.Controls.Add(Me.cboSelect)
        Me.gbSelect.Controls.Add(Me.Label7)
        Me.gbSelect.ForeColor = System.Drawing.Color.White
        Me.gbSelect.Location = New System.Drawing.Point(8, 41)
        Me.gbSelect.Name = "gbSelect"
        Me.gbSelect.Size = New System.Drawing.Size(371, 58)
        Me.gbSelect.TabIndex = 8
        Me.gbSelect.TabStop = False
        Me.gbSelect.Text = "Filter Box"
        Me.gbSelect.Visible = False
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cboSelect.Location = New System.Drawing.Point(105, 21)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(254, 21)
        Me.cboSelect.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Search Type"
        '
        'gbNumber
        '
        Me.gbNumber.Controls.Add(Me.chkreupdate)
        Me.gbNumber.Controls.Add(Me.txttNum)
        Me.gbNumber.Controls.Add(Me.txtfNum)
        Me.gbNumber.Controls.Add(Me.Label8)
        Me.gbNumber.Controls.Add(Me.Label6)
        Me.gbNumber.ForeColor = System.Drawing.Color.White
        Me.gbNumber.Location = New System.Drawing.Point(12, 42)
        Me.gbNumber.Name = "gbNumber"
        Me.gbNumber.Size = New System.Drawing.Size(371, 76)
        Me.gbNumber.TabIndex = 9
        Me.gbNumber.TabStop = False
        Me.gbNumber.Text = "Filter Box"
        Me.gbNumber.Visible = False
        '
        'chkreupdate
        '
        Me.chkreupdate.AutoSize = True
        Me.chkreupdate.Location = New System.Drawing.Point(247, 49)
        Me.chkreupdate.Name = "chkreupdate"
        Me.chkreupdate.Size = New System.Drawing.Size(116, 17)
        Me.chkreupdate.TabIndex = 9
        Me.chkreupdate.Text = "Re-update the Age"
        Me.chkreupdate.UseVisualStyleBackColor = True
        '
        'txttNum
        '
        Me.txttNum.Location = New System.Drawing.Point(247, 20)
        Me.txttNum.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.txttNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txttNum.Name = "txttNum"
        Me.txttNum.Size = New System.Drawing.Size(115, 20)
        Me.txttNum.TabIndex = 8
        Me.txttNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtfNum
        '
        Me.txtfNum.Location = New System.Drawing.Point(109, 20)
        Me.txtfNum.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.txtfNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtfNum.Name = "txtfNum"
        Me.txtfNum.Size = New System.Drawing.Size(112, 20)
        Me.txtfNum.TabIndex = 7
        Me.txtfNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age Range"
        '
        'gbSuggest
        '
        Me.gbSuggest.Controls.Add(Me.txtSuggest)
        Me.gbSuggest.Controls.Add(Me.Label10)
        Me.gbSuggest.ForeColor = System.Drawing.Color.White
        Me.gbSuggest.Location = New System.Drawing.Point(8, 45)
        Me.gbSuggest.Name = "gbSuggest"
        Me.gbSuggest.Size = New System.Drawing.Size(371, 76)
        Me.gbSuggest.TabIndex = 10
        Me.gbSuggest.TabStop = False
        Me.gbSuggest.Text = "Filter Box"
        Me.gbSuggest.Visible = False
        '
        'txtSuggest
        '
        Me.txtSuggest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSuggest.Location = New System.Drawing.Point(109, 22)
        Me.txtSuggest.Name = "txtSuggest"
        Me.txtSuggest.Size = New System.Drawing.Size(253, 20)
        Me.txtSuggest.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Search Name"
        '
        'gbYears
        '
        Me.gbYears.Controls.Add(Me.optAll)
        Me.gbYears.Controls.Add(Me.optNo)
        Me.gbYears.Controls.Add(Me.optYes)
        Me.gbYears.Controls.Add(Me.cboYear)
        Me.gbYears.Controls.Add(Me.Label9)
        Me.gbYears.ForeColor = System.Drawing.Color.White
        Me.gbYears.Location = New System.Drawing.Point(11, 42)
        Me.gbYears.Name = "gbYears"
        Me.gbYears.Size = New System.Drawing.Size(371, 103)
        Me.gbYears.TabIndex = 11
        Me.gbYears.TabStop = False
        Me.gbYears.Text = "Filter Box"
        Me.gbYears.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Search Type"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(235, 19)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 7
        '
        'optYes
        '
        Me.optYes.AutoSize = True
        Me.optYes.Checked = True
        Me.optYes.Location = New System.Drawing.Point(107, 23)
        Me.optYes.Name = "optYes"
        Me.optYes.Size = New System.Drawing.Size(93, 17)
        Me.optYes.TabIndex = 8
        Me.optYes.TabStop = True
        Me.optYes.Text = "Year Attended"
        Me.optYes.UseVisualStyleBackColor = True
        '
        'optNo
        '
        Me.optNo.AutoSize = True
        Me.optNo.Location = New System.Drawing.Point(107, 46)
        Me.optNo.Name = "optNo"
        Me.optNo.Size = New System.Drawing.Size(51, 17)
        Me.optNo.TabIndex = 9
        Me.optNo.TabStop = True
        Me.optNo.Text = "None"
        Me.optNo.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(107, 69)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 10
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'frmProfilePicker
        '
        Me.AcceptButton = Me.cmdSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(395, 200)
        Me.Controls.Add(Me.gbYears)
        Me.Controls.Add(Me.gbSuggest)
        Me.Controls.Add(Me.gbNumber)
        Me.Controls.Add(Me.gbSelect)
        Me.Controls.Add(Me.gbDate)
        Me.Controls.Add(Me.cboOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbString)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProfilePicker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Profile Picker Report"
        Me.gbString.ResumeLayout(False)
        Me.gbString.PerformLayout()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        Me.gbSelect.ResumeLayout(False)
        Me.gbSelect.PerformLayout()
        Me.gbNumber.ResumeLayout(False)
        Me.gbNumber.PerformLayout()
        CType(Me.txttNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSuggest.ResumeLayout(False)
        Me.gbSuggest.PerformLayout()
        Me.gbYears.ResumeLayout(False)
        Me.gbYears.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSearch As PowerNET8.My8Button
    Friend WithEvents gbString As System.Windows.Forms.GroupBox
    Friend WithEvents txtStringBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttyear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbotmonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtfyear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbofmonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbSelect As System.Windows.Forms.GroupBox
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbNumber As System.Windows.Forms.GroupBox
    Friend WithEvents txttNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtfNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkreupdate As System.Windows.Forms.CheckBox
    Friend WithEvents gbSuggest As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuggest As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbYears As System.Windows.Forms.GroupBox
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optNo As System.Windows.Forms.RadioButton
    Friend WithEvents optYes As System.Windows.Forms.RadioButton
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
