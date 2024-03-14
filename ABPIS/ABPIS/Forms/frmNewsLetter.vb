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
        autosuggest()
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
            cmdUpload.Text = "Preview"
            txtFromSource.Text = mydata.Rows(0).Item("dSourceFile")
            txtFileName.Text = mydata.Rows(0).Item("dFileName")
        End If



    End Sub

    Private Sub autosuggest()
        clsObjects.autoSuggest(txtHeadings, "headings", "tbl_newsletter")
        clsObjects.autoSuggest(txtSubHeadings, "subheadings", "tbl_newsletter")
        clsObjects.autoSuggest(txtEncodedBy, "encodedBy", "tbl_newsletter")
        clsObjects.autoSuggest(txtmsgFrom, "msgFrom", "tbl_newsletter")
        udDtPublished.Value = Now
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
                            txtFromSource.Text = "myDocFile" + NLID.ToString + ".docx"
                            .addValue(txtFromSource.Text, "dFileName")
                            .addValue("Documents~" + txtFromSource.Text, "dSourceFile")

                            PowerNET8.myFile.Share.Folders.createFolder("Documents")
                            System.IO.File.Copy(txtFileName.Text, "Documents\myDocFile" + NLID.ToString + ".docx")
                            .Insert()
                        Else
                            .Update("NLID", NLID)
                        End If
                    End With



                    MsgBox("You have successfully saved the record")
                    mytoolstrip.toolstripNavigation(clsObjects.ToolAction.save)
                    clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
                    cmdUpload.Text = "Preview"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click
        Select Case CType(sender, Button).Text
            Case "Upload"
                Dim sourceFile As String = ""
                Dim dialog As New OpenFileDialog()
                dialog.InitialDirectory = Environment.SpecialFolder.Desktop
                dialog.Title = "Select Application Configeration Files Path"
                dialog.Filter = "Word (*.docx) |*.docx;*.rtf|(*.txt) |*.txt|(*.*) |*.*"
                If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim col() As String = dialog.FileName.Split(".")
                    If col(col.Length - 1) <> "docx" And col(col.Length - 1) <> "doc" Then
                        MsgBox("Only word document to be uploaded. Please try another file.", MsgBoxStyle.Critical, "Unablt to upload")
                        Exit Sub
                    End If
                    sourceFile = dialog.FileName
                End If
                txtFileName.Text = (sourceFile)
                txtFileName.ReadOnly = True
            Case "Preview"
                If txtFromSource.Text <> "" Then
                    Try
                        Dim col() As String = txtFromSource.Text.Split("~")
                        Process.Start(Application.StartupPath + "\Documents\" + col(1))
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Unable to view document")
                    End Try

                End If
        End Select
    End Sub
End Class