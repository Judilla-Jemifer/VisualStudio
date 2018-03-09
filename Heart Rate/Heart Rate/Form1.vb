Public Class Form1


    Private Sub btnComputeTHR_Click(sender As Object, e As EventArgs) Handles btnComputeTHR.Click
        ' Create the variables for the age, resting heart rate, and the THR
        Dim intAge, intRestingHeartRate, intTHR As Integer

        ' Get the age and the resting heart rate
        intAge = CInt(txtAge.Text)
        intRestingHeartRate = CInt(txtRestingHeartRate.Text)

        ' Compute the THR
        intTHR = 0.7 * (220 - intAge) + 0.3 * intRestingHeartRate

        ' Output the results
        lblOutput.Text = "Your THR is " & intTHR & " beats per minute."



    End Sub
End Class
