Imports System.Data.Odbc
Module kon
    Public conn As OdbcConnection
    Public dr As OdbcDataReader
    Public ds As DataSet
    Public da As OdbcDataAdapter
    Public cmd As OdbcCommand
    Public sql1 As String
    Public sql2 As String

    Sub koneksi()
        sql1 = "driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=apotek;port=3306"
        conn = New OdbcConnection(sql1)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
