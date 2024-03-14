Public Class frmCourseTalk
    Private mysql As New PowerNET8.mySQL.Init.SQL

    Private Sub initialize()
        connect(mysql)
        loadCourses()

        If userLevel <> "Admin" Then
            cmdCAdd.Enabled = False
            cmdCDelete.Enabled = False
            cmdCEdit.Enabled = False
            cmdSAdd.Enabled = False
            cmdSDelete.Enabled = False
            cmdSEdit.Enabled = False
        End If
    End Sub

    Private Sub frmCourseTalk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()

        If userLevel <> "Administrator" Then
            cmdCAdd.Enabled = False
            cmdCDelete.Enabled = False
            cmdCEdit.Enabled = False
            cmdSAdd.Enabled = False
            cmdSDelete.Enabled = False
            cmdSEdit.Enabled = False
        Else
            cmdCAdd.Enabled = True
            cmdCEdit.Enabled = True
            cmdCDelete.Enabled = True
        End If
    End Sub

#Region "COURSES"

    Private CID As String

    Private Sub clearCourses()
        txtName.Text = ""
        txtType.Text = ""
        txtTag.Text = ""
    End Sub

    Private Sub loadCourses()
        Dim mydata As DataTable = mysql.Query("SELECT * from tbl_lstcourses order by NoOrder")
        dgvC.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvC
                .Rows.Add()
                .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                .Rows(i).Cells(1).Value = mydata.Rows(i).Item(3)
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item(1)
                .Rows(i).Cells(3).Value = mydata.Rows(i).Item(2)
                .Rows(i).Cells(4).Value = mydata.Rows(i).Item(4)
            End With
        Next
    End Sub

    Private Sub cmdCAdd_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdCAdd.ClickButtonArea, cmdCEdit.ClickButtonArea, cmdCDelete.ClickButtonArea
        Select Case CType(Sender, PowerNET8.CButton).Text
            Case "Add"
                CID = 0
                If txtName.Text <> "" Then
                    With mysql
                        .setTable("tbl_lstcourses")
                        .addValue(.nextID("CID"), "CID")
                        .addValue(.nextID("CID"), "NoOrder")
                        .addValue(txtType.Text, "Type")
                        .addValue(txtName.Text, "Name")
                        .addValue(txtTag.Text, "tag")
                        .Insert()
                    End With
                    clearCourses()
                    loadCourses()
                    txtType.Focus()
                Else
                    MsgBox("Please enter name", MsgBoxStyle.Information, "Unable to Add Record")
                End If
            Case "Edit"
                If dgvC.Rows.Count > 0 Then
                    CID = dgvC.CurrentRow.Cells(0).Value
                    txtType.Text = dgvC.CurrentRow.Cells(2).Value
                    txtName.Text = dgvC.CurrentRow.Cells(3).Value
                    txtTag.Text = dgvC.CurrentRow.Cells(4).Value
                    txtorderNo.Text = dgvC.CurrentRow.Cells(1).Value
                    txtorderNo.Visible = True
                    lblOrderNo.Visible = True
                    cmdCDelete.Enabled = False
                    cmdCEdit.Text = "Cancel"
                    cmdCEdit.Image = My.Resources.dialog_cancel
                    cmdCAdd.Text = "Update"
                    cmdCAdd.Image = My.Resources.save

                End If
            Case "Update"
                If txtName.Text <> "" Then
                    With mysql
                        .setTable("tbl_lstcourses")
                        .addValue(txtType.Text, "Type")
                        .addValue(txtName.Text, "Name")
                        .addValue(txtorderNo.Text, "NoOrder")
                        .addValue(txtTag.Text, "tag")
                        .Update("CID", CID)
                    End With
                    clearCourses()
                    loadCourses()
                    txtType.Focus()
                    cmdCDelete.Enabled = True
                    txtorderNo.Visible = False
                    lblOrderNo.Visible = False
                Else
                    MsgBox("lease enter name", MsgBoxStyle.Information, "Unable to Add Record")
                End If
                cmdCAdd_ClickButtonArea(cmdCEdit, Nothing)
            Case "Cancel"
                CID = 0
                txtorderNo.Visible = False
                lblOrderNo.Visible = False
                cmdCDelete.Enabled = True
                cmdCEdit.Text = "Edit"
                cmdCEdit.Image = My.Resources.write
                cmdCAdd.Text = "Add"
                cmdCAdd.Image = My.Resources.add1
                clearCourses()
                txtType.Focus()
            Case "Delete"
                If dgvC.Rows.Count > 0 Then
                    If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            mysql.Query("DELETE FROM tbl_lstcourses where CID=" + CID)
                            mysql.Query("DELETE FROM tbl_lstcourses_unit where CID=" + CID)
                            loadCourses()
                        Catch ex As Exception
                            MsgBox("Please select a record to delete.")
                        End Try
                        CID = 0
                    End If
                End If
        End Select
    End Sub

    Private Sub txtType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtType.GotFocus, txtCode.GotFocus, txtName.GotFocus, txtorderNo.GotFocus, txtsubName.GotFocus, txtSubOrderNo.GotFocus, txtUnitCategory.GotFocus, txtTag.GotFocus
        sender.backcolor = Color.Beige
    End Sub

    Private Sub txtType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtType.KeyDown, txtName.KeyDown, txtTag.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdCAdd_ClickButtonArea(cmdCAdd, Nothing)
        End If
    End Sub


    Private Sub dgvC_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvC.CellClick
        If dgvC.RowCount > 0 Then
            CID = dgvC.CurrentRow.Cells(0).Value
            loadUnits()

        End If

        If userLevel = "Administrator" Then
            If dgvC.RowCount > 0 Then
                cmdSAdd.Enabled = True
                cmdSEdit.Enabled = True
                cmdSDelete.Enabled = True
            Else
                cmdSAdd.Enabled = False
                cmdSEdit.Enabled = False
                cmdSDelete.Enabled = False
            End If
        End If

    End Sub


#End Region

#Region "UNIT"

    Private UID As String

    Private Sub clearUnits()
        txtsubName.Text = ""
        txtCode.Text = ""
        txtUnitCategory.Text = ""
    End Sub

    Private Sub loadUnits()
        Dim mydata As DataTable = mysql.Query("SELECT * from tbl_lstcourses_unit where CID=" + CID + " order by Type,NoOrder")
        dgvUnit.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvUnit
                .Rows.Add()
                .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                .Rows(i).Cells(1).Value = mydata.Rows(i).Item(5)
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item(2)
                .Rows(i).Cells(3).Value = mydata.Rows(i).Item(3)
                .Rows(i).Cells(4).Value = mydata.Rows(i).Item(4)
            End With
        Next
    End Sub


    Private Sub disableUpperCategory(ByVal value As Boolean)
        If value Then
            cmdCAdd.Enabled = False
            cmdCEdit.Enabled = False
            cmdCDelete.Enabled = False
            dgvC.Enabled = False
        Else
            cmdCAdd.Enabled = True
            cmdCEdit.Enabled = True
            cmdCDelete.Enabled = True
            dgvC.Enabled = True
        End If
    End Sub

    Private Sub cmdSAdd_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdSAdd.ClickButtonArea, cmdSEdit.ClickButtonArea, cmdSDelete.ClickButtonArea
        Select Case CType(Sender, PowerNET8.CButton).Text
            Case "Add"
                If txtsubName.Text <> "" And CID <> 0 Then
                    With mysql
                        .setTable("tbl_lstcourses_unit")
                        .addValue(.nextID("UID"), "UID")
                        .addValue(.nextID("UID"), "NoOrder")
                        .addValue(CID, "CID")
                        .addValue(txtCode.Text, "Code")
                        .addValue(txtUnitCategory.Text, "Type")
                        .addValue(txtsubName.Text, "Name")
                        .Insert()
                    End With
                    clearUnits()
                    loadUnits()
                    txtCode.Focus()
                Else
                    MsgBox("Please select foundation course and enter name", MsgBoxStyle.Information, "Unable to Add Record")
                End If
            Case "Edit"
                If dgvUnit.Rows.Count > 0 Then
                    disableUpperCategory(True)
                    cmdSDelete.Enabled = False
                    txtSubOrderNo.Visible = True
                    lblSubOrderNo.Visible = True
                    UID = dgvUnit.CurrentRow.Cells(0).Value
                    txtCode.Text = dgvUnit.CurrentRow.Cells(2).Value
                    txtUnitCategory.Text = dgvUnit.CurrentRow.Cells(3).Value
                    txtsubName.Text = dgvUnit.CurrentRow.Cells(4).Value
                    txtSubOrderNo.Text = dgvUnit.CurrentRow.Cells(1).Value
                    cmdSEdit.Text = "Cancel"
                    cmdSEdit.Image = My.Resources.dialog_cancel
                    cmdSAdd.Text = "Update"
                    cmdSAdd.Image = My.Resources.save
                End If
            Case "Update"
                If txtsubName.Text <> "" And CID <> 0 Then
                    With mysql
                        .setTable("tbl_lstcourses_unit")
                        .addValue(txtCode.Text, "Code")
                        .addValue(txtUnitCategory.Text, "Type")
                        .addValue(txtsubName.Text, "Name")
                        .addValue(txtSubOrderNo.Text, "NoOrder")
                        .Update("UID", UID)
                    End With
                    clearUnits()
                    loadUnits()
                    txtCode.Focus()
                    cmdSDelete.Enabled = True
                    disableUpperCategory(False)
                    txtSubOrderNo.Visible = False
                    lblSubOrderNo.Visible = False
                Else
                    MsgBox("Please select foundation course and enter name", MsgBoxStyle.Information, "Unable to Add Record")
                End If
                cmdSAdd_ClickButtonArea(cmdSEdit, Nothing)
            Case "Cancel"
                txtSubOrderNo.Visible = False
                lblSubOrderNo.Visible = False
                disableUpperCategory(False)
                cmdSDelete.Enabled = True
                cmdSEdit.Text = "Edit"
                cmdSEdit.Image = My.Resources.write
                cmdSAdd.Text = "Add"
                cmdSAdd.Image = My.Resources.add1
                clearUnits()
                txtCode.Focus()
            Case "Delete"
                If dgvUnit.Rows.Count > 0 Then
                    If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        mysql.Query("DELETE FROM tbl_lstcourses_unit where UID=" + dgvUnit.CurrentRow.Cells(0).Value.ToString)
                        loadUnits()
                    End If
                End If
        End Select

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown, txtUnitCategory.KeyDown, txtsubName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSAdd_ClickButtonArea(cmdSAdd, Nothing)
        End If
    End Sub

#End Region



    Private Sub txtorderNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtorderNo.LostFocus
        If Not IsNumeric(sender.text) Then
            sender.text = dgvC.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub txtSubOrderNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubOrderNo.LostFocus
        If Not IsNumeric(txtSubOrderNo.Text) Then
            txtSubOrderNo.Text = dgvUnit.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub dgvC_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvC.MouseDoubleClick
        If userLevel = "Administrator" Then
            If dgvC.RowCount > 0 Then
                cmdCAdd_ClickButtonArea(cmdCEdit, Nothing)
            End If
        End If
    End Sub

    Private Sub dgvUnit_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvUnit.MouseDoubleClick
        If userLevel = "Administrator" Then
            If dgvUnit.RowCount > 0 Then
                cmdSAdd_ClickButtonArea(cmdSEdit, Nothing)
            End If
        End If
    End Sub


    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtType.LostFocus, txtCode.LostFocus, txtName.LostFocus, txtorderNo.LostFocus, txtsubName.LostFocus, txtSubOrderNo.LostFocus, txtUnitCategory.LostFocus, txtTag.LostFocus
        sender.backcolor = Color.White
    End Sub

    Private Sub dgvC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvC.CellContentClick

    End Sub

    Private Sub dgvUnit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUnit.CellContentClick

    End Sub
End Class