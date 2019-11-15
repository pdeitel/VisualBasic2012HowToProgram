<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowColors
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
      Me.setColorValueButton = New System.Windows.Forms.Button()
      Me.backColorGroupBox = New System.Windows.Forms.GroupBox()
      Me.setColorNameButton = New System.Windows.Forms.Button()
      Me.colorNameTextBox = New System.Windows.Forms.TextBox()
      Me.frontColorGroupBox = New System.Windows.Forms.GroupBox()
      Me.redTextBox = New System.Windows.Forms.TextBox()
      Me.greenTextBox = New System.Windows.Forms.TextBox()
      Me.blueTextBox = New System.Windows.Forms.TextBox()
      Me.alphaTextBox = New System.Windows.Forms.TextBox()
      Me.aLabel = New System.Windows.Forms.Label()
      Me.rLabel = New System.Windows.Forms.Label()
      Me.gLabel = New System.Windows.Forms.Label()
      Me.bLabel = New System.Windows.Forms.Label()
      Me.backColorGroupBox.SuspendLayout()
      Me.frontColorGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      'setColorValueButton
      '
      Me.setColorValueButton.Location = New System.Drawing.Point(308, 20)
      Me.setColorValueButton.Name = "setColorValueButton"
      Me.setColorValueButton.Size = New System.Drawing.Size(108, 24)
      Me.setColorValueButton.TabIndex = 6
      Me.setColorValueButton.Text = "Set Color Value"
      '
      'backColorGroupBox
      '
      Me.backColorGroupBox.Controls.Add(Me.setColorNameButton)
      Me.backColorGroupBox.Controls.Add(Me.colorNameTextBox)
      Me.backColorGroupBox.Location = New System.Drawing.Point(12, 215)
      Me.backColorGroupBox.Name = "backColorGroupBox"
      Me.backColorGroupBox.Size = New System.Drawing.Size(428, 72)
      Me.backColorGroupBox.TabIndex = 11
      Me.backColorGroupBox.TabStop = False
      Me.backColorGroupBox.Text = "Set Back Color Name"
      '
      'setColorNameButton
      '
      Me.setColorNameButton.Location = New System.Drawing.Point(308, 30)
      Me.setColorNameButton.Name = "setColorNameButton"
      Me.setColorNameButton.Size = New System.Drawing.Size(108, 24)
      Me.setColorNameButton.TabIndex = 1
      Me.setColorNameButton.Text = "Set Color Name"
      '
      'colorNameTextBox
      '
      Me.colorNameTextBox.Location = New System.Drawing.Point(9, 30)
      Me.colorNameTextBox.Name = "colorNameTextBox"
      Me.colorNameTextBox.Size = New System.Drawing.Size(293, 23)
      Me.colorNameTextBox.TabIndex = 0
      '
      'frontColorGroupBox
      '
      Me.frontColorGroupBox.Controls.Add(Me.bLabel)
      Me.frontColorGroupBox.Controls.Add(Me.gLabel)
      Me.frontColorGroupBox.Controls.Add(Me.rLabel)
      Me.frontColorGroupBox.Controls.Add(Me.aLabel)
      Me.frontColorGroupBox.Controls.Add(Me.setColorValueButton)
      Me.frontColorGroupBox.Controls.Add(Me.redTextBox)
      Me.frontColorGroupBox.Controls.Add(Me.greenTextBox)
      Me.frontColorGroupBox.Controls.Add(Me.blueTextBox)
      Me.frontColorGroupBox.Controls.Add(Me.alphaTextBox)
      Me.frontColorGroupBox.Location = New System.Drawing.Point(12, 293)
      Me.frontColorGroupBox.Name = "frontColorGroupBox"
      Me.frontColorGroupBox.Size = New System.Drawing.Size(428, 65)
      Me.frontColorGroupBox.TabIndex = 12
      Me.frontColorGroupBox.TabStop = False
      Me.frontColorGroupBox.Text = "Set Front Color Value"
      '
      'redTextBox
      '
      Me.redTextBox.Location = New System.Drawing.Point(105, 21)
      Me.redTextBox.Name = "redTextBox"
      Me.redTextBox.Size = New System.Drawing.Size(46, 23)
      Me.redTextBox.TabIndex = 3
      '
      'greenTextBox
      '
      Me.greenTextBox.Location = New System.Drawing.Point(181, 21)
      Me.greenTextBox.Name = "greenTextBox"
      Me.greenTextBox.Size = New System.Drawing.Size(46, 23)
      Me.greenTextBox.TabIndex = 4
      '
      'blueTextBox
      '
      Me.blueTextBox.Location = New System.Drawing.Point(256, 20)
      Me.blueTextBox.Name = "blueTextBox"
      Me.blueTextBox.Size = New System.Drawing.Size(46, 23)
      Me.blueTextBox.TabIndex = 5
      '
      'alphaTextBox
      '
      Me.alphaTextBox.Location = New System.Drawing.Point(30, 21)
      Me.alphaTextBox.Name = "alphaTextBox"
      Me.alphaTextBox.Size = New System.Drawing.Size(46, 23)
      Me.alphaTextBox.TabIndex = 2
      '
      'aLabel
      '
      Me.aLabel.AutoSize = True
      Me.aLabel.Location = New System.Drawing.Point(6, 26)
      Me.aLabel.Name = "aLabel"
      Me.aLabel.Size = New System.Drawing.Size(18, 15)
      Me.aLabel.TabIndex = 13
      Me.aLabel.Text = "A:"
      '
      'rLabel
      '
      Me.rLabel.AutoSize = True
      Me.rLabel.Location = New System.Drawing.Point(82, 26)
      Me.rLabel.Name = "rLabel"
      Me.rLabel.Size = New System.Drawing.Size(17, 15)
      Me.rLabel.TabIndex = 14
      Me.rLabel.Text = "R:"
      '
      'gLabel
      '
      Me.gLabel.AutoSize = True
      Me.gLabel.Location = New System.Drawing.Point(157, 26)
      Me.gLabel.Name = "gLabel"
      Me.gLabel.Size = New System.Drawing.Size(18, 15)
      Me.gLabel.TabIndex = 15
      Me.gLabel.Text = "G:"
      '
      'bLabel
      '
      Me.bLabel.AutoSize = True
      Me.bLabel.Location = New System.Drawing.Point(233, 26)
      Me.bLabel.Name = "bLabel"
      Me.bLabel.Size = New System.Drawing.Size(17, 15)
      Me.bLabel.TabIndex = 16
      Me.bLabel.Text = "B:"
      '
      'ShowColors
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(451, 370)
      Me.Controls.Add(Me.backColorGroupBox)
      Me.Controls.Add(Me.frontColorGroupBox)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "ShowColors"
      Me.Text = "Show Colors"
      Me.backColorGroupBox.ResumeLayout(False)
      Me.backColorGroupBox.PerformLayout()
      Me.frontColorGroupBox.ResumeLayout(False)
      Me.frontColorGroupBox.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents setColorValueButton As System.Windows.Forms.Button
   Private WithEvents backColorGroupBox As System.Windows.Forms.GroupBox
   Private WithEvents setColorNameButton As System.Windows.Forms.Button
   Private WithEvents colorNameTextBox As System.Windows.Forms.TextBox
   Private WithEvents frontColorGroupBox As System.Windows.Forms.GroupBox
   Private WithEvents redTextBox As System.Windows.Forms.TextBox
   Private WithEvents greenTextBox As System.Windows.Forms.TextBox
   Private WithEvents blueTextBox As System.Windows.Forms.TextBox
   Private WithEvents alphaTextBox As System.Windows.Forms.TextBox
   Friend WithEvents bLabel As System.Windows.Forms.Label
   Friend WithEvents gLabel As System.Windows.Forms.Label
   Friend WithEvents rLabel As System.Windows.Forms.Label
   Friend WithEvents aLabel As System.Windows.Forms.Label

End Class
