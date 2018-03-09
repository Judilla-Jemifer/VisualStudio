Public Class Form1
    Private Sub txtGPA_TextChanged(sender As Object, e As EventArgs) Handles txtGPA.TextChanged

        ' set variables
        Dim decGPA As Decimal

        ' empty the label boxes
        lblOutput.Text = ""
        lblGPA.Text = ""

        ' get the input
        decGPA = CDec(txtGPA.Text)

        ' show message for the GPA/ compute score*20
        If decGPA < 2.0 Then
            lblOutput.Text = "Not admitted – low GPA"
        ElseIf decGPA > 4.3 Then
            MsgBox("The GPA is not correct")
        Else
            lblGPA.Text = Int(decGPA * 20)
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' set variables
        Dim intTotalScore, intScore, intLimitedScore As Integer
        Dim strTotalScore, strMessage As String

        ' get the score from GPA to include in the total
        intTotalScore = CInt(lblGPA.Text)
        ' set initial score to zero for limited score of 40 points
        intLimitedScore = 0


        ' ===========Scores Limited to 40 Points Here ==========================

        If chkGeoResident10.Checked = True Then
            intScore = 10
        Else intScore = 0
        End If
        intLimitedScore += intScore
        If chkGeoOut.Checked = True Then
            intScore = 0
        Else intScore = 0
        End If
        intLimitedScore += intScore



        If radEssayVGood1.Checked = True Then
            intScore = 1
        ElseIf radEssayExcellent2.Checked = True Then
            intScore = 2
        ElseIf radEssayOutstanding3.Checked = True Then
            intScore = 3
        Else intScore = 0
        End If
        intLimitedScore += intScore


        If radMiscSocio20.Checked = True Then
            intScore = 20
        ElseIf radMiscMenNursing5.Checked = True Then
            intScore = 5
        ElseIf radMiscAthlete20.Checked = True Then
            intScore = 20
        ElseIf radMiscProvost20.Checked = True Then
            intScore = 20
        Else intScore = 0
        End If
        intLimitedScore += intScore


        If chkAlumLegacy4.Checked = True Then
            intScore = 4
        Else intScore = 0
        End If
        intLimitedScore += intScore
        If chkAlumOther1.Checked = True Then
            intScore = 1
        Else intScore = 0
        End If
        intLimitedScore += intScore


        If chkLeadState1.Checked = True Then
            intScore = 1
        Else intScore = 0
        End If
        intLimitedScore += intScore

        If chkLeadRegional2.Checked = True Then
            intScore = 2
        Else intScore = 0
        End If
        intLimitedScore += intScore

        If chkLeadNatl5.Checked = True Then
            intScore = 5
        Else intScore = 0
        End If
        intLimitedScore += intScore


        If intLimitedScore <= 40 Then
            intTotalScore += intLimitedScore
        Else intTotalScore += 40
        End If

        ' ==============Scores without Limit Here ==================================

        If radSAT0.Checked = True Then
            intScore = 0
        ElseIf radSAT6.Checked = True Then
            intScore = 6
        ElseIf radSAT10.Checked = True Then
            intScore = 10
        ElseIf radSAT11.Checked = True Then
            intScore = 11
        ElseIf radSAT12.Checked = True Then
            intScore = 12
        Else intScore = 0
        End If

        intTotalScore += intScore

        If radHSQ0.Checked = True Then
            intScore = 0
        ElseIf radHSQ2.Checked = True Then
            intScore = 2
        ElseIf radHSQ4.Checked = True Then
            intScore = 4
        ElseIf radHSQ6.Checked = True Then
            intScore = 6
        ElseIf radHSQ8.Checked = True Then
            intScore = 8
        ElseIf radHSQ10.Checked = True Then
            intScore = 10
        Else intScore = 0
        End If

        intTotalScore += intScore

        If radCurMinus4.Checked = True Then
            intScore = -4
        ElseIf radCurMinus2.Checked = True Then
            intScore = -2
        ElseIf radCur0.Checked = True Then
            intScore = 0
        ElseIf radCur2.Checked = True Then
            intScore = 2
        ElseIf radCur4.Checked = True Then
            intScore = 4
        ElseIf radCur6.Checked = True Then
            intScore = 6
        ElseIf radCur8.Checked = True Then
            intScore = 8
        Else intScore = 0
        End If

        intTotalScore += intScore

        strTotalScore = "Total Score:" & intTotalScore

        If intTotalScore >= 100 Then
            strMessage = "Admitted"
        Else
            strMessage = "Not admitted"
        End If

        lblOutput.Text = strTotalScore & vbNewLine & strMessage


    End Sub
End Class
