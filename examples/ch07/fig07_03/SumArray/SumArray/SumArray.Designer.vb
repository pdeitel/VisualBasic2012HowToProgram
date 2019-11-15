<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SumArray
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
      Me.totalLabel = New System.Windows.Forms.Label()
      Me.sumLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'totalLabel
      '
      Me.totalLabel.AutoSize = True
      Me.totalLabel.Location = New System.Drawing.Point(12, 13)
      Me.totalLabel.Name = "totalLabel"
      Me.totalLabel.Size = New System.Drawing.Size(120, 15)
      Me.totalLabel.TabIndex = 0
      Me.totalLabel.Text = "Total of exam grades:"
      '
      'sumLabel
      '
      Me.sumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.sumLabel.Location = New System.Drawing.Point(138, 9)
      Me.sumLabel.Name = "sumLabel"
      Me.sumLabel.Size = New System.Drawing.Size(42, 23)
      Me.sumLabel.TabIndex = 1
      Me.sumLabel.Text = "Label2"
      Me.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'SumArray
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(195, 42)
      Me.Controls.Add(Me.sumLabel)
      Me.Controls.Add(Me.totalLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "SumArray"
      Me.Text = "Sum Array"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents totalLabel As System.Windows.Forms.Label
   Friend WithEvents sumLabel As System.Windows.Forms.Label

End Class
