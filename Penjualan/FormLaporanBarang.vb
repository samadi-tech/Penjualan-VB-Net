Public Class FormLaporanBarang

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.ReportSource = "E:\NOT DELETE\ADI NUGROHO 2020804171\Penjualan\Penjualan\LaporanBarang.rpt"
        CrystalReportViewer1.SelectionFormula = "{tbbarang.kdbarang} = '" & TextBox1.Text & "'"

    End Sub
End Class