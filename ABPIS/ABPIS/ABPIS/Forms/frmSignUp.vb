Public Class frmSignUp
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private myDialog As New PowerNET8.myDialog.messageBoxes
    Public userID As String = "0"
    Public action As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub initialize()
        connect(mysql)
        With myDialog
            .setDialogBoxStyle = PowerNET8.myDialog.messageBoxes.DialogStyle.PlainDialog
            .setShadowBackground = PowerNET8.myDialog.messageBoxes.Mode.enable
        End With

        If action = "add" Then
            cmdCreate.Visible = False
            clearAll()
        ElseIf action = "view" Then
            retrieveRecord()
            lockControls(True)
        ElseIf action = "edit" Then
            retrieveRecord()
            lockControls(False)
        End If
    End Sub

    Private Function validateIfUsernameExist(ByVal username As String)
        Dim mydata As DataTable = mysql.Query("select * from tblsys_user where username='" + username + "'")
        If mydata.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub retrieveRecord()
        Dim mydata As DataTable = mysql.Query("SELECT * FROM    tbluserinfo    INNER JOIN tblsys_user      ON (tbluserinfo.userID = tblsys_user.userID) where tblsys_user.userID=" + userID)
        If mydata.Rows.Count > 0 Then
            txtsurname.Text_ = mydata.Rows(0).Item("surname")
            txtfirstname.Text_ = mydata.Rows(0).Item("firstname")
            txtmiddlename.Text_ = mydata.Rows(0).Item("middlename")
            cboUserLevel.Text = mydata.Rows(0).Item("userLevel")
            txtusername.Text_ = mydata.Rows(0).Item("username")
        End If
    End Sub

    Private Sub lockControls(ByVal value As Boolean)
        If value Then
            txtsurname.ReadOnly_ = True
            txtfirstname.ReadOnly_ = True
            txtmiddlename.ReadOnly_ = True
            cboUserLevel.Enabled = False
            txtsurname.ReadOnly_ = True
            txtpassword.ReadOnly_ = True
            txtrpassword.ReadOnly_ = True
        Else
            txtsurname.ReadOnly_ = False
            txtfirstname.ReadOnly_ = False
            txtmiddlename.ReadOnly_ = False
            cboUserLevel.Enabled = True
            txtsurname.ReadOnly_ = False
            txtpassword.ReadOnly_ = False
            txtrpassword.ReadOnly_ = False
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If cboUserLevel.SelectedIndex <> -1 And txtsurname.Text_ <> "" And txtfirstname.Text_ <> "" And txtusername.Text_ <> "" And txtpassword.Text_ <> "" And txtrpassword.Text_ <> "" Then

            If txtpassword.Text_ = txtrpassword.Text_ Then
                If action = "edit" Then GoTo Skip
                If Not validateIfUsernameExist(txtusername.Text_) Then
skip:
                    With mysql
                        .setTable("tbluserinfo")
                        .addValue(txtsurname.Text_, "surname")
                        .addValue(txtmiddlename.Text_, "middlename")
                        .addValue(txtfirstname.Text_, "firstname")

                        If userID = "0" Then
                            userID = .nextID("userID").ToString
                            .addValue(userID, "userID")
                            .Insert()
                        Else
                            .Update("userID", userID)
                        End If

                    End With

                    With mysql
                        .setTable("tblsys_user")
                        .addValue(cboUserLevel.Text, "userLevel")
                        .addValue(txtusername.Text_, "username")
                        .addValue(.crypt(txtpassword.Text_), "password")

                        If action = "add" Then
                            .addValue(userID, "userID")
                            .addValue(.nextID("sysID"), "sysID")
                            .Insert()
                        Else
                            .Update("userID", userID)
                        End If

                    End With
                    If action = "add" Then
                        myDialog.show("Successfully Added")
                    Else
                        myDialog.show("Successfully Updated")
                    End If

                    action = "edit"
                    cmdCreate.Visible = True
                Else
                    myDialog.show("There is username already exist, please try another username")
                    txtusername.Text_ = ""
                    txtusername.Focus()
                End If
            Else
                myDialog.show("password does not match please try again.")
                txtpassword.Text_ = ""
                txtrpassword.Text_ = ""
                txtpassword.Focus()
            End If

        Else
            myDialog.show("Please complete all required fields")
        End If
    End Sub

    Private Sub clearAll()
        userID = "0"
        action = "add"
        txtsurname.Text_ = ""
        txtsurname.Focus()
        txtfirstname.Text_ = ""
        txtmiddlename.Text_ = ""
        cboUserLevel.SelectedIndex -= -1
        txtusername.Text_ = ""
        txtpassword.Text_ = ""
        txtrpassword.Text_ = ""
    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        If myDialog.show("Do you want to add new user?", "Add New", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmdCreate.Visible = False
            clearAll()
        End If
    End Sub
End Class
