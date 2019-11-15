<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimationDemo
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
      Me.logoPictureBox = New System.Windows.Forms.PictureBox()
      Me.animationTimer = New System.Windows.Forms.Timer()
      Me.SuspendLayout()
      '
      'logoPictureBox
      '
      Me.logoPictureBox.Location = New System.Drawing.Point(12, 12)
      Me.logoPictureBox.Name = "logoPictureBox"
      Me.logoPictureBox.Size = New System.Drawing.Size(196, 112)
      Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
      Me.logoPictureBox.TabIndex = 0
      Me.logoPictureBox.TabStop = False
      '
      'animationTimer
      '
      Me.animationTimer.Enabled = True
      Me.animationTimer.Interval = 50
      '
      'AnimationDemo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(221, 137)
      Me.Controls.Add(Me.logoPictureBox)
      Me.Name = "AnimationDemo"
      Me.Text = "AnimationDemo"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents animationTimer As System.Windows.Forms.Timer

End Class
