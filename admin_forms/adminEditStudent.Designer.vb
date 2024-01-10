<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminEditStudent
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminEditStudent))
        Button1 = New Button()
        cboStatus = New ComboBox()
        cboLevel = New ComboBox()
        cboType = New ComboBox()
        btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        lstCurrentlyActive = New CheckedListBox()
        Label12 = New Label()
        lstVehicleType = New CheckedListBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        txtAddress = New TextBox()
        Label6 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        txtContactNumber = New TextBox()
        Label4 = New Label()
        txtTempPassword = New TextBox()
        Label2 = New Label()
        txtEmail = New TextBox()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtName = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        Label1 = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(216, 446)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 29)
        Button1.TabIndex = 160
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(700, 189)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(244, 28)
        cboStatus.TabIndex = 159
        cboStatus.Text = "Active"
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Introductory", "Standard", "PassPlus"})
        cboLevel.Location = New Point(384, 278)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(237, 28)
        cboLevel.TabIndex = 158
        cboLevel.Text = "Introductory"
        ' 
        ' cboType
        ' 
        cboType.FormattingEnabled = True
        cboType.Items.AddRange(New Object() {"Pay as You Go", "Monthly", "Yearly"})
        cboType.Location = New Point(387, 190)
        cboType.Name = "cboType"
        cboType.Size = New Size(237, 28)
        cboType.TabIndex = 157
        cboType.Text = "Pay as You Go"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Active = False
        btnSubmit.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.BorderRadius = 0
        btnSubmit.ButtonText = "    Confirm and Edit Student"
        btnSubmit.DisabledColor = Color.Gray
        btnSubmit.Iconcolor = Color.Transparent
        btnSubmit.Iconimage = CType(resources.GetObject("btnSubmit.Iconimage"), Image)
        btnSubmit.Iconimage_right = Nothing
        btnSubmit.Iconimage_right_Selected = Nothing
        btnSubmit.Iconimage_Selected = Nothing
        btnSubmit.IconMarginLeft = 10
        btnSubmit.IconMarginRight = 0
        btnSubmit.IconRightVisible = True
        btnSubmit.IconRightZoom = 0R
        btnSubmit.IconVisible = True
        btnSubmit.IconZoom = 50R
        btnSubmit.IsTab = False
        btnSubmit.Location = New Point(657, 654)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        btnSubmit.OnHoverTextColor = Color.White
        btnSubmit.selected = False
        btnSubmit.Size = New Size(287, 60)
        btnSubmit.TabIndex = 156
        btnSubmit.Text = "    Confirm and Edit Student"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.Textcolor = Color.White
        btnSubmit.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' lstCurrentlyActive
        ' 
        lstCurrentlyActive.FormattingEnabled = True
        lstCurrentlyActive.Items.AddRange(New Object() {"B", "A1", "A2", "A", "AM", "C1", "C1E", "D1", "D1E", "D", "DE"})
        lstCurrentlyActive.Location = New Point(703, 359)
        lstCurrentlyActive.Name = "lstCurrentlyActive"
        lstCurrentlyActive.Size = New Size(237, 246)
        lstCurrentlyActive.TabIndex = 155
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(700, 331)
        Label12.Name = "Label12"
        Label12.Size = New Size(136, 25)
        Label12.TabIndex = 154
        Label12.Text = "Currently Active"
        ' 
        ' lstVehicleType
        ' 
        lstVehicleType.FormattingEnabled = True
        lstVehicleType.Items.AddRange(New Object() {"B", "A1", "A2", "A", "AM", "C1", "C1E", "D1", "D1E", "D", "DE"})
        lstVehicleType.Location = New Point(387, 359)
        lstVehicleType.Name = "lstVehicleType"
        lstVehicleType.Size = New Size(237, 246)
        lstVehicleType.TabIndex = 153
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(384, 331)
        Label11.Name = "Label11"
        Label11.Size = New Size(116, 25)
        Label11.TabIndex = 152
        Label11.Text = "Vehicle Types"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(384, 251)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 151
        Label10.Text = "Level"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(700, 162)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 25)
        Label9.TabIndex = 150
        Label9.Text = "Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(384, 162)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 25)
        Label8.TabIndex = 149
        Label8.Text = "Subscription Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(60, 593)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 146
        Label5.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(60, 621)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(240, 27)
        txtAddress.TabIndex = 145
        txtAddress.Text = "Castle Court"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(60, 507)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 25)
        Label6.TabIndex = 144
        Label6.Text = "Contact Number"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(60, 687)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(240, 27)
        TextBox8.TabIndex = 148
        TextBox8.Text = "UK"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(60, 654)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(240, 27)
        TextBox7.TabIndex = 147
        TextBox7.Text = "Dudley"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(60, 535)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(240, 27)
        txtContactNumber.TabIndex = 143
        txtContactNumber.Text = "0741223456"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(60, 420)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 25)
        Label4.TabIndex = 142
        Label4.Text = "Temp Password"
        ' 
        ' txtTempPassword
        ' 
        txtTempPassword.Location = New Point(60, 448)
        txtTempPassword.Name = "txtTempPassword"
        txtTempPassword.Size = New Size(150, 27)
        txtTempPassword.TabIndex = 141
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(60, 331)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 140
        Label2.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(60, 359)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(240, 27)
        txtEmail.TabIndex = 139
        txtEmail.Text = "chamodabeyrathna@gmail.com"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(60, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 138
        Label3.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(60, 279)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(240, 27)
        txtUsername.TabIndex = 137
        txtUsername.Text = "chamod"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(60, 190)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 27)
        txtName.TabIndex = 136
        txtName.Text = "Ravindu Chamod Abeyrathne"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(33, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(170, 41)
        Label7.TabIndex = 131
        Label7.Text = "Edit Student"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 62)
        PictureBox1.TabIndex = 135
        PictureBox1.TabStop = False
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.Transparent
        IconPictureBox5.Cursor = Cursors.Hand
        IconPictureBox5.ForeColor = Color.DimGray
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile
        IconPictureBox5.IconColor = Color.DimGray
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 40
        IconPictureBox5.Location = New Point(948, 22)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 134
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ActiveCaptionText
        Label27.Location = New Point(831, 23)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 133
        Label27.Text = "GO BACK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 132
        Label1.Text = "Name"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(33, 93)
        Label13.Name = "Label13"
        Label13.Size = New Size(151, 31)
        Label13.TabIndex = 162
        Label13.Text = "Select Student"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Ravindu Chamod Abeyrathne", "Olivia Grace Thompson", "Liam Alexander Rodriguez", "Sophia Rose Johnson", "Noah James Anderson", "Ava Elizabeth Smith", "Jackson Thomas Davis", "Emma Grace Miller", "Aiden Michael Williams", "Isabella Marie Brown", "Lucas William Taylor", "Mia Olivia Martinez", "Ethan Daniel Jackson", "Amelia Claire Davis", "Mason Christopher Wilson", "Harper Grace Smith", "Benjamin Ryan Taylor", "Abigail Rose Harris", "Elijah Joseph Turner", "Grace Emily Walker", "Alexander John Mitchell", "Scarlett Grace Anderson", "James Patrick Robinson", "Lily Katherine White", "William Henry Turner", "Zoe Isabella Martinez"})
        ComboBox1.Location = New Point(200, 96)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(316, 28)
        ComboBox1.TabIndex = 161
        ComboBox1.Text = "Ravindu Chamod Abeyrathne"
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.Red
        BunifuFlatButton1.BackColor = Color.IndianRed
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "    Delete Student"
        BunifuFlatButton1.DisabledColor = Color.Gray
        BunifuFlatButton1.Iconcolor = Color.Transparent
        BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), Image)
        BunifuFlatButton1.Iconimage_right = Nothing
        BunifuFlatButton1.Iconimage_right_Selected = Nothing
        BunifuFlatButton1.Iconimage_Selected = Nothing
        BunifuFlatButton1.IconMarginLeft = 10
        BunifuFlatButton1.IconMarginRight = 0
        BunifuFlatButton1.IconRightVisible = True
        BunifuFlatButton1.IconRightZoom = 0R
        BunifuFlatButton1.IconVisible = True
        BunifuFlatButton1.IconZoom = 50R
        BunifuFlatButton1.IsTab = False
        BunifuFlatButton1.Location = New Point(387, 654)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.IndianRed
        BunifuFlatButton1.OnHovercolor = Color.Red
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(262, 60)
        BunifuFlatButton1.TabIndex = 163
        BunifuFlatButton1.Text = "    Delete Student"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' adminEditStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1009, 758)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(Label13)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(cboStatus)
        Controls.Add(cboLevel)
        Controls.Add(cboType)
        Controls.Add(btnSubmit)
        Controls.Add(lstCurrentlyActive)
        Controls.Add(Label12)
        Controls.Add(lstVehicleType)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(txtAddress)
        Controls.Add(Label6)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(txtContactNumber)
        Controls.Add(Label4)
        Controls.Add(txtTempPassword)
        Controls.Add(Label2)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(txtUsername)
        Controls.Add(txtName)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "adminEditStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Student"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lstCurrentlyActive As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstVehicleType As CheckedListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTempPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
