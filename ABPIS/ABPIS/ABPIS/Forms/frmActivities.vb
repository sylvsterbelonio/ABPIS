Public Class frmActivities
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private lstCID As New ArrayList
    Private CID As String = "0"
    Private UID As String = "0"
    Private tsPrint As New ToolStripButton
    Public action As String = ""
    Public AMID As String = "0"
    Private allowOpen As Boolean = True

    Private Sub loadObjects()
        With colObjects
            .Clear()
            .Add(txtChapters)
            .Add(txtCourse)
            .Add(txtTrainings)
            .Add(dgvJoined)
            .Add(udtConductedTrainings)
        End With
    End Sub

    Private Sub initialize()
        connect(mysql)
        loadObjects()
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        clsObjects.setTextSkin(colObjects)
        udtConductedTrainings.Value = Now
    End Sub

    Private Sub variables()
        If action = "add" Then
            AMID = "0"
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

    Private Sub reloadRecord()
        Dim mydata As DataTable = mysql.Query("SELECT tbl_activities.AMID,trainings,tbl_lstcourses.CID, tbl_lstcourses.Name as 'course',tbl_lstcourses_unit.UID,tbl_lstcourses_unit.Name as 'chapters',tbl_activities.type,tbl_activities.dtActivites FROM tbl_lstcourses   right JOIN  tbl_activities     ON (tbl_lstcourses.CID = tbl_activities.courses)   left JOIN  tbl_lstcourses_unit    ON (tbl_lstcourses_unit.UID = tbl_activities.subCourse) where tbl_activities.AMID=" + AMID)
        If mydata.Rows.Count > 0 Then
            txtTrainings.Text = mydata.Rows(0).Item("trainings")
            If Not IsDBNull(mydata.Rows(0).Item("course")) Then
                CID = mydata.Rows(0).Item("CID")
                txtCourse.Text = mydata.Rows(0).Item("course")
            End If
            If Not IsDBNull(mydata.Rows(0).Item("chapters")) Then
                txtChapters.Text = mydata.Rows(0).Item("chapters")
                UID = mydata.Rows(0).Item("UID")
            End If
            udtConductedTrainings.Value = mydata.Rows(0).Item("dtActivites")
        End If


        mydata = mysql.Query("SELECT tblp_info_courses.whenJoined,tbl_activities.AMID,tblp_info.IID, concat(surName,', ',firstName,' ',middleName) as 'name', tbl_lstcourses.Name as 'course', tbl_lstcourses_unit.Name as 'chp' FROM   tblp_info_courses   INNER JOIN abpis.tbl_activities        ON (tblp_info_courses.AMID = tbl_activities.AMID)   INNER JOIN tblp_info        ON (tblp_info.IID = tblp_info_courses.IID)   left JOIN tbl_lstcourses      ON (tbl_lstcourses.CID = tblp_info_courses.CID)   left JOIN abpis.tbl_lstcourses_unit     ON (tbl_lstcourses_unit.UID = tblp_info_courses.UID) where tbl_activities.AMID = " + AMID)
        dgvJoined.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvJoined
                .Rows.Add()
                With .Rows(i)
                    .Cells(2).Value = mydata.Rows(i).Item("IID")
                    .Cells(3).Value = mydata.Rows(i).Item("name")
                    .Cells(4).Value = mydata.Rows(i).Item("whenJoined")
                End With
            End With
        Next

    End Sub

    Private Sub frmActivities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        variables()

    End Sub

    Private Sub dgvJoined_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJoined.CellClick
        Select Case dgvJoined.CurrentCell.ColumnIndex
            Case 0
                If allowOpen Then
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
                                'SINGLE MODE'
                                Dim blnfound As Boolean = False
                                For i As Integer = 0 To dgvJoined.Rows.Count - 2
                                    If dgvJoined.Rows(i).Cells(2).Value = .returnValue Then
                                        blnfound = True
                                    End If
                                Next
                                If Not blnfound Then
                                    Dim mydata As DataTable = mysql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + .returnValue)
                                    dgvJoined.Rows.Add()
                                    dgvJoined.Rows(dgvJoined.RowCount - 2).Cells(2).Value = .returnValue
                                    dgvJoined.Rows(dgvJoined.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                                    dgvJoined.Rows(dgvJoined.RowCount - 2).Cells(4).Value = udtConductedTrainings.Value
                                Else
                                    MsgBox("Member is already been added")
                                End If
                            Else
                                'MULTI MODE'
                                For Each row As DataGridViewRow In frm.dgvMain.SelectedRows

                                    Dim blnfound As Boolean = False
                                    For i As Integer = 0 To dgvJoined.Rows.Count - 2
                                        If dgvJoined.Rows(i).Cells(2).Value = row.Cells(0).Value.ToString Then
                                            blnfound = True
                                        End If
                                    Next
                                    If Not blnfound Then
                                        Dim mydata As DataTable = mysql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + row.Cells(0).Value.ToString)
                                        dgvJoined.Rows.Add()
                                        dgvJoined.Rows(dgvJoined.RowCount - 2).Cells(2).Value = row.Cells(0).Value.ToString
                                        dgvJoined.Rows(dgvJoined.RowCount - 2).Cells(3).Value = mydata.Rows(0).Item(0)
                                        dgvJoined.Rows(dgvJoined.RowCount - 2).Cells(4).Value = udtConductedTrainings.Value
                                    Else
                                        MsgBox("Member is already been added")
                                    End If

                                Next

                            End If

                        End If
                    End With
                End If
            Case 1
                If Not dgvJoined.CurrentRow.Cells(2).Value Is Nothing Then
                    If MsgBox("Do you want to remove this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            dgvJoined.Rows.RemoveAt(dgvJoined.CurrentCell.RowIndex)
                        Catch ex As Exception
                        End Try
                    End If
                End If
        End Select
    End Sub

    Private Sub dgvJoined_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvJoined.RowsAdded
        dgvJoined.Rows(dgvJoined.RowCount - 1).Cells(4).Value = Now
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCourse.MouseClick
        If allowOpen Then
            Dim frm As New frmActivitiesCoursesChaptersFinder
            With frm
                .action = "course"
                .ShowDialog()
                If .returnvalue <> "" Then
                    Dim col() As String = .returnvalue.Split("~")
                    CID = col(0)
                    txtCourse.Text = col(1)
                End If
            End With
        End If
    End Sub

    Private Sub txtChapters_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtChapters.MouseClick
        If allowOpen Then
            Dim frm As New frmActivitiesCoursesChaptersFinder
            If CID <> "0" Then
                With frm
                    .action = "chapters"
                    .CID = CID
                    .ShowDialog()
                    If .returnvalue <> "" Then
                        Dim col() As String = .returnvalue.Split("~")
                        UID = col(0)
                        txtChapters.Text = col(1)
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtCourse.Text = ""
        CID = "0"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtChapters.Text = ""
        UID = "0"
    End Sub

    Private Sub udtConductedTrainings_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udtConductedTrainings.ValueChanged
        For i As Integer = 0 To dgvJoined.RowCount - 2
            Try
                dgvJoined.Rows(i).Cells(4).Value = udtConductedTrainings.Value
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsEdit.Click, tsCancel.Click, tsSave.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtTrainings.Text = ""
                txtTrainings.Focus()
                txtCourse.Text = ""
                CID = "0"
                txtChapters.Text = ""
                UID = "0"
                dgvJoined.Rows.Clear()
                mytoolstrip.toolstripNavigation(clsObjects.ToolAction.add)
                clsObjects.Lock_Mode_All(colObjects, clsObjects.Lock.No)
                allowOpen = True
                action = "add"
            Case "Save"
                If txtTrainings.Text <> "" Then
                    With mysql
                        .setTable("tbl_activities")
                        .addValue(txtTrainings.Text, "trainings")
                        .addValue(CID, "courses")
                        .addValue(UID, "subCourse")
                        .addValue(udtConductedTrainings.Value, "dtActivites")
                        If AMID = "0" Then
                            AMID = .nextID("AMID")
                            .addValue(AMID, "AMID")
                            .Insert()
                        Else
                            .Update("AMID", AMID)
                        End If
                    End With

                    mysql.Query("DELETE FROM tblp_info_courses where AMID=" + AMID)
                    For i As Integer = 0 To dgvJoined.Rows.Count - 2
                        With mysql
                            .setTable("tblp_info_courses")
                            .addValue(AMID, "AMID")
                            .addValue(dgvJoined.Rows(i).Cells(2).Value, "IID")
                            .addValue(CID, "CID")
                            .addValue(UID, "UID")
                            .addValue(dgvJoined.Rows(i).Cells(4).Value, "WhenJoined")
                            .Insert()
                        End With
                    Next

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

    Private Sub txtCourse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCourse.TextChanged

    End Sub

    Private Sub dgvJoined_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJoined.CellContentClick

    End Sub
End Class