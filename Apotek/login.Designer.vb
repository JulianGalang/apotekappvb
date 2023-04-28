<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbUsername = New Sipaa.Framework.STextBox()
        Me.tbPassword = New Sipaa.Framework.STextBox()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.bPassword = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(96, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apotek berkah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gotham", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selamat datang di "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gotham", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PASSWORD"
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.SystemColors.Window
        Me.tbUsername.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.tbUsername.BorderFocusColor = System.Drawing.Color.HotPink
        Me.tbUsername.BorderRadius = 0
        Me.tbUsername.BorderSize = 2
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbUsername.Location = New System.Drawing.Point(15, 104)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.tbUsername.Multiline = False
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.tbUsername.PasswordChar = False
        Me.tbUsername.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tbUsername.PlaceholderText = ""
        Me.tbUsername.Size = New System.Drawing.Size(288, 31)
        Me.tbUsername.TabIndex = 5
        Me.tbUsername.Texts = ""
        Me.tbUsername.UnderlinedStyle = False
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.SystemColors.Window
        Me.tbPassword.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.tbPassword.BorderFocusColor = System.Drawing.Color.HotPink
        Me.tbPassword.BorderRadius = 0
        Me.tbPassword.BorderSize = 2
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbPassword.Location = New System.Drawing.Point(15, 160)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPassword.Multiline = False
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.tbPassword.PasswordChar = False
        Me.tbPassword.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.Size = New System.Drawing.Size(288, 31)
        Me.tbPassword.TabIndex = 6
        Me.tbPassword.Texts = ""
        Me.tbPassword.UnderlinedStyle = False
        '
        'bLogin
        '
        Me.bLogin.FlatAppearance.BorderSize = 0
        Me.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogin.Font = New System.Drawing.Font("Gotham", 14.25!, System.Drawing.FontStyle.Bold)
        Me.bLogin.Location = New System.Drawing.Point(15, 198)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(288, 44)
        Me.bLogin.TabIndex = 7
        Me.bLogin.Text = "LOGIN"
        Me.bLogin.UseVisualStyleBackColor = True
        '
        'bPassword
        '
        Me.bPassword.FlatAppearance.BorderSize = 0
        Me.bPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPassword.Font = New System.Drawing.Font("Gotham", 14.25!, System.Drawing.FontStyle.Bold)
        Me.bPassword.Location = New System.Drawing.Point(16, 248)
        Me.bPassword.Name = "bPassword"
        Me.bPassword.Size = New System.Drawing.Size(288, 44)
        Me.bPassword.TabIndex = 8
        Me.bPassword.Text = "DAFTAR"
        Me.bPassword.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(316, 300)
        Me.Controls.Add(Me.bPassword)
        Me.Controls.Add(Me.bLogin)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbUsername As Sipaa.Framework.STextBox
    Friend WithEvents tbPassword As Sipaa.Framework.STextBox
    Friend WithEvents bLogin As Button
    Friend WithEvents bPassword As Button
End Class
