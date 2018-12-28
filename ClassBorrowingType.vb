Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Public Class ClassBorrowingType

    Public LType, LDisc, LNo_of_Days, LNo_of_Books, SRType, SRDisc, SRNo_of_Days, SRNo_of_Books As String
    Public Sec As Boolean

#Region "Add Borrowing Type"

    Public Sub AddType(ByVal TypeL As String, ByVal DecL As String, ByVal LBooks As String, ByVal LDays As String, ByVal TypeSR As String, ByVal DecSR As String, ByVal SRBooks As String, ByVal SRDays As String)

        Dim trans As SqlTransaction = Nothing
        Try
            sqlconn.Open()
            trans = sqlconn.BeginTransaction()
            Try
                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into BorrowingType values('" & TypeL & "','" & DecL & "','" & LBooks & "','" & LDays & "')")
                SqlHelper.ExecuteNonQuery(trans, CommandType.Text, "insert into BorrowingType values('" & TypeSR & "','" & DecSR & "','" & SRBooks & "','" & SRDays & "')")
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

    End Sub

#End Region

#Region "Update Type"

    Public Sub Update_Member_Type(ByVal Type As String, ByVal Books As String, ByVal Days As String)

        If Type = "" Or Books = "" Or Days = "" Then
            MessageBox.Show("Enter the Details", "Verify Type", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "Update BorrowingType set noOfBooks='" & Books & "' , noOfDays='" & Days & "' where type='" & Type & "'")
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If

    End Sub

#End Region

#Region "View Level"

    Public Sub View_Level(ByVal Type As String)

        Sec = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "SELECT count(type) FROM BorrowingType where type like '%L' and type='" & Type & "'")

        Dim stSQL1 As String = "SELECT * FROM BorrowingType where type='" & Type & "'"
        Dim Comm1 As New SqlCommand(stSQL1, sqlconn)
        Dim myReader1 As SqlDataReader
        Try
            sqlconn.Open()
            myReader1 = Comm1.ExecuteReader

            If Sec = True Then
                While (myReader1.Read())

                    LType = myReader1("type")
                    LDisc = myReader1("discription")
                    LNo_of_Books = myReader1("noOfBooks")
                    LNo_of_Days = myReader1("noOfDays")

                End While
                SRType = ""
                SRDisc = ""
                SRNo_of_Books = ""
                SRNo_of_Days = ""

            Else
                While (myReader1.Read())

                    SRType = myReader1("type")
                    SRDisc = myReader1("discription")
                    SRNo_of_Books = myReader1("noOfBooks")
                    SRNo_of_Days = myReader1("noOfDays")

                End While
                LType = ""
                LDisc = ""
                LNo_of_Books = ""
                LNo_of_Days = ""
            End If

        Catch ex As Exception
        Finally
            myReader1.Close()
            sqlconn.Close()
        End Try

    End Sub

#End Region

End Class
