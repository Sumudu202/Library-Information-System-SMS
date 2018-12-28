Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports Library.LogginUser

Public Class ClassBorrowdCopy
    Dim MemberID As String
    Dim AccessionNo As String

    Function GetTyp(ByVal MemberID As String, ByVal AccessionNo As String)

        ' Return SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select NoOfDays from Borrowingtype as a, MemberBorrwingType as b where ")

    End Function
End Class
