Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmChangePwd
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents tbNpwd As System.Windows.Forms.TextBox
    Friend WithEvents tbconpwd As System.Windows.Forms.TextBox
    Friend WithEvents tbCpwd As System.Windows.Forms.TextBox
    Friend WithEvents tbUName As System.Windows.Forms.TextBox
    Friend WithEvents cmbuType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbNpwd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbconpwd = New System.Windows.Forms.TextBox
        Me.tbCpwd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbUName = New System.Windows.Forms.TextBox
        Me.cmbuType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(144, 216)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(48, 216)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 24)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "&Ok"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbNpwd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbconpwd)
        Me.GroupBox1.Controls.Add(Me.tbCpwd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbUName)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 164)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User"
        '
        'tbNpwd
        '
        Me.tbNpwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNpwd.Location = New System.Drawing.Point(120, 96)
        Me.tbNpwd.Name = "tbNpwd"
        Me.tbNpwd.TabIndex = 7
        Me.tbNpwd.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "New Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbconpwd
        '
        Me.tbconpwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbconpwd.Location = New System.Drawing.Point(120, 128)
        Me.tbconpwd.Name = "tbconpwd"
        Me.tbconpwd.TabIndex = 5
        Me.tbconpwd.Text = ""
        '
        'tbCpwd
        '
        Me.tbCpwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCpwd.Location = New System.Drawing.Point(120, 64)
        Me.tbCpwd.Name = "tbCpwd"
        Me.tbCpwd.TabIndex = 4
        Me.tbCpwd.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbUName
        '
        Me.tbUName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUName.Location = New System.Drawing.Point(120, 32)
        Me.tbUName.Name = "tbUName"
        Me.tbUName.TabIndex = 0
        Me.tbUName.Text = ""
        '
        'cmbuType
        '
        Me.cmbuType.Items.AddRange(New Object() {"Administrator", "Clarical"})
        Me.cmbuType.Location = New System.Drawing.Point(100, 184)
        Me.cmbuType.Name = "cmbuType"
        Me.cmbuType.Size = New System.Drawing.Size(121, 21)
        Me.cmbuType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "User Type"
        '
        'frmChangePwd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(248, 246)
        Me.Controls.Add(Me.cmbuType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmChangePwd"
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Change Password"

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim avl1, avl2 As Integer
        'avl1 = SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "select count(userId) where userId='" & tbUName.Text & "'")
        'If avl1 = 0 Then
        avl2 = SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "select count(userId) from Loggin where userId='" & tbUName.Text & "' and passWord='" & tbCpwd.Text & "'")
        If avl2 <= 0 Then
            MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tbNpwd.Text = tbconpwd.Text Then
            SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Loggin set passWord='" & tbNpwd.Text & "' and userType='" & cmbuType.Text & "' where userId='" & tbUName.Text & "' and passWord='" & tbCpwd.Text & "'")
            MessageBox.Show("Record is updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Confirm the Password! ", "Verify Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#End Region

End Class
