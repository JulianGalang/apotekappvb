Imports System.Data.Odbc
Public Class login

    Private Sub bPassword_Click(sender As Object, e As EventArgs) Handles bPassword.Click
        kelola_user.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        koneksi()
        cmd = New OdbcCommand("select * from user where username='" & tbUsername.Texts & "'and password='" & tbPassword.Texts & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        MsgBox("Berhasil Login")
        Form1.TypeLabel.Text = dr!tipe_user
        Form1.bProfil.Text = dr!nama_user
        Form1.Show()
    End Sub
End Class