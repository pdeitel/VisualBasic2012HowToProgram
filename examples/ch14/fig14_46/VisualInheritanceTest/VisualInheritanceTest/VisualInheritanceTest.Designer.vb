<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualInheritanceTest
   Inherits VisualInheritance.VisualInheritanceForm

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
      Me.aboutButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'aboutButton
      '
      Me.aboutButton.Location = New System.Drawing.Point(90, 99)
      Me.aboutButton.Name = "aboutButton"
      Me.aboutButton.Size = New System.Drawing.Size(145, 23)
      Me.aboutButton.TabIndex = 21
      Me.aboutButton.Text = "About this Program"
      Me.aboutButton.UseVisualStyleBackColor = True
      '
      'VisualInheritanceTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(326, 173)
      Me.Controls.Add(Me.aboutButton)
      Me.Name = "VisualInheritanceTest"
      Me.Text = "Form1"
      Me.Controls.SetChildIndex(Me.aboutButton, 0)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents aboutButton As System.Windows.Forms.Button

End Class
