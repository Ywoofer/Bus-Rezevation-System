Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        hakkında.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        iletisim.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not (RadioButton1.Checked Or RadioButton2.Checked) Then
            MessageBox.Show("Lütfen gidiş veya dönüş seçimini yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If RadioButton1.Checked Then
                tekyon.Show()
                Me.Hide()
            ElseIf RadioButton2.Checked Then

                gidisdonus.Show()
                Me.Hide()
            End If
        End If
        If RadioButton1.Checked Then
            odeme.RadioButton1Secilme = "True"
            odeme.RadioButton2Secilme = "False"

        ElseIf RadioButton2.Checked Then
            odeme.RadioButton1Secilme = "False"
            odeme.RadioButton2Secilme = "True"

        End If
        If RadioButton1.Checked Then
            qrolustur.Secili1 = "True"
            qrolustur.Secili2 = "False"

        ElseIf RadioButton2.Checked Then
            qrolustur.Secili1 = "False"
            qrolustur.Secili2 = "True"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Shared RadioButton1Enabled As Boolean
    Public Shared RadioButton2Enabled As Boolean



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1Enabled = RadioButton1.Enabled
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton2Enabled = RadioButton2.Enabled
    End Sub
End Class
