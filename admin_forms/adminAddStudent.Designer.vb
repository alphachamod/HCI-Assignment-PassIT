<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminAddStudent))
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        txtName = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtEmail = New TextBox()
        Label4 = New Label()
        txtTempPassword = New TextBox()
        Label5 = New Label()
        txtAddress = New TextBox()
        Label6 = New Label()
        txtContactNumber = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        lstVehicleType = New CheckedListBox()
        lstCurrentlyActive = New CheckedListBox()
        Label12 = New Label()
        btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        cboType = New ComboBox()
        cboLevel = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
        cboStatus = New ComboBox()
        Button1 = New Button()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        IconPictureBox5.Location = New Point(950, 30)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 99
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ActiveCaptionText
        Label27.Location = New Point(833, 31)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 98
        Label27.Text = "GO BACK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 97
        Label1.Text = "Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 31)
        Label7.Name = "Label7"
        Label7.Size = New Size(240, 41)
        Label7.TabIndex = 96
        Label7.Text = "Add New Student"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 62)
        PictureBox1.TabIndex = 100
        PictureBox1.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(62, 175)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 27)
        txtName.TabIndex = 101
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(62, 264)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(240, 27)
        txtUsername.TabIndex = 103
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(62, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 104
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 316)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 106
        Label2.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(62, 344)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(240, 27)
        txtEmail.TabIndex = 105
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 405)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 25)
        Label4.TabIndex = 108
        Label4.Text = "Temp Password"
        ' 
        ' txtTempPassword
        ' 
        txtTempPassword.Location = New Point(62, 433)
        txtTempPassword.Name = "txtTempPassword"
        txtTempPassword.Size = New Size(150, 27)
        txtTempPassword.TabIndex = 107
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(62, 578)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 112
        Label5.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(62, 606)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(240, 27)
        txtAddress.TabIndex = 111
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(62, 492)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 25)
        Label6.TabIndex = 110
        Label6.Text = "Contact Number"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(62, 520)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(240, 27)
        txtContactNumber.TabIndex = 109
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(62, 639)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(240, 27)
        TextBox7.TabIndex = 113
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(62, 672)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(240, 27)
        TextBox8.TabIndex = 114
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(386, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 25)
        Label8.TabIndex = 116
        Label8.Text = "Subscription Type"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(702, 147)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 25)
        Label9.TabIndex = 118
        Label9.Text = "Status"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(386, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 120
        Label10.Text = "Level"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(386, 316)
        Label11.Name = "Label11"
        Label11.Size = New Size(116, 25)
        Label11.TabIndex = 122
        Label11.Text = "Vehicle Types"
        ' 
        ' lstVehicleType
        ' 
        lstVehicleType.FormattingEnabled = True
        lstVehicleType.Items.AddRange(New Object() {"B", "A1", "A2", "A", "AM", "C1", "C1E", "D1", "D1E", "D", "DE"})
        lstVehicleType.Location = New Point(389, 344)
        lstVehicleType.Name = "lstVehicleType"
        lstVehicleType.Size = New Size(237, 246)
        lstVehicleType.TabIndex = 123
        ' 
        ' lstCurrentlyActive
        ' 
        lstCurrentlyActive.FormattingEnabled = True
        lstCurrentlyActive.Items.AddRange(New Object() {"B", "A1", "A2", "A", "AM", "C1", "C1E", "D1", "D1E", "D", "DE"})
        lstCurrentlyActive.Location = New Point(705, 344)
        lstCurrentlyActive.Name = "lstCurrentlyActive"
        lstCurrentlyActive.Size = New Size(237, 246)
        lstCurrentlyActive.TabIndex = 125
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(702, 316)
        Label12.Name = "Label12"
        Label12.Size = New Size(136, 25)
        Label12.TabIndex = 124
        Label12.Text = "Currently Active"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Active = False
        btnSubmit.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.BorderRadius = 0
        btnSubmit.ButtonText = "    Confirm and Add Student"
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
        btnSubmit.Location = New Point(659, 639)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        btnSubmit.OnHoverTextColor = Color.White
        btnSubmit.selected = False
        btnSubmit.Size = New Size(287, 60)
        btnSubmit.TabIndex = 126
        btnSubmit.Text = "    Confirm and Add Student"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.Textcolor = Color.White
        btnSubmit.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' cboType
        ' 
        cboType.FormattingEnabled = True
        cboType.Items.AddRange(New Object() {"Pay as You Go", "Monthly", "Yearly"})
        cboType.Location = New Point(389, 175)
        cboType.Name = "cboType"
        cboType.Size = New Size(237, 28)
        cboType.TabIndex = 127
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Introductory", "Standard", "PassPlus"})
        cboLevel.Location = New Point(386, 263)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(237, 28)
        cboLevel.TabIndex = 128
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(702, 174)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(244, 28)
        cboStatus.TabIndex = 129
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(218, 431)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 29)
        Button1.TabIndex = 130
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' adminAddStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1009, 758)
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
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(Label5)
        Controls.Add(txtAddress)
        Controls.Add(Label6)
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
        Name = "adminAddStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Student"
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTempPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lstVehicleType As CheckedListBox
    Friend WithEvents lstCurrentlyActive As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Button1 As Button
End Class
