<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTimePickerDemo
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
      Me.dropOffLabel = New System.Windows.Forms.Label()
      Me.deliveryLabel = New System.Windows.Forms.Label()
      Me.outputLabel = New System.Windows.Forms.Label()
      Me.dropOffDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.SuspendLayout()
      '
      'dropOffLabel
      '
      Me.dropOffLabel.AutoSize = True
      Me.dropOffLabel.Location = New System.Drawing.Point(24, 9)
      Me.dropOffLabel.Name = "dropOffLabel"
      Me.dropOffLabel.Size = New System.Drawing.Size(76, 13)
      Me.dropOffLabel.TabIndex = 15
      Me.dropOffLabel.Text = "Drop Off Date:"
      '
      'deliveryLabel
      '
      Me.deliveryLabel.AutoSize = True
      Me.deliveryLabel.Location = New System.Drawing.Point(24, 65)
      Me.deliveryLabel.Name = "deliveryLabel"
      Me.deliveryLabel.Size = New System.Drawing.Size(123, 13)
      Me.deliveryLabel.TabIndex = 14
      Me.deliveryLabel.Text = "Estimated Delivery Date:"
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(24, 82)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(200, 23)
      Me.outputLabel.TabIndex = 13
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'dropOffDateTimePicker
      '
      Me.dropOffDateTimePicker.Location = New System.Drawing.Point(24, 25)
      Me.dropOffDateTimePicker.Name = "dropOffDateTimePicker"
      Me.dropOffDateTimePicker.Size = New System.Drawing.Size(200, 20)
      Me.dropOffDateTimePicker.TabIndex = 12
      '
      'DateTimePickerDemo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(249, 122)
      Me.Controls.Add(Me.dropOffLabel)
      Me.Controls.Add(Me.deliveryLabel)
      Me.Controls.Add(Me.outputLabel)
      Me.Controls.Add(Me.dropOffDateTimePicker)
      Me.Name = "DateTimePickerDemo"
      Me.Text = "DateTimePicker Demo"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents dropOffLabel As System.Windows.Forms.Label
   Friend WithEvents deliveryLabel As System.Windows.Forms.Label
   Friend WithEvents outputLabel As System.Windows.Forms.Label
   Friend WithEvents dropOffDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
