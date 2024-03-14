Public Class frmContributionReport
    Private mysql As New PowerNET8.mySQL.Init.SQL

    Private Sub cboTypeOfPayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeOfPayment.SelectedIndexChanged
        If cboTypeOfPayment.Text = "Others" Then
            cboOtherSpecify.Visible = True
            cboOtherSpecify.SelectedIndex = 0
        Else
            cboOtherSpecify.Visible = False
        End If
    End Sub

    Private Sub initialize()
        connect(mysql)
        getTypeOfPayment()
        txtYear.Text = Now.Year
        cboTypeReport.SelectedIndex = 0
        cboPeriodType.SelectedIndex = 0
        cboTypeOfPayment.SelectedIndex = 0
    End Sub

    Private Sub getTypeOfPayment()
        Dim mydata As DataTable = mysql.Query("SELECT DISTINCT typeOfpayment from tbl_contribution_record_history order by typeOfpayment")
        With cboTypeOfPayment
            .Items.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                If Trim(mydata.Rows(i).Item(0)) <> "" Then
                    .Items.Add(mydata.Rows(i).Item(0))
                End If
            Next
        End With

        mydata = mysql.Query("SELECT distinct otherSpecify from tbl_contribution_record_history order by otherSpecify")
        With cboOtherSpecify
            .Items.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                If Trim(mydata.Rows(i).Item(0)) <> "" Then
                    .Items.Add(mydata.Rows(i).Item(0))
                End If
            Next
        End With
    End Sub

    Private Sub frmContributionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub cboPeriodType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodType.SelectedIndexChanged
        Select Case cboPeriodType.SelectedIndex
            Case 0
                With cboMonth
                    .Visible = True
                    .Items.Clear()
                    With .Items
                        .Add("Jan")
                        .Add("Feb")
                        .Add("Mar")
                        .Add("Apr")
                        .Add("May")
                        .Add("Jun")
                        .Add("Jul")
                        .Add("Aug")
                        .Add("Sep")
                        .Add("Oct")
                        .Add("Nov")
                        .Add("Dec")
                    End With
                    .SelectedIndex = 0
                End With
            Case 1
                With cboMonth
                    .Visible = True
                    .Items.Clear()
                    With .Items
                        .Add("1st Quarter")
                        .Add("2nd Quarter")
                        .Add("3rd Quarter")
                        .Add("4th Quarter")
                    End With
                    .SelectedIndex = 0
                End With
            Case 2
                With cboMonth
                    .Visible = False
                End With
        End Select
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        txtYear.Text = Val(txtYear.Text) + 1
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        txtYear.Text = Val(txtYear.Text) - 1
    End Sub

    Private Sub cboTypeReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeReport.SelectedIndexChanged
        If cboTypeReport.Text = "By Summary" Then
            cboTypeOfPayment.SelectedIndex = 0
            cboTypeOfPayment.Visible = False
            Label2.Visible = False
            txtMembers.Visible = False
            Label5.Visible = False
            chkBGroup.Visible = False
        ElseIf cboTypeReport.Text = "By OR Members" Then
            txtMembers.Text = ""
            Label5.Visible = True
            txtMembers.Visible = True
            cboTypeOfPayment.Visible = False
            Label2.Visible = False
            chkBGroup.Visible = True
        Else
            Label2.Visible = True
            txtMembers.Visible = False
            cboTypeOfPayment.SelectedIndex = 0
            cboTypeOfPayment.Visible = True
            Label5.Visible = False
            chkBGroup.Visible = False
        End If
    End Sub




    Private Function createTable() As DataTable
        Dim tb As New PowerNET8.myDataTableCreator
        With tb
            .new_table("tblDetails")
            .add_columnField("district")
            .add_columnField("leaders")
            .add_columnField("members")
            .add_columnField("amount", PowerNET8.myDataTableCreator.FieldType.Decimal_)
            Return .get_table
        End With
    End Function


    Private Function getDatePeriod() As String
        Select Case cboPeriodType.Text
            Case "By Month"
                Return " and dtPayment between '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-1' and '" + txtYear.Text + "-" + (cboMonth.SelectedIndex + 1).ToString + "-31'"
            Case "By Quarter"
                Select Case cboMonth.Text
                    Case "1st Quarter"
                        Return " and dtPayment between '" + txtYear.Text + "-1-1' and '" + txtYear.Text + "-3-31'"
                    Case "2nd Quarter"
                        Return " and dtPayment between '" + txtYear.Text + "-4-1' and '" + txtYear.Text + "-6-31'"
                    Case "3rd Quarter"
                        Return " and dtPayment between '" + txtYear.Text + "-7-1' and '" + txtYear.Text + "-9-31'"
                    Case "4th Quarter"
                        Return " and dtPayment between '" + txtYear.Text + "-10-1' and '" + txtYear.Text + "-12-31'"
                End Select
            Case "By Year"
                Return " and dtPayment between '" + txtYear.Text + "-1-1' and '" + txtYear.Text + "-12-31'"
        End Select
        Return Nothing
    End Function

    Private Function getMonth(ByVal index As Integer)
        Dim col() = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Return col(index)
    End Function

    Private Function getParameterPeriod() As String
        Select Case cboPeriodType.Text
            Case "By Month"
                Return "For the month of '" + getMonth(cboMonth.SelectedIndex) + " " + txtYear.Text
            Case "By Quarter"
                Select Case cboMonth.Text
                    Case "1st Quarter"
                        Return "For the 1st Quarter of " + txtYear.Text
                    Case "2nd Quarter"
                        Return "For the 2nd Quarter of " + txtYear.Text
                    Case "3rd Quarter"
                        Return "For the 3rd Quarter of " + txtYear.Text
                    Case "4th Quarter"
                        Return "For the 4th Quarter of " + txtYear.Text
                End Select
            Case "By Year"
                Return "For the year of " + txtYear.Text
        End Select
        Return Nothing
    End Function

    Private Function getListPersonQuery(Optional ByVal types As String = "")
        If types = "" Then
            If cboTypeReport.Text <> "By Summary" Then
                Dim where As String = ""
                If cboTypeOfPayment.Text <> "Others" Then
                    Dim mydata As DataTable = mysql.Query("SELECT IID, orNo,dtPayment, typeOfpayment, journalEntry,otherSpecify,amount FROM    tbl_contribution_record  INNER JOIN  tbl_contribution_record_history   ON (tbl_contribution_record.CRID = tbl_contribution_record_history.CRID) where typeOfPayment = '" + cboTypeOfPayment.Text + "' " + getDatePeriod())
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        If i = 0 Then
                            where = " where tblp_info.IID=" + mydata.Rows(i).Item(0).ToString
                        Else
                            where += " or tblp_info.IID=" + mydata.Rows(i).Item(0).ToString
                        End If
                    Next
                Else
                    Dim mydata As DataTable = mysql.Query("SELECT IID, orNo,dtPayment, typeOfpayment, journalEntry,otherSpecify,amount FROM    tbl_contribution_record  INNER JOIN  tbl_contribution_record_history   ON (tbl_contribution_record.CRID = tbl_contribution_record_history.CRID) where otherSpecify = '" + cboOtherSpecify.Text + "' " + getDatePeriod())
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        If i = 0 Then
                            where = " where tblp_info.IID=" + mydata.Rows(i).Item(0).ToString
                        Else
                            where += " or tblp_info.IID=" + mydata.Rows(i).Item(0).ToString
                        End If
                    Next
                End If
                Return where
            End If
        Else
            Dim mydata As DataTable = mysql.Query("SELECT tbl_contribution_record.IID, orNo,dtPayment, typeOfpayment, journalEntry,otherSpecify,amount FROM    tbl_contribution_record  INNER JOIN  tbl_contribution_record_history   ON (tbl_contribution_record.CRID = tbl_contribution_record_history.CRID) where tbl_contribution_record.IID=" + types + " and typeOfPayment = '" + cboTypeOfPayment.Text + "' " + getDatePeriod())
            If mydata.Rows.Count > 0 Then
                Return mydata.Rows(0).Item("amount")
            Else
                Return 0
            End If
        End If
        Return 0
    End Function

    Private Function ORDate(ByVal types As String)
        Dim mydata As DataTable = mysql.Query("SELECT tbl_contribution_record.IID, orNo,dtPayment, typeOfpayment, journalEntry,otherSpecify,amount FROM    tbl_contribution_record  INNER JOIN  tbl_contribution_record_history   ON (tbl_contribution_record.CRID = tbl_contribution_record_history.CRID) where tbl_contribution_record.IID=" + types + " and typeOfPayment = '" + cboTypeOfPayment.Text + "' " + getDatePeriod())
        If mydata.Rows.Count > 0 Then
            Dim dt As Date = mydata.Rows(0).Item("dtPayment")
            Return " - ORNo.:" + mydata.Rows(0).Item("orNo") + " (" + dt.ToString("MM/dd/yyyy") + ")"
        Else
            Return ""
        End If
    End Function

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim cr As New PowerNET8.myDocument.Init.CrystalReportViewer
        Dim table As DataTable = createTable()

        With cr
            .title = "CONTRIBUTION REPORT SUMMARY - " + cboTypeOfPayment.Text

            If cboTypeReport.Text = "By District" Then
                Dim mydata As DataTable = mysql.Query("SELECT tblp_info.IID, districtName, groupName, concat(surName,', ',firstName,' ',middleName) as 'NAME' FROM  tbl_group_members   INNER JOIN tbl_group    ON (tbl_group_members.GID = tbl_group.GID)   INNER JOIN tbl_districtname_pastoralleaders    ON (tbl_group.GID = tbl_districtname_pastoralleaders.GID)   INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID)   INNER JOIN tbl_districtname    ON (tbl_districtname_pastoralleaders.DID = tbl_districtname.DID) " + getListPersonQuery() + " order by districtname,groupName,surName ")
                table.Rows.Clear()
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With table
                        .Rows.Add()
                        .Rows(i).Item("district") = mydata.Rows(i).Item("districtName")
                        .Rows(i).Item("leaders") = mydata.Rows(i).Item("groupName")
                        .Rows(i).Item("members") = mydata.Rows(i).Item("NAME") + ORDate(mydata.Rows(i).Item("IID"))
                        .Rows(i).Item("amount") = PowerNET8.myNumber.Share.Formatter.format_DecimalOnly(getListPersonQuery(mydata.Rows(i).Item("IID")), 2)
                    End With
                Next

                If cboTypeOfPayment.Text <> "Others" Then
                    .addParameterField("lblSubHead", "BY DISTRICT - " + cboTypeOfPayment.Text)
                Else
                    .addParameterField("lblSubHead", "BY DISTRICT - " + cboTypeOfPayment.Text + " (" + cboOtherSpecify.Text + ")")
                End If

                .addTableField(table)
                .reportPath("Reports\rptContribution_Report_District.rpt")
            ElseIf cboTypeReport.Text = "By Leaders" Then
                Dim mydata As DataTable = mysql.Query("SELECT tbl_group.GID, groupName, tblp_info.IID, concat(surname,', ', firstname,' ',middlename) as 'Name' FROM tbl_group_members INNER JOIN tbl_group   ON (tbl_group_members.GID = tbl_group.GID)  INNER JOIN tblp_info    ON (tblp_info.IID = tbl_group_members.IID) " + getListPersonQuery() + " order by groupName,surName ")
                table.Rows.Clear()
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With table
                        .Rows.Add()
                        .Rows(i).Item("leaders") = mydata.Rows(i).Item("groupName")
                        .Rows(i).Item("members") = mydata.Rows(i).Item("NAME") + ORDate(mydata.Rows(i).Item("IID"))
                        .Rows(i).Item("amount") = PowerNET8.myNumber.Share.Formatter.format_DecimalOnly(getListPersonQuery(mydata.Rows(i).Item("IID")), 2)
                    End With
                Next

                If cboTypeOfPayment.Text <> "Others" Then
                    .addParameterField("lblSubHead", "BY PASTORAL LEADERS - " + cboTypeOfPayment.Text)
                Else
                    .addParameterField("lblSubHead", "BY PASTORAL LEADERS - " + cboTypeOfPayment.Text + " (" + cboOtherSpecify.Text + ")")
                End If

                .addTableField(table)
                .reportPath("Reports\rptContribution_Report_Leaders.rpt")
            ElseIf cboTypeReport.Text = "By Members" Then
                Dim mydata As DataTable = mysql.Query("SELECT IID,concat(surname,', ', firstname,' ',middlename) as 'NAME' from tblp_info " + getListPersonQuery() + " order by surName ")
                table.Rows.Clear()
                For i As Integer = 0 To mydata.Rows.Count - 1
                    With table
                        .Rows.Add()
                        .Rows(i).Item("members") = mydata.Rows(i).Item("NAME") + ORDate(mydata.Rows(i).Item("IID"))
                        .Rows(i).Item("amount") = PowerNET8.myNumber.Share.Formatter.format_DecimalOnly(getListPersonQuery(mydata.Rows(i).Item("IID")), 2)
                    End With
                Next

                If cboTypeOfPayment.Text <> "Others" Then
                    .addParameterField("lblSubHead", "BY MEMBERS - " + cboTypeOfPayment.Text)
                Else
                    .addParameterField("lblSubHead", "BY MEMBERS - " + cboTypeOfPayment.Text + " (" + cboOtherSpecify.Text + ")")
                End If

                .addTableField(table)
                .reportPath("Reports\rptContribution_Report_Members.rpt")
            ElseIf cboTypeReport.Text = "By Summary" Then
                Dim sql As String = "select typeOfPayment, journalEntry,otherSpecify, sum(amount) as 'Amount' FROM   tbl_contribution_record  INNER JOIN tbl_contribution_record_history    ON (tbl_contribution_record.CRID = tbl_contribution_record_history.CRID) where amount>0  " + getDatePeriod() + " group by typeOfPayment,journalentry order by journalEntry desc,typeOfPayment "
                Dim mydata As DataTable = mysql.Query(sql)
                Dim debit As DataTable = createTableSummary("tblDetails")
                Dim credit As DataTable = createTableSummary("tblExpenses")
                Dim tdebit As Decimal = 0
                Dim tcredit As Decimal = 0
                For i As Integer = 0 To mydata.Rows.Count - 1
                    If mydata.Rows(i).Item("journalEntry") = "Debit" Then
                        With debit
                            .Rows.Add()
                            If mydata.Rows(i).Item("typeOfPayment") <> "Others" Then
                                .Rows(.Rows.Count - 1).Item("particulars") = mydata.Rows(i).Item("typeOfPayment")
                            Else
                                .Rows(.Rows.Count - 1).Item("particulars") = mydata.Rows(i).Item("typeOfPayment") + " (" + mydata.Rows(i).Item("otherSpecify") + ")"
                            End If
                            .Rows(.Rows.Count - 1).Item("amount") = mydata.Rows(i).Item("Amount")
                            tdebit += mydata.Rows(i).Item("Amount")
                        End With

                    Else
                        With credit
                            .Rows.Add()
                            If mydata.Rows(i).Item("typeOfPayment") <> "Others" Then
                                .Rows(.Rows.Count - 1).Item("particulars") = mydata.Rows(i).Item("typeOfPayment")
                            Else
                                .Rows(.Rows.Count - 1).Item("particulars") = mydata.Rows(i).Item("typeOfPayment") + " (" + mydata.Rows(i).Item("otherSpecify") + ")"
                            End If
                            .Rows(.Rows.Count - 1).Item("amount") = mydata.Rows(i).Item("Amount")
                            tcredit += mydata.Rows(i).Item("Amount")
                        End With
                    End If
                Next
                .addTableField(debit)
                .addTableField(credit)
                .addParameterField("lblTotalAmount", PowerNET8.myNumber.Share.Formatter.format_DecimalOnly((tdebit - tcredit), 2))
                .addParameterField("lblSubHead", "BY SUMMARY REPORT")
                .reportPath("Reports\rptSummaryReport.rpt")
            ElseIf cboTypeReport.Text = "By OR Members" Then
                table = createORhistory()
                Dim mydata As DataTable = mysql.Query("SELECT IID,ORno,dtPayment, typeofpayment,amount  FROM  tbl_contribution_record  INNER JOIN  tbl_contribution_record_history    ON (tbl_contribution_record.CRID = tbl_contribution_record_history.CRID) where IID=" + IID + " " + getDatePeriod() + " order by dtPayment desc,typeofpayment ")


                With table
                    .Rows.Clear()
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Item("ORNo") = mydata.Rows(i).Item("ORno")
                        .Rows(i).Item("Particulars") = mydata.Rows(i).Item("typeofpayment")
                        Dim dt As Date = mydata.Rows(i).Item("dtPayment")
                        .Rows(i).Item("datePaid") = dt.ToString("MM/dd/yyyy")
                        .Rows(i).Item("Amount") = mydata.Rows(i).Item("amount")
                    Next
                End With
                .addTableField(table)
                .addParameterField("lblMember", txtMembers.Text)

                If chkBGroup.Checked Then
                    .reportPath("Reports\rptORHistoryByGroup.rpt")
                Else
                    .reportPath("Reports\rptORHistory.rpt")
                End If

            End If


            .addParameterField("lblP", getParameterPeriod())

            .launchReport()
        End With

    End Sub

    Private Function createORhistory()
        Dim table As New PowerNET8.myDataTableCreator
        With table
            .new_table("tblDetails")
            .add_columnField("ORNo")
            .add_columnField("Particulars")
            .add_columnField("datePaid")
            .add_columnField("Amount", PowerNET8.myDataTableCreator.FieldType.Decimal_)
            Return .get_table
        End With
    End Function

    Private Function createTableSummary(ByVal value As String)
        Dim table As New PowerNET8.myDataTableCreator
        With table
            .new_table(value)
            .add_columnField("particulars")
            .add_columnField("amount", PowerNET8.myDataTableCreator.FieldType.Decimal_)
            Return .get_table
        End With
    End Function

    Private IID As String = ""

    Private Sub txtMembers_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMembers.MouseClick
        Dim frm As New frmProfileInfoFinder
        With frm
            .action = "use"
            .ShowDialog()
            If .returnValue <> "" Then
                IID = .returnValue
                Dim blnFoundMulti As Boolean = False
                'SINGLE MODE'
                Dim mydata As DataTable = mysql.Query("SELECT concat(surName, ', ' , firstName,' ', middleName) as 'name' from tblp_info where IID=" + .returnValue)
                txtMembers.Text = mydata.Rows(0).Item(0)
            End If
        End With
    End Sub

    Private Sub txtMembers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembers.TextChanged

    End Sub
End Class