<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(481, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.ADDUSERToolStripMenuItem, Me.LToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(481, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "&FILE"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BantuanToolStripMenuItem.Text = "&Bantuan"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MASTERToolStripMenuItem.Text = "&MASTER"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data &Barang"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPenjualanToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "&TRANSAKSI"
        '
        'TransaksiPenjualanToolStripMenuItem
        '
        Me.TransaksiPenjualanToolStripMenuItem.Name = "TransaksiPenjualanToolStripMenuItem"
        Me.TransaksiPenjualanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TransaksiPenjualanToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.TransaksiPenjualanToolStripMenuItem.Text = "&Transaksi Penjualan"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataBarangToolStripMenuItem, Me.LaporanToolStripMenuItem1, Me.LaporanPenjualanToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "&LAPORAN"
        '
        'LaporanDataBarangToolStripMenuItem
        '
        Me.LaporanDataBarangToolStripMenuItem.Name = "LaporanDataBarangToolStripMenuItem"
        Me.LaporanDataBarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.LaporanDataBarangToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.LaporanDataBarangToolStripMenuItem.Text = "&Laporan Data Barang"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.LaporanToolStripMenuItem1.Text = "&Laporan Data Customer"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "&Laporan Penjualan"
        '
        'ADDUSERToolStripMenuItem
        '
        Me.ADDUSERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.ADDUSERToolStripMenuItem.Name = "ADDUSERToolStripMenuItem"
        Me.ADDUSERToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ADDUSERToolStripMenuItem.Text = "&ADD USER"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.LToolStripMenuItem.Text = "&LOG OUT"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(97, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selamat Datang di Menu Utama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(123, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SISTEM INFORMASI PENJUALAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(229, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PADA "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(113, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PT MAJU KEDEPAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(12, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Created By. ADI NUGROHO"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 283)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDUSERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
