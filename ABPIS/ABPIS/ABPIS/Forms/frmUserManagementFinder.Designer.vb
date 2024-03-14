<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagementFinder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagementFinder))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdSearch = New PowerNET8.My8Button
        Me.cmdAdd = New PowerNET8.My8Button
        Me.cmdView = New PowerNET8.My8Button
        Me.cmdEdit = New PowerNET8.My8Button
        Me.cmdDelete = New PowerNET8.My8Button
        Me.MyNavigationGrid1 = New PowerNET8.myNavigationGrid
        Me.cmdClear = New PowerNET8.My8Button
        Me.dgvMain = New System.Windows.Forms.DataGridView
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(76, 15)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(237, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(380, 15)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(237, 20)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(319, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'cmdSearch
        '
        Me.cmdSearch.BorderColors = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdSearch.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdSearch.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdSearch.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdSearch.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdSearch.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdSearch.Location = New System.Drawing.Point(5, 47)
        Me.cmdSearch.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdSearch.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 30)
        Me.cmdSearch.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        Me.cmdSearch.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdAdd
        '
        Me.cmdAdd.BorderColors = System.Drawing.Color.White
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdAdd.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdAdd.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdAdd.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdAdd.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdAdd.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdAdd.Location = New System.Drawing.Point(298, 47)
        Me.cmdAdd.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdAdd.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdAdd.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdAdd.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 30)
        Me.cmdAdd.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        Me.cmdAdd.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdView
        '
        Me.cmdView.BorderColors = System.Drawing.Color.White
        Me.cmdView.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdView.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdView.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdView.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdView.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdView.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdView.Location = New System.Drawing.Point(379, 47)
        Me.cmdView.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdView.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdView.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdView.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(75, 30)
        Me.cmdView.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdView.TabIndex = 6
        Me.cmdView.Text = "View"
        Me.cmdView.UseVisualStyleBackColor = True
        Me.cmdView.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdEdit
        '
        Me.cmdEdit.BorderColors = System.Drawing.Color.White
        Me.cmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdEdit.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdEdit.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdEdit.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdEdit.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdEdit.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdEdit.Location = New System.Drawing.Point(460, 47)
        Me.cmdEdit.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdEdit.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdEdit.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdEdit.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 30)
        Me.cmdEdit.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        Me.cmdEdit.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdDelete
        '
        Me.cmdDelete.BorderColors = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdDelete.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdDelete.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdDelete.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdDelete.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdDelete.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdDelete.Location = New System.Drawing.Point(541, 47)
        Me.cmdDelete.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdDelete.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdDelete.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdDelete.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 30)
        Me.cmdDelete.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'MyNavigationGrid1
        '
        Me.MyNavigationGrid1.Location = New System.Drawing.Point(2, 358)
        Me.MyNavigationGrid1.My_Skin_BackGround_BorderColor = System.Drawing.Color.White
        Me.MyNavigationGrid1.My_Skin_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.MyNavigationGrid1.My_Skin_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.MyNavigationGrid1.My_Skin_BackGround_Has_Border = False
        Me.MyNavigationGrid1.My_Skin_BackGround_TopColor1 = System.Drawing.Color.White
        Me.MyNavigationGrid1.My_Skin_BackGround_TopColor2 = System.Drawing.Color.White
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_Select_Has_Border = False
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_UnSelect_Has_Border = False
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyNavigationGrid1.My_Skin_Standard_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.MyNavigationGrid1.My_Skin_Standard_UnSelect_FontColor = System.Drawing.Color.Black
        Me.MyNavigationGrid1.My_TxtCbo_Backcolor_GotFocus = System.Drawing.Color.Black
        Me.MyNavigationGrid1.My_TxtCbo_Backcolor_LostFocus = System.Drawing.Color.White
        Me.MyNavigationGrid1.My_TxtCbo_Fontcolor_GotFocus = System.Drawing.Color.SteelBlue
        Me.MyNavigationGrid1.My_TxtCbo_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.MyNavigationGrid1.My_UI_ICON_HOVER_JQUERY = CType(resources.GetObject("MyNavigationGrid1.My_UI_ICON_HOVER_JQUERY"), System.Drawing.Image)
        Me.MyNavigationGrid1.My_UI_ICON_NORMAL_JQUERY = CType(resources.GetObject("MyNavigationGrid1.My_UI_ICON_NORMAL_JQUERY"), System.Drawing.Image)
        Me.MyNavigationGrid1.Name = "MyNavigationGrid1"
        Me.MyNavigationGrid1.Padding = New System.Windows.Forms.Padding(1)
        Me.MyNavigationGrid1.Size = New System.Drawing.Size(616, 32)
        Me.MyNavigationGrid1.TabIndex = 10
        '
        'cmdClear
        '
        Me.cmdClear.BorderColors = System.Drawing.Color.White
        Me.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdClear.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdClear.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdClear.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdClear.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdClear.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdClear.Location = New System.Drawing.Point(86, 47)
        Me.cmdClear.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdClear.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdClear.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdClear.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 30)
        Me.cmdClear.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdClear.TabIndex = 11
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        Me.cmdClear.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeColumns = False
        Me.dgvMain.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMain.GridColor = System.Drawing.Color.White
        Me.dgvMain.Location = New System.Drawing.Point(1, 93)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(617, 263)
        Me.dgvMain.TabIndex = 12
        '
        'frmUserManagementFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(620, 392)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.MyNavigationGrid1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(636, 430)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(636, 430)
        Me.Name = "frmUserManagementFinder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management Finder"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As PowerNET8.My8Button
    Friend WithEvents cmdAdd As PowerNET8.My8Button
    Friend WithEvents cmdView As PowerNET8.My8Button
    Friend WithEvents cmdEdit As PowerNET8.My8Button
    Friend WithEvents cmdDelete As PowerNET8.My8Button
    Friend WithEvents MyNavigationGrid1 As PowerNET8.myNavigationGrid
    Friend WithEvents cmdClear As PowerNET8.My8Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
End Class
