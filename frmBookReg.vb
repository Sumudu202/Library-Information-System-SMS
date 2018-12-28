Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports System.Windows.Forms
'Imports Library.baseclass
Imports Library.LogginUser
Imports Library.Book

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
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTitle As System.Windows.Forms.TextBox
    Friend WithEvents tbPagination As System.Windows.Forms.TextBox
    Friend WithEvents tbCallNo As System.Windows.Forms.TextBox
    Friend WithEvents tbEdition As System.Windows.Forms.TextBox
    Friend WithEvents tbLanguage As System.Windows.Forms.TextBox
    Friend WithEvents tbAdd As System.Windows.Forms.Button
    Friend WithEvents tbacmMaterials As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpPubDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tp1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpRegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbISBN As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCopy As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbkwds As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbAu1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAu2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAu3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPubName As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.tbTitle = New System.Windows.Forms.TextBox
        Me.tbISBN = New System.Windows.Forms.TextBox
        Me.tbPagination = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbCallNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbEdition = New System.Windows.Forms.TextBox
        Me.tbLanguage = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbPubName = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpPubDate = New System.Windows.Forms.DateTimePicker
        Me.tbAdd = New System.Windows.Forms.Button
        Me.tbacmMaterials = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAddCopy = New System.Windows.Forms.Button
        Me.tp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbkwds = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpRegDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbAu3 = New System.Windows.Forms.ComboBox
        Me.cmbAu2 = New System.Windows.Forms.ComboBox
        Me.cmbAu1 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbDept = New System.Windows.Forms.ComboBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.ep = New System.Windows.Forms.ErrorProvider
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl5
        '
        Me.lbl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl5.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(4, 184)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(76, 23)
        Me.lbl5.TabIndex = 2
        Me.lbl5.Text = "Pagination"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(4, 82)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(76, 23)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "Title"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(4, 14)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(76, 23)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "ISBN No"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTitle
        '
        Me.tbTitle.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitle.Location = New System.Drawing.Point(80, 83)
        Me.tbTitle.MaxLength = 100
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(160, 21)
        Me.tbTitle.TabIndex = 2
        Me.tbTitle.Text = ""
        '
        'tbISBN
        '
        Me.tbISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbISBN.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbISBN.Location = New System.Drawing.Point(80, 15)
        Me.tbISBN.MaxLength = 18
        Me.tbISBN.Name = "tbISBN"
        Me.tbISBN.Size = New System.Drawing.Size(160, 21)
        Me.tbISBN.TabIndex = 0
        Me.tbISBN.Text = ""
        '
        'tbPagination
        '
        Me.tbPagination.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPagination.Location = New System.Drawing.Point(80, 185)
        Me.tbPagination.Name = "tbPagination"
        Me.tbPagination.Size = New System.Drawing.Size(160, 21)
        Me.tbPagination.TabIndex = 5
        Me.tbPagination.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Edition"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Language"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCallNo
        '
        Me.tbCallNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCallNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCallNo.Location = New System.Drawing.Point(80, 49)
        Me.tbCallNo.MaxLength = 20
        Me.tbCallNo.Name = "tbCallNo"
        Me.tbCallNo.Size = New System.Drawing.Size(160, 21)
        Me.tbCallNo.TabIndex = 1
        Me.tbCallNo.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Call No"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbEdition
        '
        Me.tbEdition.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEdition.Location = New System.Drawing.Point(80, 151)
        Me.tbEdition.MaxLength = 15
        Me.tbEdition.Name = "tbEdition"
        Me.tbEdition.Size = New System.Drawing.Size(160, 21)
        Me.tbEdition.TabIndex = 4
        Me.tbEdition.Text = ""
        '
        'tbLanguage
        '
        Me.tbLanguage.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLanguage.Location = New System.Drawing.Point(80, 117)
        Me.tbLanguage.MaxLength = 50
        Me.tbLanguage.Name = "tbLanguage"
        Me.tbLanguage.Size = New System.Drawing.Size(160, 21)
        Me.tbLanguage.TabIndex = 3
        Me.tbLanguage.Text = ""
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Subject"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPubName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.dtpPubDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(250, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 88)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Publisher Details"
        '
        'cmbPubName
        '
        Me.cmbPubName.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPubName.Location = New System.Drawing.Point(56, 23)
        Me.cmbPubName.Name = "cmbPubName"
        Me.cmbPubName.Size = New System.Drawing.Size(224, 23)
        Me.cmbPubName.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Name"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 23)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Published Date "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpPubDate
        '
        Me.dtpPubDate.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.dtpPubDate.AllowDrop = True
        Me.dtpPubDate.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPubDate.Location = New System.Drawing.Point(96, 55)
        Me.dtpPubDate.Name = "dtpPubDate"
        Me.dtpPubDate.Size = New System.Drawing.Size(184, 21)
        Me.dtpPubDate.TabIndex = 12
        Me.dtpPubDate.Value = New Date(2006, 4, 8, 0, 0, 0, 0)
        '
        'tbAdd
        '
        Me.tbAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdd.Location = New System.Drawing.Point(552, 138)
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.Size = New System.Drawing.Size(80, 23)
        Me.tbAdd.TabIndex = 16
        Me.tbAdd.Text = "&Register"
        '
        'tbacmMaterials
        '
        Me.tbacmMaterials.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbacmMaterials.Location = New System.Drawing.Point(80, 255)
        Me.tbacmMaterials.MaxLength = 250
        Me.tbacmMaterials.Name = "tbacmMaterials"
        Me.tbacmMaterials.Size = New System.Drawing.Size(160, 21)
        Me.tbacmMaterials.TabIndex = 7
        Me.tbacmMaterials.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Accompanied Materials"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddCopy
        '
        Me.btnAddCopy.Enabled = False
        Me.btnAddCopy.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCopy.Location = New System.Drawing.Point(552, 177)
        Me.btnAddCopy.Name = "btnAddCopy"
        Me.btnAddCopy.Size = New System.Drawing.Size(80, 23)
        Me.btnAddCopy.TabIndex = 17
        Me.btnAddCopy.Text = "&Add Copies"
        '
        'tbkwds
        '
        Me.tbkwds.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkwds.Location = New System.Drawing.Point(9, 23)
        Me.tbkwds.MaxLength = 50
        Me.tbkwds.Multiline = True
        Me.tbkwds.Name = "tbkwds"
        Me.tbkwds.Size = New System.Drawing.Size(152, 89)
        Me.tbkwds.TabIndex = 15
        Me.tbkwds.Text = ""
        Me.tp1.SetToolTip(Me.tbkwds, "Enter the Ketword")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Book Entered Date "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpRegDate
        '
        Me.dtpRegDate.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.dtpRegDate.AllowDrop = True
        Me.dtpRegDate.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDate.Location = New System.Drawing.Point(360, 230)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(176, 21)
        Me.dtpRegDate.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAu3)
        Me.GroupBox1.Controls.Add(Me.cmbAu2)
        Me.GroupBox1.Controls.Add(Me.cmbAu1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(250, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 120)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Author Details"
        '
        'cmbAu3
        '
        Me.cmbAu3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu3.Location = New System.Drawing.Point(33, 85)
        Me.cmbAu3.Name = "cmbAu3"
        Me.cmbAu3.Size = New System.Drawing.Size(167, 23)
        Me.cmbAu3.TabIndex = 53
        '
        'cmbAu2
        '
        Me.cmbAu2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu2.Location = New System.Drawing.Point(32, 53)
        Me.cmbAu2.Name = "cmbAu2"
        Me.cmbAu2.Size = New System.Drawing.Size(168, 23)
        Me.cmbAu2.TabIndex = 52
        '
        'cmbAu1
        '
        Me.cmbAu1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu1.ItemHeight = 15
        Me.cmbAu1.Location = New System.Drawing.Point(32, 21)
        Me.cmbAu1.Name = "cmbAu1"
        Me.cmbAu1.Size = New System.Drawing.Size(168, 23)
        Me.cmbAu1.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 24)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "3"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbkwds)
        Me.GroupBox3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(464, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 120)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Key Words"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(552, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "&Cancel"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(254, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 23)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Ordered Department"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDept
        '
        Me.cmbDept.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.Items.AddRange(New Object() {"Statistics and Computer Science", "Chemistry", "Physics", "Zoology"})
        Me.cmbDept.Location = New System.Drawing.Point(384, 254)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(152, 23)
        Me.cmbDept.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(552, 216)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "&Clear"
        '
        'cmbSubject
        '
        Me.cmbSubject.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubject.Location = New System.Drawing.Point(80, 219)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(160, 23)
        Me.cmbSubject.TabIndex = 6
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'frmBookRegistration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(640, 286)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpRegDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddCopy)
        Me.Controls.Add(Me.tbacmMaterials)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbLanguage)
        Me.Controls.Add(Me.tbEdition)
        Me.Controls.Add(Me.tbCallNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPagination)
        Me.Controls.Add(Me.tbISBN)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl5)
        Me.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBookRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Registration"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Add New Book"

    Private Sub tbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAdd.Click

        Dim Book As New Book
        Book.addNewBook(tbISBN.Text, tbCallNo.Text, tbTitle.Text, cmbSubject.Text, cmbAu1.Text, cmbAu2.Text, cmbAu3.Text, cmbPubName.Text, tbLanguage.Text, tbEdition.Text, tbPagination.Text, dtpPubDate.Value, 1, tbkwds.Text, cmbDept.SelectedItem, dtpRegDate.Value, tbacmMaterials.Text)
        btnAddCopy.Enabled = True

    End Sub

#End Region

#Region "Add New Copy"

    Private Sub btnAddCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCopy.Click

        Dim frmCopyReg As New frmBookCopyReg
        frmCopyReg.ISBN.Visible = False
        frmCopyReg.tbISBN.Visible = False
        frmCopyReg.EnteredDate.Visible = False
        frmCopyReg.dtpEntDate.Visible = False
        'If tbISBN.Text <> "" Then
        frmCopyReg.Show()
        'End If

    End Sub

#End Region

#Region "Clear Fields"

    Private Sub ClearFields()

        tbISBN.Text = ""
        tbCallNo.Text = ""
        tbTitle.Text = ""
        tbLanguage.Text = ""
        tbEdition.Text = ""
        tbPagination.Text = ""
        cmbSubject.Text = ""
        tbacmMaterials.Text = ""
        cmbPubName.Text = ""
        dtpPubDate.Text = ""
        dtpRegDate.Text = ""
        cmbAu1.Text = ""
        cmbAu2.Text = ""
        cmbAu3.Text = ""
        tbkwds.Text = ""
        cmbDept.Text = ""
        dtpPubDate.Text = ""

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.ClearFields()

    End Sub

#End Region

#Region "Exit"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

#End Region

#Region "Error Handling"

    Private Sub tbISBN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbISBN.TextChanged

        tp1.SetToolTip(tbISBN, "EX: ISBN 0-13-196859-5")

    End Sub

    Private Sub tbISBN_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbISBN.Leave

        Dim count As Int16
        If tbISBN.Text Like "ISBN #-##-######-#" Then
            ep.Dispose()
        Else
            ep.SetError(tbISBN, "Please Enter With Correct Format")
            ep.SetIconAlignment(tbISBN, ErrorIconAlignment.TopLeft)
            ep.BlinkRate.Equals(1)
        End If

        count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(ISBN) from Book where ISBN='" & tbISBN.Text & "'")
        If count > 0 Then
            ep.SetError(tbISBN, "The book is already registered")
            ep.SetIconAlignment(tbISBN, ErrorIconAlignment.TopLeft)
            ep.BlinkRate.Equals(1)
        End If

    End Sub

#End Region

#Region "Form Load"

    Private Sub frmBookRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sqlDs As New DataSet
        Dim sqlDA1 As New Data.SqlClient.SqlDataAdapter("select distinct subjects from Author order by subjects asc", sqlconn)
        sqlDA1.Fill(sqlDs, "Subjects")
        cmbSubject.DataSource = sqlDs.Tables("Subjects")
        cmbSubject.DisplayMember = "subjects"
        cmbSubject.ValueMember = "subjects"

        Dim sqlDA2 As New Data.SqlClient.SqlDataAdapter("select distinct auName from Author order by auName", sqlconn)
        sqlDA2.Fill(sqlDs, "AuName")
        cmbAu1.DataSource = sqlDs.Tables("AuName")
        cmbAu1.DisplayMember = "auName"
        cmbAu1.ValueMember = "auName"

        cmbAu2.DataSource = sqlDs.Tables("AuName")
        cmbAu2.DisplayMember = "auName"
        cmbAu2.ValueMember = "auName"

        cmbAu3.DataSource = sqlDs.Tables("AuName")
        cmbAu3.DisplayMember = "auName"
        cmbAu3.ValueMember = "auName"

        Dim sqlDA3 As New Data.SqlClient.SqlDataAdapter("select pubName from Publisher order by pubName", sqlconn)
        sqlDA3.Fill(sqlDs, "PubName")
        cmbPubName.DataSource = sqlDs.Tables("PubName")
        cmbPubName.DisplayMember = "pubName"
        cmbPubName.ValueMember = "pubName"

        cmbSubject.Text = ""
        cmbAu1.Text = ""
        cmbAu2.Text = ""
        cmbAu3.Text = ""
        cmbPubName.Text = ""

    End Sub

#End Region
    
End Class

