<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SamTech
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.btn_tambah = New System.Windows.Forms.Button
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.btn_batal = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_keluar = New System.Windows.Forms.Button
        Me.btn_hapus = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HARGA"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 38)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(119, 71)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(119, 135)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(71, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(119, 171)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(149, 22)
        Me.TextBox4.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PCS", "SET", "BOX", "KG", "METER"})
        Me.ComboBox1.Location = New System.Drawing.Point(120, 102)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 25)
        Me.ComboBox1.TabIndex = 10
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.White
        Me.btn_tambah.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.ForeColor = System.Drawing.Color.Black
        Me.btn_tambah.Location = New System.Drawing.Point(11, 40)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(80, 41)
        Me.btn_tambah.TabIndex = 11
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.White
        Me.btn_simpan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Black
        Me.btn_simpan.Location = New System.Drawing.Point(111, 40)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(79, 41)
        Me.btn_simpan.TabIndex = 12
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.White
        Me.btn_batal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.ForeColor = System.Drawing.Color.Black
        Me.btn_batal.Location = New System.Drawing.Point(207, 92)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(80, 38)
        Me.btn_batal.TabIndex = 14
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.White
        Me.btn_edit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Location = New System.Drawing.Point(207, 40)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(80, 41)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.Color.Red
        Me.btn_keluar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_keluar.Location = New System.Drawing.Point(111, 136)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(79, 58)
        Me.btn_keluar.TabIndex = 17
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.White
        Me.btn_hapus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.Color.Black
        Me.btn_hapus.Location = New System.Drawing.Point(111, 92)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(79, 38)
        Me.btn_hapus.TabIndex = 16
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.White
        Me.btn_update.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(11, 92)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(80, 38)
        Me.btn_update.TabIndex = 15
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(10, 325)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(611, 170)
        Me.DGV.TabIndex = 18
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""D:\NOT DELETE\ADI NUGROHO 202080417" & _
            "1\Penjualan\SamtechDatabse.mdb"""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Location = New System.Drawing.Point(10, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(306, 217)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Barang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(105, 174)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(105, 138)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(105, 106)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(106, 74)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(106, 41)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.btn_simpan)
        Me.GroupBox2.Controls.Add(Me.btn_keluar)
        Me.GroupBox2.Controls.Add(Me.btn_batal)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_hapus)
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.btn_tambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox2.Location = New System.Drawing.Point(322, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 217)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(221, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 61)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FileToolStripMenuItem.Text = "About"
        '
        'SamTech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 501)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "SamTech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Barang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
