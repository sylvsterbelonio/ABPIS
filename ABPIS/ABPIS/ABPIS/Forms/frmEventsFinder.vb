Imports PowerNET8.myString.Share
Public Class frmEventsFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private Sub initialize()
        connect(mysql)
        loadRecord()
        cboMonth.SelectedIndex = Now.Month - 1
        txtYear.Text = Now.Year
    End Sub

    Private Sub loadRecord()
        With navMain
            .set_class(mysql)
            .Set_SELECT("*")
            .Set_FROM("tbl_event")
            .Set_ORDER("Edate desc")
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.Columns(0).Visible = False
    End Sub

    Private Sub frmEventsFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        If userLevel <> "Administrator" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdReset.Click, cmdEdit.Click, cmdView.Click, cmdDelete.Click, cmdSearch.Click
        Select Case CType(sender, Button).Text
            Case "Search"
                Dim x As String = ""
                If txtTitle.Text <> "" Then Concat.Append(x, " title LIKE '" + txtTitle.Text + "%'", " and ")
                If txtFacilitator.Text <> "" Then Concat.Append(x, " facilator LIKE '" + txtFacilitator.Text + "%'", " and ")
                If chkAllowFilter.Checked Then Concat.Append(x, " Edate between '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-1 00:00:00' and '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-31 23:59:59'", " and ")
                If txtLocation.Text <> "" Then Concat.Append(x, "location like '" + txtLocation.Text + "%'", " and ")
                navMain.Set_WHERE(x)
                navMain.Execute()
            Case "Reset"
                chkAllowFilter.Checked = False
                txtFacilitator.Text = ""
                txtTitle.Text = ""
                txtTitle.Focus()
                txtYear.Text = Now.Year
                cboMonth.SelectedIndex = Now.Month - 1
                txtLocation.Text = ""
                navMain.Execute()
            Case "Browse"
            Case "Add"
                Dim frm As New frmEvents
                With frm
                    .action = "add"
                    .ShowDialog()
                End With
            Case "Edit"
                Try
                    Dim frm As New frmEvents
                    With frm
                        .action = "edit"
                        .EID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "View"
                Try
                    Dim frm As New frmEvents
                    With frm
                        .action = "view"
                        .EID = dgvMain.CurrentRow.Cells(0).Value
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox("Please select a record")
                End Try
            Case "Delete"
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        mysql.Query("DELETE FROM tbl_event where EID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
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
        If dgvMain.RowCount > 0 Then
            cmdAdd_Click(cmdView, Nothing)
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub
End Class