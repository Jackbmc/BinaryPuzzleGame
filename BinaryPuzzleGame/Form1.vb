Imports System.IO

Public Class Form1
    Dim arrButtons(6, 6) As Button
    Dim puzzleGrid(6, 6) As Integer
    Dim isValid As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateButtons()
        initalisepArray()

        For r = 1 To 6
            For c = 1 To 6
                arrButtons(r, c).Text = puzzleGrid(r, c)
            Next
        Next

        'ListBox1.Items.Add(locateNumberTrios(puzzleGrid))
        'ListBox1.Items.Add(checkRowGrid(puzzleGrid))
        ListBox1.Items.Add("sim" & checkSimilarity(puzzleGrid))

    End Sub

    Private Sub initalisepArray()
        puzzleGrid(1, 1) = 1
        puzzleGrid(1, 2) = 1
        puzzleGrid(1, 3) = 0
        puzzleGrid(1, 4) = 1
        puzzleGrid(1, 5) = 0
        puzzleGrid(1, 6) = 0
        puzzleGrid(2, 1) = 0
        puzzleGrid(2, 2) = 1
        puzzleGrid(2, 3) = 1
        puzzleGrid(2, 4) = 0
        puzzleGrid(2, 5) = 0
        puzzleGrid(2, 6) = 1
        puzzleGrid(3, 1) = 1
        puzzleGrid(3, 2) = 0
        puzzleGrid(3, 3) = 1
        puzzleGrid(3, 4) = 0
        puzzleGrid(3, 5) = 1
        puzzleGrid(3, 6) = 0
        puzzleGrid(4, 1) = 0
        puzzleGrid(4, 2) = 1
        puzzleGrid(4, 3) = 0
        puzzleGrid(4, 4) = 1
        puzzleGrid(4, 5) = 0
        puzzleGrid(4, 6) = 1
        puzzleGrid(5, 1) = 1
        puzzleGrid(5, 2) = 0
        puzzleGrid(5, 3) = 0
        puzzleGrid(5, 4) = 1
        puzzleGrid(5, 5) = 1
        puzzleGrid(5, 6) = 0
        puzzleGrid(6, 1) = 0
        puzzleGrid(6, 2) = 0
        puzzleGrid(6, 3) = 1
        puzzleGrid(6, 4) = 0
        puzzleGrid(6, 5) = 1
        puzzleGrid(6, 6) = 1
    End Sub

    Private Sub generateButtons()
        'generate each square on the chessboard as a Button
        For row = 1 To 6
            For column = 1 To 6
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
            Next column
        Next row

    End Sub

    Private Function locateNumberTrios(pArray(,) As Integer)
        Dim valid As Boolean
        valid = True

        For r = 1 To 6
            For c = 3 To 6
                If c >= 3 Then
                    If (pArray(r, c - 2) = pArray(r, c - 1) And pArray(r, c - 1) = pArray(r, c)) Then
                        valid = False
                    End If
                End If
            Next
        Next


        For r = 3 To 6
            For c = 1 To 6
                If r >= 3 Then
                    If (pArray(r - 2, c) = pArray(r - 1, c) And pArray(r - 1, c) = pArray(r, c)) Then
                        valid = False
                    End If
                End If
            Next
        Next

        Return valid
    End Function

    Private Function checkRowGrid(pArray(,) As Integer)
        Dim valid As Boolean
        Dim counter As Integer
        Dim initial As Integer
        valid = True

        counter = 0

        For r = 1 To 6
            For c = 1 To 6
                initial = pArray(r, 1)
                If pArray(r, c) = initial Then
                    counter = counter + 1
                End If
            Next
            If counter > 3 Or counter < 3 Then
                valid = False
            End If
            counter = 0
        Next

        counter = 0
        For c = 1 To 6
            For r = 1 To 6
                initial = pArray(1, c)
                If pArray(c, r) = initial Then
                    counter = counter + 1
                End If
            Next
            If counter > 3 Or counter < 3 Then
                valid = False
            End If
            counter = 0
        Next

        Return valid
    End Function

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

        puzzleGrid(cX, cY) = Int(arrButtons(cX, cY).Text)

        'checkAdjacent()
        'locateNumberTrios(puzzleGrid)
        'checkRowGrid(puzzleGrid)
        ListBox1.Items.Add("sim" & checkSimilarity(puzzleGrid))
    End Sub

    Private Function checkSimilarity(puzzleGrid(,) As Integer)
        Dim valid As Boolean
        Dim r1 As String
        Dim r2 As String
        Dim r3 As String
        Dim r4 As String
        Dim r5 As String
        Dim r6 As String

        Dim c1 As String
        Dim c2 As String
        Dim c3 As String
        Dim c4 As String
        Dim c5 As String
        Dim c6 As String

        valid = True

        For c = 1 To 6
            r1 = r1 & puzzleGrid(1, c)
            r2 = r2 & puzzleGrid(2, c)
            r3 = r3 & puzzleGrid(3, c)
            r4 = r4 & puzzleGrid(4, c)
            r5 = r5 & puzzleGrid(5, c)
            r6 = r6 & puzzleGrid(6, c)
        Next

        For c = 1 To 6
            c1 = c1 & puzzleGrid(c, 1)
            c2 = c2 & puzzleGrid(c, 2)
            c3 = c3 & puzzleGrid(c, 3)
            c4 = c4 & puzzleGrid(c, 4)
            c5 = c5 & puzzleGrid(c, 5)
            c6 = c6 & puzzleGrid(c, 6)
        Next
        ' Compare the strings for similarity
        Dim strings() As String = {r1, r2, r3, r4, r5, r6}

        For i = 0 To strings.Length - 1
            For j = i + 1 To strings.Length - 1
                If strings(i) = strings(j) Then
                    ' Return False if any two strings are the same
                    valid = False
                End If
            Next
        Next

        Dim strings12() As String = {c1, c2, c3, c4, c5, c6}

        For i = 0 To strings12.Length - 1
            For j = i + 1 To strings12.Length - 1
                If strings12(i) = strings12(j) Then
                    valid = False
                End If
            Next
        Next


        ' Return the result
        Return valid
    End Function

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
        Dim temp
        For x = 1 To 6
            For y = 1 To 4
                If puzzleGrid(x, y) <> -1 AndAlso puzzleGrid(x, y) = puzzleGrid(x, y + 1) And puzzleGrid(x, y) = puzzleGrid(x, y + 2) Then
                    MsgBox("hor invalid")
                    isValid = False
                End If

            Next
        Next
        For x = 1 To 4
            For y = 1 To 6
                If puzzleGrid(x, y) <> -1 AndAlso puzzleGrid(x, y) = puzzleGrid(x + 1, y) And puzzleGrid(x, y) = puzzleGrid(x + 2, y) Then
                    MsgBox("vert invalid")
                    isValid = False
                End If
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

    Private Sub btnTofrmStart_Click(sender As Object, e As EventArgs) Handles btnTofrmStart.Click
        Me.Hide()
        frmStart.Show()
    End Sub

    'Private Function checkgrid(puzzleGrid) As Boolean
    '    Dim total As Integer = 0
    '    For i = 1 To 6
    '        For j = 1 To 6
    '            total += puzzleGrid(i, j)
    '        Next i
    '        If total = 3 * 6 Then
    '            Return True
    '        Else
    '            Return False
    '        End If

    'End Function
End Class