Imports PowerNET8.myString.Share
Public Class frmActivitesFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private Sub initialize()
        connect(mysql)
        loadRecord()
        reloadType()
        reloadDivision()
        reloadSection()
    End Sub

    Private Sub loadRecord()
        With navMain
            .set_class(mysql)
            .Set_SELECT("AMID, trainings,tbl_lstcourses.Name,tbl_lstcourses_unit.Name,tbl_activities.type, dtActivites")
            .Set_FROM("tbl_lstcourses   right JOIN tbl_activities     ON (tbl_lstcourses.CID = tbl_activities.courses)   left JOIN abpis.tbl_lstcourses_unit    ON (tbl_lstcourses_unit.UID = tbl_activities.subCourse)")
            .Set_ORDER("tbl_lstcourses_unit.Name,tbl_activities.type")
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.Columns(0).Visible = False
    End Sub

    Private Sub reloadType()
        Dim mydata As DataTable = mysql.Query("SELECT DISTINCT `type` from tbl_lstcourses order by `type`")
        cboType.Items.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            cboType.Items.Add(mydata.Rows(i).Item(0))
        Next
        cboType.Items.Add("-All-")
    End Sub

    Private Sub reloadDivision()
        Dim mydata As DataTable = mysql.Query("select distinct `type` from tbl_lstcourses_unit order by `type`")
        cboDivision.Items.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            cboDivision.Items.Add(mydata.Rows(i).Item(0))
        Next
        cboDivision.Items.Add("-All-")
    End Sub

    Private Sub reloadSection()
        Dim wh As String = ""
        Dim mydata As DataTable = mysql.Query("select distinct `Name` from tbl_lstcourses_unit order by `Name`")
        cboSection.Items.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            cboSection.Items.Add(mydata.Rows(i).Item(0))
        Next
        cboSection.Items.Add("-All-")
    End Sub

    Private Sub reloadSubType()
        Dim wh As String = ""
        If cboType.Text <> "-All-" Then
            wh = " where `type`='" + cboType.Text + "'"
        End If
        Dim mydata As DataTable = mysql.Query("SELECT DISTINCT `Name` from tbl_lstcourses " + wh + "  order by `Name`")
        cboSubType.Items.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            cboSubType.Items.Add(mydata.Rows(i).Item(0))
        Next
        cboSubType.Items.Add("-All-")
    End Sub

    Private Sub frmActivitesFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()

        If userLevel <> "Administrator" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdSearch.Click, cmdReset.Click, cmdEdit.Click, cmdView.Click, cmdDelete.Click
        Select Case CType(sender, Button).Text
            Case "Search"
                Dim x As String = ""
                If txtTrainings.Text <> "" Then Concat.Append(x, " trainings LIKE '" + txtTrainings.Text + "%'", " and ")
                If cboType.Text <> "" Then Concat.Append(x, "tbl_activities.type LIKE '" + IIf(cboType.Text <> "-All-", cboType.Text, "") + "%'", " and ")
                navMain.Set_WHERE(x)
                navMain.Execute()
            Case "Reset"
                txtTrainings.Text = ""
                cboType.SelectedIndex = -1
                navMain.Execute()
            Case "Add"
                Try
                    Dim frm As New frmActivities
                    With frm
                        .action = "add"
                        .ShowDialog()
                    End With
                Catch ex As Exception
                End Try
            Case "Edit"
                Try
                    Dim frm As New frmActivities
                    With frm
                        .action = "edit"
                        .AMID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                End Try
            Case "View"
                Try
                    Dim frm As New frmActivities
                    With frm
                        .action = "view"
                        .AMID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "Delete"
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        mysql.Query("DELETE FROM tbl_activities where AMID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        mysql.Query("DELETE FROM tbl_activities_members_attended where AMID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        mysql.Query("DELETE FROM tblp_info_courses where AMID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        MsgBox("Record has been deleted.")
                        navMain.Execute()
                    Catch ex As Exception
                        MsgBox("No Recrod selected")
                    End Try
                End If
        End Select


    End Sub

    Private Sub dgvMain_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvMain.DataSourceChanged
        If userLevel = "Administrator" Then
            If dgvMain.RowCount > 0 Then
                cmdEdit.Enabled = True
                cmdView.Enabled = True
                cmdDelete.Enabled = True
                'cmdPrint.Enabled = True
            Else
                cmdEdit.Enabled = False
                cmdView.Enabled = False
                cmdDelete.Enabled = False
                'cmdPrint.Enabled = False
            End If
        Else
            cmdView.Enabled = True
        End If
    End Sub

    Private Sub dgvMain_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvMain.MouseDoubleClick
        If dgvMain.Rows.Count > 0 Then 
            cmdAdd_Click(cmdView, Nothing)
        End If
    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        reloadSubType()
        cboSubType.SelectedIndex = -1
        cboDivision.SelectedIndex = -1
        cboSection.SelectedIndex = -1
    End Sub

    Private Sub cboSubType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubType.SelectedIndexChanged
        reloadDivision()
        cboSection.SelectedIndex = -1
    End Sub
End Class
