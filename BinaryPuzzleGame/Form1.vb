Imports System.IO

Public Class Form1
    Dim arrButtons(6, 6) As Button
    Dim puzzleGrid(6, 6) As Integer
    Dim lstStatus As New ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateButtons()
        setupListBox()
        startNewGame()
    End Sub

    Private Sub setupListBox()
        lstStatus.Location = New Point(50, 500)
        lstStatus.Size = New Size(400, 100)
        Me.Controls.Add(lstStatus)

        Dim btnNewGame As New Button
        btnNewGame.Text = "New Game"
        btnNewGame.Location = New Point(50, 610)
        AddHandler btnNewGame.Click, AddressOf btnNewGame_Click
        Me.Controls.Add(btnNewGame)
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs)
        startNewGame()
    End Sub

    Private Sub startNewGame()
        puzzleGrid = generatePuzzle()
        updateButtonsFromGrid()
        updateStatus("New game started. Good luck!")
    End Sub

    Private Sub generateButtons()
        For row = 1 To 6
            For column = 1 To 6
                Dim button = New Button
                arrButtons(row, column) = button
                button.Name = $"btn{row}{column}"
                button.Parent = Me
                button.Width = 60
                button.Height = 60
                button.Visible = True
                button.Location = New Point(column * 70, row * 70)
                AddHandler button.Click, AddressOf Button_Click
            Next column
        Next row
    End Sub

    Private Function generatePuzzle() As Integer(,)
        Dim newPuzzle(6, 6) As Integer
        Dim rnd As New Random()
        Dim attempts As Integer = 0

        Do
            For i As Integer = 1 To 6
                For j As Integer = 1 To 6
                    newPuzzle(i, j) = -1
                Next
            Next

            For i As Integer = 1 To 6
                For j As Integer = 1 To 6
                    If rnd.Next(100) < 40 Then
                        newPuzzle(i, j) = rnd.Next(2)
                    End If
                Next
            Next

            attempts += 1
            If attempts > 1000 Then
                attempts = 0
            End If

        Loop Until isValidPuzzle(newPuzzle) AndAlso isSolvable(newPuzzle)

        Return newPuzzle
    End Function

    Private Sub updateButtonsFromGrid()
        For r = 1 To 6
            For c = 1 To 6
                If puzzleGrid(r, c) = -1 Then
                    arrButtons(r, c).Text = ""
                    arrButtons(r, c).Enabled = True
                Else
                    arrButtons(r, c).Text = puzzleGrid(r, c).ToString()
                    arrButtons(r, c).Enabled = False
                End If
            Next
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Dim r, c As Integer
        getPos(clickedButton, r, c)

        If puzzleGrid(r, c) = -1 Then
            clickedButton.Text = "0"
            puzzleGrid(r, c) = 0
        ElseIf puzzleGrid(r, c) = 0 Then
            clickedButton.Text = "1"
            puzzleGrid(r, c) = 1
        Else
            clickedButton.Text = "0"
            puzzleGrid(r, c) = 0
        End If

        checkPuzzleStatus()
    End Sub

    Private Sub getPos(clickedButton As Button, ByRef x As Integer, ByRef y As Integer)
        For i = 1 To 6
            For j = 1 To 6
                If arrButtons(i, j) Is clickedButton Then
                    x = i
                    y = j
                    Exit Sub
                End If
            Next j
        Next i
    End Sub

    Private Sub checkPuzzleStatus()
        If Not checkAdjacent() Then
            updateStatus("Invalid: More than two adjacent squares with the same number.")
        ElseIf Not checkRowColumnCounts() Then
            updateStatus("Invalid: Each row and column must have three 0s and three 1s.")
        ElseIf Not checkUniqueness() Then
            updateStatus("Invalid: Each row and column must be unique.")
        ElseIf isPuzzleComplete() Then
            updateStatus("Congratulations! Puzzle complete!")
        Else
            updateStatus("Valid move. Keep going!")
        End If
    End Sub

    Private Function checkAdjacent() As Boolean
        For r = 1 To 6
            For c = 1 To 4
                If puzzleGrid(r, c) <> -1 AndAlso puzzleGrid(r, c) = puzzleGrid(r, c + 1) AndAlso puzzleGrid(r, c) = puzzleGrid(r, c + 2) Then
                    Return False
                End If
            Next
        Next

        For c = 1 To 6
            For r = 1 To 4
                If puzzleGrid(r, c) <> -1 AndAlso puzzleGrid(r, c) = puzzleGrid(r + 1, c) AndAlso puzzleGrid(r, c) = puzzleGrid(r + 2, c) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Function checkRowColumnCounts() As Boolean
        For r = 1 To 6
            Dim zeros As Integer = 0
            Dim ones As Integer = 0
            For c = 1 To 6
                If puzzleGrid(r, c) = 0 Then zeros += 1
                If puzzleGrid(r, c) = 1 Then ones += 1
            Next
            If zeros > 3 Or ones > 3 Then Return False
        Next

        For c = 1 To 6
            Dim zeros As Integer = 0
            Dim ones As Integer = 0
            For r = 1 To 6
                If puzzleGrid(r, c) = 0 Then zeros += 1
                If puzzleGrid(r, c) = 1 Then ones += 1
            Next
            If zeros > 3 Or ones > 3 Then Return False
        Next

        Return True
    End Function

    Private Function checkUniqueness() As Boolean
        For r1 = 1 To 5
            For r2 = r1 + 1 To 6
                If rowsEqual(r1, r2) Then Return False
            Next
        Next

        For c1 = 1 To 5
            For c2 = c1 + 1 To 6
                If columnsEqual(c1, c2) Then Return False
            Next
        Next

        Return True
    End Function

    Private Function rowsEqual(r1 As Integer, r2 As Integer) As Boolean
        For c = 1 To 6
            If puzzleGrid(r1, c) <> puzzleGrid(r2, c) OrElse puzzleGrid(r1, c) = -1 OrElse puzzleGrid(r2, c) = -1 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function columnsEqual(c1 As Integer, c2 As Integer) As Boolean
        For r = 1 To 6
            If puzzleGrid(r, c1) <> puzzleGrid(r, c2) OrElse puzzleGrid(r, c1) = -1 OrElse puzzleGrid(r, c2) = -1 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function isPuzzleComplete() As Boolean
        For r = 1 To 6
            For c = 1 To 6
                If puzzleGrid(r, c) = -1 Then Return False
            Next
        Next
        Return True
    End Function

    Private Sub updateStatus(message As String)
        lstStatus.Items.Add(message)
        lstStatus.TopIndex = lstStatus.Items.Count - 1
    End Sub

    Private Function isValidPuzzle(puzzle As Integer(,)) As Boolean
        puzzleGrid = puzzle
        Dim isValid As Boolean = checkAdjacent() AndAlso checkRowColumnCounts() AndAlso checkUniqueness()
        puzzleGrid = New Integer(6, 6) {}
        Return isValid
    End Function

    Private Function isSolvable(puzzle As Integer(,)) As Boolean
        Dim tempPuzzle(6, 6) As Integer
        Array.Copy(puzzle, tempPuzzle, puzzle.Length)
        Return solvePuzzle(tempPuzzle)
    End Function

    Private Function solvePuzzle(ByRef puzzle As Integer(,)) As Boolean
        Dim r, c As Integer
        If Not findEmptyCell(puzzle, r, c) Then
            Return True
        End If

        For num As Integer = 0 To 1
            puzzle(r, c) = num
            If isValidPuzzle(puzzle) Then
                If solvePuzzle(puzzle) Then
                    Return True
                End If
            End If
            puzzle(r, c) = -1
        Next

        Return False
    End Function

    Private Function findEmptyCell(puzzle As Integer(,), ByRef row As Integer, ByRef col As Integer) As Boolean
        For r As Integer = 1 To 6
            For c As Integer = 1 To 6
                If puzzle(r, c) = -1 Then
                    row = r
                    col = c
                    Return True
                End If
            Next
        Next
        Return False
    End Function
End Class