Public Class Currency
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Create the variables for pounds, shillings, and pence

        Dim intPounds, intShillings, intPence, intPenceOutput As Integer

        ' Get the pence
        intPence = CInt(txtPence.Text)



        ' Calculate the Cost 
        intPounds = Fix(intPence / (12 * 20))
        intShillings = Fix((intPence - intPounds * 20 * 12) / 12)
        intPenceOutput = intPence - (intPounds * 20 * 12) - (intShillings * 12)


        'Output the results
        lblPounds.Text = intPounds
        lblShillings.Text = intShillings
        lblPence.Text = intPenceOutput
    End Sub
End Class
