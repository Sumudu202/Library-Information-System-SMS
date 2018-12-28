Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Public Class frmEditMemberDetails
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
    Friend WithEvents tbMemId As System.Windows.Forms.TextBox
    Friend WithEvents gbStu As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStuStg As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbStaff As System.Windows.Forms.GroupBox
    Friend WithEvents cmbstg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeptName As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbPer As System.Windows.Forms.GroupBox
    Friend WithEvents tbInit As System.Windows.Forms.TextBox
    Friend WithEvents Initial As System.Windows.Forms.Label
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents tbNID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbPemAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents tbStuNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbConNo As System.Windows.Forms.TextBox
    Friend WithEvents tbTmpAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tbUnvId As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.tbMemId = New System.Windows.Forms.TextBox
        Me.gbStu = New System.Windows.Forms.GroupBox
        Me.cmbLevel = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbStuNo = New System.Windows.Forms.TextBox
        Me.cmbStuStg = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.gbStaff = New System.Windows.Forms.GroupBox
        Me.tbUnvId = New System.Windows.Forms.TextBox
        Me.cmbstg = New System.Windows.Forms.ComboBox
        Me.cmbDeptName = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.gbPer = New System.Windows.Forms.GroupBox
        Me.tbInit = New System.Windows.Forms.TextBox
        Me.Initial = New System.Windows.Forms.Label
        Me.tblName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.tbNID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbConNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tbPemAdd = New System.Windows.Forms.TextBox
        Me.tbTmpAdd = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.gbStu.SuspendLayout()
        Me.gbStaff.SuspendLayout()
        Me.gbPer.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmbType.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.ItemHeight = 15
        Me.cmbType.Items.AddRange(New Object() {"Staff", "Student"})
        Me.cmbType.Location = New System.Drawing.Point(312, 8)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(80, 23)
        Me.cmbType.TabIndex = 1
        '
        'tbMemId
        '
        Me.tbMemId.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbMemId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMemId.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMemId.Location = New System.Drawing.Point(152, 8)
        Me.tbMemId.MaxLength = 15
        Me.tbMemId.Name = "tbMemId"
        Me.tbMemId.Size = New System.Drawing.Size(104, 21)
        Me.tbMemId.TabIndex = 0
        Me.tbMemId.Text = ""
        '
        'gbStu
        '
        Me.gbStu.Controls.Add(Me.cmbLevel)
        Me.gbStu.Controls.Add(Me.Label4)
        Me.gbStu.Controls.Add(Me.tbStuNo)
        Me.gbStu.Controls.Add(Me.cmbStuStg)
        Me.gbStu.Controls.Add(Me.Label7)
        Me.gbStu.Controls.Add(Me.Label3)
        Me.gbStu.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStu.Location = New System.Drawing.Point(352, 40)
        Me.gbStu.Name = "gbStu"
        Me.gbStu.Size = New System.Drawing.Size(208, 120)
        Me.gbStu.TabIndex = 214
        Me.gbStu.TabStop = False
        Me.gbStu.Text = "Acedemic Details"
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLevel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.ItemHeight = 15
        Me.cmbLevel.Items.AddRange(New Object() {"Undergraduate", "Postgraduate"})
        Me.cmbLevel.Location = New System.Drawing.Point(80, 50)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(120, 23)
        Me.cmbLevel.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 23)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "Level"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbStuNo
        '
        Me.tbStuNo.BackColor = System.Drawing.SystemColors.Window
        Me.tbStuNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbStuNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStuNo.Location = New System.Drawing.Point(80, 24)
        Me.tbStuNo.MaxLength = 20
        Me.tbStuNo.Name = "tbStuNo"
        Me.tbStuNo.Size = New System.Drawing.Size(120, 21)
        Me.tbStuNo.TabIndex = 9
        Me.tbStuNo.Text = ""
        '
        'cmbStuStg
        '
        Me.cmbStuStg.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStuStg.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStuStg.ItemHeight = 15
        Me.cmbStuStg.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbStuStg.Location = New System.Drawing.Point(80, 80)
        Me.cmbStuStg.Name = "cmbStuStg"
        Me.cmbStuStg.Size = New System.Drawing.Size(120, 23)
        Me.cmbStuStg.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 23)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Stage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Student No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbStaff
        '
        Me.gbStaff.Controls.Add(Me.tbUnvId)
        Me.gbStaff.Controls.Add(Me.cmbstg)
        Me.gbStaff.Controls.Add(Me.cmbDeptName)
        Me.gbStaff.Controls.Add(Me.Label20)
        Me.gbStaff.Controls.Add(Me.Label12)
        Me.gbStaff.Controls.Add(Me.Label13)
        Me.gbStaff.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStaff.Location = New System.Drawing.Point(336, 40)
        Me.gbStaff.Name = "gbStaff"
        Me.gbStaff.Size = New System.Drawing.Size(248, 120)
        Me.gbStaff.TabIndex = 213
        Me.gbStaff.TabStop = False
        Me.gbStaff.Text = "Professional Details"
        '
        'tbUnvId
        '
        Me.tbUnvId.BackColor = System.Drawing.SystemColors.Window
        Me.tbUnvId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUnvId.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUnvId.Location = New System.Drawing.Point(112, 24)
        Me.tbUnvId.MaxLength = 10
        Me.tbUnvId.Name = "tbUnvId"
        Me.tbUnvId.Size = New System.Drawing.Size(128, 21)
        Me.tbUnvId.TabIndex = 206
        Me.tbUnvId.Text = ""
        '
        'cmbstg
        '
        Me.cmbstg.BackColor = System.Drawing.SystemColors.Window
        Me.cmbstg.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstg.ItemHeight = 15
        Me.cmbstg.Items.AddRange(New Object() {"Dean", "Professor", "Senior Lecturer", "Lecturer", "Demonstrator", "Executive Officer", "Temporary Demonstrator"})
        Me.cmbstg.Location = New System.Drawing.Point(111, 83)
        Me.cmbstg.Name = "cmbstg"
        Me.cmbstg.Size = New System.Drawing.Size(128, 23)
        Me.cmbstg.TabIndex = 14
        '
        'cmbDeptName
        '
        Me.cmbDeptName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDeptName.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDeptName.ItemHeight = 15
        Me.cmbDeptName.Items.AddRange(New Object() {"Statistics and Computer Science", "Mathematics ", "Physics", "Chemistry", "Botany", "Zoology", "Industrial Management"})
        Me.cmbDeptName.Location = New System.Drawing.Point(111, 51)
        Me.cmbDeptName.Name = "cmbDeptName"
        Me.cmbDeptName.Size = New System.Drawing.Size(128, 23)
        Me.cmbDeptName.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 23)
        Me.Label20.TabIndex = 205
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 23)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 23)
        Me.Label13.TabIndex = 203
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbPer
        '
        Me.gbPer.Controls.Add(Me.tbInit)
        Me.gbPer.Controls.Add(Me.Initial)
        Me.gbPer.Controls.Add(Me.tblName)
        Me.gbPer.Controls.Add(Me.Label18)
        Me.gbPer.Controls.Add(Me.Label19)
        Me.gbPer.Controls.Add(Me.cmbTitle)
        Me.gbPer.Controls.Add(Me.tbNID)
        Me.gbPer.Controls.Add(Me.Label2)
        Me.gbPer.Controls.Add(Me.tbConNo)
        Me.gbPer.Controls.Add(Me.Label14)
        Me.gbPer.Controls.Add(Me.tbPemAdd)
        Me.gbPer.Controls.Add(Me.tbTmpAdd)
        Me.gbPer.Controls.Add(Me.Label15)
        Me.gbPer.Controls.Add(Me.Label16)
        Me.gbPer.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPer.Location = New System.Drawing.Point(16, 40)
        Me.gbPer.Name = "gbPer"
        Me.gbPer.Size = New System.Drawing.Size(304, 264)
        Me.gbPer.TabIndex = 2
        Me.gbPer.TabStop = False
        Me.gbPer.Text = "Personal Details"
        '
        'tbInit
        '
        Me.tbInit.BackColor = System.Drawing.SystemColors.Window
        Me.tbInit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInit.Cursor = System.Windows.Forms.Cursors.No
        Me.tbInit.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInit.Location = New System.Drawing.Point(96, 46)
        Me.tbInit.MaxLength = 10
        Me.tbInit.Name = "tbInit"
        Me.tbInit.Size = New System.Drawing.Size(80, 21)
        Me.tbInit.TabIndex = 3
        Me.tbInit.Text = ""
        '
        'Initial
        '
        Me.Initial.BackColor = System.Drawing.SystemColors.Highlight
        Me.Initial.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial.Location = New System.Drawing.Point(10, 40)
        Me.Initial.Name = "Initial"
        Me.Initial.Size = New System.Drawing.Size(40, 23)
        Me.Initial.TabIndex = 194
        Me.Initial.Text = "Initial"
        Me.Initial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblName
        '
        Me.tblName.BackColor = System.Drawing.SystemColors.Window
        Me.tblName.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblName.Location = New System.Drawing.Point(96, 73)
        Me.tblName.MaxLength = 50
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(152, 21)
        Me.tblName.TabIndex = 4
        Me.tblName.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 23)
        Me.Label18.TabIndex = 189
        Me.Label18.Text = "Last Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 23)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTitle.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ItemHeight = 15
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(96, 16)
        Me.cmbTitle.MaxLength = 5
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(56, 23)
        Me.cmbTitle.TabIndex = 2
        '
        'tbNID
        '
        Me.tbNID.BackColor = System.Drawing.SystemColors.Window
        Me.tbNID.Enabled = False
        Me.tbNID.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNID.Location = New System.Drawing.Point(96, 100)
        Me.tbNID.MaxLength = 10
        Me.tbNID.Name = "tbNID"
        Me.tbNID.Size = New System.Drawing.Size(128, 21)
        Me.tbNID.TabIndex = 5
        Me.tbNID.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(10, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = " National ID No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbConNo
        '
        Me.tbConNo.BackColor = System.Drawing.SystemColors.Window
        Me.tbConNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConNo.Location = New System.Drawing.Point(96, 127)
        Me.tbConNo.MaxLength = 10
        Me.tbConNo.Name = "tbConNo"
        Me.tbConNo.Size = New System.Drawing.Size(128, 21)
        Me.tbConNo.TabIndex = 6
        Me.tbConNo.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 23)
        Me.Label14.TabIndex = 184
        Me.Label14.Text = "Contact No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPemAdd
        '
        Me.tbPemAdd.BackColor = System.Drawing.SystemColors.Window
        Me.tbPemAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPemAdd.Location = New System.Drawing.Point(96, 208)
        Me.tbPemAdd.MaxLength = 250
        Me.tbPemAdd.Multiline = True
        Me.tbPemAdd.Name = "tbPemAdd"
        Me.tbPemAdd.Size = New System.Drawing.Size(200, 48)
        Me.tbPemAdd.TabIndex = 8
        Me.tbPemAdd.Text = ""
        '
        'tbTmpAdd
        '
        Me.tbTmpAdd.BackColor = System.Drawing.SystemColors.Window
        Me.tbTmpAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTmpAdd.Location = New System.Drawing.Point(96, 154)
        Me.tbTmpAdd.MaxLength = 250
        Me.tbTmpAdd.Multiline = True
        Me.tbTmpAdd.Name = "tbTmpAdd"
        Me.tbTmpAdd.Size = New System.Drawing.Size(200, 48)
        Me.tbTmpAdd.TabIndex = 7
        Me.tbTmpAdd.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 218)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 181
        Me.Label15.Text = "Permanent Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Temporary Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "Enter the Member ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(368, 248)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 25)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "&Update"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(368, 192)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "&Search"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(472, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 25)
        Me.Button1.TabIndex = 215
        Me.Button1.Text = "&Clear"
        '
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'frmEditMemberDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(588, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.tbMemId)
        Me.Controls.Add(Me.gbPer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gbStu)
        Me.Controls.Add(Me.gbStaff)
        Me.Name = "frmEditMemberDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Member Details"
        Me.gbStu.ResumeLayout(False)
        Me.gbStaff.ResumeLayout(False)
        Me.gbPer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form load"

    Private Sub frmEditMemberDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbPer.Visible = False
        gbStaff.Visible = False
        gbStu.Visible = False
    End Sub

#End Region

#Region "Search Member"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        gbPer.Visible = False
        gbStaff.Visible = False
        gbStu.Visible = False
        Dim Count1, Count2 As Int16
        If tbMemId.Text = "" Or cmbType.Text = "" Then
            MessageBox.Show("Please enter the Member ID and the Type", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If cmbType.Text = "Staff" Then
                Count1 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(memberID) from staff where memberID='" & tbMemId.Text & "'")
                If Count1 = 0 Then
                    MessageBox.Show("Please Check the MemberID and Type", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim stfMem As New ClassStaff
                stfMem.searchMember(tbMemId.Text, cmbType.Text)
                gbPer.Visible = True
                gbStaff.Visible = True
                gbStu.Visible = False
                cmbTitle.Text = stfMem.Title
                tblName.Text = stfMem.LName
                tbInit.Text = stfMem.Init
                tbConNo.Text = stfMem.ConNo
                tbTmpAdd.Text = stfMem.TmpAdd
                tbPemAdd.Text = stfMem.PermAdd
                tbUnvId.Text = stfMem.MemberID
                tbNID.Text = stfMem.NID
                cmbDeptName.Text = stfMem.DeptName
                cmbstg.Text = stfMem.Post

            ElseIf cmbType.Text = "Student" Then

                Count2 = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(memberID) from student where memberID='" & tbMemId.Text & "'")
                If Count2 = 0 Then
                    MessageBox.Show("Please Check the MemberID and Type", "Verify Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim stuMem As New ClassStudent
                stuMem.searchMember(tbMemId.Text, cmbType.Text)
                gbPer.Visible = True
                gbStu.Visible = True
                gbStaff.Visible = False
                tbStuNo.Text = stuMem.MemberId
                cmbTitle.Text = stuMem.Title
                tblName.Text = stuMem.LName
                tbInit.Text = stuMem.Init
                tbConNo.Text = stuMem.ConNo
                tbTmpAdd.Text = stuMem.TmpAdd
                tbPemAdd.Text = stuMem.PermAdd
                tbUnvId.Text = stuMem.UnvId
                tbNID.Text = stuMem.NID
                cmbLevel.Text = stuMem.Level
                cmbStuStg.Text = stuMem.StuStg
                End If
            End If

        Me.Addlist()

    End Sub

#End Region

#Region "Update Member"

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If cmbType.Text = "Staff" And tbUnvId.Text <> "" And cmbTitle.Text <> "" And tbInit.Text <> "" And tblName.Text <> "" And tbNID.Text <> "" And tbTmpAdd.Text <> "" And tbPemAdd.Text <> "" And tbMemId.Text <> "" And cmbDeptName.Text <> "" And cmbstg.Text <> "" Then
            Dim stfMem As New ClassStaff
            stfMem.EditMember(tbUnvId.Text, cmbTitle.Text, tbInit.Text, tblName.Text, tbConNo.Text, tbNID.Text, tbTmpAdd.Text, tbPemAdd.Text, tbMemId.Text, cmbDeptName.Text, cmbstg.Text)

        ElseIf cmbType.Text = "Student" And tbStuNo.Text <> "" And cmbTitle.Text <> "" And tbInit.Text <> "" And tblName.Text <> "" And tbNID.Text <> "" And tbTmpAdd.Text <> "" And tbPemAdd.Text <> "" And tbMemId.Text <> "" And cmbLevel.Text <> "" And cmbStuStg.Text <> "" Then
            Dim stuMem As New ClassStudent
            stuMem.EditMember(tbStuNo.Text, cmbTitle.Text, tbInit.Text, tblName.Text, tbConNo.Text, tbNID.Text, tbTmpAdd.Text, tbPemAdd.Text, tbMemId.Text, cmbLevel.Text, cmbStuStg.Text)
        Else
            MessageBox.Show("Please enter the relevent details")
        End If

    End Sub
#End Region

#Region "Clear"

    Sub Clear()

        cmbTitle.Text = ""
        tblName.Text = ""
        tbInit.Text = ""
        tbConNo.Text = ""
        tbTmpAdd.Text = ""
        tbPemAdd.Text = ""
        tbUnvId.Text = ""
        tbNID.Text = ""
        cmbDeptName.Text = ""
        cmbstg.Text = ""
        tbStuNo.Text = ""
        cmbLevel.Text = ""
        cmbStuStg.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Clear()

    End Sub

#End Region

#Region "Error Handling"

    Private Sub tbConNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbConNo.Leave

        If tbConNo.Text Like "##########" Then
            ep1.Dispose()
            Exit Sub
        ElseIf tbConNo.TextLength < 10 Then
            ep1.SetError(tbConNo, "Input 10 digit number")
            ep1.SetIconAlignment(tbConNo, ErrorIconAlignment.TopLeft)
            ep1.BlinkRate.Equals(1)
        ElseIf tbConNo.Text Like "*?*" Then
            ep1.SetError(tbConNo, "Accept Only Digits")
            ep1.SetIconAlignment(tbConNo, ErrorIconAlignment.TopLeft)
            ep1.BlinkRate.Equals(1)
        End If

    End Sub

    Private Sub tbNID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbNID.Leave

        If tbNID.Text Like "#########v" Then
            ep1.Dispose()
            Exit Sub
        ElseIf tbNID.TextLength < 10 Then
            ep1.SetError(tbNID, "Does not match")
            ep1.SetIconAlignment(tbNID, ErrorIconAlignment.BottomLeft)
            ep1.BlinkRate.Equals(1)
        ElseIf tbNID.Text Like "#########?" Then
            ep1.SetError(tbNID, "Should End With 'V'")
            ep1.SetIconAlignment(tbNID, ErrorIconAlignment.BottomLeft)
            ep1.BlinkRate.Equals(1)
            'ElseIf tbNID.Text Like "*?*?" Then
            '    ep1.SetError(tbNID, "Does not match")
            '    ep1.SetIconAlignment(tbNID, ErrorIconAlignment.BottomLeft)
            '    ep1.BlinkRate.Equals(1)
        End If

    End Sub

#End Region

#Region "Add List"

    Private Sub cmbLevel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLevel.Leave

        cmbStuStg.Items.Clear()
        Me.Addlist()

    End Sub

    Sub Addlist()

        cmbStuStg.Items.Clear()
        If cmbLevel.Text = "Undergraduate" Then
            cmbStuStg.Items.Add("1st Year")
            cmbStuStg.Items.Add("2nd Year")
            cmbStuStg.Items.Add("3rd Year")
            cmbStuStg.Items.Add("4th Year")
        ElseIf cmbLevel.Text = "Postgraduate" Then
            cmbStuStg.Items.Add("1st Year")
            cmbStuStg.Items.Add("2nd Year")
        End If

    End Sub

#End Region
    
End Class
