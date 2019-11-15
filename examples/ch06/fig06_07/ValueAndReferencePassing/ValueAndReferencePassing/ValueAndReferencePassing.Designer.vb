<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValueAndReferencePassing
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
      Me.squareLabel = New System.Windows.Forms.Label()
      Me.squareTextBox = New System.Windows.Forms.TextBox()
      Me.squareButton = New System.Windows.Forms.Button()
      Me.outputTextBox = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'squareLabel
      '
      Me.squareLabel.AutoSize = True
      Me.squareLabel.Location = New System.Drawing.Point(79, 15)
      Me.squareLabel.Name = "squareLabel"
      Me.squareLabel.Size = New System.Drawing.Size(120, 15)
      Me.squareLabel.TabIndex = 0
      Me.squareLabel.Text = "Enter value to square:"
      '
      'squareTextBox
      '
      Me.squareTextBox.Location = New System.Drawing.Point(205, 12)
      Me.squareTextBox.Name = "squareTextBox"
      Me.squareTextBox.Size = New System.Drawing.Size(100, 23)
      Me.squareTextBox.TabIndex = 1
      '
      'squareButton
      '
      Me.squareButton.Location = New System.Drawing.Point(311, 12)
      Me.squareButton.Name = "squareButton"
      Me.squareButton.Size = New System.Drawing.Size(75, 23)
      Me.squareButton.TabIndex = 2
      Me.squareButton.Text = "Square"
      Me.squareButton.UseVisualStyleBackColor = True
      '
      'outputTextBox
      '
      Me.outputTextBox.Location = New System.Drawing.Point(15, 42)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.Size = New System.Drawing.Size(437, 264)
      Me.outputTextBox.TabIndex = 3
      '
      'ValueAndReferencePassing
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(464, 318)
      Me.Controls.Add(Me.outputTextBox)
      Me.Controls.Add(Me.squareButton)
      Me.Controls.Add(Me.squareTextBox)
      Me.Controls.Add(Me.squareLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "ValueAndReferencePassing"
      Me.Text = "Passing by Value and by Reference"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents squareLabel As System.Windows.Forms.Label
   Friend WithEvents squareTextBox As System.Windows.Forms.TextBox
   Friend WithEvents squareButton As System.Windows.Forms.Button
   Friend WithEvents outputTextBox As System.Windows.Forms.TextBox

End Class
