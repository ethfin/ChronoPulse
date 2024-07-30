Imports MySql.Data.MySqlClient

Public Class Common
    Private Shared ReadOnly myDBConnection As New Lazy(Of MySqlConnection)(
        Function() New MySqlConnection(
            "Database=projectDB;" &
            "Data Source=localhost;" &
            "User id=projectDBAdmin;" &
            "Password=1322LDSP;" &
            "Port=3306;Command Timeout=600;"))

    Public Shared Function getDBConnectionX() As MySqlConnection
        Return myDBConnection.Value
    End Function
End Class


'Imports MySql.Data.MySqlClient

'Public Class Common
'    Private Shared myDBConnection As MySqlConnection

'    Public Shared Function getDBConnectionX() As MySqlConnection
'        If myDBConnection Is Nothing Then
'            myDBConnection = New MySqlConnection(
'                "Database=projectDB;" &
'                "Data Source=localhost;" &
'                "User id=projectDBAdmin;" &
'                "Password=1322LDSP;" &
'                "Port=3306;Command Timeout=600;")
'        End If
'        Return myDBConnection
'    End Function
'End Class
