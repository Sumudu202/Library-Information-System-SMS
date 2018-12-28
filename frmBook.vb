Public Class frmNewBook
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
    Friend WithEvents tlbBook As System.Windows.Forms.ToolBar
    Friend WithEvents tlbAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents tbBookId As System.Windows.Forms.TextBox
    Friend WithEvents tbTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblBookId As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tlbBook = New System.Windows.Forms.ToolBar
        Me.tlbAdd = New System.Windows.Forms.ToolBarButton
        Me.tlbEdit = New System.Windows.Forms.ToolBarButton
        Me.tlbDelete = New System.Windows.Forms.ToolBarButton
        Me.lblBookId = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.tbTitle = New System.Windows.Forms.TextBox
        Me.tbBookId = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'tlbBook
        '
        Me.tlbBook.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tlbAdd, Me.tlbEdit, Me.tlbDelete})
        Me.tlbBook.DropDownArrows = True
        Me.tlbBook.Location = New System.Drawing.Point(0, 0)
        Me.tlbBook.Name = "tlbBook"
        Me.tlbBook.ShowToolTips = True
        Me.tlbBook.Size = New System.Drawing.Size(512, 42)
        Me.tlbBook.TabIndex = 0
        '
        'tlbAdd
        '
        Me.tlbAdd.Text = "&New"
        Me.tlbAdd.ToolTipText = "Add a new book"
        '
        'tlbEdit
        '
        Me.tlbEdit.Text = "&Edit"
        Me.tlbEdit.ToolTipText = "Edit an existing book"
        '
        'tlbDelete
        '
        Me.tlbDelete.Text = "&Delete"
        Me.tlbDelete.ToolTipText = "Delete an existing book"
        '
        'lblBookId
        '
        Me.lblBookId.Location = New System.Drawing.Point(16, 56)
        Me.lblBookId.Name = "lblBookId"
        Me.lblBookId.TabIndex = 1
        Me.lblBookId.Text = "Accession No"
        Me.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBookId.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(16, 88)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = ""
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(152, 88)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.TabIndex = 8
        Me.tbTitle.Text = ""
        Me.tbTitle.Visible = False
        '
        'tbBookId
        '
        Me.tbBookId.Location = New System.Drawing.Point(152, 56)
        Me.tbBookId.Name = "tbBookId"
        Me.tbBookId.TabIndex = 9
        Me.tbBookId.Text = ""
        Me.tbBookId.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(152, 184)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = ""
        '
        'frmNewBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 326)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.tbBookId)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBookId)
        Me.Controls.Add(Me.tlbBook)
        Me.Name = "frmNewBook"
        Me.Text = "Book Registration"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBookId.Click

    End Sub

    Private Sub tlbBook_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbBook.ButtonClick
        If e.Button.Text = "&New" Then
            tbBookId.Visible = True
            tbTitle.Visible = True
            lblBookId.Visible = True
            lblTitle.Visible = True
        Else
if e.Button.Text = "&Edit" then
                tbBookId.Visible = True
                lblBookId.Visible = True
            End If
        End If
    End Sub
End Class
