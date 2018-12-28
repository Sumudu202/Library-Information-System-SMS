Public Class frmSearch
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgResult As System.Windows.Forms.DataGrid
    Friend WithEvents tbKwd As System.Windows.Forms.TextBox
    Friend WithEvents tpType As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSelect = New System.Windows.Forms.ComboBox
        Me.dgResult = New System.Windows.Forms.DataGrid
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.tbKwd = New System.Windows.Forms.TextBox
        Me.tpType = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSelect
        '
        Me.cmbSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSelect.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelect.Items.AddRange(New Object() {"ISBN", "Accession No", "Author", "Title", "Key Word"})
        Me.cmbSelect.Location = New System.Drawing.Point(72, 9)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(265, 23)
        Me.cmbSelect.TabIndex = 2
        '
        'dgResult
        '
        Me.dgResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgResult.DataMember = ""
        Me.dgResult.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgResult.Location = New System.Drawing.Point(3, 76)
        Me.dgResult.Name = "dgResult"
        Me.dgResult.Size = New System.Drawing.Size(574, 244)
        Me.dgResult.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSearch.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(376, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(464, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        '
        'tbKwd
        '
        Me.tbKwd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKwd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKwd.Location = New System.Drawing.Point(9, 41)
        Me.tbKwd.Name = "tbKwd"
        Me.tbKwd.Size = New System.Drawing.Size(328, 21)
        Me.tbKwd.TabIndex = 6
        Me.tbKwd.Text = ""
        '
        'frmSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(584, 326)
        Me.Controls.Add(Me.tbKwd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgResult)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

   
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        dgResult.Visible = False

        Dim bc As New ClassBookCopy
        If cmbSelect.Text = "ISBN" Then
            bc.Search_By_ISBN(tbKwd.Text, dgResult)
        ElseIf cmbSelect.Text = "Author" Then
            bc.Search_By_Author(tbKwd.Text, dgResult)
            dgResult.CaptionText = "Result"
        ElseIf cmbSelect.Text = "Accession No" Then
            bc.Search_By_AccNo(tbKwd.Text, dgResult)
        ElseIf cmbSelect.Text = "Title" Then
            bc.Search_By_Title(tbKwd.Text, dgResult)
        ElseIf cmbSelect.Text = "Key Word" Then
            bc.Search_By_KWD(tbKwd.Text, dgResult)
        Else
            MessageBox.Show("Does Not Match", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub
End Class
