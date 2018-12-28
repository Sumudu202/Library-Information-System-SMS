Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
'Imports System.Data.SqlClient

Public Class frmEditmem
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMemId As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbPermenentAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbtempAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents tbfName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents btnChange2 As System.Windows.Forms.Button
    Friend WithEvents gbStaff As System.Windows.Forms.GroupBox
    Friend WithEvents tbNationalID As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbstage As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeptNo As System.Windows.Forms.ComboBox
    Friend WithEvents tbUniversityId As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbStu As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbtnPG As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUG As System.Windows.Forms.RadioButton
    Friend WithEvents tbNID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbStuNo As System.Windows.Forms.TextBox
    Friend WithEvents gbCont As System.Windows.Forms.GroupBox
    Friend WithEvents gbName As System.Windows.Forms.GroupBox
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbMemId = New System.Windows.Forms.TextBox
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.gbCont = New System.Windows.Forms.GroupBox
        Me.tbContactNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tbPermenentAddress = New System.Windows.Forms.TextBox
        Me.tbtempAddress = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.gbName = New System.Windows.Forms.GroupBox
        Me.tblName = New System.Windows.Forms.TextBox
        Me.tbfName = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.btnChange2 = New System.Windows.Forms.Button
        Me.gbStaff = New System.Windows.Forms.GroupBox
        Me.gbStu = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.rbtnPG = New System.Windows.Forms.RadioButton
        Me.rbtnUG = New System.Windows.Forms.RadioButton
        Me.tbNID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbStuNo = New System.Windows.Forms.TextBox
        Me.tbNationalID = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbstage = New System.Windows.Forms.ComboBox
        Me.cmbDeptNo = New System.Windows.Forms.ComboBox
        Me.tbUniversityId = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.gbCont.SuspendLayout()
        Me.gbName.SuspendLayout()
        Me.gbStaff.SuspendLayout()
        Me.gbStu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(520, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "&Save the changes"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(520, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 63
        Me.btnSearch.Text = "&Search"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Enter the Member ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbMemId
        '
        Me.tbMemId.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbMemId.Location = New System.Drawing.Point(144, 16)
        Me.tbMemId.Name = "tbMemId"
        Me.tbMemId.Size = New System.Drawing.Size(144, 20)
        Me.tbMemId.TabIndex = 71
        Me.tbMemId.Text = ""
        '
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(312, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbType
        '
        Me.cmbType.Items.AddRange(New Object() {"Staff", "Student"})
        Me.cmbType.Location = New System.Drawing.Point(360, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 156
        '
        'gbCont
        '
        Me.gbCont.Controls.Add(Me.tbContactNo)
        Me.gbCont.Controls.Add(Me.Label14)
        Me.gbCont.Controls.Add(Me.tbPermenentAddress)
        Me.gbCont.Controls.Add(Me.tbtempAddress)
        Me.gbCont.Controls.Add(Me.Label15)
        Me.gbCont.Controls.Add(Me.Label16)
        Me.gbCont.Location = New System.Drawing.Point(8, 192)
        Me.gbCont.Name = "gbCont"
        Me.gbCont.Size = New System.Drawing.Size(376, 135)
        Me.gbCont.TabIndex = 201
        Me.gbCont.TabStop = False
        Me.gbCont.Text = "Contact Details"
        '
        'tbContactNo
        '
        Me.tbContactNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbContactNo.Location = New System.Drawing.Point(120, 32)
        Me.tbContactNo.Name = "tbContactNo"
        Me.tbContactNo.Size = New System.Drawing.Size(128, 20)
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
        'tbPermenentAddress
        '
        Me.tbPermenentAddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbPermenentAddress.Location = New System.Drawing.Point(120, 104)
        Me.tbPermenentAddress.Name = "tbPermenentAddress"
        Me.tbPermenentAddress.Size = New System.Drawing.Size(248, 20)
        Me.tbPermenentAddress.TabIndex = 183
        Me.tbPermenentAddress.Text = ""
        '
        'tbtempAddress
        '
        Me.tbtempAddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbtempAddress.Location = New System.Drawing.Point(120, 68)
        Me.tbtempAddress.Name = "tbtempAddress"
        Me.tbtempAddress.Size = New System.Drawing.Size(248, 20)
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
        'gbName
        '
        Me.gbName.BackColor = System.Drawing.SystemColors.Highlight
        Me.gbName.Controls.Add(Me.tblName)
        Me.gbName.Controls.Add(Me.tbfName)
        Me.gbName.Controls.Add(Me.Label17)
        Me.gbName.Controls.Add(Me.Label18)
        Me.gbName.Controls.Add(Me.Label19)
        Me.gbName.Controls.Add(Me.cmbTitle)
        Me.gbName.Location = New System.Drawing.Point(8, 56)
        Me.gbName.Name = "gbName"
        Me.gbName.Size = New System.Drawing.Size(377, 120)
        Me.gbName.TabIndex = 199
        Me.gbName.TabStop = False
        Me.gbName.Text = "Name"
        '
        'tblName
        '
        Me.tblName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tblName.Location = New System.Drawing.Point(136, 88)
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(232, 20)
        Me.tblName.TabIndex = 182
        Me.tblName.Text = ""
        '
        'tbfName
        '
        Me.tbfName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbfName.Location = New System.Drawing.Point(136, 59)
        Me.tbfName.Name = "tbfName"
        Me.tbfName.Size = New System.Drawing.Size(232, 20)
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
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTitle.ItemHeight = 13
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(136, 27)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(72, 21)
        Me.cmbTitle.TabIndex = 185
        '
        'btnChange2
        '
        Me.btnChange2.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnChange2.Location = New System.Drawing.Point(424, 232)
        Me.btnChange2.Name = "btnChange2"
        Me.btnChange2.TabIndex = 195
        Me.btnChange2.Text = "&Change"
        '
        'gbStaff
        '
        Me.gbStaff.Controls.Add(Me.gbStu)
        Me.gbStaff.Controls.Add(Me.tbNationalID)
        Me.gbStaff.Controls.Add(Me.Label22)
        Me.gbStaff.Controls.Add(Me.cmbstage)
        Me.gbStaff.Controls.Add(Me.cmbDeptNo)
        Me.gbStaff.Controls.Add(Me.tbUniversityId)
        Me.gbStaff.Controls.Add(Me.Label20)
        Me.gbStaff.Controls.Add(Me.Label12)
        Me.gbStaff.Controls.Add(Me.Label13)
        Me.gbStaff.Location = New System.Drawing.Point(408, 48)
        Me.gbStaff.Name = "gbStaff"
        Me.gbStaff.Size = New System.Drawing.Size(256, 144)
        Me.gbStaff.TabIndex = 203
        Me.gbStaff.TabStop = False
        Me.gbStaff.Text = "GroupBox3"
        '
        'gbStu
        '
        Me.gbStu.Controls.Add(Me.ComboBox1)
        Me.gbStu.Controls.Add(Me.Label7)
        Me.gbStu.Controls.Add(Me.rbtnPG)
        Me.gbStu.Controls.Add(Me.rbtnUG)
        Me.gbStu.Controls.Add(Me.tbNID)
        Me.gbStu.Controls.Add(Me.Label2)
        Me.gbStu.Controls.Add(Me.Label3)
        Me.gbStu.Controls.Add(Me.tbStuNo)
        Me.gbStu.Location = New System.Drawing.Point(0, 0)
        Me.gbStu.Name = "gbStu"
        Me.gbStu.Size = New System.Drawing.Size(256, 144)
        Me.gbStu.TabIndex = 211
        Me.gbStu.TabStop = False
        Me.gbStu.Text = "GroupBox3"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"1st Year ", "2nd Year ", "3rd Year ", "4th Year"})
        Me.ComboBox1.Location = New System.Drawing.Point(110, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 143
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Stage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtnPG
        '
        Me.rbtnPG.Location = New System.Drawing.Point(128, 77)
        Me.rbtnPG.Name = "rbtnPG"
        Me.rbtnPG.Size = New System.Drawing.Size(96, 24)
        Me.rbtnPG.TabIndex = 146
        Me.rbtnPG.Text = "&Postgraduate"
        '
        'rbtnUG
        '
        Me.rbtnUG.Location = New System.Drawing.Point(16, 77)
        Me.rbtnUG.Name = "rbtnUG"
        Me.rbtnUG.TabIndex = 142
        Me.rbtnUG.Text = "&Undergraduate"
        '
        'tbNID
        '
        Me.tbNID.BackColor = System.Drawing.Color.SeaShell
        Me.tbNID.Location = New System.Drawing.Point(110, 53)
        Me.tbNID.Name = "tbNID"
        Me.tbNID.Size = New System.Drawing.Size(132, 20)
        Me.tbNID.TabIndex = 141
        Me.tbNID.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = " National ID No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Student No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbStuNo
        '
        Me.tbStuNo.BackColor = System.Drawing.Color.SeaShell
        Me.tbStuNo.Location = New System.Drawing.Point(110, 24)
        Me.tbStuNo.Name = "tbStuNo"
        Me.tbStuNo.Size = New System.Drawing.Size(132, 20)
        Me.tbStuNo.TabIndex = 140
        Me.tbStuNo.Text = ""
        '
        'tbNationalID
        '
        Me.tbNationalID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbNationalID.Location = New System.Drawing.Point(116, 48)
        Me.tbNationalID.Name = "tbNationalID"
        Me.tbNationalID.Size = New System.Drawing.Size(128, 20)
        Me.tbNationalID.TabIndex = 210
        Me.tbNationalID.Text = ""
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Location = New System.Drawing.Point(20, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 23)
        Me.Label22.TabIndex = 209
        Me.Label22.Text = " National ID No"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbstage
        '
        Me.cmbstage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbstage.ItemHeight = 13
        Me.cmbstage.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.cmbstage.Location = New System.Drawing.Point(116, 112)
        Me.cmbstage.Name = "cmbstage"
        Me.cmbstage.Size = New System.Drawing.Size(128, 21)
        Me.cmbstage.TabIndex = 208
        '
        'cmbDeptNo
        '
        Me.cmbDeptNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbDeptNo.ItemHeight = 13
        Me.cmbDeptNo.Items.AddRange(New Object() {"Science", "Commerce and Management"})
        Me.cmbDeptNo.Location = New System.Drawing.Point(116, 80)
        Me.cmbDeptNo.Name = "cmbDeptNo"
        Me.cmbDeptNo.Size = New System.Drawing.Size(128, 21)
        Me.cmbDeptNo.TabIndex = 207
        '
        'tbUniversityId
        '
        Me.tbUniversityId.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbUniversityId.Location = New System.Drawing.Point(113, 16)
        Me.tbUniversityId.Name = "tbUniversityId"
        Me.tbUniversityId.Size = New System.Drawing.Size(128, 20)
        Me.tbUniversityId.TabIndex = 206
        Me.tbUniversityId.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(20, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 23)
        Me.Label20.TabIndex = 205
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(20, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(20, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 23)
        Me.Label13.TabIndex = 203
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEditmem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(768, 398)
        Me.Controls.Add(Me.gbStaff)
        Me.Controls.Add(Me.gbCont)
        Me.Controls.Add(Me.gbName)
        Me.Controls.Add(Me.btnChange2)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMemId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmEditmem"
        Me.Text = "Edit Member Details"
        Me.gbCont.ResumeLayout(False)
        Me.gbName.ResumeLayout(False)
        Me.gbStaff.ResumeLayout(False)
        Me.gbStu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cmbType.Text = "Staff" Then
            gbStaff.Visible = True And gbStu.Visible = False
        ElseIf cmbType.Text = "Student" Then
            gbStaff.Visible = False And gbStu.Visible = True
        End If
        gbName.Visible = True
        gbCont.Visible = True
        Try
            sqlconn.Open()
            Dim avail As Integer
            If cmbType.Text = "Staff" Then
                avail = SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "select * from Staff where memberID='201a'")
                If avail > 0 Then
                    MessageBox.Show("Ready")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        sqlconn.Close()

    End Sub

    Private Sub frmStaffEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gbStaff.Visible = False
        gbStu.Visible = False
        gbCont.Visible = False
        gbName.Visible = False


    End Sub

    Private Sub gbstf_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbStu.Enter

    End Sub
End Class
