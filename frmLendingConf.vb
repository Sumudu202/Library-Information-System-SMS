Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmLendingConf
    Inherits System.Windows.Forms.Form
    Public Llended, Rlended, Lallow, Rallow As Integer

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
    Friend WithEvents tbMemId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUnret As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents sqlDa2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOdvBooks As System.Windows.Forms.Button
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents btnChkRec As System.Windows.Forms.Button
    Friend WithEvents tbSummary As System.Windows.Forms.TextBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbMemId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgUnret = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.sqlDa2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.tbSummary = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOdvBooks = New System.Windows.Forms.Button
        Me.btnLoan = New System.Windows.Forms.Button
        Me.btnChkRec = New System.Windows.Forms.Button
        Me.ep = New System.Windows.Forms.ErrorProvider
        CType(Me.dgUnret, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMemId
        '
        Me.tbMemId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMemId.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMemId.Location = New System.Drawing.Point(128, 8)
        Me.tbMemId.Name = "tbMemId"
        Me.tbMemId.TabIndex = 0
        Me.tbMemId.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Member ID"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Member ID"
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Accession No"
        Me.DataGridTextBoxColumn2.MappingName = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Lended Date"
        Me.DataGridTextBoxColumn3.MappingName = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Due Date"
        Me.DataGridTextBoxColumn4.MappingName = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'dgUnret
        '
        Me.dgUnret.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dgUnret.CaptionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgUnret.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.dgUnret.CaptionText = "Unreturned Books"
        Me.dgUnret.DataMember = ""
        Me.dgUnret.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgUnret.Location = New System.Drawing.Point(8, 40)
        Me.dgUnret.Name = "dgUnret"
        Me.dgUnret.Size = New System.Drawing.Size(480, 168)
        Me.dgUnret.TabIndex = 0
        Me.dgUnret.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgUnret
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table1"
        '
        'sqlDa2
        '
        Me.sqlDa2.DeleteCommand = Me.SqlDeleteCommand2
        Me.sqlDa2.InsertCommand = Me.SqlInsertCommand2
        Me.sqlDa2.SelectCommand = Me.SqlSelectCommand2
        Me.sqlDa2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BorrowedCopy", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("accessionNo", "accessionNo"), New System.Data.Common.DataColumnMapping("memberID", "memberID"), New System.Data.Common.DataColumnMapping("runingNo", "runingNo"), New System.Data.Common.DataColumnMapping("brwDate", "brwDate"), New System.Data.Common.DataColumnMapping("dueDate", "dueDate")})})
        Me.sqlDa2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM BorrowedCopy WHERE (accessionNo = @Original_accessionNo) AND (memberI" & _
        "D = @Original_memberID) AND (brwDate = @Original_brwDate) AND (dueDate = @Origin" & _
        "al_dueDate) AND (runingNo = @Original_runingNo)"
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_accessionNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "accessionNo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memberID", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memberID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_brwDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "brwDate", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dueDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dueDate", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_runingNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "runingNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO BorrowedCopy(accessionNo, memberID, brwDate, dueDate) VALUES (@access" & _
        "ionNo, @memberID, @brwDate, @dueDate); SELECT accessionNo, memberID, runingNo, b" & _
        "rwDate, dueDate FROM BorrowedCopy WHERE (accessionNo = @accessionNo) AND (member" & _
        "ID = @memberID)"
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@accessionNo", System.Data.SqlDbType.Int, 4, "accessionNo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memberID", System.Data.SqlDbType.VarChar, 20, "memberID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@brwDate", System.Data.SqlDbType.DateTime, 8, "brwDate"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dueDate", System.Data.SqlDbType.DateTime, 8, "dueDate"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT accessionNo, memberID, runingNo, brwDate, dueDate FROM BorrowedCopy"
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE BorrowedCopy SET accessionNo = @accessionNo, memberID = @memberID, brwDate" & _
        " = @brwDate, dueDate = @dueDate WHERE (accessionNo = @Original_accessionNo) AND " & _
        "(memberID = @Original_memberID) AND (brwDate = @Original_brwDate) AND (dueDate =" & _
        " @Original_dueDate); SELECT accessionNo, memberID, runingNo, brwDate, dueDate FR" & _
        "OM BorrowedCopy WHERE (accessionNo = @accessionNo) AND (memberID = @memberID)"
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@accessionNo", System.Data.SqlDbType.Int, 4, "accessionNo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memberID", System.Data.SqlDbType.VarChar, 20, "memberID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@brwDate", System.Data.SqlDbType.DateTime, 8, "brwDate"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dueDate", System.Data.SqlDbType.DateTime, 8, "dueDate"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_accessionNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "accessionNo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memberID", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memberID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_brwDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "brwDate", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dueDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dueDate", System.Data.DataRowVersion.Original, Nothing))
        '
        'tbSummary
        '
        Me.tbSummary.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSummary.ForeColor = System.Drawing.Color.DarkBlue
        Me.tbSummary.Location = New System.Drawing.Point(8, 216)
        Me.tbSummary.Multiline = True
        Me.tbSummary.Name = "tbSummary"
        Me.tbSummary.Size = New System.Drawing.Size(480, 32)
        Me.tbSummary.TabIndex = 11
        Me.tbSummary.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(509, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOdvBooks
        '
        Me.btnOdvBooks.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOdvBooks.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnOdvBooks.Location = New System.Drawing.Point(497, 96)
        Me.btnOdvBooks.Name = "btnOdvBooks"
        Me.btnOdvBooks.Size = New System.Drawing.Size(96, 23)
        Me.btnOdvBooks.TabIndex = 2
        Me.btnOdvBooks.Text = "&Overdue Books"
        '
        'btnLoan
        '
        Me.btnLoan.Enabled = False
        Me.btnLoan.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.Location = New System.Drawing.Point(509, 144)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(72, 23)
        Me.btnLoan.TabIndex = 13
        Me.btnLoan.Text = "&Loan"
        '
        'btnChkRec
        '
        Me.btnChkRec.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChkRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChkRec.Location = New System.Drawing.Point(497, 48)
        Me.btnChkRec.Name = "btnChkRec"
        Me.btnChkRec.Size = New System.Drawing.Size(96, 23)
        Me.btnChkRec.TabIndex = 1
        Me.btnChkRec.Text = "&Check Records"
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'frmLendingConf
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(600, 262)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOdvBooks)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnChkRec)
        Me.Controls.Add(Me.tbSummary)
        Me.Controls.Add(Me.tbMemId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgUnret)
        Me.Name = "frmLendingConf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirm Lending"
        CType(Me.dgUnret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Check Member"

    Private Sub btnChkRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkRec.Click

        Dim count As Boolean
        MemberID = tbMemId.Text
        Try
            sqlconn.Open()
            count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count (memberID) from Member where memberID='" & tbMemId.Text & "' ")
            If count = 0 Then
                MessageBox.Show("Unvalid member", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                btnOdvBooks.ForeColor = SystemColors.ControlText
                btnOdvBooks.FlatStyle = FlatStyle.Popup
                btnOdvBooks.Cursor = Cursors.Hand

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not sqlconn Is Nothing Then
                sqlconn.Close()
            End If
        End Try

    End Sub

#End Region

#Region "Overdue Books"

    Private Sub btnOdvBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdvBooks.Click

        ' Dim Llended, Rlended, Lallow, Rallow As Integer
        Dim sqlDs As New DataSet
        Dim sqlDA As New SqlClient.SqlDataAdapter("select distinct a.MemberID,a.AccessionNo,a.DueDate,b.Status,c.Title from BorrowedCopy as a,dbo.BookCopy as b,dbo.Book as c,dbo.MemberBorrowingType as d,dbo.BorrowingType as e where a.accessionNo=b.accessionNo and b.ISBN=c.ISBN and returned=0 and	dueDate<getDate()and a.memberID='" & tbMemId.Text & "'", sqlconn)

        'sqlDA.SelectCommand.CommandText = "select distinct a.memberID,a.accessionNo,a.dueDate,b.status,c.title from BorrowedCopy as a,dbo.BookCopy as b,dbo.Book as c,dbo.MemberBorrowingType as d,dbo.BorrowingType as e where a.accessionNo=b.accessionNo and b.ISBN=c.ISBN and returned=0 and	dueDate<getDate()and a.memberID='" & tbMemId.Text & "'"
        'sqlDA.SelectCommand.Connection = sqlconn
        sqlDA.Fill(sqlDs)
        sqlDs.DataSetName = "Books"
        dgUnret.DataSource = sqlDs

        Llended = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(a.status)from bookCopy as a,borrowedCopy as b where a.accessionNo=b.accessionNo and b.memberID='" & tbMemId.Text & "' and returned=0 and status='L'")
        Rlended = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(a.status)from bookCopy as a,borrowedCopy as b where a.accessionNo=b.accessionNo and b.memberID='" & tbMemId.Text & "' and returned=0 and status='SR'")
        Lallow = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select noOfBooks from BorrowingType as a, MemberBorrowingType as b where a.type=b.type and a.type like '%L' and memberId='" & tbMemId.Text & "'")
        Rallow = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select noOfBooks from BorrowingType as a, MemberBorrowingType as b where a.type=b.type and a.type like '%R' and memberId='" & tbMemId.Text & "'")
        tbSummary.Text = "Can borrow '" & Lallow - Llended & "' Lending and '" & Rallow - Rlended & "' Scheduled Reference Books"

        If Lallow > Llended Or Rallow > Rlended Then
            btnLoan.Enabled = True
        End If

    End Sub

#End Region

#Region "Lend"

    Private Sub btnLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan.Click

        Dim LendForm As New frmLend
        LendForm.Show()

    End Sub

#End Region

#Region "Cancel"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub frmLendingConf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetCancelButton(btnCancel)

    End Sub

    Private Sub SetCancelButton(ByVal myCancelBtn As Button)

        Me.CancelButton = myCancelBtn

    End Sub

#End Region

End Class
