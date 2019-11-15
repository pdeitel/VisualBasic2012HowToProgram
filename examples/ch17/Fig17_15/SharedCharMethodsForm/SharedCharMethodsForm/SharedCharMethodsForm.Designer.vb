<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SharedCharMethodsForm
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
      Me.outputTextBox = New System.Windows.Forms.TextBox()
      Me.analyzeButton = New System.Windows.Forms.Button()
      Me.inputTextBox = New System.Windows.Forms.TextBox()
      Me.enterLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'outputTextBox
      '
      Me.outputTextBox.Location = New System.Drawing.Point(12, 73)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.Size = New System.Drawing.Size(224, 147)
      Me.outputTextBox.TabIndex = 11
      '
      'analyzeButton
      '
      Me.analyzeButton.Location = New System.Drawing.Point(64, 44)
      Me.analyzeButton.Name = "analyzeButton"
      Me.analyzeButton.Size = New System.Drawing.Size(120, 23)
      Me.analyzeButton.TabIndex = 10
      Me.analyzeButton.Text = "Analyze Character"
      '
      'inputTextBox
      '
      Me.inputTextBox.Location = New System.Drawing.Point(120, 14)
      Me.inputTextBox.Name = "inputTextBox"
      Me.inputTextBox.Size = New System.Drawing.Size(116, 23)
      Me.inputTextBox.TabIndex = 9
      '
      'enterLabel
      '
      Me.enterLabel.AutoSize = True
      Me.enterLabel.Location = New System.Drawing.Point(12, 17)
      Me.enterLabel.Name = "enterLabel"
      Me.enterLabel.Size = New System.Drawing.Size(98, 15)
      Me.enterLabel.TabIndex = 8
      Me.enterLabel.Text = "Enter a character:"
      '
      'SharedCharMethodsForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(248, 232)
      Me.Controls.Add(Me.outputTextBox)
      Me.Controls.Add(Me.analyzeButton)
      Me.Controls.Add(Me.inputTextBox)
      Me.Controls.Add(Me.enterLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "SharedCharMethodsForm"
      Me.Text = "Shared Char Methods"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents analyzeButton As System.Windows.Forms.Button
   Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents enterLabel As System.Windows.Forms.Label

End Class
