Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class frmBookRegistration
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
    Friend WithEvents sqlcon As System.Data.SqlClient.SqlConnection
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTitle As System.Windows.Forms.TextBox
    Friend WithEvents tbISBN As System.Windows.Forms.TextBox
    Friend WithEvents tbAccNo As System.Windows.Forms.TextBox
    Friend WithEvents tbPagination As System.Windows.Forms.TextBox
    Friend WithEvents tbCallNo As System.Windows.Forms.TextBox
    Friend WithEvents tbEdition As System.Windows.Forms.TextBox
    Friend WithEvents tbLanguage As System.Windows.Forms.TextBox
    Friend WithEvents tbSubject As System.Windows.Forms.TextBox
    Friend WithEvents tblName1 As System.Windows.Forms.TextBox
    Friend WithEvents tbfName3 As System.Windows.Forms.TextBox
    Friend WithEvents tbfName2 As System.Windows.Forms.TextBox
    Friend WithEvents tbfName1 As System.Windows.Forms.TextBox
    Friend WithEvents tblName3 As System.Windows.Forms.TextBox
    Friend WithEvents tblName2 As System.Windows.Forms.TextBox
    Friend WithEvents tbDate As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbKeyWord1 As System.Windows.Forms.TextBox
    Friend WithEvents tbKeyWord3 As System.Windows.Forms.TextBox
    Friend WithEvents tbKeyWord2 As System.Windows.Forms.TextBox
    Friend WithEvents tbAdd As System.Windows.Forms.Button
    Friend WithEvents tbExit As System.Windows.Forms.Button
    Friend WithEvents tbClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.tbTitle = New System.Windows.Forms.TextBox
        Me.tbISBN = New System.Windows.Forms.TextBox
        Me.tbAccNo = New System.Windows.Forms.TextBox
        Me.tbPagination = New System.Windows.Forms.TextBox
        Me.sqlcon = New System.Data.SqlClient.SqlConnection
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tblName3 = New System.Windows.Forms.TextBox
        Me.tblName2 = New System.Windows.Forms.TextBox
        Me.tblName1 = New System.Windows.Forms.TextBox
        Me.tbfName3 = New System.Windows.Forms.TextBox
        Me.tbfName2 = New System.Windows.Forms.TextBox
        Me.tbfName1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbCallNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbEdition = New System.Windows.Forms.TextBox
        Me.tbLanguage = New System.Windows.Forms.TextBox
        Me.tbSubject = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbName = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tbKeyWord1 = New System.Windows.Forms.TextBox
        Me.tbKeyWord3 = New System.Windows.Forms.TextBox
        Me.tbKeyWord2 = New System.Windows.Forms.TextBox
        Me.tbAdd = New System.Windows.Forms.Button
        Me.tbClear = New System.Windows.Forms.Button
        Me.tbExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(24, 32)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(78, 23)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Accession No"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl5
        '
        Me.lbl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(24, 256)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(78, 23)
        Me.lbl5.TabIndex = 2
        Me.lbl5.Text = "Pagination"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(24, 144)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(78, 23)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "Title"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(24, 72)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(78, 23)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "ISBN No"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(112, 144)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(160, 20)
        Me.tbTitle.TabIndex = 7
        Me.tbTitle.Text = ""
        '
        'tbISBN
        '
        Me.tbISBN.Location = New System.Drawing.Point(112, 72)
        Me.tbISBN.Name = "tbISBN"
        Me.tbISBN.Size = New System.Drawing.Size(160, 20)
        Me.tbISBN.TabIndex = 8
        Me.tbISBN.Text = ""
        '
        'tbAccNo
        '
        Me.tbAccNo.Location = New System.Drawing.Point(112, 32)
        Me.tbAccNo.Name = "tbAccNo"
        Me.tbAccNo.Size = New System.Drawing.Size(160, 20)
        Me.tbAccNo.TabIndex = 9
        Me.tbAccNo.Text = ""
        '
        'tbPagination
        '
        Me.tbPagination.Location = New System.Drawing.Point(112, 256)
        Me.tbPagination.Name = "tbPagination"
        Me.tbPagination.Size = New System.Drawing.Size(160, 20)
        Me.tbPagination.TabIndex = 10
        Me.tbPagination.Text = ""
        '
        'sqlcon
        '
        Me.sqlcon.ConnectionString = "workstation id=NIROSHA;packet size=4096;user id=sa;initial catalog=Library;persis" & _
        "t security info=True;password=sa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tblName3)
        Me.GroupBox1.Controls.Add(Me.tblName2)
        Me.GroupBox1.Controls.Add(Me.tblName1)
        Me.GroupBox1.Controls.Add(Me.tbfName3)
        Me.GroupBox1.Controls.Add(Me.tbfName2)
        Me.GroupBox1.Controls.Add(Me.tbfName1)
        Me.GroupBox1.Location = New System.Drawing.Point(288, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 112)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Authors  Details"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblName3
        '
        Me.tblName3.Location = New System.Drawing.Point(233, 80)
        Me.tblName3.Name = "tblName3"
        Me.tblName3.Size = New System.Drawing.Size(136, 20)
        Me.tblName3.TabIndex = 5
        Me.tblName3.Text = ""
        '
        'tblName2
        '
        Me.tblName2.Location = New System.Drawing.Point(233, 48)
        Me.tblName2.Name = "tblName2"
        Me.tblName2.Size = New System.Drawing.Size(136, 20)
        Me.tblName2.TabIndex = 4
        Me.tblName2.Text = ""
        '
        'tblName1
        '
        Me.tblName1.Location = New System.Drawing.Point(233, 16)
        Me.tblName1.Name = "tblName1"
        Me.tblName1.Size = New System.Drawing.Size(136, 20)
        Me.tblName1.TabIndex = 3
        Me.tblName1.Text = ""
        '
        'tbfName3
        '
        Me.tbfName3.Location = New System.Drawing.Point(49, 80)
        Me.tbfName3.Name = "tbfName3"
        Me.tbfName3.Size = New System.Drawing.Size(136, 20)
        Me.tbfName3.TabIndex = 2
        Me.tbfName3.Text = ""
        '
        'tbfName2
        '
        Me.tbfName2.Location = New System.Drawing.Point(49, 48)
        Me.tbfName2.Name = "tbfName2"
        Me.tbfName2.Size = New System.Drawing.Size(136, 20)
        Me.tbfName2.TabIndex = 1
        Me.tbfName2.Text = ""
        '
        'tbfName1
        '
        Me.tbfName1.Location = New System.Drawing.Point(49, 16)
        Me.tbfName1.Name = "tbfName1"
        Me.tbfName1.Size = New System.Drawing.Size(136, 20)
        Me.tbfName1.TabIndex = 0
        Me.tbfName1.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Edition"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Language"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCallNo
        '
        Me.tbCallNo.Location = New System.Drawing.Point(112, 104)
        Me.tbCallNo.Name = "tbCallNo"
        Me.tbCallNo.Size = New System.Drawing.Size(160, 20)
        Me.tbCallNo.TabIndex = 17
        Me.tbCallNo.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Call No"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbEdition
        '
        Me.tbEdition.Location = New System.Drawing.Point(112, 224)
        Me.tbEdition.Name = "tbEdition"
        Me.tbEdition.Size = New System.Drawing.Size(160, 20)
        Me.tbEdition.TabIndex = 19
        Me.tbEdition.Text = ""
        '
        'tbLanguage
        '
        Me.tbLanguage.Location = New System.Drawing.Point(112, 184)
        Me.tbLanguage.Name = "tbLanguage"
        Me.tbLanguage.Size = New System.Drawing.Size(160, 20)
        Me.tbLanguage.TabIndex = 20
        Me.tbLanguage.Text = ""
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(112, 296)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(160, 20)
        Me.tbSubject.TabIndex = 26
        Me.tbSubject.Text = ""
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Subject"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbDate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbName)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 64)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Publisher Details"
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(264, 24)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(112, 20)
        Me.tbDate.TabIndex = 12
        Me.tbDate.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(216, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Date "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(72, 24)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(112, 20)
        Me.tbName.TabIndex = 0
        Me.tbName.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbKeyWord1)
        Me.GroupBox3.Controls.Add(Me.tbKeyWord3)
        Me.GroupBox3.Controls.Add(Me.tbKeyWord2)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 64)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Key Words"
        '
        'tbKeyWord1
        '
        Me.tbKeyWord1.Location = New System.Drawing.Point(8, 24)
        Me.tbKeyWord1.Name = "tbKeyWord1"
        Me.tbKeyWord1.Size = New System.Drawing.Size(112, 20)
        Me.tbKeyWord1.TabIndex = 3
        Me.tbKeyWord1.Text = ""
        '
        'tbKeyWord3
        '
        Me.tbKeyWord3.Location = New System.Drawing.Point(272, 28)
        Me.tbKeyWord3.Name = "tbKeyWord3"
        Me.tbKeyWord3.Size = New System.Drawing.Size(112, 20)
        Me.tbKeyWord3.TabIndex = 2
        Me.tbKeyWord3.Text = ""
        '
        'tbKeyWord2
        '
        Me.tbKeyWord2.Location = New System.Drawing.Point(140, 26)
        Me.tbKeyWord2.Name = "tbKeyWord2"
        Me.tbKeyWord2.Size = New System.Drawing.Size(112, 20)
        Me.tbKeyWord2.TabIndex = 1
        Me.tbKeyWord2.Text = ""
        '
        'tbAdd
        '
        Me.tbAdd.Location = New System.Drawing.Point(728, 64)
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.TabIndex = 29
        Me.tbAdd.Text = "&Add"
        '
        'tbClear
        '
        Me.tbClear.Location = New System.Drawing.Point(728, 172)
        Me.tbClear.Name = "tbClear"
        Me.tbClear.TabIndex = 30
        Me.tbClear.Text = "&Clear"
        '
        'tbExit
        '
        Me.tbExit.Location = New System.Drawing.Point(728, 280)
        Me.tbExit.Name = "tbExit"
        Me.tbExit.TabIndex = 31
        Me.tbExit.Text = "&Exit"
        '
        'frmBookRegistration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(816, 350)
        Me.Controls.Add(Me.tbExit)
        Me.Controls.Add(Me.tbClear)
        Me.Controls.Add(Me.tbAdd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tbSubject)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbLanguage)
        Me.Controls.Add(Me.tbEdition)
        Me.Controls.Add(Me.tbCallNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbPagination)
        Me.Controls.Add(Me.tbAccNo)
        Me.Controls.Add(Me.tbISBN)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "frmBookRegistration"
        Me.Text = "frmBookRegistration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub tlbBook_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbBook.ButtonClick
    '    If e.Button.Text = "&New" Then
    '        tbBookId.Visible = True
    '        tbTitle.Visible = True
    '        lblBookId.Visible = True
    '        lblTitle.Visible = True
    '    Else
    '        If e.Button.Text = "&Edit" Then
    '            tbBookId.Visible = True
    '            lblBookId.Visible = True
    '        End If
    '    End If
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    ' String variable that will hold the returned result
    '    ' Dim productName As String

    '    ' SqlConnection that will be used to execute the sql commands
    '    'Dim connection As SqlCon = Nothing
    '    Dim sqlcon As SqlConnection

    '    Try
    '        sqlcon.Open()

    '    Catch ex As Exception
    '        MessageBox.Show("The connection with the database can´t be established", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '    ' Call ExecuteScalar static method of SqlHelper class that returns an Object. Then cast the return value to string.
    '    ' We pass in database connection string, command type, stored procedure name, and a "1" as value for productID SqlParameter
    '    SqlHelper.ExecuteScalar(sqlcon, CommandType.StoredProcedure, "addBook")

    '    ' Display results in text box
    '    'txtResults.Text = ProductName

    '    'Catch ex As Exception
    '    '    Dim errMessage As String = ""
    '    '    Dim tempException As Exception = ex

    '    '    While (Not tempException Is Nothing)
    '    '        errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
    '    '        tempException = tempException.InnerException
    '    '    End While

    '    '    MessageBox.Show(String.Format("There are some problems while trying to use the Data Access Application block, please check the following error messages: {0}" _
    '    '      + Environment.NewLine + "This test requires some modifications to the Northwind database. Please make sure the database has been initialized using the SetUpDataBase.bat database script, or from the  Install Quickstart option on the Start menu.", errMessage), _
    '    '      "Application error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    'Finally
    '    '    If Not connection Is Nothing Then
    '    '        CType(connection, IDisposable).Dispose()
    '    '    End If
    '    'End Try
    '    'finally
    '    '    sqlcon.Close()

    'End Sub
    Dim constr As String = "workstation id=NIROSHA;packet size=4096;user id=sa;initial catalog=Library;persist security info=True;password=sa"
    Private Function GetConnection(ByVal connectionString As String) As SqlConnection
        Dim connection As New SqlConnection(connectionString)

        connection.Open()

        Return connection
    End Function
    Private Sub tbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAdd.Click
        Dim connection As SqlConnection = Nothing

        Try
            Try
                connection = GetConnection(constr)
            Catch ex As Exception
                MessageBox.Show("The connection with the database can´t be established", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Dim trans As SqlTransaction = Nothing
            Try
                trans = connection.BeginTransaction()

                ' Establish command parameters

                ' @ISBN (From Account)
                Dim ISBNNo As New SqlParameter("@ISBN", SqlDbType.Char, 10)
                ISBNNo.Value = tbISBN.Text

                ' @subject (To Account)
                Dim maniSubject As New SqlParameter("@subject", SqlDbType.VarChar, 50)
                maniSubject.Value = tbSubject.Text

                '' @Money (Credit amount)
                'Dim paramCreditAmount As New SqlParameter("@Amount", SqlDbType.Money)
                'paramCreditAmount.Value = 500

                '' @Money (Debit amount)
                'Dim paramDebitAmount As New SqlParameter("@Amount", SqlDbType.Money)
                'paramDebitAmount.Value = 500

                Try
                    ' Perform the debit operation
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "addBook", ISBNNo, maniSubject)

                    '' Perform the credit operation
                    'SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "Credit", paramToAcc, paramCreditAmount)

                    trans.Commit()
                    ' If we got this far, transfer completed without errors being thrown
                    tbAccNo.Text = "Transfer Completed"

                Catch ex As Exception
                    ' throw an exception
                    trans.Rollback()
                    tbAccNo.Text = "Transfer Error"
                    Throw ex
                End Try
            Finally
                If Not trans Is Nothing Then trans.Dispose()
            End Try
        Catch ex As Exception
            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("There are some problems while trying to use the Data Access Application block, please check the following error messages: {0}" _
              + Environment.NewLine + "This test requires some modifications to the Northwind database. Please make sure the database has been initialized using the SetUpDataBase.bat database script, or from the  Install Quickstart option on the Start menu.", errMessage), _
              "Application error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If Not connection Is Nothing Then
                CType(connection, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub frmBookRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbClear.Click

    End Sub
End Class
