Public Class Average


    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ' Create the variables for scores and average

        Dim intScore1, intScore2, intScore3, intMax1, intMax2 As Integer
        Dim decAverage As Decimal

        ' Get the scores
        intScore1 = CInt(txtScore1.Text)
        intScore2 = CInt(txtScore2.Text)
        intScore3 = CInt(txtScore3.Text)


        ' Calculate the Average of the two highest scores
        If (intScore1 >= intScore2 And intScore2 >= intScore3) Or (intScore2 >= intScore1 And intScore1 >= intScore3) Then
            intMax1 = intScore1
            intMax2 = intScore2
            decAverage = (intMax1 + intMax2) / 2

        ElseIf (intScore2 >= intScore3 And intScore3 >= intScore1) Or (intScore3 >= intScore2 And intScore2 >= intScore1) Then
            intMax1 = intScore2
            intMax2 = intScore3
            decAverage = (intMax1 + intMax2) / 2
        Else
            intMax1 = intScore1
            intMax2 = intScore3
            decAverage = (intMax1 + intMax2) / 2
        End If



        'Output the results
        lblOutput.Text = decAverage

    End Sub
End Class
