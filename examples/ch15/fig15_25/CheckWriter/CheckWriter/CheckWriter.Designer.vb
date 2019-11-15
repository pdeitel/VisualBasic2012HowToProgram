<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckWriter
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckWriter))
      Me.printButton = New System.Windows.Forms.Button()
      Me.previewButton = New System.Windows.Forms.Button()
      Me.abaLabel = New System.Windows.Forms.Label()
      Me.accountLabel = New System.Windows.Forms.Label()
      Me.underlineLabel = New System.Windows.Forms.Label()
      Me.signedLabel = New System.Windows.Forms.Label()
      Me.memoTextBox = New System.Windows.Forms.TextBox()
      Me.memoLabel = New System.Windows.Forms.Label()
      Me.dollarsLabel = New System.Windows.Forms.Label()
      Me.dollarsTextBox = New System.Windows.Forms.TextBox()
      Me.payeeTextBox = New System.Windows.Forms.TextBox()
      Me.payeeLabel = New System.Windows.Forms.Label()
      Me.amountLabel = New System.Windows.Forms.Label()
      Me.amountTextBox = New System.Windows.Forms.TextBox()
      Me.printPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
      Me.dateLabel = New System.Windows.Forms.Label()
      Me.dateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.checkNumberLabel = New System.Windows.Forms.Label()
      Me.checkNumberTextBox = New System.Windows.Forms.TextBox()
      Me.payerTextBox = New System.Windows.Forms.TextBox()
      Me.printDocument = New System.Drawing.Printing.PrintDocument()
      Me.SuspendLayout()
      '
      'printButton
      '
      Me.printButton.Location = New System.Drawing.Point(459, 269)
      Me.printButton.Name = "printButton"
      Me.printButton.Size = New System.Drawing.Size(75, 23)
      Me.printButton.TabIndex = 27
      Me.printButton.Text = "Print"
      Me.printButton.UseVisualStyleBackColor = True
      '
      'previewButton
      '
      Me.previewButton.Location = New System.Drawing.Point(378, 269)
      Me.previewButton.Name = "previewButton"
      Me.previewButton.Size = New System.Drawing.Size(75, 23)
      Me.previewButton.TabIndex = 26
      Me.previewButton.Text = "Preview"
      Me.previewButton.UseVisualStyleBackColor = True
      '
      'abaLabel
      '
      Me.abaLabel.AutoSize = True
      Me.abaLabel.Location = New System.Drawing.Point(24, 225)
      Me.abaLabel.Name = "abaLabel"
      Me.abaLabel.Size = New System.Drawing.Size(61, 13)
      Me.abaLabel.TabIndex = 33
      Me.abaLabel.Text = "000000000"
      '
      'accountLabel
      '
      Me.accountLabel.AutoSize = True
      Me.accountLabel.Location = New System.Drawing.Point(162, 225)
      Me.accountLabel.Name = "accountLabel"
      Me.accountLabel.Size = New System.Drawing.Size(61, 13)
      Me.accountLabel.TabIndex = 34
      Me.accountLabel.Text = "123456789"
      '
      'underlineLabel
      '
      Me.underlineLabel.AutoSize = True
      Me.underlineLabel.Location = New System.Drawing.Point(359, 202)
      Me.underlineLabel.Name = "underlineLabel"
      Me.underlineLabel.Size = New System.Drawing.Size(175, 13)
      Me.underlineLabel.TabIndex = 36
      Me.underlineLabel.Text = "____________________________"
      '
      'signedLabel
      '
      Me.signedLabel.AutoSize = True
      Me.signedLabel.Location = New System.Drawing.Point(313, 202)
      Me.signedLabel.Name = "signedLabel"
      Me.signedLabel.Size = New System.Drawing.Size(40, 13)
      Me.signedLabel.TabIndex = 35
      Me.signedLabel.Text = "Signed"
      '
      'memoTextBox
      '
      Me.memoTextBox.Location = New System.Drawing.Point(57, 199)
      Me.memoTextBox.Name = "memoTextBox"
      Me.memoTextBox.Size = New System.Drawing.Size(166, 20)
      Me.memoTextBox.TabIndex = 25
      '
      'memoLabel
      '
      Me.memoLabel.AutoSize = True
      Me.memoLabel.Location = New System.Drawing.Point(9, 202)
      Me.memoLabel.Name = "memoLabel"
      Me.memoLabel.Size = New System.Drawing.Size(36, 13)
      Me.memoLabel.TabIndex = 32
      Me.memoLabel.Text = "Memo"
      '
      'dollarsLabel
      '
      Me.dollarsLabel.AutoSize = True
      Me.dollarsLabel.Location = New System.Drawing.Point(495, 161)
      Me.dollarsLabel.Name = "dollarsLabel"
      Me.dollarsLabel.Size = New System.Drawing.Size(39, 13)
      Me.dollarsLabel.TabIndex = 37
      Me.dollarsLabel.Text = "Dollars"
      '
      'dollarsTextBox
      '
      Me.dollarsTextBox.Location = New System.Drawing.Point(15, 158)
      Me.dollarsTextBox.Name = "dollarsTextBox"
      Me.dollarsTextBox.Size = New System.Drawing.Size(472, 20)
      Me.dollarsTextBox.TabIndex = 24
      '
      'payeeTextBox
      '
      Me.payeeTextBox.Location = New System.Drawing.Point(120, 118)
      Me.payeeTextBox.Name = "payeeTextBox"
      Me.payeeTextBox.Size = New System.Drawing.Size(411, 20)
      Me.payeeTextBox.TabIndex = 23
      '
      'payeeLabel
      '
      Me.payeeLabel.AutoSize = True
      Me.payeeLabel.Location = New System.Drawing.Point(12, 121)
      Me.payeeLabel.Name = "payeeLabel"
      Me.payeeLabel.Size = New System.Drawing.Size(98, 13)
      Me.payeeLabel.TabIndex = 31
      Me.payeeLabel.Text = "Pay to the Order Of"
      Me.payeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'amountLabel
      '
      Me.amountLabel.AutoSize = True
      Me.amountLabel.Location = New System.Drawing.Point(332, 73)
      Me.amountLabel.Name = "amountLabel"
      Me.amountLabel.Size = New System.Drawing.Size(52, 13)
      Me.amountLabel.TabIndex = 30
      Me.amountLabel.Text = "Amount $"
      '
      'amountTextBox
      '
      Me.amountTextBox.Location = New System.Drawing.Point(390, 70)
      Me.amountTextBox.Name = "amountTextBox"
      Me.amountTextBox.Size = New System.Drawing.Size(141, 20)
      Me.amountTextBox.TabIndex = 22
      '
      'printPreviewDialog
      '
      Me.printPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
      Me.printPreviewDialog.Enabled = True
      Me.printPreviewDialog.Icon = CType(resources.GetObject("printPreviewDialog.Icon"), System.Drawing.Icon)
      Me.printPreviewDialog.Name = "previewObject"
      Me.printPreviewDialog.UseAntiAlias = True
      Me.printPreviewDialog.Visible = False
      '
      'dateLabel
      '
      Me.dateLabel.AutoSize = True
      Me.dateLabel.Location = New System.Drawing.Point(354, 44)
      Me.dateLabel.Name = "dateLabel"
      Me.dateLabel.Size = New System.Drawing.Size(30, 13)
      Me.dateLabel.TabIndex = 29
      Me.dateLabel.Text = "Date"
      '
      'dateTimePicker
      '
      Me.dateTimePicker.CustomFormat = "MMMM d, yyyy"
      Me.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dateTimePicker.Location = New System.Drawing.Point(390, 41)
      Me.dateTimePicker.Name = "dateTimePicker"
      Me.dateTimePicker.Size = New System.Drawing.Size(141, 20)
      Me.dateTimePicker.TabIndex = 21
      '
      'checkNumberLabel
      '
      Me.checkNumberLabel.AutoSize = True
      Me.checkNumberLabel.Location = New System.Drawing.Point(467, 15)
      Me.checkNumberLabel.Name = "checkNumberLabel"
      Me.checkNumberLabel.Size = New System.Drawing.Size(24, 13)
      Me.checkNumberLabel.TabIndex = 28
      Me.checkNumberLabel.Text = "No."
      '
      'checkNumberTextBox
      '
      Me.checkNumberTextBox.Location = New System.Drawing.Point(497, 12)
      Me.checkNumberTextBox.Name = "checkNumberTextBox"
      Me.checkNumberTextBox.Size = New System.Drawing.Size(34, 20)
      Me.checkNumberTextBox.TabIndex = 20
      '
      'payerTextBox
      '
      Me.payerTextBox.AcceptsReturn = True
      Me.payerTextBox.Location = New System.Drawing.Point(12, 12)
      Me.payerTextBox.Multiline = True
      Me.payerTextBox.Name = "payerTextBox"
      Me.payerTextBox.Size = New System.Drawing.Size(147, 53)
      Me.payerTextBox.TabIndex = 19
      '
      'printDocument
      '
      '
      'CheckWriter
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(546, 304)
      Me.Controls.Add(Me.printButton)
      Me.Controls.Add(Me.previewButton)
      Me.Controls.Add(Me.abaLabel)
      Me.Controls.Add(Me.accountLabel)
      Me.Controls.Add(Me.underlineLabel)
      Me.Controls.Add(Me.signedLabel)
      Me.Controls.Add(Me.memoTextBox)
      Me.Controls.Add(Me.memoLabel)
      Me.Controls.Add(Me.dollarsLabel)
      Me.Controls.Add(Me.dollarsTextBox)
      Me.Controls.Add(Me.payeeTextBox)
      Me.Controls.Add(Me.payeeLabel)
      Me.Controls.Add(Me.amountLabel)
      Me.Controls.Add(Me.amountTextBox)
      Me.Controls.Add(Me.dateLabel)
      Me.Controls.Add(Me.dateTimePicker)
      Me.Controls.Add(Me.checkNumberLabel)
      Me.Controls.Add(Me.checkNumberTextBox)
      Me.Controls.Add(Me.payerTextBox)
      Me.Name = "CheckWriter"
      Me.Text = "Check Writer"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents printButton As System.Windows.Forms.Button
   Friend WithEvents previewButton As System.Windows.Forms.Button
   Friend WithEvents abaLabel As System.Windows.Forms.Label
   Friend WithEvents accountLabel As System.Windows.Forms.Label
   Friend WithEvents underlineLabel As System.Windows.Forms.Label
   Friend WithEvents signedLabel As System.Windows.Forms.Label
   Friend WithEvents memoTextBox As System.Windows.Forms.TextBox
   Friend WithEvents memoLabel As System.Windows.Forms.Label
   Friend WithEvents dollarsLabel As System.Windows.Forms.Label
   Friend WithEvents dollarsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents payeeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents payeeLabel As System.Windows.Forms.Label
   Friend WithEvents amountLabel As System.Windows.Forms.Label
   Friend WithEvents amountTextBox As System.Windows.Forms.TextBox
   Friend WithEvents printPreviewDialog As System.Windows.Forms.PrintPreviewDialog
   Friend WithEvents dateLabel As System.Windows.Forms.Label
   Friend WithEvents dateTimePicker As System.Windows.Forms.DateTimePicker
   Friend WithEvents checkNumberLabel As System.Windows.Forms.Label
   Friend WithEvents checkNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents payerTextBox As System.Windows.Forms.TextBox
   Friend WithEvents printDocument As System.Drawing.Printing.PrintDocument

End Class
