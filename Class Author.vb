
Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class Class_Author

#Region "Add Author"
    Function AddNew(ByVal Name, ByVal Subjects, ByVal ConNo, ByVal Address, ByVal City, ByVal Country)
        Try
            SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into Author(auName,subjects,contactNo,address,city,country) values(Name,Subjects,ConNo,Address,City,Country)")
            MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try
    End Function
#End Region


End Class
