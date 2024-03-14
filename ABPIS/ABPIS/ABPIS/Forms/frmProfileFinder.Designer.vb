<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileInfoFinder
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileInfoFinder))
        Me.txtSearch = New PowerNET8.My8TextBox
        Me.dgvMain = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.navMain = New PowerNET8.myNavigationGrid
        Me.cmdDelete = New PowerNET8.My8Button
        Me.cmdView = New PowerNET8.My8Button
        Me.cmdEdit = New PowerNET8.My8Button
        Me.cmdAdd = New PowerNET8.My8Button
        Me.cmdReset = New PowerNET8.My8Button
        Me.cmdSearch = New PowerNET8.My8Button
        Me.chkActive = New System.Windows.Forms.CheckBox
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(218, 29)
        Me.txtSearch.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.MinimumSize = New System.Drawing.Size(50, 26)
        Me.txtSearch.My_AllowCustom_Colors = False
        Me.txtSearch.My_ClearButton = True
        Me.txtSearch.My_GotFocus_Backcolor = System.Drawing.Color.White
        Me.txtSearch.My_GotFocus_Forecolor = System.Drawing.Color.Black
        Me.txtSearch.My_LostFocus_Backcolor = System.Drawing.Color.White
        Me.txtSearch.My_LostFocus_Forecolor = System.Drawing.Color.Black
        Me.txtSearch.My_SearchButton = PowerNET8.My8TextBox.SearchButtonBehavior.Hide
        Me.txtSearch.My_SearchButton_AutoClear = True
        Me.txtSearch.My_SearchButton_BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtSearch.My_SearchButton_MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.txtSearch.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ReadOnly_ = False
        Me.txtSearch.Size = New System.Drawing.Size(384, 26)
        Me.txtSearch.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text_ = ""
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeColumns = False
        Me.dgvMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMain.GridColor = System.Drawing.Color.White
        Me.dgvMain.Location = New System.Drawing.Point(1, 133)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(713, 292)
        Me.dgvMain.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search Type"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Surname", "FirstName", "MiddleName"})
        Me.cboType.Location = New System.Drawing.Point(109, 31)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(103, 21)
        Me.cboType.TabIndex = 13
        '
        'navMain
        '
        Me.navMain.Location = New System.Drawing.Point(0, 427)
        Me.navMain.My_Skin_BackGround_BorderColor = System.Drawing.Color.White
        Me.navMain.My_Skin_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.navMain.My_Skin_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.navMain.My_Skin_BackGround_Has_Border = False
        Me.navMain.My_Skin_BackGround_TopColor1 = System.Drawing.Color.White
        Me.navMain.My_Skin_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.navMain.My_Skin_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_Select_Has_Border = False
        Me.navMain.My_Skin_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_UnSelect_Has_Border = False
        Me.navMain.My_Skin_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.navMain.My_Skin_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.navMain.My_Skin_Standard_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.navMain.My_Skin_Standard_UnSelect_FontColor = System.Drawing.Color.Black
        Me.navMain.My_TxtCbo_Backcolor_GotFocus = System.Drawing.Color.Azure
        Me.navMain.My_TxtCbo_Backcolor_LostFocus = System.Drawing.Color.White
        Me.navMain.My_TxtCbo_Fontcolor_GotFocus = System.Drawing.Color.SteelBlue
        Me.navMain.My_TxtCbo_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.navMain.My_UI_ICON_HOVER_JQUERY = CType(resources.GetObject("navMain.My_UI_ICON_HOVER_JQUERY"), System.Drawing.Image)
        Me.navMain.My_UI_ICON_NORMAL_JQUERY = CType(resources.GetObject("navMain.My_UI_ICON_NORMAL_JQUERY"), System.Drawing.Image)
        Me.navMain.Name = "navMain"
        Me.navMain.Padding = New System.Windows.Forms.Padding(1)
        Me.navMain.Size = New System.Drawing.Size(715, 32)
        Me.navMain.TabIndex = 15
        '
        'cmdDelete
        '
        Me.cmdDelete.BorderColors = System.Drawing.Color.White
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdDelete.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdDelete.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.closethick
        Me.cmdDelete.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdDelete.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdDelete.Location = New System.Drawing.Point(608, 94)
        Me.cmdDelete.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdDelete.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdDelete.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdDelete.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(103, 36)
        Me.cmdDelete.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdView
        '
        Me.cmdView.BorderColors = System.Drawing.Color.White
        Me.cmdView.Enabled = False
        Me.cmdView.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdView.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdView.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdView.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.folder_open
        Me.cmdView.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdView.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdView.Location = New System.Drawing.Point(502, 94)
        Me.cmdView.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdView.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdView.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdView.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(103, 36)
        Me.cmdView.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdView.TabIndex = 7
        Me.cmdView.Text = "View"
        Me.cmdView.UseVisualStyleBackColor = True
        Me.cmdView.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdEdit
        '
        Me.cmdEdit.BorderColors = System.Drawing.Color.White
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdEdit.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdEdit.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.pencil
        Me.cmdEdit.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdEdit.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdEdit.Location = New System.Drawing.Point(396, 94)
        Me.cmdEdit.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdEdit.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdEdit.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdEdit.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(103, 36)
        Me.cmdEdit.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdEdit.TabIndex = 6
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        Me.cmdEdit.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdAdd
        '
        Me.cmdAdd.BorderColors = System.Drawing.Color.White
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdAdd.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdAdd.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.plusthick
        Me.cmdAdd.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdAdd.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdAdd.Location = New System.Drawing.Point(290, 94)
        Me.cmdAdd.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdAdd.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdAdd.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdAdd.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(103, 36)
        Me.cmdAdd.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        Me.cmdAdd.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdReset
        '
        Me.cmdReset.BorderColors = System.Drawing.Color.White
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdReset.Image = CType(resources.GetObject("cmdReset.Image"), System.Drawing.Image)
        Me.cmdReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReset.ImageSize = New System.Drawing.Size(18, 18)
        Me.cmdReset.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdReset.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.home
        Me.cmdReset.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdReset.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdReset.Location = New System.Drawing.Point(108, 94)
        Me.cmdReset.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdReset.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdReset.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdReset.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(103, 36)
        Me.cmdReset.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
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
        Me.cmdSearch.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.search
        Me.cmdSearch.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdSearch.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdSearch.Location = New System.Drawing.Point(2, 94)
        Me.cmdSearch.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdSearch.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(103, 36)
        Me.cmdSearch.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        Me.cmdSearch.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.ForeColor = System.Drawing.Color.White
        Me.chkActive.Location = New System.Drawing.Point(626, 33)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(64, 20)
        Me.chkActive.TabIndex = 16
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'frmProfileInfoFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(715, 459)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.navMain)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfileInfoFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Record Finder"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As PowerNET8.My8TextBox
    Friend WithEvents cmdSearch As PowerNET8.My8Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents cmdReset As PowerNET8.My8Button
    Friend WithEvents cmdAdd As PowerNET8.My8Button
    Friend WithEvents cmdEdit As PowerNET8.My8Button
    Friend WithEvents cmdView As PowerNET8.My8Button
    Friend WithEvents cmdDelete As PowerNET8.My8Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents navMain As PowerNET8.myNavigationGrid
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox

End Class
