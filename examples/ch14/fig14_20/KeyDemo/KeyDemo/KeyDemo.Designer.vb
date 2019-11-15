<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyDemo
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
      Me.charLabel = New System.Windows.Forms.Label()
      Me.keyInfoLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'charLabel
      '
      Me.charLabel.AutoSize = True
      Me.charLabel.Location = New System.Drawing.Point(12, 9)
      Me.charLabel.Name = "charLabel"
      Me.charLabel.Size = New System.Drawing.Size(54, 13)
      Me.charLabel.TabIndex = 0
      Me.charLabel.Text = "Just press"
      '
      'keyInfoLabel
      '
      Me.keyInfoLabel.Location = New System.Drawing.Point(12, 35)
      Me.keyInfoLabel.Name = "keyInfoLabel"
      Me.keyInfoLabel.Size = New System.Drawing.Size(172, 87)
      Me.keyInfoLabel.TabIndex = 1
      Me.keyInfoLabel.Text = "a key..."
      '
      'KeyDemo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(189, 133)
      Me.Controls.Add(Me.keyInfoLabel)
      Me.Controls.Add(Me.charLabel)
      Me.Name = "KeyDemo"
      Me.Text = "Key Demo"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents charLabel As System.Windows.Forms.Label
   Friend WithEvents keyInfoLabel As System.Windows.Forms.Label

End Class
