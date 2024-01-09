<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        PictureBox1 = New PictureBox()
        btn_passplus = New FontAwesome.Sharp.IconButton()
        btn_instructors = New FontAwesome.Sharp.IconButton()
        btn_lessons = New FontAwesome.Sharp.IconButton()
        btn_book = New FontAwesome.Sharp.IconButton()
        btn_profile = New FontAwesome.Sharp.IconButton()
        sidebarPanel = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox6 = New PictureBox()
        IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        btn_logout = New FontAwesome.Sharp.IconButton()
        CurrentLabel = New Label()
        sub_form = New Panel()
        Panel3 = New Panel()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        sidebarPanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        sub_form.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(112, 774)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btn_passplus
        ' 
        btn_passplus.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        btn_passplus.Cursor = Cursors.Hand
        btn_passplus.FlatStyle = FlatStyle.Flat
        btn_passplus.ForeColor = SystemColors.ButtonHighlight
        btn_passplus.IconChar = FontAwesome.Sharp.IconChar.BoxArchive
        btn_passplus.IconColor = Color.White
        btn_passplus.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_passplus.IconSize = 45
        btn_passplus.Location = New Point(66, 530)
        btn_passplus.Name = "btn_passplus"
        btn_passplus.Size = New Size(259, 61)
        btn_passplus.TabIndex = 25
        btn_passplus.Text = "STAFF INFO"
        btn_passplus.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_passplus.UseVisualStyleBackColor = False
        ' 
        ' btn_instructors
        ' 
        btn_instructors.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        btn_instructors.Cursor = Cursors.Hand
        btn_instructors.FlatStyle = FlatStyle.Flat
        btn_instructors.ForeColor = SystemColors.ButtonHighlight
        btn_instructors.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        btn_instructors.IconColor = Color.White
        btn_instructors.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_instructors.IconSize = 45
        btn_instructors.Location = New Point(66, 445)
        btn_instructors.Name = "btn_instructors"
        btn_instructors.Size = New Size(259, 61)
        btn_instructors.TabIndex = 24
        btn_instructors.Text = "TIMETABLE"
        btn_instructors.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_instructors.UseVisualStyleBackColor = False
        ' 
        ' btn_lessons
        ' 
        btn_lessons.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        btn_lessons.Cursor = Cursors.Hand
        btn_lessons.FlatStyle = FlatStyle.Flat
        btn_lessons.ForeColor = SystemColors.ButtonHighlight
        btn_lessons.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        btn_lessons.IconColor = Color.White
        btn_lessons.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_lessons.IconSize = 45
        btn_lessons.Location = New Point(66, 358)
        btn_lessons.Name = "btn_lessons"
        btn_lessons.Size = New Size(259, 61)
        btn_lessons.TabIndex = 23
        btn_lessons.Text = "LESSONS"
        btn_lessons.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_lessons.UseVisualStyleBackColor = False
        ' 
        ' btn_book
        ' 
        btn_book.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        btn_book.Cursor = Cursors.Hand
        btn_book.FlatStyle = FlatStyle.Flat
        btn_book.ForeColor = SystemColors.ButtonHighlight
        btn_book.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof
        btn_book.IconColor = Color.White
        btn_book.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_book.IconSize = 45
        btn_book.Location = New Point(66, 271)
        btn_book.Name = "btn_book"
        btn_book.Size = New Size(259, 61)
        btn_book.TabIndex = 22
        btn_book.Text = "STUDENTS"
        btn_book.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_book.UseVisualStyleBackColor = False
        ' 
        ' btn_profile
        ' 
        btn_profile.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        btn_profile.Cursor = Cursors.Hand
        btn_profile.FlatStyle = FlatStyle.Flat
        btn_profile.ForeColor = SystemColors.ButtonHighlight
        btn_profile.IconChar = FontAwesome.Sharp.IconChar.ChartSimple
        btn_profile.IconColor = Color.White
        btn_profile.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_profile.IconSize = 45
        btn_profile.Location = New Point(66, 177)
        btn_profile.Name = "btn_profile"
        btn_profile.Size = New Size(259, 61)
        btn_profile.TabIndex = 21
        btn_profile.Text = "OVERVIEW"
        btn_profile.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_profile.UseVisualStyleBackColor = False
        ' 
        ' sidebarPanel
        ' 
        sidebarPanel.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        sidebarPanel.Controls.Add(IconButton1)
        sidebarPanel.Controls.Add(Panel2)
        sidebarPanel.Controls.Add(PictureBox1)
        sidebarPanel.Controls.Add(btn_passplus)
        sidebarPanel.Controls.Add(btn_book)
        sidebarPanel.Controls.Add(btn_instructors)
        sidebarPanel.Controls.Add(btn_profile)
        sidebarPanel.Controls.Add(btn_lessons)
        sidebarPanel.Dock = DockStyle.Left
        sidebarPanel.Location = New Point(0, 0)
        sidebarPanel.Name = "sidebarPanel"
        sidebarPanel.Size = New Size(401, 903)
        sidebarPanel.TabIndex = 26
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(31), CByte(40), CByte(51))
        IconButton1.Cursor = Cursors.Hand
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = SystemColors.ButtonHighlight
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.CarOn
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 45
        IconButton1.Location = New Point(66, 615)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(259, 61)
        IconButton1.TabIndex = 26
        IconButton1.Text = "VEHICLE INFO"
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(80), CByte(70), CByte(229))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(401, 101)
        Panel2.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(21, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 23)
        Label2.TabIndex = 9
        Label2.Text = "Logged in as Admin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 60)
        Label1.TabIndex = 9
        Label1.Text = "Dashboard"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(281, 22)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(415, 62)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 8
        PictureBox6.TabStop = False
        ' 
        ' IconPictureBox6
        ' 
        IconPictureBox6.BackColor = Color.Transparent
        IconPictureBox6.Cursor = Cursors.Hand
        IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Gear
        IconPictureBox6.IconColor = Color.White
        IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox6.IconSize = 48
        IconPictureBox6.Location = New Point(997, 26)
        IconPictureBox6.Name = "IconPictureBox6"
        IconPictureBox6.Size = New Size(51, 48)
        IconPictureBox6.TabIndex = 7
        IconPictureBox6.TabStop = False
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.Transparent
        btn_logout.Cursor = Cursors.Hand
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.ForeColor = SystemColors.ButtonHighlight
        btn_logout.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        btn_logout.IconColor = Color.Crimson
        btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_logout.IconSize = 25
        btn_logout.Location = New Point(831, 25)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(142, 49)
        btn_logout.TabIndex = 6
        btn_logout.Text = "LOGOUT"
        btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' CurrentLabel
        ' 
        CurrentLabel.AutoSize = True
        CurrentLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurrentLabel.ForeColor = SystemColors.ButtonHighlight
        CurrentLabel.Location = New Point(6, 37)
        CurrentLabel.Name = "CurrentLabel"
        CurrentLabel.Size = New Size(59, 23)
        CurrentLabel.TabIndex = 1
        CurrentLabel.Text = "HOME"
        ' 
        ' sub_form
        ' 
        sub_form.BackColor = Color.White
        sub_form.Controls.Add(Panel3)
        sub_form.Controls.Add(Panel1)
        sub_form.Dock = DockStyle.Fill
        sub_form.Location = New Point(401, 0)
        sub_form.Name = "sub_form"
        sub_form.Size = New Size(1081, 903)
        sub_form.TabIndex = 28
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(242), CByte(246), CByte(255))
        Panel3.Controls.Add(BunifuFlatButton1)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 101)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1081, 802)
        Panel3.TabIndex = 1
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "Click to navigate to Overview"
        BunifuFlatButton1.DisabledColor = Color.Gray
        BunifuFlatButton1.Iconcolor = Color.Transparent
        BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), Image)
        BunifuFlatButton1.Iconimage_right = Nothing
        BunifuFlatButton1.Iconimage_right_Selected = Nothing
        BunifuFlatButton1.Iconimage_Selected = Nothing
        BunifuFlatButton1.IconMarginLeft = 0
        BunifuFlatButton1.IconMarginRight = 0
        BunifuFlatButton1.IconRightVisible = True
        BunifuFlatButton1.IconRightZoom = 0R
        BunifuFlatButton1.IconVisible = True
        BunifuFlatButton1.IconZoom = 90R
        BunifuFlatButton1.IsTab = False
        BunifuFlatButton1.Location = New Point(218, 407)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(401, 92)
        BunifuFlatButton1.TabIndex = 12
        BunifuFlatButton1.Text = "Click to navigate to Overview"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(218, 328)
        Label4.Name = "Label4"
        Label4.Size = New Size(339, 31)
        Label4.TabIndex = 11
        Label4.Text = "You're Logged in as Administrator"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(200, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(725, 81)
        Label3.TabIndex = 10
        Label3.Text = "Welcome to the Dashboard"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(80), CByte(70), CByte(229))
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(IconPictureBox6)
        Panel1.Controls.Add(CurrentLabel)
        Panel1.Controls.Add(btn_logout)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1081, 101)
        Panel1.TabIndex = 0
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1482, 903)
        Controls.Add(sub_form)
        Controls.Add(sidebarPanel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        sidebarPanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox6, ComponentModel.ISupportInitialize).EndInit()
        sub_form.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_passplus As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_instructors As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_lessons As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_book As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_profile As FontAwesome.Sharp.IconButton
    Friend WithEvents sidebarPanel As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents CurrentLabel As Label
    Friend WithEvents sub_form As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
