Imports PowerNET8.myString.Share
Public Class frmNewsLetterFinder
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
            .Set_FROM("tbl_newsletter")
            .Set_ORDER("dtPublished desc")
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.Columns(0).Visible = False
        dgvMain.Columns(3).Visible = False
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdSearch.Click, cmdEdit.Click, cmdView.Click, cmdReset.Click, cmdDelete.Click
        Select Case CType(sender, Button).Text
            Case "Search"
                Dim x As String = ""
                If txtHeading.Text <> "" Then Concat.Append(x, " headings LIKE '" + txtHeading.Text + "%'", " and ")
                If txtEncodedBy.Text <> "" Then Concat.Append(x, " encodedBy LIKE '" + txtEncodedBy.Text + "%'", " and ")
                Concat.Append(x, " dtPublished between '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-1' and '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-31'", " and ")
                If txtMessageFrom.Text <> "" Then Concat.Append(x, "msgFrom like '" + txtMessageFrom.Text + "%'", " and ")
                navMain.Set_WHERE(x)
                navMain.Execute()
            Case "Reset"
                txtEncodedBy.Text = ""
                txtHeading.Text = ""
                txtHeading.Focus()
                txtYear.Text = Now.Year
                cboMonth.SelectedIndex = Now.Month - 1
                txtMessageFrom.Text = ""
                navMain.Execute()
            Case "Browse"
            Case "Add"
                Dim frm As New frmNewsLetter
                With frm
                    .action = "add"
                    .ShowDialog()
                End With
            Case "Edit"
                Dim frm As New frmNewsLetter
                With frm
                    .action = "edit"
                    .NLID = dgvMain.CurrentRow.Cells(0).Value
                    .ShowDialog()
                End With
            Case "View"
                Dim frm As New frmNewsLetter
                With frm
                    .action = "view"
                    .NLID = dgvMain.CurrentRow.Cells(0).Value
                    .ShowDialog()
                End With
            Case "Delete"
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        mysql.Query("DELETE FROM tbl_newsletter where NLID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                        MsgBox("Record has been deleted.")
                        navMain.Execute()
                    Catch ex As Exception
                        MsgBox("No Recrod selected")
                    End Try
                End If
        End Select
    End Sub

    Private Sub frmNewsLetterFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Function createTable()
        Dim myx As New PowerNET8.myDataTableCreator
        With myx
            .new_table("tblDetaios")
            .add_columnField("headings")
            Return .get_table
        End With
    End Function

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If dgvMain.RowCount > 0 Then
            Try
                Dim mydata As DataTable = mysql.Query("SELECT * from tbl_newsletter where NLID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                If mydata.Rows.Count > 0 Then
                    Dim myCR As New PowerNET8.myDocument.Init.CrystalReportViewer
                    Dim myDetails As DataTable = createTable()
                    With myCR
                        .addTableField(myDetails)
                        .addParameterField("lblHeadings", mydata.Rows(0).Item(1))
                        .addParameterField("lblsubheadings", mydata.Rows(0).Item(2))
                        .addParameterField("lblContent", IIf(IsDBNull(mydata.Rows(0).Item(3)), "", mydata.Rows(0).Item(3)))

                        Dim dt As Date = mydata.Rows(0).Item(4)
                        .addParameterField("lblDtPublished", dt.ToString("MM/dd/yyyy"))
                        .addParameterField("lblEncodedBy", mydata.Rows(0).Item(5))
                        .addParameterField("msgFrom", mydata.Rows(0).Item(6))
                        .reportPath("Reports\rptNewsLetter.rpt")
                        .launchReport()
                    End With
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class