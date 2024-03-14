Public Class frmContribution
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Public CRID As String = "0"
    Private IID As String = "0"
    Private allowOpen As Boolean = False
    Private colObjects As New Collection
    Public action As String = ""

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged
        If cboStatus.SelectedIndex <> -1 Then
            If cboStatus.Text = "Others" Then
                cboStatus.Width = 140
                lblOther.Visible = True
                txtOther.Visible = True
                txtOther.Focus()
            Else
                cboStatus.Width = 325
                lblOther.Visible = False
                txtOther.Visible = False
            End If
        End If
    End Sub

    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtOrNo)
            .Add(udDtpayment)
            .Add(txtNameMember)
            .Add(txtOther)
            .Add(cboStatus)
            .Add(txtAmount)
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
            End If
        End If
    End Sub

    Private Sub frmContribution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
    End Sub

    Private Sub reloadRecord()
        Dim mydata As DataTable = mysql.Query("SELECT CRID,tbl_contribution_record.IID, concat(surName,', ',firstName,' ',middleName) as 'name', orNo, dtPayment, typePayment, specify, amount FROM  tblp_info  INNER JOIN tbl_contribution_record   ON (tblp_info.IID = tbl_contribution_record.IID) WHERE CRID=" + CRID)
        If mydata.Rows.Count > 0 Then
            txtOrNo.Text = mydata.Rows(0).Item("orNo")
            udDtpayment.Value = mydata.Rows(0).Item("dtPayment")
            txtNameMember.Text = mydata.Rows(0).Item("name")
            IID = mydata.Rows(0).Item("IID")
            If mydata.Rows(0).Item("typePayment") = "Others" Then
                cboStatus.Text = mydata.Rows(0).Item("typePayment")
                txtOther.Text_ = mydata.Rows(0).Item("specify")
            Else
                cboStatus.Text = mydata.Rows(0).Item("typePayment")
            End If
            txtAmount.Text = PowerNET8.myNumber.Share.Formatter.format_DecimalOnly(mydata.Rows(0).Item("amount"), 2)
        End If
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
                txtAmount.Text = "0.00"
                CRID = "0"
                IID = "0"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                allowOpen = True
                action = "add"
            Case "Save"
                If txtOrNo.Text <> "" And txtNameMember.Text <> "" And txtAmount.Text <> "" And cboStatus.SelectedIndex <> -1 Then
                    With mysql
                        .setTable("tbl_contribution_record")
                        .addValue(IID, "IID")
                        .addValue(txtOrNo.Text, "orNo")
                        .addValue(udDtpayment, "dtPayment")
                        .addValue(cboStatus, "typePayment")
                        .addValue(txtOther.Text_, "specify")
                        .addValue(CDbl(txtAmount.Text), "amount")
                        If CRID = "0" Then
                            CRID = .nextID("CRID")
                            .addValue(CRID, "CRID")
                            .Insert()
                        Else
                            .Update("CRID", CRID)
                        End If
                    End With
                    MsgBox("You have successfully saved the record")
                    mytoolstrip.toolstripNavigation(clsObjects.ToolAction.save)
                    clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
                    allowOpen = False
                Else
                    MsgBox("Please input the required fields", MsgBoxStyle.Exclamation)
                End If
            Case "Edit"
                allowOpen = True
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            Case "Cancel"
                allowOpen = False
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.cancel)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
            Case "Print"
                Me.Close()
        End Select
    End Sub

    Private Sub txtAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.LostFocus
        If Not IsNumeric(txtAmount.Text) Then
            txtAmount.Text = "0.00"
        End If
    End Sub

    Private Sub txtAmount_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmount.MouseClick
        txtAmount.SelectAll()
    End Sub

    Private Sub txtNameMember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameMember.TextChanged

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub
End Class