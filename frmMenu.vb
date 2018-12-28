Imports Library.frmlogging
Public Class frmMenu
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
    Friend WithEvents miAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents miRemove As System.Windows.Forms.MenuItem
    Friend WithEvents miNew As System.Windows.Forms.MenuItem
    Friend WithEvents miStuReg As System.Windows.Forms.MenuItem
    Friend WithEvents miMember As System.Windows.Forms.MenuItem
    Friend WithEvents miAddNewCopy As System.Windows.Forms.MenuItem
    Friend WithEvents miEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents miUsers As System.Windows.Forms.MenuItem
    Friend WithEvents miAddU As System.Windows.Forms.MenuItem
    Friend WithEvents miDelU As System.Windows.Forms.MenuItem
    Friend WithEvents michanU As System.Windows.Forms.MenuItem
    Friend WithEvents miExit As System.Windows.Forms.MenuItem
    Friend WithEvents miChanM As System.Windows.Forms.MenuItem
    Friend WithEvents miDelM As System.Windows.Forms.MenuItem
    Friend WithEvents miReport As System.Windows.Forms.MenuItem
    Friend WithEvents miMangRepor As System.Windows.Forms.MenuItem
    Friend WithEvents miBook As System.Windows.Forms.MenuItem
    Friend WithEvents miLend As System.Windows.Forms.MenuItem
    Friend WithEvents miReturn As System.Windows.Forms.MenuItem
    Friend WithEvents miReserve As System.Windows.Forms.MenuItem
    Friend WithEvents miOverdueRe As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents miAddAu As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents miStfReg As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMenu))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.miUsers = New System.Windows.Forms.MenuItem
        Me.miAddU = New System.Windows.Forms.MenuItem
        Me.michanU = New System.Windows.Forms.MenuItem
        Me.miDelU = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.miExit = New System.Windows.Forms.MenuItem
        Me.miMember = New System.Windows.Forms.MenuItem
        Me.miNew = New System.Windows.Forms.MenuItem
        Me.miStuReg = New System.Windows.Forms.MenuItem
        Me.miStfReg = New System.Windows.Forms.MenuItem
        Me.miChanM = New System.Windows.Forms.MenuItem
        Me.miDelM = New System.Windows.Forms.MenuItem
        Me.miBook = New System.Windows.Forms.MenuItem
        Me.miAddNew = New System.Windows.Forms.MenuItem
        Me.miAddNewCopy = New System.Windows.Forms.MenuItem
        Me.miRemove = New System.Windows.Forms.MenuItem
        Me.miEdit = New System.Windows.Forms.MenuItem
        Me.miLend = New System.Windows.Forms.MenuItem
        Me.miReturn = New System.Windows.Forms.MenuItem
        Me.miReserve = New System.Windows.Forms.MenuItem
        Me.miReport = New System.Windows.Forms.MenuItem
        Me.miOverdueRe = New System.Windows.Forms.MenuItem
        Me.miMangRepor = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.miAddAu = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miUsers, Me.miMember, Me.miBook, Me.miLend, Me.miReturn, Me.miReserve, Me.miReport, Me.MenuItem2, Me.MenuItem1, Me.MenuItem4})
        '
        'miUsers
        '
        Me.miUsers.Index = 0
        Me.miUsers.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAddU, Me.michanU, Me.miDelU, Me.MenuItem9, Me.miExit})
        Me.miUsers.Text = "&User"
        '
        'miAddU
        '
        Me.miAddU.Index = 0
        Me.miAddU.Shortcut = System.Windows.Forms.Shortcut.CtrlU
        Me.miAddU.Text = "&Add New User"
        '
        'michanU
        '
        Me.michanU.Index = 1
        Me.michanU.Text = "&Change Password"
        '
        'miDelU
        '
        Me.miDelU.Index = 2
        Me.miDelU.Text = "&Delete User"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Text = "-"
        '
        'miExit
        '
        Me.miExit.Index = 4
        Me.miExit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.miExit.Text = "&Exit"
        '
        'miMember
        '
        Me.miMember.Index = 1
        Me.miMember.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNew, Me.miChanM, Me.miDelM})
        Me.miMember.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.miMember.Text = "&Member"
        '
        'miNew
        '
        Me.miNew.Index = 0
        Me.miNew.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miStuReg, Me.miStfReg})
        Me.miNew.Text = "&New"
        '
        'miStuReg
        '
        Me.miStuReg.Index = 0
        Me.miStuReg.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.miStuReg.Text = "&Student"
        '
        'miStfReg
        '
        Me.miStfReg.Index = 1
        Me.miStfReg.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.miStfReg.Text = "&Staff"
        '
        'miChanM
        '
        Me.miChanM.Index = 1
        Me.miChanM.Text = "&Edit"
        '
        'miDelM
        '
        Me.miDelM.Index = 2
        Me.miDelM.Text = "&Delete"
        '
        'miBook
        '
        Me.miBook.Index = 2
        Me.miBook.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAddNew, Me.miAddNewCopy, Me.miRemove, Me.miEdit})
        Me.miBook.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.miBook.Text = "&Book"
        '
        'miAddNew
        '
        Me.miAddNew.Index = 0
        Me.miAddNew.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.miAddNew.Text = "&Add New Book"
        '
        'miAddNewCopy
        '
        Me.miAddNewCopy.Index = 1
        Me.miAddNewCopy.Text = "&Add New Copy"
        '
        'miRemove
        '
        Me.miRemove.Index = 2
        Me.miRemove.Text = "&Remove"
        '
        'miEdit
        '
        Me.miEdit.Index = 3
        Me.miEdit.Text = "&Edit"
        '
        'miLend
        '
        Me.miLend.Index = 3
        Me.miLend.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.miLend.Text = "&Lending"
        '
        'miReturn
        '
        Me.miReturn.Index = 4
        Me.miReturn.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.miReturn.Text = "&Returning"
        '
        'miReserve
        '
        Me.miReserve.Index = 5
        Me.miReserve.Text = "&Reservation"
        '
        'miReport
        '
        Me.miReport.Index = 6
        Me.miReport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOverdueRe, Me.miMangRepor})
        Me.miReport.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.miReport.Text = "&Reports"
        '
        'miOverdueRe
        '
        Me.miOverdueRe.Index = 0
        Me.miOverdueRe.Text = "Overdue Reprt"
        '
        'miMangRepor
        '
        Me.miMangRepor.Index = 1
        Me.miMangRepor.Text = "Management Report"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAddAu, Me.MenuItem5})
        Me.MenuItem2.Text = "&Author"
        '
        'miAddAu
        '
        Me.miAddAu.Index = 0
        Me.miAddAu.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.miAddAu.Text = "&Add New Author"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "&Edit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 8
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem6})
        Me.MenuItem1.Text = "&Publisher"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem3.Text = "&Add New Publisher"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "&Edit"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 9
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem4.Text = "&MemberLevel"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem7.Text = "&Add New Level"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "&Edit"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(616, 271)
        Me.Label1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Location = New System.Drawing.Point(112, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(888, 916)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(632, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(736, 364)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 309)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Load"

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DisableMenuItemsForClarical(2) As String
        DisableMenuItemsForClarical(0) = "&Add New User"
        DisableMenuItemsForClarical(1) = "&Delete User"

        If ClaricalUser = True Then
            DiableMenu(MainMenu1, DisableMenuItemsForClarical)
        End If

    End Sub

#End Region

#Region "The function for menu disable"

    Function DiableMenu(ByVal Menu As Object, ByVal DisItems() As String)
        Dim MI As MenuItem
        For Each MI In Menu.MenuItems
            If DisItems.BinarySearch(DisItems, MI.Text) > -1 Then
                MI.Enabled = False
            End If

            If MI.MenuItems.Count <> 0 Then
                DiableMenu(MI, DisItems)
            End If
        Next
    End Function

#End Region

#Region "Add new user"

    Private Sub miAddU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAddU.Click

        Dim NewUserform As New frmNewUser
        NewUserform.Show()

    End Sub

#End Region

#Region "Change the password"

    Private Sub michanU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles michanU.Click

        Dim changePwdform As New frmChangePwd
        changePwdform.Show()

    End Sub

#End Region

#Region "Delete  user"

    Private Sub miDelU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miDelU.Click

        Dim deleteUserform As New frmDeleteUser
        deleteUserform.Show()

    End Sub

#End Region

#Region "Exit from the menu"

    Private Sub miExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miExit.Click

        Me.Close()

    End Sub

#End Region


#Region "Add new book"

    Private Sub miAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAddNew.Click

        Dim frmBook As New frmBookRegistration
        frmBook.Show()

    End Sub

#End Region

#Region "Add new copy"

    Private Sub miAddNewCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAddNewCopy.Click

        Dim frmAddCopy As New frmBookCopyReg
        frmAddCopy.Show()

    End Sub

#End Region

#Region "Remove book"

    Private Sub miRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miRemove.Click

        Dim frmRemoveBook As New frmRemoveBook
        frmRemoveBook.Show()

    End Sub

#End Region


#Region "Student registration"

    Private Sub miStuReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miStuReg.Click

        Dim frmStudentReg As New frmStuReg
        frmStudentReg.Show()

    End Sub

#End Region

#Region "Staff registration"

    Private Sub miStfReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miStfReg.Click

        Dim frmStaffReg As New frmStaffReg
        frmStaffReg.Show()
    End Sub

#End Region

#Region "Edit Member details"

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miChanM.Click

        Dim frmChangeMem As New frmEditMemberDetails
        frmChangeMem.Show()

    End Sub

#End Region


#Region "Lend"

    Private Sub miLend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miLend.Click

        Dim LendConform As New frmLendingConf
        LendConform.Show()

    End Sub

#End Region

#Region "Return"

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miReturn.Click

        Dim Returnform As New frmReturn
        Returnform.Show()

    End Sub

#End Region

#Region "Overdu report"

    Private Sub miOverdueRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miOverdueRe.Click

        Dim overdueRe As New frmOverdueRe
        overdueRe.Show()

    End Sub

#End Region

#Region "Reserve"

    Private Sub miReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miReserve.Click
        Dim ReserveForm As New frmReservation
        ReserveForm.Show()
    End Sub

#End Region

#Region "Add new author"

    Private Sub miAddAu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAddAu.Click

        Dim Author As New frmAuthorReg
        Author.Show()

    End Sub

#End Region

#Region "Add new Member Type"

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click

        Dim MemberType As New frmAddMemberType
        MemberType.Show()

    End Sub

#End Region

#Region "EditMember Level"

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click

        Dim frmMemLevel As New frmEditMemLevel
        frmMemLevel.Show()

    End Sub

#End Region


#Region "Remove Member"

    Private Sub miDelM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miDelM.Click

        Dim ReMemberForm As New frmRemoveMember
        ReMemberForm.Show()

    End Sub

#End Region
    
    Private Sub miEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEdit.Click

    End Sub

#Region "Edit Author Details"

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click

        Dim EditAuForm As New frmEditAuthor
        EditAuForm.Show()

    End Sub

#End Region

    
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    End Sub
End Class
