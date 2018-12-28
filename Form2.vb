Public Class Form2
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
    Friend WithEvents tbUniversityId As System.Windows.Forms.TextBox
    Friend WithEvents btnChange2 As System.Windows.Forms.Button
    Friend WithEvents btnRegister2 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents tbfName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbPermenentAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbtempAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.cmbstage = New System.Windows.Forms.ComboBox
        Me.cmbDeptNo = New System.Windows.Forms.ComboBox
        Me.tbUniversityId = New System.Windows.Forms.TextBox
        Me.btnChange2 = New System.Windows.Forms.Button
        Me.btnRegister2 = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tblName = New System.Windows.Forms.TextBox
        Me.tbfName = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbPermenentAddress = New System.Windows.Forms.TextBox
        Me.tbtempAddress = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tbContactNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTitle.ItemHeight = 13
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(136, 30)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(72, 21)
        Me.cmbTitle.TabIndex = 185
        '
        'cmbstage
        '
        Me.cmbstage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbstage.ItemHeight = 13
        Me.cmbstage.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.cmbstage.Location = New System.Drawing.Point(552, 120)
        Me.cmbstage.Name = "cmbstage"
        Me.cmbstage.Size = New System.Drawing.Size(112, 21)
        Me.cmbstage.TabIndex = 184
        '
        'cmbDeptNo
        '
        Me.cmbDeptNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbDeptNo.ItemHeight = 13
        Me.cmbDeptNo.Items.AddRange(New Object() {"Science", "Commerce and Management"})
        Me.cmbDeptNo.Location = New System.Drawing.Point(552, 88)
        Me.cmbDeptNo.Name = "cmbDeptNo"
        Me.cmbDeptNo.Size = New System.Drawing.Size(112, 21)
        Me.cmbDeptNo.TabIndex = 182
        '
        'tbUniversityId
        '
        Me.tbUniversityId.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbUniversityId.Location = New System.Drawing.Point(536, 24)
        Me.tbUniversityId.Name = "tbUniversityId"
        Me.tbUniversityId.Size = New System.Drawing.Size(128, 20)
        Me.tbUniversityId.TabIndex = 175
        Me.tbUniversityId.Text = ""
        '
        'btnChange2
        '
        Me.btnChange2.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnChange2.Location = New System.Drawing.Point(456, 240)
        Me.btnChange2.Name = "btnChange2"
        Me.btnChange2.TabIndex = 172
        Me.btnChange2.Text = "&Change"
        '
        'btnRegister2
        '
        Me.btnRegister2.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRegister2.Location = New System.Drawing.Point(440, 168)
        Me.btnRegister2.Name = "btnRegister2"
        Me.btnRegister2.TabIndex = 171
        Me.btnRegister2.Text = "&Register"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(440, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 23)
        Me.Label20.TabIndex = 168
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Location = New System.Drawing.Point(16, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 23)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(440, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 23)
        Me.Label12.TabIndex = 160
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(440, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 23)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.tblName)
        Me.GroupBox1.Controls.Add(Me.tbfName)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbTitle)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 120)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name"
        '
        'tblName
        '
        Me.tblName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tblName.Location = New System.Drawing.Point(136, 88)
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(256, 20)
        Me.tblName.TabIndex = 182
        Me.tblName.Text = ""
        '
        'tbfName
        '
        Me.tbfName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbfName.Location = New System.Drawing.Point(136, 59)
        Me.tbfName.Name = "tbfName"
        Me.tbfName.Size = New System.Drawing.Size(256, 20)
        Me.tbfName.TabIndex = 181
        Me.tbfName.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Location = New System.Drawing.Point(16, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 23)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "Last Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Location = New System.Drawing.Point(16, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 23)
        Me.Label18.TabIndex = 178
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Location = New System.Drawing.Point(440, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 23)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = " National ID No"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbContactNo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tbPermenentAddress)
        Me.GroupBox2.Controls.Add(Me.tbtempAddress)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 135)
        Me.GroupBox2.TabIndex = 189
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Details"
        '
        'tbPermenentAddress
        '
        Me.tbPermenentAddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbPermenentAddress.Location = New System.Drawing.Point(152, 104)
        Me.tbPermenentAddress.Name = "tbPermenentAddress"
        Me.tbPermenentAddress.Size = New System.Drawing.Size(237, 20)
        Me.tbPermenentAddress.TabIndex = 183
        Me.tbPermenentAddress.Text = ""
        '
        'tbtempAddress
        '
        Me.tbtempAddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbtempAddress.Location = New System.Drawing.Point(152, 68)
        Me.tbtempAddress.Name = "tbtempAddress"
        Me.tbtempAddress.Size = New System.Drawing.Size(237, 20)
        Me.tbtempAddress.TabIndex = 182
        Me.tbtempAddress.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(16, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 23)
        Me.Label15.TabIndex = 181
        Me.Label15.Text = "Permanent Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(16, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 23)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Temporary Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbContactNo
        '
        Me.tbContactNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbContactNo.Location = New System.Drawing.Point(152, 32)
        Me.tbContactNo.Name = "tbContactNo"
        Me.tbContactNo.Size = New System.Drawing.Size(240, 20)
        Me.tbContactNo.TabIndex = 185
        Me.tbContactNo.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(16, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 23)
        Me.Label14.TabIndex = 184
        Me.Label14.Text = "Contact No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Location = New System.Drawing.Point(536, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 190
        Me.TextBox1.Text = ""
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(680, 302)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbstage)
        Me.Controls.Add(Me.cmbDeptNo)
        Me.Controls.Add(Me.tbUniversityId)
        Me.Controls.Add(Me.btnChange2)
        Me.Controls.Add(Me.btnRegister2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
