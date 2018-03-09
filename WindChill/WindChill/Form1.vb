Public Class WindChill


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Create the variables for the temperature and windspeed in fanhrenheit and celsius

        Dim decFahrenheit, decWindSpeed, decWindSpeedF, decWindSpeedC As Decimal

        ' Get the device name, wattage, hours used, and price per kWh used


        decFahrenheit = CDec(txtFahrenheit.Text)
        decWindSpeed = CDec(txtWindSpeed.Text)


        ' Calculate the Wind Chill
        decWindSpeedF = 35.74 + (0.6215 * decFahrenheit) - (35.75 * decWindSpeed ^ 0.16) + (0.4275 * decFahrenheit * decWindSpeed ^ 0.16)
        decWindSpeedC = (decWindSpeedF - 32) * 5 / 9
        'Output the results
        lblFahrenheit.Text = decWindSpeedF.ToString("f2")
        lblCelsius.Text = decWindSpeedC.ToString("f2")
    End Sub
End Class
