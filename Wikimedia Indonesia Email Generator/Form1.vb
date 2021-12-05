Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nominal As Double = txbNominal.Text
        txbHasil.Text = "Halo " _
            & Trim(txbKepada.Text) _
            & "," _
            & Environment.NewLine _
            & Environment.NewLine _
            & "Berikut adalah permintaan penggantian " _
            & Trim(txbPembelian.Text) _
            & " sebesar Rp" _
            & Trim(Nominal.ToString("N2")) _
            & "." _
            & Environment.NewLine _
            & Environment.NewLine _
            & "Nota: " _
            & Trim(txbPranalaNota.Text) _
            & Environment.NewLine _
            & Environment.NewLine _
            & "Laporan penggunaan dana: " _
            & Trim(txbPranalaLaporan.Text) _
            & Environment.NewLine _
            & Environment.NewLine _
            & "Anggaran: " _
            & txbPranalaAnggaran.Text _
            & Environment.NewLine _
            & Environment.NewLine _
            & "Apabila disetujui, mohon dana tersebut dikirim ke rekening " _
            & Trim(cmbBank.Text) _
            & " " _
            & Trim(txbNoRekeningTujuan.Text) _
            & " a.n. " _
            & Trim(txbNamaRekening.Text) _
            & "." _
            & Environment.NewLine _
            & Environment.NewLine _
            & "Salam," _
            & Environment.NewLine _
            & txbNamaRekening.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Const V As String = ""
        txbHasil.Text = V
        txbKepada.Text = V
        txbNamaRekening.Text = V
        txbNominal.Text = V
        txbNoRekeningTujuan.Text = V
        txbPembelian.Text = V
        txbPranalaAnggaran.Text = V
        txbPranalaLaporan.Text = V
        txbPranalaNota.Text = V
    End Sub

    Private Function GetTxbHasil() As TextBox
        Return txbHasil
    End Function

    Private Function GetTxbKepada() As TextBox
        Return txbKepada
    End Function

    Private Function GetTxbNamaRekening() As TextBox
        Return txbNamaRekening
    End Function

    Private Function GetTxbNominal() As TextBox
        Return txbNominal
    End Function

    Private Function GetTxbNoRekeningTujuan() As TextBox
        Return txbNoRekeningTujuan
    End Function

    Private Function GetTxbPembelian() As TextBox
        Return txbPembelian
    End Function

    Private Function GetTxbPranalaAnggaran() As TextBox
        Return txbPranalaAnggaran
    End Function

    Private Function GetTxbPranalaLaporan() As TextBox
        Return txbPranalaLaporan
    End Function

    Private Function GetTxbPranalaNota() As TextBox
        Return txbPranalaNota
    End Function

    Private Function GetCmbBank() As ComboBox
        Return cmbBank
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txbHasil.Text _
                Is String.Empty Then
            Return
        End If
        Clipboard.Clear()
        Clipboard.SetText(txbHasil.Text)
    End Sub

    Private Sub txbNominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNominal.KeyPress
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
    End Sub

    Private Sub txbNoRekeningTujuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNoRekeningTujuan.KeyPress
        If e.KeyChar _
           = ControlChars.Back Then
            Return
        End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
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

End Class
