Public Class Electricity
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Create the variables for the device, wattage, hours used, and price per kWh used
        Dim strDevice As String
        Dim decWattage, decHoursUse, decPricePerKWh, decCost As Decimal

        ' Get the device name, wattage, hours used, and price per kWh used
        strDevice = CStr(txtDevice.Text)

        decWattage = CDec(txtWattage.Text)
        decHoursUse = CDec(txtHoursUse.Text)
        decPricePerKWh = CDec(txtPricePerKWh.Text)

        ' Calculate the Cost 
        decCost = (decWattage * decHoursUse * decPricePerKWh) / 100000

        'Output the results
        lblOutput.Text = decCost.ToString("f2")

    End Sub

    Private Sub txtDevice_TextChanged(sender As Object, e As EventArgs) Handles txtDevice.TextChanged

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

End Class
