Public Class frmUserManagementFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public ParentForms As frmMain

    Private Sub frmUserManagementFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub initialize()
        connect(mysql)
        With MyNavigationGrid1
            .set_class(mysql)
            .Set_SELECT("tblsys_user.userID, username, userLevel, concat(surName, ', ',firstname, ' ', middleName) as 'Full Name'")
            .Set_FROM("tbluserinfo    INNER JOIN tblsys_user      ON (tbluserinfo.userID = tblsys_user.userID)")
            .Set_ORDER("username")
            .Set_Data(dgvMain)
            .Execute()
            dgvMain.Columns(0).Visible = False
        End With
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim wh As String = ""
        If txtLastName.Text <> "" Then wh = " surName like '" + txtLastName.Text + "%' "
        If txtUsername.Text <> "" Then
            If wh = "" Then
                wh = " username like '" + txtUsername.Text + "%' "
            Else
                wh += " and username like '" + txtUsername.Text + "%' "
            End If
        End If
        MyNavigationGrid1.Set_WHERE(wh)
        MyNavigationGrid1.Execute()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtLastName.Text = ""
        txtUsername.Text = ""
        txtLastName.Focus()
    End Sub

    Private Sub txtLastName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastName.GotFocus, txtUsername.GotFocus
        sender.backcolor = Color.Beige
    End Sub

    Private Sub txtLastName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastName.LostFocus, txtUsername.LostFocus
        sender.backcolor = Color.White
    End Sub

    Private Sub txtLastName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLastName.KeyDown, txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(cmdSearch, Nothing)
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim frmSignUp As New frmSignUp
        With frmSignUp
            .userID = "0"
            .action = "add"
            .MdiParent = ParentForms
            .Show()
        End With
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim frmSignUp As New frmSignUp
        With frmSignUp
            .userID = dgvMain.CurrentRow.Cells(0).Value.ToString
            .action = "view"
            .MdiParent = ParentForms
            .Show()
        End With
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Delete Username Confirm") = MsgBoxResult.Yes Then
            mysql.Query("DELETE FROM tblsys_user where userID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
            mysql.Query("DELETE FROM tbluserinfo where userID=" + dgvMain.CurrentRow.Cells(0).Value.ToString)
            MsgBox("You have been successfully deleted.")
            cmdSearch_Click(cmdSearch, Nothing)
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim frmSignUp As New frmSignUp
        With frmSignUp
            .userID = dgvMain.CurrentRow.Cells(0).Value.ToString
            .action = "edit"
            .MdiParent = ParentForms
            .Show()
        End With
    End Sub

    Private Sub dgvMain_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        cmdView_Click(cmdView, Nothing)
    End Sub
End Class