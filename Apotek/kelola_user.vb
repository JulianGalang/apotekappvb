Imports System.Data.Odbc
Public Class kelola_user
    Private Sub kelola_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nonaktif()
        tampil()
    End Sub
    Sub aktif()
        bSimpan.Text = "SIMPAN"
        bEdit.Enabled = False
        bHapus.Enabled = False

        cbType.Enabled = True
        tbNama.Enabled = True
        tbTelepon.Enabled = True
        tbAlamat.Enabled = True
        tbUsername.Enabled = True
        tbPassword.Enabled = True
        tbCari.Enabled = False
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("select id_user, tipe_user, nama_user, alamat, telepon, username from user", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "user")
        dgvuser.DataSource = (ds.Tables("user"))
        dgvuser.Columns(0).HeaderText = "ID USER"
        dgvuser.Columns(1).HeaderText = "TYPE USER"
        dgvuser.Columns(2).HeaderText = "NAMA USER"
        dgvuser.Columns(3).HeaderText = "ALAMAT"
        dgvuser.Columns(4).HeaderText = "TELEPON"
        dgvuser.Columns(5).HeaderText = "USERNAME"
    End Sub
    Sub nonaktif()
        bSimpan.Text = "TAMBAH"
        bEdit.Enabled = False
        bHapus.Enabled = False

        cbType.Enabled = False
        tbNama.Enabled = False
        tbTelepon.Enabled = False
        tbAlamat.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbCari.Enabled = True
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        If bSimpan.Text = "TAMBAH" Then
            aktif()
        Else
            If cbType.Text IsNot "" And tbNama.Text IsNot "" And tbTelepon.Text IsNot "" And tbAlamat.Text IsNot "" And tbUsername.Text IsNot "" And tbPassword.Text IsNot "" Then
                koneksi()
                Dim simpandata As String
                simpandata = "insert into user values('', '" & cbType.Text & "','" & tbNama.Text & "','" & tbAlamat.Text & "','" & tbTelepon.Text & "','" & tbUsername.Text & "','" & tbPassword.Text & "')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("SUKSES")
                tampil()
                nonaktif()
            Else
                MessageBox.Show("Mohon isi semua formulir dengan benar!", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                nonaktif()
            End If

        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click

    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click

    End Sub
    Private Sub dgvuser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellClick

    End Sub
End Class