Imports System.IO
Public Class frmProfile
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public IID As String = "0"
    Private colObject As New Collection
    Public action As String = ""

    Private Sub initialize()
        connect(mysql)
        loadObjects()
    End Sub

    Private Sub checkFoundation(ByRef dgv As DataGridView, ByVal index As Integer, ByVal CID As Integer, ByVal total As Integer)
        Dim mydata As DataTable = mysql.Query("SELECT tbl_lstcourses.CID,tbl_lstcourses.NoOrder,tbl_lstcourses.Type,tbl_lstcourses.Name,tbl_lstcourses_unit.Code, tbl_lstcourses_unit.Type, tbl_lstcourses_unit.Name,IID FROM  tbl_lstcourses  INNER JOIN tbl_lstcourses_unit   ON (tbl_lstcourses.CID = tbl_lstcourses_unit.CID)  INNER JOIN tblp_info_courses   ON (tblp_info_courses.UID = tbl_lstcourses_unit.UID) WHERE tbl_lstcourses.CID=" + CID.ToString + " and tblp_info_courses.IID=" + IID.ToString)
        dgv.Rows(index).Cells(5).Value = mydata.Rows.Count.ToString + "/" + total.ToString
    End Sub

    Private Sub reloadCourses()

        Dim mydata As DataTable = mysql.Query("SELECT COUNT(tbl_lstcourses.CID) as 'no',tbl_lstcourses.tag,tbl_lstcourses.CID,tbl_lstcourses.NoOrder,tbl_lstcourses.Type,tbl_lstcourses.Name,tbl_lstcourses_unit.Code, tbl_lstcourses_unit.Type, tbl_lstcourses_unit.Name FROM  tbl_lstcourses   INNER JOIN abpis.tbl_lstcourses_unit    ON (tbl_lstcourses.CID = tbl_lstcourses_unit.CID) GROUP BY tbl_lstcourses.CID Order by tbl_lstcourses.NoOrder ")
        dgvC.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvC
                .Rows.Add()
                With .Rows(i)
                    .Cells(0).Value = mydata.Rows(i).Item("CID")
                    .Cells(1).Value = mydata.Rows(i).Item("NoOrder")
                    .Cells(2).Value = mydata.Rows(i).Item("Type")
                    .Cells(3).Value = mydata.Rows(i).Item("Name")
                    '.Cells(5).Value = "/" + mydata.Rows(i).Item(0).ToString
                    checkFoundation(dgvC, i, mydata.Rows(i).Item("CID"), mydata.Rows(i).Item(0).ToString)
                    .Cells(6).Value = mydata.Rows(i).Item("tag")
                End With
            End With
        Next


    End Sub


    Private Sub frmProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        Select Case action
            Case "add"
                clsObjects.Clear_All(colObject)
                toolstripNavigation(ToolAction.add)
            Case "edit"
                clsObjects.Clear_All(colObject)
                Recordload()
                toolstripNavigation(ToolAction.edit)
            Case "view"
                clsObjects.Clear_All(colObject)
                Recordload()
                clsObjects.Lock_Mode_All(colObject, clsObjects.Lock.Yes)
                toolstripNavigation(ToolAction.view)

                If userLevel <> "Administrator" Then
                    tsEdit.Enabled = False
                    tsAdd.Enabled = False
                End If

        End Select


    End Sub


    Private Sub Recordload()
        Dim mydata As DataTable = mysql.Query("SELECT * from tblp_info where IID=" + IID)
        If mydata.Rows.Count > 0 Then
            With mydata.Rows(0)
                'MEMBERS
                If Not IsDBNull(.Item("allOthers")) Then txtAllOthers.Text = .Item("allOthers")
                txtSurname.Text_ = .Item("surName")
                txtFName.Text_ = .Item("firstName")
                txtMName.Text_ = .Item("middleName")
                If Not IsDBNull(.Item("homeAddress")) Then txtHomeAddress.Text = .Item("homeAddress")
                txtResPhone.Text_ = .Item("resPhone")
                txtCellPhone.Text_ = .Item("cellPhone")
                udtBirthdate.Value = .Item("birthdate")
                cboStatus.Text = .Item("status")
                txtAge.Text_ = Age(udtBirthdate.Value)
                txtBirthPlace.Text_ = .Item("birthplace")
                txtNickName.Text_ = .Item("nickName")
                txtSNickName.Text_ = .Item("sNickName")
                cboSex.Text = .Item("gender")
                txtBloodType.Text_ = .Item("bloodType")
                cboEducationalAttainment.Text = .Item("educAttainment")
                txtEmployer.Text_ = .Item("employer")
                txtOccupation.Text_ = .Item("occupation")
                txtWorkPhone.Text_ = .Item("workPhone")
                txtOfficeAddress.Text_ = .Item("officeAddress")
                txtLineBusiness.Text_ = .Item("lineAddress")
                'SPOUSES
                txtSSurname.Text_ = .Item("sSurName")
                txtSFName.Text_ = .Item("sFirstName")
                txtSMiddleName.Text_ = .Item("sMiddleName")
                txtSCellPhone.Text_ = .Item("sCellPhone")
                udtSBirthDate.Value = .Item("sBirthDate")
                txtSAge.Text_ = Age(udtSBirthDate.Value)
                txtSBirthDate.Text_ = .Item("SbirthPlace")
                txtSBloodType.Text_ = .Item("SbloodType")
                cboSEducAttain.Text = .Item("SeducAttainment")
                txtSEmployer.Text_ = .Item("Semployer")
                txtSOccupation.Text_ = .Item("Soccupation")
                txtSWorkPhone.Text_ = .Item("SworkPhone")
                txtSOfficeAddresss.Text_ = .Item("SofficeAddress")
                txtSLineBusiness.Text_ = .Item("SlineAddress")
                'COMMUNITY
                txtCurDistrict.Text_ = .Item("curDistrict")
                txtyrAttended.Text_ = .Item("yrAttended")
                txtYrComWeek.Text_ = .Item("yrComWeek")
                txtInvitedBy.Text_ = .Item("invitedBy")
                ''
                chkKC.Checked = IIf(.Item("KC"), 1, 0)
                chkCWL.Checked = IIf(.Item("CWL"), 1, 0)
                chkCharismatic.Checked = IIf(.Item("Charismatic"), 1, 0)
                chkApostolado.Checked = IIf(.Item("Apostolado"), 1, 0)
                chkEucharistic.Checked = IIf(.Item("Eucharistic"), 1, 0)
                chkSBA.Checked = IIf(.Item("SBA"), 1, 0)
                chkOtherPO.Checked = IIf(.Item("OtherPO"), 1, 0)
                txtOtherPO.Text = .Item("txtOtherPO")
                ''
                txtcurrPLeader.Text_ = .Item("curPLeader")
                txtYrUnderCom.Text_ = .Item("yrUnderCom")
                txtYrCovenant.Text_ = .Item("yrCovenant")
                ''
                chkPL.Checked = IIf(.Item("PL"), 1, 0)
                chkDistrictHead.Checked = IIf(.Item("DistrictHead"), 1, 0)
                chkHandmaid.Checked = IIf(.Item("Handmaid"), 1, 0)
                chkBSD.Checked = IIf(.Item("BSD"), 1, 0)
                chkMusicMinistry.Checked = IIf(.Item("MusicMinistry"), 1, 0)
                chkYA.Checked = IIf(.Item("YA"), 1, 0)
                chkChildrenMin.Checked = IIf(.Item("ChildrenMin"), 1, 0)
                chkIntercessory.Checked = IIf(.Item("Intercessory"), 1, 0)
                chkCYA.Checked = IIf(.Item("CYA"), 1, 0)
                chkLampstand.Checked = IIf(.Item("Lampstand"), 1, 0)
                chkBuhing.Checked = IIf(.Item("Buhing"), 1, 0)
                chkLingkod.Checked = IIf(.Item("Lingkod"), 1, 0)
                chkBible.Checked = IIf(.Item("Bible"), 1, 0)
                chkOtherC.Checked = IIf(.Item("OtherC"), 1, 0)
                txtOtherC.Text = .Item("txtOtherC")

                udtDateAccomplished.Value = .Item("dtAccomplished")
                utdWhenJoined.Value = .Item("whenJoined")
                chkActiveStatus.Checked = IIf(.Item("isActive"), 1, 0)
            End With

            '''''''''''''''''''''''
            'Wedding Anniversary'''
            mydata = mysql.Query("SELECT * FROM tblp_info_wedding_anniversary where IID=" + IID)
            dgvWeddingAnn.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvWeddingAnn.Rows.Add()
                dgvWeddingAnn.Rows(i).Cells(0).Value = mydata.Rows(i).Item("weddingPlace")
                dgvWeddingAnn.Rows(i).Cells(1).Value = mydata.Rows(i).Item("weddingDt")
            Next
            '''''''''''''''''''''''
            'Name of Children''''''
            mydata = mysql.Query("SELECT * FROM tblp_info_list_children where IID=" + IID)
            dgvNameChildren.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvNameChildren.Rows.Add()
                dgvNameChildren.Rows(i).Cells(0).Value = mydata.Rows(i).Item("NameofChildren")
                dgvNameChildren.Rows(i).Cells(1).Value = mydata.Rows(i).Item("birthdate")
                'dgvNameChildren.Rows(i).Cells(2).Value = mydata.Rows(i).Item("age")

                If IsDate(dgvNameChildren.Rows(i).Cells(1).Value) Then
                    Dim dt As Date = dgvNameChildren.Rows(i).Cells(1).Value
                    dgvNameChildren.Rows(i).Cells(2).Value = Now.Year - dt.Year
                End If

            Next
            '''''''''''''''''''''''
            'Hobbies'''''''''''''''
            mydata = mysql.Query("SELECT * FROM tblp_info_hobbies where IID=" + IID)
            dgvHobbies.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvHobbies.Rows.Add()
                dgvHobbies.Rows(i).Cells(0).Value = mydata.Rows(i).Item("Hobbies")
            Next
            '''''''''''''''''''''''
            'dgvTalents'''''''''''''''
            mydata = mysql.Query("SELECT * FROM tblp_info_talents where IID=" + IID)
            dgvTalents.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvTalents.Rows.Add()
                dgvTalents.Rows(i).Cells(0).Value = mydata.Rows(i).Item("Talents")
            Next
            '''''''''''''''''''''''
            'Civi Organization'''''
            mydata = mysql.Query("SELECT * FROM tblp_info_civic_org where IID=" + IID)
            dgvCivicOrg.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvCivicOrg.Rows.Add()
                dgvCivicOrg.Rows(i).Cells(0).Value = mydata.Rows(i).Item("Name")
            Next
            '''''''''''''''''''''''
            'Civi Organization'''''
            mydata = mysql.Query("SELECT * FROM tblp_info_relatives_community where IID=" + IID)
            dgvRelativesCommunity.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvRelativesCommunity.Rows.Add()
                dgvRelativesCommunity.Rows(i).Cells(0).Value = mydata.Rows(i).Item("Name")
                dgvRelativesCommunity.Rows(i).Cells(1).Value = mydata.Rows(i).Item("Relation")
            Next
            '''''''''''''''''''''''
            'Children Outreach'''''
            mydata = mysql.Query("SELECT * FROM tblp_info_children_outreach where IID=" + IID)
            dgvChildrenOutreach.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvChildrenOutreach.Rows.Add()
                dgvChildrenOutreach.Rows(i).Cells(0).Value = mydata.Rows(i).Item("Name")
            Next
            '''''''''''''''''''''''
            'Previous PLs'''''
            mydata = mysql.Query("SELECT * FROM tblp_info_prevpl where IID=" + IID)
            dgvPreviousPL.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvPreviousPL.Rows.Add()
                dgvPreviousPL.Rows(i).Cells(0).Value = mydata.Rows(i).Item("Name")
            Next
            '''''''''''''''''''''''
            'Previous Communities'''''
            mydata = mysql.Query("SELECT * FROM tblp_info_what_service_add where IID=" + IID)
            dgvServiceCommunity.Rows.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                dgvServiceCommunity.Rows.Add()
                dgvServiceCommunity.Rows(i).Cells(0).Value = mydata.Rows(i).Item("ServiceName")
            Next
            '''''''''''''''''''''''


            mydata = mysql.Query("SELECT * from tblp_info_photo where IID=" + IID)
            If mydata.Rows.Count > 0 Then
                Dim loc As String = Application.StartupPath + "\"
                If Not IsDBNull(mydata.Rows(0).Item(1)) Then
                    If File.Exists(loc + "\sample.jpg") Then File.Delete(loc + "\sample.jpg")
                    mysql.write_BLOBFIle(loc, "sample.jpg", mydata.Rows(0).Item(1))
                    pcPicture.ImageLocation = loc + "\sample.jpg"
                    pcPicture.Tag = "custom"
                Else
                    pcPicture.Image = My.Resources.profile_icon1
                    pcPicture.Tag = ""
                End If
                If Not IsDBNull(mydata.Rows(0).Item(2)) Then
                    If File.Exists(loc + "\sample2.jpg") Then File.Delete(loc + "\sample2.jpg")
                    mysql.write_BLOBFIle(loc, "sample2.jpg", mydata.Rows(0).Item(2))
                    pcPicture2.ImageLocation = loc + "\sample2.jpg"
                    pcPicture2.Tag = "custom"
                Else
                    pcPicture2.Image = My.Resources.profile_icon1
                    pcPicture2.Tag = ""
                End If
            Else
                pcPicture.Image = My.Resources.profile_icon1
                pcPicture.Tag = ""
                pcPicture2.Image = My.Resources.profile_icon1
                pcPicture2.Tag = ""
            End If
            reloadCourses()
        End If
    End Sub

    Private Sub recordSave()
        If txtSurname.Text_ <> "" And txtFName.Text_ <> "" And Not udtBirthdate.Value Is Nothing And cboStatus.SelectedIndex <> -1 And cboSex.SelectedIndex <> -1 Then
            With mysql
                .setTable("tblp_info")
                'MEMBERS
                .addValue(txtAllOthers.Text, "allOthers")
                .addValue(txtSurname.Text_, "surName")
                .addValue(txtFName.Text_, "firstName")
                .addValue(txtMName.Text_, "middleName")
                .addValue(txtHomeAddress.Text, "homeAddress")
                .addValue(txtResPhone.Text_, "resPhone")
                .addValue(txtCellPhone.Text_, "cellPhone")
                .addValue(udtBirthdate.Value, "birthdate")
                .addValue(cboStatus.Text, "status")
                If IsNumeric(txtAge.Text_) Then .addValue(txtAge.Text_, "age")
                .addValue(txtBirthPlace.Text_, "birthplace")
                .addValue(cboSex.Text, "gender")
                .addValue(txtBloodType.Text_, "bloodType")
                .addValue(cboEducationalAttainment.Text, "educAttainment")
                .addValue(txtEmployer.Text_, "employer")
                .addValue(txtOccupation.Text_, "occupation")
                .addValue(txtWorkPhone.Text_, "workPhone")
                .addValue(txtOfficeAddress.Text_, "officeAddress")
                .addValue(txtLineBusiness.Text_, "lineAddress")
                .addValue(txtNickName.Text_, "nickname")
                .addValue(txtSNickName.Text_, "sNickName")
                'SPOUSES
                .addValue(txtSSurname.Text_, "sSurName")
                .addValue(txtSFName.Text_, "sFirstName")
                .addValue(txtSMiddleName.Text_, "sMiddleName")
                .addValue(txtSCellPhone.Text_, "sCellPhone")
                .addValue(udtSBirthDate.Value, "sBirthDate")
                If IsNumeric(txtSAge.Text_) Then .addValue(txtSAge.Text_, "Sage")
                .addValue(txtSBirthDate.Text_, "SbirthPlace")
                .addValue(txtSBloodType.Text_, "SbloodType")
                .addValue(cboSEducAttain.Text, "SeducAttainment")
                .addValue(txtSEmployer.Text_, "Semployer")
                .addValue(txtSOccupation.Text_, "Soccupation")
                .addValue(txtSWorkPhone.Text_, "SworkPhone")
                .addValue(txtSOfficeAddresss.Text_, "SofficeAddress")
                .addValue(txtSLineBusiness.Text_, "SlineAddress")
                'COMMUNITY
                .addValue(txtCurDistrict.Text_, "curDistrict")
                If IsNumeric(txtyrAttended.Text_) Then .addValue(txtyrAttended.Text_, "yrAttended")
                If IsNumeric(txtYrComWeek.Text_) Then .addValue(txtYrComWeek.Text_, "yrComWeek")
                .addValue(txtInvitedBy.Text_, "invitedBy")
                ''
                .addValue(IIf(chkKC.Checked, 1, 0), "KC")
                .addValue(IIf(chkCWL.Checked, 1, 0), "CWL")
                .addValue(IIf(chkCharismatic.Checked, 1, 0), "Charismatic")
                .addValue(IIf(chkApostolado.Checked, 1, 0), "Apostolado")
                .addValue(IIf(chkEucharistic.Checked, 1, 0), "Eucharistic")
                .addValue(IIf(chkSBA.Checked, 1, 0), "SBA")
                .addValue(IIf(chkOtherPO.Checked, 1, 0), "OtherPO")
                .addValue(txtOtherPO.Text, "txtOtherPO")
                ''
                .addValue(txtcurrPLeader.Text_, "curPLeader")
                If IsNumeric(txtYrUnderCom.Text_) Then .addValue(txtYrUnderCom.Text_, "yrUnderCom")
                If IsNumeric(txtYrCovenant.Text_) Then .addValue(txtYrCovenant.Text_, "yrCovenant")
                ''
                .addValue(IIf(chkPL.Checked, 1, 0), "PL")
                .addValue(IIf(chkDistrictHead.Checked, 1, 0), "DistrictHead")
                .addValue(IIf(chkHandmaid.Checked, 1, 0), "Handmaid")
                .addValue(IIf(chkBSD.Checked, 1, 0), "BSD")
                .addValue(IIf(chkMusicMinistry.Checked, 1, 0), "MusicMinistry")
                .addValue(IIf(chkYA.Checked, 1, 0), "YA")
                .addValue(IIf(chkChildrenMin.Checked, 1, 0), "ChildrenMin")
                .addValue(IIf(chkIntercessory.Checked, 1, 0), "Intercessory")
                .addValue(IIf(chkCYA.Checked, 1, 0), "CYA")
                .addValue(IIf(chkLampstand.Checked, 1, 0), "Lampstand")
                .addValue(IIf(chkBuhing.Checked, 1, 0), "Buhing")
                .addValue(IIf(chkLingkod.Checked, 1, 0), "Lingkod")
                .addValue(IIf(chkBible.Checked, 1, 0), "Bible")
                .addValue(IIf(chkOtherC.Checked, 1, 0), "OtherC")
                .addValue(txtOtherC.Text, "txtOtherC")
                .addValue(udtDateAccomplished.Value, "dtAccomplished")

                If IsDate(utdWhenJoined.Value) Then
                    .addValue(utdWhenJoined.Value, "whenJoined")
                End If

                .addValue(IIf(chkActiveStatus.Checked, 1, 0), "isActive")
                If IID = "0" Then
                    IID = .nextID("IID")
                    .addValue(IID, "IID")
                    .Insert()

                Else
                    .Update("IID", IID)

                End If
            End With

            '''''''''''''''''''''''
            'Wedding Anniversary'''
            mysql.Query("DELETE FROM tblp_info_wedding_anniversary where IID=" + IID)
            For i As Integer = 0 To dgvWeddingAnn.RowCount - 2
                If IsDate(dgvWeddingAnn.Rows(i).Cells(1).Value) Then
                    With mysql
                        .setTable("tblp_info_wedding_anniversary")
                        .addValue(IID, "IID")
                        .addValue(dgvWeddingAnn.Rows(i).Cells(0).Value, "weddingPlace")
                        .addValue(CDate(dgvWeddingAnn.Rows(i).Cells(1).Value), "weddingDt")
                        .Insert()
                    End With
                End If
            Next
            '''''''''''''''''''''''
            'Name of Children''''''
            mysql.Query("DELETE FROM tblp_info_list_children where IID=" + IID)
            For i As Integer = 0 To dgvNameChildren.RowCount - 2
                With mysql
                    If IsDate(dgvNameChildren.Rows(i).Cells(1).Value) Then
                        .setTable("tblp_info_list_children")
                        .addValue(IID, "IID")
                        .addValue(dgvNameChildren.Rows(i).Cells(0).Value, "NameofChildren")
                        .addValue(CDate(dgvNameChildren.Rows(i).Cells(1).Value), "birthdate")
                        .addValue(dgvNameChildren.Rows(i).Cells(2).Value, "age")
                        .Insert()
                    End If
                End With
            Next
            '''''''''''''''''''''''
            'Hobbies'''''''''''''''
            mysql.Query("DELETE FROM tblp_info_hobbies where IID=" + IID)
            For i As Integer = 0 To dgvHobbies.RowCount - 2
                With mysql
                    .setTable("tblp_info_hobbies")
                    .addValue(IID, "IID")
                    .addValue(dgvHobbies.Rows(i).Cells(0).Value, "Hobbies")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''
            'dgvTalents'''''''''''''''
            mysql.Query("DELETE FROM tblp_info_talents where IID=" + IID)
            For i As Integer = 0 To dgvTalents.RowCount - 2
                With mysql
                    .setTable("tblp_info_talents")
                    .addValue(IID, "IID")
                    .addValue(dgvTalents.Rows(i).Cells(0).Value, "Talents")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''
            'Civi Organization'''''
            mysql.Query("DELETE FROM tblp_info_civic_org where IID=" + IID)
            For i As Integer = 0 To dgvCivicOrg.RowCount - 2
                With mysql
                    .setTable("tblp_info_civic_org")
                    .addValue(IID, "IID")
                    .addValue(dgvCivicOrg.Rows(i).Cells(0).Value, "Name")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''
            'Civi Organization'''''
            mysql.Query("DELETE FROM tblp_info_relatives_community where IID=" + IID)
            For i As Integer = 0 To dgvRelativesCommunity.RowCount - 2
                With mysql
                    .setTable("tblp_info_relatives_community")
                    .addValue(IID, "IID")
                    .addValue(dgvRelativesCommunity.Rows(i).Cells(0).Value, "Name")
                    .addValue(dgvRelativesCommunity.Rows(i).Cells(1).Value, "Relation")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''
            'Children Outreach'''''
            mysql.Query("DELETE FROM tblp_info_children_outreach where IID=" + IID)
            For i As Integer = 0 To dgvChildrenOutreach.RowCount - 2
                With mysql
                    .setTable("tblp_info_children_outreach")
                    .addValue(IID, "IID")
                    .addValue(dgvChildrenOutreach.Rows(i).Cells(0).Value, "Name")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''
            'Previous PLs'''''
            mysql.Query("DELETE FROM tblp_info_prevpl where IID=" + IID)
            For i As Integer = 0 To dgvPreviousPL.RowCount - 2
                With mysql
                    .setTable("tblp_info_prevpl")
                    .addValue(IID, "IID")
                    .addValue(dgvPreviousPL.Rows(i).Cells(0).Value, "Name")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''
            'Previous Communities'''''
            mysql.Query("DELETE FROM tblp_info_what_service_add where IID=" + IID)
            For i As Integer = 0 To dgvServiceCommunity.RowCount - 2
                With mysql
                    .setTable("tblp_info_what_service_add")
                    .addValue(IID, "IID")
                    .addValue(dgvServiceCommunity.Rows(i).Cells(0).Value, "ServiceName")
                    .Insert()
                End With
            Next
            '''''''''''''''''''''''

            If pcPicture.Tag <> "" Then
                mysql.Query("DELETE FROM tblp_info_photo where IID=" + IID)
                With mysql
                    .setTable("tblp_info_photo")
                    .addValue(IID, "IID")
                    .addValue(pcPicture.Image, "photoImage")
                    If pcPicture2.Tag <> "" Then
                        .addValue(pcPicture2.Image, "photoImage2")
                    End If
                    .Insert()
                End With
            End If

            MsgBox("Record has been saved successfully!")
        Else
            MsgBox("Please input the required fields.", MsgBoxStyle.Information, "Unable to Save")
        End If
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsCancel.Click, tsEdit.Click, tsSave.Click
        With CType(sender, ToolStripButton)
            Select Case .Text
                Case "Add"
                    clsObjects.Clear_All(colObject)
                    toolstripNavigation(ToolAction.add)
                    pcPicture.Image = My.Resources.profile_icon1
                    pcPicture.Tag = ""
                    pcPicture2.Image = My.Resources.profile_icon1
                    pcPicture2.Tag = ""
                    clsObjects.Lock_Mode_All(colObject, clsObjects.Lock.No)
                    utbMain.Tabs(4).Visible = False
                    cmd4Next.Enabled = False
                Case "Save"
                    recordSave()
                    toolstripNavigation(ToolAction.save)
                    clsObjects.Lock_Mode_All(colObject, clsObjects.Lock.Yes)
                Case "Edit"
                    toolstripNavigation(ToolAction.edit)
                    clsObjects.Lock_Mode_All(colObject, clsObjects.Lock.No)
                Case "Cancel"
                    toolstripNavigation(ToolAction.cancel)
                    If action = "add" Then Me.Close()
                    clsObjects.Lock_Mode_All(colObject, clsObjects.Lock.Yes)
                    utbMain.Tabs(4).Visible = True
                    cmd4Next.Enabled = True
                Case "Print"
            End Select
        End With
    End Sub


#Region "Reserved Codes"

    Private Sub loadObjects()
        With colObject
            .Clear()
            .Add(txtSurname)
            .Add(txtNickName)
            .Add(txtSNickName)
            .Add(txtFName)
            .Add(txtMName)
            .Add(txtHomeAddress)
            .Add(txtResPhone)
            .Add(txtCellPhone)
            .Add(udtBirthdate)
            .Add(cboStatus)
            .Add(txtAge)
            .Add(txtBirthPlace)
            .Add(cboSex)
            .Add(txtBloodType)
            .Add(cboEducationalAttainment)
            .Add(txtEmployer)
            .Add(txtOccupation)
            .Add(txtWorkPhone)
            .Add(txtOfficeAddress)
            .Add(txtLineBusiness)
            'SPOUSES
            .Add(txtSSurname)
            .Add(txtSFName)
            .Add(txtSMiddleName)
            .Add(txtSCellPhone)
            .Add(udtSBirthDate)
            .Add(txtSAge)
            .Add(txtSBirthDate)
            .Add(txtSBloodType)
            .Add(cboSEducAttain)
            .Add(txtSEmployer)
            .Add(txtSOccupation)
            .Add(txtSWorkPhone)
            .Add(txtSOfficeAddresss)
            .Add(txtSLineBusiness)
            'COMMUNITY
            .Add(txtCurDistrict)
            .Add(txtyrAttended)
            .Add(txtYrComWeek)
            .Add(txtInvitedBy)
            ''
            .Add(chkKC)
            .Add(chkCWL)
            .Add(chkCharismatic)
            .Add(chkApostolado)
            .Add(chkEucharistic)
            .Add(chkSBA)
            .Add(chkOtherPO)
            .Add(txtOtherPO)
            ''
            .Add(txtcurrPLeader)
            .Add(txtYrUnderCom)
            .Add(txtYrCovenant)
            ''
            .Add(chkPL)
            .Add(chkDistrictHead)
            .Add(chkHandmaid)
            .Add(chkBSD)
            .Add(chkMusicMinistry)
            .Add(chkYA)
            .Add(chkChildrenMin)
            .Add(chkIntercessory)
            .Add(chkCYA)
            .Add(chkLampstand)
            .Add(chkBuhing)
            .Add(chkLingkod)
            .Add(chkBible)
            .Add(chkOtherC)
            .Add(txtOtherC)

            .Add(dgvWeddingAnn)
            .Add(dgvNameChildren)
            .Add(dgvHobbies)
            .Add(dgvTalents)
            .Add(dgvCivicOrg)
            .Add(dgvRelativesCommunity)
            .Add(dgvChildrenOutreach)
            .Add(dgvPreviousPL)
            .Add(dgvServiceCommunity)
            .Add(dgvC)
            .Add(dgvUnit)
            .Add(pcPicture)
            .Add(pcPicture2)
        End With
    End Sub

    Private Sub cmdUpload_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdUpload.ClickButtonArea
        Dim a As String = PowerNET8.myBrowseDialog.browseImage
        If a <> "" Then
            pcPicture.ImageLocation = a
            pcPicture.Tag = "custom"
        Else
            pcPicture.Image = My.Resources.profile_icon1
            pcPicture.Tag = ""
        End If
    End Sub

    Private Sub cmdDel_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdDel.ClickButtonArea
        If pcPicture.Tag <> "" Then
            If MsgBox("Do you want to remove this photo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                pcPicture.Image = My.Resources.profile_icon1
                pcPicture.Tag = ""
            End If
        End If
    End Sub

    Private Sub cmdUpload2_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdUpload2.ClickButtonArea
        Dim a As String = PowerNET8.myBrowseDialog.browseImage
        If a <> "" Then
            pcPicture2.ImageLocation = a
            pcPicture2.Tag = "custom"
        Else
            pcPicture2.Image = My.Resources.profile_icon1
            pcPicture2.Tag = ""
        End If
    End Sub

    Private Sub cmdDel2_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdDel2.ClickButtonArea
        If pcPicture2.Tag <> "" Then
            If MsgBox("Do you want to remove this photo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                pcPicture2.Image = My.Resources.profile_icon1
                pcPicture2.Tag = ""
            End If
        End If
    End Sub

    Private Sub cmdHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1Next.Click, cmdPrev2.Click, cmdNext2.Click, cmd3Next.Click, cmdPrev3.Click, cmd4Next.Click, cmd4Prev.Click, cmd5Prev.Click, cmd5Home.Click
        With CType(sender, Button)
            Select Case .Name
                Case "cmd1Next", "cmdPrev3"
                    utbMain.Tabs(1).Selected = True
                Case "cmdNext2"
                    utbMain.Tabs(2).Selected = True
                Case "cmdPrev2", "cmd5Home"
                    utbMain.Tabs(0).Selected = True
                Case "cmd3Next", "cmd5Prev"
                    utbMain.Tabs(3).Selected = True
                Case "cmd4Prev"
                    utbMain.Tabs(2).Selected = True
                Case "cmd4Next"
                    utbMain.Tabs(4).Selected = True
            End Select
        End With
    End Sub

    Enum ToolAction
        add
        edit
        view
        save
        cancel
    End Enum

    Private Sub toolstripNavigation(ByVal action As ToolAction)
        Select Case action
            Case ToolAction.add
                tsAdd.Visible = False
                tsEdit.Visible = False
                tsCancel.Visible = True
                tsPrint.Visible = False
                tsSave.Visible = True
                cmdUpload.Enabled = True
                cmdUpload2.Enabled = True
                cmdDel.Enabled = True
                cmdDel2.Enabled = True

                utbMain.Tabs(4).Visible = False
                cmd4Next.Enabled = False
            Case ToolAction.cancel
                tsAdd.Visible = True
                tsEdit.Visible = True
                tsCancel.Visible = False
                tsPrint.Visible = True
                tsSave.Visible = False

                cmdUpload.Enabled = False
                cmdUpload2.Enabled = False
                cmdDel.Enabled = False
                cmdDel2.Enabled = False

                utbMain.Tabs(4).Visible = True
                cmd4Next.Enabled = True
            Case ToolAction.save
                tsAdd.Visible = True
                tsEdit.Visible = True
                tsCancel.Visible = False
                tsPrint.Visible = True
                tsSave.Visible = False

                cmdUpload.Enabled = False
                cmdUpload2.Enabled = False
                cmdDel.Enabled = False
                cmdDel2.Enabled = False

            Case ToolAction.edit
                tsSave.Visible = True
                tsAdd.Visible = False
                tsEdit.Visible = False
                tsCancel.Visible = True
                tsPrint.Visible = False

                cmdUpload.Enabled = True
                cmdUpload2.Enabled = True
                cmdDel.Enabled = True
                cmdDel2.Enabled = True

            Case ToolAction.view
                tsAdd.Visible = True
                tsEdit.Visible = True
                tsSave.Visible = False
                tsCancel.Visible = False
                tsPrint.Visible = True

                cmdUpload.Enabled = False
                cmdUpload2.Enabled = False
                cmdDel.Enabled = False
                cmdDel2.Enabled = False
        End Select
    End Sub

#End Region


#Region "VALIDATION"

    Private Sub txtyrAttended_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtyrAttended.LostFocus, txtYrComWeek.LostFocus, txtYrUnderCom.LostFocus, txtYrCovenant.LostFocus, txtAge.LostFocus, txtSAge.LostFocus
        If Not IsNumeric(sender.text) Then
            sender.text_ = 0
        End If
    End Sub

    Private Sub dgvWeddingAnn_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvWeddingAnn.EditingControlShowing
        Select Case dgvWeddingAnn.CurrentCell.ColumnIndex
            Case 0
                clsObjects.EditShowControl(e.Control, "weddingPlace", "tblp_info_wedding_anniversary")
        End Select
    End Sub

    Private Sub dgvWeddingAnn_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvWeddingAnn.RowsAdded
        dgvWeddingAnn.Rows(dgvWeddingAnn.RowCount - 1).Cells(1).Value = Now
    End Sub

    Private Sub dgvNameChildren_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNameChildren.EditingControlShowing
        Select Case dgvNameChildren.CurrentCell.ColumnIndex
            Case 0
                Dim c As TextBox = e.Control
                c.CharacterCasing = CharacterCasing.Upper
        End Select
    End Sub

    Private Sub dgvNameChildren_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvNameChildren.RowsAdded
        With dgvNameChildren
            .Rows(.RowCount - 1).Cells(1).Value = Now
            .Rows(.RowCount - 1).Cells(2).Value = 0
        End With
    End Sub

    Private Sub dgvNameChildren_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNameChildren.RowValidated
        For i As Integer = 0 To dgvNameChildren.Rows.Count - 2
            If Not IsNumeric(dgvNameChildren.Rows(i).Cells(2).Value) Then dgvNameChildren.Rows(i).Cells(2).Value = 0
        Next
        Select Case dgvNameChildren.CurrentCell.ColumnIndex
            Case 1
                If IsDate(dgvNameChildren.CurrentRow.Cells(1).Value) Then
                    Dim dt As Date = dgvNameChildren.CurrentRow.Cells(1).Value
                    dgvNameChildren.CurrentRow.Cells(2).Value = Now.Year - dt.Year
                Else
                    dgvNameChildren.CurrentRow.Cells(2).Value = 0
                End If
        End Select
    End Sub

    Private Sub dgvHobbies_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvHobbies.EditingControlShowing
        clsObjects.EditShowControl(e.Control, "Hobbies", "tblp_info_hobbies")
    End Sub

    Private Sub dgvTalents_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvTalents.EditingControlShowing
        clsObjects.EditShowControl(e.Control, "Talents", "tblp_info_talents")
    End Sub

    Private Sub dgvCivicOrg_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCivicOrg.EditingControlShowing
        clsObjects.EditShowControl(e.Control, "Name", "tblp_info_civic_org")
    End Sub

    Private Sub dgvRelativesCommunity_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRelativesCommunity.EditingControlShowing
        Select Case dgvRelativesCommunity.CurrentCell.ColumnIndex
            Case 0
                Dim c As TextBox = e.Control
                c.CharacterCasing = CharacterCasing.Upper
            Case 1
                clsObjects.EditShowControl(e.Control, "Relation", "tblp_info_relatives_community")
        End Select
    End Sub

    Private Sub dgvChildrenOutreach_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvChildrenOutreach.EditingControlShowing
        clsObjects.EditShowControl(e.Control, "Name", "tblp_info_children_outreach")
    End Sub

    Private Sub dgvPreviousPL_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPreviousPL.EditingControlShowing
        clsObjects.EditShowControl(e.Control, "Name", "tblp_info_prevpl")
    End Sub

    Private Sub dgvServiceCommunity_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvServiceCommunity.EditingControlShowing
        clsObjects.EditShowControl(e.Control, "ServiceName", "tblp_info_what_service_add")
    End Sub

#End Region

    Private Sub reloadUnit(ByVal CID As String)
        Dim mydata As DataTable = mysql.Query("SELECT  CID, NoOrder,`Type`,`Name`,tbl_lstcourses_unit.UID,tbl_lstcourses_unit.NoOrder as 'NoOrderUnit', tbl_lstcourses_unit.Code, tbl_lstcourses_unit.Type as 'subType', tbl_lstcourses_unit.Name as 'UnitName', get_IID(" + IID.ToString + "," + CID.ToString + ",UID) as 'IID' FROM tbl_lstcourses_unit  WHERE  CID = " + CID.ToString + " order by tbl_lstcourses_unit.Type,tbl_lstcourses_unit.UID")
        dgvUnit.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvUnit
                .Rows.Add()
                .Rows(i).Cells(0).Value = mydata.Rows(i).Item("UID")
                .Rows(i).Cells(1).Value = mydata.Rows(i).Item("NoOrderUnit")
                .Rows(i).Cells(2).Value = mydata.Rows(i).Item("Code")
                .Rows(i).Cells(3).Value = mydata.Rows(i).Item("subType")
                .Rows(i).Cells(4).Value = mydata.Rows(i).Item("UnitName")
                Dim col() As String = mydata.Rows(i).Item("IID").ToString.Split("~")
                If Val(col(0)) > 0 Then
                    .Rows(i).Cells(5).Value = 1
                    .Rows(i).Cells(6).Value = col(1)
                Else
                    .Rows(i).Cells(5).Value = 0
                    .Rows(i).Cells(6).Value = "-"
                End If

            End With
        Next


    End Sub

    Private Sub dgvC_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvC.CellClick
        If dgvC.RowCount > 0 Then
            Try
                reloadUnit(dgvC.CurrentRow.Cells(0).Value.ToString)
            Catch ex As Exception
                dgvUnit.Rows.Clear()
            End Try

        End If
    End Sub

    Private Sub dgvUnit_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUnit.CellValidated
        If dgvUnit.Rows.Count > 0 Then
            Select Case dgvUnit.CurrentCell.ColumnIndex
                Case 5
                    Dim count As Integer = 0
                    For i As Integer = 0 To dgvUnit.Rows.Count - 1
                        If dgvUnit.Rows(i).Cells(5).Value Then
                            count += 1
                        End If
                    Next
                    Dim col() As String = dgvC.CurrentRow.Cells(5).Value.ToString.Split("/")
                    dgvC.CurrentRow.Cells(5).Value = count.ToString + "/" + col(1)

            End Select
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        mysql.Query("DELETE FROM tblp_info_courses where CID=" + dgvC.CurrentRow.Cells(0).Value.ToString + " and IID=" + IID)
        For i As Integer = 0 To dgvUnit.Rows.Count - 1
            If dgvUnit.Rows(i).Cells(5).Value Then
                With mysql
                    .setTable("tblp_info_courses")
                    .addValue(IID, "IID")
                    .addValue(dgvC.CurrentRow.Cells(0).Value, "CID")
                    .addValue(dgvUnit.Rows(i).Cells(0).Value, "UID")
                    .Insert()
                End With
            End If
        Next
    End Sub

    Private Function createTable(ByVal type As String)
        Dim mydtc As New PowerNET8.myDataTableCreator
        With mydtc
            Select Case type
                Case "image"
                    .new_table("tblDetails")
                    .add_columnField("image1", PowerNET8.myDataTableCreator.FieldType.blob_)
                    .add_columnField("image2", PowerNET8.myDataTableCreator.FieldType.blob_)
                    Return .get_table
                Case "children"
                    .new_table("tblchildren")
                    .add_columnField("name")
                    .add_columnField("age")
                    Return .get_table
                Case "relatives"
                    .new_table("tblrelatives")
                    .add_columnField("name")
                    .add_columnField("relation")
                    Return .get_table
            End Select
        End With
    End Function

    Private Sub passAttended(ByRef cy As PowerNET8.myDocument.Init.CrystalReportViewer, ByVal inxex As Integer, ByVal value As Boolean)
        Select Case inxex
            Case 0
                cy.addParameterField("chkFCI", IIf(value, "X", ""))
            Case 1
                cy.addParameterField("chkFCII", IIf(value, "X", ""))
            Case 2
                cy.addParameterField("chkCPR", IIf(value, "X", ""))
            Case 3
                cy.addParameterField("chkCHE", IIf(value, "X", ""))
            Case 4
                cy.addParameterField("chkCHS", IIf(value, "X", ""))
            Case 5
                cy.addParameterField("chkFS", IIf(value, "X", ""))
            Case 6
                cy.addParameterField("chkCD", IIf(value, "X", ""))
            Case 7
                cy.addParameterField("chkBS", IIf(value, "X", ""))
            Case 8
                cy.addParameterField("chkLXC", IIf(value, "X", ""))
        End Select
    End Sub

    Private Sub TypeAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeAToolStripMenuItem.Click
        Dim myCR As New PowerNET8.myDocument.Init.CrystalReportViewer

        Select Case CType(sender, ToolStripMenuItem).Name
            Case "TypeAToolStripMenuItem"
                Dim tblImage As DataTable = createTable("image")
                Dim tblChildren As DataTable = createTable("children")
                Dim tblrelative As DataTable = createTable("relatives")

                'IMAGE
                Dim mydata As DataTable = mysql.Query("SELECT * from tblp_info_photo where IID=" + IID)
                If mydata.Rows.Count > 0 Then
                    tblImage.Rows.Add()
                    If Not IsDBNull(mydata.Rows(0).Item("photoImage")) Then
                        tblImage.Rows(0).Item("image1") = mydata.Rows(0).Item("photoImage")
                    End If
                    If Not IsDBNull(mydata.Rows(0).Item("photoImage2")) Then
                        tblImage.Rows(0).Item("image2") = mydata.Rows(0).Item("photoImage2")
                    End If
                End If
                'CHILDREN
                For i As Integer = 0 To dgvNameChildren.Rows.Count - 1
                    tblChildren.Rows.Add()
                    tblChildren.Rows(i).Item("name") = dgvNameChildren.Rows(i).Cells(0).Value
                    tblChildren.Rows(i).Item("age") = dgvNameChildren.Rows(i).Cells(2).Value
                Next
                'RELATIVES
                For i As Integer = 0 To dgvRelativesCommunity.Rows.Count - 1
                    tblrelative.Rows.Add()
                    tblrelative.Rows(i).Item("name") = dgvRelativesCommunity.Rows(i).Cells(0).Value
                    tblrelative.Rows(i).Item("relation") = dgvRelativesCommunity.Rows(i).Cells(1).Value
                Next
                For i As Integer = 0 To 8
                    passAttended(myCR, i, False)
                Next
                For i As Integer = 0 To dgvC.Rows.Count - 1
                    Select Case dgvC.Rows(i).Cells(6).Value.ToString.ToLower
                        Case "foundations course i"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 0, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "foundations course ii"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 1, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "christian personal rel."
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 2, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "christian & his emotions"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 3, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "christian & his service"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 4, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "fruit of the spirit"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 5, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "catholic doctrines"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 6, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "bible study"
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 7, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                        Case "living as x'tian comty."
                            Dim col() As String = dgvC.Rows(i).Cells(5).Value.ToString.Split("/")
                            passAttended(myCR, 8, IIf(Trim(col(0)) = Trim(col(1)), True, False))
                    End Select
                Next

                With myCR
                    .title = "Profile Record Report"
                    .addParameterField("lblMyOther", txtAllOthers.Text)
                    If cboSex.Text = "Male" And cboStatus.Text <> "Single" Then
                        .addParameterField("lblHeader1", "Husband")
                        .addParameterField("lblHeader2", "Wife")
                    ElseIf cboStatus.Text <> "Single" Then
                        .addParameterField("lblHeader1", "Wife")
                        .addParameterField("lblHeader2", "Husband")
                    Else
                        .addParameterField("lblHeader1", "Single")
                        .addParameterField("lblHeader2", "-")
                    End If
                    .addParameterField("lblFamilyName", txtSurname.Text_)
                    .addParameterField("lblFirstName", txtFName.Text_)
                    .addParameterField("lblMiddleName", txtMName.Text_)
                    .addParameterField("lblNickName", txtNickName.Text_)
                    .addParameterField("lblAddress", txtHomeAddress.Text)
                    .addParameterField("lblResTelNo", txtResPhone.Text_)
                    Dim dt As Date = udtBirthdate.Value
                    .addParameterField("lbldateBirth", dt.ToString("MM/dd/yyyy"))
                    .addParameterField("lblPlaceBirth", txtBirthPlace.Text_)
                    .addParameterField("lblEducation", cboEducationalAttainment.Text)
                    .addParameterField("lblOccupation", txtOccupation.Text_)
                    .addParameterField("lblEmployer", txtEmployer.Text_)
                    .addParameterField("lblOfficeTelNo", txtWorkPhone.Text_)
                    .addParameterField("lblOfficeBusiness", txtOfficeAddress.Text_)
                    .addParameterField("lblLineBusiness", txtLineBusiness.Text_)


                    .addParameterField("lblSFamilyName", txtSSurname.Text_)
                    .addParameterField("lblSFirstName", txtSFName.Text_)
                    .addParameterField("lblSMiddleName", txtSMiddleName.Text_)
                    .addParameterField("lblSNickName", txtSNickName.Text_)
                    dt = udtSBirthDate.Value
                    .addParameterField("lblSBirthDat", dt.ToString("MM/dd/yyyy"))
                    .addParameterField("lblSPlaceBirth", txtSBirthDate.Text_)
                    .addParameterField("lblSEducation", cboSEducAttain.Text)
                    .addParameterField("lblSOccupation", txtSOccupation.Text_)
                    .addParameterField("lblSEmployer", txtSEmployer.Text_)
                    .addParameterField("lblSOfficeTelNo", txtSWorkPhone.Text_)
                    .addParameterField("lblSOfficeBusiness", txtSOfficeAddresss.Text_)
                    .addParameterField("lblSLineBusiness", txtSLineBusiness.Text_)

                    dt = utdWhenJoined.Value
                    .addParameterField("lblWhenJoined", dt.ToString("MM/dd/yyyy"))
                    Dim x As String = ""
                    For i As Integer = 0 To dgvWeddingAnn.RowCount - 1
                        dt = dgvWeddingAnn.Rows(i).Cells(1).Value
                        PowerNET8.myString.Share.Concat.Append(x, dgvWeddingAnn.Rows(i).Cells(0).Value.ToString + " - " + dt.ToString("MM/dd/yyyy"))
                    Next
                    .addParameterField("lblWeddingAnni", x)

                    Dim tblSignatory As DataTable = mysql.Query("SELECT * from tbl_signatories where type='profile record'")
                    If tblSignatory.Rows.Count > 0 Then
                        .addParameterField("lblHeadSignature", tblSignatory.Rows(0).Item(1))
                    Else
                        .addParameterField("lblHeadSignature", "")
                    End If

                    .addTableField(tblChildren)
                    .addTableField(tblImage)
                    .addTableField(tblrelative)
                    .reportPath("Reports\rptProfileReport.rpt")
                    .launchReport()
                End With
        End Select

    End Sub

    Private Sub udtSBirthDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udtSBirthDate.ValueChanged
        txtSAge.Text_ = (Age(udtSBirthDate.Value))
    End Sub

    Private Sub udtBirthdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udtBirthdate.ValueChanged
        txtAge.Text_ = (Age(udtBirthdate.Value))
    End Sub

    Public Shared Function Age(ByVal DOfB As Date) As String
        Dim myAge = Now.Year - DOfB.Year
        If DOfB.Month = Now.Month Then
            If DOfB.Day < Now.Day Then
                myAge -= 1
            End If
        ElseIf DOfB.Month < Now.Month Then
            myAge -= 1
        End If
        Return myAge
    End Function


    Private Sub dgvNameChildren_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvNameChildren.RowStateChanged

    End Sub

    Private Sub dgvC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvC.CellContentClick

    End Sub

    Private Sub dgvUnit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUnit.CellContentClick

    End Sub
End Class