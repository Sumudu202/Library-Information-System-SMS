'Imports Library.baseclass
Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports Library.frmBookRegistration

Public Class frmBookCopyReg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tbISBN As System.Windows.Forms.TextBox
    Friend WithEvents ISBN As System.Windows.Forms.Label
    Friend WithEvents Sta As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dtpEntDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents EnteredDate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tbISBN = New System.Windows.Forms.TextBox
        Me.ISBN = New System.Windows.Forms.Label
        Me.Sta = New System.Windows.Forms.Label
        Me.EnteredDate = New System.Windows.Forms.Label
        Me.btnNew = New System.Windows.Forms.Button
        Me.dtpEntDate = New System.Windows.Forms.DateTimePicker
        Me.tp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tbISBN
        '
        Me.tbISBN.AutoSize = False
        Me.tbISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbISBN.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbISBN.Location = New System.Drawing.Point(74, 8)
        Me.tbISBN.Name = "tbISBN"
        Me.tbISBN.Size = New System.Drawing.Size(190, 20)
        Me.tbISBN.TabIndex = 0
        Me.tbISBN.Text = ""
        '
        'ISBN
        '
        Me.ISBN.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(16, 4)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(40, 23)
        Me.ISBN.TabIndex = 29
        Me.ISBN.Text = "ISBN"
        Me.ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sta
        '
        Me.Sta.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sta.Location = New System.Drawing.Point(16, 36)
        Me.Sta.Name = "Sta"
        Me.Sta.Size = New System.Drawing.Size(40, 23)
        Me.Sta.TabIndex = 28
        Me.Sta.Text = "Status"
        Me.Sta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnteredDate
        '
        Me.EnteredDate.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnteredDate.Location = New System.Drawing.Point(2, 68)
        Me.EnteredDate.Name = "EnteredDate"
        Me.EnteredDate.Size = New System.Drawing.Size(72, 23)
        Me.EnteredDate.TabIndex = 21
        Me.EnteredDate.Text = "Copy Entered Date"
        Me.EnteredDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(88, 104)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(64, 24)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "&Add"
        '
        'dtpEntDate
        '
        Me.dtpEntDate.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntDate.Location = New System.Drawing.Point(74, 71)
        Me.dtpEntDate.Name = "dtpEntDate"
        Me.dtpEntDate.Size = New System.Drawing.Size(190, 21)
        Me.dtpEntDate.TabIndex = 2
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Items.AddRange(New Object() {"L", "SR", "PR", "R"})
        Me.cmbStatus.Location = New System.Drawing.Point(74, 38)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(190, 23)
        Me.cmbStatus.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(176, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Cancel"
        '
        'frmBookCopyReg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(272, 134)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.dtpEntDate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.tbISBN)
        Me.Controls.Add(Me.ISBN)
        Me.Controls.Add(Me.Sta)
        Me.Controls.Add(Me.EnteredDate)
        Me.Name = "frmBookCopyReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Book Copy"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Add Book Copy"
    'Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

    '    Dim maxCopyNo As Integer
    '    Dim status As Integer
    '    Dim status1 As Integer
    '    Dim Max As Int16
    '    Try
    '        sqlconn.Open()

    '        If tbISBN.Visible = True Then

    '            maxCopyNo = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select  count(ISBN) from BookCopy where ISBN='" & tbISBN.Text & "'")
    '            If maxCopyNo = 0 Then
    '                MessageBox.Show("The Book is not Registered", "Error")

    '            ElseIf maxCopyNo = 1 Then
    '                status = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(status) from BookCopy where ISBN='" & tbISBN.Text & "'")
    '                MsgBox(status)
    '                If status = 0 Then
    '                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update BookCopy set status='" & cmbStatus.Text & "' where ISBN='" & tbISBN.Text & "'")
    '                    MessageBox.Show("Record is Updated", "Updated")
    '                    Me.Clear()
    '                Else
    '                    Max = maxCopyNo + 1
    '                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & tbISBN.Text & "'")
    '                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,enteredDate) values('" & tbISBN.Text & "','" & Max & "','" & cmbStatus.Text & "','" & dtpEntDate.Value & "')")
    '                    MessageBox.Show("Book Copy is Succesfully Added", "Book Copy Registration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '                    Me.Clear()
    '                End If

    '            Else
    '                Max = maxCopyNo + 1
    '                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & tbISBN.Text & "'")
    '                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,enteredDate) values('" & tbISBN.Text & "','" & Max & "','" & cmbStatus.Text & "','" & dtpEntDate.Value & "')")
    '                MessageBox.Show("Book Copy is Succesfully Added", "Book Copy Registration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '                Me.Clear()
    '            End If

    '        Else
    '            maxCopyNo = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select  count(copyNo) from BookCopy where ISBN='" & CurrentUser.ISBN & "'")
    '            If maxCopyNo = 1 Then
    '                status1 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(status) from BookCopy where ISBN='" & CurrentUser.ISBN & "'")
    '                If status1 = 0 Then
    '                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update BookCopy set status='" & cmbStatus.Text & "' where ISBN='" & CurrentUser.ISBN & "'")
    '                Else
    '                    Max = maxCopyNo + 1
    '                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & CurrentUser.ISBN & "'")
    '                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,enteredDate) values('" & CurrentUser.ISBN & "','" & Max & "','" & cmbStatus.Text & "','" & dtpEntDate.Value & "')")
    '                End If
    '                MessageBox.Show("Record is Updated ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    '            Else
    '                Max = maxCopyNo + 1
    '                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Book set noOfCopies='" & Max & "' where ISBN='" & CurrentUser.ISBN & "'")
    '                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into BookCopy(ISBN,copyNo,status,enteredDate) values('" & CurrentUser.ISBN & "','" & Max & "','" & cmbStatus.Text & "','" & dtpEntDate.Value & "')")
    '                MessageBox.Show("Book Copy is Succesfully Added", "Book Copy Registration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '                Me.Clear()
    '            End If
    '            End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        If Not sqlconn Is Nothing Then
    '            sqlconn.Close()
    '        End If
    '    End Try
    'End Sub
#End Region

#Region "Clear Fields"

    Sub Clear()
        tbISBN.Text = ""
        cmbStatus.Text = ""
    End Sub

#End Region

#Region "Add new copy"

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Dim Copy As New ClassBookCopy
        If tbISBN.Visible = True Then
            Copy.addNewCopy(tbISBN.Text, cmbStatus.Text, dtpEntDate.Value)
            Me.Clear()
        Else
            Copy.addNewCopy(cmbStatus.Text, dtpEntDate.Value)
            Me.Clear()
        End If

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
