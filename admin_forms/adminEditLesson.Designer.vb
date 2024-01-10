<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminEditLesson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminEditLesson))
        cboLevel = New ComboBox()
        btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        Label10 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        cboType = New ComboBox()
        Label4 = New Label()
        desc = New RichTextBox()
        Label2 = New Label()
        txtPrice = New TextBox()
        Label3 = New Label()
        txtName = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        lName = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Introductory", "Standard", "PassPlus"})
        cboLevel.Location = New Point(70, 202)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(237, 28)
        cboLevel.TabIndex = 173
        cboLevel.Text = "Introductory"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Active = False
        btnSubmit.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.BorderRadius = 0
        btnSubmit.ButtonText = "                   Update"
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
        btnSubmit.Location = New Point(392, 500)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        btnSubmit.OnHoverTextColor = Color.White
        btnSubmit.selected = False
        btnSubmit.Size = New Size(348, 60)
        btnSubmit.TabIndex = 172
        btnSubmit.Text = "                   Update"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.Textcolor = Color.White
        btnSubmit.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(70, 175)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 171
        Label10.Text = "Level"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' cboType
        ' 
        cboType.FormattingEnabled = True
        cboType.Items.AddRange(New Object() {"Theory", "Practical", "Throry + Practical"})
        cboType.Location = New Point(70, 278)
        cboType.Name = "cboType"
        cboType.Size = New Size(237, 28)
        cboType.TabIndex = 176
        cboType.Text = "Theory"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(70, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 25)
        Label4.TabIndex = 175
        Label4.Text = "Type"
        ' 
        ' desc
        ' 
        desc.Location = New Point(392, 203)
        desc.Name = "desc"
        desc.Size = New Size(348, 270)
        desc.TabIndex = 174
        desc.Text = "1. Understand the basic vehicle controls." & vbLf & "2. Familiarize with the cockpit layout." & vbLf & "2. Learn the purpose of primary controls."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(70, 418)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 170
        Label2.Text = "Price"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(70, 446)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(240, 27)
        txtPrice.TabIndex = 169
        txtPrice.Text = "£29.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(392, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 25)
        Label3.TabIndex = 168
        Label3.Text = "Description"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(70, 367)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 27)
        txtName.TabIndex = 167
        txtName.Text = "Introduction to Driving"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 41)
        Label7.TabIndex = 162
        Label7.Text = "Edit Lessons"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 62)
        PictureBox1.TabIndex = 166
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
        IconPictureBox5.Location = New Point(679, 27)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 165
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ActiveCaptionText
        Label27.Location = New Point(562, 28)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 164
        Label27.Text = "GO BACK"
        ' 
        ' lName
        ' 
        lName.AutoSize = True
        lName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lName.Location = New Point(70, 339)
        lName.Name = "lName"
        lName.Size = New Size(118, 25)
        lName.TabIndex = 163
        lName.Text = "Lesson Name"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(26, 94)
        Label13.Name = "Label13"
        Label13.Size = New Size(143, 31)
        Label13.TabIndex = 178
        Label13.Text = "Select Lesson"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Introduction to Driving", "Basic Manuers"})
        ComboBox1.Location = New Point(193, 97)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(316, 28)
        ComboBox1.TabIndex = 177
        ComboBox1.Text = "Introduction to Driving"
        ' 
        ' adminEditLesson
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(793, 596)
        Controls.Add(Label13)
        Controls.Add(ComboBox1)
        Controls.Add(cboLevel)
        Controls.Add(btnSubmit)
        Controls.Add(Label10)
        Controls.Add(cboType)
        Controls.Add(Label4)
        Controls.Add(desc)
        Controls.Add(Label2)
        Controls.Add(txtPrice)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(lName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "adminEditLesson"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Lesson"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label10 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents desc As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lName As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
