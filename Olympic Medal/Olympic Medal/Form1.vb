Public Class OlympicMedal
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        ' Create the variables for finishing position and output

        Dim intPosition As Integer
        Dim strPosition As String

        ' Get the finishing position

        intPosition = CInt(txtPosition.Text)


        ' Evaluate Position 
        Select Case intPosition
            Case 1
                strPosition = "Gold medalist."

            Case 2
                strPosition = "Silver medalist."
            Case 3
                strPosition = "Bronze medalist."
            Case 4 To 5
                strPosition = "You almost won a medal."
            Case Else
                strPosition = "Nice try."

        End Select

        'Output the results
        lblOutput.Text = strPosition
    End Sub
End Class
