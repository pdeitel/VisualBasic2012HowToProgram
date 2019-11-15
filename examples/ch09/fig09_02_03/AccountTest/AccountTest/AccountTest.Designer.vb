<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountTest
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
      Me.xc = New System.Windows.Forms.Label()
      Me.inputTextBox = New System.Windows.Forms.TextBox()
      Me.depositButton = New System.Windows.Forms.Button()
      Me.withdrawButton = New System.Windows.Forms.Button()
      Me.accountBalanceValueLabel = New System.Windows.Forms.Label()
      Me.accountBalanceLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'xc
      '
      Me.xc.AutoSize = True
      Me.xc.Location = New System.Drawing.Point(12, 15)
      Me.xc.Name = "xc"
      Me.xc.Size = New System.Drawing.Size(199, 15)
      Me.xc.TabIndex = 0
      Me.xc.Text = "Enter deposit or withdrawal amount:"
      '
      'inputTextBox
      '
      Me.inputTextBox.Location = New System.Drawing.Point(217, 12)
      Me.inputTextBox.Name = "inputTextBox"
      Me.inputTextBox.Size = New System.Drawing.Size(100, 23)
      Me.inputTextBox.TabIndex = 1
      '
      'depositButton
      '
      Me.depositButton.Location = New System.Drawing.Point(15, 41)
      Me.depositButton.Name = "depositButton"
      Me.depositButton.Size = New System.Drawing.Size(75, 23)
      Me.depositButton.TabIndex = 2
      Me.depositButton.Text = "Deposit"
      Me.depositButton.UseVisualStyleBackColor = True
      '
      'withdrawButton
      '
      Me.withdrawButton.Location = New System.Drawing.Point(96, 41)
      Me.withdrawButton.Name = "withdrawButton"
      Me.withdrawButton.Size = New System.Drawing.Size(75, 23)
      Me.withdrawButton.TabIndex = 3
      Me.withdrawButton.Text = "Withdraw"
      Me.withdrawButton.UseVisualStyleBackColor = True
      '
      'accountBalanceValueLabel
      '
      Me.accountBalanceValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.accountBalanceValueLabel.Location = New System.Drawing.Point(242, 76)
      Me.accountBalanceValueLabel.Name = "accountBalanceValueLabel"
      Me.accountBalanceValueLabel.Size = New System.Drawing.Size(75, 24)
      Me.accountBalanceValueLabel.TabIndex = 4
      Me.accountBalanceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'accountBalanceLabel
      '
      Me.accountBalanceLabel.AutoSize = True
      Me.accountBalanceLabel.Location = New System.Drawing.Point(137, 81)
      Me.accountBalanceLabel.Name = "accountBalanceLabel"
      Me.accountBalanceLabel.Size = New System.Drawing.Size(99, 15)
      Me.accountBalanceLabel.TabIndex = 5
      Me.accountBalanceLabel.Text = "Account Balance:"
      '
      'AccountTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(330, 109)
      Me.Controls.Add(Me.accountBalanceLabel)
      Me.Controls.Add(Me.accountBalanceValueLabel)
      Me.Controls.Add(Me.withdrawButton)
      Me.Controls.Add(Me.depositButton)
      Me.Controls.Add(Me.inputTextBox)
      Me.Controls.Add(Me.xc)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "AccountTest"
      Me.Text = "Testing Class Account"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents xc As System.Windows.Forms.Label
   Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents depositButton As System.Windows.Forms.Button
   Friend WithEvents withdrawButton As System.Windows.Forms.Button
   Friend WithEvents accountBalanceValueLabel As System.Windows.Forms.Label
   Friend WithEvents accountBalanceLabel As System.Windows.Forms.Label

End Class
