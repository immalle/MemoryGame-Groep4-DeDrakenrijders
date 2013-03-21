Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim randomGenerator As New Random()
        
        For i = 0 To 9
            Dim a As Integer = randomGenerator.Next(1, 6)
            Dim pict As New Label()
            pict.Hide()
            pict.Size = New Size(100, 150)
            pict.Location = New Point(150 * i, 30)
            pict.Image = My.Resources.ResourceManager.GetObject("_" & a)

            Me.Controls.Add(pict)

            AddHandler pict.MouseClick, AddressOf LabelOnMouseClickEventHandler


        Next
    End Sub
    Private Sub LabelOnMouseClickEventHandler(sender As Label, e As System.EventArgs)
        sender()

    End Sub
End Class
