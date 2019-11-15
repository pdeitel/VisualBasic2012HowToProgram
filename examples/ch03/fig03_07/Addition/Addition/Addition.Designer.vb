<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addition
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
      Me.addButton = New System.Windows.Forms.Button()
      Me.number2TextBox = New System.Windows.Forms.TextBox()
      Me.number1TextBox = New System.Windows.Forms.TextBox()
      Me.number2Label = New System.Windows.Forms.Label()
      Me.number1Label = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'resultLabel
      '
      Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.resultLabel.Location = New System.Drawing.Point(12, 97)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(251, 31)
      Me.resultLabel.TabIndex = 11
      Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'addButton
      '
      Me.addButton.Location = New System.Drawing.Point(12, 56)
      Me.addButton.Name = "addButton"
      Me.addButton.Size = New System.Drawing.Size(251, 27)
      Me.addButton.TabIndex = 10
      Me.addButton.Text = "Add"
      Me.addButton.UseVisualStyleBackColor = True
      '
      'number2TextBox
      '
      Me.number2TextBox.Location = New System.Drawing.Point(148, 27)
      Me.number2TextBox.Name = "number2TextBox"
      Me.number2TextBox.Size = New System.Drawing.Size(115, 23)
      Me.number2TextBox.TabIndex = 9
      '
      'number1TextBox
      '
      Me.number1TextBox.Location = New System.Drawing.Point(12, 27)
      Me.number1TextBox.Name = "number1TextBox"
      Me.number1TextBox.Size = New System.Drawing.Size(130, 23)
      Me.number1TextBox.TabIndex = 8
      '
      'number2Label
      '
      Me.number2Label.AutoSize = True
      Me.number2Label.Location = New System.Drawing.Point(145, 9)
      Me.number2Label.Name = "number2Label"
      Me.number2Label.Size = New System.Drawing.Size(118, 15)
      Me.number2Label.TabIndex = 7
      Me.number2Label.Text = "Enter second integer:"
      '
      'number1Label
      '
      Me.number1Label.AutoSize = True
      Me.number1Label.Location = New System.Drawing.Point(12, 9)
      Me.number1Label.Name = "number1Label"
      Me.number1Label.Size = New System.Drawing.Size(100, 15)
      Me.number1Label.TabIndex = 6
      Me.number1Label.Text = "Enter first integer:"
      '
      'Addition
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(276, 142)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.addButton)
      Me.Controls.Add(Me.number2TextBox)
      Me.Controls.Add(Me.number1TextBox)
      Me.Controls.Add(Me.number2Label)
      Me.Controls.Add(Me.number1Label)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Addition"
      Me.Text = "Addition"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents number2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents number1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents number2Label As System.Windows.Forms.Label
    Friend WithEvents number1Label As System.Windows.Forms.Label

End Class
