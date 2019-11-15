<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FundRaiser
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
      Me.totalDonationsLabel = New System.Windows.Forms.Label()
      Me.donationAfterExpensesLabel = New System.Windows.Forms.Label()
      Me.donationTextBox = New System.Windows.Forms.TextBox()
      Me.donateButton = New System.Windows.Forms.Button()
      Me.totalRaisedLabel = New System.Windows.Forms.Label()
      Me.afterExpensesLabel = New System.Windows.Forms.Label()
      Me.donationLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'totalDonationsLabel
      '
      Me.totalDonationsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.totalDonationsLabel.Location = New System.Drawing.Point(108, 69)
      Me.totalDonationsLabel.Name = "totalDonationsLabel"
      Me.totalDonationsLabel.Size = New System.Drawing.Size(100, 23)
      Me.totalDonationsLabel.TabIndex = 13
      Me.totalDonationsLabel.Text = "$0.00"
      Me.totalDonationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'donationAfterExpensesLabel
      '
      Me.donationAfterExpensesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.donationAfterExpensesLabel.Location = New System.Drawing.Point(108, 40)
      Me.donationAfterExpensesLabel.Name = "donationAfterExpensesLabel"
      Me.donationAfterExpensesLabel.Size = New System.Drawing.Size(100, 23)
      Me.donationAfterExpensesLabel.TabIndex = 12
      Me.donationAfterExpensesLabel.Text = "$0.00"
      Me.donationAfterExpensesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'donationTextBox
      '
      Me.donationTextBox.Location = New System.Drawing.Point(108, 12)
      Me.donationTextBox.Name = "donationTextBox"
      Me.donationTextBox.Size = New System.Drawing.Size(100, 23)
      Me.donationTextBox.TabIndex = 11
      '
      'donateButton
      '
      Me.donateButton.Location = New System.Drawing.Point(214, 12)
      Me.donateButton.Name = "donateButton"
      Me.donateButton.Size = New System.Drawing.Size(75, 23)
      Me.donateButton.TabIndex = 10
      Me.donateButton.Text = "Donate"
      Me.donateButton.UseVisualStyleBackColor = True
      '
      'totalRaisedLabel
      '
      Me.totalRaisedLabel.AutoSize = True
      Me.totalRaisedLabel.Location = New System.Drawing.Point(12, 73)
      Me.totalRaisedLabel.Name = "totalRaisedLabel"
      Me.totalRaisedLabel.Size = New System.Drawing.Size(71, 15)
      Me.totalRaisedLabel.TabIndex = 9
      Me.totalRaisedLabel.Text = "Total raised:"
      '
      'afterExpensesLabel
      '
      Me.afterExpensesLabel.AutoSize = True
      Me.afterExpensesLabel.Location = New System.Drawing.Point(12, 44)
      Me.afterExpensesLabel.Name = "afterExpensesLabel"
      Me.afterExpensesLabel.Size = New System.Drawing.Size(86, 15)
      Me.afterExpensesLabel.TabIndex = 8
      Me.afterExpensesLabel.Text = "After expenses:"
      '
      'donationLabel
      '
      Me.donationLabel.AutoSize = True
      Me.donationLabel.Location = New System.Drawing.Point(12, 15)
      Me.donationLabel.Name = "donationLabel"
      Me.donationLabel.Size = New System.Drawing.Size(59, 15)
      Me.donationLabel.TabIndex = 7
      Me.donationLabel.Text = "Donation:"
      '
      'FundRaiser
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(300, 104)
      Me.Controls.Add(Me.totalDonationsLabel)
      Me.Controls.Add(Me.donationAfterExpensesLabel)
      Me.Controls.Add(Me.donationTextBox)
      Me.Controls.Add(Me.donateButton)
      Me.Controls.Add(Me.totalRaisedLabel)
      Me.Controls.Add(Me.afterExpensesLabel)
      Me.Controls.Add(Me.donationLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "FundRaiser"
      Me.Text = "Fund Raiser"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents totalDonationsLabel As System.Windows.Forms.Label
   Friend WithEvents donationAfterExpensesLabel As System.Windows.Forms.Label
   Friend WithEvents donationTextBox As System.Windows.Forms.TextBox
   Friend WithEvents donateButton As System.Windows.Forms.Button
   Friend WithEvents totalRaisedLabel As System.Windows.Forms.Label
   Friend WithEvents afterExpensesLabel As System.Windows.Forms.Label
   Friend WithEvents donationLabel As System.Windows.Forms.Label

End Class
