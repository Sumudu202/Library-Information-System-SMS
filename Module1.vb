Module Module1
    Public CurrentUser As LogginUser

    'Public sqlconn As clsDb
    Sub main()
        Dim LogginForm As New frmlogging
        LogginForm.ShowDialog()
    End Sub

End Module
