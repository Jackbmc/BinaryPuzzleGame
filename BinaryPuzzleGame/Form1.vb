Public Class Form1
    Dim buttonArray(6, 6) As Button
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim grid(6, 6)
        'test
        'tyvgy
        'test2
        generateButtons()
    End Sub

    Private Sub generateButtons()
        'generate each square on the chessboard as a Button
        For column = 1 To 6
            For row = 1 To 6
                Dim Button = New Button
                buttonArray(row, column) = Button

                Button.Name = Format(row) + Format(column)
                Button.Parent = Me
                Button.Width = 60
                Button.Height = 60
                Button.Visible = True
                Button.Left = row * 30
                Button.Location = New Point(2 * column * 30 + 450, 2 * row * 30 + 100)

                If (row + column) Mod 2 = 0 Then
                    Button.BackColor = Color.Beige
                Else
                    Button.BackColor = Color.BurlyWood
                End If
            Next row
        Next column

    End Sub

    Private Sub loadPuzzle()
        'test
    End Sub

    Private Sub locatePairs()

    End Sub

    Private Sub checkgrid()
        For i = 0 To 5
            For j = 0 To 5
            Next j

        Next i
    End Sub
End Class