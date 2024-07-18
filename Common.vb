Imports MySql.Data.MySqlClient

Public Class Common
    Private Shared myDBConnection As MySqlConnection

    Public Shared Function getDBConnectionX() As MySqlConnection
        If myDBConnection Is Nothing Then
            myDBConnection = New MySqlConnection(
                "Database=projectDB;" &
                "Data Source=localhost;" &
                "User id=projectDBAdmin;" &
                "Password=1322LDSP;" &
                "Port=3306;Command Timeout=600;")
        End If
        Return myDBConnection
    End Function
End Class
