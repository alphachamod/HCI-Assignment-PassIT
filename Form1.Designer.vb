<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        btnLogin = New FontAwesome.Sharp.IconButton()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(941, 903)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(941, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(541, 245)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(IconPictureBox3)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(IconPictureBox2)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(941, 245)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(541, 658)
        Panel2.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(131, 598)
        Label6.Name = "Label6"
        Label6.Size = New Size(242, 20)
        Label6.TabIndex = 11
        Label6.Text = "We're more than happy to help you"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(130, 580)
        Label5.Name = "Label5"
        Label5.Size = New Size(343, 20)
        Label5.TabIndex = 10
        Label5.Text = "Having trouble logging in? Contact Us for support."
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.White
        IconPictureBox3.ForeColor = SystemColors.ControlText
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Envelope
        IconPictureBox3.IconColor = SystemColors.ControlText
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 47
        IconPictureBox3.Location = New Point(72, 580)
        IconPictureBox3.Name = "IconPictureBox3"
        IconPictureBox3.Size = New Size(50, 47)
        IconPictureBox3.TabIndex = 9
        IconPictureBox3.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.BackColor = Color.Gold
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        btnLogin.IconColor = SystemColors.ActiveCaptionText
        btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogin.Location = New Point(95, 373)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(351, 61)
        btnLogin.TabIndex = 6
        btnLogin.Text = "LOGIN"
        btnLogin.TextImageRelation = TextImageRelation.TextBeforeImage
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.White
        IconPictureBox2.ForeColor = SystemColors.ControlText
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock
        IconPictureBox2.IconColor = SystemColors.ControlText
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 30
        IconPictureBox2.Location = New Point(56, 260)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(30, 34)
        IconPictureBox2.TabIndex = 5
        IconPictureBox2.TabStop = False
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.White
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 30
        IconPictureBox1.Location = New Point(56, 175)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(31, 30)
        IconPictureBox1.TabIndex = 4
        IconPictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(95, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 3
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 0
        Label2.Text = "USERNAME"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(541, 125)
        Panel3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 46)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(95, 283)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(351, 27)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(95, 198)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(351, 27)
        txtUsername.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1482, 903)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - PassIT"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
