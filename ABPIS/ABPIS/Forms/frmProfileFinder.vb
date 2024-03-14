Imports System.Windows.Forms.Cursor

Public Class frmProfileInfoFinder
    Public action As String = ""
    Public returnValue As String = ""
    Private mysql As New PowerNET8.mySQL.Init.SQL

    Private Sub frmProfileInfoFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        cboType.SelectedIndex = 0

        If action = "use" Then
            cmdAdd.Text = "Use"
            dgvMain.MultiSelect = True
        End If

        If userLevel <> "Administrator" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If
    End Sub

    Private Sub initialize()
        connect(mysql)
        reload()
    End Sub

    Private Sub reload()
        With navMain
            .set_class(mysql)
            .Set_SELECT("IID, surName, firstName,middleName,nickname,homeAddress,dtAccomplished,whenJoined,isActive")
            .Set_FROM("tblp_info")
            .Set_Data(dgvMain)
            .Execute()
        End With
        'dgvMain.Columns(0).Visible = False
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdEdit.Click, cmdView.Click, cmdSearch.Click
        Dim frm As New frmProfile
        With frm
            Select Case CType(sender, Button).Text
                Case "Search"
                    Dim x As String = ""
                    If cboType.SelectedIndex <> -1 Then PowerNET8.myString.Share.Concat.Append(x, cboType.Text + " LIKE '" + txtSearch.Text_ + "%' ", " AND ")
                    PowerNET8.myString.Share.Concat.Append(x, " isActive = " + IIf(chkActive.Checked, 1, 0).ToString, " AND ")
                    navMain.Set_WHERE(x)
                    navMain.Execute()
                Case "Add"
                    .IID = "0"
                    .action = "add"
                    .ShowDialog()
                Case "Edit"
                    Try
                        .IID = dgvMain.CurrentRow.Cells(0).Value
                        .action = "edit"
                        .ShowDialog()
                    Catch ex As Exception
                        MsgBox("Please select a record.", MsgBoxStyle.Information, "Unable to edit")
                    End Try
                Case "View"
                    Me.Cursor = Cursors.WaitCursor
                    Try
                        .IID = dgvMain.CurrentRow.Cells(0).Value
                        .action = "view"
                        .ShowDialog()
                    Catch ex As Exception
                        MsgBox("Please select a record.", MsgBoxStyle.Information, "Unable to edit")
                    End Try
                    Me.Cursor = Cursors.Default
                Case "Use"
                    Try
                        returnValue = dgvMain.CurrentRow.Cells(0).Value.ToString
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Please select a record")
                    End Try

            End Select

        End With
    End Sub

    Private Sub dgvMain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellClick
        If dgvMain.Rows.Count > 0 Then
            If userLevel = "Administrator" Then
                cmdAdd.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdView.Enabled = True
            Else
                cmdAdd.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdView.Enabled = True
            End If
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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            mysql.Query("DELETE FROM tblp_info where IID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
            navMain.Execute()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAdd_Click(cmdSearch, Nothing)
        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        txtSearch.Focus()
    End Sub
End Class
