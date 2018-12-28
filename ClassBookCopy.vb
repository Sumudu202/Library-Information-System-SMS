
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports Library.LogginUser

Public Class ClassBookCopy
    Inherits Book

    Private AccessionNo As String
    Private CopyNo As String
    Private Status As String
    Private Availability As String
    Private EnteredDate As Date
    Private maxCopyNo As Integer

#Region "Add New Copy"

    Public Function addNewCopy(ByVal bISBN As String, ByVal section As String, ByVal entDate As Date)

        Dim Max As Integer
        Try
            sqlconn.Open()
            maxCopyNo = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select  count(ISBN) from BookCopy where ISBN='" & bISBN & "'")
            If maxCopyNo = 0 Then
                MessageBox.Show("The Book is not Registered", "Error")
            ElseIf maxCopyNo = 1 Then
                Status = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(status) from BookCopy where ISBN='" & bISBN & "'")
                If Status = 0 Then
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update BookCopy set status='" & section & "' where ISBN='" & bISBN & "'")
                    MessageBox.Show("Record is Updated", "Updated")
                Else
                    Max = maxCopyNo + 1
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & bISBN & "'")
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,availability,enteredDate) values('" & bISBN & "','" & Max & "','" & section & "',1,'" & entDate & "')")
                    MessageBox.Show("Record is Updated", "Book Copy Registration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            Else
                Max = maxCopyNo + 1
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & bISBN & "'")
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,availability,enteredDate) values('" & bISBN & "','" & Max & "','" & section & "',1,'" & entDate & "')")
                MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try

    End Function

    Public Function addNewCopy(ByVal section As String, ByVal entDate As Date)

        Dim Max As Integer
        Try
            sqlconn.Open()
            maxCopyNo = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select  count(ISBN) from BookCopy where ISBN='" & Book.ISBN & "'")
            If maxCopyNo = 1 Then
                Status = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(status) from BookCopy where ISBN='" & Book.ISBN & "'")
                If Status = 0 Then
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update BookCopy set status='" & section & "' where ISBN='" & Book.ISBN & "'")
                Else
                    Max = maxCopyNo + 1
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & Book.ISBN & "'")
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,availability,enteredDate) values('" & Book.ISBN & "','" & Max & "','" & section & "',1,'" & entDate & "')")
                End If
                MessageBox.Show("Record is Updated ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Else
                Max = maxCopyNo + 1
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & Book.ISBN & "'")
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,availability,enteredDate) values('" & Book.ISBN & "','" & Max & "','" & section & "',1,'" & entDate & "')")
                MessageBox.Show("Book Copy is Succesfully Added", "Book Copy Registration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try
    End Function

#End Region

#Region "Delete Book Copy"

    Function RemoveBookCopy_AccNo(ByVal AccNo As String)

        Dim avl1 As Integer = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count (accessionNo) from BookCopy where accessionNo='" & AccNo & "'")
        If avl1 > 0 Then

            Dim Avl2 As Boolean = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select availability from BookCopy where accessionNo='" & AccNo & "'")
            If Avl2 = False Then
                MessageBox.Show("The Book Has to Return", "Verify Book", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Dim bISBN As String = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select ISBN from BookCopy where accessionNo='" & AccNo & "'")
                Dim count As Integer = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(accessionNo) from BookCopy where ISBN= '" & bISBN & "'")

                If count = 0 Then
                    MessageBox.Show("There is no book copy to remove", "Verify Book Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf count = 1 Then
                    MessageBox.Show("There is only one copy! you can't remove the Book", "Remove Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Function

                ElseIf count > 1 Then
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & count - 1 & "' where ISBN='" & bISBN & "' ")
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "delete BookCopy where accessionNo='" & AccNo & "'")
                    MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AccNo = ""
                End If
            End If

        Else
            MessageBox.Show("Not Available", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Function

#End Region

#Region "Search Book"

    Function Search_By_ISBN(ByVal BISBN As String, ByVal DG As DataGrid)

        DG.Visible = True
        Dim Count, i As Integer
        Dim sqlDs As New DataSet
        sqlDs.DataSetName = "Result"
        Try
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(accessionNo) from BookCopy where ISBN='" & BISBN & "'")

            If Count = 0 Then
                MessageBox.Show("No Result", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function
            Else
                Dim sqlDA As New SqlDataAdapter("Select b.Title,b.ISBN,bc.accessionNo,bc.status,bc.availability from Book as b,BookCopy as bc where b.ISBN='" & BISBN & "' and b.ISBN=bc.ISBN", sqlconn)
                sqlDA.Fill(sqlDs)
                DG.DataSource = sqlDs
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Function Search_By_Author(ByVal Author As String, ByVal DG As DataGrid)

        DG.Visible = True
        Try
            Dim sqlDs As New DataSet
            sqlDs.DataSetName = "Result"
            Dim sqlDA As New SqlDataAdapter("select b.Title,b.ISBN,bc.Accessionno,bc.Status,bc.Availability from Book as b,BookCopy as bc where b.ISBN=bc.ISBN and b.ISBN in(select ISBN from BookAuthors as ba,Author as a where a.authorId=ba.authorId and a.auName='" & Author & "')", sqlconn)
            sqlDA.Fill(sqlDs)
            DG.DataSource = sqlDs

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Function Search_By_Title(ByVal Title As String, ByVal DG As DataGrid)

        DG.Visible = True
        Try
            Dim sqlDs As New DataSet
            sqlDs.DataSetName = "Result"
            Dim sqlDA As New SqlDataAdapter("select b.title,b.ISBN,bc.accessionno,bc.status,bc.availability from Book as b,BookCopy as bc where b.ISBN=bc.ISBN and b.ISBN in(select ISBN from Book where Title='" & Title & "')", sqlconn)
            sqlDA.Fill(sqlDs)
            DG.DataSource = sqlDs
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function


    Function Search_By_AccNo(ByVal AccNo As String, ByVal DG As DataGrid)

        DG.Visible = True
        Dim ISBN As String
        Try
            ISBN = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select ISBN from BookCopy where accessionNo='" & AccNo & "'")
            Search_By_ISBN(ISBN, DG)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Function Search_By_KWD(ByVal KWD As String, ByVal DG As DataGrid)

        DG.Visible = True
        Try
            Dim sqlDs As New DataSet
            sqlDs.DataSetName = "Result"
            Dim sqlDA As New SqlDataAdapter("select b.title,b.ISBN,bc.accessionno,bc.status,bc.availability from Book as b,BookCopy as bc where b.ISBN=bc.ISBN and b.ISBN in(select ISBN from Book where kwds like '%" & KWD & "%')", sqlconn)
            sqlDA.Fill(sqlDs)
            DG.DataSource = sqlDs
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

#End Region

#Region "Lend"

    Function Lend(ByVal AccNo As String, ByVal MemID As String)

        Dim Lended, Llended, Lallowed, Rlended, Rallowed As Integer
        Lended = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "Select count(accessionNo) from BorrowedCopy where accessionNo='" & AccNo & "' and returned='" & 0 & "'")
        If Lended = 0 Then
            Dim Section As String
            Section = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select status from BookCopy where accessionNo='" & AccNo & "'")

            If Section = "L" Then
                Llended = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(a.status)from bookCopy as a,borrowedCopy as b where a.accessionNo=b.accessionNo and b.memberID='" & MemID & "' and returned=0 and status='L'")
                Lallowed = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select noOfBooks from BorrowingType as a, MemberBorrowingType as b where a.type=b.type and a.type like '%L' and memberId='" & MemID & "'")
                If Llended = Lallowed Then
                    MsgBox("Has Lended Maximum No of lending Books")
                    Exit Function
                End If

            ElseIf Section = "SR" Then
                Rlended = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(a.status)from bookCopy as a,borrowedCopy as b where a.accessionNo=b.accessionNo and b.memberID='" & LogginUser.MemberID & "' and returned=0 and status='SR'")
                Rallowed = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select noOfBooks from BorrowingType as a, MemberBorrowingType as b where a.type=b.type and a.type like '%SR' and memberId='" & LogginUser.MemberID & "'")
                If Rlended = Rallowed Then
                    MsgBox("Has Lended Maximum No of Reference Books")
                    Exit Function
                End If

            ElseIf Section = "PR" Then
                MessageBox.Show("Can Not Lend a Permenent Reference Book", "Verify Book Copy", MessageBoxButtons.OK)
                Exit Function
            End If

            Dim Days As Integer
            Days = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select distinct NoOfDays from BorrowingType as a,MemberBorrowingType as b,BookCopy as c where a.type=b.type and b.memberId='" & MemID & "' and a.type like '%" & Section & "' ")
            Dim DueDate = System.DateTime.Today.AddDays(Days)

            Dim Trans As SqlTransaction = Nothing
            Try
                sqlconn.Open()
                Trans = sqlconn.BeginTransaction()
                Try
                    SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "update BookCopy set availability='0' where accessionNo='" & AccNo & "' ")
                    SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, " insert into BorrowedCopy values('" & AccNo & "','" & MemID & "','" & DateTime.Today & "','" & DueDate & "','" & 0 & "')")

                    Trans.Commit()
                    MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    Trans.Rollback()
                    MessageBox.Show(ex.Message)
                    Throw ex
                End Try
            Finally
                If Not Trans Is Nothing Then Trans.Dispose()
                If Not sqlconn Is Nothing Then
                    sqlconn.Close()
                End If
            End Try

        Else
            MessageBox.Show("Sorry,Book Is Already Borrowed", "Verify Borrowing", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Function

#End Region

#Region "Return"

    Function Retn(ByVal AccNo As String)

        Dim Trans As SqlTransaction = Nothing
        Try
            sqlconn.Open()
            Trans = sqlconn.BeginTransaction()
            Try
                SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, "update BookCopy set availability='1' where accessionNo='" & AccNo & "'")
                SqlHelper.ExecuteNonQuery(Trans, CommandType.Text, " delete BorrowedCopy where accessionNo='" & AccNo & "'")

                Trans.Commit()
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                Trans.Rollback()
                MessageBox.Show(ex.Message)
                Throw ex
            End Try
        Finally
            If Not Trans Is Nothing Then Trans.Dispose()
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try

    End Function

#End Region

End Class
