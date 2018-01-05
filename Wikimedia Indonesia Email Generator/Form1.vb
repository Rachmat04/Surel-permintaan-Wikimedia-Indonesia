Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nominal As Double = txbNominal.Text
        txbHasil.Text = "Halo " & Trim(txbKepada.Text) & "," & Environment.NewLine & Environment.NewLine & "Berikut adalah permintaan penggantian " &
                Trim(txbPembelian.Text) & " sebesar Rp" & Trim(Nominal.ToString("N2")) & "." & Environment.NewLine & Environment.NewLine &
                "Nota: " & Trim(txbPranalaNota.Text) & Environment.NewLine & Environment.NewLine & "Laporan penggunaan dana: " &
                Trim(txbPranalaLaporan.Text) & Environment.NewLine & Environment.NewLine & "Anggaran: " & txbPranalaAnggaran.Text & Environment.NewLine & Environment.NewLine &
                "Apabila disetujui, mohon dana tersebut dikirim ke rekening " & Trim(cmbBank.Text) & " " & Trim(txbNoRekeningTujuan.Text) &
                " a.n. " & Trim(txbNamaRekening.Text) & "." & Environment.NewLine & Environment.NewLine & "Salam," & Environment.NewLine & txbNamaRekening.Text
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

    Private Sub txbNominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNominal.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txbNoRekeningTujuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNoRekeningTujuan.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
End Class
