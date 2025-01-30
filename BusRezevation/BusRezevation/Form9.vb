Public Class chooseseats

    Dim buttonColors As New List(Of Color) From {Color.Red, Color.Green}
    Dim random As New Random()

    Private Sub chooseseats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim buttons As New List(Of Button) From {
            Button1, Button2, Button3, Button4, Button5, Button6, Button7,
            Button8, Button9, Button10, Button11, Button12, Button13, Button14,
            Button15, Button16, Button17, Button18, Button19, Button20, Button21,
            Button22, Button23, Button24, Button25, Button26, Button27
        }


        For Each btn In buttons
            Dim colorIndex = random.Next(buttonColors.Count)
            btn.BackColor = buttonColors(colorIndex)


            If btn.BackColor = Color.Red Then
                btn.Enabled = False
                btn.Text = "Alındı"
            End If
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
        Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click,
        Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click,
        Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click,
        Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click

        Dim clickedButton As Button = CType(sender, Button)


        Label1.Text = "Seçilen Koltuk: " & clickedButton.Name.Replace("Button", "")
    End Sub



    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Label1.Text = "Seçilen Koltuk:0" Then
            MessageBox.Show("Lütfen koltuk numaranızı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            odeme.Show()
            Me.Hide()
            odeme.Koltuk = Label1.Text
        End If

    End Sub
End Class