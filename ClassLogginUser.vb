'Public Class BaseClass
'    Public userId
'    Private passWord
'End Class
Imports System.Data.SqlClient
Imports System.Configuration

Public Class LogginUser
    'Inherits BaseClass
    Public userId
    Public Shared userType
    Private passWord
    Public loginMassage As String
    Public Shared sqlconn As New SqlClient.SqlConnection("workstation id=NIROSHA;packet size=4096;user id=sa;data source=.;persist security info=True;initial catalog=LIS;password=296105")
    Public Shared MemberID As String

    Public Sub New(ByVal UID As String, ByVal PWD As String)

        ValidateUser(UID, PWD)

    End Sub

#Region "Check the validity of the user"

    Private Function ValidateUser(ByVal UID As String, ByVal PWD As String)

        Dim comm As New SqlClient.SqlCommand("Select * from Loggin where UserId='" + UID + "' and  passWord = '" + PWD + "'", sqlconn)
        Dim myReader As SqlClient.SqlDataReader

        Try
            sqlconn.Open()
            myReader = comm.ExecuteReader()
            If (myReader.Read()) Then
                userId = myReader.GetString(0)
                loginMassage = "A Valid User"
            Else
                loginMassage = "Error"
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        Finally
            sqlconn.Close()
        End Try

    End Function

#End Region

End Class

