<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Electricity
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
        Me.txtDevice = New System.Windows.Forms.TextBox()
        Me.txtWattage = New System.Windows.Forms.TextBox()
        Me.txtHoursUse = New System.Windows.Forms.TextBox()
        Me.txtPricePerKWh = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDevice
        '
        Me.txtDevice.Location = New System.Drawing.Point(170, 36)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.Size = New System.Drawing.Size(100, 20)
        Me.txtDevice.TabIndex = 0
        '
        'txtWattage
        '
        Me.txtWattage.Location = New System.Drawing.Point(170, 73)
        Me.txtWattage.Name = "txtWattage"
        Me.txtWattage.Size = New System.Drawing.Size(100, 20)
        Me.txtWattage.TabIndex = 1
        '
        'txtHoursUse
        '
        Me.txtHoursUse.Location = New System.Drawing.Point(170, 109)
        Me.txtHoursUse.Name = "txtHoursUse"
        Me.txtHoursUse.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursUse.TabIndex = 2
        '
        'txtPricePerKWh
        '
        Me.txtPricePerKWh.Location = New System.Drawing.Point(170, 148)
        Me.txtPricePerKWh.Name = "txtPricePerKWh"
        Me.txtPricePerKWh.Size = New System.Drawing.Size(100, 20)
        Me.txtPricePerKWh.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(94, 195)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Device:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Wattage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hours Used:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Price per kWh used:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cost (in dollars):"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.CausesValidation = False
        Me.lblOutput.Location = New System.Drawing.Point(170, 245)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(100, 28)
        Me.lblOutput.TabIndex = 10
        '
        'Electricity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 336)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPricePerKWh)
        Me.Controls.Add(Me.txtHoursUse)
        Me.Controls.Add(Me.txtWattage)
        Me.Controls.Add(Me.txtDevice)
        Me.Name = "Electricity"
        Me.Text = "Electricity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDevice As TextBox
    Friend WithEvents txtWattage As TextBox
    Friend WithEvents txtHoursUse As TextBox
    Friend WithEvents txtPricePerKWh As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOutput As Label
End Class
