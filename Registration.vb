Public Class Registration
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabStudent As System.Windows.Forms.TabPage
    Friend WithEvents tabPStudent As System.Windows.Forms.TabPage
    Friend WithEvents tabStaff As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnRegister1 As System.Windows.Forms.Button
    Friend WithEvents btnExit1 As System.Windows.Forms.Button
    Friend WithEvents btnRegister2 As System.Windows.Forms.Button
    Friend WithEvents btnExit2 As System.Windows.Forms.Button
    Friend WithEvents btnChange1 As System.Windows.Forms.Button
    Friend WithEvents btnChange2 As System.Windows.Forms.Button
    Friend WithEvents tbNationalId As System.Windows.Forms.TextBox
    Friend WithEvents tbUniversityId As System.Windows.Forms.TextBox
    Friend WithEvents tbfName As System.Windows.Forms.TextBox
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents tbtempAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbPermenentAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbContactNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbDeptNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstage As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents btnDelete1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabStudent = New System.Windows.Forms.TabPage
        Me.btnDelete1 = New System.Windows.Forms.Button
        Me.btnChange1 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnRegister1 = New System.Windows.Forms.Button
        Me.btnExit1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.tabStaff = New System.Windows.Forms.TabPage
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.cmbstage = New System.Windows.Forms.ComboBox
        Me.cmbDeptNo = New System.Windows.Forms.ComboBox
        Me.tbContactNo = New System.Windows.Forms.TextBox
        Me.tbPermenentAddress = New System.Windows.Forms.TextBox
        Me.tbtempAddress = New System.Windows.Forms.TextBox
        Me.tblName = New System.Windows.Forms.TextBox
        Me.tbfName = New System.Windows.Forms.TextBox
        Me.tbUniversityId = New System.Windows.Forms.TextBox
        Me.tbNationalId = New System.Windows.Forms.TextBox
        Me.btnDelete2 = New System.Windows.Forms.Button
        Me.btnChange2 = New System.Windows.Forms.Button
        Me.btnRegister2 = New System.Windows.Forms.Button
        Me.btnExit2 = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.tabPStudent = New System.Windows.Forms.TabPage
        Me.TabControl1.SuspendLayout()
        Me.tabStudent.SuspendLayout()
        Me.tabStaff.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabStudent)
        Me.TabControl1.Controls.Add(Me.tabStaff)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(616, 390)
        Me.TabControl1.TabIndex = 0
        '
        'tabStudent
        '
        Me.tabStudent.BackColor = System.Drawing.Color.Gray
        Me.tabStudent.Controls.Add(Me.btnDelete1)
        Me.tabStudent.Controls.Add(Me.btnChange1)
        Me.tabStudent.Controls.Add(Me.ComboBox2)
        Me.tabStudent.Controls.Add(Me.Label10)
        Me.tabStudent.Controls.Add(Me.TextBox7)
        Me.tabStudent.Controls.Add(Me.Label9)
        Me.tabStudent.Controls.Add(Me.RadioButton2)
        Me.tabStudent.Controls.Add(Me.RadioButton1)
        Me.tabStudent.Controls.Add(Me.Label8)
        Me.tabStudent.Controls.Add(Me.btnRegister1)
        Me.tabStudent.Controls.Add(Me.btnExit1)
        Me.tabStudent.Controls.Add(Me.ComboBox1)
        Me.tabStudent.Controls.Add(Me.TextBox6)
        Me.tabStudent.Controls.Add(Me.TextBox5)
        Me.tabStudent.Controls.Add(Me.TextBox4)
        Me.tabStudent.Controls.Add(Me.TextBox3)
        Me.tabStudent.Controls.Add(Me.Label7)
        Me.tabStudent.Controls.Add(Me.Label6)
        Me.tabStudent.Controls.Add(Me.Label5)
        Me.tabStudent.Controls.Add(Me.Label4)
        Me.tabStudent.Controls.Add(Me.Label3)
        Me.tabStudent.Controls.Add(Me.Label2)
        Me.tabStudent.Controls.Add(Me.Label1)
        Me.tabStudent.Controls.Add(Me.TextBox1)
        Me.tabStudent.Controls.Add(Me.TextBox2)
        Me.tabStudent.ForeColor = System.Drawing.Color.Black
        Me.tabStudent.Location = New System.Drawing.Point(4, 22)
        Me.tabStudent.Name = "tabStudent"
        Me.tabStudent.Size = New System.Drawing.Size(608, 364)
        Me.tabStudent.TabIndex = 0
        Me.tabStudent.Tag = "To add an new student click on this"
        Me.tabStudent.Text = " Students"
        '
        'btnDelete1
        '
        Me.btnDelete1.BackColor = System.Drawing.Color.Tan
        Me.btnDelete1.Location = New System.Drawing.Point(512, 184)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(72, 24)
        Me.btnDelete1.TabIndex = 59
        Me.btnDelete1.Text = "&Delete"
        '
        'btnChange1
        '
        Me.btnChange1.BackColor = System.Drawing.Color.Tan
        Me.btnChange1.Location = New System.Drawing.Point(512, 112)
        Me.btnChange1.Name = "btnChange1"
        Me.btnChange1.Size = New System.Drawing.Size(72, 24)
        Me.btnChange1.TabIndex = 58
        Me.btnChange1.Text = "&Change"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox2.Items.AddRange(New Object() {"Rev", "Mr", "Mrs", "Miss", ""})
        Me.ComboBox2.Location = New System.Drawing.Point(232, 144)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox2.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DimGray
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(32, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 24)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Title"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox7.Location = New System.Drawing.Point(232, 48)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(216, 20)
        Me.TextBox7.TabIndex = 55
        Me.TextBox7.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 23)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = " National ID No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(360, 176)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton2.TabIndex = 53
        Me.RadioButton2.Text = "Female"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(240, 176)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton1.TabIndex = 52
        Me.RadioButton1.Text = "Male"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DimGray
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(32, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Sex"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister1
        '
        Me.btnRegister1.BackColor = System.Drawing.Color.Tan
        Me.btnRegister1.Location = New System.Drawing.Point(512, 40)
        Me.btnRegister1.Name = "btnRegister1"
        Me.btnRegister1.Size = New System.Drawing.Size(72, 24)
        Me.btnRegister1.TabIndex = 50
        Me.btnRegister1.Text = "&Register"
        '
        'btnExit1
        '
        Me.btnExit1.BackColor = System.Drawing.Color.Tan
        Me.btnExit1.Location = New System.Drawing.Point(512, 264)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(72, 24)
        Me.btnExit1.TabIndex = 49
        Me.btnExit1.Text = "&Exit"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox1.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.ComboBox1.Location = New System.Drawing.Point(232, 304)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox6.Location = New System.Drawing.Point(232, 272)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 20)
        Me.TextBox6.TabIndex = 47
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox5.Location = New System.Drawing.Point(232, 240)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(216, 20)
        Me.TextBox5.TabIndex = 46
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox4.Location = New System.Drawing.Point(232, 208)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(216, 20)
        Me.TextBox4.TabIndex = 45
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox3.Location = New System.Drawing.Point(232, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 20)
        Me.TextBox3.TabIndex = 44
        Me.TextBox3.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Stage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Contact No"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(48, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Permanent Address"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 32)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Temporary Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Student No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox1.Location = New System.Drawing.Point(232, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox2.Location = New System.Drawing.Point(232, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 20)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = ""
        '
        'tabStaff
        '
        Me.tabStaff.BackColor = System.Drawing.Color.Gray
        Me.tabStaff.Controls.Add(Me.cmbTitle)
        Me.tabStaff.Controls.Add(Me.cmbstage)
        Me.tabStaff.Controls.Add(Me.cmbDeptNo)
        Me.tabStaff.Controls.Add(Me.tbContactNo)
        Me.tabStaff.Controls.Add(Me.tbPermenentAddress)
        Me.tabStaff.Controls.Add(Me.tbtempAddress)
        Me.tabStaff.Controls.Add(Me.tblName)
        Me.tabStaff.Controls.Add(Me.tbfName)
        Me.tabStaff.Controls.Add(Me.tbUniversityId)
        Me.tabStaff.Controls.Add(Me.tbNationalId)
        Me.tabStaff.Controls.Add(Me.btnDelete2)
        Me.tabStaff.Controls.Add(Me.btnChange2)
        Me.tabStaff.Controls.Add(Me.btnRegister2)
        Me.tabStaff.Controls.Add(Me.btnExit2)
        Me.tabStaff.Controls.Add(Me.Label22)
        Me.tabStaff.Controls.Add(Me.Label20)
        Me.tabStaff.Controls.Add(Me.Label14)
        Me.tabStaff.Controls.Add(Me.Label15)
        Me.tabStaff.Controls.Add(Me.Label16)
        Me.tabStaff.Controls.Add(Me.Label19)
        Me.tabStaff.Controls.Add(Me.RadioButton3)
        Me.tabStaff.Controls.Add(Me.RadioButton4)
        Me.tabStaff.Controls.Add(Me.Label11)
        Me.tabStaff.Controls.Add(Me.Label12)
        Me.tabStaff.Controls.Add(Me.Label13)
        Me.tabStaff.Controls.Add(Me.Label17)
        Me.tabStaff.Controls.Add(Me.Label18)
        Me.tabStaff.ForeColor = System.Drawing.Color.Black
        Me.tabStaff.Location = New System.Drawing.Point(4, 22)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Size = New System.Drawing.Size(608, 364)
        Me.tabStaff.TabIndex = 1
        Me.tabStaff.Text = "Permanent and Tempory Staff"
        '
        'cmbTitle
        '
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(216, 120)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(224, 21)
        Me.cmbTitle.TabIndex = 96
        '
        'cmbstage
        '
        Me.cmbstage.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.cmbstage.Location = New System.Drawing.Point(216, 312)
        Me.cmbstage.Name = "cmbstage"
        Me.cmbstage.Size = New System.Drawing.Size(224, 21)
        Me.cmbstage.TabIndex = 95
        '
        'cmbDeptNo
        '
        Me.cmbDeptNo.Items.AddRange(New Object() {"Science", "Commerce and Management"})
        Me.cmbDeptNo.Location = New System.Drawing.Point(216, 280)
        Me.cmbDeptNo.Name = "cmbDeptNo"
        Me.cmbDeptNo.Size = New System.Drawing.Size(224, 21)
        Me.cmbDeptNo.TabIndex = 94
        '
        'tbContactNo
        '
        Me.tbContactNo.Location = New System.Drawing.Point(216, 240)
        Me.tbContactNo.Name = "tbContactNo"
        Me.tbContactNo.Size = New System.Drawing.Size(224, 20)
        Me.tbContactNo.TabIndex = 93
        Me.tbContactNo.Text = ""
        '
        'tbPermenentAddress
        '
        Me.tbPermenentAddress.Location = New System.Drawing.Point(216, 208)
        Me.tbPermenentAddress.Name = "tbPermenentAddress"
        Me.tbPermenentAddress.Size = New System.Drawing.Size(224, 20)
        Me.tbPermenentAddress.TabIndex = 92
        Me.tbPermenentAddress.Text = ""
        '
        'tbtempAddress
        '
        Me.tbtempAddress.Location = New System.Drawing.Point(216, 176)
        Me.tbtempAddress.Name = "tbtempAddress"
        Me.tbtempAddress.Size = New System.Drawing.Size(224, 20)
        Me.tbtempAddress.TabIndex = 91
        Me.tbtempAddress.Text = ""
        '
        'tblName
        '
        Me.tblName.Location = New System.Drawing.Point(216, 96)
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(224, 20)
        Me.tblName.TabIndex = 90
        Me.tblName.Text = ""
        '
        'tbfName
        '
        Me.tbfName.Location = New System.Drawing.Point(216, 72)
        Me.tbfName.Name = "tbfName"
        Me.tbfName.Size = New System.Drawing.Size(224, 20)
        Me.tbfName.TabIndex = 89
        Me.tbfName.Text = ""
        '
        'tbUniversityId
        '
        Me.tbUniversityId.Location = New System.Drawing.Point(216, 8)
        Me.tbUniversityId.Name = "tbUniversityId"
        Me.tbUniversityId.Size = New System.Drawing.Size(224, 20)
        Me.tbUniversityId.TabIndex = 88
        Me.tbUniversityId.Text = ""
        '
        'tbNationalId
        '
        Me.tbNationalId.Location = New System.Drawing.Point(216, 40)
        Me.tbNationalId.Name = "tbNationalId"
        Me.tbNationalId.Size = New System.Drawing.Size(224, 20)
        Me.tbNationalId.TabIndex = 87
        Me.tbNationalId.Text = ""
        '
        'btnDelete2
        '
        Me.btnDelete2.BackColor = System.Drawing.Color.Olive
        Me.btnDelete2.Location = New System.Drawing.Point(512, 212)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.TabIndex = 86
        Me.btnDelete2.Text = "&Delete"
        '
        'btnChange2
        '
        Me.btnChange2.BackColor = System.Drawing.Color.Olive
        Me.btnChange2.Location = New System.Drawing.Point(512, 122)
        Me.btnChange2.Name = "btnChange2"
        Me.btnChange2.TabIndex = 85
        Me.btnChange2.Text = "&Change"
        '
        'btnRegister2
        '
        Me.btnRegister2.BackColor = System.Drawing.Color.Olive
        Me.btnRegister2.Location = New System.Drawing.Point(512, 32)
        Me.btnRegister2.Name = "btnRegister2"
        Me.btnRegister2.TabIndex = 84
        Me.btnRegister2.Text = "&Register"
        '
        'btnExit2
        '
        Me.btnExit2.BackColor = System.Drawing.Color.Olive
        Me.btnExit2.Location = New System.Drawing.Point(512, 302)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.TabIndex = 83
        Me.btnExit2.Text = "&Exit"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Gray
        Me.Label22.Location = New System.Drawing.Point(16, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(152, 23)
        Me.Label22.TabIndex = 82
        Me.Label22.Text = " National ID No"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(16, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 23)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(16, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 23)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Contact No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(16, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 23)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Permanent Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(16, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 23)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Temporary Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Gray
        Me.Label19.Location = New System.Drawing.Point(16, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 23)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.Gray
        Me.RadioButton3.Location = New System.Drawing.Point(344, 152)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(88, 20)
        Me.RadioButton3.TabIndex = 67
        Me.RadioButton3.Text = "Female"
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.Gray
        Me.RadioButton4.Location = New System.Drawing.Point(216, 152)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(116, 20)
        Me.RadioButton4.TabIndex = 66
        Me.RadioButton4.Text = "Male"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(16, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 23)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Sex"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(16, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 23)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(16, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 23)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Gray
        Me.Label17.Location = New System.Drawing.Point(16, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 23)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Last Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.Location = New System.Drawing.Point(16, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 23)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabPStudent
        '
        Me.tabPStudent.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.tabPStudent.Location = New System.Drawing.Point(4, 22)
        Me.tabPStudent.Name = "tabPStudent"
        Me.tabPStudent.Size = New System.Drawing.Size(496, 278)
        Me.tabPStudent.TabIndex = 1
        Me.tabPStudent.Text = "PostGraduate Student"
        '
        'Registration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 390)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.TabControl1.ResumeLayout(False)
        Me.tabStudent.ResumeLayout(False)
        Me.tabStaff.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub tabStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabStaff.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub btnExit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit1.Click
        Me.Close()

    End Sub
End Class
