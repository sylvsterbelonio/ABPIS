Public Class frmEvents
    Private tsPrint As New ToolStripButton
    Private mySql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Public EID As String = "0"
    Public action As String = ""
    Private dvList As New DataView

    Private Sub initialize()
        connect(mySql)
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        loadObjects()
        reloadListType()

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

            .Add(txtSearchList)

            .Add(optDistrict)
            .Add(optLeaders)
            .Add(optMembers)
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
            tsAttendance.Visible = False
        ElseIf action = "edit" Then
            reloadRecord()
            clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)

            cmdRemove.Visible = True
            cmdReset.Visible = True
            cmdSelect.Visible = True
            cmdSelectAll.Visible = True
            tsAttendance.Visible = False
        ElseIf action = "view" Then

            tsAttendance.Visible = True
            cmdRemove.Visible = False
            cmdReset.Visible = False
            cmdSelect.Visible = False
            cmdSelectAll.Visible = False

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
            txtFacilator.Text = mydata.Rows(0).Item("facilitator")
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

            Select Case mydata.Rows(0).Item("types")
                Case "By District"
                    optDistrict.Checked = True

                    mydata = mySql.Query("SELECT tbl_districtname.DID,tbl_districtname.districtName FROM  tbl_event_participants  INNER JOIN tbl_districtname   ON (tbl_event_participants.IID = tbl_districtname.DID) where tbl_event_participants.EID=" + EID)
                    dgvParticipants.Rows.Clear()
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With dgvParticipants
                            .Rows.Add()
                            .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                            .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                        End With
                    Next

                    Dim where As String = ""
                    For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                        If i = 0 Then
                            where = " where tbl_districtname.DID !=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                        Else
                            where += " and tbl_districtname.DID !=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                        End If
                    Next
                    mydata = mySql.Query("SELECT DID, districtName as 'NAME' from tbl_districtname " + where + " order by districtName")
                    dgvList.DataSource = mydata
                    dgvList.Columns(0).Visible = False

                Case "By Pastoral Leaders"
                    optLeaders.Checked = True

                    mydata = mySql.Query("SELECT tbl_group.GID,tbl_group.groupName FROM  tbl_event_participants  INNER JOIN tbl_group    ON (tbl_event_participants.IID = tbl_group.GID) where tbl_event_participants.EID=" + EID)
                    dgvParticipants.Rows.Clear()
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With dgvParticipants
                            .Rows.Add()
                            .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                            .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                        End With
                    Next

                    Dim where As String = ""
                    For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                        If i = 0 Then
                            where = " where tbl_group.GID !=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                        Else
                            where += " and tbl_group.GID !=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                        End If
                    Next
                    mydata = mySql.Query("SELECT GID, groupName as 'NAME' from tbl_group " + where + " order by groupName")
                    dgvList.DataSource = mydata
                    dgvList.Columns(0).Visible = False

                Case "By Member"
                    optMembers.Checked = True

                    mydata = mySql.Query("SELECT tblp_info.IID, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_event_participants  INNER JOIN tblp_info   ON (tbl_event_participants.IID = tblp_info.IID) where tbl_event_participants.EID=" + EID)
                    dgvParticipants.Rows.Clear()
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With dgvParticipants
                            .Rows.Add()
                            .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                            .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                        End With
                    Next

                    Dim where As String = ""
                    For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                        If i = 0 Then
                            where = " where tblp_info.IID !=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                        Else
                            where += " and tblp_info.IID !=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                        End If
                    Next
                    mydata = mySql.Query("SELECT tblp_info.IID, concat(surName,', ',firstName,' ',middleName) as 'NAME' from tblp_info " + where + " order by surName")
                    dgvList.DataSource = mydata
                    dgvList.Columns(0).Visible = False
            End Select

        End If



    End Sub

    Private Sub frmEvents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
        autosuggest()
    End Sub

    Private Sub autosuggest()
        clsObjects.autoSuggest(txtTitle, "title", "tbl_event")
        clsObjects.autoSuggest(txtFacilator, "facilitator", "tbl_event")
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
                tsAttendance.Visible = False
            Case "Save"
                If txtTitle.Text <> "" Then
                    With mySql
                        .setTable("tbl_event")
                        .addValue(txtTitle.Text, "title")
                        .addValue(txtDescription.Text, "description")
                        .addValue(txtFacilator.Text, "facilitator")
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

                        If optDistrict.Checked Then
                            .addValue("By District", "types")
                        ElseIf optLeaders.Checked Then
                            .addValue("By Pastoral Leaders", "types")
                        Else
                            .addValue("By Member", "types")
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
                    For i As Integer = 0 To dgvParticipants.RowCount - 1
                        With mySql
                            .setTable("tbl_event_participants")
                            .addValue(EID, "EID")
                            .addValue(dgvParticipants.Rows(i).Cells(0).Value, "IID")
                            .Insert()
                        End With
                    Next

                    MsgBox("You have successfully saved the record")
                    mytoolstrip.toolstripNavigation(clsObjects.ToolAction.save)
                    clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
                    tsAttendance.Visible = True
                Else
                    MsgBox("Please input headings", MsgBoxStyle.Exclamation)
                End If
            Case "Edit"
                tsAttendance.Visible = False
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)

                cmdRemove.Visible = True
                cmdReset.Visible = True
                cmdSelect.Visible = True
                cmdSelectAll.Visible = True
                tsAttendance.Visible = False
            Case "Cancel"
                If action = "add" Then Me.Close()
                tsAttendance.Visible = True
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.cancel)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)

                cmdRemove.Visible = False
                cmdReset.Visible = False
                cmdSelect.Visible = False
                cmdSelectAll.Visible = False
                tsAttendance.Visible = True
            Case "Print"
                Me.Close()
        End Select
    End Sub

    Private Sub txtTime_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTime.LostFocus
        txtTime.Text = txtTime.Text.Replace(" ", "0")
    End Sub

    Private Sub txtTime_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTime.MouseClick
        txtTime.SelectAll()
    End Sub

    Private Sub reloadListType(Optional ByVal where As String = "")
        Dim mydata As New DataTable
        If where = "" Then dgvParticipants.Rows.Clear()

        If optDistrict.Checked Then
            mydata = mySql.Query("select DID as 'ID',districtName as 'NAME' from tbl_districtname " + where + " order by districtName")
        ElseIf optLeaders.Checked Then
            mydata = mySql.Query("select GID as 'ID',groupName as 'NAME' from tbl_group " + where + "  order by groupName")
        Else
            mydata = mySql.Query("select IID as 'ID',concat(surname,', ',firstname,' ',middlename) as 'NAME' from tblp_info " + where + " order by surname")
        End If

        dvList = New DataView(mydata)
        dvList.Table.TableName = "mydata"
        dgvList.DataSource = dvList
        dgvList.Columns(0).Visible = False
        'With dgvLists
        '    .Rows.Clear()
        '    For i As Integer = 0 To dvList.Table.Rows.Count - 1
        '        .Rows.Add()
        '        .Rows(i).Cells(0).Value = dvList.Table.Rows(i).Item(0).ToString
        '        .Rows(i).Cells(1).Value = dvList.Table.Rows(i).Item(1).ToString
        '    Next
        'End With
    End Sub

    Private Sub optDistrict_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDistrict.Click, optLeaders.Click, optMembers.Click
        If optDistrict.Checked Then
            grpSelection.Text = "SELECTED - (BY DISTRICT)"
            grpListAll.Text = "LIST OF DISTRICTS"
        ElseIf optLeaders.Checked Then
            grpSelection.Text = "SELECTED - (BY PASTORAL LEADERS)"
            grpListAll.Text = "LIST OF PASTORAL LEADERS"
        Else
            grpSelection.Text = "SELECTED - (BY MEMBERS)"
            grpListAll.Text = "LIST OF MEMBERS"
        End If
        reloadListType()
    End Sub

    Private Sub dgvParticipants_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvParticipants.CellMouseDoubleClick
        If txtTime.ReadOnly = False Then
            cmdRemove_Click(cmdRemove, Nothing)
        End If
    End Sub

    Private Sub dgvParticipants_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvParticipants.RowStateChanged
        If txtTime.ReadOnly = False Then
            If dgvParticipants.RowCount > 0 Then
                cmdRemove.Enabled = True
            Else
                cmdRemove.Enabled = False
            End If
        End If
    End Sub

    Private Sub selectITEMS()
        Dim blnFoundMulti As Boolean = False
        For i As Integer = 0 To dgvList.SelectedRows.Count - 1
            If i > 0 Then
                blnFoundMulti = True
                Exit For
            End If
        Next
        If blnFoundMulti = False Then
            'SINGLE
            With dgvParticipants
                .Rows.Add()
                Try
                    .Rows(.Rows.Count - 1).Cells(0).Value = dgvList.CurrentRow.Cells(0).Value
                    .Rows(.Rows.Count - 1).Cells(1).Value = dgvList.CurrentRow.Cells(1).Value
                Catch ex As Exception
                    MsgBox("Please select items")
                    dgvParticipants.Rows.Clear()
                    Exit Sub
                End Try

            End With
            dgvList.Rows.Remove(dgvList.CurrentRow)
        Else
            'MULTI
            For Each row As DataGridViewRow In dgvList.SelectedRows
                With dgvParticipants
                    .Rows.Add()
                    .Rows(.Rows.Count - 1).Cells(0).Value = row.Cells(0).Value
                    .Rows(.Rows.Count - 1).Cells(1).Value = row.Cells(1).Value
                End With
                dgvList.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub deSelectITEMS()
        Dim where As String = ""

        Dim blnFoundMulti As Boolean = False
        For i As Integer = 0 To dgvParticipants.SelectedRows.Count - 1
            If i > 0 Then
                blnFoundMulti = True
                Exit For
            End If
        Next
        If blnFoundMulti = False Then
            'SINGLE
            'With dgvList
            '    .Rows.Add()
            '    Try
            '        .Rows(.Rows.Count - 1).Cells(0).Value = dgvParticipants.CurrentRow.Cells(0).Value
            '        .Rows(.Rows.Count - 1).Cells(1).Value = dgvParticipants.CurrentRow.Cells(1).Value
            '    Catch ex As Exception
            '        MsgBox("Please select items")
            '        dgvList.Rows.Clear()
            '        Exit Sub
            '    End Try

            'End With

            dgvParticipants.Rows.Remove(dgvParticipants.CurrentRow)
        Else
            'MULTI
            For Each row As DataGridViewRow In dgvParticipants.SelectedRows
                'With dgvList
                '    .Rows.Add()
                '    .Rows(.Rows.Count - 1).Cells(0).Value = row.Cells(0).Value
                '    .Rows(.Rows.Count - 1).Cells(1).Value = row.Cells(1).Value
                'End With
                dgvParticipants.Rows.Remove(row)
            Next
        End If

        Dim colum As String = ""
        If optDistrict.Checked Then
            colum = "DID"
        ElseIf optLeaders.Checked Then
            colum = "GID"
        Else
            colum = "IID"
        End If


        For i As Integer = 0 To dgvParticipants.Rows.Count - 1
            If i = 0 Then
                where = "WHERE " + colum + " != " + dgvParticipants.Rows(i).Cells(0).Value.ToString
            Else
                where += " AND " + colum + " != " + dgvParticipants.Rows(i).Cells(0).Value.ToString
            End If
        Next

        reloadListType(where)


    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        selectITEMS()
        txtSearchList.Text = ""
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        dgvParticipants.Rows.Clear()
        reloadListType()
    End Sub

    Private Sub dgvList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvList.CellMouseDoubleClick
        If txtTitle.ReadOnly = False Then
            cmdSelect_Click(cmdSelect, Nothing)
        End If
    End Sub

    Private Sub dgvList_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvList.RowStateChanged
        If txtTitle.ReadOnly = False Then
            If dgvList.RowCount > 0 Then
                cmdSelect.Enabled = True
                cmdSelectAll.Enabled = True
            Else
                cmdSelect.Enabled = False
                cmdSelectAll.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectAll.Click
        Do
            With dgvParticipants
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dgvList.Rows(0).Cells(0).Value
                .Rows(.Rows.Count - 1).Cells(1).Value = dgvList.Rows(0).Cells(1).Value
            End With
            dgvList.Rows.RemoveAt(0)
        Loop Until dgvList.Rows.Count = 0

    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        deSelectITEMS()
    End Sub

    Private Sub txtSearchList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchList.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvList.RowCount > 0 Then
                cmdSelect_Click(cmdSelect, Nothing)
            Else
                txtSearchList.Text = ""
            End If
        End If
    End Sub

    Private Sub txtSearchList_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchList.TextChanged
        dvList.RowFilter = " NAME like '" + txtSearchList.Text + "%'"
        Dim dv1 As DataView = dvList
        With dgvList
            dgvList.DataSource = dv1
        End With
    End Sub

    Private Function createTable() As DataTable
        Dim tb As New PowerNET8.myDataTableCreator
        With tb
            .new_table("tblDetails")
            .add_columnField("district")
            .add_columnField("leaders")
            .add_columnField("members")
            Return .get_table
        End With
    End Function

    Private Sub setCagegoryQuery_DistrictOnly(ByRef data As DataTable)
        data.Rows.Clear()
        Dim mydata As DataTable
        Dim where As String = ""
        Dim blnFound As Boolean = False

        If optDistrict.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tbl_districtname.DID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tbl_districtname.DID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT districtName, groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID)  " + where + " order by districtname,groupName,surName  ")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("district") = Trim(mydata.Rows(i).Item(0).ToString)
                        .Rows(i).Item("leaders") = Trim(mydata.Rows(i).Item(1).ToString)
                        .Rows(i).Item("members") = mydata.Rows(i).Item(2).ToString
                    End With
                Next
            End If
        ElseIf optLeaders.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tbl_group.GID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tbl_group.GID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT districtName, groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID)  " + where + " order by districtname,groupName,surName  ")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("district") = Trim(mydata.Rows(i).Item(0).ToString)
                        .Rows(i).Item("leaders") = Trim(mydata.Rows(i).Item(1).ToString)
                        .Rows(i).Item("members") = mydata.Rows(i).Item(2).ToString
                    End With
                Next
            End If
        ElseIf optMembers.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tblp_info.IID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tblp_info.IID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT districtName, groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID) " + where + " order by districtname ")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("district") = mydata.Rows(i).Item(0).ToString
                        .Rows(i).Item("leaders") = mydata.Rows(i).Item(1).ToString
                        .Rows(i).Item("members") = mydata.Rows(i).Item(2).ToString
                    End With
                Next
            End If
        End If

    End Sub

    Private Sub setCategoryQuery_LeadersOnly(ByRef data As DataTable)
        Dim mydata As DataTable
        Dim where As String = ""
        Dim blnFound As Boolean = False
        If optDistrict.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tbl_districtname.DID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tbl_districtname.DID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT districtName, groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID) " + where + " order by surName ")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("leaders") = mydata.Rows(i).Item(1).ToString + " (" + LCase(mydata.Rows(i).Item(0).ToString) + ")"
                        .Rows(i).Item("members") = mydata.Rows(i).Item(2).ToString
                    End With
                Next
            End If
        ElseIf optLeaders.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tbl_group.GID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tbl_group.GID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT groupName, concat(surname,', ', firstname,' ',middlename) as 'Name' FROM tbl_group_members INNER JOIN tbl_group   ON (tbl_group_members.GID = tbl_group.GID)  INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID) " + where)
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("leaders") = mydata.Rows(i).Item(0).ToString
                        .Rows(i).Item("members") = mydata.Rows(i).Item(1).ToString
                    End With
                Next
            End If
        ElseIf optMembers.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tblp_info.IID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tblp_info.IID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT groupName, concat(surname,', ', firstname,' ',middlename) as 'Name' FROM tbl_group_members INNER JOIN tbl_group   ON (tbl_group_members.GID = tbl_group.GID)  INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID) " + where)
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("leaders") = mydata.Rows(i).Item(0).ToString
                        .Rows(i).Item("members") = mydata.Rows(i).Item(1).ToString
                    End With
                Next
            End If
        End If
    End Sub

    Private Sub setCategoryQuery_MembersOnly(ByRef data As DataTable)
        Dim mydata As DataTable
        Dim where As String = ""
        Dim blnFound As Boolean = False

        If optDistrict.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tbl_districtname.DID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tbl_districtname.DID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT districtName, groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID) " + where + " order by surName ")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("members") = mydata.Rows(i).Item(2).ToString + " (" + LCase(mydata.Rows(i).Item("districtName")) + "/" + LCase(mydata.Rows(i).Item("groupName")) + ")"
                    End With
                Next
            End If
        ElseIf optLeaders.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where tbl_group_members.GID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or tbl_group_members.GID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next
            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members  INNER JOIN tbl_group   ON (tbl_group_members.GID = tbl_group.GID) INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID) " + where + " order by groupName, surName")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("members") = mydata.Rows(i).Item(1).ToString + " (" + LCase(mydata.Rows(i).Item("groupName")) + ")"
                    End With
                Next
            End If
        ElseIf optMembers.Checked Then
            For i As Integer = 0 To dgvParticipants.Rows.Count - 1
                If i = 0 Then
                    blnFound = True
                    where = " where IID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                Else
                    where += " or IID=" + dgvParticipants.Rows(i).Cells(0).Value.ToString + " "
                End If
            Next

            If Not blnFound Then
                Exit Sub
            Else
                mydata = mySql.Query("SELECT concat(surname,', ', firstname,' ',middlename) as 'Name' from tblp_info " + where + " order by surname")
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With data
                        .Rows.Add()
                        .Rows(i).Item("members") = mydata.Rows(i).Item(0).ToString
                    End With
                Next
            End If

        End If
    End Sub

    Private Sub ByDistrictToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDistrict.Click, tsLeaders.Click, tsMembers.Click
        Dim cr As New PowerNET8.myDocument.Init.CrystalReportViewer
        Dim table As DataTable = createTable()

        Select Case (sender).Name
            Case "tsDistrict"
                setCagegoryQuery_DistrictOnly(table)
                cr.reportPath("Reports\rptEvent_District.rpt")
            Case "tsLeaders"
                setCategoryQuery_LeadersOnly(table)
                cr.reportPath("Reports\rptEvent_Leaders.rpt")
            Case "tsMembers"
                setCategoryQuery_MembersOnly(table)
                cr.reportPath("Reports\rptEvent_Members.rpt")
        End Select

        With cr
            .title = txtTitle.Text
            .addTableField(table)
            .addParameterField("lblTitle", txtTitle.Text)
            Dim dt As Date = udtDate.Value
            .addParameterField("lblT", dt.ToString("MM/dd/yyyy") + " " + txtTime.Text + " " + cboFormat.Text)
            .launchReport()
        End With
    End Sub

    Private Sub tsAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAttendance.Click
        Dim frm As New frmEventsAttendance
        With frm
            .EID = EID
            .ShowDialog()
        End With
    End Sub

End Class