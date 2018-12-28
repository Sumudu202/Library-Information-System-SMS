
Imports Library.LogginUser
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmAddMemberType
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
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbLD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbLB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbDescL As System.Windows.Forms.TextBox
    Friend WithEvents tbTypeL As System.Windows.Forms.TextBox
    Friend WithEvents tbSRB As System.Windows.Forms.TextBox
    Friend WithEvents tbSRD As System.Windows.Forms.TextBox
    Friend WithEvents tbDescSR As System.Windows.Forms.TextBox
    Friend WithEvents tbTypeSR As System.Windows.Forms.TextBox
    Friend WithEvents ep1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbLD = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbLB = New System.Windows.Forms.TextBox
        Me.tbDescL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbTypeL = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbSRB = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbSRD = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbDescSR = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbTypeSR = New System.Windows.Forms.TextBox
        Me.ep1 = New System.Windows.Forms.ErrorProvider
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(480, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(384, 206)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbLD)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbLB)
        Me.GroupBox1.Controls.Add(Me.tbDescL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbTypeL)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lending"
        '
        'tbLD
        '
        Me.tbLD.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLD.Location = New System.Drawing.Point(161, 145)
        Me.tbLD.MaxLength = 5
        Me.tbLD.Name = "tbLD"
        Me.tbLD.Size = New System.Drawing.Size(112, 21)
        Me.tbLD.TabIndex = 3
        Me.tbLD.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "No Of Days"
        '
        'tbLB
        '
        Me.tbLB.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLB.Location = New System.Drawing.Point(161, 113)
        Me.tbLB.MaxLength = 5
        Me.tbLB.Name = "tbLB"
        Me.tbLB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbLB.Size = New System.Drawing.Size(112, 21)
        Me.tbLB.TabIndex = 2
        Me.tbLB.Text = ""
        '
        'tbDescL
        '
        Me.tbDescL.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescL.Location = New System.Drawing.Point(81, 58)
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
        Me.Label3.Location = New System.Drawing.Point(6, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "No Of Lending Books"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Discription"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Type"
        '
        'tbTypeL
        '
        Me.tbTypeL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTypeL.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTypeL.Location = New System.Drawing.Point(81, 26)
        Me.tbTypeL.MaxLength = 15
        Me.tbTypeL.Name = "tbTypeL"
        Me.tbTypeL.Size = New System.Drawing.Size(112, 21)
        Me.tbTypeL.TabIndex = 0
        Me.tbTypeL.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.tbSRB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbSRD)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbDescSR)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbTypeSR)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(296, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 184)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sheduled Reference"
        '
        'tbSRB
        '
        Me.tbSRB.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSRB.Location = New System.Drawing.Point(210, 112)
        Me.tbSRB.MaxLength = 5
        Me.tbSRB.Name = "tbSRB"
        Me.tbSRB.Size = New System.Drawing.Size(64, 21)
        Me.tbSRB.TabIndex = 6
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
        Me.tbSRD.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSRD.Location = New System.Drawing.Point(162, 146)
        Me.tbSRD.MaxLength = 5
        Me.tbSRD.Name = "tbSRD"
        Me.tbSRD.Size = New System.Drawing.Size(112, 21)
        Me.tbSRD.TabIndex = 7
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
        Me.tbDescSR.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'tbTypeSR
        '
        Me.tbTypeSR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTypeSR.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTypeSR.Location = New System.Drawing.Point(82, 26)
        Me.tbTypeSR.MaxLength = 15
        Me.tbTypeSR.Name = "tbTypeSR"
        Me.tbTypeSR.Size = New System.Drawing.Size(112, 21)
        Me.tbTypeSR.TabIndex = 4
        Me.tbTypeSR.Text = ""
        '
        'ep1
        '
        Me.ep1.ContainerControl = Me
        '
        'frmAddMemberType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(600, 246)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmAddMemberType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Member Type"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Add Level"

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim bt As New ClassBorrowingType
        bt.AddType(tbTypeL.Text, tbDescL.Text, tbLB.Text, tbLD.Text, tbTypeSR.Text, tbDescSR.Text, tbSRB.Text, tbSRD.Text)
        Me.Clear()

    End Sub

#End Region

#Region "Clear"

    Sub Clear()

        tbTypeL.Text = ""
        tbDescL.Text = ""
        tbLB.Text = ""
        tbLD.Text = ""
        tbTypeSR.Text = ""
        tbDescSR.Text = ""
        tbSRB.Text = ""
        tbSRD.Text = ""

    End Sub

#End Region

#Region "Exit"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub


#End Region
   
#Region "Error Handling"

    'Private Sub tbLB_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbLB.Leave

    '    If tbLB.Text Like "##" Or "#" Then
    '        ep1.Dispose()
    '        Exit Sub
    '    Else
    '        ep1.SetError(tbLB, "Accept Only Digits")
    '        ep1.SetIconAlignment(tbLB, ErrorIconAlignment.TopLeft)
    '        ep1.BlinkRate.Equals(1)
    '    End If

    'End Sub

    'Private Sub tbLD_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbLD.Leave

    '    If tbLD.Text Like "##" Or "#" Then
    '        ep1.Dispose()
    '        Exit Sub
    '    Else
    '        ep1.SetError(tbLB, "Accept Only Digits")
    '        ep1.SetIconAlignment(tbLD, ErrorIconAlignment.TopLeft)
    '        ep1.BlinkRate.Equals(1)
    '    End If

    'End Sub

    'Private Sub tbSRB_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSRB.Leave

    '    If tbSRB.Text Like "##" Or "#" Then
    '        ep1.Dispose()
    '        Exit Sub
    '    Else
    '        ep1.SetError(tbLB, "Accept Only Digits")
    '        ep1.SetIconAlignment(tbSRB, ErrorIconAlignment.TopLeft)
    '        ep1.BlinkRate.Equals(1)
    '    End If

    'End Sub

    'Private Sub tbSRD_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSRD.Leave

    '    If tbSRD.Text Like "##" Or "#" Then
    '        ep1.Dispose()
    '        Exit Sub
    '    Else
    '        ep1.SetError(tbLB, "Accept Only Digits")
    '        ep1.SetIconAlignment(tbSRD, ErrorIconAlignment.TopLeft)
    '        ep1.BlinkRate.Equals(1)
    '    End If

    'End Sub

#End Region

End Class
