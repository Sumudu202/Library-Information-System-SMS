Public Class frmEditAuthor
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbconNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents ISBN As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbSby As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSub As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents tbAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnclRe As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cmbSby = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbCountry = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbAdd = New System.Windows.Forms.TextBox
        Me.tbconNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCity = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSub = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbName = New System.Windows.Forms.TextBox
        Me.ISBN = New System.Windows.Forms.Label
        Me.btnclRe = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(152, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(32, 177)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Update"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.cmbSby)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 96)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(152, 59)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'cmbSby
        '
        Me.cmbSby.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSby.Items.AddRange(New Object() {"Author ID", "Name,Subjects and City"})
        Me.cmbSby.Location = New System.Drawing.Point(71, 24)
        Me.cmbSby.Name = "cmbSby"
        Me.cmbSby.Size = New System.Drawing.Size(160, 24)
        Me.cmbSby.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Search By"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCountry)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbAdd)
        Me.GroupBox2.Controls.Add(Me.tbconNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbCity)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbSub)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbName)
        Me.GroupBox2.Controls.Add(Me.ISBN)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(262, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 240)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Author Details"
        '
        'cmbCountry
        '
        Me.cmbCountry.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.Items.AddRange(New Object() {"Sri Lanka", "India", "USA", "UK", "Japan", "Kanada"})
        Me.cmbCountry.Location = New System.Drawing.Point(86, 116)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(144, 24)
        Me.cmbCountry.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Country"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbAdd
        '
        Me.tbAdd.AutoSize = False
        Me.tbAdd.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdd.Location = New System.Drawing.Point(86, 149)
        Me.tbAdd.Multiline = True
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.Size = New System.Drawing.Size(144, 50)
        Me.tbAdd.TabIndex = 6
        Me.tbAdd.Text = ""
        '
        'tbconNo
        '
        Me.tbconNo.AutoSize = False
        Me.tbconNo.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbconNo.Location = New System.Drawing.Point(86, 207)
        Me.tbconNo.Name = "tbconNo"
        Me.tbconNo.Size = New System.Drawing.Size(144, 24)
        Me.tbconNo.TabIndex = 7
        Me.tbconNo.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Contact No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCity
        '
        Me.cmbCity.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.Location = New System.Drawing.Point(86, 83)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(144, 24)
        Me.cmbCity.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "City"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSub
        '
        Me.cmbSub.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSub.Location = New System.Drawing.Point(86, 50)
        Me.cmbSub.Name = "cmbSub"
        Me.cmbSub.Size = New System.Drawing.Size(144, 24)
        Me.cmbSub.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 23)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Subjects"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbName
        '
        Me.tbName.AutoSize = False
        Me.tbName.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(86, 22)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(144, 24)
        Me.tbName.TabIndex = 2
        Me.tbName.Text = ""
        '
        'ISBN
        '
        Me.ISBN.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(19, 22)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(37, 23)
        Me.ISBN.TabIndex = 81
        Me.ISBN.Text = "Name"
        Me.ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnclRe
        '
        Me.btnclRe.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclRe.Location = New System.Drawing.Point(145, 177)
        Me.btnclRe.Name = "btnclRe"
        Me.btnclRe.Size = New System.Drawing.Size(88, 23)
        Me.btnclRe.TabIndex = 9
        Me.btnclRe.Text = "&Clear Result"
        '
        'frmEditAuthor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(512, 254)
        Me.Controls.Add(Me.btnclRe)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmEditAuthor"
        Me.Text = "Edit Author Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim Inbox As Integer
        Dim Inbox1, Inbox2, Inbox3 As String
        Me.Clear()

        If cmbSby.Text = "Author ID" Then
            Dim au As New Class_Author
            Inbox = InputBox("Input the Author ID", "Author ID", , , )
            au.SearchAuthor_By_AuID(Inbox)
            tbName.Text = au.AuName
            cmbSub.Text = au.Subjects
            cmbCity.Text = au.City
            cmbCountry.Text = au.Country
            tbAdd.Text = au.Add
            tbconNo.Text = au.ConNo

        ElseIf cmbSby.Text = "Name,Subjects and City" Then
            Dim au As New Class_Author
            Inbox1 = InputBox("Input the Name", "Author Name", , )
            Inbox2 = InputBox("Input the Subjects", "Subjects", , , )
            Inbox3 = InputBox("Input the City", "City", , , )
            au.SearchAuthor_By_Name_Sub_City(Inbox1, Inbox2, Inbox3)
            tbName.Text = au.AuName
            cmbSub.Text = au.Subjects
            cmbCity.Text = au.City
            cmbCountry.Text = au.Country
            tbAdd.Text = au.Add
            tbconNo.Text = au.ConNo
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnclRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclRe.Click

        tbName.Text = ""
        cmbSub.Text = ""
        cmbCity.Text = ""
        cmbCountry.Text = ""
        tbAdd.Text = ""
        tbconNo.Text = ""

    End Sub

    Sub Clear()


        tbName.Text = ""
        cmbSub.Text = ""
        cmbCity.Text = ""
        cmbCountry.Text = ""
        tbAdd.Text = ""
        tbconNo.Text = ""

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim au As New Class_Author
        au.Update(tbName.Text, cmbSub.Text, cmbCity.Text, cmbCountry.Text, tbAdd.Text, tbconNo.Text)

    End Sub
End Class
