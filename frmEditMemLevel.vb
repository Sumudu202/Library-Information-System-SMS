Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmEditMemLevel
    Inherits System.Windows.Forms.Form
    Dim bt As New ClassBorrowingType

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbSRB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbSRD As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbDescSR As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbLD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbLB As System.Windows.Forms.TextBox
    Friend WithEvents tbDescL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents tbTypeL As System.Windows.Forms.TextBox
    Friend WithEvents tbTypeSR As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbTypeSR = New System.Windows.Forms.TextBox
        Me.tbSRB = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbSRD = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbDescSR = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbTypeL = New System.Windows.Forms.TextBox
        Me.tbLD = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbLB = New System.Windows.Forms.TextBox
        Me.tbDescL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbType = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.ep = New System.Windows.Forms.ErrorProvider
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.tbTypeSR)
        Me.GroupBox2.Controls.Add(Me.tbSRB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbSRD)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbDescSR)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(308, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 184)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sheduled Reference"
        '
        'tbTypeSR
        '
        Me.tbTypeSR.Enabled = False
        Me.tbTypeSR.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTypeSR.Location = New System.Drawing.Point(82, 28)
        Me.tbTypeSR.MaxLength = 5
        Me.tbTypeSR.Name = "tbTypeSR"
        Me.tbTypeSR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTypeSR.Size = New System.Drawing.Size(112, 22)
        Me.tbTypeSR.TabIndex = 45
        Me.tbTypeSR.Text = ""
        '
        'tbSRB
        '
        Me.tbSRB.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSRB.Location = New System.Drawing.Point(210, 112)
        Me.tbSRB.MaxLength = 5
        Me.tbSRB.Name = "tbSRB"
        Me.tbSRB.Size = New System.Drawing.Size(64, 22)
        Me.tbSRB.TabIndex = 3
        Me.tbSRB.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 23)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "No Of Sheduled ReferenceBooks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbSRD
        '
        Me.tbSRD.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSRD.Location = New System.Drawing.Point(162, 146)
        Me.tbSRD.MaxLength = 5
        Me.tbSRD.Name = "tbSRD"
        Me.tbSRD.Size = New System.Drawing.Size(112, 22)
        Me.tbSRD.TabIndex = 4
        Me.tbSRD.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 23)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "No Of Days"
        '
        'tbDescSR
        '
        Me.tbDescSR.Enabled = False
        Me.tbDescSR.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescSR.Location = New System.Drawing.Point(82, 57)
        Me.tbDescSR.MaxLength = 250
        Me.tbDescSR.Multiline = True
        Me.tbDescSR.Name = "tbDescSR"
        Me.tbDescSR.Size = New System.Drawing.Size(192, 43)
        Me.tbDescSR.TabIndex = 5
        Me.tbDescSR.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 23)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Discription"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbTypeL)
        Me.GroupBox1.Controls.Add(Me.tbLD)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbLB)
        Me.GroupBox1.Controls.Add(Me.tbDescL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 184)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lending"
        '
        'tbTypeL
        '
        Me.tbTypeL.Enabled = False
        Me.tbTypeL.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTypeL.Location = New System.Drawing.Point(85, 30)
        Me.tbTypeL.MaxLength = 5
        Me.tbTypeL.Name = "tbTypeL"
        Me.tbTypeL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTypeL.Size = New System.Drawing.Size(112, 22)
        Me.tbTypeL.TabIndex = 35
        Me.tbTypeL.Text = ""
        '
        'tbLD
        '
        Me.tbLD.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLD.Location = New System.Drawing.Point(163, 146)
        Me.tbLD.MaxLength = 5
        Me.tbLD.Name = "tbLD"
        Me.tbLD.Size = New System.Drawing.Size(112, 22)
        Me.tbLD.TabIndex = 2
        Me.tbLD.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "No Of Days"
        '
        'tbLB
        '
        Me.tbLB.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLB.Location = New System.Drawing.Point(163, 114)
        Me.tbLB.MaxLength = 5
        Me.tbLB.Name = "tbLB"
        Me.tbLB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbLB.Size = New System.Drawing.Size(112, 22)
        Me.tbLB.TabIndex = 1
        Me.tbLB.Text = ""
        '
        'tbDescL
        '
        Me.tbDescL.Enabled = False
        Me.tbDescL.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescL.Location = New System.Drawing.Point(83, 59)
        Me.tbDescL.MaxLength = 250
        Me.tbDescL.Multiline = True
        Me.tbDescL.Name = "tbDescL"
        Me.tbDescL.Size = New System.Drawing.Size(192, 43)
        Me.tbDescL.TabIndex = 1
        Me.tbDescL.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "No Of Lending Books"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Discription"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Type"
        '
        'lbType
        '
        Me.lbType.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbType.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbType.Location = New System.Drawing.Point(16, 8)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(200, 24)
        Me.lbType.TabIndex = 30
        Me.lbType.Text = "Type of Member Want To Modify"
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Location = New System.Drawing.Point(216, 8)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(264, 21)
        Me.cmbType.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(496, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "&Search"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(480, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(360, 246)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "&Update"
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'frmEditMemLevel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(608, 278)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmEditMemLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Member Level"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form LOad"

    Private Sub frmEditMemLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sqlDs As New DataSet
        Dim sqlDA1 As New Data.SqlClient.SqlDataAdapter("select type from dbo.BorrowingType order by discription asc", sqlconn)
        sqlDA1.Fill(sqlDs, "Types")
        cmbType.DataSource = sqlDs.Tables("Types")
        cmbType.DisplayMember = "type"
        cmbType.ValueMember = "type"

    End Sub

#End Region

#Region "Search"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Me.clear()
        'Dim bt As New ClassBorrowingType
        bt.View_Level(cmbType.Text)
        tbTypeL.Text = bt.LType
        tbTypeSR.Text = bt.SRType
        tbDescL.Text = bt.LDisc
        tbDescSR.Text = bt.SRDisc
        tbLB.Text = bt.LNo_of_Books
        tbSRB.Text = bt.SRNo_of_Books
        tbLD.Text = bt.LNo_of_Days
        tbSRD.Text = bt.SRNo_of_Days

        ' cmbType.Enabled = False

    End Sub


#End Region

#Region "Update Type"

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If bt.Sec = True Then
            bt.Update_Member_Type(cmbType.Text, tbLB.Text, tbLD.Text)
        Else
            bt.Update_Member_Type(cmbType.Text, tbSRB.Text, tbSRD.Text)

        End If

    End Sub

#End Region

#Region "Error Handling"

    Private Sub btnSearch_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.MouseEnter

        If cmbType.Text = "" Then
            ep.SetError(cmbType, "Select the Type")
            ep.SetIconAlignment(cmbType, ErrorIconAlignment.TopLeft)
            ep.BlinkRate.Equals(1)
        End If

    End Sub

#End Region

#Region "Exit"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

#End Region

#Region "Clear Fields"

    Sub Clear()

        tbTypeL.Text = ""
        tbTypeSR.Text = ""
        tbDescL.Text = ""
        tbDescSR.Text = ""
        tbLB.Text = ""
        tbSRB.Text = ""
        tbLD.Text = ""
        tbSRD.Text = ""

    End Sub

#End Region

End Class
