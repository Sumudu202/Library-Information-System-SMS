Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports Library.LogginUser

Public Class frmNewUser
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbConPwd As System.Windows.Forms.TextBox
    Friend WithEvents tbPwd As System.Windows.Forms.TextBox
    Friend WithEvents tbUName As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbuType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbConPwd = New System.Windows.Forms.TextBox
        Me.tbPwd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbUName = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmbuType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbConPwd)
        Me.GroupBox1.Controls.Add(Me.tbPwd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbUName)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User"
        '
        'tbConPwd
        '
        Me.tbConPwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConPwd.Location = New System.Drawing.Point(120, 96)
        Me.tbConPwd.MaxLength = 5
        Me.tbConPwd.Name = "tbConPwd"
        Me.tbConPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbConPwd.TabIndex = 2
        Me.tbConPwd.Text = ""
        '
        'tbPwd
        '
        Me.tbPwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPwd.Location = New System.Drawing.Point(120, 64)
        Me.tbPwd.MaxLength = 5
        Me.tbPwd.Name = "tbPwd"
        Me.tbPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbPwd.TabIndex = 1
        Me.tbPwd.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        '
        'tbUName
        '
        Me.tbUName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUName.Location = New System.Drawing.Point(120, 32)
        Me.tbUName.MaxLength = 15
        Me.tbUName.Name = "tbUName"
        Me.tbUName.TabIndex = 0
        Me.tbUName.Text = ""
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(48, 182)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(144, 182)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        '
        'cmbuType
        '
        Me.cmbuType.Items.AddRange(New Object() {"Administrator", "Clarical"})
        Me.cmbuType.Location = New System.Drawing.Point(108, 147)
        Me.cmbuType.Name = "cmbuType"
        Me.cmbuType.Size = New System.Drawing.Size(121, 21)
        Me.cmbuType.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "User Type"
        '
        'frmNewUser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(264, 214)
        Me.Controls.Add(Me.cmbuType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Register new user"

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim PreUsers As Int16
        PreUsers = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(userId) from loggin where userId='" & tbUName.Text & "'")

        If tbUName.Text = "" Then
            MessageBox.Show("Please enter the 'User Name'", "Verify Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tbPwd.Text <> tbConPwd.Text Then
            MessageBox.Show("Please confirm the 'Password'", "Verify Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cmbuType.Text = "" Then
            MessageBox.Show("Please enter the 'User Type'", "Verify Usertype", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf PreUsers > 0 Then
            MessageBox.Show("The User Name you entered is currently in use, Please enter another User Name", "Verify Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                sqlconn.Open()
                SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "insert into Loggin values('" & tbUName.Text & "','" & tbPwd.Text & "','" & cmbuType.Text & "')")
                MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.clearform()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                sqlconn.Close()
            End Try

        End If

    End Sub

#End Region

#Region "Clear fields"

    Sub clearform()
        tbUName.Text = ""
        tbPwd.Text = ""
        tbConPwd.Text = ""
        cmbuType.Text = ""
    End Sub

#End Region

#Region "Set Cancel Button"

    Private Sub frmLendingConf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCancelButton(btnCancel)
    End Sub

    Private Sub SetCancelButton(ByVal myCancelBtn As Button)
        Me.CancelButton = myCancelBtn
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

End Class
