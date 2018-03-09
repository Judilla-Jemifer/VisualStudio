<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.grpSAT = New System.Windows.Forms.GroupBox()
        Me.radSAT12 = New System.Windows.Forms.RadioButton()
        Me.radSAT11 = New System.Windows.Forms.RadioButton()
        Me.radSAT10 = New System.Windows.Forms.RadioButton()
        Me.radSAT6 = New System.Windows.Forms.RadioButton()
        Me.radSAT0 = New System.Windows.Forms.RadioButton()
        Me.grpHSQuality = New System.Windows.Forms.GroupBox()
        Me.radHSQ10 = New System.Windows.Forms.RadioButton()
        Me.radHSQ8 = New System.Windows.Forms.RadioButton()
        Me.radHSQ6 = New System.Windows.Forms.RadioButton()
        Me.radHSQ4 = New System.Windows.Forms.RadioButton()
        Me.radHSQ2 = New System.Windows.Forms.RadioButton()
        Me.radHSQ0 = New System.Windows.Forms.RadioButton()
        Me.grpCurriculum = New System.Windows.Forms.GroupBox()
        Me.radCur8 = New System.Windows.Forms.RadioButton()
        Me.radCur6 = New System.Windows.Forms.RadioButton()
        Me.radCur4 = New System.Windows.Forms.RadioButton()
        Me.radCur2 = New System.Windows.Forms.RadioButton()
        Me.radCur0 = New System.Windows.Forms.RadioButton()
        Me.radCurMinus2 = New System.Windows.Forms.RadioButton()
        Me.radCurMinus4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpGeography = New System.Windows.Forms.GroupBox()
        Me.chkGeoOut = New System.Windows.Forms.CheckBox()
        Me.chkGeoResident10 = New System.Windows.Forms.CheckBox()
        Me.grpEssay = New System.Windows.Forms.GroupBox()
        Me.radEssayOutstanding3 = New System.Windows.Forms.RadioButton()
        Me.radEssayExcellent2 = New System.Windows.Forms.RadioButton()
        Me.radEssayVGood1 = New System.Windows.Forms.RadioButton()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.radMiscProvost20 = New System.Windows.Forms.RadioButton()
        Me.radMiscAthlete20 = New System.Windows.Forms.RadioButton()
        Me.radMiscMenNursing5 = New System.Windows.Forms.RadioButton()
        Me.radMiscSocio20 = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpAlumni = New System.Windows.Forms.GroupBox()
        Me.chkAlumOther1 = New System.Windows.Forms.CheckBox()
        Me.chkAlumLegacy4 = New System.Windows.Forms.CheckBox()
        Me.grpLeadership = New System.Windows.Forms.GroupBox()
        Me.chkLeadNatl5 = New System.Windows.Forms.CheckBox()
        Me.chkLeadRegional2 = New System.Windows.Forms.CheckBox()
        Me.chkLeadState1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpSAT.SuspendLayout()
        Me.grpHSQuality.SuspendLayout()
        Me.grpCurriculum.SuspendLayout()
        Me.grpGeography.SuspendLayout()
        Me.grpEssay.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.grpAlumni.SuspendLayout()
        Me.grpLeadership.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GPA Score"
        '
        'lblGPA
        '
        Me.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPA.Location = New System.Drawing.Point(196, 10)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(49, 20)
        Me.lblGPA.TabIndex = 1
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(124, 10)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(54, 20)
        Me.txtGPA.TabIndex = 2
        '
        'grpSAT
        '
        Me.grpSAT.Controls.Add(Me.radSAT12)
        Me.grpSAT.Controls.Add(Me.radSAT11)
        Me.grpSAT.Controls.Add(Me.radSAT10)
        Me.grpSAT.Controls.Add(Me.radSAT6)
        Me.grpSAT.Controls.Add(Me.radSAT0)
        Me.grpSAT.Location = New System.Drawing.Point(12, 67)
        Me.grpSAT.Name = "grpSAT"
        Me.grpSAT.Size = New System.Drawing.Size(132, 152)
        Me.grpSAT.TabIndex = 3
        Me.grpSAT.TabStop = False
        Me.grpSAT.Text = "SAT"
        '
        'radSAT12
        '
        Me.radSAT12.AutoSize = True
        Me.radSAT12.Location = New System.Drawing.Point(7, 116)
        Me.radSAT12.Name = "radSAT12"
        Me.radSAT12.Size = New System.Drawing.Size(97, 17)
        Me.radSAT12.TabIndex = 4
        Me.radSAT12.TabStop = True
        Me.radSAT12.Text = "1360-1600 [12]"
        Me.radSAT12.UseVisualStyleBackColor = True
        '
        'radSAT11
        '
        Me.radSAT11.AutoSize = True
        Me.radSAT11.Location = New System.Drawing.Point(7, 92)
        Me.radSAT11.Name = "radSAT11"
        Me.radSAT11.Size = New System.Drawing.Size(97, 17)
        Me.radSAT11.TabIndex = 3
        Me.radSAT11.TabStop = True
        Me.radSAT11.Text = "1200-1350 [11]"
        Me.radSAT11.UseVisualStyleBackColor = True
        '
        'radSAT10
        '
        Me.radSAT10.AutoSize = True
        Me.radSAT10.Location = New System.Drawing.Point(7, 68)
        Me.radSAT10.Name = "radSAT10"
        Me.radSAT10.Size = New System.Drawing.Size(97, 17)
        Me.radSAT10.TabIndex = 2
        Me.radSAT10.TabStop = True
        Me.radSAT10.Text = "1010-1190 [10]"
        Me.radSAT10.UseVisualStyleBackColor = True
        '
        'radSAT6
        '
        Me.radSAT6.AutoSize = True
        Me.radSAT6.Location = New System.Drawing.Point(7, 44)
        Me.radSAT6.Name = "radSAT6"
        Me.radSAT6.Size = New System.Drawing.Size(85, 17)
        Me.radSAT6.TabIndex = 1
        Me.radSAT6.TabStop = True
        Me.radSAT6.Text = "930-1000 [6]"
        Me.radSAT6.UseVisualStyleBackColor = True
        '
        'radSAT0
        '
        Me.radSAT0.AutoSize = True
        Me.radSAT0.Location = New System.Drawing.Point(7, 20)
        Me.radSAT0.Name = "radSAT0"
        Me.radSAT0.Size = New System.Drawing.Size(79, 17)
        Me.radSAT0.TabIndex = 0
        Me.radSAT0.TabStop = True
        Me.radSAT0.Text = "400-920 [0]"
        Me.radSAT0.UseVisualStyleBackColor = True
        '
        'grpHSQuality
        '
        Me.grpHSQuality.Controls.Add(Me.radHSQ10)
        Me.grpHSQuality.Controls.Add(Me.radHSQ8)
        Me.grpHSQuality.Controls.Add(Me.radHSQ6)
        Me.grpHSQuality.Controls.Add(Me.radHSQ4)
        Me.grpHSQuality.Controls.Add(Me.radHSQ2)
        Me.grpHSQuality.Controls.Add(Me.radHSQ0)
        Me.grpHSQuality.Location = New System.Drawing.Point(166, 67)
        Me.grpHSQuality.Name = "grpHSQuality"
        Me.grpHSQuality.Size = New System.Drawing.Size(160, 152)
        Me.grpHSQuality.TabIndex = 4
        Me.grpHSQuality.TabStop = False
        Me.grpHSQuality.Text = "High School Quality"
        '
        'radHSQ10
        '
        Me.radHSQ10.AutoSize = True
        Me.radHSQ10.Location = New System.Drawing.Point(86, 116)
        Me.radHSQ10.Name = "radHSQ10"
        Me.radHSQ10.Size = New System.Drawing.Size(52, 17)
        Me.radHSQ10.TabIndex = 5
        Me.radHSQ10.TabStop = True
        Me.radHSQ10.Text = "5 [10]"
        Me.radHSQ10.UseVisualStyleBackColor = True
        '
        'radHSQ8
        '
        Me.radHSQ8.AutoSize = True
        Me.radHSQ8.Location = New System.Drawing.Point(86, 68)
        Me.radHSQ8.Name = "radHSQ8"
        Me.radHSQ8.Size = New System.Drawing.Size(46, 17)
        Me.radHSQ8.TabIndex = 4
        Me.radHSQ8.TabStop = True
        Me.radHSQ8.Text = "4 [8]"
        Me.radHSQ8.UseVisualStyleBackColor = True
        '
        'radHSQ6
        '
        Me.radHSQ6.AutoSize = True
        Me.radHSQ6.Location = New System.Drawing.Point(86, 19)
        Me.radHSQ6.Name = "radHSQ6"
        Me.radHSQ6.Size = New System.Drawing.Size(46, 17)
        Me.radHSQ6.TabIndex = 3
        Me.radHSQ6.TabStop = True
        Me.radHSQ6.Text = "3 [6]"
        Me.radHSQ6.UseVisualStyleBackColor = True
        '
        'radHSQ4
        '
        Me.radHSQ4.AutoSize = True
        Me.radHSQ4.Location = New System.Drawing.Point(13, 116)
        Me.radHSQ4.Name = "radHSQ4"
        Me.radHSQ4.Size = New System.Drawing.Size(46, 17)
        Me.radHSQ4.TabIndex = 2
        Me.radHSQ4.TabStop = True
        Me.radHSQ4.Text = "2 [4]"
        Me.radHSQ4.UseVisualStyleBackColor = True
        '
        'radHSQ2
        '
        Me.radHSQ2.AutoSize = True
        Me.radHSQ2.Location = New System.Drawing.Point(13, 68)
        Me.radHSQ2.Name = "radHSQ2"
        Me.radHSQ2.Size = New System.Drawing.Size(46, 17)
        Me.radHSQ2.TabIndex = 1
        Me.radHSQ2.TabStop = True
        Me.radHSQ2.Text = "1 [2]"
        Me.radHSQ2.UseVisualStyleBackColor = True
        '
        'radHSQ0
        '
        Me.radHSQ0.AutoSize = True
        Me.radHSQ0.Location = New System.Drawing.Point(13, 20)
        Me.radHSQ0.Name = "radHSQ0"
        Me.radHSQ0.Size = New System.Drawing.Size(46, 17)
        Me.radHSQ0.TabIndex = 0
        Me.radHSQ0.TabStop = True
        Me.radHSQ0.Text = "0 [0]"
        Me.radHSQ0.UseVisualStyleBackColor = True
        '
        'grpCurriculum
        '
        Me.grpCurriculum.Controls.Add(Me.radCur8)
        Me.grpCurriculum.Controls.Add(Me.radCur6)
        Me.grpCurriculum.Controls.Add(Me.radCur4)
        Me.grpCurriculum.Controls.Add(Me.radCur2)
        Me.grpCurriculum.Controls.Add(Me.radCur0)
        Me.grpCurriculum.Controls.Add(Me.radCurMinus2)
        Me.grpCurriculum.Controls.Add(Me.radCurMinus4)
        Me.grpCurriculum.Location = New System.Drawing.Point(345, 67)
        Me.grpCurriculum.Name = "grpCurriculum"
        Me.grpCurriculum.Size = New System.Drawing.Size(164, 152)
        Me.grpCurriculum.TabIndex = 5
        Me.grpCurriculum.TabStop = False
        Me.grpCurriculum.Text = "Difficulty of Curriculum"
        '
        'radCur8
        '
        Me.radCur8.AutoSize = True
        Me.radCur8.Location = New System.Drawing.Point(86, 80)
        Me.radCur8.Name = "radCur8"
        Me.radCur8.Size = New System.Drawing.Size(46, 17)
        Me.radCur8.TabIndex = 6
        Me.radCur8.TabStop = True
        Me.radCur8.Text = "4 [8]"
        Me.radCur8.UseVisualStyleBackColor = True
        '
        'radCur6
        '
        Me.radCur6.AutoSize = True
        Me.radCur6.Location = New System.Drawing.Point(86, 51)
        Me.radCur6.Name = "radCur6"
        Me.radCur6.Size = New System.Drawing.Size(46, 17)
        Me.radCur6.TabIndex = 5
        Me.radCur6.TabStop = True
        Me.radCur6.Text = "3 [6]"
        Me.radCur6.UseVisualStyleBackColor = True
        '
        'radCur4
        '
        Me.radCur4.AutoSize = True
        Me.radCur4.Location = New System.Drawing.Point(86, 20)
        Me.radCur4.Name = "radCur4"
        Me.radCur4.Size = New System.Drawing.Size(46, 17)
        Me.radCur4.TabIndex = 4
        Me.radCur4.TabStop = True
        Me.radCur4.Text = "2 [4]"
        Me.radCur4.UseVisualStyleBackColor = True
        '
        'radCur2
        '
        Me.radCur2.AutoSize = True
        Me.radCur2.Location = New System.Drawing.Point(7, 116)
        Me.radCur2.Name = "radCur2"
        Me.radCur2.Size = New System.Drawing.Size(46, 17)
        Me.radCur2.TabIndex = 3
        Me.radCur2.TabStop = True
        Me.radCur2.Text = "1 [2]"
        Me.radCur2.UseVisualStyleBackColor = True
        '
        'radCur0
        '
        Me.radCur0.AutoSize = True
        Me.radCur0.Location = New System.Drawing.Point(7, 81)
        Me.radCur0.Name = "radCur0"
        Me.radCur0.Size = New System.Drawing.Size(46, 17)
        Me.radCur0.TabIndex = 2
        Me.radCur0.TabStop = True
        Me.radCur0.Text = "0 [0]"
        Me.radCur0.UseVisualStyleBackColor = True
        '
        'radCurMinus2
        '
        Me.radCurMinus2.AutoSize = True
        Me.radCurMinus2.Location = New System.Drawing.Point(6, 49)
        Me.radCurMinus2.Name = "radCurMinus2"
        Me.radCurMinus2.Size = New System.Drawing.Size(52, 17)
        Me.radCurMinus2.TabIndex = 1
        Me.radCurMinus2.TabStop = True
        Me.radCurMinus2.Text = "-1 [-2]"
        Me.radCurMinus2.UseVisualStyleBackColor = True
        '
        'radCurMinus4
        '
        Me.radCurMinus4.AutoSize = True
        Me.radCurMinus4.Location = New System.Drawing.Point(7, 20)
        Me.radCurMinus4.Name = "radCurMinus4"
        Me.radCurMinus4.Size = New System.Drawing.Size(52, 17)
        Me.radCurMinus4.TabIndex = 0
        Me.radCurMinus4.TabStop = True
        Me.radCurMinus4.Text = "-2 [-4]"
        Me.radCurMinus4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(694, 10)
        Me.Label3.TabIndex = 6
        '
        'grpGeography
        '
        Me.grpGeography.Controls.Add(Me.chkGeoOut)
        Me.grpGeography.Controls.Add(Me.chkGeoResident10)
        Me.grpGeography.Location = New System.Drawing.Point(12, 271)
        Me.grpGeography.Name = "grpGeography"
        Me.grpGeography.Size = New System.Drawing.Size(200, 100)
        Me.grpGeography.TabIndex = 7
        Me.grpGeography.TabStop = False
        Me.grpGeography.Text = "Geography"
        '
        'chkGeoOut
        '
        Me.chkGeoOut.AutoSize = True
        Me.chkGeoOut.Location = New System.Drawing.Point(6, 45)
        Me.chkGeoOut.Name = "chkGeoOut"
        Me.chkGeoOut.Size = New System.Drawing.Size(81, 17)
        Me.chkGeoOut.TabIndex = 1
        Me.chkGeoOut.Text = "Out of state"
        Me.chkGeoOut.UseVisualStyleBackColor = True
        '
        'chkGeoResident10
        '
        Me.chkGeoResident10.AutoSize = True
        Me.chkGeoResident10.Location = New System.Drawing.Point(7, 19)
        Me.chkGeoResident10.Name = "chkGeoResident10"
        Me.chkGeoResident10.Size = New System.Drawing.Size(117, 17)
        Me.chkGeoResident10.TabIndex = 0
        Me.chkGeoResident10.Text = "State Resident [10]"
        Me.chkGeoResident10.UseVisualStyleBackColor = True
        '
        'grpEssay
        '
        Me.grpEssay.Controls.Add(Me.radEssayOutstanding3)
        Me.grpEssay.Controls.Add(Me.radEssayExcellent2)
        Me.grpEssay.Controls.Add(Me.radEssayVGood1)
        Me.grpEssay.Location = New System.Drawing.Point(232, 271)
        Me.grpEssay.Name = "grpEssay"
        Me.grpEssay.Size = New System.Drawing.Size(200, 100)
        Me.grpEssay.TabIndex = 8
        Me.grpEssay.TabStop = False
        Me.grpEssay.Text = "Essay"
        '
        'radEssayOutstanding3
        '
        Me.radEssayOutstanding3.AutoSize = True
        Me.radEssayOutstanding3.Location = New System.Drawing.Point(7, 68)
        Me.radEssayOutstanding3.Name = "radEssayOutstanding3"
        Me.radEssayOutstanding3.Size = New System.Drawing.Size(97, 17)
        Me.radEssayOutstanding3.TabIndex = 2
        Me.radEssayOutstanding3.TabStop = True
        Me.radEssayOutstanding3.Text = "Outstanding [3]"
        Me.radEssayOutstanding3.UseVisualStyleBackColor = True
        '
        'radEssayExcellent2
        '
        Me.radEssayExcellent2.AutoSize = True
        Me.radEssayExcellent2.Location = New System.Drawing.Point(7, 44)
        Me.radEssayExcellent2.Name = "radEssayExcellent2"
        Me.radEssayExcellent2.Size = New System.Drawing.Size(83, 17)
        Me.radEssayExcellent2.TabIndex = 1
        Me.radEssayExcellent2.TabStop = True
        Me.radEssayExcellent2.Text = "Excellent [2]"
        Me.radEssayExcellent2.UseVisualStyleBackColor = True
        '
        'radEssayVGood1
        '
        Me.radEssayVGood1.AutoSize = True
        Me.radEssayVGood1.Location = New System.Drawing.Point(7, 20)
        Me.radEssayVGood1.Name = "radEssayVGood1"
        Me.radEssayVGood1.Size = New System.Drawing.Size(90, 17)
        Me.radEssayVGood1.TabIndex = 0
        Me.radEssayVGood1.TabStop = True
        Me.radEssayVGood1.Text = "Very Good [1]"
        Me.radEssayVGood1.UseVisualStyleBackColor = True
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.radMiscProvost20)
        Me.grpMisc.Controls.Add(Me.radMiscAthlete20)
        Me.grpMisc.Controls.Add(Me.radMiscMenNursing5)
        Me.grpMisc.Controls.Add(Me.radMiscSocio20)
        Me.grpMisc.Location = New System.Drawing.Point(458, 271)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(243, 227)
        Me.grpMisc.TabIndex = 9
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Miscellaneous"
        '
        'radMiscProvost20
        '
        Me.radMiscProvost20.AutoSize = True
        Me.radMiscProvost20.Location = New System.Drawing.Point(10, 180)
        Me.radMiscProvost20.Name = "radMiscProvost20"
        Me.radMiscProvost20.Size = New System.Drawing.Size(139, 17)
        Me.radMiscProvost20.TabIndex = 3
        Me.radMiscProvost20.TabStop = True
        Me.radMiscProvost20.Text = "Provost's Discretion [20]"
        Me.radMiscProvost20.UseVisualStyleBackColor = True
        '
        'radMiscAthlete20
        '
        Me.radMiscAthlete20.AutoSize = True
        Me.radMiscAthlete20.Location = New System.Drawing.Point(10, 127)
        Me.radMiscAthlete20.Name = "radMiscAthlete20"
        Me.radMiscAthlete20.Size = New System.Drawing.Size(136, 17)
        Me.radMiscAthlete20.TabIndex = 2
        Me.radMiscAthlete20.TabStop = True
        Me.radMiscAthlete20.Text = "Scholarship athlete [20]"
        Me.radMiscAthlete20.UseVisualStyleBackColor = True
        '
        'radMiscMenNursing5
        '
        Me.radMiscMenNursing5.AutoSize = True
        Me.radMiscMenNursing5.Location = New System.Drawing.Point(10, 70)
        Me.radMiscMenNursing5.Name = "radMiscMenNursing5"
        Me.radMiscMenNursing5.Size = New System.Drawing.Size(111, 17)
        Me.radMiscMenNursing5.TabIndex = 1
        Me.radMiscMenNursing5.TabStop = True
        Me.radMiscMenNursing5.Text = "Men in Nursing [5]"
        Me.radMiscMenNursing5.UseVisualStyleBackColor = True
        '
        'radMiscSocio20
        '
        Me.radMiscSocio20.AutoSize = True
        Me.radMiscSocio20.Location = New System.Drawing.Point(10, 20)
        Me.radMiscSocio20.Name = "radMiscSocio20"
        Me.radMiscSocio20.Size = New System.Drawing.Size(188, 17)
        Me.radMiscSocio20.TabIndex = 0
        Me.radMiscSocio20.TabStop = True
        Me.radMiscSocio20.Text = "Socioeconomic Disadvantage [20]"
        Me.radMiscSocio20.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(530, 10)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(171, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Total Score"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(530, 86)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(171, 90)
        Me.lblOutput.TabIndex = 11
        '
        'grpAlumni
        '
        Me.grpAlumni.Controls.Add(Me.chkAlumOther1)
        Me.grpAlumni.Controls.Add(Me.chkAlumLegacy4)
        Me.grpAlumni.Location = New System.Drawing.Point(12, 398)
        Me.grpAlumni.Name = "grpAlumni"
        Me.grpAlumni.Size = New System.Drawing.Size(200, 100)
        Me.grpAlumni.TabIndex = 12
        Me.grpAlumni.TabStop = False
        Me.grpAlumni.Text = "Alumni"
        '
        'chkAlumOther1
        '
        Me.chkAlumOther1.AutoSize = True
        Me.chkAlumOther1.Location = New System.Drawing.Point(11, 54)
        Me.chkAlumOther1.Name = "chkAlumOther1"
        Me.chkAlumOther1.Size = New System.Drawing.Size(178, 17)
        Me.chkAlumOther1.TabIndex = 1
        Me.chkAlumOther1.Text = "Other (grandparents, siblings) [1]"
        Me.chkAlumOther1.UseVisualStyleBackColor = True
        '
        'chkAlumLegacy4
        '
        Me.chkAlumLegacy4.AutoSize = True
        Me.chkAlumLegacy4.Location = New System.Drawing.Point(11, 20)
        Me.chkAlumLegacy4.Name = "chkAlumLegacy4"
        Me.chkAlumLegacy4.Size = New System.Drawing.Size(181, 17)
        Me.chkAlumLegacy4.TabIndex = 0
        Me.chkAlumLegacy4.Text = "Legacy (parents, stepparents) [4]"
        Me.chkAlumLegacy4.UseVisualStyleBackColor = True
        '
        'grpLeadership
        '
        Me.grpLeadership.Controls.Add(Me.chkLeadNatl5)
        Me.grpLeadership.Controls.Add(Me.chkLeadRegional2)
        Me.grpLeadership.Controls.Add(Me.chkLeadState1)
        Me.grpLeadership.Location = New System.Drawing.Point(232, 398)
        Me.grpLeadership.Name = "grpLeadership"
        Me.grpLeadership.Size = New System.Drawing.Size(200, 100)
        Me.grpLeadership.TabIndex = 13
        Me.grpLeadership.TabStop = False
        Me.grpLeadership.Text = "Leadership and Service"
        '
        'chkLeadNatl5
        '
        Me.chkLeadNatl5.AutoSize = True
        Me.chkLeadNatl5.Location = New System.Drawing.Point(7, 68)
        Me.chkLeadNatl5.Name = "chkLeadNatl5"
        Me.chkLeadNatl5.Size = New System.Drawing.Size(80, 17)
        Me.chkLeadNatl5.TabIndex = 2
        Me.chkLeadNatl5.Text = "National [5]"
        Me.chkLeadNatl5.UseVisualStyleBackColor = True
        '
        'chkLeadRegional2
        '
        Me.chkLeadRegional2.AutoSize = True
        Me.chkLeadRegional2.Location = New System.Drawing.Point(7, 44)
        Me.chkLeadRegional2.Name = "chkLeadRegional2"
        Me.chkLeadRegional2.Size = New System.Drawing.Size(83, 17)
        Me.chkLeadRegional2.TabIndex = 1
        Me.chkLeadRegional2.Text = "Regional [2]"
        Me.chkLeadRegional2.UseVisualStyleBackColor = True
        '
        'chkLeadState1
        '
        Me.chkLeadState1.AutoSize = True
        Me.chkLeadState1.Location = New System.Drawing.Point(7, 20)
        Me.chkLeadState1.Name = "chkLeadState1"
        Me.chkLeadState1.Size = New System.Drawing.Size(66, 17)
        Me.chkLeadState1.TabIndex = 0
        Me.chkLeadState1.Text = "State [1]"
        Me.chkLeadState1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Maximum of 40 points"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 532)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpLeadership)
        Me.Controls.Add(Me.grpAlumni)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.grpEssay)
        Me.Controls.Add(Me.grpGeography)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpCurriculum)
        Me.Controls.Add(Me.grpHSQuality)
        Me.Controls.Add(Me.grpSAT)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "University Admissions Point System"
        Me.grpSAT.ResumeLayout(False)
        Me.grpSAT.PerformLayout()
        Me.grpHSQuality.ResumeLayout(False)
        Me.grpHSQuality.PerformLayout()
        Me.grpCurriculum.ResumeLayout(False)
        Me.grpCurriculum.PerformLayout()
        Me.grpGeography.ResumeLayout(False)
        Me.grpGeography.PerformLayout()
        Me.grpEssay.ResumeLayout(False)
        Me.grpEssay.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.grpAlumni.ResumeLayout(False)
        Me.grpAlumni.PerformLayout()
        Me.grpLeadership.ResumeLayout(False)
        Me.grpLeadership.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents grpSAT As GroupBox
    Friend WithEvents radSAT12 As RadioButton
    Friend WithEvents radSAT11 As RadioButton
    Friend WithEvents radSAT10 As RadioButton
    Friend WithEvents radSAT6 As RadioButton
    Friend WithEvents radSAT0 As RadioButton
    Friend WithEvents grpHSQuality As GroupBox
    Friend WithEvents radHSQ10 As RadioButton
    Friend WithEvents radHSQ8 As RadioButton
    Friend WithEvents radHSQ6 As RadioButton
    Friend WithEvents radHSQ4 As RadioButton
    Friend WithEvents radHSQ2 As RadioButton
    Friend WithEvents radHSQ0 As RadioButton
    Friend WithEvents grpCurriculum As GroupBox
    Friend WithEvents radCur8 As RadioButton
    Friend WithEvents radCur6 As RadioButton
    Friend WithEvents radCur4 As RadioButton
    Friend WithEvents radCur2 As RadioButton
    Friend WithEvents radCur0 As RadioButton
    Friend WithEvents radCurMinus2 As RadioButton
    Friend WithEvents radCurMinus4 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents grpGeography As GroupBox
    Friend WithEvents chkGeoOut As CheckBox
    Friend WithEvents chkGeoResident10 As CheckBox
    Friend WithEvents grpEssay As GroupBox
    Friend WithEvents radEssayOutstanding3 As RadioButton
    Friend WithEvents radEssayExcellent2 As RadioButton
    Friend WithEvents radEssayVGood1 As RadioButton
    Friend WithEvents grpMisc As GroupBox
    Friend WithEvents radMiscProvost20 As RadioButton
    Friend WithEvents radMiscAthlete20 As RadioButton
    Friend WithEvents radMiscMenNursing5 As RadioButton
    Friend WithEvents radMiscSocio20 As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents grpAlumni As GroupBox
    Friend WithEvents chkAlumOther1 As CheckBox
    Friend WithEvents chkAlumLegacy4 As CheckBox
    Friend WithEvents grpLeadership As GroupBox
    Friend WithEvents chkLeadNatl5 As CheckBox
    Friend WithEvents chkLeadRegional2 As CheckBox
    Friend WithEvents chkLeadState1 As CheckBox
    Friend WithEvents Label5 As Label
End Class
