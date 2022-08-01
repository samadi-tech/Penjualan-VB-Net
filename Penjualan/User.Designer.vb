<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.btn_tambah = New System.Windows.Forms.Button
        Me.btn_batal = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.btn_hapus = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_keluar = New System.Windows.Forms.Button
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Bagian"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(74, 126)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADV", "SPV"})
        Me.ComboBox1.Location = New System.Drawing.Point(74, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 193)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(239, 136)
        Me.DGV.TabIndex = 7
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(180, 80)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(62, 29)
        Me.btn_tambah.TabIndex = 8
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(248, 80)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(62, 29)
        Me.btn_batal.TabIndex = 9
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(248, 118)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(62, 29)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(180, 118)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(62, 29)
        Me.btn_simpan.TabIndex = 10
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(248, 162)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(62, 29)
        Me.btn_hapus.TabIndex = 13
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(180, 162)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(62, 29)
        Me.btn_edit.TabIndex = 12
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(248, 197)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(62, 132)
        Me.btn_keluar.TabIndex = 14
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""E:\NOT DELETE\ADI NUGROHO 202080417" & _
            "1\Penjualan\dbpenjualan.mdb"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(59, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "INPUT DATA USER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(3, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 8)
        Me.Panel1.TabIndex = 16
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 342)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User"
        Me.Text = "User"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
