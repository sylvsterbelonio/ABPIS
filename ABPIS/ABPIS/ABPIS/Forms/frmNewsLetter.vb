Public Class frmNewsLetter
    Private mySql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Public NLID As String = "0"
    Public action As String = ""
    Private Sub initialize()
        connect(mySql)
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        loadObjects()
    End Sub

    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtEncodedBy)
            .Add(txtHeadings)
            .Add(txtmsgFrom)
            .Add(txtSubHeadings)
            .Add(udDtPublished)
            .Add(rtbContent)
        End With
        clsObjects.setTextSkin(colObjects)
    End Sub

    Private Sub variables()
        If action = "add" Then
            NLID = "0"
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
        ElseIf action = "edit" Then
            reloadRecord()
            clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
        ElseIf action = "view" Then
            reloadRecord()
            clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.view)
            If userLevel <> "Administrator" Then
                tsEdit.Enabled = False
                tsAdd.Enabled = False
            End If
        End If
    End Sub

    Private Sub reloadRecord()
        Dim mydata As DataTable = mySql.Query("select * from tbl_newsletter where NLID=" + NLID)
        If mydata.Rows.Count > 0 Then
            txtHeadings.Text = mydata.Rows(0).Item("headings")
            txtSubHeadings.Text = mydata.Rows(0).Item("subheadings")
            rtbContent.Text = mydata.Rows(0).Item("content")
            udDtPublished.Value = mydata.Rows(0).Item("dtPublished")
            txtEncodedBy.Text = mydata.Rows(0).Item("encodedBy")
            txtmsgFrom.Text = mydata.Rows(0).Item("msgFrom")
        End If
    End Sub

    Private Sub frmNewsLetter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsEdit.Click, tsSave.Click, tsCancel.Click, tsPrint.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtHeadings.Focus()
                NLID = "0"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                action = "add"
            Case "Save"
                If txtHeadings.Text <> "" Then
                    With mySql
                        .setTable("tbl_newsletter")
                        .addValue(txtHeadings.Text, "headings")
                        .addValue(txtSubHeadings.Text, "subheadings")
                        .addValue(rtbContent.Text, "content")
                        .addValue(udDtPublished.Value, "dtPublished")
                        .addValue(txtEncodedBy.Text, "encodedBy")
                        .addValue(txtmsgFrom.Text, "msgFrom")
                        If NLID = "0" Then
                            NLID = .nextID("NLID")
                            .addValue(NLID, "NLID")
                            .Insert()
                        Else
                            .Update("NLID", NLID)
                        End If
                    End With
                    MsgBox("You have successfully saved the record")
                    mytoolstrip.toolstripNavigation(clsObjects.ToolAction.save)
                    clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
                Else
                    MsgBox("Please input headings", MsgBoxStyle.Exclamation)
                End If
            Case "Edit"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            Case "Cancel"
                If action = "add" Then Me.Close()
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.cancel)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
            Case "Print"
                Me.Close()
        End Select
    End Sub
End Class