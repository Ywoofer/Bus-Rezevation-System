Imports System.Security.Policy

Public Class odeme
    Public Property RadioButton1Secilme
    Public Property RadioButton2Secilme
    Public Property TekYonNereden
    Public Property TekYonNereye
    Public Property TekYonTarih
    Public Property GitGelNereden
    Public Property GitGelNereye
    Public Property GitGelTarih1
    Public Property GitGelTarih2
    Public Property KalkisSaat
    Public Property BitisSaat
    Public Property KalkisYer
    Public Property VarisYer
    Public Property Sure
    Public Property Fiyat
    Public Property KalkisSaat2
    Public Property BitisSaat2
    Public Property KalkisYer2
    Public Property VarisYer2
    Public Property Sure2
    Public Property Fiyat2
    Public Property Koltuk



    Sub qrKodAc(qrolustur As Form)
        qrolustur.TopLevel = False
        Panel1.Controls.Add(qrolustur)
        qrolustur.Show()
    End Sub
    Private Sub odeme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadioButton1Secilme = "True" Then
            Label10.Text = TekYonNereden
            Label26.Text = TekYonNereye
            Label30.Text = TekYonTarih
            Label12.Text = KalkisSaat
            Label13.Text = BitisSaat
            Label15.Text = Sure
            Label17.Text = Fiyat
            Label34.Text = KalkisYer
            Label35.Text = VarisYer
            Label4.Text = Koltuk
            Label36.Text = ""
            Label37.Text = ""
            Label11.Text = ""
            Label28.Text = ""
            Label32.Text = ""
            Label24.Text = ""
            Label22.Text = ""
            Label20.Text = ""
            Label9.Text = ""
            Label6.Text = ""
            Label29.Text = ""
            Label25.Text = ""
            Label23.Text = ""
            Label21.Text = ""
            Label33.Text = ""
            Label19.Text = ""
            Label36.Text = ""
            Label37.Text = ""
            PictureBox2.Image = Nothing

        ElseIf RadioButton2Secilme = "True" Then
            Label10.Text = GitGelNereden
            Label26.Text = GitGelNereye
            Label30.Text = GitGelTarih1
            Label12.Text = KalkisSaat
            Label13.Text = BitisSaat
            Label15.Text = Sure
            Label17.Text = Fiyat
            Label34.Text = KalkisYer
            Label35.Text = VarisYer
            Label36.Text = KalkisYer2
            Label37.Text = VarisYer2
            Label11.Text = GitGelNereye
            Label28.Text = GitGelNereden
            Label32.Text = GitGelTarih2
            Label24.Text = KalkisSaat2
            Label22.Text = BitisSaat2
            Label20.Text = Sure2
            Label9.Text = Fiyat2
            Label4.Text = Koltuk

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Lütfen Adınızı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Lütfen E-postanızı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("Lütfen İletişim Numaranızı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            qrolustur.Isim1 = TextBox1.Text
            qrolustur.Gmail1 = TextBox2.Text
            qrolustur.Number = TextBox3.Text
            qrolustur.Tarih = Label30.Text
            qrolustur.Kalkis = Label34.Text
            qrolustur.Varis = Label35.Text
            qrolustur.Saat = Label12.Text
            qrolustur.Seats = Koltuk
            qrolustur.Donusbaslangic = Label36.Text
            qrolustur.Donusyer = Label37.Text
            qrolustur.Donuskalkissaat = Label24.Text
            qrolustur.Donustarih = Label32.Text
            qrolustur.Donusfiyat = Label9.Text


            qrKodAc(qrolustur)
        End If
    End Sub


End Class