Public Class frmStaffRegistration
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
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstage As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeptNo As System.Windows.Forms.ComboBox
    Friend WithEvents tbContactNo As System.Windows.Forms.TextBox
    Friend WithEvents tbPermenentAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbtempAddress As System.Windows.Forms.TextBox
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents tbfName As System.Windows.Forms.TextBox
    Friend WithEvents tbUniversityId As System.Windows.Forms.TextBox
    Friend WithEvents tbNationalId As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents btnChange2 As System.Windows.Forms.Button
    Friend WithEvents btnRegister2 As System.Windows.Forms.Button
    Friend WithEvents btnExit2 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(231, 144)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(224, 21)
        Me.cmbTitle.TabIndex = 125
        '
        'cmbstage
        '
        Me.cmbstage.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cmbstage.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.cmbstage.Location = New System.Drawing.Point(231, 336)
        Me.cmbstage.Name = "cmbstage"
        Me.cmbstage.Size = New System.Drawing.Size(224, 21)
        Me.cmbstage.TabIndex = 124
        '
        'cmbDeptNo
        '
        Me.cmbDeptNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cmbDeptNo.Items.AddRange(New Object() {"Science", "Commerce and Management"})
        Me.cmbDeptNo.Location = New System.Drawing.Point(231, 304)
        Me.cmbDeptNo.Name = "cmbDeptNo"
        Me.cmbDeptNo.Size = New System.Drawing.Size(224, 21)
        Me.cmbDeptNo.TabIndex = 122
        '
        'tbContactNo
        '
        Me.tbContactNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbContactNo.Location = New System.Drawing.Point(231, 264)
        Me.tbContactNo.Name = "tbContactNo"
        Me.tbContactNo.Size = New System.Drawing.Size(224, 20)
        Me.tbContactNo.TabIndex = 120
        Me.tbContactNo.Text = ""
        '
        'tbPermenentAddress
        '
        Me.tbPermenentAddress.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbPermenentAddress.Location = New System.Drawing.Point(231, 232)
        Me.tbPermenentAddress.Name = "tbPermenentAddress"
        Me.tbPermenentAddress.Size = New System.Drawing.Size(224, 20)
        Me.tbPermenentAddress.TabIndex = 119
        Me.tbPermenentAddress.Text = ""
        '
        'tbtempAddress
        '
        Me.tbtempAddress.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbtempAddress.Location = New System.Drawing.Point(231, 200)
        Me.tbtempAddress.Name = "tbtempAddress"
        Me.tbtempAddress.Size = New System.Drawing.Size(224, 20)
        Me.tbtempAddress.TabIndex = 118
        Me.tbtempAddress.Text = ""
        '
        'tblName
        '
        Me.tblName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tblName.Location = New System.Drawing.Point(231, 120)
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(224, 20)
        Me.tblName.TabIndex = 117
        Me.tblName.Text = ""
        '
        'tbfName
        '
        Me.tbfName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbfName.Location = New System.Drawing.Point(231, 96)
        Me.tbfName.Name = "tbfName"
        Me.tbfName.Size = New System.Drawing.Size(224, 20)
        Me.tbfName.TabIndex = 116
        Me.tbfName.Text = ""
        '
        'tbUniversityId
        '
        Me.tbUniversityId.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbUniversityId.Location = New System.Drawing.Point(231, 32)
        Me.tbUniversityId.Name = "tbUniversityId"
        Me.tbUniversityId.Size = New System.Drawing.Size(224, 20)
        Me.tbUniversityId.TabIndex = 115
        Me.tbUniversityId.Text = ""
        '
        'tbNationalId
        '
        Me.tbNationalId.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbNationalId.Location = New System.Drawing.Point(231, 64)
        Me.tbNationalId.Name = "tbNationalId"
        Me.tbNationalId.Size = New System.Drawing.Size(224, 20)
        Me.tbNationalId.TabIndex = 114
        Me.tbNationalId.Text = ""
        '
        'btnDelete2
        '
        Me.btnDelete2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.btnDelete2.Location = New System.Drawing.Point(519, 236)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.TabIndex = 113
        Me.btnDelete2.Text = "&Delete"
        '
        'btnChange2
        '
        Me.btnChange2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.btnChange2.Location = New System.Drawing.Point(519, 146)
        Me.btnChange2.Name = "btnChange2"
        Me.btnChange2.TabIndex = 112
        Me.btnChange2.Text = "&Change"
        '
        'btnRegister2
        '
        Me.btnRegister2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.btnRegister2.Location = New System.Drawing.Point(519, 56)
        Me.btnRegister2.Name = "btnRegister2"
        Me.btnRegister2.TabIndex = 111
        Me.btnRegister2.Text = "&Register"
        '
        'btnExit2
        '
        Me.btnExit2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.btnExit2.Location = New System.Drawing.Point(519, 326)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.TabIndex = 110
        Me.btnExit2.Text = "&Exit"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.RosyBrown
        Me.Label22.Location = New System.Drawing.Point(23, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 23)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = " National ID No"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.RosyBrown
        Me.Label20.Location = New System.Drawing.Point(23, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 23)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.RosyBrown
        Me.Label14.Location = New System.Drawing.Point(23, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 23)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Contact No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RosyBrown
        Me.Label15.Location = New System.Drawing.Point(23, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 23)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "Permanent Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.RosyBrown
        Me.Label16.Location = New System.Drawing.Point(23, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 23)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Temporary Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.RosyBrown
        Me.Label19.Location = New System.Drawing.Point(23, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 23)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RadioButton3.Location = New System.Drawing.Point(351, 176)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(88, 20)
        Me.RadioButton3.TabIndex = 103
        Me.RadioButton3.Text = "Female"
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.RadioButton4.Location = New System.Drawing.Point(223, 176)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(72, 20)
        Me.RadioButton4.TabIndex = 102
        Me.RadioButton4.Text = "Male"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.RosyBrown
        Me.Label11.Location = New System.Drawing.Point(23, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 23)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Sex"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.RosyBrown
        Me.Label12.Location = New System.Drawing.Point(23, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 23)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.RosyBrown
        Me.Label13.Location = New System.Drawing.Point(23, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 23)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.RosyBrown
        Me.Label17.Location = New System.Drawing.Point(23, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 23)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Last Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.RosyBrown
        Me.Label18.Location = New System.Drawing.Point(23, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 23)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ComboBox3.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.ComboBox3.Location = New System.Drawing.Point(231, 144)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox3.TabIndex = 126
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ComboBox4.Items.AddRange(New Object() {"Science", "Commerce and Management"})
        Me.ComboBox4.Location = New System.Drawing.Point(231, 304)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox4.TabIndex = 121
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ComboBox5.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.ComboBox5.Location = New System.Drawing.Point(231, 336)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox5.TabIndex = 123
        '
        'frmStaffRegistration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(616, 390)
        Me.Controls.Add(Me.cmbTitle)
        Me.Controls.Add(Me.cmbstage)
        Me.Controls.Add(Me.cmbDeptNo)
        Me.Controls.Add(Me.tbContactNo)
        Me.Controls.Add(Me.tbPermenentAddress)
        Me.Controls.Add(Me.tbtempAddress)
        Me.Controls.Add(Me.tblName)
        Me.Controls.Add(Me.tbfName)
        Me.Controls.Add(Me.tbUniversityId)
        Me.Controls.Add(Me.tbNationalId)
        Me.Controls.Add(Me.btnDelete2)
        Me.Controls.Add(Me.btnChange2)
        Me.Controls.Add(Me.btnRegister2)
        Me.Controls.Add(Me.btnExit2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox5)
        Me.Name = "frmStaffRegistration"
        Me.Text = "Staff Registration"
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class
