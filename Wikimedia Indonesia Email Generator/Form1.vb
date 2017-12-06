Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txbHasil.Text = "Halo " & txbKepada.Text & "," & Environment.NewLine & Environment.NewLine & "Berikut adalah permintaan penggantian " &
            txbPembelian.Text & " sebesar Rp" & txbNominal.Text & "." & Environment.NewLine & Environment.NewLine &
            "Pranala nota: " & txbPranalaNota.Text & Environment.NewLine & Environment.NewLine & "Pranala laporan penggunaan dana: " &
            txbPranalaLaporan.Text & Environment.NewLine & Environment.NewLine & "Pranala anggaran: " & txbPranalaAnggaran.Text & Environment.NewLine & Environment.NewLine &
            "Apabila disetujui, mohon dana tersebut dikirim ke rekening " & cmbBank.Text & " " & txbNoRekeningTujuan.Text &
            " a.n. " & txbNamaRekening.Text & "." & Environment.NewLine & Environment.NewLine & "Terima kasih dan salam,"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txbHasil.Text = ""
        txbKepada.Text = ""
        txbNamaRekening.Text = ""
        txbNominal.Text = ""
        txbNoRekeningTujuan.Text = ""
        txbPembelian.Text = ""
        txbPranalaAnggaran.Text = ""
        txbPranalaLaporan.Text = ""
        txbPranalaNota.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txbHasil.Text = ""
        txbKepada.Text = ""
        txbNamaRekening.Text = ""
        txbNominal.Text = ""
        txbNoRekeningTujuan.Text = ""
        txbPembelian.Text = ""
        txbPranalaAnggaran.Text = ""
        txbPranalaLaporan.Text = ""
        txbPranalaNota.Text = ""
        cmbBank.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txbHasil.Text <> String.Empty Then
            Clipboard.Clear()
            Clipboard.SetText(txbHasil.Text)
        End If
    End Sub
End Class
