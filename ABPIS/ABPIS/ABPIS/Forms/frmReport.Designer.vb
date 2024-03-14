<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.cmdMReset = New PowerNET8.My8Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboMStatus = New System.Windows.Forms.ComboBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.txtAfrom = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtATo = New System.Windows.Forms.NumericUpDown
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdPMember = New PowerNET8.My8Button
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.cmdPReset = New PowerNET8.My8Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboPType = New System.Windows.Forms.ComboBox
        Me.cmdPPrint = New PowerNET8.My8Button
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cboDistrict = New System.Windows.Forms.ComboBox
        Me.cmdDPrint = New PowerNET8.My8Button
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkEInclude = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.udtTo = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.udtFrom = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.cmdEPrint = New PowerNET8.My8Button
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtAfrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtATo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.udtTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.cmdMReset)
        Me.UltraTabPageControl1.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdPMember)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(371, 233)
        '
        'cmdMReset
        '
        Me.cmdMReset.BorderColors = System.Drawing.Color.White
        Me.cmdMReset.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdMReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdMReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdMReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMReset.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdMReset.Image = CType(resources.GetObject("cmdMReset.Image"), System.Drawing.Image)
        Me.cmdMReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMReset.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdMReset.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdMReset.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.home
        Me.cmdMReset.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdMReset.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdMReset.Location = New System.Drawing.Point(187, 185)
        Me.cmdMReset.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdMReset.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdMReset.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdMReset.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdMReset.Name = "cmdMReset"
        Me.cmdMReset.Size = New System.Drawing.Size(83, 36)
        Me.cmdMReset.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdMReset.TabIndex = 57
        Me.cmdMReset.Text = "Reset"
        Me.cmdMReset.UseVisualStyleBackColor = True
        Me.cmdMReset.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.cboMStatus)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.txtAfrom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtATo)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 167)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'cboMStatus
        '
        Me.cboMStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMStatus.FormattingEnabled = True
        Me.cboMStatus.Items.AddRange(New Object() {"Active", "Inactive", "-All-"})
        Me.cboMStatus.Location = New System.Drawing.Point(137, 130)
        Me.cboMStatus.Name = "cboMStatus"
        Me.cboMStatus.Size = New System.Drawing.Size(192, 21)
        Me.cboMStatus.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(137, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Member Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Surname", "FirstName", "MiddleName"})
        Me.cboType.Location = New System.Drawing.Point(56, 22)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(75, 21)
        Me.cboType.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed", "-All-"})
        Me.cboStatus.Location = New System.Drawing.Point(137, 103)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(192, 21)
        Me.cboStatus.TabIndex = 10
        '
        'txtAfrom
        '
        Me.txtAfrom.Location = New System.Drawing.Point(166, 50)
        Me.txtAfrom.Name = "txtAfrom"
        Me.txtAfrom.Size = New System.Drawing.Size(40, 20)
        Me.txtAfrom.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Gender"
        '
        'txtATo
        '
        Me.txtATo.Location = New System.Drawing.Point(257, 50)
        Me.txtATo.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.txtATo.Name = "txtATo"
        Me.txtATo.Size = New System.Drawing.Size(40, 20)
        Me.txtATo.TabIndex = 5
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female", "-All-"})
        Me.cboGender.Location = New System.Drawing.Point(137, 76)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(192, 21)
        Me.cboGender.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "To"
        '
        'cmdPMember
        '
        Me.cmdPMember.BorderColors = System.Drawing.Color.White
        Me.cmdPMember.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdPMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdPMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPMember.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdPMember.Image = CType(resources.GetObject("cmdPMember.Image"), System.Drawing.Image)
        Me.cmdPMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPMember.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdPMember.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdPMember.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.scroll
        Me.cmdPMember.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdPMember.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdPMember.Location = New System.Drawing.Point(276, 185)
        Me.cmdPMember.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPMember.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPMember.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPMember.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPMember.Name = "cmdPMember"
        Me.cmdPMember.Size = New System.Drawing.Size(83, 36)
        Me.cmdPMember.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPMember.TabIndex = 37
        Me.cmdPMember.Text = "Print"
        Me.cmdPMember.UseVisualStyleBackColor = True
        Me.cmdPMember.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.cmdPReset)
        Me.UltraTabPageControl2.Controls.Add(Me.GroupBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.cmdPPrint)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(371, 233)
        '
        'cmdPReset
        '
        Me.cmdPReset.BorderColors = System.Drawing.Color.White
        Me.cmdPReset.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdPReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdPReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPReset.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdPReset.Image = CType(resources.GetObject("cmdPReset.Image"), System.Drawing.Image)
        Me.cmdPReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPReset.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdPReset.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdPReset.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.home
        Me.cmdPReset.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdPReset.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdPReset.Location = New System.Drawing.Point(187, 185)
        Me.cmdPReset.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPReset.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPReset.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPReset.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPReset.Name = "cmdPReset"
        Me.cmdPReset.Size = New System.Drawing.Size(83, 36)
        Me.cmdPReset.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPReset.TabIndex = 58
        Me.cmdPReset.Text = "Reset"
        Me.cmdPReset.UseVisualStyleBackColor = True
        Me.cmdPReset.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboPType)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 101)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Type of Criteria"
        '
        'cboPType
        '
        Me.cboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPType.FormattingEnabled = True
        Me.cboPType.Items.AddRange(New Object() {"gender", "age", "occupation", "homeAddress", "employer", "bloodType", "status", "isActive"})
        Me.cboPType.Location = New System.Drawing.Point(137, 33)
        Me.cboPType.Name = "cboPType"
        Me.cboPType.Size = New System.Drawing.Size(192, 21)
        Me.cboPType.TabIndex = 8
        '
        'cmdPPrint
        '
        Me.cmdPPrint.BorderColors = System.Drawing.Color.White
        Me.cmdPPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdPPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdPPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPPrint.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdPPrint.Image = CType(resources.GetObject("cmdPPrint.Image"), System.Drawing.Image)
        Me.cmdPPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPPrint.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdPPrint.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdPPrint.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.scroll
        Me.cmdPPrint.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdPPrint.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdPPrint.Location = New System.Drawing.Point(276, 185)
        Me.cmdPPrint.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPPrint.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPPrint.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPPrint.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPPrint.Name = "cmdPPrint"
        Me.cmdPPrint.Size = New System.Drawing.Size(83, 36)
        Me.cmdPPrint.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPPrint.TabIndex = 39
        Me.cmdPPrint.Text = "Print"
        Me.cmdPPrint.UseVisualStyleBackColor = True
        Me.cmdPPrint.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.GroupBox3)
        Me.UltraTabPageControl3.Controls.Add(Me.cmdDPrint)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(371, 233)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.cboDistrict)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 98)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "District"
        '
        'cboDistrict
        '
        Me.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Items.AddRange(New Object() {"Gender", "Age", "Profession", "Address", "Offices", "Blood Type", "Status", "Member Status"})
        Me.cboDistrict.Location = New System.Drawing.Point(137, 33)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(192, 21)
        Me.cboDistrict.TabIndex = 8
        '
        'cmdDPrint
        '
        Me.cmdDPrint.BorderColors = System.Drawing.Color.White
        Me.cmdDPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdDPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdDPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDPrint.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdDPrint.Image = CType(resources.GetObject("cmdDPrint.Image"), System.Drawing.Image)
        Me.cmdDPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDPrint.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdDPrint.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdDPrint.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.scroll
        Me.cmdDPrint.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdDPrint.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdDPrint.Location = New System.Drawing.Point(276, 185)
        Me.cmdDPrint.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdDPrint.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdDPrint.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdDPrint.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdDPrint.Name = "cmdDPrint"
        Me.cmdDPrint.Size = New System.Drawing.Size(83, 36)
        Me.cmdDPrint.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdDPrint.TabIndex = 41
        Me.cmdDPrint.Text = "Print"
        Me.cmdDPrint.UseVisualStyleBackColor = True
        Me.cmdDPrint.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.GroupBox4)
        Me.UltraTabPageControl4.Controls.Add(Me.cmdEPrint)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 1)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(371, 233)
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.chkEInclude)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.udtTo)
        Me.GroupBox4.Controls.Add(Me.udtFrom)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cboLocation)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(348, 138)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        '
        'chkEInclude
        '
        Me.chkEInclude.AutoSize = True
        Me.chkEInclude.Location = New System.Drawing.Point(137, 64)
        Me.chkEInclude.Name = "chkEInclude"
        Me.chkEInclude.Size = New System.Drawing.Size(15, 14)
        Me.chkEInclude.TabIndex = 49
        Me.chkEInclude.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(187, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "To"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(187, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "From"
        '
        'udtTo
        '
        Me.udtTo.DateTime = New Date(2015, 7, 18, 0, 0, 0, 0)
        Me.udtTo.Enabled = False
        Me.udtTo.Location = New System.Drawing.Point(236, 87)
        Me.udtTo.Name = "udtTo"
        Me.udtTo.Size = New System.Drawing.Size(93, 21)
        Me.udtTo.TabIndex = 46
        Me.udtTo.Value = New Date(2015, 7, 18, 0, 0, 0, 0)
        '
        'udtFrom
        '
        Me.udtFrom.DateTime = New Date(2015, 7, 18, 0, 0, 0, 0)
        Me.udtFrom.Enabled = False
        Me.udtFrom.Location = New System.Drawing.Point(236, 60)
        Me.udtFrom.Name = "udtFrom"
        Me.udtFrom.Size = New System.Drawing.Size(93, 21)
        Me.udtFrom.TabIndex = 45
        Me.udtFrom.Value = New Date(2015, 7, 18, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Date Attended"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Location"
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Gender", "Age", "Profession", "Address", "Offices", "Blood Type", "Status", "Member Status"})
        Me.cboLocation.Location = New System.Drawing.Point(137, 33)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(192, 21)
        Me.cboLocation.TabIndex = 8
        '
        'cmdEPrint
        '
        Me.cmdEPrint.BorderColors = System.Drawing.Color.White
        Me.cmdEPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdEPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdEPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdEPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEPrint.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdEPrint.Image = CType(resources.GetObject("cmdEPrint.Image"), System.Drawing.Image)
        Me.cmdEPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEPrint.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdEPrint.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdEPrint.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.scroll
        Me.cmdEPrint.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdEPrint.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdEPrint.Location = New System.Drawing.Point(276, 185)
        Me.cmdEPrint.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdEPrint.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdEPrint.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdEPrint.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdEPrint.Name = "cmdEPrint"
        Me.cmdEPrint.Size = New System.Drawing.Size(83, 36)
        Me.cmdEPrint.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdEPrint.TabIndex = 41
        Me.cmdEPrint.Text = "Print"
        Me.cmdEPrint.UseVisualStyleBackColor = True
        Me.cmdEPrint.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(488, 235)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.UltraTabControl1.TabIndex = 0
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.RightTop
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Members List"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Members Population"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "District List"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Event List"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        Me.UltraTabControl1.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(371, 233)
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 235)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Management"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtAfrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtATo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.udtTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtATo As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtAfrom As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPMember As PowerNET8.My8Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPPrint As PowerNET8.My8Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDPrint As PowerNET8.My8Button
    Friend WithEvents cmdEPrint As PowerNET8.My8Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboPType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents udtTo As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udtFrom As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkEInclude As System.Windows.Forms.CheckBox
    Friend WithEvents cmdMReset As PowerNET8.My8Button
    Friend WithEvents cmdPReset As PowerNET8.My8Button
End Class
