<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Craps
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
      Me.statusLabel = New System.Windows.Forms.Label()
      Me.pointDie2PictureBox = New System.Windows.Forms.PictureBox()
      Me.rollButton = New System.Windows.Forms.Button()
      Me.playButton = New System.Windows.Forms.Button()
      Me.pointDie1PictureBox = New System.Windows.Forms.PictureBox()
      Me.die2PictureBox = New System.Windows.Forms.PictureBox()
      Me.die1PictureBox = New System.Windows.Forms.PictureBox()
      Me.pointGroupBox = New System.Windows.Forms.GroupBox()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.pointGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      'statusLabel
      '
      Me.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.statusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.statusLabel.Location = New System.Drawing.Point(0, 170)
      Me.statusLabel.Name = "statusLabel"
      Me.statusLabel.Size = New System.Drawing.Size(247, 17)
      Me.statusLabel.TabIndex = 18
      '
      'pointDie2PictureBox
      '
      Me.pointDie2PictureBox.Location = New System.Drawing.Point(74, 22)
      Me.pointDie2PictureBox.Name = "pointDie2PictureBox"
      Me.pointDie2PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.pointDie2PictureBox.TabIndex = 1
      Me.pointDie2PictureBox.TabStop = False
      '
      'rollButton
      '
      Me.rollButton.Enabled = False
      Me.rollButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.rollButton.Location = New System.Drawing.Point(160, 51)
      Me.rollButton.Name = "rollButton"
      Me.rollButton.Size = New System.Drawing.Size(75, 23)
      Me.rollButton.TabIndex = 17
      Me.rollButton.Text = "Roll"
      '
      'playButton
      '
      Me.playButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.playButton.Location = New System.Drawing.Point(160, 22)
      Me.playButton.Name = "playButton"
      Me.playButton.Size = New System.Drawing.Size(75, 23)
      Me.playButton.TabIndex = 16
      Me.playButton.Text = "Play"
      '
      'pointDie1PictureBox
      '
      Me.pointDie1PictureBox.Location = New System.Drawing.Point(15, 22)
      Me.pointDie1PictureBox.Name = "pointDie1PictureBox"
      Me.pointDie1PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.pointDie1PictureBox.TabIndex = 0
      Me.pointDie1PictureBox.TabStop = False
      '
      'die2PictureBox
      '
      Me.die2PictureBox.Location = New System.Drawing.Point(86, 107)
      Me.die2PictureBox.Name = "die2PictureBox"
      Me.die2PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.die2PictureBox.TabIndex = 15
      Me.die2PictureBox.TabStop = False
      '
      'die1PictureBox
      '
      Me.die1PictureBox.Location = New System.Drawing.Point(27, 107)
      Me.die1PictureBox.Name = "die1PictureBox"
      Me.die1PictureBox.Size = New System.Drawing.Size(53, 53)
      Me.die1PictureBox.TabIndex = 14
      Me.die1PictureBox.TabStop = False
      '
      'pointGroupBox
      '
      Me.pointGroupBox.Controls.Add(Me.pointDie2PictureBox)
      Me.pointGroupBox.Controls.Add(Me.pointDie1PictureBox)
      Me.pointGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.pointGroupBox.Location = New System.Drawing.Point(12, 12)
      Me.pointGroupBox.Name = "pointGroupBox"
      Me.pointGroupBox.Size = New System.Drawing.Size(142, 89)
      Me.pointGroupBox.TabIndex = 13
      Me.pointGroupBox.TabStop = False
      Me.pointGroupBox.Text = "Point"
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(203, 51)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(0, 0)
      Me.Button1.TabIndex = 19
      Me.Button1.Text = "Button1"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Craps
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(247, 187)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.statusLabel)
      Me.Controls.Add(Me.rollButton)
      Me.Controls.Add(Me.playButton)
      Me.Controls.Add(Me.die2PictureBox)
      Me.Controls.Add(Me.die1PictureBox)
      Me.Controls.Add(Me.pointGroupBox)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Craps"
      Me.Text = "Craps Game"
      Me.pointGroupBox.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents statusLabel As System.Windows.Forms.Label
   Friend WithEvents pointDie2PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents rollButton As System.Windows.Forms.Button
   Friend WithEvents playButton As System.Windows.Forms.Button
   Friend WithEvents pointDie1PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents die2PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents die1PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents pointGroupBox As System.Windows.Forms.GroupBox
   Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
