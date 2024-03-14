Imports PowerNET8.myString.Share
Public Class frmEventsAttendance
    Public EID As String = 2
    Private GID As String = "0"
    Private DID As String = "0"
    Private types As String = ""
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Dim dvGroup As New DataView
    Dim dvDistrict As New DataView

    Private Sub initialize()
        connect(mysql)
        cboMode.SelectedIndex = 0
        getData()
    End Sub

    Private Sub getData()
        Dim mydata As DataTable = mysql.Query("SELECT * from tbl_event where EID=" + EID)
        If mydata.Rows.Count > 0 Then
            types = mydata.Rows(0).Item("types")
            Select Case mydata.Rows(0).Item("types")
                Case "By District"
                    mydata = mysql.Query("SELECT * FROM tbl_event_participants_attendance where EID=" + EID + " and GID=" + GID + " and DID=" + DID)

                    'CREATE NEW DATA
                    If mydata.Rows.Count = 0 Then
                        mydata = mysql.Query("SELECT tbl_districtname.DID,tbl_districtname.districtName as 'DISTRICT_NAME' FROM   tbl_districtname  INNER JOIN  tbl_event_participants    ON (tbl_districtname.DID = tbl_event_participants.IID) where tbl_event_participants.EID=" + EID + " order by districtName ")
                        dvDistrict = New DataView(mydata)
                        dgvDistrict.DataSource = dvDistrict
                        dgvDistrict.Columns(0).Visible = False
                    End If

                Case "By Pastoral Leaders"
                    dgvDistrict.Rows.Clear()

                    mydata = mysql.Query("SELECT * FROM tbl_event_participants_attendance where EID=" + EID + " and GID=" + GID)

                    'CREATE NEW DATA
                    If mydata.Rows.Count = 0 Then

                        mydata = mysql.Query("SELECT tbl_group.GID,tbl_group.groupName as 'GROUP_NAME' FROM tbl_group INNER JOIN tbl_event_participants   ON (tbl_group.GID = tbl_event_participants.IID) where EID=" + EID)
                        dvGroup = New DataView(mydata)
                        dgvGroup.DataSource = dvGroup
                        dgvGroup.Columns(0).Visible = False

                    End If

                Case "By Member"
                    dgvDistrict.Rows.Clear()
                    dgvGroup.Rows.Clear()

                    mydata = mysql.Query("SELECT * FROM tbl_event_participants_attendance where EID=" + EID)
                    'CREATE NEW DATA
                    If mydata.Rows.Count = 0 Then
                        mydata = mysql.Query("SELECT tblp_info.IID, concat(surname,', ', firstname,' ',middlename) as 'Name' FROM tblp_info INNER JOIN tbl_event_participants    ON (tblp_info.IID = tbl_event_participants.IID) where  tbl_event_participants.EID = " + EID)
                        With dgvMember
                            For i As Integer = 0 To mydata.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                                .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                            Next
                        End With
                    Else
                        'EXISTING DATA
                        mydata = mysql.Query("SELECT tblp_info.IID, concat(surname,', ', firstname,' ',middlename) as 'Name', Attendance FROM  tblp_info  INNER JOIN tbl_event_participants_attendance    ON (tblp_info.IID = tbl_event_participants_attendance.IID) where tbl_event_participants_attendance.EID=" + EID.ToString)
                        With dgvMember
                            For i As Integer = 0 To mydata.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                                .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                                If mydata.Rows(i).Item(2).ToString = "True" Then
                                    .Rows(i).Cells(2).Value = 1
                                Else
                                    .Rows(i).Cells(2).Value = 0
                                End If
                            Next
                        End With
                    End If

            End Select
        End If
    End Sub

    Private Sub frmEventsAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub txtGroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.TextChanged
        dvGroup.RowFilter = " GROUP_NAME like '" + txtGroup.Text + "%'"
        dgvGroup.DataSource = dvGroup
    End Sub

    Private Sub dgvGroup_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGroup.CellClick

        If dgvGroup.RowCount > 0 Then
            lblSGroup.Text = dgvGroup.CurrentRow.Cells(1).Value
            GID = dgvGroup.CurrentRow.Cells(0).Value
            txtGroup.Text = ""

            Dim mydata As DataTable = mysql.Query("SELECT * FROM tbl_event_participants_attendance where EID=" + EID + " and GID=" + GID)

            If mydata.Rows.Count = 0 Then
                Dim sql As String = "SELECT tblp_info.IID, concat(surname,', ', firstname,' ',middlename) as 'Name'    FROM  tbl_group_members  INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID) INNER JOIN tblp_info   ON (tblp_info.IID = tbl_group_members.IID)  where tbl_group.GID=" + dgvGroup.CurrentRow.Cells(0).Value.ToString + " order by surname"
                mydata = mysql.Query(sql)
                With dgvMember
                    .Rows.Clear()
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                        .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                    Next
                End With
            Else
                mydata = mysql.Query("SELECT tblp_info.IID, concat(surname,', ', firstname,' ',middlename) as 'Name', Attendance FROM  tblp_info  INNER JOIN tbl_event_participants_attendance    ON (tblp_info.IID = tbl_event_participants_attendance.IID) where tbl_event_participants_attendance.EID=" + EID.ToString + " and tbl_event_participants_attendance.GID=" + GID)
                With dgvMember
                    .Rows.Clear()
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells(0).Value = mydata.Rows(i).Item(0)
                        .Rows(i).Cells(1).Value = mydata.Rows(i).Item(1)
                        If mydata.Rows(i).Item(2).ToString = "True" Then
                            .Rows(i).Cells(2).Value = 1
                        Else
                            .Rows(i).Cells(2).Value = 0
                        End If
                    Next
                End With
            End If



        End If

    End Sub

    Private Sub dgvDistrict_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDistrict.CellClick
        If dgvDistrict.RowCount > 0 Then
            dgvMember.Rows.Clear()
            lblSDistrict.Text = dgvDistrict.CurrentRow.Cells(1).Value
            DID = dgvDistrict.CurrentRow.Cells(0).Value
            txtDistrict.Text = ""
            lblSGroup.Text = "-"
            Dim sql As String = "SELECT tbl_group.GID,tbl_group.groupName as 'GROUP_NAME' FROM tbl_group INNER JOIN tbl_districtname_pastoralleaders   ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID) where tbl_districtname_pastoralleaders.DID=" + dgvDistrict.CurrentRow.Cells(0).Value.ToString + " order by groupName "
            Dim mydata As DataTable = mysql.Query(sql)
            dvGroup = New DataView(mydata)
            dgvGroup.DataSource = dvGroup
            dgvGroup.Columns(0).Visible = False
        End If
    End Sub

    Private Sub txtDistrict_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistrict.TextChanged
        dvDistrict.RowFilter = " DISTRICT_NAME like '" + txtDistrict.Text + "%'"
        dgvDistrict.DataSource = dvDistrict
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Select Case types
            Case "By District"
                mysql.Query("delete from tbl_event_participants_attendance where EID=" + EID + " and GID=" + GID + " and DID=" + DID)
                For i As Integer = 0 To dgvMember.Rows.Count - 1
                    With mysql
                        .setTable("tbl_event_participants_attendance")
                        .addValue(EID, "EID")
                        .addValue(GID, "GID")
                        .addValue(DID, "DID")
                        .addValue(dgvMember.Rows(i).Cells(0).Value, "IID")
                        If dgvMember.Rows(i).Cells(2).Value Then
                            .addValue(1, "Attendance")
                        Else
                            .addValue(0, "Attendance")
                        End If
                        .Insert()
                    End With
                Next
            Case "By Pastoral Leaders"
                mysql.Query("delete from tbl_event_participants_attendance where EID=" + EID + " and GID=" + GID)
                For i As Integer = 0 To dgvMember.Rows.Count - 1
                    With mysql
                        .setTable("tbl_event_participants_attendance")
                        .addValue(EID, "EID")
                        .addValue(GID, "GID")
                        .addValue(dgvMember.Rows(i).Cells(0).Value, "IID")
                        If dgvMember.Rows(i).Cells(2).Value Then
                            .addValue(1, "Attendance")
                        Else
                            .addValue(0, "Attendance")
                        End If
                        .Insert()
                    End With
                Next
            Case "By Member"
                mysql.Query("delete from tbl_event_participants_attendance where EID=" + EID)
                For i As Integer = 0 To dgvMember.Rows.Count - 1
                    With mysql
                        .setTable("tbl_event_participants_attendance")
                        .addValue(EID, "EID")
                        .addValue(dgvMember.Rows(i).Cells(0).Value, "IID")
                        If dgvMember.Rows(i).Cells(2).Value Then
                            .addValue(1, "Attendance")
                        Else
                            .addValue(0, "Attendance")
                        End If
                        .Insert()
                    End With
                Next

        End Select
    End Sub

    Private Function createTable() As DataTable
        Dim mytbl As New PowerNET8.myDataTableCreator
        With mytbl
            .new_table("tblDetails")
            .add_columnField("district")
            .add_columnField("leaders")
            .add_columnField("members")
            .add_columnField("attendance")
            Return .get_table
        End With
    End Function


    Private noAttended As Integer = 0
    Private Function getAttendanceSheet(ByVal dids As String, ByVal gips As String, ByVal iids As String) As String
        Dim sql As String = "SELECT * from tbl_event_participants_attendance where EID=" + EID + " and " + " DID=" + dids + " and GID = " + gips + " and IID = " + iids + " and Attendance=1"
        Dim mydata As DataTable = mysql.Query(sql)
        If mydata.Rows.Count > 0 Then
            noAttended += 1
            Return "PRESENT"
        Else
            Return "ABSENT"
        End If
    End Function

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim cr As New PowerNET8.myDocument.Init.CrystalReportViewer
        Dim table As DataTable = createTable()
        Dim mydata As DataTable
        Dim where As String = ""
        Dim blnFound As Boolean = False
        Select Case types
            Case "By District"
                noAttended = 0
                For i As Integer = 0 To dgvDistrict.Rows.Count - 1
                    If i = 0 Then
                        blnFound = True
                        where = " where tbl_districtname.DID=" + dgvDistrict.Rows(i).Cells(0).Value.ToString + " "
                    Else
                        where += " or tbl_districtname.DID=" + dgvDistrict.Rows(i).Cells(0).Value.ToString + " "
                    End If
                Next
                If Not blnFound Then
                    Exit Sub
                Else
                    mydata = mysql.Query("SELECT tbl_districtname.DID, districtName, tbl_group.GID, groupName, tblp_info.IID, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID)  " + where + " order by districtname,groupName,surName  ")
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With table
                            .Rows.Add()
                            .Rows(i).Item("district") = Trim(mydata.Rows(i).Item("districtName").ToString)
                            .Rows(i).Item("leaders") = Trim(mydata.Rows(i).Item("groupName").ToString)
                            .Rows(i).Item("members") = mydata.Rows(i).Item("NAME").ToString
                            .Rows(i).Item("attendance") = getAttendanceSheet(mydata.Rows(i).Item("DID"), mydata.Rows(i).Item("GID"), mydata.Rows(i).Item("IID"))
                        End With
                    Next
                End If
                cr.addParameterField("lblNoAttended", "Total Members Attended : " + noAttended.ToString + "/" + mydata.Rows.Count.ToString)
                cr.reportPath("Reports\rptAttendance_District.rpt")
            Case "By Pastoral Leaders"
                noAttended = 0
                For i As Integer = 0 To dgvGroup.Rows.Count - 1
                    If i = 0 Then
                        blnFound = True
                        where = " where tbl_group.GID=" + dgvGroup.Rows(i).Cells(0).Value.ToString + " "
                    Else
                        where += " or tbl_group.GID=" + dgvGroup.Rows(i).Cells(0).Value.ToString + " "
                    End If
                Next
                If Not blnFound Then
                    Exit Sub
                Else
                    mydata = mysql.Query("SELECT tbl_group.GID, groupName, tblp_info.IID, concat(surname,', ', firstname,' ',middlename) as 'Name' FROM tbl_group_members INNER JOIN tbl_group   ON (tbl_group_members.GID = tbl_group.GID)  INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID) " + where)
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With table
                            .Rows.Add()
                            .Rows(i).Item("leaders") = Trim(mydata.Rows(i).Item("groupName").ToString)
                            .Rows(i).Item("members") = mydata.Rows(i).Item("NAME").ToString
                            .Rows(i).Item("attendance") = getAttendanceSheet(0, mydata.Rows(i).Item("GID"), mydata.Rows(i).Item("IID"))
                        End With
                    Next
                End If
                cr.addParameterField("lblNoAttended", "Total Members Attended : " + noAttended.ToString + "/" + mydata.Rows.Count.ToString)
                cr.reportPath("Reports\rptAttendance_Group.rpt")
            Case "By Member"
                noAttended = 0
                For i As Integer = 0 To dgvMember.Rows.Count - 1
                    If i = 0 Then
                        blnFound = True
                        where = " where IID=" + dgvMember.Rows(i).Cells(0).Value.ToString + " "
                    Else
                        where += " or IID=" + dgvMember.Rows(i).Cells(0).Value.ToString + " "
                    End If
                Next

                If Not blnFound Then
                    Exit Sub
                Else
                    mydata = mysql.Query("SELECT tblp_info.IID,concat(surname,', ', firstname,' ',middlename) as 'Name' from tblp_info " + where + " order by surname")
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With table
                            .Rows.Add()
                            .Rows(i).Item("members") = mydata.Rows(i).Item("NAME").ToString
                            .Rows(i).Item("attendance") = getAttendanceSheet(0, 0, mydata.Rows(i).Item("IID"))
                        End With
                    Next
                End If
                cr.addParameterField("lblNoAttended", "Total Members Attended : " + noAttended.ToString + "/" + mydata.Rows.Count.ToString)
                cr.reportPath("Reports\rptAttendance_Member.rpt")
        End Select

        With cr
            .title = ""
            .addTableField(table)

            mydata = mysql.Query("SELECT * FROM tbl_event where EID=" + EID)
            If mydata.Rows.Count > 0 Then
                .addParameterField("lblTitle", mydata.Rows(0).Item("title"))
                Dim dt As Date = mydata.Rows(0).Item("Edate")
                .addParameterField("lblT", dt.ToString("MM/dd/yyyy"))
            Else
                .addParameterField("lblTitle", "-")
                .addParameterField("lblT", "-")
            End If

            .launchReport()
        End With
    End Sub
End Class