Public Class frmMain
    Private myform As New PowerNET8.myForm

    Private Sub ProfileRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileRecordToolStripMenuItem.Click, CoursesAndTalksToolStripMenuItem.Click, ContributionRecordToolStripMenuItem.Click, NewsLetterToolStripMenuItem.Click, EventsRecordToolStripMenuItem.Click, DistrictRecordToolStripMenuItem.Click, GroupModulesToolStripMenuItem.Click, ActivitiesModuleToolStripMenuItem.Click, MemberListToolStripMenuItem.Click, MembersPopulationToolStripMenuItem.Click, DistrictListToolStripMenuItem.Click, EventListToolStripMenuItem.Click, LogOutToolStripMenuItem.Click, ExitApplicationToolStripMenuItem.Click, SystemUserManagementToolStripMenuItem.Click
        Select Case CType(sender, ToolStripMenuItem).Name
            Case "ProfileRecordToolStripMenuItem"
                myform.Load_Form(Me, New frmProfileInfoFinder)
            Case "CoursesAndTalksToolStripMenuItem"
                myform.Load_Form(Me, New frmCourseTalk)
            Case "ContributionRecordToolStripMenuItem"
                myform.Load_Form(Me, New frmContributionFinder)
            Case "NewsLetterToolStripMenuItem"
                myform.Load_Form(Me, New frmNewsLetterFinder)
            Case "EventsRecordToolStripMenuItem"
                myform.Load_Form(Me, New frmEventsFinder)
            Case "DistrictRecordToolStripMenuItem"
                myform.Load_Form(Me, New frmDistrictsFinder)
            Case "GroupModulesToolStripMenuItem"
                myform.Load_Form(Me, New frmGroupFinder)
            Case "ActivitiesModuleToolStripMenuItem"
                myform.Load_Form(Me, New frmActivitesFinder)
            Case "MemberListToolStripMenuItem", "MembersPopulationToolStripMenuItem", "DistrictListToolStripMenuItem", "EventListToolStripMenuItem"
                myform.Load_Form(Me, New frmReport)
            Case "LogOutToolStripMenuItem"
                If MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Log Out Confirm") = MsgBoxResult.Yes Then
                    Dim frmLogIn As New frmLogIn
                    Me.Hide()
                    frmLogIn.frm = Me
                    frmLogIn.txtusername.Text = ""
                    frmLogIn.txtpassword.Text = ""
                    frmLogIn.Show()
                End If
            Case "ExitApplicationToolStripMenuItem"
                If MsgBox("Do you want to exit application?", MsgBoxStyle.YesNo, "Exit Confirm") = MsgBoxResult.Yes Then
                    End
                End If
            Case "SystemUserManagementToolStripMenuItem"
                myform.Load_Form(Me, New frmUserManagementFinder)
        End Select
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProfile.Click, ToolStripButton2.Click, ToolStripButton7.Click, ToolStripButton6.Click, ToolStripButton5.Click, ToolStripButton4.Click, ToolStripButton3.Click, ToolStripButton1.Click, ToolStripButton8.Click
        Select Case CType(sender, ToolStripButton).Name
            Case "tsbProfile"
                myform.Load_Form(Me, New frmProfileInfoFinder)
            Case "ToolStripButton2"
                myform.Load_Form(Me, New frmCourseTalk)
            Case "ToolStripButton7"
                myform.Load_Form(Me, New frmContributionFinder)
            Case "ToolStripButton6"
                myform.Load_Form(Me, New frmNewsLetterFinder)
            Case "ToolStripButton5"
                myform.Load_Form(Me, New frmEventsFinder)
            Case "ToolStripButton4"
                myform.Load_Form(Me, New frmDistrictsFinder)
            Case "ToolStripButton3"
                myform.Load_Form(Me, New frmGroupFinder)
            Case "ToolStripButton1"
                myform.Load_Form(Me, New frmActivitesFinder)
            Case "ToolStripButton8"
                myform.Load_Form(Me, New frmReport)
        End Select
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("ABP System Program")
    End Sub

    Private Sub SystemUserManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemUserManagementToolStripMenuItem.Click

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If userLevel <> "Administrator" Then
            SystemUserManagementToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub MemberTypeGeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberTypeGeneratorToolStripMenuItem.Click
        Dim frm As New frmProfilePicker
        frm.ShowDialog()
    End Sub

    Private Sub ContributionSummaryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContributionSummaryReportToolStripMenuItem.Click
        Dim frm As New frmContributionReport
        frm.ShowDialog()
    End Sub
End Class