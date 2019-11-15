<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factorial
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
      Me.numberTextBox = New System.Windows.Forms.TextBox()
      Me.factorialResultLabel = New System.Windows.Forms.Label()
      Me.factorialLabel = New System.Windows.Forms.Label()
      Me.numberLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(100, 80)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(100, 23)
      Me.calculateButton.TabIndex = 6
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'numberTextBox
      '
      Me.numberTextBox.Location = New System.Drawing.Point(100, 12)
      Me.numberTextBox.Name = "numberTextBox"
      Me.numberTextBox.Size = New System.Drawing.Size(100, 23)
      Me.numberTextBox.TabIndex = 5
      '
      'factorialResultLabel
      '
      Me.factorialResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.factorialResultLabel.Location = New System.Drawing.Point(100, 44)
      Me.factorialResultLabel.Name = "factorialResultLabel"
      Me.factorialResultLabel.Size = New System.Drawing.Size(100, 23)
      Me.factorialResultLabel.TabIndex = 9
      Me.factorialResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'factorialLabel
      '
      Me.factorialLabel.AutoSize = True
      Me.factorialLabel.Location = New System.Drawing.Point(12, 48)
      Me.factorialLabel.Name = "factorialLabel"
      Me.factorialLabel.Size = New System.Drawing.Size(55, 15)
      Me.factorialLabel.TabIndex = 8
      Me.factorialLabel.Text = "Factorial:"
      Me.factorialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'numberLabel
      '
      Me.numberLabel.AutoSize = True
      Me.numberLabel.Location = New System.Drawing.Point(12, 15)
      Me.numberLabel.Name = "numberLabel"
      Me.numberLabel.Size = New System.Drawing.Size(82, 15)
      Me.numberLabel.TabIndex = 7
      Me.numberLabel.Text = "Enter number:"
      Me.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Factorial
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(215, 115)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.numberTextBox)
      Me.Controls.Add(Me.factorialResultLabel)
      Me.Controls.Add(Me.factorialLabel)
      Me.Controls.Add(Me.numberLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Factorial"
      Me.Text = "Factorial"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents numberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents factorialResultLabel As System.Windows.Forms.Label
   Friend WithEvents factorialLabel As System.Windows.Forms.Label
   Friend WithEvents numberLabel As System.Windows.Forms.Label

End Class
