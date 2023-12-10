<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_interface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_interface))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Label5 = New Label()
        Label4 = New Label()
        btn_passplus = New FontAwesome.Sharp.IconButton()
        btn_instructors = New FontAwesome.Sharp.IconButton()
        btn_lessons = New FontAwesome.Sharp.IconButton()
        btn_book = New FontAwesome.Sharp.IconButton()
        btn_profile = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        sidebarPanel = New Panel()
        btn_logout = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        Label9 = New Label()
        Label3 = New Label()
        IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Label2 = New Label()
        Current_Icon = New FontAwesome.Sharp.IconPictureBox()
        CurrentLabel = New Label()
        sub_form = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(IconPictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(Current_Icon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(IconPictureBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btn_passplus)
        Panel1.Controls.Add(btn_instructors)
        Panel1.Controls.Add(btn_lessons)
        Panel1.Controls.Add(btn_book)
        Panel1.Controls.Add(btn_profile)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(IconPictureBox3)
        Panel1.Controls.Add(IconPictureBox4)
        Panel1.Controls.Add(IconPictureBox5)
        Panel1.Controls.Add(sidebarPanel)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(401, 903)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(32, 706)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(353, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(84, 831)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 20)
        Label8.TabIndex = 14
        Label8.Text = "Send an Enquiry"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(83, 794)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 20)
        Label7.TabIndex = 13
        Label7.Text = "Email Us"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(83, 755)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 12
        Label6.Text = "Call Us"
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        IconPictureBox2.ForeColor = SystemColors.ButtonHighlight
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Headset
        IconPictureBox2.IconColor = SystemColors.ButtonHighlight
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 40
        IconPictureBox2.Location = New Point(103, 673)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(40, 40)
        IconPictureBox2.TabIndex = 11
        IconPictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(246, 675)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 28)
        Label5.TabIndex = 10
        Label5.Text = "US"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(150, 675)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 28)
        Label4.TabIndex = 9
        Label4.Text = "CONTACT"
        ' 
        ' btn_passplus
        ' 
        btn_passplus.BackColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btn_passplus.FlatStyle = FlatStyle.Flat
        btn_passplus.IconChar = FontAwesome.Sharp.IconChar.Medal
        btn_passplus.IconColor = Color.Black
        btn_passplus.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_passplus.IconSize = 45
        btn_passplus.Location = New Point(77, 547)
        btn_passplus.Name = "btn_passplus"
        btn_passplus.Size = New Size(259, 61)
        btn_passplus.TabIndex = 5
        btn_passplus.Text = "®PassPlus"
        btn_passplus.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_passplus.UseVisualStyleBackColor = False
        ' 
        ' btn_instructors
        ' 
        btn_instructors.BackColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btn_instructors.FlatStyle = FlatStyle.Flat
        btn_instructors.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        btn_instructors.IconColor = Color.Black
        btn_instructors.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_instructors.IconSize = 45
        btn_instructors.Location = New Point(77, 462)
        btn_instructors.Name = "btn_instructors"
        btn_instructors.Size = New Size(259, 61)
        btn_instructors.TabIndex = 4
        btn_instructors.Text = "INSTRUCTORS"
        btn_instructors.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_instructors.UseVisualStyleBackColor = False
        ' 
        ' btn_lessons
        ' 
        btn_lessons.BackColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btn_lessons.FlatStyle = FlatStyle.Flat
        btn_lessons.IconChar = FontAwesome.Sharp.IconChar.CarRear
        btn_lessons.IconColor = Color.Black
        btn_lessons.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_lessons.IconSize = 45
        btn_lessons.Location = New Point(77, 375)
        btn_lessons.Name = "btn_lessons"
        btn_lessons.Size = New Size(259, 61)
        btn_lessons.TabIndex = 3
        btn_lessons.Text = "LESSONS"
        btn_lessons.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_lessons.UseVisualStyleBackColor = False
        ' 
        ' btn_book
        ' 
        btn_book.BackColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btn_book.FlatStyle = FlatStyle.Flat
        btn_book.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt
        btn_book.IconColor = Color.Black
        btn_book.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_book.IconSize = 45
        btn_book.Location = New Point(77, 288)
        btn_book.Name = "btn_book"
        btn_book.Size = New Size(259, 61)
        btn_book.TabIndex = 2
        btn_book.Text = "BOOKINGS"
        btn_book.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_book.UseVisualStyleBackColor = False
        ' 
        ' btn_profile
        ' 
        btn_profile.BackColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btn_profile.FlatStyle = FlatStyle.Flat
        btn_profile.IconChar = FontAwesome.Sharp.IconChar.UserCog
        btn_profile.IconColor = Color.Black
        btn_profile.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_profile.IconSize = 45
        btn_profile.Location = New Point(77, 202)
        btn_profile.Name = "btn_profile"
        btn_profile.Size = New Size(259, 61)
        btn_profile.TabIndex = 1
        btn_profile.Text = "PROFILE"
        btn_profile.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_profile.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(401, 176)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(373, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        IconPictureBox3.ForeColor = SystemColors.ButtonHighlight
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Phone
        IconPictureBox3.IconColor = SystemColors.ButtonHighlight
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 31
        IconPictureBox3.Location = New Point(33, 749)
        IconPictureBox3.Name = "IconPictureBox3"
        IconPictureBox3.Size = New Size(38, 31)
        IconPictureBox3.TabIndex = 15
        IconPictureBox3.TabStop = False
        ' 
        ' IconPictureBox4
        ' 
        IconPictureBox4.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        IconPictureBox4.ForeColor = SystemColors.ButtonHighlight
        IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen
        IconPictureBox4.IconColor = SystemColors.ButtonHighlight
        IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox4.IconSize = 31
        IconPictureBox4.Location = New Point(33, 826)
        IconPictureBox4.Name = "IconPictureBox4"
        IconPictureBox4.Size = New Size(38, 31)
        IconPictureBox4.TabIndex = 16
        IconPictureBox4.TabStop = False
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        IconPictureBox5.ForeColor = SystemColors.ButtonHighlight
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        IconPictureBox5.IconColor = SystemColors.ButtonHighlight
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 31
        IconPictureBox5.Location = New Point(32, 789)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(38, 31)
        IconPictureBox5.TabIndex = 17
        IconPictureBox5.TabStop = False
        ' 
        ' sidebarPanel
        ' 
        sidebarPanel.Dock = DockStyle.Fill
        sidebarPanel.Location = New Point(0, 0)
        sidebarPanel.Name = "sidebarPanel"
        sidebarPanel.Size = New Size(401, 903)
        sidebarPanel.TabIndex = 19
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.ForeColor = SystemColors.ButtonHighlight
        btn_logout.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        btn_logout.IconColor = Color.Crimson
        btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_logout.IconSize = 25
        btn_logout.Location = New Point(846, 40)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(142, 49)
        btn_logout.TabIndex = 6
        btn_logout.Text = "LOGOUT"
        btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(22))
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(IconPictureBox6)
        Panel3.Controls.Add(btn_logout)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Current_Icon)
        Panel3.Controls.Add(CurrentLabel)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(401, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1081, 125)
        Panel3.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonShadow
        Label9.Location = New Point(1000, 87)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 17)
        Label9.TabIndex = 8
        Label9.Text = "SETTINGS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(656, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 23)
        Label3.TabIndex = 3
        Label3.Text = "Chamod Abeyrathne"
        ' 
        ' IconPictureBox6
        ' 
        IconPictureBox6.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(22))
        IconPictureBox6.ForeColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Gear
        IconPictureBox6.IconColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox6.IconSize = 48
        IconPictureBox6.Location = New Point(1006, 36)
        IconPictureBox6.Name = "IconPictureBox6"
        IconPictureBox6.Size = New Size(51, 48)
        IconPictureBox6.TabIndex = 7
        IconPictureBox6.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tw Cen MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(711, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 33)
        Label2.TabIndex = 2
        Label2.Text = "Welcome! "
        ' 
        ' Current_Icon
        ' 
        Current_Icon.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(22))
        Current_Icon.ForeColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        Current_Icon.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt
        Current_Icon.IconColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        Current_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto
        Current_Icon.IconSize = 48
        Current_Icon.Location = New Point(50, 39)
        Current_Icon.Name = "Current_Icon"
        Current_Icon.Size = New Size(51, 48)
        Current_Icon.TabIndex = 0
        Current_Icon.TabStop = False
        ' 
        ' CurrentLabel
        ' 
        CurrentLabel.AutoSize = True
        CurrentLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurrentLabel.ForeColor = SystemColors.ButtonShadow
        CurrentLabel.Location = New Point(120, 54)
        CurrentLabel.Name = "CurrentLabel"
        CurrentLabel.Size = New Size(59, 23)
        CurrentLabel.TabIndex = 1
        CurrentLabel.Text = "HOME"
        ' 
        ' sub_form
        ' 
        sub_form.Dock = DockStyle.Fill
        sub_form.Location = New Point(401, 125)
        sub_form.Name = "sub_form"
        sub_form.Size = New Size(1081, 778)
        sub_form.TabIndex = 2
        ' 
        ' main_interface
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1482, 903)
        Controls.Add(sub_form)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "main_interface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PassIT - Driving School"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(IconPictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(Current_Icon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_profile As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_passplus As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_instructors As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_lessons As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_book As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents CurrentLabel As Label
    Friend WithEvents Current_Icon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents sidebarPanel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents sub_form As Panel
End Class
