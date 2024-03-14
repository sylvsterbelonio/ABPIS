Public Class frmGroup
    Private tsPrint As New ToolStripButton
    Private mySql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Private allowOpen As Boolean = False
    Private IID As String = 0
    Public GID As String = "0"
    Public action As String = ""

    Private Sub initialize()
        connect(mySql)
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        loadObjects()
    End Sub

    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtGroupName)
            .Add(dgvLeader)
            .Add(dgvMembers)
        End With
        clsObjects.setTextSkin(colObjects)
    End Sub

    Private Sub variables()
        If action = "add" Then
            GID = "0"
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
            allowOpen = True
        ElseIf action = "edit" Then
            reloadRecord()
            clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
            allowOpen = True
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

    Private Sub reloadRecord()
        Dim mydata As DataTable = mySql.Query("SELECT tbl_group.GID, groupname	,tbl_group.leader, concat(surName,', ',firstname,' ' , middlename) as 'name', dtformed FROM tblp_info right JOIN tbl_group    ON (tblp_info.IID = tbl_group.leader) WHERE GID = " + GID)
        If mydata.Rows.Count > 0 Then
            txtGroupName.Text = mydata.Rows(0).Item("groupName")
            IID = mydata.Rows(0).Item("leader")
            dtFormed.Value = mydata.Rows(0).Item("dtFormed")
            Dim col() = mydata.Rows(0).Item("leader").ToString.Split(",")


            For i As Integer = 0 To col.Length - 1
                If col(i) <> "" Then
                    Dim rawdata As DataTable = mySql.Query("SELECT IID, concat(surName,', ',firstName,' ', middleName) as 'fullname' FROM tblp_info where IID=" + Trim(col(i).ToString))
                    If rawdata.Rows.Count > 0 Then
                        With dgvLeader
                            .Rows.Add()
                            .Rows(i).Cells(2).Value = rawdata.Rows(0).Item("IID")
                            .Rows(i).Cells(3).Value = rawdata.Rows(0).Item("fullname")
                        End With
                    End If
                End If
            Next

        End If

        mydata = mySql.Query("SELECT  tbl_group_members.IID,	 concat(surName,', ',firstname,' ' , middlename) as 'name' FROM  tblp_info  INNER JOIN tbl_group_members       ON (tblp_info.IID = tbl_group_members.IID) where tbl_group_members.GID=" + GID)
        dgvMembers.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvMembers
                .Rows.Add()
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item("IID")
                .Rows(i).Cells(3).Value = mydata.Rows(i).Item("name")
            End With
        Next

    End Sub

    Private Sub frmGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsEdit.Click, tsSave.Click, tsCancel.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtGroupName.Focus()
                GID = "0"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                action = "add"
                allowOpen = True
            Case "Save"
                If txtGroupName.Text <> "" Then
                    With mySql
                        .setTable("tbl_group")
                        .addValue(txtGroupName.Text, "groupName")

                        Dim idds As String = ""
                        For i As Integer = 0 To dgvLeader.RowCount - 2
                            If idds = "" Then
                                idds = dgvLeader.Rows(i).Cells(2).Value.ToString
                            Else
                                idds += "," + dgvLeader.Rows(i).Cells(2).Value.ToString
                            End If
                        Next

                        .addValue(idds, "leader")
                        .addValue(dtFormed.Value, "dtFormed")
                        If GID = "0" Then
                            GID = .nextID("GID")
                            .addValue(GID, "GID")
                            .Insert()
                        Else
                            .Update("GID", GID)
                        End If
                    End With

                    'PARTICIPANTS
                    mySql.Query("DELETE FROM tbl_group_members where GID=" + GID)
                    For i As Integer = 0 To dgvMembers.RowCount - 2
                        With mySql
                            .setTable("tbl_group_members")
                            .addValue(GID, "GID")
                            .addValue(dgvMembers.Rows(i).Cells(2).Value, "IID")
                            .Insert()
                        End With
                    Next
                    allowOpen = False
                    MsgBox("You have successfully saved the record")
                    mytoolstrip.toolstripNavigation(clsObjects.ToolAction.save)
                    clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
                Else
                    MsgBox("Please input headings", MsgBoxStyle.Exclamation)
                End If
            Case "Edit"
                allowOpen = True
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.edit)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
            Case "Cancel"
                If action = "add" Then Me.Close()
                allowOpen = False
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.cancel)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.Yes)
            Case "Print"
                Me.Close()
        End Select
    End Sub


    Private Sub dgvParticipants_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMembers.CellClick
        Select Case dgvMembers.CurrentCell.ColumnIndex
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
                            For i As Integer = 0 To dgvMembers.Rows.Count - 2
                                If dgvMembers.Rows(i).Cells(2).Value = .returnValue Then
                                    blnfound = True
                                End If
                            Next
                            If Not blnfound Then
                                Dim mydata As DataTable = mySql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + .returnValue)
                                dgvMembers.Rows.Add()
                                dgvMembers.Rows(dgvMembers.RowCount - 2).Cells(2).Value = .returnValue
                                dgvMembers.Rows(dgvMembers.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                            Else
                                MsgBox("Member is already been added")
                            End If
                        Else
                            'MULTI
                            For Each row As DataGridViewRow In frm.dgvMain.SelectedRows
                                Dim blnfound As Boolean = False
                                For i As Integer = 0 To dgvMembers.Rows.Count - 2
                                    If dgvMembers.Rows(i).Cells(2).Value = row.Cells(0).Value.ToString Then
                                        blnfound = True
                                    End If
                                Next
                                If Not blnfound Then
                                    Dim mydata As DataTable = mySql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + row.Cells(0).Value.ToString)
                                    dgvMembers.Rows.Add()
                                    dgvMembers.Rows(dgvMembers.RowCount - 2).Cells(2).Value = row.Cells(0).Value.ToString
                                    dgvMembers.Rows(dgvMembers.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                                Else
                                    MsgBox("Member is already been added")
                                End If
                            Next
                        End If
                      
                    End If
                End With
            Case 1
                If Not dgvMembers.CurrentRow.Cells(2).Value Is Nothing Then
                    If MsgBox("Do you want to remove this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            dgvMembers.Rows.RemoveAt(dgvMembers.CurrentCell.RowIndex)
                        Catch ex As Exception
                        End Try
                    End If
                End If
        End Select
    End Sub



    Private Sub txtLeader_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgvMembers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMembers.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLeader.CellClick
        Select Case dgvLeader.CurrentCell.ColumnIndex
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
                            For i As Integer = 0 To dgvLeader.Rows.Count - 2
                                If dgvLeader.Rows(i).Cells(2).Value = .returnValue Then
                                    blnfound = True
                                End If
                            Next
                            If Not blnfound Then
                                Dim mydata As DataTable = mySql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + .returnValue)
                                dgvLeader.Rows.Add()
                                dgvLeader.Rows(dgvLeader.RowCount - 2).Cells(2).Value = .returnValue
                                dgvLeader.Rows(dgvLeader.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                            Else
                                MsgBox("Member is already been added")
                            End If
                        Else
                            'MULTI
                            For Each row As DataGridViewRow In frm.dgvMain.SelectedRows
                                Dim blnfound As Boolean = False
                                For i As Integer = 0 To dgvMembers.Rows.Count - 2
                                    If dgvMembers.Rows(i).Cells(2).Value = row.Cells(0).Value.ToString Then
                                        blnfound = True
                                    End If
                                Next
                                If Not blnfound Then
                                    Dim mydata As DataTable = mySql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + row.Cells(0).Value.ToString)
                                    dgvLeader.Rows.Add()
                                    dgvLeader.Rows(dgvLeader.RowCount - 2).Cells(2).Value = row.Cells(0).Value.ToString
                                    dgvLeader.Rows(dgvLeader.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                                Else
                                    MsgBox("Member is already been added")
                                End If
                            Next
                        End If

                    End If
                End With
            Case 1
                If Not dgvLeader.CurrentRow.Cells(2).Value Is Nothing Then
                    If MsgBox("Do you want to remove this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            dgvLeader.Rows.RemoveAt(dgvLeader.CurrentCell.RowIndex)
                        Catch ex As Exception
                        End Try
                    End If
                End If
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLeader.CellContentClick

    End Sub
End Class