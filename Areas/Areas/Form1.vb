Public Class Form1



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Set the variables
        Dim decRadius, decArea, decHeight, decLength As Decimal

        ' to empty the label output for the next selection
        lblOutput.Text = ""

        ' to select the input box that will appear
        If radCircle.Checked = True Then
            decRadius = InputBox("Enter the radius of the circle.", "Input Needed",,,)
            decArea = 3.14 * decRadius ^ 2
        ElseIf radTriangle.Checked = True Then
            decLength = InputBox("Enter the length of the triangle.", "Input Needed",,,)
            decHeight = InputBox("Enter the height of the triangle.", "Input Needed",,,)
            decArea = (1 / 2) * decLength * decHeight
        ElseIf radSquare.Checked = True Then
            decLength = InputBox("Enter the length of the square.", "Input Needed",,,)
            decArea = decLength ^ 2
        ElseIf radRectangle.Checked = True Then
            decLength = InputBox("Enter the length of the rectangle.", "Input Needed",,,)
            decHeight = InputBox("Enter the height of the rectangle.", "Input Needed",,,)
            decArea = decLength * decHeight
        End If

        ' the show the results 
        lblOutput.Text = decArea.ToString("f2")
    End Sub
End Class
