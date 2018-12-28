Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmStaffReg
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbIni As System.Windows.Forms.TextBox
    Friend WithEvents tblName As System.Windows.Forms.TextBox
    Friend WithEvents tbTelNo As System.Windows.Forms.TextBox
    Friend WithEvents tbPerAdd As System.Windows.Forms.TextBox
    Friend WithEvents tbtemAdd As System.Windows.Forms.TextBox
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents gbAcdetl As System.Windows.Forms.GroupBox
    Friend WithEvents tbNID As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbstage As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeptNo As System.Windows.Forms.ComboBox
    Friend WithEvents tbUniId As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStaffReg))
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbIni = New System.Windows.Forms.TextBox
        Me.tblName = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbTelNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tbPerAdd = New System.Windows.Forms.TextBox
        Me.tbtemAdd = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.gbAcdetl = New System.Windows.Forms.GroupBox
        Me.tbNID = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbstage = New System.Windows.Forms.ComboBox
        Me.cmbDeptNo = New System.Windows.Forms.ComboBox
        Me.tbUniId = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnRegister = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbAcdetl.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTitle.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ItemHeight = 15
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(72, 15)
        Me.cmbTitle.MaxLength = 5
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(72, 23)
        Me.cmbTitle.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 23)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.tbIni)
        Me.GroupBox1.Controls.Add(Me.tblName)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbTitle)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name"
        '
        'tbIni
        '
        Me.tbIni.BackColor = System.Drawing.SystemColors.Window
        Me.tbIni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbIni.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIni.Location = New System.Drawing.Point(72, 75)
        Me.tbIni.Name = "tbIni"
        Me.tbIni.Size = New System.Drawing.Size(128, 21)
        Me.tbIni.TabIndex = 2
        Me.tbIni.Text = ""
        '
        'tblName
        '
        Me.tblName.BackColor = System.Drawing.SystemColors.Window
        Me.tblName.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblName.Location = New System.Drawing.Point(72, 46)
        Me.tblName.MaxLength = 50
        Me.tblName.Name = "tblName"
        Me.tblName.Size = New System.Drawing.Size(216, 21)
        Me.tblName.TabIndex = 1
        Me.tblName.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 23)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "Initial"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 23)
        Me.Label18.TabIndex = 178
        Me.Label18.Text = "Last Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbTelNo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tbPerAdd)
        Me.GroupBox2.Controls.Add(Me.tbtemAdd)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 184)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Details"
        '
        'tbTelNo
        '
        Me.tbTelNo.BackColor = System.Drawing.SystemColors.Window
        Me.tbTelNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelNo.Location = New System.Drawing.Point(72, 24)
        Me.tbTelNo.MaxLength = 10
        Me.tbTelNo.Name = "tbTelNo"
        Me.tbTelNo.Size = New System.Drawing.Size(104, 21)
        Me.tbTelNo.TabIndex = 3
        Me.tbTelNo.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 23)
        Me.Label14.TabIndex = 184
        Me.Label14.Text = "Contact No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPerAdd
        '
        Me.tbPerAdd.BackColor = System.Drawing.SystemColors.Window
        Me.tbPerAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPerAdd.Location = New System.Drawing.Point(72, 116)
        Me.tbPerAdd.MaxLength = 250
        Me.tbPerAdd.Multiline = True
        Me.tbPerAdd.Name = "tbPerAdd"
        Me.tbPerAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPerAdd.Size = New System.Drawing.Size(216, 56)
        Me.tbPerAdd.TabIndex = 5
        Me.tbPerAdd.Text = ""
        '
        'tbtemAdd
        '
        Me.tbtemAdd.BackColor = System.Drawing.SystemColors.Window
        Me.tbtemAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtemAdd.Location = New System.Drawing.Point(72, 52)
        Me.tbtemAdd.MaxLength = 250
        Me.tbtemAdd.Multiline = True
        Me.tbtemAdd.Name = "tbtemAdd"
        Me.tbtemAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbtemAdd.Size = New System.Drawing.Size(216, 56)
        Me.tbtemAdd.TabIndex = 4
        Me.tbtemAdd.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 23)
        Me.Label15.TabIndex = 181
        Me.Label15.Text = "Permanent Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Temporary Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'gbAcdetl
        '
        Me.gbAcdetl.Controls.Add(Me.tbNID)
        Me.gbAcdetl.Controls.Add(Me.Label22)
        Me.gbAcdetl.Controls.Add(Me.cmbstage)
        Me.gbAcdetl.Controls.Add(Me.cmbDeptNo)
        Me.gbAcdetl.Controls.Add(Me.tbUniId)
        Me.gbAcdetl.Controls.Add(Me.Label20)
        Me.gbAcdetl.Controls.Add(Me.Label12)
        Me.gbAcdetl.Controls.Add(Me.Label13)
        Me.gbAcdetl.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAcdetl.Location = New System.Drawing.Point(320, 24)
        Me.gbAcdetl.Name = "gbAcdetl"
        Me.gbAcdetl.Size = New System.Drawing.Size(256, 152)
        Me.gbAcdetl.TabIndex = 6
        Me.gbAcdetl.TabStop = False
        Me.gbAcdetl.Text = "Acedemic Details"
        '
        'tbNID
        '
        Me.tbNID.BackColor = System.Drawing.SystemColors.Window
        Me.tbNID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNID.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNID.Location = New System.Drawing.Point(118, 55)
        Me.tbNID.MaxLength = 10
        Me.tbNID.Name = "tbNID"
        Me.tbNID.Size = New System.Drawing.Size(128, 21)
        Me.tbNID.TabIndex = 7
        Me.tbNID.Text = ""
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 23)
        Me.Label22.TabIndex = 196
        Me.Label22.Text = " National ID No"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbstage
        '
        Me.cmbstage.BackColor = System.Drawing.SystemColors.Window
        Me.cmbstage.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstage.ItemHeight = 15
        Me.cmbstage.Items.AddRange(New Object() {"Dean", "Professor", "Senior Lecturer", "Lecturer", "Demonstrator", "Executive Officer", "Temporary Demonstrator"})
        Me.cmbstage.Location = New System.Drawing.Point(118, 119)
        Me.cmbstage.Name = "cmbstage"
        Me.cmbstage.Size = New System.Drawing.Size(128, 23)
        Me.cmbstage.TabIndex = 9
        '
        'cmbDeptNo
        '
        Me.cmbDeptNo.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDeptNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDeptNo.ItemHeight = 15
        Me.cmbDeptNo.Items.AddRange(New Object() {"Statistics and Computer Science", "Mathematics ", "Physics", "Chemistry", "Botany", "Zoology", "Industrial Management"})
        Me.cmbDeptNo.Location = New System.Drawing.Point(118, 87)
        Me.cmbDeptNo.Name = "cmbDeptNo"
        Me.cmbDeptNo.Size = New System.Drawing.Size(128, 23)
        Me.cmbDeptNo.TabIndex = 8
        '
        'tbUniId
        '
        Me.tbUniId.BackColor = System.Drawing.SystemColors.Window
        Me.tbUniId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUniId.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUniId.Location = New System.Drawing.Point(118, 23)
        Me.tbUniId.MaxLength = 20
        Me.tbUniId.Name = "tbUniId"
        Me.tbUniId.Size = New System.Drawing.Size(128, 21)
        Me.tbUniId.TabIndex = 6
        Me.tbUniId.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 23)
        Me.Label20.TabIndex = 195
        Me.Label20.Text = "University ID"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.TabIndex = 194
        Me.Label12.Text = "Department Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 23)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "Stage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(408, 274)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRegister.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ImageList = Me.ImageList1
        Me.btnRegister.Location = New System.Drawing.Point(408, 192)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "&Register"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(408, 233)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Clear"
        '
        'frmStaffReg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(584, 318)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.gbAcdetl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStaffReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbAcdetl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Register Staff"

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        Dim stfMember As New ClassStaff
        stfMember.AddMember(tbUniId.Text, cmbTitle.Text, tbIni.Text, tblName.Text, tbNID.Text, tbTelNo.Text, tbtemAdd.Text, tbPerAdd.Text, cmbDeptNo.Text, cmbstage.Text)

    End Sub

#End Region

#Region "Clear fields"

    Private Sub Clear()

        cmbTitle.Text = ""
        tblName.Text = ""
        tbIni.Text = ""
        tbTelNo.Text = ""
        tbtemAdd.Text = ""
        tbPerAdd.Text = ""
        tbUniId.Text = ""
        tbNID.Text = ""
        cmbDeptNo.Text = ""
        cmbstage.Text = ""
        
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.Clear()
    End Sub

#End Region

#Region "Error Handling"

    Private Sub cmbDeptNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbTelNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTelNo.Leave

        If tbTelNo.Text Like "##########" Then
            ep1.Dispose()
            Exit Sub
        ElseIf tbTelNo.TextLength <> 10 Then
            ep1.SetError(tbTelNo, "Should Enter 10 digit number")
            ep1.SetIconAlignment(tbTelNo, ErrorIconAlignment.TopRight)
            ep1.BlinkRate.Equals(1)
        ElseIf tbTelNo.Text Like "*?*" Then
            ep1.SetError(tbTelNo, "Should Enter Only Digits")
            ep1.SetIconAlignment(tbTelNo, ErrorIconAlignment.TopRight)
            ep1.BlinkRate.Equals(1)
        End If

    End Sub

    Private Sub tbNID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbNID.Leave

        If tbNID.Text Like "#########V" Then
            ep1.Dispose()
            Exit Sub
        ElseIf tbNID.TextLength <> 10 Then
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

#End Region

#Region "Exit"

    Private Sub frmStaffReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCancelButton(btnCancel)
    End Sub

    Private Sub SetCancelButton(ByVal myCancelBtn As Button)
        Me.CancelButton = myCancelBtn
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region


    Private Sub tbTelNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTelNo.TextChanged

    End Sub
End Class
