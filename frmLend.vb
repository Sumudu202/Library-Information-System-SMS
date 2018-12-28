Imports Library.LogginUser
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports Library.frmLendingConf

Public Class frmLend
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbAccNo As System.Windows.Forms.TextBox
    Friend WithEvents btnlend As System.Windows.Forms.Button
    Friend WithEvents btnCheckC As System.Windows.Forms.Button
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmbKWD As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbKWD = New System.Windows.Forms.ComboBox
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCheckC = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnlend = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbAccNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DG1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbKWD)
        Me.GroupBox1.Controls.Add(Me.cmbSearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCheckC)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Copies"
        '
        'cmbKWD
        '
        Me.cmbKWD.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKWD.Items.AddRange(New Object() {"ISBN", "Author", "Title", "Accession No"})
        Me.cmbKWD.Location = New System.Drawing.Point(16, 57)
        Me.cmbKWD.Name = "cmbKWD"
        Me.cmbKWD.Size = New System.Drawing.Size(200, 23)
        Me.cmbKWD.TabIndex = 14
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"ISBN", "Author", "Title", "Accession No"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(80, 24)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(136, 23)
        Me.cmbSearchBy.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Check By"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckC
        '
        Me.btnCheckC.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckC.Location = New System.Drawing.Point(64, 97)
        Me.btnCheckC.Name = "btnCheckC"
        Me.btnCheckC.Size = New System.Drawing.Size(96, 24)
        Me.btnCheckC.TabIndex = 1
        Me.btnCheckC.Text = "Check Copies"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(520, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        '
        'btnlend
        '
        Me.btnlend.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlend.Location = New System.Drawing.Point(520, 48)
        Me.btnlend.Name = "btnlend"
        Me.btnlend.TabIndex = 14
        Me.btnlend.Text = "&Lend"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tbAccNo)
        Me.GroupBox3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(264, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 72)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lending Sample"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Accession No"
        '
        'tbAccNo
        '
        Me.tbAccNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccNo.Location = New System.Drawing.Point(95, 33)
        Me.tbAccNo.Name = "tbAccNo"
        Me.tbAccNo.Size = New System.Drawing.Size(120, 21)
        Me.tbAccNo.TabIndex = 11
        Me.tbAccNo.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG1)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 232)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Copy Details"
        '
        'DG1
        '
        Me.DG1.DataMember = ""
        Me.DG1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG1.Location = New System.Drawing.Point(8, 24)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(648, 200)
        Me.DG1.TabIndex = 0
        '
        'frmLend
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(680, 390)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnlend)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lending Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Check copies"

    Private Sub btnCheckC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckC.Click

        ' DG1.Expand(-1)
        If cmbSearchBy.Text = "ISBN" Then
            Dim BookC As New ClassBookCopy
            BookC.Search_By_ISBN(cmbKWD.Text, DG1)
        ElseIf cmbSearchBy.Text = "Author" Then
            Dim BookC As New ClassBookCopy
            BookC.Search_By_Author(cmbKWD.Text, DG1)
        ElseIf cmbSearchBy.Text = "Title" Then
            Dim BookC As New ClassBookCopy
            BookC.Search_By_Title(cmbKWD.Text, DG1)
        ElseIf cmbSearchBy.Text = "Accession No" Then
            Dim BookC As New ClassBookCopy
            BookC.Search_By_AccNo(cmbKWD.Text, DG1)
        End If

    End Sub

#End Region

#Region "Lend"

    Private Sub btnlend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlend.Click

        Dim BorrCopy As New ClassBookCopy
        BorrCopy.Lend(tbAccNo.Text, LogginUser.MemberID)

    End Sub

#End Region

#Region "Exit"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

#End Region

#Region "Form Load"

    Private Sub frmLend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
    End Sub

#End Region
    

    Private Sub cmbSearchBy_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSearchBy.Leave

        If cmbSearchBy.Text = "ISBN" Then

            cmbKWD.Refresh()
            Dim sqlDs1 As New DataSet
            Dim sqlDA1 As New Data.SqlClient.SqlDataAdapter("select ISBN from Book order by ISBN asc", sqlconn)
            sqlDA1.Fill(sqlDs1, "ISBN")
            cmbKWD.DataSource = sqlDs1.Tables("ISBN")
            cmbKWD.DisplayMember = "ISBN"
            cmbKWD.ValueMember = "ISBN"

        ElseIf cmbSearchBy.Text = "Author" Then
            cmbKWD.Refresh()
            Dim sqlDs2 As New DataSet
            Dim sqlDA2 As New Data.SqlClient.SqlDataAdapter("select auName from Author order by auName asc", sqlconn)
            sqlDA2.Fill(sqlDs2, "auName")
            cmbKWD.DataSource = sqlDs2.Tables("auName")
            cmbKWD.DisplayMember = "auName"
            cmbKWD.ValueMember = "auName"

        ElseIf cmbSearchBy.Text = "Title" Then
            cmbKWD.Refresh()
            Dim sqlDs3 As New DataSet
            Dim sqlDA3 As New Data.SqlClient.SqlDataAdapter("select title from Book order by title asc", sqlconn)
            sqlDA3.Fill(sqlDs3, "title")
            cmbKWD.DataSource = sqlDs3.Tables("title")
            cmbKWD.DisplayMember = "title"
            cmbKWD.ValueMember = "title"

        ElseIf cmbSearchBy.Text = "Accession No" Then
            cmbKWD.Refresh()
            Dim sqlDs4 As New DataSet
            Dim sqlDA4 As New Data.SqlClient.SqlDataAdapter("select accessionNo from BookCopy order by accessionNo asc", sqlconn)
            sqlDA4.Fill(sqlDs4, "accessionNo")
            cmbKWD.DataSource = sqlDs4.Tables("accessionNo")
            cmbKWD.DisplayMember = "accessionNo"
            cmbKWD.ValueMember = "accessionNo"
        End If


    End Sub
End Class
