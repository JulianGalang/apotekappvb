Imports System.Drawing.Drawing2D
Imports System.Runtime.Remoting.Channels

Public Class Form1
    Private tombolini As Button
    Private panelkiri As Panel
    Private form2 As Form
    Dim jatuh As Boolean = True
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        panelkiri = New Panel()
        panelkiri.Size = New Size(7, 43)

    End Sub
    Private Sub AktifitasButton(senderBtn As Object, Warnakustom As Color)
        If senderBtn IsNot Nothing Then
            matikanbutton()
            'tombol
            tombolini = CType(senderBtn, Button)
            tombolini.ForeColor = Warnakustom
        End If
    End Sub
    Private Sub bukaformlain(formLain As Form)
        If form2 IsNot Nothing Then
            form2.Close()
        End If
        form2 = formLain
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(formLain)
        panelDesktop.Tag = formLain
        formLain.BringToFront()
        formLain.Show()
        LabelTitle.Text = formLain.Text
    End Sub
    Private Sub matikanbutton()
        If tombolini IsNot Nothing Then
            tombolini.BackColor = Color.FromArgb(161, 204, 165)
            tombolini.ForeColor = Color.Black
        End If
    End Sub

    Private Sub bAct1_Click(sender As Object, e As EventArgs) Handles bAct1.Click
        AktifitasButton(sender, CusColor.color1)
    End Sub

    Private Sub bAct2_Click(sender As Object, e As EventArgs) Handles bAct2.Click
        AktifitasButton(sender, CusColor.color2)
    End Sub

    Private Sub bAct3_Click(sender As Object, e As EventArgs) Handles bAct3.Click
        AktifitasButton(sender, CusColor.color3)
    End Sub

    Private Sub bAct4_Click(sender As Object, e As EventArgs) Handles bAct4.Click
        AktifitasButton(sender, CusColor.color4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bAct5.Click
        AktifitasButton(sender, CusColor.color5)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        droppanel.Visible = False
        bAct1.Visible = False
        bAct2.Visible = False
        bAct3.Visible = False
        bAct4.Visible = False
        bAct5.Visible = False

    End Sub

    Private Sub bProfil_Click(sender As Object, e As EventArgs) Handles bProfil.Click
        If droppanel.Visible = False Then
            droppanel.Visible = True
        Else
            droppanel.Visible = False
        End If
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        login.Show()
    End Sub
End Class
