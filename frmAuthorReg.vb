Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmAuthorReg
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
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents ISBN As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbconNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents tbAddr As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbSub As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbName = New System.Windows.Forms.TextBox
        Me.ISBN = New System.Windows.Forms.Label
        Me.tbCity = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbconNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCountry = New System.Windows.Forms.ComboBox
        Me.tbAddr = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.tbSub = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.AutoSize = False
        Me.tbName.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(78, 16)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(144, 20)
        Me.tbName.TabIndex = 0
        Me.tbName.Text = ""
        '
        'ISBN
        '
        Me.ISBN.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(14, 16)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(40, 23)
        Me.ISBN.TabIndex = 31
        Me.ISBN.Text = "Name"
        Me.ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCity
        '
        Me.tbCity.AutoSize = False
        Me.tbCity.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCity.Location = New System.Drawing.Point(78, 168)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(120, 20)
        Me.tbCity.TabIndex = 4
        Me.tbCity.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "City"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Country"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbconNo
        '
        Me.tbconNo.AutoSize = False
        Me.tbconNo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbconNo.Location = New System.Drawing.Point(78, 104)
        Me.tbconNo.MaxLength = 12
        Me.tbconNo.Name = "tbconNo"
        Me.tbconNo.Size = New System.Drawing.Size(120, 20)
        Me.tbconNo.TabIndex = 2
        Me.tbconNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Contact No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCountry
        '
        Me.cmbCountry.Items.AddRange(New Object() {"Sri Lanka", "India", "USA", "UK", "Japan", "Kanada"})
        Me.cmbCountry.Location = New System.Drawing.Point(78, 136)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(120, 21)
        Me.cmbCountry.TabIndex = 3
        '
        'tbAddr
        '
        Me.tbAddr.AutoSize = False
        Me.tbAddr.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddr.Location = New System.Drawing.Point(78, 46)
        Me.tbAddr.Multiline = True
        Me.tbAddr.Name = "tbAddr"
        Me.tbAddr.Size = New System.Drawing.Size(144, 50)
        Me.tbAddr.TabIndex = 1
        Me.tbAddr.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Subjects"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(40, 240)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(134, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel"
        '
        'tbSub
        '
        Me.tbSub.AutoSize = False
        Me.tbSub.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSub.Location = New System.Drawing.Point(78, 200)
        Me.tbSub.MaxLength = 150
        Me.tbSub.Name = "tbSub"
        Me.tbSub.Size = New System.Drawing.Size(138, 20)
        Me.tbSub.TabIndex = 5
        Me.tbSub.Text = ""
        '
        'frmAuthorReg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(240, 270)
        Me.Controls.Add(Me.tbSub)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.tbAddr)
        Me.Controls.Add(Me.tbconNo)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ISBN)
        Me.Name = "frmAuthorReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Author Registration"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Add new author"

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim author As New Class_Author
        author.AddNew(tbName.Text, tbSub.Text, tbconNo.Text, tbAddr.Text, tbCity.Text, cmbCountry.SelectedText)
        Me.Clear()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Sub Clear()

        tbName.Text = ""
        tbSub.Text = ""
        tbconNo.Text = ""
        tbAddr.Text = ""
        tbCity.Text = ""
        cmbCountry.Text = ""

    End Sub

End Class
