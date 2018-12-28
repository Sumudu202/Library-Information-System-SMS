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
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
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
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(144, 186)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(45, 186)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 24)
        Me.btnOk.TabIndex = 5
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
        Me.tbNpwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbNpwd.TabIndex = 2
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
        Me.tbconpwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbconpwd.TabIndex = 3
        Me.tbconpwd.Text = ""
        '
        'tbCpwd
        '
        Me.tbCpwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCpwd.Location = New System.Drawing.Point(120, 64)
        Me.tbCpwd.Name = "tbCpwd"
        Me.tbCpwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbCpwd.TabIndex = 1
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
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'frmChangePwd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(248, 222)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmChangePwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change the Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public avl As Integer

#Region "Error handling"

    Private Sub tbCpwd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbCpwd.Leave

        avl = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(userId) from Loggin where userId='" & tbUName.Text & "' and passWord='" & tbCpwd.Text & "'")
        If avl = 0 Then
            ep1.SetError(tbCpwd, "Invalid User")
            ep1.SetIconAlignment(tbNpwd, ErrorIconAlignment.BottomLeft)
            ep1.BlinkRate.Equals(1)
        Else
            ep1.Dispose()
        End If
    End Sub

#End Region

#Region "Change Password"

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If avl > 0 And tbNpwd.Text = tbconpwd.Text Then
            SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "update Loggin set passWord='" & tbNpwd.Text & "' where userId='" & tbUName.Text & "' and passWord='" & tbCpwd.Text & "'")
            MessageBox.Show("Record is updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.clearform()
        Else
            MessageBox.Show("Confirm the Password! ", "Verify Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#End Region

#Region "Clear fields"

    Sub clearform()
        tbUName.Text = ""
        tbCpwd.Text = ""
        tbNpwd.Text = ""
        tbconpwd.Text = ""
        ep1.Dispose()
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
