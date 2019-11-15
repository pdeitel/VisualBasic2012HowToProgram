<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Power
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
      Me.baseLabel = New System.Windows.Forms.Label()
      Me.baseTextBox = New System.Windows.Forms.TextBox()
      Me.exponentTextBox = New System.Windows.Forms.TextBox()
      Me.exponentLabel = New System.Windows.Forms.Label()
      Me.calculatePowerButton = New System.Windows.Forms.Button()
      Me.outputLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'resultLabel
      '
      Me.resultLabel.AutoSize = True
      Me.resultLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.resultLabel.Location = New System.Drawing.Point(197, 49)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(42, 15)
      Me.resultLabel.TabIndex = 12
      Me.resultLabel.Text = "Result:"
      '
      'baseLabel
      '
      Me.baseLabel.AutoSize = True
      Me.baseLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.baseLabel.Location = New System.Drawing.Point(12, 17)
      Me.baseLabel.Name = "baseLabel"
      Me.baseLabel.Size = New System.Drawing.Size(34, 15)
      Me.baseLabel.TabIndex = 7
      Me.baseLabel.Text = "Base:"
      '
      'baseTextBox
      '
      Me.baseTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.baseTextBox.Location = New System.Drawing.Point(74, 12)
      Me.baseTextBox.Multiline = True
      Me.baseTextBox.Name = "baseTextBox"
      Me.baseTextBox.Size = New System.Drawing.Size(100, 23)
      Me.baseTextBox.TabIndex = 8
      '
      'exponentTextBox
      '
      Me.exponentTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.exponentTextBox.Location = New System.Drawing.Point(74, 45)
      Me.exponentTextBox.Multiline = True
      Me.exponentTextBox.Name = "exponentTextBox"
      Me.exponentTextBox.Size = New System.Drawing.Size(100, 23)
      Me.exponentTextBox.TabIndex = 10
      '
      'exponentLabel
      '
      Me.exponentLabel.AutoSize = True
      Me.exponentLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.exponentLabel.Location = New System.Drawing.Point(12, 48)
      Me.exponentLabel.Name = "exponentLabel"
      Me.exponentLabel.Size = New System.Drawing.Size(56, 15)
      Me.exponentLabel.TabIndex = 9
      Me.exponentLabel.Text = "Exponent"
      '
      'calculatePowerButton
      '
      Me.calculatePowerButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.calculatePowerButton.Location = New System.Drawing.Point(200, 12)
      Me.calculatePowerButton.Name = "calculatePowerButton"
      Me.calculatePowerButton.Size = New System.Drawing.Size(145, 23)
      Me.calculatePowerButton.TabIndex = 11
      Me.calculatePowerButton.Text = "Calculate Power"
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.outputLabel.Location = New System.Drawing.Point(245, 45)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(100, 23)
      Me.outputLabel.TabIndex = 13
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Power
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(357, 79)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.baseLabel)
      Me.Controls.Add(Me.baseTextBox)
      Me.Controls.Add(Me.exponentTextBox)
      Me.Controls.Add(Me.exponentLabel)
      Me.Controls.Add(Me.calculatePowerButton)
      Me.Controls.Add(Me.outputLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Power"
      Me.Text = "Power"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents baseLabel As System.Windows.Forms.Label
   Friend WithEvents baseTextBox As System.Windows.Forms.TextBox
   Friend WithEvents exponentTextBox As System.Windows.Forms.TextBox
   Friend WithEvents exponentLabel As System.Windows.Forms.Label
   Friend WithEvents calculatePowerButton As System.Windows.Forms.Button
   Friend WithEvents outputLabel As System.Windows.Forms.Label

End Class
