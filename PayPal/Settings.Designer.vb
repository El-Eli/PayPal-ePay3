<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.valbtn = New System.Windows.Forms.Button()
        Me.bacbtn = New System.Windows.Forms.Button()
        Me.ppadtxt = New System.Windows.Forms.TextBox()
        Me.bunatxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'valbtn
        '
        Me.valbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.valbtn.BackColor = System.Drawing.Color.Transparent
        Me.valbtn.BackgroundImage = CType(resources.GetObject("valbtn.BackgroundImage"), System.Drawing.Image)
        Me.valbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.valbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.valbtn.FlatAppearance.BorderSize = 0
        Me.valbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.valbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.valbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.valbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.valbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valbtn.ForeColor = System.Drawing.Color.White
        Me.valbtn.Location = New System.Drawing.Point(625, 40)
        Me.valbtn.Name = "valbtn"
        Me.valbtn.Size = New System.Drawing.Size(150, 50)
        Me.valbtn.TabIndex = 2
        Me.valbtn.Text = "validate"
        Me.valbtn.UseVisualStyleBackColor = False
        '
        'bacbtn
        '
        Me.bacbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bacbtn.BackColor = System.Drawing.Color.Transparent
        Me.bacbtn.BackgroundImage = CType(resources.GetObject("bacbtn.BackgroundImage"), System.Drawing.Image)
        Me.bacbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bacbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bacbtn.FlatAppearance.BorderSize = 0
        Me.bacbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.bacbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bacbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bacbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bacbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bacbtn.ForeColor = System.Drawing.Color.White
        Me.bacbtn.Location = New System.Drawing.Point(625, 490)
        Me.bacbtn.Name = "bacbtn"
        Me.bacbtn.Size = New System.Drawing.Size(150, 50)
        Me.bacbtn.TabIndex = 3
        Me.bacbtn.Text = "back"
        Me.bacbtn.UseVisualStyleBackColor = False
        '
        'ppadtxt
        '
        Me.ppadtxt.BackColor = System.Drawing.Color.White
        Me.ppadtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ppadtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppadtxt.ForeColor = System.Drawing.Color.Black
        Me.ppadtxt.Location = New System.Drawing.Point(205, 249)
        Me.ppadtxt.MaxLength = 100
        Me.ppadtxt.Name = "ppadtxt"
        Me.ppadtxt.Size = New System.Drawing.Size(200, 24)
        Me.ppadtxt.TabIndex = 0
        Me.ppadtxt.Text = "paypal address"
        Me.ppadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bunatxt
        '
        Me.bunatxt.BackColor = System.Drawing.Color.White
        Me.bunatxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bunatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunatxt.ForeColor = System.Drawing.Color.Black
        Me.bunatxt.Location = New System.Drawing.Point(205, 279)
        Me.bunatxt.MaxLength = 100
        Me.bunatxt.Name = "bunatxt"
        Me.bunatxt.Size = New System.Drawing.Size(200, 24)
        Me.bunatxt.TabIndex = 1
        Me.bunatxt.Text = "business name"
        Me.bunatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 581)
        Me.Controls.Add(Me.bunatxt)
        Me.Controls.Add(Me.bacbtn)
        Me.Controls.Add(Me.valbtn)
        Me.Controls.Add(Me.ppadtxt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ePay"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents valbtn As System.Windows.Forms.Button
    Friend WithEvents bacbtn As System.Windows.Forms.Button
    Friend WithEvents ppadtxt As System.Windows.Forms.TextBox
    Friend WithEvents bunatxt As TextBox
End Class
