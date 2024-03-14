Imports System.Windows.Forms.Cursor
Public Class frmProfilePicker
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private Sub initialize()
        connect(mysql)
        reset()
    End Sub

    Private Sub reset()
        txtStringBox.Text = ""
        cboType.SelectedIndex = 0
        cboOrder.SelectedIndex = 0
        cbofmonth.SelectedIndex = Now.Month - 1
        cbotmonth.SelectedIndex = Now.Month - 1
        txtfyear.Text = Now.Year
        txttyear.Text = Now.Year
    End Sub

    Private Sub frmProfilePicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Function createTable() As DataTable
        Dim mytable As New PowerNET8.myDataTableCreator
        With mytable
            .new_table("tblDetails")
            .add_columnField("name")
            .add_columnField("column")
            Return .get_table
        End With
    End Function

    Private Function getOrder(Optional ByVal overrride As String = "")
        Select Case cboOrder.SelectedIndex
            Case 0
                If overrride = "" Then
                    Return " order by surname, " + cboType.Text
                Else
                    Return " order by surname, " + overrride
                End If
            Case 1
                If overrride = "" Then
                    Return " order by  surname desc, " + cboType.Text + " desc "
                Else
                    Return " order by  surname desc, " + overrride + " desc "
                End If
            Case Else
                Return ""
        End Select
    End Function

    Private Sub getQueryMode(ByRef tbldata As DataTable)
        Dim rawdata As New DataTable
        Select Case cboType.Text
            'THIS IS PRE FILTERED BY STRING
            Case "surName", "firstName", "middleName", "nickname", "resPhone", "cellPhone"
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " LIKE '" + txtStringBox.Text + "%' " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
                'THIS IS FULL FILTERED BY STRING
            Case "bloodType"
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " LIKE '" + txtStringBox.Text + "' " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
            Case "homeAddress"
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " LIKE '%" + txtStringBox.Text + "%' " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
                'THIS IS FILTERED BY BETWEEN TWO DATES RANGE
            Case "birthdate", "dtAccomplished", "whenJoined"
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " BETWEEN '" + txtfyear.Text.ToString + "-" + (cbofmonth.SelectedIndex + 1).ToString + "-1' and '" + txttyear.Text.ToString + "-" + (cbotmonth.SelectedIndex + 1).ToString + "-1' " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        Dim col() As String = rawdata.Rows(i).Item(1).ToString.Split(" ")
                        .Rows(i).Item(1) = col(0)
                    End With
                Next
            Case "status", "gender"
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " LIKE '" + cboSelect.Text + "%' " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
            Case "isActive"
                Dim where As String = " where "
                If cboSelect.Text = "Active" Then
                    where += cboType.Text + " = 1 "
                ElseIf cboSelect.Text = "Inactive" Then
                    where += cboType.Text + " = 0 "
                Else
                    where = ""
                End If
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + ", dueTo from tblp_info " + where + " " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = IIf(rawdata.Rows(i).Item(1).ToString = "True", "YES", "NO - Due to (" + rawdata.Rows(i).Item(2) + ")")
                    End With
                Next
            Case "age"
                'reupdate the age of all members
                If chkreupdate.Checked Then
                    chkreupdate.Checked = False
                    rawdata = mysql.Query("SELECT * FROM tblp_info")
                    For i As Integer = 0 To rawdata.Rows.Count - 1
                        With mysql
                            .setTable("tblp_info")
                            Dim dt As Date = rawdata.Rows(i).Item("birthdate")
                            .addValue(Age(dt), "age")
                            .Update("IID", rawdata.Rows(i).Item("IID").ToString)
                        End With
                    Next
                    MsgBox("Re update the age completed!", MsgBoxStyle.Information)
                End If
                'requery the record
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " >= " + txtfNum.Value.ToString + " and " + cboType.Text + " <= " + txttNum.Value.ToString + " " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
                'THIS IS FOR SUGGEST QUERY
            Case "birthplace", "educAttainment", "employer", "curPLeader", "occupation", "profession", "workPhone", "officeAddress", "lineAddress", "curDistrict", "invitedBy"
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info where " + cboType.Text + " LIKE '%" + txtSuggest.Text + "%' " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
            Case "yrAttended", "yrComWeek", "yrUnderCom", "yrCovenant"
                Dim where As String = " where "
                If optYes.Checked Then
                    where += cboType.Text + " = " + cboYear.Text.ToString
                ElseIf optNo.Checked Then
                    where += cboType.Text + " = 0 or " + cboType.Text + " = 1800 "
                Else
                    where = ""
                End If
                rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboType.Text + " from tblp_info  " + where + " " + getOrder())
                For i As Integer = 0 To rawdata.Rows.Count - 1
                    With tbldata
                        .Rows.Add()
                        .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                        .Rows(i).Item(1) = rawdata.Rows(i).Item(1)
                    End With
                Next
            Case "Parish Organization"
                Dim where As String = " where "
                If optYes.Checked Then
                    where += cboYear.Text + " = 1 "
                ElseIf optNo.Checked Then
                    where += cboYear.Text + " = 0 "
                Else
                    where = ""
                End If
                Select Case cboYear.Text
                    Case "OtherPO"
                        rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboYear.Text + ", txtOtherPO from tblp_info  " + where + " " + getOrder(cboYear.Text))
                        For i As Integer = 0 To rawdata.Rows.Count - 1
                            With tbldata
                                .Rows.Add()
                                .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                                .Rows(i).Item(1) = IIf(rawdata.Rows(i).Item(1).ToString = "True", "YES - " + rawdata.Rows(i).Item(2), "NO - " + rawdata.Rows(i).Item(2))
                            End With
                        Next
                    Case Else
                        rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboYear.Text + " from tblp_info  " + where + " " + getOrder(cboYear.Text))
                        For i As Integer = 0 To rawdata.Rows.Count - 1
                            With tbldata
                                .Rows.Add()
                                .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                                .Rows(i).Item(1) = IIf(rawdata.Rows(i).Item(1).ToString = "True", "YES", "NO")
                            End With
                        Next
                End Select
            Case "Services and Ministries"
                Dim where As String = " where "
                If optYes.Checked Then
                    where += cboYear.Text + " = 1 "
                ElseIf optNo.Checked Then
                    where += cboYear.Text + " = 0 "
                Else
                    where = ""
                End If
                Select Case cboYear.Text
                    Case "OtherC"
                        rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboYear.Text + ", txtOtherC from tblp_info  " + where + " " + getOrder(cboYear.Text))
                        For i As Integer = 0 To rawdata.Rows.Count - 1
                            With tbldata
                                .Rows.Add()
                                .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                                .Rows(i).Item(1) = IIf(rawdata.Rows(i).Item(1).ToString = "True", "YES - " + rawdata.Rows(i).Item(2), "NO - " + rawdata.Rows(i).Item(2))
                            End With
                        Next
                    Case Else
                        rawdata = mysql.Query("SELECT concat(surName,', ',firstName,' ', middleName) as 'fullname', " + cboYear.Text + " from tblp_info  " + where + " " + getOrder(cboYear.Text))
                        For i As Integer = 0 To rawdata.Rows.Count - 1
                            With tbldata
                                .Rows.Add()
                                .Rows(i).Item(0) = rawdata.Rows(i).Item(0)
                                .Rows(i).Item(1) = IIf(rawdata.Rows(i).Item(1).ToString = "True", "YES", "NO")
                            End With
                        Next
                End Select
        End Select
    End Sub

    Public Shared Function Age(ByVal DOfB As Date) As String
        Dim myAge = Now.Year - DOfB.Year
        If DOfB.Month = Now.Month Then
            If DOfB.Day > Now.Day Then
                myAge -= 1
            End If
        ElseIf DOfB.Month > Now.Month Then
            myAge -= 1
        End If
        Return myAge
    End Function

    Private Sub getheader(ByRef cr As PowerNET8.myDocument.Init.CrystalReportViewer)
        With cr
            Select Case cboType.Text
                Case "surName", "firstName", "middleName", "nickname", "curPLeader", "isActive", "resPhone", "cellPhone", "homeAddress", "status", "birthplace", "gender", "bloodType", "educAttainment", "employer", "occupation", "profession", "workPhone", "officeAddress", "lineAddress", "curDistrict", "invitedBy"
                    .addParameterField("lblHeader", "Filtered by: " + LCase(cboType.Text))
                    .addParameterField("lblCaption", "")
                Case "birthdate", "dtAccomplished", "whenJoined"
                    .addParameterField("lblHeader", "Filtered by: " + LCase(cboType.Text))
                    .addParameterField("lblCaption", cbofmonth.Text + ". " + txtfyear.Text + " - " + cbotmonth.Text + ". " + txttyear.Text)
                Case "age"
                    .addParameterField("lblHeader", "Filtered by: " + LCase(cboType.Text))
                    .addParameterField("lblCaption", " From the age of " + txtfNum.Value.ToString + " to " + txttNum.Value.ToString)
                Case "yrAttended", "yrComWeek", "yrUnderCom", "yrCovenant"
                    .addParameterField("lblHeader", "Filtered by: " + LCase(cboType.Text))
                    If optYes.Checked Then
                        .addParameterField("lblCaption", " For the year of " + cboYear.Text.ToString)
                    ElseIf optYes.Checked Then
                        .addParameterField("lblCaption", " No participation")
                    Else
                        .addParameterField("lblCaption", " All")
                    End If
                Case "Parish Organization"
                    .addParameterField("lblHeader", "Parish Organization - " + LCase(cboYear.Text))
                    If optYes.Checked Then
                        .addParameterField("lblCaption", "Filtered by: " + LCase(cboYear.Text))
                    ElseIf optNo.Checked Then
                        .addParameterField("lblCaption", "Filtered by: " + LCase(cboYear.Text))
                    Else
                        .addParameterField("lblCaption", "Filtered by: " + LCase(cboYear.Text))
                    End If
                Case "Services and Ministries"
                    .addParameterField("lblHeader", "Services and Ministries")
                    If optYes.Checked Then
                        .addParameterField("lblCaption", "Filtered by: " + LCase(cboYear.Text))
                    ElseIf optNo.Checked Then
                        .addParameterField("lblCaption", "Filtered by: " + LCase(cboYear.Text))
                    Else
                        .addParameterField("lblCaption", "Filtered by: " + LCase(cboYear.Text))
                    End If
            End Select
        End With
    End Sub

    Private Function getColumnName(ByVal value As String)
        Select Case value
            Case "surName"
                Return "SURNAME"
            Case "firstName"
                Return "FIRSTNAME"
            Case "middleName"
                Return "MIDDLENAME"
            Case "nickname"
                Return "NICKNAME"
            Case "homeAddress"
                Return "HOME ADDRESS"
            Case "resPhone"
                Return "RESIDENTIAL PHONE"
            Case "cellPhone"
                Return "MOBILE NUMBER"
            Case "birthdate"
                Return "BIRTHDATE"
            Case "educAttainment"
                Return "EDUCATIONAL ATTAINMENT"
            Case "officeAddress"
                Return "OFFICE ADDRESS"
            Case "lineAddress"
                Return "LINE ADDRESS"
            Case "curDistrict"
                Return "CURRENT DISTRICT"
            Case "yrAttended"
                Return "YEAR ATTENDED"
            Case "yrComWeek"
                Return "YEAR ATTENDED COMMUNITY WEEKEND"
            Case "yrUnderCom"
                Return "YEAR UNDERWAY COMMITMENT"
            Case "yrCovenant"
                Return "YEAR COVENANTED"
            Case "curPLeader"
                Return "CURRENT PASTORAL LEADER"
            Case "dtAccomplished"
                Return "DATE ACCOMPLISHED"
            Case "whenJoined"
                Return "WHEN JOINED"
            Case "isActive"
                Return "ACTIVE/INACTIVE MEMBER"
            Case "Parish Organization"
                Return "Parish Organization - " + UCase(cboYear.Text)
            Case "Services and Ministries"
                Return "Services and Ministries - " + UCase(cboYear.Text)
            Case Else
                Return UCase(value)
        End Select
    End Function

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cr As New PowerNET8.myDocument.Init.CrystalReportViewer
        Dim tbldetails As DataTable = createTable()
        getQueryMode(tbldetails)
        With cr
            getheader(cr)
            .addTableField(tbldetails)
            .title = "SUMMARY REPORT - " + getColumnName((cboType.Text))
            .addParameterField("lblColumn", getColumnName((cboType.Text)))
            .reportPath("Reports\rptProfilePicker.rpt")
            .launchReport()
        End With
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        txtStringBox.Focus()
        txtStringBox.Text = ""
        cbofmonth.SelectedIndex = Now.Month - 1
        cbotmonth.SelectedIndex = Now.Month - 1
        txtfyear.Text = Now.Year
        txttyear.Text = Now.Year

          Select cboType.Text
            Case "surName", "firstName", "middleName", "nickname", "resPhone", "cellPhone", "bloodType"
                gbString.Visible = True
                gbDate.Visible = False
                gbSelect.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = False
            Case "birthdate", "dtAccomplished", "whenJoined"
                gbString.Visible = False
                gbDate.Visible = True
                gbSelect.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = False
            Case "status"
                gbSelect.Visible = True
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = False
                With cboSelect.Items
                    .Clear()
                    .Add("Single")
                    .Add("Married")
                    .Add("Separated")
                    .Add("Widowed")
                End With
                cboSelect.SelectedIndex = 0
            Case "isActive"
                gbSelect.Visible = True
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = False
                With cboSelect.Items
                    .Clear()
                    .Add("Active")
                    .Add("Inactive")
                    .Add("-All-")
                End With
                cboSelect.SelectedIndex = 0
            Case "gender"
                gbSelect.Visible = True
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = False
                With cboSelect.Items
                    .Clear()
                    .Add("Male")
                    .Add("Female")
                End With
                cboSelect.SelectedIndex = 0
            Case "age"
                gbSelect.Visible = False
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = True
                gbSuggest.Visible = False
                gbYears.Visible = False
            Case "birthplace", "employer", "occupation", "profession", "workPhone", "officeAddress", "lineAddress", "curDistrict", "invitedBy", "curPLeader"
                gbSelect.Visible = False
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = True
                gbYears.Visible = False
                Dim mydata As DataTable = mysql.Query("SELECT distinct " + cboType.Text + " from tblp_info")
                With txtSuggest
                    .AutoCompleteCustomSource.Clear()
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0))
                    Next
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                    .Text = ""
                    .Focus()
                End With
            Case "educAttainment"
                gbSelect.Visible = False
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = True
                gbYears.Visible = False
                Dim mydata As DataTable = mysql.Query("SELECT distinct educAttainment from tblp_info")
                With txtSuggest
                    .AutoCompleteCustomSource.Clear()
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0))
                    Next
                    mydata = mysql.Query("SELECT distinct otherSpecify from tblp_info")
                    For i As Integer = 0 To mydata.Rows.Count - 1
                        .AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0))
                    Next
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                    .Text = ""
                    .Focus()
                End With
            Case "yrAttended", "yrComWeek", "yrUnderCom", "yrCovenant"
                gbSelect.Visible = False
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = True

                optYes.Text = "Year Attended"
                optNo.Text = "None"

                optYes.Checked = True
                Dim counter As Integer = Now.Year
                With cboYear.Items
                    .Clear()
                    Do
                        .Add(counter.ToString)
                        counter -= 1
                    Loop Until counter <= 1800
                    cboYear.SelectedIndex = 0
                End With
            Case "Parish Organization"
                gbSelect.Visible = False
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = True
                optYes.Checked = True
                optYes.Text = "Yes"
                optNo.Text = "No"
                optYes.Checked = True
                With cboYear.Items
                    .Clear()
                    .Add("KC")
                    .Add("CWL")
                    .Add("Charismatic")
                    .Add("Apostolado")
                    .Add("Eucharistic")
                    .Add("SBA")
                    .Add("OtherPO")
                    cboYear.SelectedIndex = 0
                End With
            Case "Services and Ministries"
                gbSelect.Visible = False
                gbString.Visible = False
                gbDate.Visible = False
                gbNumber.Visible = False
                gbSuggest.Visible = False
                gbYears.Visible = True
                optYes.Checked = True
                optYes.Text = "Yes"
                optNo.Text = "No"
                optYes.Checked = True
                With cboYear.Items
                    .Clear()
                    .Add("PL")
                    .Add("DistrictHead")
                    .Add("Handmaid")
                    .Add("BSD")
                    .Add("MusicMinistry")
                    .Add("YA")
                    .Add("ChildrenMin")
                    .Add("Intercessory")
                    .Add("CYA")
                    .Add("Lampstand")
                    .Add("Buhing")
                    .Add("Lingkod")
                    .Add("Bible")
                    .Add("OtherC")
                    cboYear.SelectedIndex = 0
                End With
        End Select

    End Sub

    Private Sub txtfyear_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtfyear.MouseClick, txttyear.MouseClick
        txtfyear.SelectAll()
    End Sub

    Private Sub txtSuggest_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSuggest.MouseClick
        txtSuggest.SelectAll()
    End Sub

End Class