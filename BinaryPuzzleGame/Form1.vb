Imports System.IO

Public Class Form1
    Dim arrButtons(6, 6) As Button
    Dim puzzleGrid(6, 6)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateButtons()
    End Sub

    Private Sub generateButtons()
        'generate each square on the chessboard as a Button
        For column = 1 To 6
            For row = 1 To 6
                Dim Button = New Button
                arrButtons(row, column) = Button

                Button.Name = Format(row) + Format(column)
                Button.Parent = Me
                Button.Width = 60
                Button.Height = 60
                Button.Visible = True
                Button.Left = row * 30
                Button.Location = New Point(2 * column * 30 + 100, 2 * row * 30 + 100)

                AddHandler Button.Click, AddressOf Button_Click
            Next row
        Next column

    End Sub

    Dim cX, cY
    Private Sub Button_Click(sender As Object, e As System.EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        getPos(clickedButton, cX, cY)

        If arrButtons(cX, cY).Text = "1" Then
            arrButtons(cX, cY).Text = "0"
        ElseIf arrButtons(cX, cY).Text = "0" Then
            arrButtons(cX, cY).Text = "1"
        Else
            arrButtons(cX, cY).Text = "1"
        End If
    End Sub

    Private Sub getPos(clickedButton As Button, ByRef x As Integer, ByRef y As Integer)
        'Gets the position of the clicked button and sets the x and y values of said button
        For i = 1 To 6
            For j = 1 To 6
                If arrButtons(i, j) Is clickedButton Then
                    x = i
                    y = j
                End If
            Next j
        Next i
    End Sub

    Private Sub checkAdjacent()
        For x = 1 To 6
            For y = 1 To 6

            Next
        Next
    End Sub

    Private Sub loadPuzzle()
        Dim filepath As String = "puzzle.txt"

        If File.Exists(filepath) = False Then
            File.Create(filepath).Dispose()
        End If

        If File.Exists(filepath) = True Then
            ' Read the leaderboard data from the file
            Dim leaderboard As List(Of String) = File.ReadAllLines(filepath).ToList()
            Dim existingPlayerFound As Boolean = False
            For i As Integer = 0 To leaderboard.Count - 1
                Dim playerName As String = leaderboard(i).Substring(0, 3)
                Dim playerScore As Integer = CInt(leaderboard(i).Substring(4))
                If playerName = Name Then
                    ' Update the score if the player already exists in the leaderboard
                    playerScore = playerScore + 1
                    leaderboard(i) = playerName & "," & CStr(playerScore)
                    existingPlayerFound = True
                    i = leaderboard.Count - 1
                End If
            Next i
        End If
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