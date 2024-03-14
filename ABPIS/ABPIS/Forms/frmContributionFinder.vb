Imports PowerNET8.myString.Share

Public Class frmContributionFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private myDate As New PowerNET8.myDate

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Select Case CType(sender, Button).Text
            Case "Add"
                Dim frm As New frmContribution
                frm.action = "add"
                frm.ShowDialog()
        End Select
    End Sub

    Private Sub initialize()
        connect(mysql)
        loadRecord()
        cboMonth.SelectedIndex = Now.Month - 1
        txtYear.Text = Now.Year
        cboFilter.SelectedIndex = 0
    End Sub

    Private Sub loadRecord()
        With navMain
            .set_class(mysql)
            .Set_SELECT("tbl_contribution_record.CRID,orNo as 'OFFICIAL RECEIPT #',CONCAT(surName,', ',firstName,' ',middleName) as 'NAME',dtPayment as 'DATE OF PAYMENT'")
            .Set_FROM("tblp_info  INNER JOIN tbl_contribution_record   ON (tblp_info.IID = tbl_contribution_record.IID)")
            .Set_ORDER("dtPayment desc")
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMain.Columns(0).Visible = False
        dgvMain.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvMain.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub frmContributionFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        If userLevel <> "Administrator" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If
        cboMonth.Text = "-"
        cmdSearch_Click(cmdSearch, Nothing)
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        txtYear.Text = Val(txtYear.Text) - 1
        cmdSearch_Click(cmdSearch, Nothing)
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        txtYear.Text = Val(txtYear.Text) + 1
        cmdSearch_Click(cmdSearch, Nothing)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click, cmdReset.Click, cmdAdd.Click, cmdEdit.Click, cmdView.Click, cmdDelete.Click
        Select Case CType(sender, Button).Text
            Case "Search"
                Dim x As String = ""
                If txtORNo.Text <> "" Then Concat.Append(x, " orNo LIKE '" + txtORNo.Text + "%'", " and ")
                If cboType.SelectedIndex <> -1 Then Concat.Append(x, " typePayment LIKE '" + cboType.Text + "%'", " and ")

                If cboMonth.Text = "-" Then
                    Concat.Append(x, " dtPayment between '" + txtYear.Text + "-1-1' and '" + txtYear.Text + "-12-31'", " and ")
                Else
                    Concat.Append(x, " dtPayment between '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-1' and '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-31'", " and ")
                End If
               
                If txtNamePerson.Text <> "" Then Concat.Append(x, cboFilter.Text + " like '" + txtNamePerson.Text + "%'", " and ")
                navMain.Set_WHERE(x)
                navMain.Execute()
            Case "Reset"
                txtNamePerson.Text = ""
                txtORNo.Text = ""
                txtYear.Text = Now.Year
                cboMonth.SelectedIndex = Now.Month - 1
                cboType.SelectedIndex = -1
            Case "Edit"
                Dim frm As New frmContribution
                With frm
                    .action = "edit"
                    .CRID = dgvMain.CurrentRow.Cells(0).Value
                    .ShowDialog()
                End With
            Case "View"
                Dim frm As New frmContribution
                With frm
                    .action = "view"
                    .CRID = dgvMain.CurrentRow.Cells(0).Value
                    .ShowDialog()
                End With
            Case "Delete"
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    mysql.Query("DELETE FROM tbl_contribution_record where CRID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
                    MsgBox("Record has been deleted.")
                    navMain.Execute()
                End If
        End Select
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilter.SelectedIndexChanged
        If cboFilter.SelectedIndex <> -1 Then
            txtNamePerson.Text = ""
            txtNamePerson.Focus()
        End If
    End Sub

    Private Sub dgvMain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellClick
        If dgvMain.RowCount > 0 Then
            'cmdEdit.Enabled = True
            'cmdView.Enabled = True
            'cmdDelete.Enabled = True
        End If
    End Sub

    Private Sub dgvMain_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentDoubleClick
        If dgvMain.RowCount > 0 Then
            cmdSearch_Click(cmdView, Nothing)
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

    Private Function createTable()
        Dim mydatac As New PowerNET8.myDataTableCreator
        With mydatac
            .new_table("tblDetails")
            .add_columnField("orNO")
            .add_columnField("date")
            .add_columnField("member")
            .add_columnField("type")
            .add_columnField("amount", PowerNET8.myDataTableCreator.FieldType.Decimal_)
            Return .get_table
        End With
    End Function

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim myCR As New PowerNET8.myDocument.Init.CrystalReportViewer
        'Dim myDetails As DataTable = createTable()
        'Dim x As String = ""
        'If txtORNo.Text <> "" Then Concat.Append(x, " orNo LIKE '" + txtORNo.Text + "%'", " and ")
        'If cboType.SelectedIndex <> -1 Then Concat.Append(x, " typePayment LIKE '" + cboType.Text + "%'", " and ")
        'Concat.Append(x, " dtPayment between '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-1' and '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-31'", " and ")
        'If txtNamePerson.Text <> "" Then Concat.Append(x, cboFilter.Text + " like '" + txtNamePerson.Text + "%'", " and ")
        'Dim mydata As DataTable = mysql.Query("SELECT orNo, tbl_contribution_record.dtPayment,tbl_contribution_record.typePayment, concat(surName,', ',firstName,' ',middleName) as 'member',tbl_contribution_record.amount FROM  tblp_info  INNER JOIN  tbl_contribution_record   ON (tblp_info.IID = tbl_contribution_record.IID) where " + x)
        'For i As Integer = 0 To mydata.Rows.Count - 1
        '    myDetails.Rows.Add()
        '    myDetails.Rows(i).Item("orNO") = mydata.Rows(i).Item("orNo")
        '    myDetails.Rows(i).Item("date") = mydata.Rows(i).Item("dtPayment")
        '    myDetails.Rows(i).Item("type") = mydata.Rows(i).Item("typePayment")
        '    myDetails.Rows(i).Item("member") = mydata.Rows(i).Item("member")
        '    myDetails.Rows(i).Item("amount") = mydata.Rows(i).Item("amount")
        'Next
        'With myCR
        '    .addTableField(myDetails)
        '    .reportPath("Reports\rptContributionRecord.rpt")
        '    .addParameterField("lblMOnth", "For the Month of " + myDate.get_Month_String_Full(cboMonth.SelectedIndex) + ", " + txtYear.Text)
        '    .launchReport()
        'End With
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        cmdSearch_Click(cmdSearch, Nothing)
    End Sub
End Class