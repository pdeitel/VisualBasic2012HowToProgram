<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DivideByZeroTest
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
      Me.outputLabel = New System.Windows.Forms.Label()
      Me.divideButton = New System.Windows.Forms.Button()
      Me.denominatorTextBox = New System.Windows.Forms.TextBox()
      Me.numeratorTextBox = New System.Windows.Forms.TextBox()
      Me.denominatorLabel = New System.Windows.Forms.Label()
      Me.numeratorLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(117, 81)
      Me.outputLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(100, 23)
      Me.outputLabel.TabIndex = 29
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'divideButton
      '
      Me.divideButton.Location = New System.Drawing.Point(13, 81)
      Me.divideButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.divideButton.Name = "divideButton"
      Me.divideButton.Size = New System.Drawing.Size(93, 23)
      Me.divideButton.TabIndex = 28
      Me.divideButton.Text = "Click to Divide"
      '
      'denominatorTextBox
      '
      Me.denominatorTextBox.Location = New System.Drawing.Point(117, 39)
      Me.denominatorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.denominatorTextBox.Name = "denominatorTextBox"
      Me.denominatorTextBox.Size = New System.Drawing.Size(100, 20)
      Me.denominatorTextBox.TabIndex = 27
      '
      'numeratorTextBox
      '
      Me.numeratorTextBox.Location = New System.Drawing.Point(117, 9)
      Me.numeratorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.numeratorTextBox.Name = "numeratorTextBox"
      Me.numeratorTextBox.Size = New System.Drawing.Size(100, 20)
      Me.numeratorTextBox.TabIndex = 26
      '
      'denominatorLabel
      '
      Me.denominatorLabel.AutoSize = True
      Me.denominatorLabel.Location = New System.Drawing.Point(13, 42)
      Me.denominatorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.denominatorLabel.Name = "denominatorLabel"
      Me.denominatorLabel.Size = New System.Drawing.Size(96, 13)
      Me.denominatorLabel.TabIndex = 25
      Me.denominatorLabel.Text = "Enter denominator:"
      '
      'numeratorLabel
      '
      Me.numeratorLabel.AutoSize = True
      Me.numeratorLabel.Location = New System.Drawing.Point(13, 12)
      Me.numeratorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.numeratorLabel.Name = "numeratorLabel"
      Me.numeratorLabel.Size = New System.Drawing.Size(85, 13)
      Me.numeratorLabel.TabIndex = 24
      Me.numeratorLabel.Text = "Enter numerator:"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(233, 117)
      Me.Controls.Add(Me.outputLabel)
      Me.Controls.Add(Me.divideButton)
      Me.Controls.Add(Me.denominatorTextBox)
      Me.Controls.Add(Me.numeratorTextBox)
      Me.Controls.Add(Me.denominatorLabel)
      Me.Controls.Add(Me.numeratorLabel)
      Me.Name = "Form1"
      Me.Text = "Divide By Zero"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents outputLabel As System.Windows.Forms.Label
   Private WithEvents divideButton As System.Windows.Forms.Button
   Private WithEvents denominatorTextBox As System.Windows.Forms.TextBox
   Private WithEvents numeratorTextBox As System.Windows.Forms.TextBox
   Private WithEvents denominatorLabel As System.Windows.Forms.Label
   Private WithEvents numeratorLabel As System.Windows.Forms.Label

End Class
