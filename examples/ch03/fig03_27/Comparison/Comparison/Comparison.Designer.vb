<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comparison
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
      Me.number1Label = New System.Windows.Forms.Label()
      Me.number1TextBox = New System.Windows.Forms.TextBox()
      Me.number2Label = New System.Windows.Forms.Label()
      Me.number2TextBox = New System.Windows.Forms.TextBox()
      Me.resultLabel = New System.Windows.Forms.Label()
      Me.resultTextBox = New System.Windows.Forms.TextBox()
      Me.compareButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'number1Label
      '
      Me.number1Label.AutoSize = True
      Me.number1Label.Location = New System.Drawing.Point(14, 14)
      Me.number1Label.Name = "number1Label"
      Me.number1Label.Size = New System.Drawing.Size(100, 15)
      Me.number1Label.TabIndex = 0
      Me.number1Label.Text = "Enter first integer:"
      '
      'number1TextBox
      '
      Me.number1TextBox.Location = New System.Drawing.Point(17, 32)
      Me.number1TextBox.Name = "number1TextBox"
      Me.number1TextBox.Size = New System.Drawing.Size(116, 23)
      Me.number1TextBox.TabIndex = 1
      '
      'number2Label
      '
      Me.number2Label.AutoSize = True
      Me.number2Label.Location = New System.Drawing.Point(14, 63)
      Me.number2Label.Name = "number2Label"
      Me.number2Label.Size = New System.Drawing.Size(118, 15)
      Me.number2Label.TabIndex = 2
      Me.number2Label.Text = "Enter second integer:"
      '
      'number2TextBox
      '
      Me.number2TextBox.Location = New System.Drawing.Point(17, 82)
      Me.number2TextBox.Name = "number2TextBox"
      Me.number2TextBox.Size = New System.Drawing.Size(116, 23)
      Me.number2TextBox.TabIndex = 3
      '
      'resultLabel
      '
      Me.resultLabel.AutoSize = True
      Me.resultLabel.Location = New System.Drawing.Point(14, 133)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(187, 15)
      Me.resultLabel.TabIndex = 5
      Me.resultLabel.Text = "Results of comparing two integers"
      '
      'resultTextBox
      '
      Me.resultTextBox.Location = New System.Drawing.Point(17, 151)
      Me.resultTextBox.Multiline = True
      Me.resultTextBox.Name = "resultTextBox"
      Me.resultTextBox.Size = New System.Drawing.Size(227, 57)
      Me.resultTextBox.TabIndex = 6
      '
      'compareButton
      '
      Me.compareButton.Location = New System.Drawing.Point(157, 80)
      Me.compareButton.Name = "compareButton"
      Me.compareButton.Size = New System.Drawing.Size(87, 27)
      Me.compareButton.TabIndex = 4
      Me.compareButton.Text = "Compare"
      Me.compareButton.UseVisualStyleBackColor = True
      '
      'Comparison
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(259, 223)
      Me.Controls.Add(Me.compareButton)
      Me.Controls.Add(Me.resultTextBox)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.number2TextBox)
      Me.Controls.Add(Me.number2Label)
      Me.Controls.Add(Me.number1TextBox)
      Me.Controls.Add(Me.number1Label)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Comparison"
      Me.Text = "Comparison"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents number1Label As System.Windows.Forms.Label
   Friend WithEvents number1TextBox As System.Windows.Forms.TextBox
   Friend WithEvents number2Label As System.Windows.Forms.Label
   Friend WithEvents number2TextBox As System.Windows.Forms.TextBox
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents resultTextBox As System.Windows.Forms.TextBox
   Friend WithEvents compareButton As System.Windows.Forms.Button

End Class
