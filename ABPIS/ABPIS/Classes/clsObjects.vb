Public Class clsObjects

    Enum Lock
        Yes
        No
    End Enum

    Public Shared Sub setTextSkin(ByRef colobjects As Collection)
        For Each obj As Object In colobjects
            If TypeOf obj Is TextBox Then
                With CType(obj, TextBox)
                    AddHandler .GotFocus, AddressOf txt_GotFocus
                    AddHandler .LostFocus, AddressOf txt_LostFocus
                End With
            End If
        Next
    End Sub

    Private Shared Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.readonly = False Then
            sender.backcolor = Color.Beige
        End If
    End Sub

    Private Shared Sub txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.readonly = False Then
            sender.backcolor = Color.White
        End If
    End Sub

    Public Shared Sub Lock_Mode_All(ByRef objects As Collection, Optional ByVal do_you_want_to_lock As Lock = Lock.Yes)
        Dim readOnly_ As Boolean
        Dim Enable As Boolean
        If do_you_want_to_lock = Lock.Yes Then
            readOnly_ = True
            Enable = False
        ElseIf do_you_want_to_lock = Lock.No Then
            readOnly_ = False
            Enable = True
        End If

        For Each O As Object In objects
            If TypeOf O Is TextBox Then
                CType(O, TextBox).ReadOnly = readOnly_
            ElseIf TypeOf O Is RichTextBox Then
                CType(O, RichTextBox).ReadOnly = readOnly_
            ElseIf TypeOf O Is PowerNET8.My8TextBox Then
                CType(O, PowerNET8.My8TextBox).ReadOnly_ = readOnly_
            ElseIf TypeOf O Is ListBox Then
                CType(O, ListBox).Enabled = Enable
            ElseIf TypeOf O Is CheckBox Then
                CType(O, CheckBox).Enabled = Enable
            ElseIf TypeOf O Is DataGridView Then
                With CType(O, DataGridView)
                    Try
                        .AllowUserToAddRows = Enable
                        .AllowUserToDeleteRows = Enable
                    Catch ex As Exception
                    End Try
                    If Enable Then
                        .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                        .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
                    Else
                        .EditMode = DataGridViewEditMode.EditProgrammatically
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    End If
                End With
            ElseIf TypeOf O Is MaskedTextBox Then
                With CType(O, MaskedTextBox)
                    .ReadOnly = readOnly_
                    If readOnly_ Then
                        '.BackColor = Validate.validateColor(disabled_BackColor)
                    Else
                        '.BackColor = Validate.validateColor(clrLostFocusTxtCbo_BackColor)
                    End If
                End With
            ElseIf TypeOf O Is ComboBox Then
                With CType(O, ComboBox)
                    .Enabled = Enable
                    If Enable = False Then
                        '.BackColor = Validate.validateColor(disabled_BackColor)
                    Else
                        '.BackColor = Validate.validateColor(clrLostFocusTxtCbo_BackColor)
                    End If
                End With
            ElseIf TypeOf O Is RadioButton Then
                CType(O, RadioButton).Enabled = Enable
            ElseIf TypeOf O Is DateTimePicker Then
                CType(O, DateTimePicker).Enabled = Enable
                If Enable = False Then
                    'CType(O, DateTimePicker).BackColor = Validate.validateColor(clrLostFocusTxtCbo_BackColor)
                Else
                    'CType(O, DateTimePicker).BackColor = Validate.validateColor(disabled_BackColor)
                End If
            ElseIf TypeOf O Is NumericUpDown Then
                With CType(O, NumericUpDown)
                    .ReadOnly = readOnly_
                    If readOnly_ Then
                        '.BackColor = ColorPicker(ui_textbox_readonly, PickStyle.backColor)
                        '.ForeColor = ColorPicker(ui_textbox_readonly, PickStyle.fontColor)
                    Else
                        '.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                        '.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                    End If
                End With
            ElseIf TypeOf O Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                CType(O, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).ReadOnly = readOnly_
                CType(O, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Enabled = Enable
                ' ElseIf TypeOf O Is MyCheckBoxExtension Then
                '    With CType(O, MyCheckBoxExtension)
                '  .Enabled = Enable
                '    End With
            End If
        Next
    End Sub

    Public Shared Sub Clear_All(ByRef objects As Collection)
        Dim myobjects As Object
        For Each myobjects In objects
            If TypeOf myobjects Is TextBox Then
                With CType(myobjects, TextBox)
                    .Text = ""
                    'If Not myAutoSuggest.get_Specified_Word(.Tag, CustomObjects.myAutoSuggest.WordTypes.suggest) Is Nothing Then
                    'If myAutoSuggest.get_Specified_Word(.Tag, CustomObjects.myAutoSuggest.WordTypes.suggest).ToString.Contains("-loaded") Then
                    'Dim suggest As String = myAutoSuggest.get_Specified_Word(.Tag, myAutoSuggest.WordTypes.suggest)
                    'Dim icon As String = myAutoSuggest.get_Specified_Word(.Tag, myAutoSuggest.WordTypes.ui)
                    'Dim tooltip As String = myAutoSuggest.get_Specified_Word(.Tag, myAutoSuggest.WordTypes.tooltip)
                    'Dim wrapper As String = ""
                    'suggest = suggest.ToString.Substring(0, suggest.Length - 7)
                    'wrapper = suggest
                    'If Not icon Is Nothing Then wrapper += ";" + icon
                    'If Not tooltip Is Nothing Then wrapper += ";" + tooltip
                    '.Tag = wrapper
                    '.Tag = .Tag.ToString.Substring(0, .Tag.length - 7)
                    'End If
                    'End If
                End With
            ElseIf TypeOf myobjects Is PowerNET8.My8TextBox Then
                CType(myobjects, PowerNET8.My8TextBox).Text_ = ""
            ElseIf TypeOf myobjects Is ComboBox Then
                CType(myobjects, ComboBox).SelectedIndex = -1
                CType(myobjects, ComboBox).Text = ""
            ElseIf TypeOf myobjects Is MaskedTextBox Then
                CType(myobjects, MaskedTextBox).Text = ""
            ElseIf TypeOf myobjects Is ListBox Then
                CType(myobjects, ListBox).Items.Clear()
            ElseIf TypeOf myobjects Is CheckBox Then
                CType(myobjects, CheckBox).Checked = False
            ElseIf TypeOf myobjects Is RadioButton Then
                CType(myobjects, RadioButton).Checked = False
            ElseIf TypeOf myobjects Is DateTimePicker Then
                CType(myobjects, DateTimePicker).Value = Now
            ElseIf TypeOf myobjects Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                CType(myobjects, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Value = Now
            ElseIf TypeOf myobjects Is DataGridView Then
                If Not CType(myobjects, DataGridView).Tag Is Nothing Then
                    If CType(myobjects, DataGridView).Tag.ToString.ToLower = "custom" Then
                        'nothing
                    Else
                        Try
                            CType(myobjects, DataGridView).Rows.Clear()
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    Try
                        CType(myobjects, DataGridView).Rows.Clear()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Next
    End Sub

    Public Shared Sub EditShowControl(ByRef c As TextBox, ByVal fieldName As String, ByVal table As String)
        Dim mysql As New PowerNET8.mySQL.Init.SQL
        connect(mysql)
        c.CharacterCasing = CharacterCasing.Upper
        Dim mydata As DataTable = mysql.Query("SELECT DISTINCT " + fieldName + " from " + table)
        For i As Integer = 0 To mydata.Rows.Count - 1
            c.AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0).ToString)
        Next
        c.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        c.AutoCompleteSource = AutoCompleteSource.CustomSource
        c.CharacterCasing = CharacterCasing.Upper
    End Sub

    Public Shared Sub autoSuggest(ByRef txt As TextBox, ByVal fieldname As String, ByVal tablename As String)
        Dim mysql As New PowerNET8.mySQL.Init.SQL
        connect(mysql)
        Dim mydata As DataTable = mysql.Query("SELECT DISTINCT " + fieldname + " from " + tablename)
        For i As Integer = 0 To mydata.Rows.Count - 1
            txt.AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0).ToString)
        Next
        txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt.CharacterCasing = CharacterCasing.Upper
    End Sub


    Enum ToolAction
        add
        edit
        view
        save
        cancel
    End Enum
    Private tsAdd As ToolStripButton
    Private tsEdit As ToolStripButton
    Private tsCancel As ToolStripButton
    Private tsPrint As ToolStripButton
    Private tsSave As ToolStripButton

    Public Sub assignToolStrip(ByRef add As ToolStripButton, ByRef edit As ToolStripButton, ByRef save As ToolStripButton, ByRef cancel As ToolStripButton, ByRef print As ToolStripButton)
        tsAdd = add
        tsEdit = edit
        tsCancel = cancel
        tsPrint = print
        tsSave = save
    End Sub

    Public Sub toolstripNavigation(ByVal action As ToolAction)
        Select Case action
            Case ToolAction.add
                tsAdd.Visible = False
                tsEdit.Visible = False
                tsCancel.Visible = True
                tsPrint.Visible = False
                tsSave.Visible = True
            Case ToolAction.cancel
                tsAdd.Visible = True
                tsEdit.Visible = True
                tsCancel.Visible = False
                tsPrint.Visible = True
                tsSave.Visible = False
            Case ToolAction.save
                tsAdd.Visible = True
                tsEdit.Visible = True
                tsCancel.Visible = False
                tsPrint.Visible = True
                tsSave.Visible = False
            Case ToolAction.edit
                tsSave.Visible = True
                tsAdd.Visible = False
                tsEdit.Visible = False
                tsCancel.Visible = True
                tsPrint.Visible = False
            Case ToolAction.view
                tsAdd.Visible = True
                tsEdit.Visible = True
                tsSave.Visible = False
                tsCancel.Visible = False
                tsPrint.Visible = True
        End Select
    End Sub


End Class
