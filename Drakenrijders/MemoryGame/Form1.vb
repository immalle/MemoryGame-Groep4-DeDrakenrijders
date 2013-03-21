Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Kader(4, 3)
            Form2.Size = New Size(450, 400)
        ElseIf RadioButton2.Checked = True Then
            Kader(6, 3)
            Form2.Size = New Size(570, 400)
        ElseIf RadioButton3.Checked = True Then
            Kader(8, 4)
            Form2.Size = New Size(700, 510)
        End If
        Form2.Show()
        Me.Hide()
    End Sub

    Sub Kader(x As Integer, y As Integer)
        For i = 1 To y
            For j = 1 To x
                Dim kaart As New PictureBox
                kaart.BackColor = Color.Gold
                kaart.Size = New Size(60, 90)
                kaart.Location = New Point(50 + (j - 1) * 75, 40 + (i - 1) * 110)

                Form2.Controls.Add(kaart)
            Next
        Next
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

    End Sub
End Class
