<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminEditStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminEditStaff))
        cboLevel = New ComboBox()
        Label10 = New Label()
        Label6 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        txtContactNumber = New TextBox()
        Label2 = New Label()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        Label1 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Instructor", "Admin", "Course Cordinator"})
        cboLevel.Location = New Point(85, 406)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(237, 28)
        cboLevel.TabIndex = 172
        cboLevel.Text = "Instructor"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(85, 379)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 171
        Label10.Text = "Level"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(85, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 25)
        Label6.TabIndex = 170
        Label6.Text = "Contact Number"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Active = False
        btnSubmit.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.BorderRadius = 0
        btnSubmit.ButtonText = "         Save"
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
        btnSubmit.Location = New Point(395, 379)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        btnSubmit.OnHoverTextColor = Color.White
        btnSubmit.selected = False
        btnSubmit.Size = New Size(215, 60)
        btnSubmit.TabIndex = 173
        btnSubmit.Text = "         Save"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.Textcolor = Color.White
        btnSubmit.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(85, 327)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(240, 27)
        txtContactNumber.TabIndex = 169
        txtContactNumber.Text = "0743456789"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 168
        Label2.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(85, 243)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(240, 27)
        txtEmail.TabIndex = 167
        txtEmail.Text = "james.smith@passit.com"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(85, 165)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 27)
        txtName.TabIndex = 166
        txtName.Text = "Mr. James Smith"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(25, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 41)
        Label7.TabIndex = 161
        Label7.Text = "Edit"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 62)
        PictureBox1.TabIndex = 165
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
        IconPictureBox5.Location = New Point(628, 29)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 164
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ActiveCaptionText
        Label27.Location = New Point(511, 30)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 163
        Label27.Text = "GO BACK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(85, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 162
        Label1.Text = "Name"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(395, 137)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(215, 187)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 174
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(395, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(215, 29)
        Button1.TabIndex = 175
        Button1.Text = "Change"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' adminEditStaff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(692, 520)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(cboLevel)
        Controls.Add(Label10)
        Controls.Add(Label6)
        Controls.Add(btnSubmit)
        Controls.Add(txtContactNumber)
        Controls.Add(Label2)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "adminEditStaff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Staff"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
