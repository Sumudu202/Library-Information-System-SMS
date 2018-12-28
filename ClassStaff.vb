
Imports Library.Member
Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class ClassStaff
    Inherits Member

    Public MemberID As String
    Public Title As String
    Public LName As String
    Public Init As String
    Public ConNo As String
    Public TmpAdd As String
    Public PermAdd As String
    Public NID As String
    Public DeptName As String
    Public Post As String

#Region "Add New Staff Member"

    Public Overrides Sub AddMember(ByVal MemId As String, ByVal Title As String, ByVal Init As String, ByVal Lname As String, ByVal NID As String, ByVal CNO As String, ByVal TAdd As String, ByVal PAdd As String, ByVal Dept As String, ByVal Position As String)

        Dim MemLevelL, MemLevelSR As String
        Dim Count, Type As Int16

        If Position = "Dean" Then
            MemLevelL = "DL"
            MemLevelSR = "DSR"
        ElseIf Position = "Professor" Then
            MemLevelL = "PL"
            MemLevelSR = "PSR"
        ElseIf Position = "Senior Lecturer" Then
            MemLevelL = "SLL"
            MemLevelSR = "SLSR"
        ElseIf Position = "Lecturer" Then
            MemLevelL = "LL"
            MemLevelSR = "LSR"
        ElseIf Position = "Demonstrator" Then
            MemLevelL = "DemL"
            MemLevelSR = "DemSR"
        ElseIf Position = "Executive Officer" Then
            MemLevelL = "EOL"
            MemLevelSR = "EOSR"
        ElseIf Position = "Temporary Demonstrator" Then
            MemLevelL = "TDemL"
            MemLevelSR = "TDemSR"
        End If

        Type = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(type)from  BorrowingType where type='" & MemLevelL & "' or type='" & MemLevelSR & "'")

        If Type < 2 Then
            MessageBox.Show("Please register the member type first")
        Else
            Dim trans As SqlTransaction = Nothing
            Try
                sqlconn.Open()
                trans = sqlconn.BeginTransaction()
                Try
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, " insert into Member values('" & MemId & "','" & Title & "','" & Init & "','" & Lname & "','" & NID & "','" & CNO & "','" & TAdd & "','" & PAdd & "')")
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, " insert into Staff values('" & MemId & "','" & Dept & "','" & Position & "')")
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into MemberBorrowingType values('" & MemId & "','" & MemLevelL & "')")
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into MemberBorrowingType values('" & MemId & "','" & MemLevelSR & "')")
                    trans.Commit()
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show(ex.Message)
                    Throw ex
                End Try

            Finally
                If Not trans Is Nothing Then trans.Dispose()
                sqlconn.Close()
            End Try

        End If
    End Sub

#End Region

#Region "Search Member Details"

    Public Overrides Sub SearchMember(ByVal MemId As String, ByVal Type As String)

        Dim stSQL1 As String = "SELECT * FROM Member where memberID='" & MemId & "'"
            Dim Comm1 As New SqlCommand(stSQL1, sqlconn)
            Dim myReader1 As SqlDataReader

        Try
            sqlconn.Open()
            myReader1 = Comm1.ExecuteReader

            While (myReader1.Read())
                MemberID = myReader1("memberID")
                Title = myReader1("title")
                LName = myReader1("lName")
                Init = myReader1("initial")
                ConNo = myReader1("contactNo")
                TmpAdd = myReader1("termTimeAddress")
                PermAdd = myReader1("permanentAddress")
                NID = myReader1("nationalIDNo")
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            myReader1.Close()
            sqlconn.Close()
        End Try

        Dim stSQL2 As String = "SELECT * FROM Staff where memberID='" & MemId & "'"
        Dim Comm2 As New SqlCommand(stSQL2, sqlconn)
        Dim myReader2 As SqlDataReader

        Try
            sqlconn.Open()
            myReader2 = Comm2.ExecuteReader

            While (myReader2.Read())
                DeptName = myReader2("dept")
                Post = myReader2("position")
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            myReader2.Close()
            sqlconn.Close()
        End Try

    End Sub

    Function Search_Member(ByVal MID As String, ByVal DG As DataGrid)

        Dim Count As Integer
        Dim sqlDs As New DataSet
        sqlDs.DataSetName = "Over Due Books"

        Try
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(memberID) from Staff where memberID='" & MID & "'")

            If Count = 0 Then
                MessageBox.Show("Check the MemberID and Type", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function
            Else
                Dim sqlDA As New SqlDataAdapter("select brc.memberID,brc.accessionNo,b.title,brc.dueDate from dbo.BorrowedCopy as brc,Book as b,BookCopy as bc where brc.memberID='" & MID & "' and brc.accessionNo=bc.accessionNo and bc.ISBN=b.ISBN and brc.returned=0", sqlconn)
                sqlDA.Fill(sqlDs)
                DG.DataSource = sqlDs
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

#End Region

#Region "Edit Member Details"

    Public Overrides Sub EditMember(ByVal UnvId As String, ByVal Title As String, ByVal Init As String, ByVal LName As String, ByVal ConNo As String, ByVal NID As String, ByVal TmpAdd As String, ByVal PermAdd As String, ByVal MemId As String, ByVal Dept As String, ByVal Post As String)

        Dim MemLevelL, MemLevelSR As String
        Dim Count, Type As Int16

        If Post = "Dean" Then
            MemLevelL = "DL"
            MemLevelSR = "DSR"
        ElseIf Post = "Professor" Then
            MemLevelL = "PL"
            MemLevelSR = "PSR"
        ElseIf Post = "Senior Lecturer" Then
            MemLevelL = "SLL"
            MemLevelSR = "SLSR"
        ElseIf Post = "Lecturer" Then
            MemLevelL = "LL"
            MemLevelSR = "LSR"
        ElseIf Post = "Demonstrator" Then
            MemLevelL = "DemL"
            MemLevelSR = "DemSR"
        ElseIf Post = "Executive Officer" Then
            MemLevelL = "EOL"
            MemLevelSR = "EOSR"
        ElseIf Post = "Temporary Demonstrator" Then
            MemLevelL = "TDemL"
            MemLevelSR = "TDemSR"
        End If

        Try
            sqlconn.Open()
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(type) from BorrowingType where type='" & MemLevelL & "' or type='" & MemLevelSR & "'")

            If Count < 1 Then
                MessageBox.Show("Please Add the Member Level First", "Verify Member Level", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                Dim trans As SqlTransaction = Nothing

                trans = sqlconn.BeginTransaction()

                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "update Member set memberID='" & UnvId & "',title='" & Title & "', initial='" & Init & "', lName='" & LName & "', contactNo='" & ConNo & "',nationalIDNo='" & NID & "',termTimeAddress='" & TmpAdd & "',permanentAddress='" & PermAdd & "' where memberID='" & MemId & "'")
                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "update Staff set memberID='" & UnvId & "',dept='" & Dept & "',position='" & Post & "' where memberID='" & MemId & "'")
                trans.Commit()
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If

        End Try

    End Sub

#End Region

#Region "Delete Member Details"

    Public Overrides Sub Delete_Member(ByVal MemId As String)

        If MemId = "" Then
            MessageBox.Show("Enter the Member ID", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "delete member where memberID='" & MemId & "'")
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

#End Region

End Class
