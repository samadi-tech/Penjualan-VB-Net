Imports System.Data.OleDb


Public Class SamTech

    'Deklarasi Awal
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String

    'Function Koneksi
    Sub Koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\NOT DELETE\ADI NUGROHO 2020804171\Penjualan\dbpenjualan.mdb"
        conn = New OleDbConnection(str)

        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'Function TampilData
    Sub TampilData()
        TextBox2.Text = rd.Item(1)
        ComboBox1.Text = rd.Item(2)
        TextBox3.Text = rd.Item(3)
        TextBox4.Text = rd.Item(4)
    End Sub

    'Function TextMati
    Sub TextMati()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
    End Sub

    'Function TextHidup
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
    End Sub

    'Function TextKosong
    Sub TextKosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    'Function TampilGrid
    Sub TampilGrid()
        da = New OleDbDataAdapter("select * from tbbarang", conn)
        ds = New DataSet
        da.Fill(ds, "tbbarang")
        DGV.DataSource = ds.Tables("tbbarang")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call TextMati()
        Me.btn_tambah.Enabled = True
        Me.btn_simpan.Enabled = False
        Me.btn_edit.Enabled = False
        Me.btn_update.Enabled = False
        Me.btn_batal.Enabled = False
        Me.btn_hapus.Enabled = False
        Me.btn_keluar.Enabled = True

    End Sub

   

    

    Private Sub OleDbConnection_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.OleDb.OleDbInfoMessageEventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        Call TextHidup()
        Call TextKosong()
        Me.TextBox1.Focus()
        Me.btn_tambah.Enabled = False
        Me.btn_simpan.Enabled = True
        Me.btn_edit.Enabled = False
        Me.btn_update.Enabled = False
        Me.btn_batal.Enabled = True
        Me.btn_hapus.Enabled = False
        Me.btn_keluar.Enabled = True

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Cek kembali data yang ingin diinputkan.!")
            Exit Sub
        Else


            Dim simpan As String
            simpan = "insert into tbbarang (kdbarang, nmbarang,satuan, jumlah, harga)" & " values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"

            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call TextMati()
            Call TextKosong()
            Call TextMati()
            Call TampilGrid()
            DGV.Refresh()
            Me.btn_tambah.Enabled = True
            Me.btn_simpan.Enabled = False
            Me.btn_edit.Enabled = False
            Me.btn_update.Enabled = False
            Me.btn_batal.Enabled = False
            Me.btn_hapus.Enabled = False
            Me.btn_keluar.Enabled = True
        End If

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") Then
            Sql = "update tbbarang set nmbarang='" & TextBox2.Text & "',satuan='" & ComboBox1.Text & "',jumlah='" & TextBox3.Text & "',harga='" & TextBox4.Text & "' where kdbarang='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(Sql, conn)
            cmd.ExecuteNonQuery()
            DGV.Refresh()
            Me.OleDbConnection1.Close()
            Call TextMati()
            Call TextKosong()
            Me.btn_tambah.Enabled = True
            Me.btn_simpan.Enabled = False
            Me.btn_edit.Enabled = False
            Me.btn_update.Enabled = False
            Me.btn_batal.Enabled = False
            Me.btn_hapus.Enabled = False
            Me.btn_keluar.Enabled = True
            DGV.Refresh()
            Call TampilGrid()
        End If
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Call TextKosong()
        Call TextMati()
        Me.btn_tambah.Enabled = True
        Me.btn_simpan.Enabled = False
        Me.btn_edit.Enabled = False
        Me.btn_update.Enabled = False
        Me.btn_batal.Enabled = False
        Me.btn_hapus.Enabled = False
        Me.btn_keluar.Enabled = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Call TextHidup()
        TextBox1.Enabled = False
        Me.btn_tambah.Enabled = False
        Me.btn_simpan.Enabled = False
        Me.btn_edit.Enabled = False
        Me.btn_update.Enabled = True
        Me.btn_batal.Enabled = True
        Me.btn_hapus.Enabled = True
        Me.btn_keluar.Enabled = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then TextBox2.Focus()

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        str = "SELECT * FROM tbbarang WHERE kdbarang = '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox2.Text = rd.GetString(1)
                ComboBox1.Text = rd.GetString(2)
                TextBox3.Text = rd.GetValue(3)
                TextBox4.Text = rd.GetValue(4)
                TextMati()
                Me.btn_tambah.Enabled = False
                Me.btn_simpan.Enabled = False
                Me.btn_edit.Enabled = True
                Me.btn_update.Enabled = True
                Me.btn_batal.Enabled = True
                Me.btn_hapus.Enabled = True
                Me.btn_keluar.Enabled = True
            End While

        Finally
            rd.Close()

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode belum diisi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = " Delete * from tbbarang where kdbarang = '" & TextBox1.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call TampilGrid()
                Call TextKosong()
                Me.btn_tambah.Enabled = True
                Me.btn_simpan.Enabled = False
                Me.btn_edit.Enabled = False
                Me.btn_update.Enabled = False
                Me.btn_batal.Enabled = False
                Me.btn_hapus.Enabled = False
                Me.btn_keluar.Enabled = True
            Else
                Call TextMati()
            End If
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class
