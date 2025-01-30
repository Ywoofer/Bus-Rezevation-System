Public Class tekyon
    Dim previousSelection As String = ""
    Private Sub tekyon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("İstanbul")
        ComboBox1.Items.Add("Ankara")
        ComboBox1.Items.Add("İzmir")
        ComboBox1.Items.Add("Bursa")
        ComboBox1.Items.Add("Antalya")



        ComboBox2.Items.Add("İstanbul")
        ComboBox2.Items.Add("Ankara")
        ComboBox2.Items.Add("İzmir")
        ComboBox2.Items.Add("Bursa")
        ComboBox2.Items.Add("Antalya")
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If e.Start < Date.Today Then
            MonthCalendar1.SelectionStart = Date.Today
            MonthCalendar1.SelectionEnd = Date.Today
        End If
        Label3.Text = MonthCalendar1.SelectionStart.ToShortDateString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If previousSelection <> "" AndAlso Not ComboBox2.Items.Contains(previousSelection) Then
            ComboBox2.Items.Add(previousSelection)
        End If

        Dim selectedItem As String = ComboBox1.SelectedItem.ToString()


        If ComboBox2.Items.Contains(selectedItem) Then
            ComboBox2.Items.Remove(selectedItem)
        End If


        previousSelection = selectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 And ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen Nereden Nereye gideceğinizi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Label3.Text = "Tarih" And Label4.Text = "Tarih" Then
            MessageBox.Show("Lütfen bir Tarih seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Label3.Text <> "Tarih" And Label4.Text <> "Tarih" Then
            Dim selectedValue As String = ComboBox1.SelectedItem.ToString()
            Dim selectedValue2 As String = ComboBox2.SelectedItem.ToString()
            sefer.SetValues(selectedValue, selectedValue2)
            sefer.Show()
            Me.Hide()
            odeme.TekYonNereden = ComboBox1.SelectedItem.ToString()
            odeme.TekYonNereye = ComboBox2.SelectedItem.ToString()
            odeme.TekYonTarih = Label3.Text
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class