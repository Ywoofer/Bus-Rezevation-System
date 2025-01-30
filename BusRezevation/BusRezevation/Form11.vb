Imports QRCoder
Public Class qrolustur
    Public Property Secili1
    Public Property Secili2
    Public Property Isim1
    Public Property Gmail1
    Public Property Number
    Public Property Kalkis
    Public Property Varis
    Public Property Tarih
    Public Property Saat
    Public Property Seats As String
    Public Property Donusbaslangic
    Public Property Donusyer
    Public Property Donuskalkissaat
    Public Property Donustarih
    Public Property Donusfiyat



    Dim qrIcerik As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Secili1 = "True" Then

            qrIcerik = $"Ad: {Isim1}" & vbCrLf &
                        $"Email: {Gmail1}" & vbCrLf &
                        $"Telefon: {Number}" & vbCrLf &
                        $"Kalkış: {Kalkis}" & vbCrLf &
                        $"Varış: {Varis}" & vbCrLf &
                        $"Tarih: {Tarih}" & vbCrLf &
                        $"Saat: {Saat}" & vbCrLf &
                        $"{Seats}"
        ElseIf Secili2 = "True" Then
            qrIcerik = $"Ad: {Isim1}" & vbCrLf &
                        $"Email: {Gmail1}" & vbCrLf &
                        $"Telefon: {Number}" & vbCrLf &
                        $"Kalkış: {Kalkis}" & vbCrLf &
                        $"Varış: {Varis}" & vbCrLf &
                        $"Tarih: {Tarih}" & vbCrLf &
                        $"Saat: {Saat}" & vbCrLf &
                        $"Dönüş Kalkış: {Donusbaslangic}" & vbCrLf &
                        $"Dönüş Varış: {Donusyer}" & vbCrLf &
                        $"Dönüş Kalkış Tarih: {Donustarih}" & vbCrLf &
                        $"Dönüş Saat : {Donuskalkissaat}" & vbCrLf &
                        $"Dönüş Fiyat: {Donusfiyat}" & vbCrLf &
                        $"{Seats}"


        End If
        Dim olustur As New QRCodeGenerator
        Dim qr = olustur.CreateQrCode(qrIcerik, QRCodeGenerator.ECCLevel.Q)
        Dim kod As New QRCode(qr)
        PictureBox1.Image = kod.GetGraphic(20)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kaydet As New SaveFileDialog
        kaydet.Filter = "JPG DOSYASI | *.jpg"
        kaydet.Title = "Qr Kod Kaydet"
        kaydet.FileName = "rezervasyon-qr"
        If kaydet.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(kaydet.FileName)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class