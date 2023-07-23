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
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.lblKudos = New System.Windows.Forms.Label()
        Me.txtKudos = New System.Windows.Forms.TextBox()
        Me.lblHIts = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHits = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.ao3Link = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl5stars0 = New System.Windows.Forms.Label()
        Me.lbl5stars = New System.Windows.Forms.Label()
        Me.lbl4stars = New System.Windows.Forms.Label()
        Me.lbl3stars = New System.Windows.Forms.Label()
        Me.lbl2stars = New System.Windows.Forms.Label()
        Me.lbl1star = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.Location = New System.Drawing.Point(123, 34)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(431, 32)
        Me.txtURL.TabIndex = 0
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Font = New System.Drawing.Font("Nirmala UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblURL.Location = New System.Drawing.Point(18, 34)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(99, 28)
        Me.lblURL.TabIndex = 1
        Me.lblURL.Text = "AO3 URL :"
        '
        'lblKudos
        '
        Me.lblKudos.AutoSize = True
        Me.lblKudos.Font = New System.Drawing.Font("Nirmala UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKudos.Location = New System.Drawing.Point(39, 96)
        Me.lblKudos.Name = "lblKudos"
        Me.lblKudos.Size = New System.Drawing.Size(78, 28)
        Me.lblKudos.TabIndex = 2
        Me.lblKudos.Text = "Kudos : "
        '
        'txtKudos
        '
        Me.txtKudos.Location = New System.Drawing.Point(123, 92)
        Me.txtKudos.Name = "txtKudos"
        Me.txtKudos.Size = New System.Drawing.Size(89, 32)
        Me.txtKudos.TabIndex = 3
        '
        'lblHIts
        '
        Me.lblHIts.AutoSize = True
        Me.lblHIts.Font = New System.Drawing.Font("Nirmala UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHIts.Location = New System.Drawing.Point(218, 96)
        Me.lblHIts.Name = "lblHIts"
        Me.lblHIts.Size = New System.Drawing.Size(53, 28)
        Me.lblHIts.TabIndex = 4
        Me.lblHIts.Text = "Hits :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kudos % :"
        '
        'txtHits
        '
        Me.txtHits.Location = New System.Drawing.Point(277, 92)
        Me.txtHits.Name = "txtHits"
        Me.txtHits.Size = New System.Drawing.Size(94, 32)
        Me.txtHits.TabIndex = 6
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(481, 92)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(88, 32)
        Me.txtRate.TabIndex = 7
        '
        'ao3Link
        '
        Me.ao3Link.AutoSize = True
        Me.ao3Link.Font = New System.Drawing.Font("Nirmala UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ao3Link.Location = New System.Drawing.Point(598, 361)
        Me.ao3Link.Name = "ao3Link"
        Me.ao3Link.Size = New System.Drawing.Size(94, 17)
        Me.ao3Link.TabIndex = 8
        Me.ao3Link.TabStop = True
        Me.ao3Link.Text = "Return to work"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtHits)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblHIts)
        Me.GroupBox1.Controls.Add(Me.txtKudos)
        Me.GroupBox1.Controls.Add(Me.lblKudos)
        Me.GroupBox1.Controls.Add(Me.lblURL)
        Me.GroupBox1.Controls.Add(Me.txtURL)
        Me.GroupBox1.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(98, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 168)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT"
        '
        'btnRate
        '
        Me.btnRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRate.Font = New System.Drawing.Font("Nirmala UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRate.Location = New System.Drawing.Point(523, 235)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(169, 35)
        Me.btnRate.TabIndex = 10
        Me.btnRate.Text = "RATE"
        Me.btnRate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI Semilight", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "*The closer your Kudos% is to 1.00, the better the ratio!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl5stars0
        '
        Me.lbl5stars0.AutoSize = True
        Me.lbl5stars0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5stars0.Location = New System.Drawing.Point(100, 275)
        Me.lbl5stars0.Name = "lbl5stars0"
        Me.lbl5stars0.Size = New System.Drawing.Size(155, 46)
        Me.lbl5stars0.TabIndex = 12
        Me.lbl5stars0.Text = "☆☆☆☆☆"
        '
        'lbl5stars
        '
        Me.lbl5stars.AutoSize = True
        Me.lbl5stars.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5stars.Location = New System.Drawing.Point(100, 275)
        Me.lbl5stars.Name = "lbl5stars"
        Me.lbl5stars.Size = New System.Drawing.Size(155, 46)
        Me.lbl5stars.TabIndex = 13
        Me.lbl5stars.Text = "★★★★★" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl4stars
        '
        Me.lbl4stars.AutoSize = True
        Me.lbl4stars.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4stars.Location = New System.Drawing.Point(100, 275)
        Me.lbl4stars.Name = "lbl4stars"
        Me.lbl4stars.Size = New System.Drawing.Size(155, 46)
        Me.lbl4stars.TabIndex = 14
        Me.lbl4stars.Text = "★★★★☆"
        '
        'lbl3stars
        '
        Me.lbl3stars.AutoSize = True
        Me.lbl3stars.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3stars.Location = New System.Drawing.Point(100, 275)
        Me.lbl3stars.Name = "lbl3stars"
        Me.lbl3stars.Size = New System.Drawing.Size(155, 46)
        Me.lbl3stars.TabIndex = 15
        Me.lbl3stars.Text = "★★★☆☆"
        '
        'lbl2stars
        '
        Me.lbl2stars.AutoSize = True
        Me.lbl2stars.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2stars.Location = New System.Drawing.Point(100, 275)
        Me.lbl2stars.Name = "lbl2stars"
        Me.lbl2stars.Size = New System.Drawing.Size(155, 46)
        Me.lbl2stars.TabIndex = 16
        Me.lbl2stars.Text = "★★☆☆☆"
        '
        'lbl1star
        '
        Me.lbl1star.AutoSize = True
        Me.lbl1star.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1star.Location = New System.Drawing.Point(100, 275)
        Me.lbl1star.Name = "lbl1star"
        Me.lbl1star.Size = New System.Drawing.Size(155, 46)
        Me.lbl1star.TabIndex = 17
        Me.lbl1star.Text = "★☆☆☆☆"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl1star)
        Me.Controls.Add(Me.lbl2stars)
        Me.Controls.Add(Me.lbl3stars)
        Me.Controls.Add(Me.lbl4stars)
        Me.Controls.Add(Me.lbl5stars)
        Me.Controls.Add(Me.lbl5stars0)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ao3Link)
        Me.Name = "Form1"
        Me.Text = "AO3 RATING SYSTEM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtURL As TextBox
    Friend WithEvents lblURL As Label
    Friend WithEvents lblKudos As Label
    Friend WithEvents txtKudos As TextBox
    Friend WithEvents lblHIts As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHits As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents ao3Link As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl5stars0 As Label
    Friend WithEvents lbl5stars As Label
    Friend WithEvents lbl4stars As Label
    Friend WithEvents lbl3stars As Label
    Friend WithEvents lbl2stars As Label
    Friend WithEvents lbl1star As Label
End Class
