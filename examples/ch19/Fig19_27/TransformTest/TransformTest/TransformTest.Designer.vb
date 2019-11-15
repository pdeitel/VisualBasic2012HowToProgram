<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransformTest
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
      Me.consoleTextBox = New System.Windows.Forms.TextBox()
      Me.transformButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'consoleTextBox
      '
      Me.consoleTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.consoleTextBox.Location = New System.Drawing.Point(12, 48)
      Me.consoleTextBox.Multiline = True
      Me.consoleTextBox.Name = "consoleTextBox"
      Me.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.consoleTextBox.Size = New System.Drawing.Size(309, 206)
      Me.consoleTextBox.TabIndex = 3
      '
      'transformButton
      '
      Me.transformButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.transformButton.Location = New System.Drawing.Point(12, 12)
      Me.transformButton.Name = "transformButton"
      Me.transformButton.Size = New System.Drawing.Size(309, 30)
      Me.transformButton.TabIndex = 2
      Me.transformButton.Text = "Transform XML"
      Me.transformButton.UseVisualStyleBackColor = True
      '
      'TransformTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(333, 266)
      Me.Controls.Add(Me.consoleTextBox)
      Me.Controls.Add(Me.transformButton)
      Me.Name = "TransformTest"
      Me.Text = "Transform Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents consoleTextBox As System.Windows.Forms.TextBox
   Friend WithEvents transformButton As System.Windows.Forms.Button

End Class
