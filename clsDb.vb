Imports System.Data.SqlClient

'Public Class clsDb
'    Private Shared con As SqlConnection
'    Public Shared Function getConnection() As SqlConnection
'        If con Is Nothing Then
'            Dim rd As New System.Configuration.AppSettingsReader
'            Dim str As String = rd.GetValue("conStr", GetType(String))
'            'Dim str As String = "Persist Security Info=False;User ID=sa;Initial Catalog=AuziDocs;Data Source=DILSHAN;Packet Size=4096"
'            con = New SqlConnection(str)
'            con.Open()
'        End If
'        Return con
'    End Function
'End Class
