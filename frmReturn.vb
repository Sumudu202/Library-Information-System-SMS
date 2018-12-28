
Imports Microsoft.ApplicationBlocks.Data
Imports Library.LogginUser
Imports System.Data.SqlClient

Public Class frmReturn
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
    Friend WithEvents tbAccNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbMemID As System.Windows.Forms.TextBox
    Friend WithEvents tbDelay As System.Windows.Forms.TextBox
    Friend WithEvents tbFines As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCheck = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbAccNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbFines = New System.Windows.Forms.TextBox
        Me.tbDelay = New System.Windows.Forms.TextBox
        Me.tbMemID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnReturn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(222, 28)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(70, 23)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "&Check"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(240, 162)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbAccNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCheck)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 64)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Return Copy"
        '
        'tbAccNo
        '
        Me.tbAccNo.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccNo.Location = New System.Drawing.Point(104, 27)
        Me.tbAccNo.Name = "tbAccNo"
        Me.tbAccNo.Size = New System.Drawing.Size(104, 22)
        Me.tbAccNo.TabIndex = 4
        Me.tbAccNo.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Accssion No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbFines)
        Me.GroupBox2.Controls.Add(Me.tbDelay)
        Me.GroupBox2.Controls.Add(Me.tbMemID)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 136)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Delay"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Member ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbFines
        '
        Me.tbFines.Enabled = False
        Me.tbFines.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFines.ForeColor = System.Drawing.Color.Maroon
        Me.tbFines.Location = New System.Drawing.Point(96, 92)
        Me.tbFines.Name = "tbFines"
        Me.tbFines.Size = New System.Drawing.Size(104, 22)
        Me.tbFines.TabIndex = 7
        Me.tbFines.Text = ""
        '
        'tbDelay
        '
        Me.tbDelay.Enabled = False
        Me.tbDelay.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDelay.ForeColor = System.Drawing.Color.Maroon
        Me.tbDelay.Location = New System.Drawing.Point(96, 61)
        Me.tbDelay.Name = "tbDelay"
        Me.tbDelay.Size = New System.Drawing.Size(104, 22)
        Me.tbDelay.TabIndex = 6
        Me.tbDelay.Text = ""
        '
        'tbMemID
        '
        Me.tbMemID.Enabled = False
        Me.tbMemID.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMemID.ForeColor = System.Drawing.Color.Maroon
        Me.tbMemID.Location = New System.Drawing.Point(96, 30)
        Me.tbMemID.Name = "tbMemID"
        Me.tbMemID.Size = New System.Drawing.Size(104, 22)
        Me.tbMemID.TabIndex = 5
        Me.tbMemID.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fines"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturn
        '
        Me.btnReturn.Enabled = False
        Me.btnReturn.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(240, 112)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(70, 23)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "&Return"
        '
        'frmReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(328, 230)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.MaximizeBox = False
        Me.Name = "frmReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click

        Dim Returned As Boolean
        Dim AccNo As Integer
        AccNo = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select count(accessionNo) from BorrowedCopy where accessionNo='" & tbAccNo.Text & "'")
        Returned = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select availability from BookCopy where accessionno='" & tbAccNo.Text & "'")

        If Returned = True Or AccNo = 0 Then
            MessageBox.Show("ReEnter the Accession No", "Verify Book", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            tbFines.Text = ""
            Dim OdDays As Int16
            Dim MemberID, Section As String
            Dim FineRate, Fine As Double

            Try
                OdDays = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select datediff(day, dueDate,getdate())from BorrowedCopy where dueDate<getdate()and accessionNo='" & tbAccNo.Text & "'")
                tbDelay.Text = CType(OdDays, String) + " Days"
                MemberID = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select memberID from BorrowedCopy where accessionNo='" & tbAccNo.Text & "'")
                tbMemID.Text = MemberID
                If OdDays > 0 Then
                    Section = SqlHelper.ExecuteScalar(sqlconn, CommandType.Text, "select status from BookCopy where accessionNo='4'")
                    If Section = "L" Then
                        FineRate = 2.0
                    ElseIf Section = "SR" Then
                        FineRate = 5.0
                    End If
                    Fine = FineRate * OdDays
                    tbFines.Text += "Rs. "
                    tbFines.Text += CType(Fine, String)
                    tbFines.Text += ".00"
                Else
                    tbFines.Text += "NO FINES"
                End If
                btnReturn.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Dim RB As New ClassBookCopy
        RB.Retn(tbAccNo.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub tbAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAccNo.TextChanged

        tbMemID.Text = ""
        tbDelay.Text = ""
        tbFines.Text = ""

    End Sub
End Class
