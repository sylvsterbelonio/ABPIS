<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUp))
        Me.txtsurname = New PowerNET8.My8TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtfirstname = New PowerNET8.My8TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtmiddlename = New PowerNET8.My8TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtusername = New PowerNET8.My8TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtpassword = New PowerNET8.My8TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtrpassword = New PowerNET8.My8TextBox
        Me.cmdCreate = New PowerNET8.My8Button
        Me.cmdSave = New PowerNET8.My8Button
        Me.cboUserLevel = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtsurname
        '
        Me.txtsurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtsurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtsurname.BackColor = System.Drawing.SystemColors.Window
        Me.txtsurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsurname.Location = New System.Drawing.Point(140, 21)
        Me.txtsurname.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtsurname.MaxLength = 32767
        Me.txtsurname.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtsurname.My_AllowCustom_Colors = False
        Me.txtsurname.My_ClearButton = True
        Me.txtsurname.My_GotFocus_Backcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsurname.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtsurname.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtsurname.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtsurname.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtsurname.My_SearchButton_AutoClear = True
        Me.txtsurname.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtsurname.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtsurname.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsurname.ReadOnly_ = False
        Me.txtsurname.Size = New System.Drawing.Size(275, 26)
        Me.txtsurname.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtsurname.TabIndex = 0
        Me.txtsurname.Text_ = ""
        Me.txtsurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Firstname"
        '
        'txtfirstname
        '
        Me.txtfirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtfirstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtfirstname.BackColor = System.Drawing.SystemColors.Window
        Me.txtfirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfirstname.Location = New System.Drawing.Point(140, 63)
        Me.txtfirstname.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtfirstname.MaxLength = 32767
        Me.txtfirstname.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtfirstname.My_AllowCustom_Colors = False
        Me.txtfirstname.My_ClearButton = True
        Me.txtfirstname.My_GotFocus_Backcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfirstname.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtfirstname.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtfirstname.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtfirstname.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtfirstname.My_SearchButton_AutoClear = True
        Me.txtfirstname.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtfirstname.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtfirstname.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.ReadOnly_ = False
        Me.txtfirstname.Size = New System.Drawing.Size(275, 26)
        Me.txtfirstname.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtfirstname.TabIndex = 2
        Me.txtfirstname.Text_ = ""
        Me.txtfirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Middlename"
        '
        'txtmiddlename
        '
        Me.txtmiddlename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtmiddlename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtmiddlename.BackColor = System.Drawing.SystemColors.Window
        Me.txtmiddlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmiddlename.Location = New System.Drawing.Point(140, 104)
        Me.txtmiddlename.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtmiddlename.MaxLength = 32767
        Me.txtmiddlename.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtmiddlename.My_AllowCustom_Colors = False
        Me.txtmiddlename.My_ClearButton = True
        Me.txtmiddlename.My_GotFocus_Backcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmiddlename.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtmiddlename.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtmiddlename.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtmiddlename.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtmiddlename.My_SearchButton_AutoClear = True
        Me.txtmiddlename.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtmiddlename.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtmiddlename.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmiddlename.ReadOnly_ = False
        Me.txtmiddlename.Size = New System.Drawing.Size(275, 26)
        Me.txtmiddlename.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtmiddlename.TabIndex = 4
        Me.txtmiddlename.Text_ = ""
        Me.txtmiddlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtusername.BackColor = System.Drawing.SystemColors.Window
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtusername.Location = New System.Drawing.Point(140, 184)
        Me.txtusername.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtusername.My_AllowCustom_Colors = False
        Me.txtusername.My_ClearButton = True
        Me.txtusername.My_GotFocus_Backcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtusername.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtusername.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtusername.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtusername.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtusername.My_SearchButton_AutoClear = True
        Me.txtusername.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtusername.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtusername.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.ReadOnly_ = False
        Me.txtusername.Size = New System.Drawing.Size(275, 26)
        Me.txtusername.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtusername.TabIndex = 6
        Me.txtusername.Text_ = ""
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(19, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtpassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtpassword.Location = New System.Drawing.Point(140, 227)
        Me.txtpassword.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtpassword.My_AllowCustom_Colors = False
        Me.txtpassword.My_ClearButton = True
        Me.txtpassword.My_GotFocus_Backcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpassword.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtpassword.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtpassword.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtpassword.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtpassword.My_SearchButton_AutoClear = True
        Me.txtpassword.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtpassword.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtpassword.PasswordChar = "*"
        Me.txtpassword.ReadOnly_ = False
        Me.txtpassword.Size = New System.Drawing.Size(275, 26)
        Me.txtpassword.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtpassword.TabIndex = 8
        Me.txtpassword.Text_ = ""
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Retype Password"
        '
        'txtrpassword
        '
        Me.txtrpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtrpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtrpassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtrpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtrpassword.Location = New System.Drawing.Point(140, 270)
        Me.txtrpassword.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtrpassword.MaxLength = 32767
        Me.txtrpassword.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtrpassword.My_AllowCustom_Colors = False
        Me.txtrpassword.My_ClearButton = True
        Me.txtrpassword.My_GotFocus_Backcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtrpassword.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtrpassword.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtrpassword.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtrpassword.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtrpassword.My_SearchButton_AutoClear = True
        Me.txtrpassword.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtrpassword.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtrpassword.Name = "txtrpassword"
        Me.txtrpassword.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtrpassword.PasswordChar = "*"
        Me.txtrpassword.ReadOnly_ = False
        Me.txtrpassword.Size = New System.Drawing.Size(275, 26)
        Me.txtrpassword.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtrpassword.TabIndex = 10
        Me.txtrpassword.Text_ = ""
        Me.txtrpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmdCreate
        '
        Me.cmdCreate.BorderColors = System.Drawing.Color.White
        Me.cmdCreate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreate.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdCreate.Image = CType(resources.GetObject("cmdCreate.Image"), System.Drawing.Image)
        Me.cmdCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCreate.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdCreate.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdCreate.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.document_b
        Me.cmdCreate.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdCreate.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdCreate.Location = New System.Drawing.Point(171, 314)
        Me.cmdCreate.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdCreate.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdCreate.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdCreate.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(116, 45)
        Me.cmdCreate.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdCreate.TabIndex = 12
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = True
        Me.cmdCreate.Visible = False
        Me.cmdCreate.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdSave
        '
        Me.cmdSave.BorderColors = System.Drawing.Color.White
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdSave.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdSave.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.disk
        Me.cmdSave.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdSave.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdSave.Location = New System.Drawing.Point(293, 314)
        Me.cmdSave.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdSave.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSave.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSave.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(116, 45)
        Me.cmdSave.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cboUserLevel
        '
        Me.cboUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserLevel.FormattingEnabled = True
        Me.cboUserLevel.Items.AddRange(New Object() {"Administrator", "User", "Guest"})
        Me.cboUserLevel.Location = New System.Drawing.Point(140, 147)
        Me.cboUserLevel.Name = "cboUserLevel"
        Me.cboUserLevel.Size = New System.Drawing.Size(274, 21)
        Me.cboUserLevel.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Userlevel"
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(436, 382)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboUserLevel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsurname)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(452, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(452, 420)
        Me.Name = "frmSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsurname As PowerNET8.My8TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As PowerNET8.My8TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmiddlename As PowerNET8.My8TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusername As PowerNET8.My8TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As PowerNET8.My8TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtrpassword As PowerNET8.My8TextBox
    Friend WithEvents cmdCreate As PowerNET8.My8Button
    Friend WithEvents cmdSave As PowerNET8.My8Button
    Friend WithEvents cboUserLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
