<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeReport
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
      Me.inputGradesGroupBox = New System.Windows.Forms.GroupBox()
      Me.test3TextBox = New System.Windows.Forms.TextBox()
      Me.test2TextBox = New System.Windows.Forms.TextBox()
      Me.test1TextBox = New System.Windows.Forms.TextBox()
      Me.test3Label = New System.Windows.Forms.Label()
      Me.test2Label = New System.Windows.Forms.Label()
      Me.test1Label = New System.Windows.Forms.Label()
      Me.submitButton = New System.Windows.Forms.Button()
      Me.gradesListBox = New System.Windows.Forms.ListBox()
      Me.classAverageLabel = New System.Windows.Forms.Label()
      Me.numericRadioButton = New System.Windows.Forms.RadioButton()
      Me.letterRadioButton = New System.Windows.Forms.RadioButton()
      Me.gradeViewGroupBox = New System.Windows.Forms.GroupBox()
      Me.averageLabel = New System.Windows.Forms.Label()
      Me.barChartListBox = New System.Windows.Forms.ListBox()
      Me.barChartLabel = New System.Windows.Forms.Label()
      Me.inputGradesGroupBox.SuspendLayout()
      Me.gradeViewGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      'inputGradesGroupBox
      '
      Me.inputGradesGroupBox.Controls.Add(Me.test3TextBox)
      Me.inputGradesGroupBox.Controls.Add(Me.test2TextBox)
      Me.inputGradesGroupBox.Controls.Add(Me.test1TextBox)
      Me.inputGradesGroupBox.Controls.Add(Me.test3Label)
      Me.inputGradesGroupBox.Controls.Add(Me.test2Label)
      Me.inputGradesGroupBox.Controls.Add(Me.test1Label)
      Me.inputGradesGroupBox.Controls.Add(Me.submitButton)
      Me.inputGradesGroupBox.Location = New System.Drawing.Point(12, 12)
      Me.inputGradesGroupBox.Name = "inputGradesGroupBox"
      Me.inputGradesGroupBox.Size = New System.Drawing.Size(150, 133)
      Me.inputGradesGroupBox.TabIndex = 5
      Me.inputGradesGroupBox.TabStop = False
      Me.inputGradesGroupBox.Text = "Input Grades"
      '
      'test3TextBox
      '
      Me.test3TextBox.Location = New System.Drawing.Point(53, 74)
      Me.test3TextBox.Name = "test3TextBox"
      Me.test3TextBox.Size = New System.Drawing.Size(88, 23)
      Me.test3TextBox.TabIndex = 3
      '
      'test2TextBox
      '
      Me.test2TextBox.Location = New System.Drawing.Point(53, 45)
      Me.test2TextBox.Name = "test2TextBox"
      Me.test2TextBox.Size = New System.Drawing.Size(88, 23)
      Me.test2TextBox.TabIndex = 2
      '
      'test1TextBox
      '
      Me.test1TextBox.Location = New System.Drawing.Point(53, 16)
      Me.test1TextBox.Name = "test1TextBox"
      Me.test1TextBox.Size = New System.Drawing.Size(88, 23)
      Me.test1TextBox.TabIndex = 1
      '
      'test3Label
      '
      Me.test3Label.AutoSize = True
      Me.test3Label.Location = New System.Drawing.Point(6, 77)
      Me.test3Label.Name = "test3Label"
      Me.test3Label.Size = New System.Drawing.Size(41, 15)
      Me.test3Label.TabIndex = 8
      Me.test3Label.Text = "Test 3:"
      '
      'test2Label
      '
      Me.test2Label.AutoSize = True
      Me.test2Label.Location = New System.Drawing.Point(6, 48)
      Me.test2Label.Name = "test2Label"
      Me.test2Label.Size = New System.Drawing.Size(41, 15)
      Me.test2Label.TabIndex = 7
      Me.test2Label.Text = "Test 2:"
      '
      'test1Label
      '
      Me.test1Label.AutoSize = True
      Me.test1Label.Location = New System.Drawing.Point(6, 19)
      Me.test1Label.Name = "test1Label"
      Me.test1Label.Size = New System.Drawing.Size(41, 15)
      Me.test1Label.TabIndex = 6
      Me.test1Label.Text = "Test 1:"
      '
      'submitButton
      '
      Me.submitButton.Location = New System.Drawing.Point(53, 103)
      Me.submitButton.Name = "submitButton"
      Me.submitButton.Size = New System.Drawing.Size(88, 23)
      Me.submitButton.TabIndex = 4
      Me.submitButton.Text = "Submit Grades"
      Me.submitButton.UseVisualStyleBackColor = True
      '
      'gradesListBox
      '
      Me.gradesListBox.FormattingEnabled = True
      Me.gradesListBox.ItemHeight = 15
      Me.gradesListBox.Location = New System.Drawing.Point(168, 21)
      Me.gradesListBox.Name = "gradesListBox"
      Me.gradesListBox.Size = New System.Drawing.Size(345, 169)
      Me.gradesListBox.TabIndex = 7
      '
      'classAverageLabel
      '
      Me.classAverageLabel.AutoSize = True
      Me.classAverageLabel.Location = New System.Drawing.Point(352, 205)
      Me.classAverageLabel.Name = "classAverageLabel"
      Me.classAverageLabel.Size = New System.Drawing.Size(81, 15)
      Me.classAverageLabel.TabIndex = 8
      Me.classAverageLabel.Text = "Class average:"
      '
      'numericRadioButton
      '
      Me.numericRadioButton.AutoSize = True
      Me.numericRadioButton.Checked = True
      Me.numericRadioButton.Location = New System.Drawing.Point(9, 20)
      Me.numericRadioButton.Name = "numericRadioButton"
      Me.numericRadioButton.Size = New System.Drawing.Size(64, 17)
      Me.numericRadioButton.TabIndex = 0
      Me.numericRadioButton.TabStop = True
      Me.numericRadioButton.Text = "Numeric"
      Me.numericRadioButton.UseVisualStyleBackColor = True
      '
      'letterRadioButton
      '
      Me.letterRadioButton.AutoSize = True
      Me.letterRadioButton.Location = New System.Drawing.Point(9, 45)
      Me.letterRadioButton.Name = "letterRadioButton"
      Me.letterRadioButton.Size = New System.Drawing.Size(52, 17)
      Me.letterRadioButton.TabIndex = 1
      Me.letterRadioButton.Text = "Letter"
      Me.letterRadioButton.UseVisualStyleBackColor = True
      '
      'gradeViewGroupBox
      '
      Me.gradeViewGroupBox.Controls.Add(Me.letterRadioButton)
      Me.gradeViewGroupBox.Controls.Add(Me.numericRadioButton)
      Me.gradeViewGroupBox.Location = New System.Drawing.Point(12, 151)
      Me.gradeViewGroupBox.Name = "gradeViewGroupBox"
      Me.gradeViewGroupBox.Size = New System.Drawing.Size(150, 73)
      Me.gradeViewGroupBox.TabIndex = 6
      Me.gradeViewGroupBox.TabStop = False
      Me.gradeViewGroupBox.Text = "Grade View"
      '
      'averageLabel
      '
      Me.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.averageLabel.Location = New System.Drawing.Point(439, 201)
      Me.averageLabel.Name = "averageLabel"
      Me.averageLabel.Size = New System.Drawing.Size(74, 23)
      Me.averageLabel.TabIndex = 9
      Me.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'barChartListBox
      '
      Me.barChartListBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.barChartListBox.FormattingEnabled = True
      Me.barChartListBox.ItemHeight = 12
      Me.barChartListBox.Location = New System.Drawing.Point(168, 256)
      Me.barChartListBox.Name = "barChartListBox"
      Me.barChartListBox.Size = New System.Drawing.Size(346, 136)
      Me.barChartListBox.TabIndex = 10
      '
      'barChartLabel
      '
      Me.barChartLabel.AutoSize = True
      Me.barChartLabel.Location = New System.Drawing.Point(165, 238)
      Me.barChartLabel.Name = "barChartLabel"
      Me.barChartLabel.Size = New System.Drawing.Size(183, 15)
      Me.barChartLabel.TabIndex = 11
      Me.barChartLabel.Text = "Numeric grade distribution chart:"
      '
      'GradeReport
      '
      Me.AcceptButton = Me.submitButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(526, 405)
      Me.Controls.Add(Me.barChartLabel)
      Me.Controls.Add(Me.barChartListBox)
      Me.Controls.Add(Me.inputGradesGroupBox)
      Me.Controls.Add(Me.gradesListBox)
      Me.Controls.Add(Me.classAverageLabel)
      Me.Controls.Add(Me.gradeViewGroupBox)
      Me.Controls.Add(Me.averageLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "GradeReport"
      Me.Text = "Grade Report"
      Me.inputGradesGroupBox.ResumeLayout(False)
      Me.inputGradesGroupBox.PerformLayout()
      Me.gradeViewGroupBox.ResumeLayout(False)
      Me.gradeViewGroupBox.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents inputGradesGroupBox As System.Windows.Forms.GroupBox
   Friend WithEvents test3TextBox As System.Windows.Forms.TextBox
   Friend WithEvents test2TextBox As System.Windows.Forms.TextBox
   Friend WithEvents test1TextBox As System.Windows.Forms.TextBox
   Friend WithEvents test3Label As System.Windows.Forms.Label
   Friend WithEvents test2Label As System.Windows.Forms.Label
   Friend WithEvents test1Label As System.Windows.Forms.Label
   Friend WithEvents submitButton As System.Windows.Forms.Button
   Friend WithEvents gradesListBox As System.Windows.Forms.ListBox
   Friend WithEvents classAverageLabel As System.Windows.Forms.Label
   Friend WithEvents numericRadioButton As System.Windows.Forms.RadioButton
   Friend WithEvents letterRadioButton As System.Windows.Forms.RadioButton
   Friend WithEvents gradeViewGroupBox As System.Windows.Forms.GroupBox
   Friend WithEvents averageLabel As System.Windows.Forms.Label
   Friend WithEvents barChartListBox As System.Windows.Forms.ListBox
   Friend WithEvents barChartLabel As System.Windows.Forms.Label

End Class
