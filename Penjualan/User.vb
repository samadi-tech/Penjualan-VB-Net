Imports System.Data.OleDb

Public Class User
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
       
    End Sub

    'Function TextMati
    Sub TextMati()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.ComboBox1.Enabled = False
       
    End Sub

    'Function TextHidup
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.ComboBox1.Enabled = True
        
    End Sub

    'Function TextKosong
    Sub TextKosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    'Function TampilGrid
    Sub TampilGrid()
        da = New OleDbDataAdapter("select * from tbuser", conn)
        ds = New DataSet
        da.Fill(ds, "tbuser")
        DGV.DataSource = ds.Tables("tbuser")
    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Cek kembali data yang ingin diinputkan.!")
            Exit Sub
        Else


            Dim simpan As String
            simpan = "insert into tbuser (IDuser, passworduser,bagian)" & " values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "')"

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

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
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
End Class