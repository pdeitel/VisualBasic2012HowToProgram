<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollDice
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
      Me.die4PictureBox = New System.Windows.Forms.PictureBox()
      Me.die3PictureBox = New System.Windows.Forms.PictureBox()
      Me.die2PictureBox = New System.Windows.Forms.PictureBox()
      Me.die1PictureBox = New System.Windows.Forms.PictureBox()
      Me.rollButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'die4PictureBox
      '
      Me.die4PictureBox.Location = New System.Drawing.Point(189, 12)
      Me.die4PictureBox.Name = "die4PictureBox"
      Me.die4PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.die4PictureBox.TabIndex = 18
      Me.die4PictureBox.TabStop = False
      '
      'die3PictureBox
      '
      Me.die3PictureBox.Location = New System.Drawing.Point(130, 12)
      Me.die3PictureBox.Name = "die3PictureBox"
      Me.die3PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.die3PictureBox.TabIndex = 17
      Me.die3PictureBox.TabStop = False
      '
      'die2PictureBox
      '
      Me.die2PictureBox.Location = New System.Drawing.Point(71, 12)
      Me.die2PictureBox.Name = "die2PictureBox"
      Me.die2PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.die2PictureBox.TabIndex = 16
      Me.die2PictureBox.TabStop = False
      '
      'die1PictureBox
      '
      Me.die1PictureBox.Location = New System.Drawing.Point(12, 12)
      Me.die1PictureBox.Name = "die1PictureBox"
      Me.die1PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.die1PictureBox.TabIndex = 15
      Me.die1PictureBox.TabStop = False
      '
      'rollButton
      '
      Me.rollButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.rollButton.Location = New System.Drawing.Point(64, 71)
      Me.rollButton.Name = "rollButton"
      Me.rollButton.Size = New System.Drawing.Size(125, 26)
      Me.rollButton.TabIndex = 14
      Me.rollButton.Text = "Roll"
      '
      'RollDice
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(255, 108)
      Me.Controls.Add(Me.die4PictureBox)
      Me.Controls.Add(Me.die3PictureBox)
      Me.Controls.Add(Me.die2PictureBox)
      Me.Controls.Add(Me.die1PictureBox)
      Me.Controls.Add(Me.rollButton)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "RollDice"
      Me.Text = "Roll Dice"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents die4PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents die3PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents die2PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents die1PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents rollButton As System.Windows.Forms.Button

End Class
