<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeTest
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
      Me.output2Label = New System.Windows.Forms.Label()
      Me.output1Label = New System.Windows.Forms.Label()
      Me.incrementSecondButton = New System.Windows.Forms.Button()
      Me.setSecondTextBox = New System.Windows.Forms.TextBox()
      Me.setSecondLabel = New System.Windows.Forms.Label()
      Me.setMinuteTextBox = New System.Windows.Forms.TextBox()
      Me.setMinuteLabel = New System.Windows.Forms.Label()
      Me.setHourTextBox = New System.Windows.Forms.TextBox()
      Me.setHourLabel = New System.Windows.Forms.Label()
      Me.setTimeButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'output2Label
      '
      Me.output2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.output2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.output2Label.Location = New System.Drawing.Point(13, 110)
      Me.output2Label.Name = "output2Label"
      Me.output2Label.Size = New System.Drawing.Size(372, 23)
      Me.output2Label.TabIndex = 26
      Me.output2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'output1Label
      '
      Me.output1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.output1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.output1Label.Location = New System.Drawing.Point(14, 76)
      Me.output1Label.Name = "output1Label"
      Me.output1Label.Size = New System.Drawing.Size(371, 23)
      Me.output1Label.TabIndex = 25
      Me.output1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'incrementSecondButton
      '
      Me.incrementSecondButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.incrementSecondButton.Location = New System.Drawing.Point(202, 41)
      Me.incrementSecondButton.Name = "incrementSecondButton"
      Me.incrementSecondButton.Size = New System.Drawing.Size(113, 23)
      Me.incrementSecondButton.TabIndex = 4
      Me.incrementSecondButton.Text = "Increment Second"
      '
      'setSecondTextBox
      '
      Me.setSecondTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.setSecondTextBox.Location = New System.Drawing.Point(335, 12)
      Me.setSecondTextBox.Name = "setSecondTextBox"
      Me.setSecondTextBox.Size = New System.Drawing.Size(50, 23)
      Me.setSecondTextBox.TabIndex = 2
      '
      'setSecondLabel
      '
      Me.setSecondLabel.AutoSize = True
      Me.setSecondLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.setSecondLabel.Location = New System.Drawing.Point(261, 15)
      Me.setSecondLabel.Name = "setSecondLabel"
      Me.setSecondLabel.Size = New System.Drawing.Size(68, 15)
      Me.setSecondLabel.TabIndex = 22
      Me.setSecondLabel.Text = "Set Second:"
      '
      'setMinuteTextBox
      '
      Me.setMinuteTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.setMinuteTextBox.Location = New System.Drawing.Point(205, 12)
      Me.setMinuteTextBox.Name = "setMinuteTextBox"
      Me.setMinuteTextBox.Size = New System.Drawing.Size(50, 23)
      Me.setMinuteTextBox.TabIndex = 1
      '
      'setMinuteLabel
      '
      Me.setMinuteLabel.AutoSize = True
      Me.setMinuteLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.setMinuteLabel.Location = New System.Drawing.Point(132, 15)
      Me.setMinuteLabel.Name = "setMinuteLabel"
      Me.setMinuteLabel.Size = New System.Drawing.Size(67, 15)
      Me.setMinuteLabel.TabIndex = 20
      Me.setMinuteLabel.Text = "Set Minute:"
      '
      'setHourTextBox
      '
      Me.setHourTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.setHourTextBox.Location = New System.Drawing.Point(76, 12)
      Me.setHourTextBox.Name = "setHourTextBox"
      Me.setHourTextBox.Size = New System.Drawing.Size(50, 23)
      Me.setHourTextBox.TabIndex = 0
      '
      'setHourLabel
      '
      Me.setHourLabel.AutoSize = True
      Me.setHourLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.setHourLabel.Location = New System.Drawing.Point(14, 15)
      Me.setHourLabel.Name = "setHourLabel"
      Me.setHourLabel.Size = New System.Drawing.Size(56, 15)
      Me.setHourLabel.TabIndex = 18
      Me.setHourLabel.Text = "Set Hour:"
      '
      'setTimeButton
      '
      Me.setTimeButton.Location = New System.Drawing.Point(83, 41)
      Me.setTimeButton.Name = "setTimeButton"
      Me.setTimeButton.Size = New System.Drawing.Size(113, 23)
      Me.setTimeButton.TabIndex = 3
      Me.setTimeButton.Text = "Set Time"
      Me.setTimeButton.UseVisualStyleBackColor = True
      '
      'TimeTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(399, 147)
      Me.Controls.Add(Me.setTimeButton)
      Me.Controls.Add(Me.output2Label)
      Me.Controls.Add(Me.output1Label)
      Me.Controls.Add(Me.incrementSecondButton)
      Me.Controls.Add(Me.setSecondTextBox)
      Me.Controls.Add(Me.setSecondLabel)
      Me.Controls.Add(Me.setMinuteTextBox)
      Me.Controls.Add(Me.setMinuteLabel)
      Me.Controls.Add(Me.setHourTextBox)
      Me.Controls.Add(Me.setHourLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "TimeTest"
      Me.Text = "Using Class Time's Properties for Data Access"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents output2Label As System.Windows.Forms.Label
   Friend WithEvents output1Label As System.Windows.Forms.Label
   Friend WithEvents incrementSecondButton As System.Windows.Forms.Button
   Friend WithEvents setSecondTextBox As System.Windows.Forms.TextBox
   Friend WithEvents setSecondLabel As System.Windows.Forms.Label
   Friend WithEvents setMinuteTextBox As System.Windows.Forms.TextBox
   Friend WithEvents setMinuteLabel As System.Windows.Forms.Label
   Friend WithEvents setHourTextBox As System.Windows.Forms.TextBox
   Friend WithEvents setHourLabel As System.Windows.Forms.Label
   Friend WithEvents setTimeButton As System.Windows.Forms.Button

End Class
