Public Class frmStart
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("C:\Users\Nicho\source\repos\BinaryPuzzleGame\BinaryPuzzleGame\startBG.png")
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Hide()
        frmHelp.Show()
    End Sub
End Class