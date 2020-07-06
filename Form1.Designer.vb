<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBOX = New System.Windows.Forms.PictureBox()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(9, 415)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 58)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBOX
        '
        Me.PictureBOX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBOX.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBOX.Enabled = False
        Me.PictureBOX.ErrorImage = Nothing
        Me.PictureBOX.InitialImage = Nothing
        Me.PictureBOX.Location = New System.Drawing.Point(9, 60)
        Me.PictureBOX.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBOX.MaximumSize = New System.Drawing.Size(350, 350)
        Me.PictureBOX.MinimumSize = New System.Drawing.Size(350, 350)
        Me.PictureBOX.Name = "PictureBOX"
        Me.PictureBOX.Size = New System.Drawing.Size(350, 350)
        Me.PictureBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBOX.TabIndex = 73
        Me.PictureBOX.TabStop = False
        '
        'txtbox
        '
        Me.txtbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox.ForeColor = System.Drawing.Color.Red
        Me.txtbox.Location = New System.Drawing.Point(394, 60)
        Me.txtbox.Multiline = True
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(584, 548)
        Me.txtbox.TabIndex = 74
        Me.txtbox.Text = "Test"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(9, 493)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 115)
        Me.TextBox1.TabIndex = 75
        Me.TextBox1.Text = "FILE MUST BE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16x16 Pixels" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1-Bit MonoChrome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BMP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only BLack and White Colors"
        '
        'txtbox2
        '
        Me.txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox2.Location = New System.Drawing.Point(9, 16)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(999, 35)
        Me.txtbox2.TabIndex = 76
        Me.txtbox2.Text = "C:\Users\Tower\Desktop\1.bmp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1030, 638)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.PictureBOX)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "16x16 bitmap to hex"
        CType(Me.PictureBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBOX As System.Windows.Forms.PictureBox
    Friend WithEvents txtbox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
End Class
