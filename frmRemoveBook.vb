Imports Library.LogginUser
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class frmRemoveBook
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
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents tbAccssionNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbAccssionNo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(30, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "&Delete"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(118, 48)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Cancel"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Accssion No"
        '
        'tbAccssionNo
        '
        Me.tbAccssionNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccssionNo.Location = New System.Drawing.Point(104, 14)
        Me.tbAccssionNo.Name = "tbAccssionNo"
        Me.tbAccssionNo.TabIndex = 5
        Me.tbAccssionNo.Text = ""
        '
        'frmRemoveBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(232, 86)
        Me.Controls.Add(Me.tbAccssionNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.MaximizeBox = False
        Me.Name = "frmRemoveBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove Book"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Load"

    Private Sub frmRemoveBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip.SetToolTip(btnDelete, "Click here to permanatly remove the book from the circulation")
        ToolTip.SetToolTip(btnExit, "Click here to exit")
    End Sub

#End Region
    
#Region "Remove Copy"

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If tbAccssionNo.Text = "" Then
            MessageBox.Show("Please enter the 'Accession Number'", "Verify AccNO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim rc As New ClassBookCopy
        rc.removeBookCopy_AccNo(tbAccssionNo.Text)
        ' tbAccssionNo.Text = ""

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
