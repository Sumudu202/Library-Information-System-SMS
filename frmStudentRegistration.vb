Public Class frmStudentRegistration
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
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabUndergraduate As System.Windows.Forms.TabPage
    Friend WithEvents TabPostgraduate As System.Windows.Forms.TabPage
    Friend WithEvents btnChange1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRegister1 As System.Windows.Forms.Button
    Friend WithEvents btnExit1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabUndergraduate = New System.Windows.Forms.TabPage
        Me.btnChange1 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnRegister1 = New System.Windows.Forms.Button
        Me.btnExit1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TabPostgraduate = New System.Windows.Forms.TabPage
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabControl.SuspendLayout()
        Me.TabUndergraduate.SuspendLayout()
        Me.TabPostgraduate.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl.Controls.Add(Me.TabUndergraduate)
        Me.TabControl.Controls.Add(Me.TabPostgraduate)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(720, 392)
        Me.TabControl.TabIndex = 85
        '
        'TabUndergraduate
        '
        Me.TabUndergraduate.Controls.Add(Me.btnChange1)
        Me.TabUndergraduate.Controls.Add(Me.ComboBox2)
        Me.TabUndergraduate.Controls.Add(Me.Label10)
        Me.TabUndergraduate.Controls.Add(Me.TextBox7)
        Me.TabUndergraduate.Controls.Add(Me.Label9)
        Me.TabUndergraduate.Controls.Add(Me.RadioButton2)
        Me.TabUndergraduate.Controls.Add(Me.RadioButton1)
        Me.TabUndergraduate.Controls.Add(Me.Label8)
        Me.TabUndergraduate.Controls.Add(Me.btnRegister1)
        Me.TabUndergraduate.Controls.Add(Me.btnExit1)
        Me.TabUndergraduate.Controls.Add(Me.ComboBox1)
        Me.TabUndergraduate.Controls.Add(Me.TextBox6)
        Me.TabUndergraduate.Controls.Add(Me.TextBox5)
        Me.TabUndergraduate.Controls.Add(Me.TextBox4)
        Me.TabUndergraduate.Controls.Add(Me.TextBox3)
        Me.TabUndergraduate.Controls.Add(Me.Label7)
        Me.TabUndergraduate.Controls.Add(Me.Label6)
        Me.TabUndergraduate.Controls.Add(Me.Label5)
        Me.TabUndergraduate.Controls.Add(Me.Label4)
        Me.TabUndergraduate.Controls.Add(Me.Label3)
        Me.TabUndergraduate.Controls.Add(Me.Label2)
        Me.TabUndergraduate.Controls.Add(Me.Label1)
        Me.TabUndergraduate.Controls.Add(Me.TextBox1)
        Me.TabUndergraduate.Controls.Add(Me.TextBox2)
        Me.TabUndergraduate.Location = New System.Drawing.Point(4, 25)
        Me.TabUndergraduate.Name = "TabUndergraduate"
        Me.TabUndergraduate.Size = New System.Drawing.Size(712, 363)
        Me.TabUndergraduate.TabIndex = 0
        Me.TabUndergraduate.Text = "UnderGraguate Student"
        '
        'btnChange1
        '
        Me.btnChange1.BackColor = System.Drawing.Color.Tan
        Me.btnChange1.Location = New System.Drawing.Point(456, 160)
        Me.btnChange1.Name = "btnChange1"
        Me.btnChange1.Size = New System.Drawing.Size(72, 24)
        Me.btnChange1.TabIndex = 108
        Me.btnChange1.Text = "&Change"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Items.AddRange(New Object() {"Rev", "Mr", "Mrs", "Miss", ""})
        Me.ComboBox2.Location = New System.Drawing.Point(192, 152)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox2.TabIndex = 107
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DimGray
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 23)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Title"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox7.Location = New System.Drawing.Point(192, 56)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(240, 20)
        Me.TextBox7.TabIndex = 105
        Me.TextBox7.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 23)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = " National ID No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(344, 184)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton2.TabIndex = 103
        Me.RadioButton2.Text = "Female"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(224, 184)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton1.TabIndex = 102
        Me.RadioButton1.Text = "Male"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DimGray
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 23)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Sex"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister1
        '
        Me.btnRegister1.BackColor = System.Drawing.Color.Tan
        Me.btnRegister1.Location = New System.Drawing.Point(456, 48)
        Me.btnRegister1.Name = "btnRegister1"
        Me.btnRegister1.Size = New System.Drawing.Size(72, 24)
        Me.btnRegister1.TabIndex = 100
        Me.btnRegister1.Text = "&Register"
        '
        'btnExit1
        '
        Me.btnExit1.BackColor = System.Drawing.Color.Tan
        Me.btnExit1.Location = New System.Drawing.Point(456, 272)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(72, 24)
        Me.btnExit1.TabIndex = 99
        Me.btnExit1.Text = "&Exit"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"1st Year ", "2nd Year ", "3rd Year ", "4th Year"})
        Me.ComboBox1.Location = New System.Drawing.Point(192, 312)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 98
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox6.Location = New System.Drawing.Point(192, 280)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 20)
        Me.TextBox6.TabIndex = 97
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox5.Location = New System.Drawing.Point(192, 248)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(240, 20)
        Me.TextBox5.TabIndex = 96
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox4.Location = New System.Drawing.Point(192, 216)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(240, 20)
        Me.TextBox4.TabIndex = 95
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox3.Location = New System.Drawing.Point(192, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 94
        Me.TextBox3.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 23)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Stage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 23)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Contact No"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Permanent Address"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 23)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Term Time Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Student No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox1.Location = New System.Drawing.Point(192, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 86
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox2.Location = New System.Drawing.Point(192, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 88
        Me.TextBox2.Text = ""
        '
        'TabPostgraduate
        '
        Me.TabPostgraduate.Controls.Add(Me.Button2)
        Me.TabPostgraduate.Controls.Add(Me.ComboBox3)
        Me.TabPostgraduate.Controls.Add(Me.Label11)
        Me.TabPostgraduate.Controls.Add(Me.TextBox8)
        Me.TabPostgraduate.Controls.Add(Me.Label12)
        Me.TabPostgraduate.Controls.Add(Me.RadioButton3)
        Me.TabPostgraduate.Controls.Add(Me.RadioButton4)
        Me.TabPostgraduate.Controls.Add(Me.Label13)
        Me.TabPostgraduate.Controls.Add(Me.Button3)
        Me.TabPostgraduate.Controls.Add(Me.Button4)
        Me.TabPostgraduate.Controls.Add(Me.ComboBox4)
        Me.TabPostgraduate.Controls.Add(Me.TextBox9)
        Me.TabPostgraduate.Controls.Add(Me.TextBox10)
        Me.TabPostgraduate.Controls.Add(Me.TextBox11)
        Me.TabPostgraduate.Controls.Add(Me.TextBox12)
        Me.TabPostgraduate.Controls.Add(Me.Label14)
        Me.TabPostgraduate.Controls.Add(Me.Label15)
        Me.TabPostgraduate.Controls.Add(Me.Label16)
        Me.TabPostgraduate.Controls.Add(Me.Label17)
        Me.TabPostgraduate.Controls.Add(Me.Label18)
        Me.TabPostgraduate.Controls.Add(Me.Label19)
        Me.TabPostgraduate.Controls.Add(Me.Label20)
        Me.TabPostgraduate.Controls.Add(Me.TextBox13)
        Me.TabPostgraduate.Controls.Add(Me.TextBox14)
        Me.TabPostgraduate.Location = New System.Drawing.Point(4, 25)
        Me.TabPostgraduate.Name = "TabPostgraduate"
        Me.TabPostgraduate.Size = New System.Drawing.Size(712, 363)
        Me.TabPostgraduate.TabIndex = 1
        Me.TabPostgraduate.Text = "Postgraduate Student"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox3.ItemHeight = 13
        Me.ComboBox3.Items.AddRange(New Object() {"Rev", "Mr", "Mrs", "Miss", ""})
        Me.ComboBox3.Location = New System.Drawing.Point(192, 154)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox3.TabIndex = 132
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DimGray
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 23)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Title"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox8.Location = New System.Drawing.Point(192, 58)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(240, 20)
        Me.TextBox8.TabIndex = 130
        Me.TextBox8.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DimGray
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 23)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = " National ID No"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(344, 186)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton3.TabIndex = 128
        Me.RadioButton3.Text = "Female"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(224, 186)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton4.TabIndex = 127
        Me.RadioButton4.Text = "Male"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DimGray
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 23)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Sex"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Tan
        Me.Button3.Location = New System.Drawing.Point(448, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 24)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "&Register"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Tan
        Me.Button4.Location = New System.Drawing.Point(448, 274)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 24)
        Me.Button4.TabIndex = 124
        Me.Button4.Text = "&Exit"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.SeaShell
        Me.ComboBox4.ItemHeight = 13
        Me.ComboBox4.Items.AddRange(New Object() {"1st Year ", "2nd Year "})
        Me.ComboBox4.Location = New System.Drawing.Point(192, 314)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox4.TabIndex = 123
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox9.Location = New System.Drawing.Point(192, 282)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(240, 20)
        Me.TextBox9.TabIndex = 122
        Me.TextBox9.Text = ""
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox10.Location = New System.Drawing.Point(192, 250)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(240, 20)
        Me.TextBox10.TabIndex = 121
        Me.TextBox10.Text = ""
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox11.Location = New System.Drawing.Point(192, 218)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(240, 20)
        Me.TextBox11.TabIndex = 120
        Me.TextBox11.Text = ""
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox12.Location = New System.Drawing.Point(192, 122)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(240, 20)
        Me.TextBox12.TabIndex = 119
        Me.TextBox12.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.DimGray
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 23)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Stage"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DimGray
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 23)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Contact No"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DimGray
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 23)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Permanent Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DimGray
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 23)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "Term Time Address"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DimGray
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 23)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "Last Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DimGray
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 23)
        Me.Label19.TabIndex = 112
        Me.Label19.Text = "First Name"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DimGray
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 23)
        Me.Label20.TabIndex = 110
        Me.Label20.Text = "Student No"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox13.Location = New System.Drawing.Point(192, 26)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(240, 20)
        Me.TextBox13.TabIndex = 111
        Me.TextBox13.Text = ""
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox14.Location = New System.Drawing.Point(192, 90)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(240, 20)
        Me.TextBox14.TabIndex = 113
        Me.TextBox14.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tan
        Me.Button2.Location = New System.Drawing.Point(448, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "&Clear"
        '
        'frmStudentRegistration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 382)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "frmStudentRegistration"
        Me.Text = "frmStudentRegistration"
        Me.TabControl.ResumeLayout(False)
        Me.TabUndergraduate.ResumeLayout(False)
        Me.TabPostgraduate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
