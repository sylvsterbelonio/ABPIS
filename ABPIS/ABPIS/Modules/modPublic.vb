Module modPublic
    Public chost As String = "localhost"
    Public cuserName As String = "root"
    Public cport As String = "3306"
    Public cpassword As String = ""
    Public cdbname As String = "abpis"
    Public userID As String = "1"
    Public username As String = "sylvster"
    Public userLevel As String = "Administrator"

    Public Sub connect(ByRef mysql As PowerNET8.mySQL.Init.SQL)
        mysql.connectDatabase(chost, cport, cuserName, cpassword, cdbname)
    End Sub



End Module
