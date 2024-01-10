<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminAddLesson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminAddLesson))
        cboLevel = New ComboBox()
        btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        Label10 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        lName = New Label()
        txtPrice = New TextBox()
        desc = New RichTextBox()
        cboType = New ComboBox()
        Label4 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Introductory", "Standard", "PassPlus"})
        cboLevel.Location = New Point(68, 153)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(237, 28)
        cboLevel.TabIndex = 158
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Active = False
        btnSubmit.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.BorderRadius = 0
        btnSubmit.ButtonText = "    Add Lesson"
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
        btnSubmit.Location = New Point(390, 451)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        btnSubmit.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        btnSubmit.OnHoverTextColor = Color.White
        btnSubmit.selected = False
        btnSubmit.Size = New Size(348, 60)
        btnSubmit.TabIndex = 156
        btnSubmit.Text = "    Add Lesson"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.Textcolor = Color.White
        btnSubmit.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(68, 126)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 151
        Label10.Text = "Level"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 369)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 140
        Label2.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(390, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 25)
        Label3.TabIndex = 138
        Label3.Text = "Description"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(68, 318)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 27)
        txtName.TabIndex = 136
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(22, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 41)
        Label7.TabIndex = 131
        Label7.Text = "Add New Lesson"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(21, 30)
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
        IconPictureBox5.Location = New Point(677, 33)
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
        Label27.Location = New Point(560, 34)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 133
        Label27.Text = "GO BACK"
        ' 
        ' lName
        ' 
        lName.AutoSize = True
        lName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lName.Location = New Point(68, 290)
        lName.Name = "lName"
        lName.Size = New Size(118, 25)
        lName.TabIndex = 132
        lName.Text = "Lesson Name"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(68, 397)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(240, 27)
        txtPrice.TabIndex = 139
        ' 
        ' desc
        ' 
        desc.Location = New Point(390, 154)
        desc.Name = "desc"
        desc.Size = New Size(348, 270)
        desc.TabIndex = 159
        desc.Text = ""
        ' 
        ' cboType
        ' 
        cboType.FormattingEnabled = True
        cboType.Items.AddRange(New Object() {"Theory", "Practical", "Throry + Practical"})
        cboType.Location = New Point(68, 229)
        cboType.Name = "cboType"
        cboType.Size = New Size(237, 28)
        cboType.TabIndex = 161
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(68, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 25)
        Label4.TabIndex = 160
        Label4.Text = "Type"
        ' 
        ' adminAddLesson
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(793, 596)
        Controls.Add(cboType)
        Controls.Add(Label4)
        Controls.Add(desc)
        Controls.Add(cboLevel)
        Controls.Add(btnSubmit)
        Controls.Add(Label10)
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
        Name = "adminAddLesson"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Lesson"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lName As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents desc As RichTextBox
    Friend WithEvents txtPrice As TextBox
End Class
