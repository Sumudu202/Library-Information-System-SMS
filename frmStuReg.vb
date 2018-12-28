Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmStuReg
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPerAdd As System.Windows.Forms.TextBox
    Friend WithEvents tbTemAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStage As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbtnPG As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUG As System.Windows.Forms.RadioButton
    Friend WithEvents tbNID As System.Windows.Forms.TextBox
    Friend WithEvents tbStuNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTi As System.Windows.Forms.ComboBox
    Friend WithEvents tbInitial As System.Windows.Forms.TextBox
    Friend WithEvents tbLName As System.Windows.Forms.TextBox
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents im1 As System.Windows.Forms.ImageList
    Friend WithEvents tbTelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tp1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStuReg))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTi = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbInitial = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbLName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbTelNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbPerAdd = New System.Windows.Forms.TextBox
        Me.tbTemAdd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbStage = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.rbtnPG = New System.Windows.Forms.RadioButton
        Me.rbtnUG = New System.Windows.Forms.RadioButton
        Me.tbNID = New System.Windows.Forms.TextBox
        Me.tbStuNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.im1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnRegister = New System.Windows.Forms.Button
        Me.tp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTi)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbInitial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbLName)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name"
        '
        'cmbTi
        '
        Me.cmbTi.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTi.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTi.ItemHeight = 15
        Me.cmbTi.Items.AddRange(New Object() {"Rev", "Mr", "Mrs", "Miss", ""})
        Me.cmbTi.Location = New System.Drawing.Point(76, 20)
        Me.cmbTi.Name = "cmbTi"
        Me.cmbTi.Size = New System.Drawing.Size(68, 23)
        Me.cmbTi.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 31)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Title"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbInitial
        '
        Me.tbInitial.BackColor = System.Drawing.SystemColors.Window
        Me.tbInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInitial.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInitial.Location = New System.Drawing.Point(76, 83)
        Me.tbInitial.MaxLength = 10
        Me.tbInitial.Name = "tbInitial"
        Me.tbInitial.Size = New System.Drawing.Size(136, 21)
        Me.tbInitial.TabIndex = 2
        Me.tbInitial.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Initial"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbLName
        '
        Me.tbLName.BackColor = System.Drawing.SystemColors.Window
        Me.tbLName.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLName.Location = New System.Drawing.Point(76, 51)
        Me.tbLName.MaxLength = 50
        Me.tbLName.Name = "tbLName"
        Me.tbLName.Size = New System.Drawing.Size(200, 21)
        Me.tbLName.TabIndex = 1
        Me.tbLName.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbTelNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbPerAdd)
        Me.GroupBox2.Controls.Add(Me.tbTemAdd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 176)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Datails"
        '
        'tbTelNo
        '
        Me.tbTelNo.BackColor = System.Drawing.SystemColors.Window
        Me.tbTelNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelNo.Location = New System.Drawing.Point(74, 24)
        Me.tbTelNo.MaxLength = 10
        Me.tbTelNo.Name = "tbTelNo"
        Me.tbTelNo.Size = New System.Drawing.Size(112, 21)
        Me.tbTelNo.TabIndex = 3
        Me.tbTelNo.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Contact No"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPerAdd
        '
        Me.tbPerAdd.BackColor = System.Drawing.SystemColors.Window
        Me.tbPerAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPerAdd.Location = New System.Drawing.Point(72, 112)
        Me.tbPerAdd.MaxLength = 250
        Me.tbPerAdd.Multiline = True
        Me.tbPerAdd.Name = "tbPerAdd"
        Me.tbPerAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPerAdd.Size = New System.Drawing.Size(208, 55)
        Me.tbPerAdd.TabIndex = 5
        Me.tbPerAdd.Text = ""
        '
        'tbTemAdd
        '
        Me.tbTemAdd.BackColor = System.Drawing.SystemColors.Window
        Me.tbTemAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemAdd.Location = New System.Drawing.Point(72, 50)
        Me.tbTemAdd.MaxLength = 250
        Me.tbTemAdd.Multiline = True
        Me.tbTemAdd.Name = "tbTemAdd"
        Me.tbTemAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTemAdd.Size = New System.Drawing.Size(208, 55)
        Me.tbTemAdd.TabIndex = 4
        Me.tbTemAdd.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Permanent Address"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Term Time Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbStage)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.rbtnPG)
        Me.GroupBox3.Controls.Add(Me.rbtnUG)
        Me.GroupBox3.Controls.Add(Me.tbNID)
        Me.GroupBox3.Controls.Add(Me.tbStuNo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(304, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 160)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acedemic Details"
        '
        'cmbStage
        '
        Me.cmbStage.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStage.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStage.ItemHeight = 15
        Me.cmbStage.Location = New System.Drawing.Point(91, 121)
        Me.cmbStage.MaxLength = 10
        Me.cmbStage.Name = "cmbStage"
        Me.cmbStage.Size = New System.Drawing.Size(128, 23)
        Me.cmbStage.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Stage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbtnPG
        '
        Me.rbtnPG.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPG.Location = New System.Drawing.Point(111, 85)
        Me.rbtnPG.Name = "rbtnPG"
        Me.rbtnPG.Size = New System.Drawing.Size(96, 24)
        Me.rbtnPG.TabIndex = 9
        Me.rbtnPG.Text = "&Postgraduate"
        '
        'rbtnUG
        '
        Me.rbtnUG.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUG.Location = New System.Drawing.Point(7, 86)
        Me.rbtnUG.Name = "rbtnUG"
        Me.rbtnUG.TabIndex = 8
        Me.rbtnUG.Text = "&Undergraduate"
        '
        'tbNID
        '
        Me.tbNID.BackColor = System.Drawing.SystemColors.Window
        Me.tbNID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNID.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNID.Location = New System.Drawing.Point(90, 57)
        Me.tbNID.MaxLength = 10
        Me.tbNID.Name = "tbNID"
        Me.tbNID.Size = New System.Drawing.Size(132, 21)
        Me.tbNID.TabIndex = 7
        Me.tbNID.Text = ""
        '
        'tbStuNo
        '
        Me.tbStuNo.BackColor = System.Drawing.SystemColors.Window
        Me.tbStuNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbStuNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStuNo.Location = New System.Drawing.Point(90, 24)
        Me.tbStuNo.MaxLength = 20
        Me.tbStuNo.Name = "tbStuNo"
        Me.tbStuNo.Size = New System.Drawing.Size(132, 21)
        Me.tbStuNo.TabIndex = 6
        Me.tbStuNo.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 23)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = " National ID No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Student No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'im1
        '
        Me.im1.ImageSize = New System.Drawing.Size(16, 16)
        Me.im1.ImageStream = CType(resources.GetObject("im1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.im1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(385, 272)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRegister.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(385, 184)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 24)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "&Register"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(385, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 24)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        '
        'frmStuReg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(544, 310)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStuReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form load"

    Private Sub frmStuReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetCancelButton(btnCancel)

    End Sub

    Private Sub SetCancelButton(ByVal myCancelBtn As Button)

        Me.CancelButton = myCancelBtn

    End Sub

#End Region

#Region "Student registration"

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        Dim level As String
        If rbtnUG.Checked Then
            level = "Undergraduate"
        Else
            level = "Postgraduate"
        End If
        Dim Student As New ClassStudent
        Student.AddMember(tbStuNo.Text, cmbTi.Text, tbInitial.Text, tbLName.Text, tbNID.Text, tbTelNo.Text, tbTemAdd.Text, tbPerAdd.Text, level, cmbStage.Text)

    End Sub

#End Region

#Region "Clear fields"

    Private Sub Clear()

        cmbTi.Text = ""
        tbLName.Text = ""
        tbInitial.Text = ""
        tbStuNo.Text = ""
        tbNID.Text = ""
        cmbStage.Text = ""
        tbTemAdd.Text = ""
        tbPerAdd.Text = ""
        tbTelNo.Text = ""

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.Clear()

    End Sub

#End Region

#Region "Error Handling"

    Private Sub tbTelNo_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTelNo.Leave

        If tbTelNo.Text Like "##########" Then
            ep1.Dispose()
            Exit Sub
        ElseIf tbTelNo.TextLength < 10 Then
            ep1.SetError(tbTelNo, "Input 10 digit number")
            ep1.SetIconAlignment(tbTelNo, ErrorIconAlignment.TopLeft)
            ep1.BlinkRate.Equals(1)
        ElseIf tbTelNo.Text Like "*?*" Then
            ep1.SetError(tbTelNo, "Accept Only Digits")
            ep1.SetIconAlignment(tbTelNo, ErrorIconAlignment.TopLeft)
            ep1.BlinkRate.Equals(1)
        End If

    End Sub


    Private Sub tbNID_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbNID.Leave

        If tbNID.Text Like "#########V" Then
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
        ElseIf tbNID.Text Like "*?*?" Then
            ep1.SetError(tbNID, "Does not match")
            ep1.SetIconAlignment(tbNID, ErrorIconAlignment.BottomLeft)
            ep1.BlinkRate.Equals(1)
        End If

    End Sub

    'Private Sub tbStuNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbStuNo.Leave

    '    If tbStuNo.Text Like "??_####_###" Then
    '        ep1.Dispose()
    '        Exit Sub
    '    Else
    '        ep1.SetError(tbStuNo, "Does not match. ")
    '        ep1.SetIconAlignment(tbNID, ErrorIconAlignment.BottomLeft)
    '        ep1.BlinkRate.Equals(1)
    '    End If

    'End Sub
    'Private Sub tbStuNo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbStuNo.Enter

    '    tp1.SetToolTip(tbStuNo, "EX: PS_2001_015")

    'End Sub

#End Region

#Region "Assign the stage"

    Private Sub setList()
        cmbStage.Items.Clear()
        If rbtnUG.Checked Then
            cmbStage.Items.Add("1st Year")
            cmbStage.Items.Add("2nd Year")
            cmbStage.Items.Add("3rd Year")
            cmbStage.Items.Add("4th Year")
        ElseIf rbtnPG.Checked Then
            cmbStage.Items.Add("1st Year")
            cmbStage.Items.Add("2nd Year")
        End If
    End Sub


    Private Sub rbtnPG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnPG.CheckedChanged
        Me.setList()
    End Sub

    Private Sub rbtnUG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUG.CheckedChanged

        Me.setList()

    End Sub

    Private Sub rbtnPG_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnPG.Leave

        Me.setList()

    End Sub

#End Region

#Region "Exit"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

End Class
