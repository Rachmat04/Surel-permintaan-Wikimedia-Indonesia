<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbNamaRekening = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbNoRekeningTujuan = New System.Windows.Forms.TextBox()
        Me.txbPranalaAnggaran = New System.Windows.Forms.TextBox()
        Me.txbPranalaLaporan = New System.Windows.Forms.TextBox()
        Me.txbPranalaNota = New System.Windows.Forms.TextBox()
        Me.txbNominal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbPembelian = New System.Windows.Forms.TextBox()
        Me.txbKepada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txbHasil = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txbNamaRekening)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbBank)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txbNoRekeningTujuan)
        Me.GroupBox1.Controls.Add(Me.txbPranalaAnggaran)
        Me.GroupBox1.Controls.Add(Me.txbPranalaLaporan)
        Me.GroupBox1.Controls.Add(Me.txbPranalaNota)
        Me.GroupBox1.Controls.Add(Me.txbNominal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txbPembelian)
        Me.GroupBox1.Controls.Add(Me.txbKepada)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Isi surel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nama pemilik rekening:"
        '
        'txbNamaRekening
        '
        Me.txbNamaRekening.Location = New System.Drawing.Point(202, 255)
        Me.txbNamaRekening.Name = "txbNamaRekening"
        Me.txbNamaRekening.Size = New System.Drawing.Size(276, 22)
        Me.txbNamaRekening.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nomor rekening tujuan:"
        '
        'cmbBank
        '
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Items.AddRange(New Object() {"Bank Mandiri", "Bank Central Asia", "Bank Rakyat Indonesia", "Bank Negara Indonesia 46", "Bank Muamalat", "Bank Tabungan Pensiunan Negara"})
        Me.cmbBank.Location = New System.Drawing.Point(202, 200)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(276, 21)
        Me.cmbBank.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Untuk dikirim ke bank:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pranala anggaran (opsional)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pranala laporan penggunaan dana:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pranala nota:"
        '
        'txbNoRekeningTujuan
        '
        Me.txbNoRekeningTujuan.Location = New System.Drawing.Point(202, 227)
        Me.txbNoRekeningTujuan.Name = "txbNoRekeningTujuan"
        Me.txbNoRekeningTujuan.Size = New System.Drawing.Size(276, 22)
        Me.txbNoRekeningTujuan.TabIndex = 9
        '
        'txbPranalaAnggaran
        '
        Me.txbPranalaAnggaran.Location = New System.Drawing.Point(202, 171)
        Me.txbPranalaAnggaran.Name = "txbPranalaAnggaran"
        Me.txbPranalaAnggaran.Size = New System.Drawing.Size(276, 22)
        Me.txbPranalaAnggaran.TabIndex = 8
        '
        'txbPranalaLaporan
        '
        Me.txbPranalaLaporan.Location = New System.Drawing.Point(202, 142)
        Me.txbPranalaLaporan.Name = "txbPranalaLaporan"
        Me.txbPranalaLaporan.Size = New System.Drawing.Size(276, 22)
        Me.txbPranalaLaporan.TabIndex = 7
        '
        'txbPranalaNota
        '
        Me.txbPranalaNota.Location = New System.Drawing.Point(202, 113)
        Me.txbPranalaNota.Name = "txbPranalaNota"
        Me.txbPranalaNota.Size = New System.Drawing.Size(276, 22)
        Me.txbPranalaNota.TabIndex = 6
        '
        'txbNominal
        '
        Me.txbNominal.Location = New System.Drawing.Point(202, 84)
        Me.txbNominal.Name = "txbNominal"
        Me.txbNominal.Size = New System.Drawing.Size(158, 22)
        Me.txbNominal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nominal pembelian:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Untuk keperluan (pembelian):"
        '
        'txbPembelian
        '
        Me.txbPembelian.Location = New System.Drawing.Point(202, 56)
        Me.txbPembelian.Name = "txbPembelian"
        Me.txbPembelian.Size = New System.Drawing.Size(276, 22)
        Me.txbPembelian.TabIndex = 2
        '
        'txbKepada
        '
        Me.txbKepada.Location = New System.Drawing.Point(202, 27)
        Me.txbKepada.Name = "txbKepada"
        Me.txbKepada.Size = New System.Drawing.Size(276, 22)
        Me.txbKepada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ditujukan kepada:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Buat surel!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(353, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Hapus semua"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txbHasil
        '
        Me.txbHasil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbHasil.Location = New System.Drawing.Point(12, 353)
        Me.txbHasil.Multiline = True
        Me.txbHasil.Name = "txbHasil"
        Me.txbHasil.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbHasil.Size = New System.Drawing.Size(484, 161)
        Me.txbHasil.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(353, 520)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Salin…"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 559)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txbHasil)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surel permintaan klaim Wikimedia Indonesia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbBank As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbNoRekeningTujuan As TextBox
    Friend WithEvents txbPranalaAnggaran As TextBox
    Friend WithEvents txbPranalaLaporan As TextBox
    Friend WithEvents txbPranalaNota As TextBox
    Friend WithEvents txbNominal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbPembelian As TextBox
    Friend WithEvents txbKepada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txbHasil As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txbNamaRekening As TextBox
    Friend WithEvents Button3 As Button
End Class
