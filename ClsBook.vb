Imports Microsoft.ApplicationBlocks.Data
Imports Library.LogginUser
Imports System.Data.SqlClient

Public Class Book
    ' Dim book() As SqlParameter = New SqlParameter(16) {}
    'book(0) = New SqlParameter("@ISBN", SqlDbType.VarChar, 25)
    'book(1) = New SqlParameter("@callNo", SqlDbType.VarChar, 10)
    'book(2) = New SqlParameter("@auther1Id", SqlDbType.VarChar, 25)
    'book(3) = New SqlParameter("@auther2Id", SqlDbType.VarChar, 25)
    'book(4) = New SqlParameter("@auther3Id", SqlDbType.VarChar, 25)
    'book(5) = New SqlParameter("@title", SqlDbType.VarChar, 100)
    'book(6) = New SqlParameter("@language", SqlDbType.VarChar, 50)
    'book(7) = New SqlParameter("@edition", SqlDbType.VarChar, 10)
    'book(8) = New SqlParameter("@pagination", SqlDbType.Int)
    'book(9) = New SqlParameter("@subject", SqlDbType.VarChar, 100)
    'book(10) = New SqlParameter("@accMeterials", SqlDbType.VarChar, 250)
    'book(11) = New SqlParameter("@pubId", SqlDbType.Char, 5)
    'book(12) = New SqlParameter("@pubDate", SqlDbType.DateTime)
    'book(13) = New SqlParameter("@regDate", SqlDbType.DateTime)
    'book(14) = New SqlParameter("@kwd1", SqlDbType.VarChar, 50)
    'book(15) = New SqlParameter("@kwd2", SqlDbType.VarChar, 50)
    'book(16) = New SqlParameter("@kwd3", SqlDbType.VarChar, 50)

        Dim ISBN As String
        Dim callNo As String
        Dim author1Id As String
        Dim author2Id As String
        Dim author3Id As String
        Dim title As String
        Dim language As String
        Dim edition As String
        Dim pagination As Integer
    'Dim subject As String
        Dim accMeterials As String
        Dim pubId As String
        Dim datePublished As Date
        Dim kwd1 As String
        Dim kwd2 As String
        Dim kwd3 As String
        Dim regDate As DateTime
        Dim noOfCopies As Byte

    Public Function addNewBook(ByVal ISBN As String, ByVal callNo As String, ByVal title As String, ByVal subject As String, ByVal author1 As String, ByVal author2 As String, ByVal author3 As String, ByVal publisher As String, ByVal language As String, ByVal edition As String, ByVal pagination As Integer, ByVal datePublished As Date, ByVal noOfCopies As Byte, ByVal keyWord1 As String, ByVal keyWord2 As String, ByVal keyWord3 As String, ByVal regDate As Date, ByVal accMeterials As String)
        '' CurrentUser.ISBN = tbISBN.Text
        '        sqlconn.Open()
        Dim AuId1 As Int16
        Dim AuId2 As Int16
        Dim AuId3 As Int16
        Dim PubID As Int16
        Dim x As Integer
        PubID = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select pubID from Publisher where pubName='" & publisher & "'")
        If PubID <> 0 Then
            AuId1 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where name='" & author1 & "' and subject='" & subject & "'")
            If AuId1 <> 0 Then
                If author2 <> "" Then
                    AuId2 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where name='" & author2 & "' and subject='" & subject & "'")
                    If AuId2 = 0 Then
                        x = MessageBox.Show("Author 2 is not registered Are you want to register the Author?", "Verify Author", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        If x = 6 Then
                            Dim AuthorForm As New frmAuthorReg
                            AuthorForm.Show()
                        End If
                        AuId2 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where name='" & author2 & "' and subject='" & subject & "'")

                        If author3 <> "" Then
                            AuId3 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where name='" & author3 & "' and subject='" & subject & "'")
                            If AuId3 = 0 Then
                                x = MessageBox.Show("Author 2 is not registered Are you want to register the Author?", "Verify Author", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                                If x = 6 Then
                                    Dim AuthorForm As New frmAuthorReg
                                    AuthorForm.Show()
                                End If
                                AuId3 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where name='" & author3 & "' and subject='" & subject & "'")
                            End If
                        End If
                    Else
                    End If
                End If

                Dim trans As SqlTransaction = Nothing
                Try
                    sqlconn.Open()
                    trans = sqlconn.BeginTransaction()

                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into Book(ISBN,callNo,author1Id,author2Id,author3Id,title,language,edition,subject,pagination,accMeterials,kwd1,kwd2,kwd3,noOfCopies,pubId,pubDate,regDate) values('" & ISBN & "','" & callNo & "','" & AuId1 & "','" & AuId2 & "','" & AuId3 & "','" & title & "','" & language & "','" & edition & "','" & subject & "','" & pagination & "','" & accMeterials & "','" & keyWord1 & "','" & keyWord2 & "','" & keyWord3 & "',1,'" & PubID & "','" & datePublished & "','" & regDate & "')")
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, " insert into BookCopy(ISBN,copyNo,enteredDate) values('" & ISBN & "', 1 ,'" & regDate & "')")
                    trans.Commit()

                    MessageBox.Show("Book Registration is sucessfully completed", "Member Registration Confermation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Me.ClearFields()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    trans.Rollback()
                Finally
                    sqlconn.Close()
                    If Not trans Is Nothing Then trans.Dispose()
                    sqlconn.Close()
                End Try
            Else
                MsgBox("Author 1 is not valid")
            End If
        Else
            MsgBox("Publisher is not registered")
        End If
    End Function
    Function removeBook(ByVal ISBN)

    End Function
    Function searchBook()

    End Function
    Function getNoOfPages(ByVal ISBN)

    End Function

End Class
