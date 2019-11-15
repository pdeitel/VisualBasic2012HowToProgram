<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterestCalculator
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
      Me.yearsNumericUpDown = New System.Windows.Forms.NumericUpDown()
      Me.interestRateTextBox = New System.Windows.Forms.TextBox()
      Me.principalTextBox = New System.Windows.Forms.TextBox()
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.balancesLabel = New System.Windows.Forms.Label()
      Me.yearsLabel = New System.Windows.Forms.Label()
      Me.interestRateLabel = New System.Windows.Forms.Label()
      Me.principalLabel = New System.Windows.Forms.Label()
      Me.resultsListBox = New System.Windows.Forms.ListBox()
      CType(Me.yearsNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
      Me.SuspendLayout
      '
      'yearsNumericUpDown
      '
      Me.yearsNumericUpDown.Location = New System.Drawing.Point(90, 70)
      Me.yearsNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
      Me.yearsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
      Me.yearsNumericUpDown.Name = "yearsNumericUpDown"
      Me.yearsNumericUpDown.Size = New System.Drawing.Size(100, 23)
      Me.yearsNumericUpDown.TabIndex = 11
      Me.yearsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'interestRateTextBox
      '
      Me.interestRateTextBox.Location = New System.Drawing.Point(90, 41)
      Me.interestRateTextBox.Name = "interestRateTextBox"
      Me.interestRateTextBox.Size = New System.Drawing.Size(100, 23)
      Me.interestRateTextBox.TabIndex = 10
      '
      'principalTextBox
      '
      Me.principalTextBox.Location = New System.Drawing.Point(90, 12)
      Me.principalTextBox.Name = "principalTextBox"
      Me.principalTextBox.Size = New System.Drawing.Size(100, 23)
      Me.principalTextBox.TabIndex = 9
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(196, 12)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(75, 23)
      Me.calculateButton.TabIndex = 12
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = true
      '
      'balancesLabel
      '
      Me.balancesLabel.AutoSize = true
      Me.balancesLabel.Location = New System.Drawing.Point(12, 109)
      Me.balancesLabel.Name = "balancesLabel"
      Me.balancesLabel.Size = New System.Drawing.Size(56, 15)
      Me.balancesLabel.TabIndex = 16
      Me.balancesLabel.Text = "Balances:"
      Me.balancesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'yearsLabel
      '
      Me.yearsLabel.AutoSize = true
      Me.yearsLabel.Location = New System.Drawing.Point(12, 72)
      Me.yearsLabel.Name = "yearsLabel"
      Me.yearsLabel.Size = New System.Drawing.Size(38, 15)
      Me.yearsLabel.TabIndex = 15
      Me.yearsLabel.Text = "Years:"
      Me.yearsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'interestRateLabel
      '
      Me.interestRateLabel.AutoSize = true
      Me.interestRateLabel.Location = New System.Drawing.Point(12, 44)
      Me.interestRateLabel.Name = "interestRateLabel"
      Me.interestRateLabel.Size = New System.Drawing.Size(72, 15)
      Me.interestRateLabel.TabIndex = 14
      Me.interestRateLabel.Text = "Interest rate:"
      Me.interestRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'principalLabel
      '
      Me.principalLabel.AutoSize = true
      Me.principalLabel.Location = New System.Drawing.Point(12, 15)
      Me.principalLabel.Name = "principalLabel"
      Me.principalLabel.Size = New System.Drawing.Size(56, 15)
      Me.principalLabel.TabIndex = 13
      Me.principalLabel.Text = "Principal:"
      Me.principalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'resultsListBox
      '
      Me.resultsListBox.FormattingEnabled = true
      Me.resultsListBox.ItemHeight = 15
      Me.resultsListBox.Location = New System.Drawing.Point(13, 128)
      Me.resultsListBox.Name = "resultsListBox"
      Me.resultsListBox.Size = New System.Drawing.Size(258, 139)
      Me.resultsListBox.TabIndex = 17
      '
      'InterestCalculator
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 281)
      Me.Controls.Add(Me.resultsListBox)
      Me.Controls.Add(Me.yearsNumericUpDown)
      Me.Controls.Add(Me.interestRateTextBox)
      Me.Controls.Add(Me.principalTextBox)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.balancesLabel)
      Me.Controls.Add(Me.yearsLabel)
      Me.Controls.Add(Me.interestRateLabel)
      Me.Controls.Add(Me.principalLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Name = "InterestCalculator"
      Me.Text = "Interest Calculator"
      CType(Me.yearsNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub
   Friend WithEvents yearsNumericUpDown As System.Windows.Forms.NumericUpDown
   Friend WithEvents interestRateTextBox As System.Windows.Forms.TextBox
   Friend WithEvents principalTextBox As System.Windows.Forms.TextBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents balancesLabel As System.Windows.Forms.Label
   Friend WithEvents yearsLabel As System.Windows.Forms.Label
   Friend WithEvents interestRateLabel As System.Windows.Forms.Label
   Friend WithEvents principalLabel As System.Windows.Forms.Label
   Friend WithEvents resultsListBox As System.Windows.Forms.ListBox

End Class
