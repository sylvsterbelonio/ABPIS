Imports PowerNET8.myString.Share
Public Class frmGroupFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public action As String = ""
    Public returnValue As String = ""
    Private Sub initialize()
        connect(mysql)
        loadRecord()
        cboType.SelectedIndex = 0
    End Sub

    Private Sub loadRecord()
        With navMain
            .set_class(mysql)
            .Set_SELECT(" tbl_group.GID, groupname	, concat(surName,', ',firstname,' ' , middlename) as 'leader', dtformed")
            .Set_FROM("tblp_info right JOIN tbl_group    ON (tblp_info.IID = tbl_group.leader)")
            .Set_ORDER("groupname")
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.Columns(0).Visible = False
    End Sub

    Private Sub frmGroupFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()

        If action = "use" Then
            cmdAdd.Text = "Use"
        End If
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
                If txtGroupname.Text <> "" Then Concat.Append(x, " groupName LIKE '" + txtGroupname.Text + "%'", " and ")
                If txtLeader.Text <> "" Then Concat.Append(x, cboType.Text + "  LIKE '" + txtLeader.Text + "%'", " and ")
                navMain.Set_WHERE(x)
                navMain.Execute()
            Case "Reset"
                txtGroupname.Text = ""
                txtLeader.Text = ""
                txtGroupname.Focus()
                navMain.Execute()
            Case "Browse"
            Case "Add"
                Dim frm As New frmGroup
                With frm
                    .action = "add"
                    .ShowDialog()
                End With
            Case "Edit"
                Try
                    Dim frm As New frmGroup
                    With frm
                        .action = "edit"
                        .GID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "View"
                Try
                    Dim frm As New frmGroup
                    With frm
                        .action = "view"
                        .GID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "Delete"
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        mysql.Query("DELETE FROM tbl_group where GID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        MsgBox("Record has been deleted.")
                        navMain.Execute()
                    Catch ex As Exception
                        MsgBox("No Recrod selected")
                    End Try
                End If
            Case "Use"
                Try
                    returnValue = dgvMain.CurrentRow.Cells(0).Value.ToString
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
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
            If action = "use" Then
                cmdAdd_Click(cmdAdd, Nothing)
            Else
                cmdAdd_Click(cmdView, Nothing)
            End If
        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.SelectedIndex <> 0 Then
            txtGroupname.Text = ""
            txtGroupname.Focus()
        End If
    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub
End Class