Public Class SavingsAccount

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ' Create the variables for balance and withdrawal

        Dim decCurrentBalance, decWithdrawal, decNewBalance As Decimal
        Dim message As String

        ' Get the current balance and withdrawal

        decCurrentBalance = CDec(txtCurrentBalance.Text)
        decWithdrawal = CDec(txtWithdrawal.Text)

        ' Calculate the New Balance 

        If decWithdrawal > decCurrentBalance Then
            message = "Withdrawal denied"

        Else
            decNewBalance = decCurrentBalance - decWithdrawal
            message = "New balance is " & decNewBalance.ToString("f2")

        End If
        If decNewBalance < 150 And decCurrentBalance > decWithdrawal Then

            message = "New balance is " & decNewBalance.ToString("f2") & "." & Environment.NewLine & "Balance below $150"
        End If
        'Output the results
        lblOutput.Text = message
    End Sub
End Class
