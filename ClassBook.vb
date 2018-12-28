Imports Microsoft.ApplicationBlocks.Data
Imports Library.LogginUser
Imports System.Data.SqlClient

Public Class Book
    Public Shared ISBN As String
    Dim callNo As String
    Dim author1Id As Integer
    Dim author2Id As Integer
    Dim author3Id As Integer
    Dim title As String
    Dim language As String
    Dim edition As String
    Dim pagination As Integer
    Dim subject As String
    Dim accMeterials As String
    Dim pubId As Int16
    Dim pubDate As Date
    Dim dept As String
    Dim regDate As Date
    Dim kwds As String
    Dim noOfCopies As Byte

#Region "Add New Book"

    Public Sub addNewBook(ByVal bookISBN As String, ByVal callNo As String, ByVal title As String, ByVal subject As String, ByVal author1 As String, ByVal author2 As String, ByVal author3 As String, ByVal publisher As String, ByVal language As String, ByVal edition As String, ByVal pagination As Integer, ByVal datePublished As Date, ByVal noOfCopies As Byte, ByVal keyWords As String, ByVal dept As String, ByVal regDate As Date, ByVal accMeterials As String)

            ISBN = bookISBN
            Dim auId As Integer
            pubId = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select pubID from Publisher where pubName='" & publisher & "'")
            author1Id = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where auName='" & author1 & "' and subjects like '%" & subject & "%'")

        If pubId = 0 Or author1Id = 0 Then
            If pubId = 0 Then
                MessageBox.Show("Publisher is not registered!", "Verify Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If author1Id = 0 Then
                MessageBox.Show("Author is not registered or does not match", "Verify Author", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            If author2 <> "" Then
                author2Id = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorId from author where auName='" & author2 & "' and subjects like '%" & subject & "%'")
                If author2Id = 0 Then
                    MessageBox.Show("Author is not registered or does not match", "Verify Author", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf author3 <> "" Then
                    author3Id = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select authorID from author where auName='" & author3 & "' and subjects like '%" & subject & "%'")
                    If author3Id = 0 Then
                        MessageBox.Show("Author is not registered or does not match", "Verify Author", MessageBoxButtons.YesNo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

            Dim trans As SqlTransaction = Nothing
            Try
                sqlconn.Open()
                auId = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(auId) from Book ")
                If auId = 0 Then
                    auId = 1
                Else
                    auId = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select max(auId) from Book ")
                    auId += 1
                End If

                trans = sqlconn.BeginTransaction()
                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into Book values('" & bookISBN & "','" & callNo & "','" & auId & "','" & title & "','" & language & "','" & edition & "','" & subject & "','" & pagination & "','" & accMeterials & "','" & keyWords & "',1,'" & pubId & "','" & datePublished & "','" & dept & "','" & regDate & "')")
                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, " insert into BookCopy(ISBN,copyNo,availability,enteredDate) values('" & ISBN & "', 1 ,0,'" & regDate & "')")
                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into BookAuthors values('" & bookISBN & "','" & auId & "','" & author1Id & "')")

                If author2Id <> 0 Then
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into BookAuthors values('" & bookISBN & "','" & auId & "','" & author2Id & "')")
                End If
                If author3Id <> 0 Then
                    SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into BookAuthors values('" & bookISBN & "','" & auId & "','" & author3Id & "')")
                End If
                trans.Commit()
                MessageBox.Show("Record is Updated", "Book Registration Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                trans.Rollback()

            Finally
                sqlconn.Close()
                If Not trans Is Nothing Then trans.Dispose()
                sqlconn.Close()
            End Try
        End If

    End Sub

#End Region

#Region "GetNoOfPages"

    Function getNoOfPages(ByVal bookISBN) As Integer

        Return (SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select pagination from book where ISBN='" & bookISBN & "'"))

    End Function

#End Region

End Class
