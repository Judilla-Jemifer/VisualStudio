Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' setting the variables here and the constants
        Dim decAmount, decReward As Decimal
        Const tenPercent = 0.1
        Const fivePercent = 0.05
        Const onePercent = 0.01
        Const tenPercentMax = 7500
        Const fivePercentMax = 1250

        ' getting the input
        decAmount = CDec(txtAmount.Text)

        ' setting the conditions
        If decAmount <= 75000 Then
            decReward = 75000 * tenPercent
        ElseIf decAmount <= 100000 Then
            decReward = tenPercentMax + ((decAmount - 75000) * fivePercent)
        ElseIf decAmount > 100000 Then
            decReward = tenPercentMax + fivePercentMax + ((decAmount - 100000) * onePercent)
        End If

        ' limit the rewards to 50000
        If decReward > 50000 Then
            decReward = 50000
        End If

        ' show the results in the output label
        lblOutput.Text = "$" & decReward.ToString("N")
    End Sub
End Class
