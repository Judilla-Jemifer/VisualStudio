Public Class Taxi
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Create the variables for distance and fare

        Dim decDistance, decFare As Decimal

        ' Get the device name, wattage, hours used, and price per kWh used

        decDistance = CDec(txtDistance.Text)


        ' Calculate the Cost 
        decFare = 1 + (((decDistance - 0.25) / 0.25) * 0.2)

        'Output the results
        lblOutput.Text = "$" & decFare.ToString("f2")
    End Sub
End Class
