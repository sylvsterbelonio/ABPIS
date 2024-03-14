Imports PowerNET8.myString.Share
Public Class frmReport
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private lstDID As New ArrayList
    Private Sub initialize()
        connect(mysql)
        cboType.SelectedIndex = 0
        cboGender.Text = "-All-"
        cboStatus.Text = "-All-"
        cboMStatus.Text = "-All-"
        txtAfrom.Value = 0
        txtATo.Value = 0
        reloadDistrictNames()
        reloadLocation()
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub reloadDistrictNames()
        Dim mydata As DataTable = mysql.Query("SELECT * from tbl_districtname order by districtName")
        cboDistrict.Items.Clear()
        lstDID.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            lstDID.Add(mydata.Rows(i).Item("DID"))
            cboDistrict.Items.Add(mydata.Rows(i).Item("districtName"))
        Next
        cboDistrict.Items.Add("-All-")
    End Sub

    Private Sub reloadLocation()
        Dim mydata As DataTable = mysql.Query("SELECT distinct location from tbl_event order by location")
        cboLocation.Items.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            cboLocation.Items.Add(mydata.Rows(i).Item("location"))
        Next
        cboLocation.Items.Add("-All-")
    End Sub

    Private Function createTable(ByVal type As String)
        Dim mydatac As New PowerNET8.myDataTableCreator
        With mydatac
            Select Case type
                Case "memberlist"
                    .new_table("tblDetails")
                    .add_columnField("lastname")
                    .add_columnField("firstname")
                    .add_columnField("middlename")
                    .add_columnField("address")
                    .add_columnField("contactNo")
                    .add_columnField("age")
                    Return .get_table
                Case "memberpopulation"
                    .new_table("tblDetails")
                    .add_columnField("Category")
                    .add_columnField("TotalNo", PowerNET8.myDataTableCreator.FieldType.Integer_)
                    Return .get_table
                Case "district"
                    .new_table("tblDetails")
                    .add_columnField("member")
                    .add_columnField("districtID")
                    .add_columnField("dirstrictName")
                    .add_columnField("pastoralLeaders")
                    .add_columnField("coordinator")
                    Return .get_table
                Case "events"
                    .new_table("tblDetails")
                    .add_columnField("title")
                    .add_columnField("location")
                    .add_columnField("date")
                    .add_columnField("time")
                    .add_columnField("facilitator")
                    .add_columnField("members")
                    Return .get_table
            End Select
        End With
    End Function
    Private Sub cmdPMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPMember.Click, cmdPPrint.Click, cmdDPrint.Click, cmdEPrint.Click

        Dim mycr As New PowerNET8.myDocument.Init.CrystalReportViewer
        With mycr
            Select Case CType(sender, Button).Name
                Case "cmdPMember"
                    Dim myDetail As DataTable = createTable("memberlist")
                    Dim x As String = ""
                    Concat.Append(x, cboType.Text + " LIKE '" + txtName.Text + "%'", "and")
                    If txtAfrom.Value <> 0 And txtATo.Value <> 0 Then
                        Concat.Append(x, "age >= " + txtAfrom.Value.ToString + " and age <=" + txtATo.Value.ToString, " and ")
                    End If
                    If cboGender.Text <> "-All-" Then Concat.Append(x, "gender = '" + cboGender.Text + "'", " and ")
                    If cboStatus.Text <> "-All-" Then Concat.Append(x, "status ='" + cboStatus.Text + "'", " and ")
                    If cboMStatus.Text <> "-All-" Then Concat.Append(x, "isActive =" + IIf(cboMStatus.Text = "Active", 1, 0).ToString, " and ")
                    Dim mydata As DataTable = mysql.Query("SELECT * from tblp_info where " + x)
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        myDetail.Rows.Add()
                        myDetail.Rows(i).Item("lastname") = mydata.Rows(i).Item("surName")
                        myDetail.Rows(i).Item("firstname") = mydata.Rows(i).Item("firstName")
                        myDetail.Rows(i).Item("middlename") = mydata.Rows(i).Item("middleName")
                        myDetail.Rows(i).Item("address") = mydata.Rows(i).Item("homeAddress")
                        myDetail.Rows(i).Item("contactNo") = mydata.Rows(i).Item("cellPhone")
                        myDetail.Rows(i).Item("age") = mydata.Rows(i).Item("age").ToString
                    Next
                    .addTableField(myDetail)
                    .reportPath("Reports\rptMemberList.rpt")
                    .launchReport()
                Case "cmdPPrint"
                    If cboPType.SelectedIndex <> -1 Then
                        Dim mydetails As DataTable = createTable("memberpopulation")
                        Dim mydata As DataTable = mysql.Query("SELECT " + cboPType.Text + ",COUNT(*) as category from tblp_info GROUP BY " + cboPType.Text + " order by " + cboPType.Text + " " + IIf(cboPType.Text = "isActive", "desc", ""))
                        For i As Integer = 0 To mydata.Rows.Count - 1
                            mydetails.Rows.Add()
                            If cboPType.Text = "isActive" Then
                                mydetails.Rows(i).Item("Category") = IIf(mydata.Rows(i).Item(cboPType.Text) = False, "Inactive", "Active")
                                mydetails.Rows(i).Item("TotalNo") = mydata.Rows(i).Item(1)
                            Else
                                mydetails.Rows(i).Item("Category") = mydata.Rows(i).Item(cboPType.Text)
                                mydetails.Rows(i).Item("TotalNo") = mydata.Rows(i).Item(1)
                            End If
                        Next
                        .addTableField(mydetails)
                        .reportPath("Reports\rptMemberPopulation.rpt")
                        .launchReport()
                    Else
                        MsgBox("Please select a record")
                    End If
                Case "cmdDPrint"
                    Dim mydetails As DataTable = createTable("district")
                    Dim x As String = ""
                    If cboDistrict.Text <> "-All-" Then x = " where districtname like '" + cboDistrict.Text + "%' "
                    Dim mydata As DataTable = mysql.Query("SELECT GROUPNAME, tbl_districtname.DID, tbl_districtname.districtName, CONCAT(surName,', ',firstName,' ',middleName) as 'pleader', coordinator  FROM   tbl_districtname  INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_districtname.DID = tbl_districtname_pastoralleaders.DID)   INNER JOIN tbl_group      ON (tbl_districtname_pastoralleaders.GID = tbl_group.GID)   INNER JOIN tblp_info     ON (tbl_group.leader = tblp_info.IID) " + x + " order by districtname,surname")
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With mydetails
                            .Rows.Add()
                            .Rows(i).Item("member") = mydata.Rows(i).Item("GROUPNAME")
                            .Rows(i).Item("districtID") = mydata.Rows(i).Item("DID")
                            .Rows(i).Item("dirstrictName") = mydata.Rows(i).Item("districtName")
                            .Rows(i).Item("pastoralLeaders") = mydata.Rows(i).Item("pleader")
                            .Rows(i).Item("coordinator") = mydata.Rows(i).Item("coordinator")
                        End With
                    Next
                    .addTableField(mydetails)
                    .reportPath("Reports\rptDistrictName.rpt")
                    .launchReport()

                Case "cmdEPrint"
                    Dim mydetails As DataTable = createTable("events")
                    Dim x As String = ""
                    If cboLocation.Text <> "-All-" Then x = " location like '" + cboLocation.Text + "%' "
                    If chkEInclude.Checked Then
                        Dim dt As Date = udtFrom.Value
                        Dim dt2 As Date = udtTo.Value
                        Concat.Append(x, " Edate Between '" + dt.ToString("yyyy-MM-dd") + " 00:00:00' and '" + dt2.ToString("yyyy-MM-dd") + " 23:59:59'", " and ")
                    End If

                    Dim mydata As DataTable = mysql.Query("SELECT tbl_event.EID,title, location, Edate, facilator, concat(surName,', ',firstName,' ', middleName) as 'members' FROM   tbl_event   INNER JOIN  tbl_event_participants      ON (tbl_event.EID = tbl_event_participants.EID)  INNER JOIN  tblp_info    ON (tbl_event_participants.IID = tblp_info.IID) " + IIf(x = "", "", " where ") + x + " order by title, facilator, surName")
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        With mydetails
                            .Rows.Add()
                            .Rows(i).Item("title") = mydata.Rows(i).Item("title")
                            .Rows(i).Item("location") = mydata.Rows(i).Item("location")
                            Dim dt As Date = mydata.Rows(i).Item("Edate")
                            .Rows(i).Item("date") = dt.ToString("yyyy-MM-dd")
                            Dim col() As String = dt.ToString("hh:mm:ss").ToString.Split(":")
                            If col(0) > 12 Then
                                .Rows(i).Item("time") = (Val(col(0)) - 12) + ":" + col(1) + " PM"
                            Else
                                .Rows(i).Item("time") = col(0) + ":" + col(1) + " AM"
                            End If

                            .Rows(i).Item("title") = mydata.Rows(i).Item("title")

                            .Rows(i).Item("facilitator") = mydata.Rows(i).Item("facilator")
                            .Rows(i).Item("members") = mydata.Rows(i).Item("members")
                        End With
                    Next
                    .addTableField(mydetails)
                    .reportPath("Reports\rptEvents.rpt")
                    .launchReport()
            End Select
        End With
    End Sub

    Private Sub cmdMReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMReset.Click, cmdPReset.Click
        Select Case CType(sender, Button).Name
            Case "cmdMReset"
                cboType.SelectedIndex = 0
                txtName.Text = ""
                txtName.Focus()
                txtAfrom.Value = 0
                txtATo.Value = 0
                cboMStatus.Text = "-All-"
                cboStatus.Text = "-All-"
                cboGender.Text = "-All-"
            Case "cmdPReset"
                cboPType.SelectedIndex = 0
        End Select

    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.SelectedIndex <> -1 Then
            txtName.Text = ""
            txtName.Focus()
        End If
    End Sub

    Private Sub txtATo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtATo.ValueChanged
        If txtAfrom.Value > txtATo.Value Then
            txtAfrom.Value = txtATo.Value
        End If
    End Sub

    Private Sub txtAfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAfrom.ValueChanged
        If txtATo.Value < txtAfrom.Value Then
            txtATo.Value = txtAfrom.Value
        End If
    End Sub

    Private Sub udtFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udtFrom.ValueChanged
       If udtTo.Value < udtFrom.Value Then
            udtTo.Value = udtFrom.Value
        End If
    End Sub

    Private Sub udtTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udtTo.ValueChanged
        If udtFrom.Value > udtTo.Value Then
            udtFrom.Value = udtTo.Value
        End If
    End Sub

    Private Sub chkEInclude_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEInclude.CheckedChanged
        If chkEInclude.Checked Then
            udtFrom.Enabled = True
            udtTo.Enabled = True
        Else
            udtFrom.Enabled = False
            udtTo.Enabled = False
        End If
    End Sub
End Class