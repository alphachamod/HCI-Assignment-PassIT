﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class date_time
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(date_time))
        DateTimePicker1 = New DateTimePicker()
        Label22 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(306, 71)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ButtonHighlight
        Label22.Location = New Point(58, 69)
        Label22.Name = "Label22"
        Label22.Size = New Size(166, 28)
        Label22.TabIndex = 12
        Label22.Text = "Select your date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(58, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 28)
        Label1.TabIndex = 13
        Label1.Text = "Select preferred time"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"08.30 AM", "09.30 AM", "10.30 AM", "11.30 AM", "12.30 PM", "12.45 PM", "01.30 PM", "02.30 PM", "03.30 PM", "04.30 PM", "05.30 PM"})
        ComboBox1.Location = New Point(306, 127)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "BOOK"
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
        BunifuFlatButton1.Location = New Point(572, 165)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(145, 69)
        BunifuFlatButton1.TabIndex = 15
        BunifuFlatButton1.Text = "BOOK"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' date_time
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        ClientSize = New Size(744, 257)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(Label22)
        Controls.Add(DateTimePicker1)
        Name = "date_time"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pick Date and Time"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class