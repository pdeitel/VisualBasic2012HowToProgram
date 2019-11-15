<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MethodOverloading
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
      Me.SuspendLayout()
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(12, 9)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(215, 37)
      Me.outputLabel.TabIndex = 0
      Me.outputLabel.Text = "Label1"
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'MethodOverloading
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(239, 55)
      Me.Controls.Add(Me.outputLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "MethodOverloading"
      Me.Text = "Method Overloading"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents outputLabel As System.Windows.Forms.Label

End Class
