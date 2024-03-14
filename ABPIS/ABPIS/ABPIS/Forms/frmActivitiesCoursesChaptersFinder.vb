Imports PowerNET8.myString.Share
Public Class frmActivitiesCoursesChaptersFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public returnvalue As String = ""
    Public CID As String = ""
    Public action As String = ""

    Private Sub initialize()
        connect(mysql)
        loadRecord()
    End Sub

    Private Sub loadRecord()
        With navMain
            .set_class(mysql)
            If action = "course" Then
                .Set_SELECT("CID, type, Name")
                .Set_FROM("tbl_lstcourses")
            Else
                .Set_SELECT("UID,Code, type, Name")
                .Set_FROM("tbl_lstcourses_unit")
            End If
            .Set_ORDER("Name")
            If CID <> "" Then .Set_WHERE("CID=" + CID)
            .Set_Data(dgvMain)
            .Execute()
        End With
        dgvMain.Columns(0).Visible = False
    End Sub

    Private Sub frmActivitiesCoursesChaptersFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim x As String = ""
        If txtType.Text <> "" Then Concat.Append(x, "Type LIKE '" + txtType.Text + "%'", " and ")
        If txtName.Text <> "" Then Concat.Append(x, " name like '" + txtName.Text + "%'", " and ")

        If action = "course" Then
            If x <> "" Then
                navMain.Set_WHERE(x)
            Else
                navMain.Set_WHERE("")
            End If
        Else
            If x <> "" Then
                navMain.Set_WHERE(x + " and CID=" + CID)
            Else
                If CID <> "" Then navMain.Set_WHERE("CID=" + CID)
            End If
        End If
        navMain.Execute()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If action = "course" Then
                returnvalue = dgvMain.CurrentRow.Cells(0).Value.ToString + "~" + dgvMain.CurrentRow.Cells(1).Value.ToString + "~" + dgvMain.CurrentRow.Cells(2).Value.ToString
            Else
                returnvalue = dgvMain.CurrentRow.Cells(0).Value.ToString + "~" + dgvMain.CurrentRow.Cells(3).Value.ToString + "~" + dgvMain.CurrentRow.Cells(2).Value.ToString
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("Please select a record")
        End Try
    End Sub

    Private Sub dgvMain_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvMain.MouseDoubleClick
        If dgvMain.RowCount > 0 Then
            cmdAdd_Click(cmdAdd, Nothing)
        End If
    End Sub
End Class