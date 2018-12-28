
Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class Class_Author

    Public AuthorID As Integer
    Public AuName, Subjects, ConNo, Add, City, Country As String

#Region "Add Author"

    Function AddNew(ByVal Name As String, ByVal Subjects As Object, ByVal ConNo As String, ByVal Address As String, ByVal City As String, ByVal Country As String)

        Dim Count As Boolean

        Try
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(authorId) from Author where auName='" & Name & "' and subjects='" & Subjects & "' and city='" & City & "'")
            If Count = False Then
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into Author(auName,subjects,contactNo,address,city,country) values('" & Name & "','" & Subjects & "','" & ConNo & "','" & Address & "','" & City & "','" & Country & "')")
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Author is a registered one", "Verify Author", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

#Region "Search Author"

    Public Sub SearchAuthor_By_AuID(ByVal AuID As Integer)

        AuthorID = AuID
        Dim Avl As Boolean = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "SELECT count(authorId) FROM Author where authorId='" & AuID & "'")
        If Avl = False Then
            MessageBox.Show("Re Enter the Author ID", "Verify Author", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim stSQL1 As String = "SELECT * FROM Author where authorId='" & AuID & "'"
            Dim Comm1 As New SqlCommand(stSQL1, sqlconn)
            Dim myReader1 As SqlDataReader
            Try
                sqlconn.Open()
                myReader1 = Comm1.ExecuteReader

                While (myReader1.Read())
                    AuName = myReader1("auName")
                    Subjects = myReader1("subjects")
                    ConNo = myReader1("contactNo")
                    Add = myReader1("address")
                    ConNo = myReader1("contactNo")
                    City = myReader1("city")
                    Country = myReader1("Country")
                End While

            Catch ex As Exception
            Finally
                myReader1.Close()
                sqlconn.Close()
        End Try
        End If

    End Sub

    Public Sub SearchAuthor_By_Name_Sub_City(ByVal Name As String, ByVal Subjs As String, ByVal Cty As String)

        Dim Avl As Boolean = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "SELECT count(authorId) FROM Author where auName='" & Name & "' and  subjects='" & Subjs & "' and city='" & Cty & "'")
        If Avl = False Then
            MessageBox.Show("Re Enter the Author ID", "Verify Author", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim stSQL1 As String = "SELECT * FROM Author where auName='" & Name & "' and subjects='" & Subjs & "' and city='" & Cty & "'"
            Dim Comm1 As New SqlCommand(stSQL1, sqlconn)

            Dim myReader1 As SqlDataReader
            Try
                sqlconn.Open()
                myReader1 = Comm1.ExecuteReader

                While (myReader1.Read())
                    AuthorID = myReader1("auName")
                    AuName = myReader1("auName")
                    Subjects = myReader1("subjects")
                    Add = myReader1("address")
                    ConNo = myReader1("contactNo")
                    City = myReader1("city")
                    Country = myReader1("Country")
                End While

            Catch ex As Exception
            Finally
                myReader1.Close()
                sqlconn.Close()
            End Try
        End If

    End Sub

#End Region

#Region "Update Author"

    Public Sub Update(ByVal Name As String, ByVal Subj As String, ByVal Cty As String, ByVal Cnt As String, ByVal Add As String, ByVal CNo As String)

        If Name = "" Or Subj = "" Then
            MessageBox.Show("Enter the Name and the Subjects", "Verify Author", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        Try
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Author set auName='" & Name & "',subjects='" & Subj & "', contactNo='" & CNo & "',address ='" & Add & "',city ='" & Cty & "',country='" & Cnt & "' where authorId='" & AuthorID & "'")
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                If Not sqlconn Is Nothing Then
                    sqlconn.Close()
                End If

            End Try

        End If

    End Sub

#End Region

End Class
