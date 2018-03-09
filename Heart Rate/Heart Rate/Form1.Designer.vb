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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnComputeTHR = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtRestingHeartRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resting Heart Rate:"
        '
        'btnComputeTHR
        '
        Me.btnComputeTHR.Location = New System.Drawing.Point(109, 123)
        Me.btnComputeTHR.Name = "btnComputeTHR"
        Me.btnComputeTHR.Size = New System.Drawing.Size(132, 32)
        Me.btnComputeTHR.TabIndex = 2
        Me.btnComputeTHR.Text = "Compute THR"
        Me.btnComputeTHR.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(40, 168)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(259, 55)
        Me.lblOutput.TabIndex = 3
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(196, 30)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(59, 20)
        Me.txtAge.TabIndex = 4
        '
        'txtRestingHeartRate
        '
        Me.txtRestingHeartRate.Location = New System.Drawing.Point(196, 68)
        Me.txtRestingHeartRate.Name = "txtRestingHeartRate"
        Me.txtRestingHeartRate.Size = New System.Drawing.Size(59, 20)
        Me.txtRestingHeartRate.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 261)
        Me.Controls.Add(Me.txtRestingHeartRate)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnComputeTHR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Heart Rate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnComputeTHR As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtRestingHeartRate As TextBox
End Class
