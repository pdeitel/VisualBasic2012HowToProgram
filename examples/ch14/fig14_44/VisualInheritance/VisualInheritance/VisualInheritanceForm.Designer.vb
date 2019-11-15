<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualInheritanceForm
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
      Me.learnMoreButton = New System.Windows.Forms.Button()
      Me.twoLabel = New System.Windows.Forms.Label()
      Me.oneLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'learnMoreButton
      '
      Me.learnMoreButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.learnMoreButton.Location = New System.Drawing.Point(90, 69)
      Me.learnMoreButton.Name = "learnMoreButton"
      Me.learnMoreButton.Size = New System.Drawing.Size(145, 23)
      Me.learnMoreButton.TabIndex = 20
      Me.learnMoreButton.Text = "Learn More"
      '
      'twoLabel
      '
      Me.twoLabel.BackColor = System.Drawing.Color.LightYellow
      Me.twoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.twoLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.twoLabel.ForeColor = System.Drawing.Color.MidnightBlue
      Me.twoLabel.Location = New System.Drawing.Point(12, 134)
      Me.twoLabel.Name = "twoLabel"
      Me.twoLabel.Size = New System.Drawing.Size(300, 25)
      Me.twoLabel.TabIndex = 19
      Me.twoLabel.Text = "Copyright 2014 by Deitel && Associates, Inc."
      Me.twoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'oneLabel
      '
      Me.oneLabel.BackColor = System.Drawing.Color.LightYellow
      Me.oneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.oneLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.oneLabel.ForeColor = System.Drawing.Color.MidnightBlue
      Me.oneLabel.Location = New System.Drawing.Point(12, 9)
      Me.oneLabel.Name = "oneLabel"
      Me.oneLabel.Size = New System.Drawing.Size(300, 47)
      Me.oneLabel.TabIndex = 18
      Me.oneLabel.Text = "Bugs, Bugs, Bugs"
      Me.oneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'VisualInheritanceForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(326, 173)
      Me.Controls.Add(Me.learnMoreButton)
      Me.Controls.Add(Me.twoLabel)
      Me.Controls.Add(Me.oneLabel)
      Me.Name = "VisualInheritanceForm"
      Me.Text = "Visual Inheritance"
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents learnMoreButton As System.Windows.Forms.Button
   Private WithEvents twoLabel As System.Windows.Forms.Label
   Private WithEvents oneLabel As System.Windows.Forms.Label

End Class
