Public Class frmDistricts
    Private tsPrint As New ToolStripButton
    Private mySql As New PowerNET8.mySQL.Init.SQL
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Private allowOpen As Boolean = False
    Private IID As String = 0
    Public DID As String = "0"
    Public action As String = ""

    Private Sub initialize()
        connect(mySql)
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        loadObjects()
    End Sub

    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtCoordinator)
            .Add(txtDistrictName)
            .Add(dgvPastoralLeaders)
        End With
        clsObjects.setTextSkin(colObjects)
    End Sub

    Private Sub variables()
        If action = "add" Then
            DID = "0"
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
        Dim mydata As DataTable = mySql.Query("SELECT * from tbl_districtname  WHERE DID = " + DID)
        If mydata.Rows.Count > 0 Then
            txtDistrictName.Text = mydata.Rows(0).Item("districtName")
            txtCoordinator.Text = mydata.Rows(0).Item("coordinator")
        End If

        mydata = mySql.Query("SELECT tbl_group.GID,tbl_group.groupName FROM  tbl_group  INNER JOIN tbl_districtname_pastoralleaders   ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)  INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group.leader) where tbl_districtname_pastoralleaders.DID = " + DID + " order by groupName")
        dgvPastoralLeaders.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvPastoralLeaders
                .Rows.Add()
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item("GID")
                .Rows(i).Cells(3).Value = mydata.Rows(i).Item("groupName")
            End With
        Next

    End Sub

    Private Sub frmDistricts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsEdit.Click, tsSave.Click, tsCancel.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtDistrictName.Focus()
                DID = "0"
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                action = "add"
                allowOpen = True
            Case "Save"
                If txtDistrictName.Text <> "" And txtCoordinator.Text <> "" Then
                    With mySql
                        .setTable("tbl_districtname")
                        .addValue(txtDistrictName.Text, "districtName")
                        .addValue(txtCoordinator.Text, "coordinator")
                        If DID = "0" Then
                            DID = .nextID("DID")
                            .addValue(DID, "DID")
                            .Insert()
                        Else
                            .Update("DID", DID)
                        End If
                    End With

                    'PARTICIPANTS
                    mySql.Query("DELETE FROM tbl_districtname_pastoralleaders where DID=" + DID)
                    For i As Integer = 0 To dgvPastoralLeaders.RowCount - 2
                        With mySql
                            .setTable("tbl_districtname_pastoralleaders")
                            .addValue(DID, "DID")
                            .addValue(dgvPastoralLeaders.Rows(i).Cells(2).Value, "GID")
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

    Private Sub dgvParticipants_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPastoralLeaders.CellClick
        Select Case dgvPastoralLeaders.CurrentCell.ColumnIndex
            Case 0
                Dim frm As New frmGroupFinder
                With frm
                    .action = "use"
                    .ShowDialog()
                    If .returnValue <> "" Then
                        Dim blnfound As Boolean = False
                        For i As Integer = 0 To dgvPastoralLeaders.Rows.Count - 2
                            If dgvPastoralLeaders.Rows(i).Cells(2).Value = .returnValue Then
                                blnfound = True
                            End If
                        Next
                        If Not blnfound Then
                            Dim mydata As DataTable = mySql.Query("SELECT tbl_group.GID,groupName FROM  tbl_group where tbl_group.GID = " + .returnValue)
                            dgvPastoralLeaders.Rows.Add()
                            dgvPastoralLeaders.Rows(dgvPastoralLeaders.RowCount - 2).Cells(2).Value = .returnValue
                            If mydata.Rows.Count > 0 Then
                                dgvPastoralLeaders.Rows(dgvPastoralLeaders.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item("groupName")
                            End If
                        Else
                            MsgBox("Member is already been added")
                        End If
                    End If
                End With
            Case 1
                If Not dgvPastoralLeaders.CurrentRow.Cells(2).Value Is Nothing Then
                    If MsgBox("Do you want to remove this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            dgvPastoralLeaders.Rows.RemoveAt(dgvPastoralLeaders.CurrentCell.RowIndex)
                        Catch ex As Exception
                        End Try
                    End If
                End If
        End Select
    End Sub



    Private Sub dgvPastoralLeaders_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPastoralLeaders.CellContentClick

    End Sub
End Class