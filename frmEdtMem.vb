Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents gbStaff As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbName As System.Windows.Forms.GroupBox
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tbInit As System.Windows.Forms.TextBox
    Friend WithEvents Initial As System.Windows.Forms.Label
    Friend WithEvents tbconNo As System.Windows.Forms.TextBox
    Friend WithEvents tbtmpAdd As System.Windows.Forms.TextBox
    Friend WithEvents tbPemAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbNID As System.Windows.Forms.TextBox
    Friend WithEvents tbStuNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbStu As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStuStg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLvl As System.Windows.Forms.ComboBox
    Friend WithEvents tbUnvId As System.Windows.Forms.TextBox
    Friend WithEvents tbNaID As System.Windows.Forms.TextBox
    Friend WithEvents cmbstg As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents tbMemId As System.Windows.Forms.TextBox
    Friend WithEvents cmbDeptName As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents gbPer As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTyp As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.gbPer = New System.Windows.Forms.GroupBox
        Me.tbInit = New System.Windows.Forms.TextBox
        Me.Initial = New System.Windows.Forms.Label
        Me.tblName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.tbNID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbconNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tbPemAdd = New System.Windows.Forms.TextBox
        Me.tbtmpAdd = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.gbStaff = New System.Windows.Forms.GroupBox
        Me.cmbstg = New System.Windows.Forms.ComboBox
        Me.cmbDeptName = New System.Windows.Forms.ComboBox
        Me.tbUnvId = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.gbStu = New System.Windows.Forms.GroupBox
        Me.cmbStuStg = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tbMemId = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbLevel = New System.Windows.Forms.ComboBox
        Me.cmbTyp = New System.Windows.Forms.ComboBox
        Me.gbPer.SuspendLayout()
        Me.gbStaff.SuspendLayout()
        Me.gbStu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(416, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 63
        Me.btnSearch.Text = "&Search"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Location = New System.Drawing.Point(7, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Enter the Member ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(232, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmbType.Items.AddRange(New Object() {"Staff", "Student"})
        Me.cmbType.Location = New System.Drawing.Point(712, 208)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 156
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
        Me.gbPer.Controls.Add(Me.tbconNo)
        Me.gbPer.Controls.Add(Me.Label14)
        Me.gbPer.Controls.Add(Me.tbPemAdd)
        Me.gbPer.Controls.Add(Me.tbtmpAdd)
        Me.gbPer.Controls.Add(Me.Label15)
        Me.gbPer.Controls.Add(Me.Label16)
        Me.gbPer.Location = New System.Drawing.Point(7, 48)
        Me.gbPer.Name = "gbPer"
        Me.gbPer.Size = New System.Drawing.Size(392, 200)
        Me.gbPer.TabIndex = 201
        Me.gbPer.TabStop = False
        Me.gbPer.Text = "Personal Details"
        '
        'tbInit
        '
        Me.tbInit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbInit.Location = New System.Drawing.Point(320, 48)
        Me.tbInit.MaxLength = 10
        Me.tbInit.Name = "tbInit"
        Me.tbInit.Size = New System.Drawing.Size(64, 20)
        Me.tbInit.TabIndex = 195
        Me.tbInit.Text = ""
        '
        'Initial
        '
        Me.Initial.BackColor = System.Drawing.SystemColors.Highlight
        Me.Initial.Location = New System.Drawing.Point(280, 48)
        Me.Initial.Name = "Initial"
        Me.Initial.Size = New System.Drawing.Size(32, 23)
        Me.Initial.TabIndex = 194
        Me.Initial.Text = "Initial"
        Me.Initial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblName
        '
        Me.tblName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tblName.Location = New System.Drawing.Point(112, 48)
        Me.tblName.MaxLength = 50
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(161, 20)
        Me.tblName.TabIndex = 191
        Me.tblName.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Location = New System.Drawing.Point(16, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 23)
        Me.Label18.TabIndex = 189
        Me.Label18.Text = "Last Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 23)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTitle.ItemHeight = 13
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(112, 16)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(56, 21)
        Me.cmbTitle.TabIndex = 193
        '
        'tbNID
        '
        Me.tbNID.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbNID.Location = New System.Drawing.Point(112, 80)
        Me.tbNID.MaxLength = 10
        Me.tbNID.Name = "tbNID"
        Me.tbNID.Size = New System.Drawing.Size(132, 20)
        Me.tbNID.TabIndex = 186
        Me.tbNID.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = " National ID No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbconNo
        '
        Me.tbconNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbconNo.Location = New System.Drawing.Point(112, 112)
        Me.tbconNo.MaxLength = 10
        Me.tbconNo.Name = "tbconNo"
        Me.tbconNo.Size = New System.Drawing.Size(128, 20)
        Me.tbconNo.TabIndex = 185
        Me.tbconNo.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(16, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 23)
        Me.Label14.TabIndex = 184
        Me.Label14.Text = "Contact No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPemAdd
        '
        Me.tbPemAdd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbPemAdd.Location = New System.Drawing.Point(112, 168)
        Me.tbPemAdd.MaxLength = 250
        Me.tbPemAdd.Name = "tbPemAdd"
        Me.tbPemAdd.Size = New System.Drawing.Size(200, 20)
        Me.tbPemAdd.TabIndex = 183
        Me.tbPemAdd.Text = ""
        '
        'tbtmpAdd
        '
        Me.tbtmpAdd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbtmpAdd.Location = New System.Drawing.Point(112, 137)
        Me.tbtmpAdd.MaxLength = 250
        Me.tbtmpAdd.Name = "tbtmpAdd"
        Me.tbtmpAdd.Size = New System.Drawing.Size(200, 20)
        Me.tbtmpAdd.TabIndex = 182
        Me.tbtmpAdd.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(16, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 23)
        Me.Label15.TabIndex = 181
        Me.Label15.Text = "Permanent Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(16, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 23)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Temporary Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbStaff
        '
        Me.gbStaff.Controls.Add(Me.cmbstg)
        Me.gbStaff.Controls.Add(Me.cmbDeptName)
        Me.gbStaff.Controls.Add(Me.tbUnvId)
        Me.gbStaff.Controls.Add(Me.Label20)
        Me.gbStaff.Controls.Add(Me.Label12)
        Me.gbStaff.Controls.Add(Me.Label13)
        Me.gbStaff.Location = New System.Drawing.Point(401, 96)
        Me.gbStaff.Name = "gbStaff"
        Me.gbStaff.Size = New System.Drawing.Size(240, 110)
        Me.gbStaff.TabIndex = 203
        Me.gbStaff.TabStop = False
        Me.gbStaff.Text = "Professional Details"
        '
        'cmbstg
        '
        Me.cmbstg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbstg.ItemHeight = 13
        Me.cmbstg.Items.AddRange(New Object() {"1st Year UnderGraduate", "2nd Year UnderGraduate", "3rd Year UnderGraduate", "4th Year UnderGraduate", "PostGraduate"})
        Me.cmbstg.Location = New System.Drawing.Point(102, 80)
        Me.cmbstg.Name = "cmbstg"
        Me.cmbstg.Size = New System.Drawing.Size(128, 21)
        Me.cmbstg.TabIndex = 208
        '
        'cmbDeptName
        '
        Me.cmbDeptName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbDeptName.ItemHeight = 13
        Me.cmbDeptName.Items.AddRange(New Object() {"Science", "Commerce and Management"})
        Me.cmbDeptName.Location = New System.Drawing.Point(102, 48)
        Me.cmbDeptName.Name = "cmbDeptName"
        Me.cmbDeptName.Size = New System.Drawing.Size(128, 21)
        Me.cmbDeptName.TabIndex = 207
        '
        'tbUnvId
        '
        Me.tbUnvId.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbUnvId.Location = New System.Drawing.Point(102, 16)
        Me.tbUnvId.MaxLength = 20
        Me.tbUnvId.Name = "tbUnvId"
        Me.tbUnvId.Size = New System.Drawing.Size(128, 20)
        Me.tbUnvId.TabIndex = 206
        Me.tbUnvId.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(8, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 23)
        Me.Label20.TabIndex = 205
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(8, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 23)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(8, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 23)
        Me.Label13.TabIndex = 203
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbStu
        '
        Me.gbStu.Controls.Add(Me.tbLevel)
        Me.gbStu.Controls.Add(Me.Label4)
        Me.gbStu.Controls.Add(Me.TextBox1)
        Me.gbStu.Controls.Add(Me.cmbStuStg)
        Me.gbStu.Controls.Add(Me.Label7)
        Me.gbStu.Controls.Add(Me.Label3)
        Me.gbStu.Location = New System.Drawing.Point(423, 208)
        Me.gbStu.Name = "gbStu"
        Me.gbStu.Size = New System.Drawing.Size(208, 112)
        Me.gbStu.TabIndex = 204
        Me.gbStu.TabStop = False
        Me.gbStu.Text = "Acedemic Details"
        '
        'cmbStuStg
        '
        Me.cmbStuStg.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbStuStg.ItemHeight = 13
        Me.cmbStuStg.Items.AddRange(New Object() {"1st Year ", "2nd Year ", "3rd Year ", "4th Year"})
        Me.cmbStuStg.Location = New System.Drawing.Point(72, 80)
        Me.cmbStuStg.Name = "cmbStuStg"
        Me.cmbStuStg.Size = New System.Drawing.Size(116, 21)
        Me.cmbStuStg.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 23)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Stage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Student No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 205
        Me.Button1.Text = "Button1"
        '
        'tbMemId
        '
        Me.tbMemId.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbMemId.Location = New System.Drawing.Point(120, 16)
        Me.tbMemId.MaxLength = 10
        Me.tbMemId.Name = "tbMemId"
        Me.tbMemId.Size = New System.Drawing.Size(104, 20)
        Me.tbMemId.TabIndex = 207
        Me.tbMemId.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(72, 24)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 207
        Me.TextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 23)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "Level"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbLevel
        '
        Me.tbLevel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbLevel.ItemHeight = 13
        Me.tbLevel.Items.AddRange(New Object() {"Undergraduate", "POstgraduate"})
        Me.tbLevel.Location = New System.Drawing.Point(72, 50)
        Me.tbLevel.Name = "tbLevel"
        Me.tbLevel.Size = New System.Drawing.Size(120, 21)
        Me.tbLevel.TabIndex = 209
        '
        'cmbTyp
        '
        Me.cmbTyp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTyp.ItemHeight = 13
        Me.cmbTyp.Items.AddRange(New Object() {"Staff", "Student"})
        Me.cmbTyp.Location = New System.Drawing.Point(280, 16)
        Me.cmbTyp.Name = "cmbTyp"
        Me.cmbTyp.Size = New System.Drawing.Size(80, 21)
        Me.cmbTyp.TabIndex = 208
        '
        'frmEditmem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(648, 326)
        Me.Controls.Add(Me.cmbTyp)
        Me.Controls.Add(Me.tbMemId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbStu)
        Me.Controls.Add(Me.gbStaff)
        Me.Controls.Add(Me.gbPer)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmEditmem"
        Me.Text = "Edit Member Details"
        Me.gbPer.ResumeLayout(False)
        Me.gbStaff.ResumeLayout(False)
        Me.gbStu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Search Member"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        gbPer.Visible = True
        If cmbTyp.Text = "Staff" Then
            gbStaff.Visible = True
            '  Dim trabs1 As SqlTransaction = Nothing
            ' trabs1 = sqlconn.BeginTransaction()
            Dim stSQL1 As String = "SELECT * FROM Member where memberID=' " & tbMemId.Text & " '"
            Dim Comm1 As New SqlCommand(stSQL1, sqlconn)
            Dim myReader1 As SqlDataReader
            Try
                sqlconn.Open()
                myReader1 = Comm1.ExecuteReader

                While (myReader1.Read())
                    cmbTitle.Text = myReader1("title")
                    tblName.Text = myReader1("lName")
                    tbInit.Text = myReader1("initial")
                    tbconNo.Text = myReader1("contactNo")
                    tbtmpAdd.Text = myReader1("termTimeAddress")
                    tbPemAdd.Text = myReader1("permanentAddress")
                    tbUnvId.Text = myReader1("memberID")
                    If Not myReader1.IsDBNull("nationalIDNo") Then
                        tbNaID.Text = myReader1("nationalIDNo")
                    End If
                End While

            Catch ex As Exception
            Finally
                myReader1.Close()
                sqlconn.Close()
            End Try

            Dim stSQL2 As String = "SELECT * FROM Staff where memberID=' " & tbMemId.Text & " '"
            Dim Comm2 As New SqlCommand(stSQL2, sqlconn)
            Dim myReader2 As SqlDataReader
            Try
                sqlconn.Open()
                myReader2 = Comm2.ExecuteReader

                While (myReader2.Read())
                    If Not myReader2.IsDBNull("dept") Then
                        cmbDeptName.Text = myReader2("dept")
                    End If
                    If Not myReader2.IsDBNull("position") Then
                        cmbstg.Text = myReader2("position")
                    End If
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                myReader2.Close()
                sqlconn.Close()
            End Try
            sqlconn.Close()

        ElseIf cmbTyp.Text = "Student" Then

            gbStu.Visible = True
            'Dim trabs2 As SqlTransaction = Nothing
            Dim stSQL3 As String = "SELECT * FROM Member where memberID=' " & tbMemId.Text & " '"
            Dim Comm3 As New SqlCommand(stSQL3, sqlconn)
            Dim myReader3 As SqlDataReader
            Try
                sqlconn.Open()
                myReader3 = Comm3.ExecuteReader

                While (myReader3.Read())
                    cmbTitle.Text = myReader3("title")
                    tblName.Text = myReader3("lName")
                    tbInit.Text = myReader3("initial")
                    tbconNo.Text = myReader3("contactNo")
                    tbtmpAdd.Text = myReader3("termTimeAddress")
                    tbPemAdd.Text = myReader3("permanentAddress")
                    tbStuNo.Text = myReader3("memberID")
                    tbNID.Text = myReader3("nationalIDNo")
                End While

            Catch ex As Exception
            Finally
                myReader3.Close()
                sqlconn.Close()
            End Try

            Dim stSQL4 As String = "SELECT * FROM Student where memberID=' " & tbMemId.Text & " '"
            Dim Comm4 As New SqlCommand(stSQL4, sqlconn)
            Dim myReader4 As SqlDataReader
            Try
                sqlconn.Open()
                myReader4 = Comm4.ExecuteReader

                While (myReader4.Read())
                    cmbLvl.Text = myReader4("level")
                    cmbStuStg.Text = myReader4("stage")
                End While

            Catch ex As Exception
            Finally
                myReader4.Close()
                sqlconn.Close()
            End Try


        End If

        '  btnSearch.Text = "Update"
        btnSearch.Name = "btnUpdate"
    End Sub

#End Region

#Region "Form load"
    Private Sub frmStaffEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbPer.Visible = False
        gbStaff.Visible = False
        gbStu.Visible = False
    End Sub
#End Region

    'Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SqlHelper.ExecuteNonQuery(CurrentUser.sqlconn, CommandType.Text, "update Member set title=' " & cmbTitle.Text & " ', initial=' " & tbInit.Text & " ', lName= contactNo=' " & tbconNo.Text & " ', where memberID=' " & tbMemId.Text & " '")
    '    MsgBox("OK")
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SqlHelper.ExecuteNonQuery(CurrentUser.sqlconn, CommandType.Text, "update Member set contactNo=' " & tbconNo.Text & " ' where memberID=' " & tbMemId.Text & " '")
        SqlHelper.ExecuteNonQuery(CurrentUser.sqlconn, CommandType.Text, "update Member set memberID=' " & cmbTitle.Text & " ',title=' " & cmbTitle.Text & " ', initial=' " & tbInit.Text & " ', lName=' " & tblName.Text & " ', contactNo=' " & tbconNo.Text & " ',nationalIDNo=' " & tbNID.Text & " ',termTimeAddress=' " & tbtmpAdd.Text & " ',permanentAddress=' " & tbPemAdd.Text & " ' where memberID=' " & tbMemId.Text & " '")
        MsgBox("OK")
    End Sub
    'Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    'Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
