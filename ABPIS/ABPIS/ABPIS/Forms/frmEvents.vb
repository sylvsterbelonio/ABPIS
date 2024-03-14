Public Class frmEvents
    Private tsPrint As New ToolStripButton
    Private mySql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Public EID As String = "0"
    Public action As String = ""

    Private Sub initialize()
        connect(mySql)
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        loadObjects()
    End Sub

    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtTitle)
            .Add(txtDescription)
            .Add(txtFacilator)
            .Add(txtLocation)
            .Add(txtTime)
            .Add(cboFormat)
            .Add(udtDate)
            .Add(dgvParticipants)
        End With
        clsObjects.setTextSkin(colObjects)
    End Sub

    Private Sub variables()
        Dim col() As String = Now.ToString("hh:mm").Split(":")

        If Val(col(0)) > 12 Then
            txtTime.Text = zerofill(Val(0) - 12) + ":" + zerofill(Val(col(1)))
            cboFormat.Text = "PM"
        Else
            txtTime.Text = col(0) + ":" + col(1)
            cboFormat.Text = "AM"
        End If

        If action = "add" Then
            EID = "0"
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

    Private Function zerofill(ByVal value As Integer) As String
        If value <= 9 Then
            Return "0" + value.ToString
        Else
            Return value.ToString
        End If
    End Function

    Private Sub reloadRecord()
        Dim mydata As DataTable = mySql.Query("select * from tbl_event where EID=" + EID)
        If mydata.Rows.Count > 0 Then
            txtTitle.Text = mydata.Rows(0).Item("title")
            If Not IsDBNull(mydata.Rows(0).Item("description")) Then txtDescription.Text = mydata.Rows(0).Item("description")
            txtFacilator.Text = mydata.Rows(0).Item("facilator")
            txtLocation.Text = mydata.Rows(0).Item("location")
            Dim dt As Date = mydata.Rows(0).Item("Edate")
            udtDate.Value = dt
            Dim col() As String = dt.ToString("hh:mm:ss").Split(":")
            If Val(col(0)) > 12 Then
                cboFormat.Text = "PM"
                txtTime.Text = zerofill(Val(col) - 12) + ":" + zerofill(Val(col(1)))
            Else
                cboFormat.Text = "AM"
                txtTime.Text = col(0) + ":" + col(1)
            End If
        End If

        mydata = mySql.Query("SELECT tblp_info.IID, concat(surName, ', ' , firstName,' ', middleName) as 'name' FROM   tblp_info   INNER JOIN tbl_event_participants    ON (tblp_info.IID = tbl_event_participants.IID) where EID=" + EID)
        dgvParticipants.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvParticipants
                .Rows.Add()
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item("IID")
                .Rows(i).Cells(3).Value = mydata.Rows(i).Item("name")
            End With
        Next

    End Sub

    Private Sub frmEvents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
        autosuggest()
    End Sub

    Private Sub autosuggest()
        clsObjects.autoSuggest(txtTitle, "title", "tbl_event")
        clsObjects.autoSuggest(txtFacilator, "facilator", "tbl_event")
        clsObjects.autoSuggest(txtLocation, "location", "tbl_event")
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsEdit.Click, tsCancel.Click, tsSave.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtTime.Focus()
                EID = "0"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                action = "add"
            Case "Save"
                If txtTitle.Text <> "" Then
                    With mySql
                        .setTable("tbl_event")
                        .addValue(txtTitle.Text, "title")
                        .addValue(txtDescription.Text, "description")
                        .addValue(txtFacilator.Text, "facilator")
                        .addValue(txtLocation.Text, "location")
                        If cboFormat.Text = "AM" Then
                            Dim dt As Date = udtDate.Value
                            .addValue(dt.ToString("yyyy-MM-dd") + " " + txtTime.Text + ":00", "Edate")
                        Else
                            Dim dt As Date = udtDate.Value
                            Dim col() As String = txtTime.Text.Split(":")
                            Dim hr As Integer = Val(col(0) + 12)
                            .addValue(dt.ToString("yyyy-MM-dd") + " " + hr.ToString + ":" + col(1) + ":00", "Edate")
                        End If
                        If EID = "0" Then
                            EID = .nextID("EID")
                            .addValue(EID, "EID")
                            .Insert()
                        Else
                            .Update("EID", EID)
                        End If
                    End With

                    'PARTICIPANTS
                    mySql.Query("DELETE FROM tbl_event_participants where EID=" + EID)
                    For i As Integer = 0 To dgvParticipants.RowCount - 2
                        With mySql
                            .setTable("tbl_event_participants")
                            .addValue(EID, "EID")
                            .addValue(dgvParticipants.Rows(i).Cells(2).Value, "IID")
                            .Insert()
                        End With
                    Next

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

    Private Sub dgvParticipants_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvParticipants.CellClick
        Select Case dgvParticipants.CurrentCell.ColumnIndex
            Case 0
                Dim frm As New frmProfileInfoFinder
                With frm
                    .action = "use"
                    .ShowDialog()
                    If .returnValue <> "" Then

                        Dim blnFoundMulti As Boolean = False
                        For i As Integer = 0 To frm.dgvMain.SelectedRows.Count - 1
                            If i > 0 Then
                                blnFoundMulti = True
                                Exit For
                            End If
                        Next

                        If blnFoundMulti = False Then
                            'SINGLE
                            Dim blnfound As Boolean = False
                            For i As Integer = 0 To dgvParticipants.Rows.Count - 2
                                If dgvParticipants.Rows(i).Cells(2).Value = .returnValue Then
                                    blnfound = True
                                End If
                            Next
                            If Not blnfound Then
                                Dim mydata As DataTable = mySql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + .returnValue)
                                dgvParticipants.Rows.Add()
                                dgvParticipants.Rows(dgvParticipants.RowCount - 2).Cells(2).Value = .returnValue
                                dgvParticipants.Rows(dgvParticipants.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                            Else
                                MsgBox("Member is already been added")
                            End If
                        Else
                            'MULTI
                            For Each row As DataGridViewRow In frm.dgvMain.SelectedRows
                                Dim blnfound As Boolean = False
                                For i As Integer = 0 To dgvParticipants.Rows.Count - 2
                                    If dgvParticipants.Rows(i).Cells(2).Value = row.Cells(0).Value.ToString Then
                                        blnfound = True
                                    End If
                                Next
                                If Not blnfound Then
                                    Dim mydata As DataTable = mySql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + row.Cells(0).Value.ToString)
                                    dgvParticipants.Rows.Add()
                                    dgvParticipants.Rows(dgvParticipants.RowCount - 2).Cells(2).Value = row.Cells(0).Value.ToString
                                    dgvParticipants.Rows(dgvParticipants.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                                Else
                                    MsgBox("Member is already been added")
                                End If
                            Next
                        End If


                    
                    End If
                End With
            Case 1
                If Not dgvParticipants.CurrentRow.Cells(2).Value Is Nothing Then
                    If MsgBox("Do you want to remove this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            dgvParticipants.Rows.RemoveAt(dgvParticipants.CurrentCell.RowIndex)
                        Catch ex As Exception
                        End Try
                    End If
                End If
        End Select
    End Sub

    Private Sub txtTime_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTime.LostFocus
        txtTime.Text = txtTime.Text.Replace(" ", "0")

    End Sub


    Private Sub txtTime_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTime.MouseClick
        txtTime.SelectAll()
    End Sub

    Private Sub dgvParticipants_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvParticipants.CellContentClick

    End Sub
End Class