<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeRESTXML
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
      Me.submitButton = New System.Windows.Forms.Button()
      Me.textLabel = New System.Windows.Forms.Label()
      Me.textBox = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'submitButton
      '
      Me.submitButton.Location = New System.Drawing.Point(77, 41)
      Me.submitButton.Name = "submitButton"
      Me.submitButton.Size = New System.Drawing.Size(75, 23)
      Me.submitButton.TabIndex = 18
      Me.submitButton.Text = "Submit"
      Me.submitButton.UseVisualStyleBackColor = True
      '
      'textLabel
      '
      Me.textLabel.AutoSize = True
      Me.textLabel.Location = New System.Drawing.Point(12, 15)
      Me.textLabel.Name = "textLabel"
      Me.textLabel.Size = New System.Drawing.Size(87, 13)
      Me.textLabel.TabIndex = 17
      Me.textLabel.Text = "Enter your name:"
      '
      'textBox
      '
      Me.textBox.Location = New System.Drawing.Point(115, 12)
      Me.textBox.Name = "textBox"
      Me.textBox.Size = New System.Drawing.Size(100, 20)
      Me.textBox.TabIndex = 16
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(227, 74)
      Me.Controls.Add(Me.submitButton)
      Me.Controls.Add(Me.textLabel)
      Me.Controls.Add(Me.textBox)
      Me.Name = "Form1"
      Me.Text = "Welcome Client"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents submitButton As System.Windows.Forms.Button
   Friend WithEvents textLabel As System.Windows.Forms.Label
   Friend WithEvents textBox As System.Windows.Forms.TextBox

End Class
