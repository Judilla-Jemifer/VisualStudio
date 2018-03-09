Public Class LetterGrades
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        ' Create variables for score and letter grade
        Dim intScore As Integer
        Dim strGrade As String

        ' Get input score
        intScore = CInt(txtScore.Text)

        ' Assign letter grade

        Select Case intScore
            Case Is >= 93
                strGrade = "A"
            Case 90 To 92
                strGrade = "A-"
            Case 87 To 89
                strGrade = "B+"
            Case 83 To 86
                strGrade = "B"
            Case 80 To 82
                strGrade = "B-"
            Case 77 To 79
                strGrade = "C+"
            Case 73 To 77
                strGrade = "C"
            Case 70 To 72
                strGrade = "C-"
            Case 65 To 69
                strGrade = "D+"
            Case 60 To 64
                strGrade = "D"
            Case Else
                strGrade = "F"


        End Select

        ' Output the result
        lblOutput.Text = strGrade
    End Sub
End Class
