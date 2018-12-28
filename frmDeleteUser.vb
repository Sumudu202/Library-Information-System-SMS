Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmDeleteUser
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbUName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbUName = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(104, 40)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(32, 40)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(56, 23)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "&Delete"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "User Name"
        '
        'tbUName
        '
        Me.tbUName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUName.Location = New System.Drawing.Point(96, 8)
        Me.tbUName.Name = "tbUName"
        Me.tbUName.TabIndex = 0
        Me.tbUName.Text = ""
        '
        'frmDeleteUser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(208, 70)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbUName)
        Me.Name = "frmDeleteUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete User"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Delete user"

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If tbUName.Text = "" Then
            MessageBox.Show("Please enter the User Name", "Verify Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Count As Int16
            Count = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(userId) from loggin where userId='" & tbUName.Text & "'")
            If Count = 0 Then
                MessageBox.Show("Invalid user", "Verify Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim MsgNo As String
                MsgNo = MessageBox.Show("Are you sure You want to delete the user", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If MsgNo = 6 Then
                    SqlHelper.ExecuteNonQuery(sqlconn, CommandType.Text, "delete Loggin where userId='" & tbUName.Text & "'")
                    MessageBox.Show("Record is Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tbUName.Text = ""
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
