﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventsFinder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventsFinder))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFacilitator = New System.Windows.Forms.TextBox
        Me.cmdNext = New PowerNET8.My8Button
        Me.cmdPrev = New PowerNET8.My8Button
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.chkAllowFilter = New System.Windows.Forms.CheckBox
        Me.navMain = New PowerNET8.myNavigationGrid
        Me.cmdDelete = New PowerNET8.My8Button
        Me.cmdView = New PowerNET8.My8Button
        Me.cmdEdit = New PowerNET8.My8Button
        Me.cmdAdd = New PowerNET8.My8Button
        Me.cmdReset = New PowerNET8.My8Button
        Me.dgvMain = New System.Windows.Forms.DataGridView
        Me.cmdSearch = New PowerNET8.My8Button
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(303, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocation.Location = New System.Drawing.Point(393, 39)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(183, 20)
        Me.txtLocation.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Facilitator"
        '
        'txtFacilitator
        '
        Me.txtFacilitator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacilitator.Location = New System.Drawing.Point(85, 38)
        Me.txtFacilitator.Name = "txtFacilitator"
        Me.txtFacilitator.Size = New System.Drawing.Size(183, 20)
        Me.txtFacilitator.TabIndex = 49
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
        Me.cmdNext.Location = New System.Drawing.Point(553, 12)
        Me.cmdNext.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdNext.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdNext.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdNext.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(23, 22)
        Me.cmdNext.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdNext.TabIndex = 48
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
        Me.cmdPrev.Location = New System.Drawing.Point(494, 12)
        Me.cmdPrev.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdPrev.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdPrev.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdPrev.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(23, 22)
        Me.cmdPrev.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdPrev.TabIndex = 47
        Me.cmdPrev.Text = "<"
        Me.cmdPrev.UseVisualStyleBackColor = True
        Me.cmdPrev.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(518, 13)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(33, 20)
        Me.txtYear.TabIndex = 46
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(303, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Date "
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(393, 13)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(95, 21)
        Me.cboMonth.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitle.Location = New System.Drawing.Point(85, 12)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(183, 20)
        Me.txtTitle.TabIndex = 42
        '
        'chkAllowFilter
        '
        Me.chkAllowFilter.AutoSize = True
        Me.chkAllowFilter.Location = New System.Drawing.Point(377, 17)
        Me.chkAllowFilter.Name = "chkAllowFilter"
        Me.chkAllowFilter.Size = New System.Drawing.Size(15, 14)
        Me.chkAllowFilter.TabIndex = 53
        Me.chkAllowFilter.UseVisualStyleBackColor = True
        '
        'navMain
        '
        Me.navMain.Location = New System.Drawing.Point(1, 398)
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
        Me.navMain.Size = New System.Drawing.Size(596, 32)
        Me.navMain.TabIndex = 61
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
        Me.cmdDelete.Location = New System.Drawing.Point(515, 66)
        Me.cmdDelete.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdDelete.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdDelete.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdDelete.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(83, 36)
        Me.cmdDelete.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdDelete.TabIndex = 60
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
        Me.cmdView.Location = New System.Drawing.Point(430, 66)
        Me.cmdView.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdView.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdView.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdView.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(83, 36)
        Me.cmdView.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdView.TabIndex = 59
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
        Me.cmdEdit.Location = New System.Drawing.Point(345, 66)
        Me.cmdEdit.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdEdit.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdEdit.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdEdit.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(83, 36)
        Me.cmdEdit.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdEdit.TabIndex = 58
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
        Me.cmdAdd.Location = New System.Drawing.Point(259, 66)
        Me.cmdAdd.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdAdd.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdAdd.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdAdd.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(83, 36)
        Me.cmdAdd.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdAdd.TabIndex = 57
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
        Me.cmdReset.Location = New System.Drawing.Point(89, 66)
        Me.cmdReset.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdReset.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdReset.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdReset.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(83, 36)
        Me.cmdReset.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdReset.TabIndex = 56
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeColumns = False
        Me.dgvMain.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMain.GridColor = System.Drawing.Color.White
        Me.dgvMain.Location = New System.Drawing.Point(2, 105)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(596, 292)
        Me.dgvMain.TabIndex = 55
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
        Me.cmdSearch.Location = New System.Drawing.Point(3, 66)
        Me.cmdSearch.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmdSearch.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(83, 36)
        Me.cmdSearch.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.SkyBlue
        Me.cmdSearch.TabIndex = 54
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        Me.cmdSearch.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'frmEventsFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(599, 430)
        Me.Controls.Add(Me.navMain)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.chkAllowFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFacilitator)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEventsFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Events Finder"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFacilitator As System.Windows.Forms.TextBox
    Friend WithEvents cmdNext As PowerNET8.My8Button
    Friend WithEvents cmdPrev As PowerNET8.My8Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents chkAllowFilter As System.Windows.Forms.CheckBox
    Friend WithEvents navMain As PowerNET8.myNavigationGrid
    Friend WithEvents cmdDelete As PowerNET8.My8Button
    Friend WithEvents cmdView As PowerNET8.My8Button
    Friend WithEvents cmdEdit As PowerNET8.My8Button
    Friend WithEvents cmdAdd As PowerNET8.My8Button
    Friend WithEvents cmdReset As PowerNET8.My8Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSearch As PowerNET8.My8Button
End Class