
Imports Library.LogginUser
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class ClassStudent
    Inherits Member

    Public Title As String
    Public LName As String
    Public Init As String
    Public ConNo As String
    Public TmpAdd As String
    Public PermAdd As String
    Public UnvId As String
    Public NID As String
    Public MemberId As String
    Public Level As String
    Public StuStg As String

#Region "Add New Student Member"

    Public Overrides Sub AddMember(ByVal MemId As String, ByVal Title As String, ByVal Init As String, ByVal LName As String, ByVal NID As String, ByVal CNO As String, ByVal TAdd As String, ByVal PAdd As String, ByVal Level As String, ByVal Stage As String)

        Dim MemLevelL, MemLevelSR As String
        Dim Count, Type As Int16

        If Level = "Undergraduate" And Stage = "1st Year" Then
            MemLevelL = "UGL1L"
            MemLevelSR = "UGL1SR"
        ElseIf Level = "Undergraduate" And Stage = "2nd Year" Then
            MemLevelL = "UGL2L"
            MemLevelSR = "UGL2SR"
        ElseIf Level = "Undergraduate" And Stage = "3rd Year" Then
            MemLevelL = "UGL3L"
            MemLevelSR = "UGL3SR"
        ElseIf Level = "Undergraduate" And Stage = "4th Year" Then
            MemLevelL = "UGL4L"
            MemLevelSR = "UGL4SR"
        ElseIf Level = "Postgraduate" And Stage = "1st Year" Then
            MemLevelL = "PGL1L"
            MemLevelSR = "PGL1SR"
        ElseIf Level = "Postgraduate" And Stage = "2nd Year" Then
            MemLevelL = "PGL2L"
            MemLevelSR = "PGL2SR"
        End If

        Type = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(type)from  BorrowingType where type='" & MemLevelL & "' or type='MemLevelSR'")

        If Type < 1 Then
            MessageBox.Show("Please register the member type first")

        Else
            Dim Trans As SqlTransaction = Nothing

            Try
                sqlconn.Open()
                Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(memberID) from Member where memberID='" & MemId & "'")
                If Count > 0 Then
                    MessageBox.Show("This Student is a registered one, Please check", "Verify Student Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Trans = sqlconn.BeginTransaction()
                    Try
                        SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, " insert into Member values('" & MemId & "','" & Title & "','" & Init & "','" & LName & "','" & NID & "','" & CNO & "','" & TAdd & "','" & PAdd & "')")
                        SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, " insert into Student values('" & MemId & "','" & Level & "','" & Stage & "')")
                        SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "insert into MemberBorrowingType values('" & MemId & "','" & MemLevelL & "')")
                        SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "insert into MemberBorrowingType values('" & MemId & "','" & MemLevelSR & "')")
                        Trans.Commit()
                        MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        Trans.Rollback()
                        MessageBox.Show(ex.Message)
                        Throw ex
                    End Try
                End If

            Finally
                If Not Trans Is Nothing Then Trans.Dispose()
                If Not sqlconn Is Nothing Then
                    sqlconn.Close()
                End If

            End Try
        End If

    End Sub

#End Region

#Region "Search Member Details"

    Public Overrides Sub SearchMember(ByVal MemId As String, ByVal Type As String)

       Dim stSQL As String = "SELECT * FROM Member where memberID='" & MemId & "'"
            Dim Comm As New SqlCommand(stSQL, sqlconn)
            Dim myReader As SqlDataReader

        Try
            sqlconn.Open()
            myReader = Comm.ExecuteReader

            While (myReader.Read())
                Title = myReader("title")
                LName = myReader("lName")
                Init = myReader("initial")
                ConNo = myReader("contactNo")
                TmpAdd = myReader("termTimeAddress")
                PermAdd = myReader("permanentAddress")
                MemberId = myReader("memberID")
                NID = myReader("nationalIDNo")
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            If Not myReader Is Nothing Then
                myReader.Close()
            End If
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try

        Dim stSQL2 As String = "SELECT * FROM Student where memberID='" & MemId & "'"
        Dim Comm2 As New SqlCommand(stSQL2, sqlconn)
        Dim MyReader2 As SqlDataReader

        Try
            sqlconn.Open()
            MyReader2 = Comm2.ExecuteReader

            While (MyReader2.Read())
                Level = MyReader2("stuLevel")
                StuStg = MyReader2("stage")
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            If Not MyReader2 Is Nothing Then
                MyReader2.Close()
            End If
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try

    End Sub

    Function Search_Member(ByVal MID As String, ByVal DG As DataGrid)

        Dim Count, i As Integer
        Dim sqlDs As New DataSet
        sqlDs.DataSetName = "Over Due Books"

        Try
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(memberID) from Student where memberID='" & MID & "'")

            If Count = 0 Then
                MessageBox.Show("Check the MemberID and Type", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function

            Else
                Dim sqlDA As New SqlDataAdapter("select brc.MemberID,brc.AccessionNo as 'Accession No',b.Title,brc.dueDate from dbo.BorrowedCopy as brc,Book as b,BookCopy as bc where brc.memberID='" & MID & "' and brc.accessionNo=bc.accessionNo and bc.ISBN=b.ISBN and brc.returned=0", sqlconn)
                sqlDA.Fill(sqlDs)
                DG.DataSource = sqlDs
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

#End Region

#Region "Edit Member Details"

    Public Overrides Sub EditMember(ByVal UnvId As String, ByVal Title As String, ByVal Init As String, ByVal LName As String, ByVal ConNo As String, ByVal NID As String, ByVal TmpAdd As String, ByVal PermAdd As String, ByVal MemId As String, ByVal Level As String, ByVal StuStg As String)

        Dim MemLevelL, MemLevelSR As String
        Dim Count As Int16

        If Level = "Undergraduate" And StuStg = "1st Year" Then
            MemLevelL = "UGL1L"
            MemLevelSR = "UGL1SR"
        ElseIf Level = "Undergraduate" And StuStg = "2nd Year" Then
            MemLevelL = "UGL2L"
            MemLevelSR = "UGL2SR"
        ElseIf Level = "Undergraduate" And StuStg = "3rd Year" Then
            MemLevelL = "UGL3L"
            MemLevelSR = "UGL3SR"
        ElseIf Level = "Undergraduate" And StuStg = "4th Year" Then
            MemLevelL = "UGL4L"
            MemLevelSR = "UGL4SR"
        ElseIf Level = "Postgraduate" And StuStg = "1st Year" Then
            MemLevelL = "PGL1L"
            MemLevelSR = "PGL1SR"
        ElseIf Level = "Postgraduate" And StuStg = "2nd Year" Then
            MemLevelL = "PGL2L"
            MemLevelSR = "PGL2SR"
        End If

        Dim Trans As SqlTransaction = Nothing

        Try
            sqlconn.Open()
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(type) from BorrowingType where type='" & MemLevelL & "' or type='" & MemLevelSR & "'")
            If Count < 2 Then
                MessageBox.Show("Please Add the Member Level First", "Verify Member Level", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Trans = sqlconn.BeginTransaction()
                Try
                    SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "update Member set memberID='" & UnvId & "',title='" & Title & "',initial='" & Init & "',lName='" & LName & "',nationalIDNo='" & NID & "',contactNo='" & ConNo & "',termTimeAddress='" & TmpAdd & "',permanentAddress='" & PermAdd & "' where memberID='" & MemId & "'")
                    SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "update Student set memberID='" & UnvId & "',stuLevel='" & Level & "',stage='" & StuStg & "' where memberID='" & MemId & "'")
                    SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "update MemberBorrowingType set type='" & MemLevelL & "' where type like '%L' and memberID='" & UnvId & "' ")
                    SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "update MemberBorrowingType set type='" & MemLevelSR & "' where type like '%SR' and memberID='" & UnvId & "' ")
                    Trans.Commit()
                    MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Trans.Rollback()
                    Throw ex
                End Try
            End If

        Finally
            If Not Trans Is Nothing Then Trans.Dispose()
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

#Region "Clear"

    Function clear(ByVal MemId As String, ByVal Title As String, ByVal Init As String, ByVal LName As String, ByVal NID As String, ByVal CNO As String, ByVal TAdd As String, ByVal PAdd As String, ByVal Stage As String)

        MemId = ""
        Title = ""
        Init = ""
        LName = ""
        NID = ""
        CNO = ""
        TAdd = ""
        PAdd = ""
        Stage = ""

    End Function

#End Region

    Function FindLevel(ByVal Level As String, ByVal Stage As String)

    End Function

End Class
