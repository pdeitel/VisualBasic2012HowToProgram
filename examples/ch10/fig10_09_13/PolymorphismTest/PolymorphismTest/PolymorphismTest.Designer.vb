<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolymorphismTest
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
      Me.outputTextBox1 = New System.Windows.Forms.TextBox()
      Me.outputTextBox2 = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'outputTextBox1
      '
      Me.outputTextBox1.Location = New System.Drawing.Point(12, 12)
      Me.outputTextBox1.Multiline = True
      Me.outputTextBox1.Name = "outputTextBox1"
      Me.outputTextBox1.Size = New System.Drawing.Size(260, 296)
      Me.outputTextBox1.TabIndex = 0
      '
      'outputTextBox2
      '
      Me.outputTextBox2.Location = New System.Drawing.Point(278, 12)
      Me.outputTextBox2.Multiline = True
      Me.outputTextBox2.Name = "outputTextBox2"
      Me.outputTextBox2.Size = New System.Drawing.Size(260, 296)
      Me.outputTextBox2.TabIndex = 1
      '
      'PolymorphismTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(550, 320)
      Me.Controls.Add(Me.outputTextBox2)
      Me.Controls.Add(Me.outputTextBox1)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "PolymorphismTest"
      Me.Text = "Polymorphism Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents outputTextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents outputTextBox2 As System.Windows.Forms.TextBox

End Class
