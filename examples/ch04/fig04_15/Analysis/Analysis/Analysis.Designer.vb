<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analysis
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
      Me.clearResultsButton = New System.Windows.Forms.Button()
      Me.analysisResultsLabel = New System.Windows.Forms.Label()
      Me.analysisLabel = New System.Windows.Forms.Label()
      Me.analyzeResultsButton = New System.Windows.Forms.Button()
      Me.submitResultButton = New System.Windows.Forms.Button()
      Me.resultTextBox = New System.Windows.Forms.TextBox()
      Me.enterResultLabel = New System.Windows.Forms.Label()
      Me.resultsListBox = New System.Windows.Forms.ListBox()
      Me.resultsLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'clearResultsButton
      '
      Me.clearResultsButton.Location = New System.Drawing.Point(78, 189)
      Me.clearResultsButton.Name = "clearResultsButton"
      Me.clearResultsButton.Size = New System.Drawing.Size(191, 23)
      Me.clearResultsButton.TabIndex = 13
      Me.clearResultsButton.Text = "Clear Results"
      Me.clearResultsButton.UseVisualStyleBackColor = True
      '
      'analysisResultsLabel
      '
      Me.analysisResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.analysisResultsLabel.Location = New System.Drawing.Point(78, 136)
      Me.analysisResultsLabel.Name = "analysisResultsLabel"
      Me.analysisResultsLabel.Size = New System.Drawing.Size(188, 50)
      Me.analysisResultsLabel.TabIndex = 16
      Me.analysisResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'analysisLabel
      '
      Me.analysisLabel.AutoSize = True
      Me.analysisLabel.Location = New System.Drawing.Point(75, 116)
      Me.analysisLabel.Name = "analysisLabel"
      Me.analysisLabel.Size = New System.Drawing.Size(53, 15)
      Me.analysisLabel.TabIndex = 15
      Me.analysisLabel.Text = "Analysis:"
      '
      'analyzeResultsButton
      '
      Me.analyzeResultsButton.Enabled = False
      Me.analyzeResultsButton.Location = New System.Drawing.Point(78, 86)
      Me.analyzeResultsButton.Name = "analyzeResultsButton"
      Me.analyzeResultsButton.Size = New System.Drawing.Size(189, 23)
      Me.analyzeResultsButton.TabIndex = 11
      Me.analyzeResultsButton.Text = "Analyze Results"
      Me.analyzeResultsButton.UseVisualStyleBackColor = True
      '
      'submitResultButton
      '
      Me.submitResultButton.Location = New System.Drawing.Point(78, 57)
      Me.submitResultButton.Name = "submitResultButton"
      Me.submitResultButton.Size = New System.Drawing.Size(189, 23)
      Me.submitResultButton.TabIndex = 10
      Me.submitResultButton.Text = "Submit Result"
      Me.submitResultButton.UseVisualStyleBackColor = True
      '
      'resultTextBox
      '
      Me.resultTextBox.Location = New System.Drawing.Point(232, 28)
      Me.resultTextBox.Name = "resultTextBox"
      Me.resultTextBox.Size = New System.Drawing.Size(34, 23)
      Me.resultTextBox.TabIndex = 8
      '
      'enterResultLabel
      '
      Me.enterResultLabel.AutoSize = True
      Me.enterResultLabel.Location = New System.Drawing.Point(75, 31)
      Me.enterResultLabel.Name = "enterResultLabel"
      Me.enterResultLabel.Size = New System.Drawing.Size(151, 15)
      Me.enterResultLabel.TabIndex = 9
      Me.enterResultLabel.Text = "Enter P for pass or F for fail:"
      '
      'resultsListBox
      '
      Me.resultsListBox.FormattingEnabled = True
      Me.resultsListBox.ItemHeight = 15
      Me.resultsListBox.Location = New System.Drawing.Point(15, 28)
      Me.resultsListBox.Name = "resultsListBox"
      Me.resultsListBox.Size = New System.Drawing.Size(47, 184)
      Me.resultsListBox.TabIndex = 12
      '
      'resultsLabel
      '
      Me.resultsLabel.AutoSize = True
      Me.resultsLabel.Location = New System.Drawing.Point(12, 9)
      Me.resultsLabel.Name = "resultsLabel"
      Me.resultsLabel.Size = New System.Drawing.Size(47, 15)
      Me.resultsLabel.TabIndex = 14
      Me.resultsLabel.Text = "Results:"
      '
      'Analysis
      '
      Me.AcceptButton = Me.submitResultButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(281, 226)
      Me.Controls.Add(Me.clearResultsButton)
      Me.Controls.Add(Me.analysisResultsLabel)
      Me.Controls.Add(Me.analysisLabel)
      Me.Controls.Add(Me.analyzeResultsButton)
      Me.Controls.Add(Me.submitResultButton)
      Me.Controls.Add(Me.resultTextBox)
      Me.Controls.Add(Me.enterResultLabel)
      Me.Controls.Add(Me.resultsListBox)
      Me.Controls.Add(Me.resultsLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Analysis"
      Me.Text = "Licensing-Exam Analysis"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents clearResultsButton As System.Windows.Forms.Button
   Friend WithEvents analysisResultsLabel As System.Windows.Forms.Label
   Friend WithEvents analysisLabel As System.Windows.Forms.Label
   Friend WithEvents analyzeResultsButton As System.Windows.Forms.Button
   Friend WithEvents submitResultButton As System.Windows.Forms.Button
   Friend WithEvents resultTextBox As System.Windows.Forms.TextBox
   Friend WithEvents enterResultLabel As System.Windows.Forms.Label
   Friend WithEvents resultsListBox As System.Windows.Forms.ListBox
   Friend WithEvents resultsLabel As System.Windows.Forms.Label

End Class
