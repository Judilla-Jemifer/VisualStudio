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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radRectangle = New System.Windows.Forms.RadioButton()
        Me.radSquare = New System.Windows.Forms.RadioButton()
        Me.radTriangle = New System.Windows.Forms.RadioButton()
        Me.radCircle = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRectangle)
        Me.GroupBox1.Controls.Add(Me.radSquare)
        Me.GroupBox1.Controls.Add(Me.radTriangle)
        Me.GroupBox1.Controls.Add(Me.radCircle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your figure"
        '
        'radRectangle
        '
        Me.radRectangle.AutoSize = True
        Me.radRectangle.Location = New System.Drawing.Point(21, 95)
        Me.radRectangle.Name = "radRectangle"
        Me.radRectangle.Size = New System.Drawing.Size(89, 22)
        Me.radRectangle.TabIndex = 3
        Me.radRectangle.TabStop = True
        Me.radRectangle.Text = "Rectange"
        Me.radRectangle.UseVisualStyleBackColor = True
        '
        'radSquare
        '
        Me.radSquare.AutoSize = True
        Me.radSquare.Location = New System.Drawing.Point(21, 68)
        Me.radSquare.Name = "radSquare"
        Me.radSquare.Size = New System.Drawing.Size(73, 22)
        Me.radSquare.TabIndex = 2
        Me.radSquare.TabStop = True
        Me.radSquare.Text = "Square"
        Me.radSquare.UseVisualStyleBackColor = True
        '
        'radTriangle
        '
        Me.radTriangle.AutoSize = True
        Me.radTriangle.Location = New System.Drawing.Point(21, 44)
        Me.radTriangle.Name = "radTriangle"
        Me.radTriangle.Size = New System.Drawing.Size(78, 22)
        Me.radTriangle.TabIndex = 1
        Me.radTriangle.TabStop = True
        Me.radTriangle.Text = "Triangle"
        Me.radTriangle.UseVisualStyleBackColor = True
        '
        'radCircle
        '
        Me.radCircle.AutoSize = True
        Me.radCircle.Location = New System.Drawing.Point(21, 20)
        Me.radCircle.Name = "radCircle"
        Me.radCircle.Size = New System.Drawing.Size(64, 22)
        Me.radCircle.TabIndex = 0
        Me.radCircle.TabStop = True
        Me.radCircle.Text = "Circle"
        Me.radCircle.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(86, 185)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(164, 35)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate the area"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(54, 241)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(219, 42)
        Me.lblOutput.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 292)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Areas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radRectangle As RadioButton
    Friend WithEvents radSquare As RadioButton
    Friend WithEvents radTriangle As RadioButton
    Friend WithEvents radCircle As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
End Class
