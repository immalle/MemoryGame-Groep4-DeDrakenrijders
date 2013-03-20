Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 2
            Dim x As Integer
            Dim rnd As System.Random()

            PictureBox1.Image = My.Resources.ResourceManager.GetString(x)

        Next
    End Sub
End Class
