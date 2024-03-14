Public Class frmContribution
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Public CRID As String = "0"
    Private IID As String = "0"
    Private allowOpen As Boolean = False
    Private colObjects As New Collection
    Public action As String = ""



    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtOrNo)
            .Add(udDtpayment)
            .Add(txtNameMember)
            .Add(dgvList)
        End With
    End Sub

    Private Sub initialize()
        connect(mysql)
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        loadObjects()
        clsObjects.setTextSkin(colObjects)
    End Sub

    Private Sub variables()
        If action = "add" Then
            CRID = "0"
            allowOpen = True
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
        ElseIf action = "edit" Then
            reloadRecord()
            allowOpen = True
            clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
        ElseIf action = "view" Then
            reloadRecord()
            allowOpen = False
            clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.view)
            If userLevel <> "Administrator" Then
                tsEdit.Enabled = False
                tsAdd.Enabled = False
                tsPrint.Visible = True
            End If
            dgvList.AllowUserToAddRows = False
        End If
    End Sub

    Private Sub frmContribution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
        udDtpayment.Value = Now
    End Sub

    Private Sub reloadRecord()
        Dim mydata As DataTable = mysql.Query("SELECT CRID,tbl_contribution_record.IID, concat(surName,', ',firstName,' ',middleName) as 'name', orNo, dtPayment FROM  tblp_info  INNER JOIN tbl_contribution_record   ON (tblp_info.IID = tbl_contribution_record.IID) WHERE CRID=" + CRID)
        If mydata.Rows.Count > 0 Then
            txtOrNo.Text = mydata.Rows(0).Item("orNo")
            udDtpayment.Value = mydata.Rows(0).Item("dtPayment")
            txtNameMember.Text = mydata.Rows(0).Item("name")
            IID = mydata.Rows(0).Item("IID")
        End If

        mydata = mysql.Query("SELECT * from tbl_contribution_record_history where CRID=" + CRID.ToString)
        With dgvList
            .Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                .Rows.Add()
                .Rows(i).Cells(0).Value = mydata.Rows(i).Item(1).ToString
                .Rows(i).Cells(1).Value = mydata.Rows(i).Item(3).ToString
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item(2).ToString
                .Rows(i).Cells(3).Value = PowerNET8.myNumber.Share.Formatter.format_DecimalOnly(mydata.Rows(i).Item(4), 2)
            Next
        End With

    End Sub

    Private Sub txtNameMember_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtNameMember.MouseClick
        Dim frm As New frmProfileInfoFinder
        With frm
            .action = "use"
            If allowOpen Then
                .ShowDialog()
                If .returnValue <> "" Then
                    Dim mydata As DataTable = mysql.Query("SELECT concat(surName,', ',firstName,' ',middleName) as 'name' from tblp_info where IID=" + .returnValue)
                    If mydata.Rows.Count > 0 Then
                        IID = .returnValue
                        txtNameMember.Text = mydata.Rows(0).Item(0)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsSave.Click, tsEdit.Click, tsCancel.Click, tsPrint.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtOrNo.Focus()
                CRID = "0"
                IID = "0"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                allowOpen = True
                action = "add"
            Case "Save"
                If txtOrNo.Text <> "" And txtNameMember.Text <> "" Then
                    With mysql
                        .setTable("tbl_contribution_record")
                        .addValue(IID, "IID")
                        .addValue(txtOrNo.Text, "orNo")
                        .addValue(udDtpayment, "dtPayment")
                        If CRID = "0" Then
                            CRID = .nextID("CRID")
                            .addValue(CRID, "CRID")
                            .Insert()
                        Else
                            .Update("CRID", CRID)
                        End If
                    End With

                    mysql.Query("DELETE FROM tbl_contribution_record_history where CRID=" + CRID.ToString)
                    For i As Integer = 0 To dgvList.Rows.Count - 2
                        With mysql
                            .setTable("tbl_contribution_record_history")
                            .addValue(CRID.ToString, "CRID")
                            .addValue(dgvList.Rows(i).Cells(0).Value, "typeOfPayment")
                            .addValue(dgvList.Rows(i).Cells(1).Value, "otherSpecify")
                            .addValue(dgvList.Rows(i).Cells(2).Value, "journalEntry")
                            .addValue(CDbl(dgvList.Rows(i).Cells(3).Value), "amount")
                            .Insert()
                        End With
                    Next

                    MsgBox("You have successfully saved the record")
                    mytoolstrip.toolstripNavigation(clsObjects.ToolAction.save)
                    clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
                    allowOpen = False
                    tsPrint.Visible = True
                Else
                    MsgBox("Please input the required fields", MsgBoxStyle.Exclamation)
                End If
            Case "Edit"
                allowOpen = True
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                tsPrint.Visible = False
            Case "Cancel"
                tsPrint.Visible = True
                allowOpen = False
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.cancel)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
            Case "Print"
                Dim cr As New PowerNET8.myDocument.Init.CrystalReportViewer
                Dim table As DataTable = createTable()
                With table
                    .Rows.Clear()
                    For i As Integer = 0 To dgvList.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Item("typeOfpayment") = dgvList.Rows(i).Cells(0).Value
                        .Rows(i).Item("amount") = CDbl(dgvList.Rows(i).Cells(3).Value)
                    Next
                End With
                With cr
                    .title = "OFFICIAL RECEIPT"
                    .addTableField(table)
                    .addParameterField("lblOR", txtOrNo.Text)
                    .addParameterField("lblName", txtNameMember.Text)
                    .reportPath("Reports\rptReceipt.rpt")
                    .launchReport()
                End With
        End Select
    End Sub

    Private Function createTable() As DataTable
        Dim table As New PowerNET8.myDataTableCreator
        With table
            .new_table("tblDetails")
            .add_columnField("typeOfpayment")
            .add_columnField("amount", PowerNET8.myDataTableCreator.FieldType.Decimal_)
            Return .get_table
        End With
    End Function

    Private Sub dgvList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellContentClick

    End Sub

    Private Sub dgvList_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellValidated
        Select Case dgvList.CurrentCell.ColumnIndex
            Case 0
                If dgvList.CurrentRow.Cells(0).Value = "Others" Then
                    dgvList.CurrentRow.Cells(1).ReadOnly = False
                Else
                    dgvList.CurrentRow.Cells(1).Value = ""
                    dgvList.CurrentRow.Cells(1).ReadOnly = True


                    Dim mydata As DataTable = mysql.Query("SELECT * from tbl_contribution_record_history where typeOfPayment ='" + dgvList.CurrentRow.Cells(0).Value + "' limit 0,1")
                    If mydata.Rows.Count > 0 Then
                        dgvList.CurrentRow.Cells(2).Value = mydata.Rows(0).Item("journalEntry")
                    End If



                End If
            Case 1
                If dgvList.CurrentRow.Cells(0).Value = "Others" Then
                    Dim mydata As DataTable = mysql.Query("SELECT * from tbl_contribution_record_history where otherSpecify ='" + dgvList.CurrentRow.Cells(1).Value + "' limit 0,1")
                    If mydata.Rows.Count > 0 Then
                        dgvList.CurrentRow.Cells(2).Value = mydata.Rows(0).Item("journalEntry")
                    End If
                End If
            Case 3
                dgvList.CurrentRow.Cells(3).Value = PowerNET8.myNumber.Share.Formatter.format_DecimalOnly(dgvList.CurrentRow.Cells(3).Value, 2)
        End Select
    End Sub


    Private Sub dgvList_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvList.EditingControlShowing

        Select Case dgvList.CurrentCell.ColumnIndex
            Case 1
                Dim c As TextBox = e.Control
                Dim mydata As DataTable = mysql.Query("SELECT DISTINCT otherSpecify from tbl_contribution_record_history")
                With c
                    .CharacterCasing = CharacterCasing.Upper
                    .AutoCompleteCustomSource.Clear()
                    .AutoCompleteMode = AutoCompleteMode.Suggest
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0))
                    Next
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With
        End Select
    End Sub

    Private Sub dgvList_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvList.RowsAdded
        With dgvList
            .Rows(.RowCount - 1).Cells(0).Value = " "
            .Rows(.RowCount - 1).Cells(2).Value = " "
        End With
    End Sub
End Class