Module modMain
    Friend myDialog As New PowerNET8.myDialog.messageBoxes
    Friend myCon As New PowerNET8.myConnector
    Friend myFIle As New PowerNET8.myFile.Share.Location
    Friend mysql As New PowerNET8.mySQL.Init.SQL
    Friend myWelcomeScr As New PowerNET8.myWelcomeScreen

    Friend myException As New PowerNET8.myExceptionHandler

    Sub Main()
        Dim myencrypt As New PowerNET8.myEncrypt
      
        enable_visual_styles()
        exeption_handler()
        With myCon
            If .check_No_Multi_System_Running("IRMS") Then
                If .connection_MYSQL_Settings(myFIle.getBasePath, "setup.ini") Then
                    chost = ._Localhost
                    cport = ._Port
                    cuserName = ._UserRoot
                    cpassword = ._Password
                    cdbname = ._Database
                    username = ._User
                    Dim frm As New frmLogIn
                    With frm
                        .ShowDialog()
                        If .returnValue Then
                            myWelcomeScr.run(My.Resources.Welcome__1_, Color.Beige, Color.Black, 0.85)
                            Dim frmmm As New frmMain
                            frmmm.ShowDialog()
                        End If
                    End With
                End If
            Else
                myDialog.show("The system is already running.", "Unable to run")
            End If
        End With

    End Sub

    Private Sub enable_visual_styles()
        Try
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub exeption_handler()
        AddHandler Application.ThreadException, AddressOf myException.OnThreadException
    End Sub

End Module
