Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class sefer
    Private receivedValue1 As String
    Private receivedValue2 As String
    Public Sub SetValues(value1 As String, value2 As String)
        receivedValue1 = value1
        receivedValue2 = value2
    End Sub
    Dim routes As New Dictionary(Of String, RouteDetails) From {
    {"İstanbul-Ankara", New RouteDetails("İstanbul-Esenler Otogarı", "Ankara Otogarı", {"06.00", "12.00", "18.00", "23.59"}, {"7.30 saat", "6.45 saat", "7.00 saat", "6.46 saat"}, {"13.30", "18.45", "01.00", "06.45"}, {"₺549,00", "₺549,00", "₺599,00", "₺539,00"})},
    {"İstanbul-Bursa", New RouteDetails("İstanbul-Esenler Otogarı", "Bursa Otogarı", {"05.00", "10.30", "14.20", "21.15"}, {"3.45 saat", "3.35 saat", "3.15 saat", "3.34 saat"}, {"08.45", "14.05", "17.35", "00.49"}, {"₺400,00", "₺410,00", "₺400,00", "₺430,00"})},
    {"İstanbul-İzmir", New RouteDetails("İstanbul-Esenler Otogarı", "İzmir Otogarı", {"02.00", "08.00", "15.00", "22.00"}, {"7.45 saat", "7.45 saat", "7.45 saat", "7.25 saat"}, {"09.45", "15.45", "22.45", "05.25"}, {"₺770,00", "₺770,00", "₺770,00", "₺770,00"})},
    {"İstanbul-Antalya", New RouteDetails("İstanbul-Esenler Otogarı", "Antalya Otogarı", {"08.30", "13.15", "17.00", "23.00"}, {"13.00 saat", "14.45 saat", "13.15 saat", "12.30 saat"}, {"21.30", "03.30", "06.15", "11.30"}, {"₺950,00", "₺950,00", "₺950,00", "₺950,00"})},
    {"Ankara-İstanbul", New RouteDetails("Ankara Otogarı", "İstanbul-Esenler Otogarı", {"10.00", "12.00", "17.00", "23.00"}, {"7.15 saat", "6.30 saat", "6.25 saat", "6.50 saat"}, {"17.15", "18.30", "23.25", "05.50"}, {"₺549,00", "₺549,00", "₺549,00", "₺549,00"})},
    {"Ankara-Bursa", New RouteDetails("Ankara Otogarı", "Bursa Otogarı", {"02.00", "06.00", "14.00", "19.00"}, {"5.45 saat", "5.45 saat", "5.50 saat", "5.44 saat"}, {"07.45", "11.45", "19.50", "00.44"}, {"₺499,00", "₺499,00", "₺499,00", "₺499,00"})},
    {"Ankara-İzmir", New RouteDetails("Ankara Otogarı", "İzmir Otogarı", {"07.30", "09.30", "18.00", "22.00"}, {"8.10 saat", "8.00 saat", "7.30 saat", "7.55 saat"}, {"15.40", "17.30", "01.30", "05.55"}, {"₺600,00", "₺600,00", "₺600,00", "₺600,00"})},
    {"Ankara-Antalya", New RouteDetails("Ankara Otogarı", "Antalya Otogarı", {"04.00", "10.00", "14.00", "22.00"}, {"8.30 saat", "7.55 saat", "9.00 saat", "7.55 saat"}, {"12.30", "17.55", "23.00", "05.55"}, {"₺549,00", "₺549,00", "₺549,00", "₺499,00"})},
    {"Bursa-İstanbul", New RouteDetails("İstanbul-Esenler Otogarı", "Ankara Otogarı", {"06.00", "12.00", "18.00", "23.59"}, {"7.30 saat", "6.45 saat", "7.00 saat", "6.46 saat"}, {"13.30", "18.45", "01.00", "06.45"}, {"₺549,00", "₺549,00", "₺599,00", "₺539,00"})},
    {"Bursa-Ankara", New RouteDetails("Bursa Otogarı", "Ankara Otogarı", {"02.00", "06.00", "14.00", "19.00"}, {"5.45 saat", "5.45 saat", "5.50 saat", "5.44 saat"}, {"07.45", "11.45", "19.50", "00.44"}, {"₺499,00", "₺499,00", "₺499,00", "₺499,00"})},
    {"Bursa-İzmir", New RouteDetails("Bursa Otogarı", "İzmir Otogarı", {"01.00", "10.00", "14.00", "21.00"}, {"3.45 saat", "3.45 saat", "3.45 saat", "3.45 saat"}, {"04.45", "13.45", "17.45", "00.45"}, {"₺400,00", "₺400,00", "₺400,00", "₺400,00"})},
    {"Bursa-Antalya", New RouteDetails("Bursa Otogarı", "Antalya Otogarı", {"05.30", "10.30", "12.00", "23.00"}, {"10.00 saat", "10.00 saat", "8.30 saat", "9.10 saat"}, {"15.30", "20.30", "20.30", "08.10"}, {"₺750,00", "₺750,00", "₺750,00", "₺750,00"})},
    {"İzmir-İstanbul", New RouteDetails("İzmir Otogarı", "İstanbul-Esenler Otogarı", {"02.00", "08.00", "15.00", "22.00"}, {"7.45 saat", "7.45 saat", "7.45 saat", "7.25 saat"}, {"09.45", "15.45", "22.45", "05.25"}, {"₺770,00", "₺770,00", "₺770,00", "₺770,00"})},
    {"İzmir-Ankara", New RouteDetails("İzmir Otogarı", "Ankara Otogarı", {"07.30", "09.30", "18.00", "22.00"}, {"8.10 saat", "8.00 saat", "7.30 saat", "7.55 saat"}, {"15.40", "17.30", "01.30", "05.55"}, {"₺600,00", "₺600,00", "₺600,00", "₺600,00"})},
    {"İzmir-Bursa", New RouteDetails("İzmir Otogarı", "Bursa Otogarı", {"01.00", "10.00", "14.00", "21.00"}, {"3.45 saat", "3.45 saat", "3.45 saat", "3.45 saat"}, {"04.45", "13.45", "17.45", "00.45"}, {"₺400,00", "₺400,00", "₺400,00", "₺400,00"})},
    {"İzmir-Antalya", New RouteDetails("İzmir Otogarı", "Antalya Otogarı", {"01.00", "07.00", "20.00", "23.58"}, {"6.00 saat", "6.45 saat", "7.30 saat", "6.32 saat"}, {"07.00", "13.45", "03.30", "06.30"}, {"₺600,00", "₺600,00", "₺600,00", "₺600,00"})},
    {"Antalya-İstanbul", New RouteDetails("Antalya Otogarı", "İstanbul-Esenler Otogarı", {"08.30", "13.15", "17.00", "23.00"}, {"13.00 saat", "14.45 saat", "13.15 saat", "12.30 saat"}, {"21.30", "03.30", "06.15", "11.30"}, {"₺950,00", "₺950,00", "₺950,00", "₺950,00"})},
    {"Antalya-Ankara", New RouteDetails("Antalya Otogarı", "Ankara Otogarı", {"04.00", "10.00", "14.00", "22.00"}, {"8.30 saat", "7.55 saat", "9.00 saat", "7.55 saat"}, {"12.30", "17.55", "23.00", "05.55"}, {"₺549,00", "₺549,00", "₺549,00", "₺499,00"})},
    {"Antalya-Bursa", New RouteDetails("Antalya Otogarı", "Bursa Otogarı", {"05.30", "10.30", "12.00", "23.00"}, {"10.00 saat", "10.00 saat", "8.30 saat", "9.10 saat"}, {"15.30", "20.30", "20.30", "08.10"}, {"₺750,00", "₺750,00", "₺750,00", "₺750,00"})},
    {"Antalya-İzmir", New RouteDetails("Antalya Otogarı", "İzmir Otogarı", {"01.00", "07.00", "20.00", "23.58"}, {"6.00 saat", "6.45 saat", "7.30 saat", "6.32 saat"}, {"07.00", "13.45", "03.30", "06.30"}, {"₺600,00", "₺600,00", "₺600,00", "₺600,00"})}}




    Public Class RouteDetails
        Public Property DepartureStation As String
        Public Property ArrivalStation As String
        Public Property DepartureTimes As String()
        Public Property Durationss As String()
        Public Property ArrivalTimes As String()
        Public Property Pricess As String()

        Public Sub New(depStation As String, arrStation As String, depTimes As String(), durations As String(), arrTimes As String(), prices As String())
            DepartureStation = depStation
            ArrivalStation = arrStation
            DepartureTimes = depTimes
            Durationss = durations
            ArrivalTimes = arrTimes
            Pricess = prices
        End Sub
    End Class
    Private Sub sefer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim key As String = $"{receivedValue1}-{receivedValue2}"
        If routes.ContainsKey(key) Then
            Dim route = routes(key)

            Label5.Text = route.DepartureStation
            Label10.Text = route.DepartureStation
            Label17.Text = route.DepartureStation
            Label24.Text = route.DepartureStation

            Label6.Text = route.ArrivalStation
            Label9.Text = route.ArrivalStation
            Label16.Text = route.ArrivalStation
            Label23.Text = route.ArrivalStation


            Label1.Text = route.DepartureTimes(0)
            Label14.Text = route.DepartureTimes(1)
            Label21.Text = route.DepartureTimes(2)
            Label28.Text = route.DepartureTimes(3)


            Label2.Text = route.Durationss(0)
            Label13.Text = route.Durationss(1)
            Label20.Text = route.Durationss(2)
            Label27.Text = route.Durationss(3)


            Label3.Text = route.ArrivalTimes(0)
            Label12.Text = route.ArrivalTimes(1)
            Label19.Text = route.ArrivalTimes(2)
            Label26.Text = route.ArrivalTimes(3)


            Label7.Text = route.Pricess(0)
            Label8.Text = route.Pricess(1)
            Label15.Text = route.Pricess(2)
            Label22.Text = route.Pricess(3)

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.RadioButton1Enabled Then
            chooseseats.Show()
            Me.Hide()
        ElseIf Form1.RadioButton2Enabled Then
            gerisefer.Show()
            gerisefer.SetValues(receivedValue1, receivedValue2)

            Me.Hide()
        End If
        odeme.KalkisYer = Label5.Text
        odeme.VarisYer = Label6.Text
        odeme.KalkisSaat = Label1.Text
        odeme.Sure = Label2.Text
        odeme.BitisSaat = Label3.Text
        odeme.Fiyat = Label7.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Form1.RadioButton1Enabled Then

            chooseseats.Show()
            Me.Hide()
        ElseIf Form1.RadioButton2Enabled Then

            gerisefer.SetValues(receivedValue1, receivedValue2)
            gerisefer.Show()
            Me.Hide()

        End If
        odeme.KalkisYer = Label10.Text
        odeme.VarisYer = Label9.Text
        odeme.KalkisSaat = Label14.Text
        odeme.Sure = Label13.Text
        odeme.BitisSaat = Label12.Text
        odeme.Fiyat = Label8.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form1.RadioButton1Enabled Then

            chooseseats.Show()
            Me.Hide()
        ElseIf Form1.RadioButton2Enabled Then

            gerisefer.SetValues(receivedValue1, receivedValue2)
            gerisefer.Show()
            Me.Hide()

        End If
        odeme.KalkisYer = Label17.Text
        odeme.VarisYer = Label16.Text
        odeme.KalkisSaat = Label21.Text
        odeme.Sure = Label20.Text
        odeme.BitisSaat = Label19.Text
        odeme.Fiyat = Label15.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Form1.RadioButton1Enabled Then

            chooseseats.Show()
            Me.Hide()
        ElseIf Form1.RadioButton2Enabled Then

            gerisefer.SetValues(receivedValue1, receivedValue2)
            gerisefer.Show()
            Me.Hide()

        End If
        odeme.KalkisYer = Label24.Text
        odeme.VarisYer = Label23.Text
        odeme.KalkisSaat = Label28.Text
        odeme.Sure = Label27.Text
        odeme.BitisSaat = Label26.Text
        odeme.Fiyat = Label22.Text

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form1.RadioButton1.Enabled Then
            tekyon.Show()
            Me.Hide()
        ElseIf Form1.RadioButton2Enabled Then
            gidisdonus.Show()
            Me.Hide()

        End If
    End Sub
End Class