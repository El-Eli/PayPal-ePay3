<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayPal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayPal))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.bacbtn = New System.Windows.Forms.Button()
        Me.numtxt = New System.Windows.Forms.TextBox()
        Me.totlbl = New System.Windows.Forms.Label()
        Me.curlbl = New System.Windows.Forms.Label()
        Me.idlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(145, 90)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(320, 320)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.TabStop = False
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
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
        Me.bacbtn.TabIndex = 0
        Me.bacbtn.Text = "back"
        Me.bacbtn.UseVisualStyleBackColor = False
        '
        'numtxt
        '
        Me.numtxt.BackColor = System.Drawing.Color.White
        Me.numtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numtxt.ForeColor = System.Drawing.Color.Black
        Me.numtxt.Location = New System.Drawing.Point(187, 446)
        Me.numtxt.MaxLength = 9
        Me.numtxt.Name = "numtxt"
        Me.numtxt.ReadOnly = True
        Me.numtxt.Size = New System.Drawing.Size(270, 73)
        Me.numtxt.TabIndex = 5
        Me.numtxt.Text = "0"
        '
        'totlbl
        '
        Me.totlbl.AutoSize = True
        Me.totlbl.BackColor = System.Drawing.Color.Transparent
        Me.totlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totlbl.ForeColor = System.Drawing.Color.Black
        Me.totlbl.Location = New System.Drawing.Point(155, 413)
        Me.totlbl.Name = "totlbl"
        Me.totlbl.Size = New System.Drawing.Size(53, 25)
        Me.totlbl.TabIndex = 2
        Me.totlbl.Text = "total"
        '
        'curlbl
        '
        Me.curlbl.AutoSize = True
        Me.curlbl.BackColor = System.Drawing.Color.Transparent
        Me.curlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curlbl.ForeColor = System.Drawing.Color.Black
        Me.curlbl.Location = New System.Drawing.Point(155, 485)
        Me.curlbl.Name = "curlbl"
        Me.curlbl.Size = New System.Drawing.Size(24, 25)
        Me.curlbl.TabIndex = 4
        Me.curlbl.Text = "$"
        '
        'idlbl
        '
        Me.idlbl.AutoSize = True
        Me.idlbl.BackColor = System.Drawing.Color.Transparent
        Me.idlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idlbl.ForeColor = System.Drawing.Color.Black
        Me.idlbl.Location = New System.Drawing.Point(214, 413)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(29, 25)
        Me.idlbl.TabIndex = 3
        Me.idlbl.Text = "id"
        '
        'PayPal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 581)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.numtxt)
        Me.Controls.Add(Me.totlbl)
        Me.Controls.Add(Me.curlbl)
        Me.Controls.Add(Me.bacbtn)
        Me.Controls.Add(Me.WebBrowser1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PayPal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ePay"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents bacbtn As Button
    Friend WithEvents numtxt As TextBox
    Friend WithEvents totlbl As Label
    Friend WithEvents curlbl As Label
    Friend WithEvents idlbl As Label
End Class
