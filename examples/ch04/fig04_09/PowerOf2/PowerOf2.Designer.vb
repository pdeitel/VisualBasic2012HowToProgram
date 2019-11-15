<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerOf2
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
      Me.resultLabel = New System.Windows.Forms.Label()
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.exponentTextBox = New System.Windows.Forms.TextBox()
      Me.exponentLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'resultLabel
      '
      Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.resultLabel.Location = New System.Drawing.Point(12, 75)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(237, 72)
      Me.resultLabel.TabIndex = 11
      Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(132, 38)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(117, 23)
      Me.calculateButton.TabIndex = 10
      Me.calculateButton.Text = "Calculate Power of 2"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'exponentTextBox
      '
      Me.exponentTextBox.Location = New System.Drawing.Point(132, 12)
      Me.exponentTextBox.Name = "exponentTextBox"
      Me.exponentTextBox.Size = New System.Drawing.Size(117, 20)
      Me.exponentTextBox.TabIndex = 7
      '
      'exponentLabel
      '
      Me.exponentLabel.AutoSize = True
      Me.exponentLabel.Location = New System.Drawing.Point(9, 15)
      Me.exponentLabel.Name = "exponentLabel"
      Me.exponentLabel.Size = New System.Drawing.Size(117, 13)
      Me.exponentLabel.TabIndex = 6
      Me.exponentLabel.Text = "Enter integer exponent:"
      '
      'PowerOf2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(259, 158)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.exponentTextBox)
      Me.Controls.Add(Me.exponentLabel)
      Me.Name = "PowerOf2"
      Me.Text = "Powers of 2"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents exponentTextBox As System.Windows.Forms.TextBox
   Friend WithEvents exponentLabel As System.Windows.Forms.Label

End Class
