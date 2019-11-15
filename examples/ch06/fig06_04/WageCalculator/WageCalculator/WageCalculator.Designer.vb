<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WageCalculator
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
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.hoursTextBox = New System.Windows.Forms.TextBox()
      Me.wageTextBox = New System.Windows.Forms.TextBox()
      Me.resultLabel = New System.Windows.Forms.Label()
      Me.earningsLabel = New System.Windows.Forms.Label()
      Me.hoursLabel = New System.Windows.Forms.Label()
      Me.wageLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(194, 12)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(82, 23)
      Me.calculateButton.TabIndex = 20
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'hoursTextBox
      '
      Me.hoursTextBox.Location = New System.Drawing.Point(106, 43)
      Me.hoursTextBox.Name = "hoursTextBox"
      Me.hoursTextBox.Size = New System.Drawing.Size(82, 23)
      Me.hoursTextBox.TabIndex = 19
      Me.hoursTextBox.Text = "0"
      '
      'wageTextBox
      '
      Me.wageTextBox.Location = New System.Drawing.Point(106, 12)
      Me.wageTextBox.Name = "wageTextBox"
      Me.wageTextBox.Size = New System.Drawing.Size(82, 23)
      Me.wageTextBox.TabIndex = 18
      Me.wageTextBox.Text = "0"
      '
      'resultLabel
      '
      Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.resultLabel.Location = New System.Drawing.Point(106, 73)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(82, 23)
      Me.resultLabel.TabIndex = 17
      Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'earningsLabel
      '
      Me.earningsLabel.AutoSize = True
      Me.earningsLabel.Location = New System.Drawing.Point(12, 77)
      Me.earningsLabel.Name = "earningsLabel"
      Me.earningsLabel.Size = New System.Drawing.Size(55, 15)
      Me.earningsLabel.TabIndex = 16
      Me.earningsLabel.Text = "Earnings:"
      Me.earningsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'hoursLabel
      '
      Me.hoursLabel.AutoSize = True
      Me.hoursLabel.Location = New System.Drawing.Point(12, 46)
      Me.hoursLabel.Name = "hoursLabel"
      Me.hoursLabel.Size = New System.Drawing.Size(84, 15)
      Me.hoursLabel.TabIndex = 15
      Me.hoursLabel.Text = "Hours worked:"
      Me.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'wageLabel
      '
      Me.wageLabel.AutoSize = True
      Me.wageLabel.Location = New System.Drawing.Point(12, 16)
      Me.wageLabel.Name = "wageLabel"
      Me.wageLabel.Size = New System.Drawing.Size(88, 15)
      Me.wageLabel.TabIndex = 14
      Me.wageLabel.Text = "Wage per hour:"
      Me.wageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'WageCalculator
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(288, 108)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.hoursTextBox)
      Me.Controls.Add(Me.wageTextBox)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.earningsLabel)
      Me.Controls.Add(Me.hoursLabel)
      Me.Controls.Add(Me.wageLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "WageCalculator"
      Me.Text = "Wage Calculator"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents hoursTextBox As System.Windows.Forms.TextBox
   Friend WithEvents wageTextBox As System.Windows.Forms.TextBox
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents earningsLabel As System.Windows.Forms.Label
   Friend WithEvents hoursLabel As System.Windows.Forms.Label
   Friend WithEvents wageLabel As System.Windows.Forms.Label

End Class
