<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScaleImage
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
      Me.heightLabel = New System.Windows.Forms.Label()
      Me.widthLabel = New System.Windows.Forms.Label()
      Me.widthNumericUpDown = New System.Windows.Forms.NumericUpDown()
      Me.heightNumericUpDown = New System.Windows.Forms.NumericUpDown()
      Me.SuspendLayout()
      '
      'heightLabel
      '
      Me.heightLabel.AutoSize = True
      Me.heightLabel.Location = New System.Drawing.Point(418, 53)
      Me.heightLabel.Name = "heightLabel"
      Me.heightLabel.Size = New System.Drawing.Size(46, 15)
      Me.heightLabel.TabIndex = 13
      Me.heightLabel.Text = "Height:"
      '
      'widthLabel
      '
      Me.widthLabel.AutoSize = True
      Me.widthLabel.Location = New System.Drawing.Point(418, 9)
      Me.widthLabel.Name = "widthLabel"
      Me.widthLabel.Size = New System.Drawing.Size(42, 15)
      Me.widthLabel.TabIndex = 11
      Me.widthLabel.Text = "Width:"
      '
      'widthNumericUpDown
      '
      Me.widthNumericUpDown.Location = New System.Drawing.Point(417, 27)
      Me.widthNumericUpDown.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
      Me.widthNumericUpDown.Name = "widthNumericUpDown"
      Me.widthNumericUpDown.Size = New System.Drawing.Size(75, 23)
      Me.widthNumericUpDown.TabIndex = 15
      '
      'heightNumericUpDown
      '
      Me.heightNumericUpDown.Location = New System.Drawing.Point(417, 72)
      Me.heightNumericUpDown.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
      Me.heightNumericUpDown.Name = "heightNumericUpDown"
      Me.heightNumericUpDown.Size = New System.Drawing.Size(75, 23)
      Me.heightNumericUpDown.TabIndex = 16
      '
      'ScaleImage
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(504, 382)
      Me.Controls.Add(Me.heightNumericUpDown)
      Me.Controls.Add(Me.widthNumericUpDown)
      Me.Controls.Add(Me.heightLabel)
      Me.Controls.Add(Me.widthLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "ScaleImage"
      Me.Text = "Scale Image"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents heightLabel As System.Windows.Forms.Label
   Private WithEvents widthLabel As System.Windows.Forms.Label
   Friend WithEvents widthNumericUpDown As System.Windows.Forms.NumericUpDown
   Friend WithEvents heightNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
