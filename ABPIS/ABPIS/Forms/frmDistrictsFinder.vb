Imports PowerNET8.myString.Share
Public Class frmDistrictsFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL

    Private Sub initialize()
        connect(mysql)
        loadRecord()
    End Sub

    Private Sub loadRecord()
        With navMain
            .set_class(mysql)
            .Set_SELECT("*")
            .Set_FROM("tbl_districtname")
            .Set_ORDER("districtName")
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.Columns(0).Visible = False
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdSearch.Click, cmdEdit.Click, cmdView.Click, cmdReset.Click, cmdDelete.Click
        Select Case CType(sender, Button).Text
            Case "Search"
                Dim x As String = ""
                If txtDistrictName.Text <> "" Then Concat.Append(x, " districtName LIKE '" + txtDistrictName.Text + "%'", " and ")
                If txtCoordinator.Text <> "" Then Concat.Append(x, " coordinator LIKE '" + txtCoordinator.Text + "%'", " and ")
                navMain.Set_WHERE(x)
                navMain.Execute()
            Case "Reset"
                txtCoordinator.Text = ""
                txtDistrictName.Text = ""
                txtCoordinator.Focus()
                navMain.Execute()
            Case "Browse"
            Case "Add"
                Dim frm As New frmDistricts
                With frm
                    .action = "add"
                    .ShowDialog()
                End With
            Case "Edit"
                Try
                    Dim frm As New frmDistricts
                    With frm
                        .action = "edit"
                        .DID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "View"
                Try
                    Dim frm As New frmDistricts
                    With frm
                        .action = "view"
                        .DID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "Delete"
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        mysql.Query("DELETE FROM tbl_districtname where DID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        mysql.Query("DELETE FROM tbl_districtname_pastoralleaders where DID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        MsgBox("Record has been deleted.")
                        navMain.Execute()
                    Catch ex As Exception
                        MsgBox("No Recrod selected")
                    End Try
                End If
        End Select
    End Sub


    Private Sub frmDistrictsFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        If userLevel <> "Administrator" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If
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
        If dgvMain.RowCount > 0 Then
            cmdAdd_Click(cmdView, Nothing)
        End If
    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub txtDistrictName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDistrictName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAdd_Click(cmdSearch, Nothing)
        End If
    End Sub


End Class