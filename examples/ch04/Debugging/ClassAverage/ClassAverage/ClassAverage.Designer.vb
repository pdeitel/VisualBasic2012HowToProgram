<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassAverage
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
      Me.gradesLabel = New System.Windows.Forms.Label()
      Me.gradesListBox = New System.Windows.Forms.ListBox()
      Me.enterGradeLabel = New System.Windows.Forms.Label()
      Me.gradeTextBox = New System.Windows.Forms.TextBox()
      Me.submitGradeButton = New System.Windows.Forms.Button()
      Me.calculateAverageButton = New System.Windows.Forms.Button()
      Me.resultsLabel = New System.Windows.Forms.Label()
      Me.classAverageLabel = New System.Windows.Forms.Label()
      Me.clearGradesButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'gradesLabel
      '
      Me.gradesLabel.AutoSize = True
      Me.gradesLabel.Location = New System.Drawing.Point(12, 9)
      Me.gradesLabel.Name = "gradesLabel"
      Me.gradesLabel.Size = New System.Drawing.Size(46, 15)
      Me.gradesLabel.TabIndex = 5
      Me.gradesLabel.Text = "Grades:"
      '
      'gradesListBox
      '
      Me.gradesListBox.FormattingEnabled = True
      Me.gradesListBox.ItemHeight = 15
      Me.gradesListBox.Location = New System.Drawing.Point(15, 28)
      Me.gradesListBox.Name = "gradesListBox"
      Me.gradesListBox.Size = New System.Drawing.Size(47, 184)
      Me.gradesListBox.TabIndex = 3
      '
      'enterGradeLabel
      '
      Me.enterGradeLabel.AutoSize = True
      Me.enterGradeLabel.Location = New System.Drawing.Point(75, 31)
      Me.enterGradeLabel.Name = "enterGradeLabel"
      Me.enterGradeLabel.Size = New System.Drawing.Size(70, 15)
      Me.enterGradeLabel.TabIndex = 0
      Me.enterGradeLabel.Text = "Enter grade:"
      '
      'gradeTextBox
      '
      Me.gradeTextBox.Location = New System.Drawing.Point(150, 28)
      Me.gradeTextBox.Name = "gradeTextBox"
      Me.gradeTextBox.Size = New System.Drawing.Size(116, 23)
      Me.gradeTextBox.TabIndex = 0
      '
      'submitGradeButton
      '
      Me.submitGradeButton.Location = New System.Drawing.Point(78, 57)
      Me.submitGradeButton.Name = "submitGradeButton"
      Me.submitGradeButton.Size = New System.Drawing.Size(189, 23)
      Me.submitGradeButton.TabIndex = 1
      Me.submitGradeButton.Text = "Submit Grade"
      Me.submitGradeButton.UseVisualStyleBackColor = True
      '
      'calculateAverageButton
      '
      Me.calculateAverageButton.Location = New System.Drawing.Point(78, 86)
      Me.calculateAverageButton.Name = "calculateAverageButton"
      Me.calculateAverageButton.Size = New System.Drawing.Size(189, 23)
      Me.calculateAverageButton.TabIndex = 2
      Me.calculateAverageButton.Text = "Calculate Class Average"
      Me.calculateAverageButton.UseVisualStyleBackColor = True
      '
      'resultsLabel
      '
      Me.resultsLabel.AutoSize = True
      Me.resultsLabel.Location = New System.Drawing.Point(75, 116)
      Me.resultsLabel.Name = "resultsLabel"
      Me.resultsLabel.Size = New System.Drawing.Size(47, 15)
      Me.resultsLabel.TabIndex = 6
      Me.resultsLabel.Text = "Results:"
      '
      'classAverageLabel
      '
      Me.classAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.classAverageLabel.Location = New System.Drawing.Point(78, 136)
      Me.classAverageLabel.Name = "classAverageLabel"
      Me.classAverageLabel.Size = New System.Drawing.Size(188, 36)
      Me.classAverageLabel.TabIndex = 7
      Me.classAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'clearGradesButton
      '
      Me.clearGradesButton.Location = New System.Drawing.Point(78, 189)
      Me.clearGradesButton.Name = "clearGradesButton"
      Me.clearGradesButton.Size = New System.Drawing.Size(191, 23)
      Me.clearGradesButton.TabIndex = 3
      Me.clearGradesButton.Text = "Clear Grades"
      Me.clearGradesButton.UseVisualStyleBackColor = True
      '
      'ClassAverage
      '
      Me.AcceptButton = Me.submitGradeButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(282, 223)
      Me.Controls.Add(Me.clearGradesButton)
      Me.Controls.Add(Me.classAverageLabel)
      Me.Controls.Add(Me.resultsLabel)
      Me.Controls.Add(Me.calculateAverageButton)
      Me.Controls.Add(Me.submitGradeButton)
      Me.Controls.Add(Me.gradeTextBox)
      Me.Controls.Add(Me.enterGradeLabel)
      Me.Controls.Add(Me.gradesListBox)
      Me.Controls.Add(Me.gradesLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "ClassAverage"
      Me.Text = "Class Average"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents gradesLabel As System.Windows.Forms.Label
   Friend WithEvents gradesListBox As System.Windows.Forms.ListBox
   Friend WithEvents enterGradeLabel As System.Windows.Forms.Label
   Friend WithEvents gradeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents submitGradeButton As System.Windows.Forms.Button
   Friend WithEvents calculateAverageButton As System.Windows.Forms.Button
   Friend WithEvents resultsLabel As System.Windows.Forms.Label
   Friend WithEvents classAverageLabel As System.Windows.Forms.Label
   Friend WithEvents clearGradesButton As System.Windows.Forms.Button

End Class
