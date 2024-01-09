<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contact_success
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contact_success))
        Label22 = New Label()
        PictureBox1 = New PictureBox()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BackColor = Color.Transparent
        Label22.Font = New Font("Segoe UI Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ButtonHighlight
        Label22.Location = New Point(117, 47)
        Label22.Name = "Label22"
        Label22.Size = New Size(573, 60)
        Label22.TabIndex = 64
        Label22.Text = "Ticket Submitted Successfully!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(183, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(448, 269)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 65
        PictureBox1.TabStop = False
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "Continue"
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
        BunifuFlatButton1.Location = New Point(317, 417)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(190, 70)
        BunifuFlatButton1.TabIndex = 66
        BunifuFlatButton1.Text = "Continue"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' contact_success
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(11), CByte(11), CByte(11))
        ClientSize = New Size(833, 544)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(PictureBox1)
        Controls.Add(Label22)
        FormBorderStyle = FormBorderStyle.None
        Name = "contact_success"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Success"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
