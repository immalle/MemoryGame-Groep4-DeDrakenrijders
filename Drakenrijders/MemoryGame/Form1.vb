Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Kader(4, 3)
            Form2.Size = New Size(650, 600)
        ElseIf RadioButton2.Checked = True Then
            Kader(6, 3)
            Form2.Size = New Size(850, 600)
        ElseIf RadioButton3.Checked = True Then
            Kader(8, 4)
            Form2.Size = New Size(1100, 750)
        End If
        Form2.Show()
        Me.Hide()


    End Sub

    Public Sub Kader(x As Integer, y As Integer)
        Dim randomGenerator As New Random()

        For i = 1 To y
            For j = 1 To x
                Dim kaart As New PictureBox
                kaart.BackgroundImage = My.Resources.vraagteken1
                kaart.Size = New Size(100, 130)
                kaart.Location = New Point(75 + (j - 1) * 120, 60 + (i - 1) * 165)
                kaart.BorderStyle = BorderStyle.FixedSingle
                Form2.Controls.Add(kaart)

                'AddHandler kaart.MouseClick, AddressOf LabelOnMouseClickEventHandler
                'Dim afbeeldingen As New List(Of Image)
                'afbeeldingen.Add(My.Resources._1)
                'afbeeldingen.Add(My.Resources._1)
                'afbeeldingen.Add(My.Resources._2)
                'afbeeldingen.Add(My.Resources._2)
                'afbeeldingen.Add(My.Resources._3)
                'afbeeldingen.Add(My.Resources._3)
                'afbeeldingen.Add(My.Resources._4)
                'afbeeldingen.Add(My.Resources._4)
                'Dim a As Integer = randomGenerator.Next(1, 4)
                'Dim pict As New Label()
                'pict.Size = New Size(100, 130)
                'pict.Location = New Point(75 + (j - 1) * 120, 60 + (i - 1) * 165)
                'pict.Image =
                'Form2.Controls.Add(pict)
            Next
        Next
    End Sub
    Private Sub LabelOnMouseClickEventHandler(sender As PictureBox, e As System.EventArgs)
        sender.Hide()
    End Sub
    Private Sub Form1_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
