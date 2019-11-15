<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathTutor
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
      Me.grpDifficulty = New System.Windows.Forms.GroupBox()
      Me.levelThreeRadioButton = New System.Windows.Forms.RadioButton()
      Me.levelTwoRadioButton = New System.Windows.Forms.RadioButton()
      Me.levelOneRadioButton = New System.Windows.Forms.RadioButton()
      Me.okButton = New System.Windows.Forms.Button()
      Me.answerTextBox = New System.Windows.Forms.TextBox()
      Me.lblEquals = New System.Windows.Forms.Label()
      Me.multiplicationRadioButton = New System.Windows.Forms.RadioButton()
      Me.grpOperation = New System.Windows.Forms.GroupBox()
      Me.subtractionRadioButton = New System.Windows.Forms.RadioButton()
      Me.additionRadioButton = New System.Windows.Forms.RadioButton()
      Me.generateButton = New System.Windows.Forms.Button()
      Me.questionLabel = New System.Windows.Forms.Label()
      Me.grpDifficulty.SuspendLayout()
      Me.grpOperation.SuspendLayout()
      Me.SuspendLayout()
      '
      'grpDifficulty
      '
      Me.grpDifficulty.Controls.Add(Me.levelThreeRadioButton)
      Me.grpDifficulty.Controls.Add(Me.levelTwoRadioButton)
      Me.grpDifficulty.Controls.Add(Me.levelOneRadioButton)
      Me.grpDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpDifficulty.Location = New System.Drawing.Point(10, 117)
      Me.grpDifficulty.Name = "grpDifficulty"
      Me.grpDifficulty.Size = New System.Drawing.Size(307, 53)
      Me.grpDifficulty.TabIndex = 40
      Me.grpDifficulty.TabStop = False
      Me.grpDifficulty.Text = "Difficulty"
      '
      'levelThreeRadioButton
      '
      Me.levelThreeRadioButton.AutoSize = True
      Me.levelThreeRadioButton.Location = New System.Drawing.Point(199, 22)
      Me.levelThreeRadioButton.Name = "levelThreeRadioButton"
      Me.levelThreeRadioButton.Size = New System.Drawing.Size(69, 20)
      Me.levelThreeRadioButton.TabIndex = 2
      Me.levelThreeRadioButton.Text = "Level 3"
      '
      'levelTwoRadioButton
      '
      Me.levelTwoRadioButton.AutoSize = True
      Me.levelTwoRadioButton.Location = New System.Drawing.Point(103, 22)
      Me.levelTwoRadioButton.Name = "levelTwoRadioButton"
      Me.levelTwoRadioButton.Size = New System.Drawing.Size(69, 20)
      Me.levelTwoRadioButton.TabIndex = 1
      Me.levelTwoRadioButton.Text = "Level 2"
      '
      'levelOneRadioButton
      '
      Me.levelOneRadioButton.AutoSize = True
      Me.levelOneRadioButton.Checked = True
      Me.levelOneRadioButton.Location = New System.Drawing.Point(7, 22)
      Me.levelOneRadioButton.Name = "levelOneRadioButton"
      Me.levelOneRadioButton.Size = New System.Drawing.Size(69, 20)
      Me.levelOneRadioButton.TabIndex = 0
      Me.levelOneRadioButton.TabStop = True
      Me.levelOneRadioButton.Text = "Level 1"
      '
      'okButton
      '
      Me.okButton.Enabled = False
      Me.okButton.Location = New System.Drawing.Point(335, 14)
      Me.okButton.Name = "okButton"
      Me.okButton.Size = New System.Drawing.Size(103, 25)
      Me.okButton.TabIndex = 38
      Me.okButton.Text = "OK"
      '
      'answerTextBox
      '
      Me.answerTextBox.Enabled = False
      Me.answerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.answerTextBox.Location = New System.Drawing.Point(206, 15)
      Me.answerTextBox.Name = "answerTextBox"
      Me.answerTextBox.Size = New System.Drawing.Size(111, 22)
      Me.answerTextBox.TabIndex = 36
      '
      'lblEquals
      '
      Me.lblEquals.AutoSize = True
      Me.lblEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEquals.Location = New System.Drawing.Point(186, 18)
      Me.lblEquals.Name = "lblEquals"
      Me.lblEquals.Size = New System.Drawing.Size(15, 16)
      Me.lblEquals.TabIndex = 37
      Me.lblEquals.Text = "="
      '
      'multiplicationRadioButton
      '
      Me.multiplicationRadioButton.AutoSize = True
      Me.multiplicationRadioButton.Location = New System.Drawing.Point(199, 22)
      Me.multiplicationRadioButton.Name = "multiplicationRadioButton"
      Me.multiplicationRadioButton.Size = New System.Drawing.Size(103, 20)
      Me.multiplicationRadioButton.TabIndex = 2
      Me.multiplicationRadioButton.Text = "Multiplication"
      '
      'grpOperation
      '
      Me.grpOperation.Controls.Add(Me.multiplicationRadioButton)
      Me.grpOperation.Controls.Add(Me.subtractionRadioButton)
      Me.grpOperation.Controls.Add(Me.additionRadioButton)
      Me.grpOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpOperation.Location = New System.Drawing.Point(10, 57)
      Me.grpOperation.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
      Me.grpOperation.Name = "grpOperation"
      Me.grpOperation.Size = New System.Drawing.Size(307, 53)
      Me.grpOperation.TabIndex = 39
      Me.grpOperation.TabStop = False
      Me.grpOperation.Text = "Operation"
      '
      'subtractionRadioButton
      '
      Me.subtractionRadioButton.AutoSize = True
      Me.subtractionRadioButton.Location = New System.Drawing.Point(103, 22)
      Me.subtractionRadioButton.Name = "subtractionRadioButton"
      Me.subtractionRadioButton.Size = New System.Drawing.Size(93, 20)
      Me.subtractionRadioButton.TabIndex = 1
      Me.subtractionRadioButton.Text = "Subtraction"
      '
      'additionRadioButton
      '
      Me.additionRadioButton.AutoSize = True
      Me.additionRadioButton.Checked = True
      Me.additionRadioButton.Location = New System.Drawing.Point(7, 22)
      Me.additionRadioButton.Name = "additionRadioButton"
      Me.additionRadioButton.Size = New System.Drawing.Size(75, 20)
      Me.additionRadioButton.TabIndex = 0
      Me.additionRadioButton.TabStop = True
      Me.additionRadioButton.Text = "Addition"
      '
      'generateButton
      '
      Me.generateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.generateButton.Location = New System.Drawing.Point(335, 57)
      Me.generateButton.Name = "generateButton"
      Me.generateButton.Size = New System.Drawing.Size(103, 113)
      Me.generateButton.TabIndex = 41
      Me.generateButton.Text = "Generate Example"
      '
      'questionLabel
      '
      Me.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.questionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.questionLabel.Location = New System.Drawing.Point(12, 12)
      Me.questionLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 2)
      Me.questionLabel.Name = "questionLabel"
      Me.questionLabel.Size = New System.Drawing.Size(167, 29)
      Me.questionLabel.TabIndex = 35
      Me.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'MathTutor
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(447, 181)
      Me.Controls.Add(Me.grpDifficulty)
      Me.Controls.Add(Me.okButton)
      Me.Controls.Add(Me.answerTextBox)
      Me.Controls.Add(Me.lblEquals)
      Me.Controls.Add(Me.grpOperation)
      Me.Controls.Add(Me.generateButton)
      Me.Controls.Add(Me.questionLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "MathTutor"
      Me.Text = "Math Tutor"
      Me.grpDifficulty.ResumeLayout(False)
      Me.grpDifficulty.PerformLayout()
      Me.grpOperation.ResumeLayout(False)
      Me.grpOperation.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents grpDifficulty As System.Windows.Forms.GroupBox
   Private WithEvents levelThreeRadioButton As System.Windows.Forms.RadioButton
   Private WithEvents levelTwoRadioButton As System.Windows.Forms.RadioButton
   Private WithEvents levelOneRadioButton As System.Windows.Forms.RadioButton
   Private WithEvents okButton As System.Windows.Forms.Button
   Private WithEvents answerTextBox As System.Windows.Forms.TextBox
   Private WithEvents lblEquals As System.Windows.Forms.Label
   Private WithEvents multiplicationRadioButton As System.Windows.Forms.RadioButton
   Private WithEvents grpOperation As System.Windows.Forms.GroupBox
   Private WithEvents subtractionRadioButton As System.Windows.Forms.RadioButton
   Private WithEvents additionRadioButton As System.Windows.Forms.RadioButton
   Private WithEvents generateButton As System.Windows.Forms.Button
   Private WithEvents questionLabel As System.Windows.Forms.Label

End Class
