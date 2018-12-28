Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public MustInherit Class Member

    Dim MemberID As String
    Dim Title As String
    Dim Initial As String
    Dim LName As String
    Dim NID As String
    Dim ContactNo As String
    Dim TAddress As String
    Dim PAddress As String

    Public MustOverride Sub AddMember(ByVal MemId As String, ByVal Title As String, ByVal Init As String, ByVal Lname As String, ByVal NID As String, ByVal CNO As String, ByVal TAdd As String, ByVal PAdd As String, ByVal DeptorLevel As String, ByVal PostorStage As String)
    'No Implimentation 

    Public MustOverride Sub EditMember(ByVal UnvId As String, ByVal Title As String, ByVal Init As String, ByVal LName As String, ByVal ConNo As String, ByVal NID As String, ByVal TmpAdd As String, ByVal PermAdd As String, ByVal MemId As String, ByVal DeptorLevel As String, ByVal PostorStage As String)
    'No Implimentation                 

    Public MustOverride Sub searchMember(ByVal MemId As String, ByVal Type As String)
    'No Implimentation

    Public MustOverride Sub Delete_Member(ByVal MemId As String)
    'No implimentation

End Class
