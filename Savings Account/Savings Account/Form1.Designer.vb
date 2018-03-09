<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavingsAccount
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
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.lblWithdrawal = New System.Windows.Forms.Label()
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.AutoSize = True
        Me.lblCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentBalance.Location = New System.Drawing.Point(77, 48)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(118, 18)
        Me.lblCurrentBalance.TabIndex = 0
        Me.lblCurrentBalance.Text = "Current Balance:"
        '
        'lblWithdrawal
        '
        Me.lblWithdrawal.AutoSize = True
        Me.lblWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithdrawal.Location = New System.Drawing.Point(110, 89)
        Me.lblWithdrawal.Name = "lblWithdrawal"
        Me.lblWithdrawal.Size = New System.Drawing.Size(85, 18)
        Me.lblWithdrawal.TabIndex = 1
        Me.lblWithdrawal.Text = "Withdrawal:"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentBalance.Location = New System.Drawing.Point(220, 40)
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Size = New System.Drawing.Size(100, 26)
        Me.txtCurrentBalance.TabIndex = 2
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWithdrawal.Location = New System.Drawing.Point(220, 81)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(100, 26)
        Me.txtWithdrawal.TabIndex = 3
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(64, 133)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(277, 42)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute New Balance"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(64, 188)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(293, 53)
        Me.lblOutput.TabIndex = 5
        '
        'SavingsAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 261)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtWithdrawal)
        Me.Controls.Add(Me.txtCurrentBalance)
        Me.Controls.Add(Me.lblWithdrawal)
        Me.Controls.Add(Me.lblCurrentBalance)
        Me.Name = "SavingsAccount"
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents lblWithdrawal As Label
    Friend WithEvents txtCurrentBalance As TextBox
    Friend WithEvents txtWithdrawal As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblOutput As Label
End Class
