<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SquareRootForm
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
      Me.squareRootButton = New System.Windows.Forms.Button()
      Me.inputTextBox = New System.Windows.Forms.TextBox()
      Me.InputLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(12, 79)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(256, 29)
      Me.outputLabel.TabIndex = 19
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'squareRootButton
      '
      Me.squareRootButton.Location = New System.Drawing.Point(52, 44)
      Me.squareRootButton.Name = "squareRootButton"
      Me.squareRootButton.Size = New System.Drawing.Size(176, 27)
      Me.squareRootButton.TabIndex = 18
      Me.squareRootButton.Text = "Calculate Square Root"
      '
      'inputTextBox
      '
      Me.inputTextBox.Location = New System.Drawing.Point(149, 14)
      Me.inputTextBox.Name = "inputTextBox"
      Me.inputTextBox.Size = New System.Drawing.Size(116, 23)
      Me.inputTextBox.TabIndex = 17
      '
      'InputLabel
      '
      Me.InputLabel.AutoSize = True
      Me.InputLabel.Location = New System.Drawing.Point(16, 17)
      Me.InputLabel.Name = "InputLabel"
      Me.InputLabel.Size = New System.Drawing.Size(127, 15)
      Me.InputLabel.TabIndex = 16
      Me.InputLabel.Text = "Please enter a number:"
      '
      'SquareRootTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(280, 121)
      Me.Controls.Add(Me.outputLabel)
      Me.Controls.Add(Me.squareRootButton)
      Me.Controls.Add(Me.inputTextBox)
      Me.Controls.Add(Me.InputLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "SquareRootTest"
      Me.Text = "Computing the Square Root"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents outputLabel As System.Windows.Forms.Label
   Private WithEvents squareRootButton As System.Windows.Forms.Button
   Private WithEvents inputTextBox As System.Windows.Forms.TextBox
   Private WithEvents InputLabel As System.Windows.Forms.Label

End Class
