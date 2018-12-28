Imports Library.LogginUser
Imports System.Data.SqlClient

Public Class frmlogging
    Inherits System.Windows.Forms.Form

    Public Shared ClaricalUser As Boolean
    Public Shared Admin As Boolean

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPwd As System.Windows.Forms.TextBox
    Friend WithEvents btnLoggin As System.Windows.Forms.Button
    Friend WithEvents tbUserId As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tp1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbUserId = New System.Windows.Forms.TextBox
        Me.tbPwd = New System.Windows.Forms.TextBox
        Me.btnLoggin = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&User Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Pass Word"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbUserId
        '
        Me.tbUserId.BackColor = System.Drawing.SystemColors.Window
        Me.tbUserId.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbUserId.Location = New System.Drawing.Point(83, 24)
        Me.tbUserId.MaxLength = 15
        Me.tbUserId.Name = "tbUserId"
        Me.tbUserId.Size = New System.Drawing.Size(88, 21)
        Me.tbUserId.TabIndex = 1
        Me.tbUserId.Text = ""
        '
        'tbPwd
        '
        Me.tbPwd.BackColor = System.Drawing.SystemColors.Window
        Me.tbPwd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPwd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbPwd.Location = New System.Drawing.Point(83, 64)
        Me.tbPwd.MaxLength = 5
        Me.tbPwd.Name = "tbPwd"
        Me.tbPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbPwd.Size = New System.Drawing.Size(88, 21)
        Me.tbPwd.TabIndex = 2
        Me.tbPwd.Text = ""
        '
        'btnLoggin
        '
        Me.btnLoggin.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnLoggin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoggin.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoggin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLoggin.Location = New System.Drawing.Point(184, 24)
        Me.btnLoggin.Name = "btnLoggin"
        Me.btnLoggin.TabIndex = 3
        Me.btnLoggin.Text = "&Loggin"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(184, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        '
        'frmlogging
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(272, 118)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLoggin)
        Me.Controls.Add(Me.tbPwd)
        Me.Controls.Add(Me.tbUserId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmlogging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loggin"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "User Login"

    Private Sub btnLoggin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoggin.Click
        If tbUserId.Text = "" Then
            MessageBox.Show("Please enter the User Name", " Verify USer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tbPwd.Text = "" Then
            MessageBox.Show("Please enter the Pass Word", "Verify PassWord", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim stSQL As String = "SELECT * FROM Loggin where userId='" & tbUserId.Text & "' and passWord='" & tbPwd.Text & "' "
            Dim Comm As New SqlCommand(stSQL, sqlconn)
            Dim mysqlReader As SqlDataReader
            Try
                sqlconn.Open()
                mysqlReader = Comm.ExecuteReader

                Dim UID As String
                While (mysqlReader.Read())
                    UID = mysqlReader("userId")
                    userType = mysqlReader("userType")
                End While

                If userType = "Clarical" Then
                    ClaricalUser = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlReader.Close()
                sqlconn.Close()
            End Try

            Try
                CurrentUser = New LogginUser(tbUserId.Text, tbPwd.Text)
                If CurrentUser.loginMassage Like "*Valid*" Then
                    Me.Close()
                    Dim MainMenu As New frmMenu
                    MainMenu.Show()
                Else
                    MessageBox.Show("Can't access if you are an unauthorized person ", "Verify user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
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

#Region "Error Handling"

    Private Sub tbPwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPwd.TextChanged
        If tbPwd.TextLength = tbPwd.MaxLength Then
            tp1.SetToolTip(tbPwd, "The maximum length is 5")
        Else
            tp1.SetToolTip(tbPwd, "")
        End If
    End Sub

    Private Sub tbUserId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbUserId.TextChanged
        If tbUserId.TextLength = tbUserId.MaxLength Then
            tp1.SetToolTip(tbUserId, "The maximum length is 15")
        Else
            tp1.SetToolTip(tbPwd, "")
        End If
    End Sub

#End Region

End Class
