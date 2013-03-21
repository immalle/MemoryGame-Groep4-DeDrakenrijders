Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim randomGenerator As New Random()
        For i = 0 To 2
            Dim x As Integer = randomGenerator.Next(5)
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("_" & x)
        Next
    End Sub
End Class
