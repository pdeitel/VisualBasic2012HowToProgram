<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavingsCalculator
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
      Me.startingAmountLabel = New System.Windows.Forms.Label()
      Me.startingAmountTextBox = New System.Windows.Forms.TextBox()
      Me.savingsLabel = New System.Windows.Forms.Label()
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.resultLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'startingAmountLabel
      '
      Me.startingAmountLabel.AutoSize = True
      Me.startingAmountLabel.Location = New System.Drawing.Point(12, 17)
      Me.startingAmountLabel.Name = "startingAmountLabel"
      Me.startingAmountLabel.Size = New System.Drawing.Size(110, 13)
      Me.startingAmountLabel.TabIndex = 0
      Me.startingAmountLabel.Text = "Enter starting amount:"
      '
      'startingAmountTextBox
      '
      Me.startingAmountTextBox.Location = New System.Drawing.Point(132, 14)
      Me.startingAmountTextBox.Name = "startingAmountTextBox"
      Me.startingAmountTextBox.Size = New System.Drawing.Size(100, 20)
      Me.startingAmountTextBox.TabIndex = 1
      '
      'savingsLabel
      '
      Me.savingsLabel.AutoSize = True
      Me.savingsLabel.Location = New System.Drawing.Point(12, 46)
      Me.savingsLabel.Name = "savingsLabel"
      Me.savingsLabel.Size = New System.Drawing.Size(114, 13)
      Me.savingsLabel.TabIndex = 2
      Me.savingsLabel.Text = "Amount after one year:"
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(238, 12)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(75, 23)
      Me.calculateButton.TabIndex = 4
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'resultLabel
      '
      Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.resultLabel.Location = New System.Drawing.Point(132, 41)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(100, 23)
      Me.resultLabel.TabIndex = 5
      Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'SavingsCalculator
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(326, 77)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.savingsLabel)
      Me.Controls.Add(Me.startingAmountTextBox)
      Me.Controls.Add(Me.startingAmountLabel)
      Me.Name = "SavingsCalculator"
      Me.Text = "Savings Calculator"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents startingAmountLabel As System.Windows.Forms.Label
   Friend WithEvents startingAmountTextBox As System.Windows.Forms.TextBox
   Friend WithEvents savingsLabel As System.Windows.Forms.Label
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents resultLabel As System.Windows.Forms.Label

End Class
