<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditInquiry
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
      Me.applicationMenuStrip = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.accountsTextBox = New System.Windows.Forms.TextBox()
      Me.creditBalancesButton = New System.Windows.Forms.Button()
      Me.debitBalancesButton = New System.Windows.Forms.Button()
      Me.zeroBalancesButton = New System.Windows.Forms.Button()
      Me.applicationMenuStrip.SuspendLayout()
      Me.SuspendLayout()
      '
      'applicationMenuStrip
      '
      Me.applicationMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
      Me.applicationMenuStrip.Location = New System.Drawing.Point(0, 0)
      Me.applicationMenuStrip.Name = "applicationMenuStrip"
      Me.applicationMenuStrip.Size = New System.Drawing.Size(517, 24)
      Me.applicationMenuStrip.TabIndex = 0
      Me.applicationMenuStrip.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'OpenToolStripMenuItem
      '
      Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
      Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
      Me.OpenToolStripMenuItem.Text = "&Open..."
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'accountsTextBox
      '
      Me.accountsTextBox.Location = New System.Drawing.Point(12, 27)
      Me.accountsTextBox.Multiline = True
      Me.accountsTextBox.Name = "accountsTextBox"
      Me.accountsTextBox.Size = New System.Drawing.Size(493, 92)
      Me.accountsTextBox.TabIndex = 2
      '
      'creditBalancesButton
      '
      Me.creditBalancesButton.Enabled = False
      Me.creditBalancesButton.Location = New System.Drawing.Point(203, 125)
      Me.creditBalancesButton.Name = "creditBalancesButton"
      Me.creditBalancesButton.Size = New System.Drawing.Size(110, 23)
      Me.creditBalancesButton.TabIndex = 2
      Me.creditBalancesButton.Text = "Credit Balances"
      Me.creditBalancesButton.UseVisualStyleBackColor = True
      '
      'debitBalancesButton
      '
      Me.debitBalancesButton.Enabled = False
      Me.debitBalancesButton.Location = New System.Drawing.Point(87, 125)
      Me.debitBalancesButton.Name = "debitBalancesButton"
      Me.debitBalancesButton.Size = New System.Drawing.Size(110, 23)
      Me.debitBalancesButton.TabIndex = 1
      Me.debitBalancesButton.Text = "Debit Balances"
      Me.debitBalancesButton.UseVisualStyleBackColor = True
      '
      'zeroBalancesButton
      '
      Me.zeroBalancesButton.Enabled = False
      Me.zeroBalancesButton.Location = New System.Drawing.Point(319, 125)
      Me.zeroBalancesButton.Name = "zeroBalancesButton"
      Me.zeroBalancesButton.Size = New System.Drawing.Size(110, 23)
      Me.zeroBalancesButton.TabIndex = 3
      Me.zeroBalancesButton.Text = "Zero Balances"
      Me.zeroBalancesButton.UseVisualStyleBackColor = True
      '
      'CreditInquiry
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(517, 158)
      Me.Controls.Add(Me.zeroBalancesButton)
      Me.Controls.Add(Me.debitBalancesButton)
      Me.Controls.Add(Me.creditBalancesButton)
      Me.Controls.Add(Me.accountsTextBox)
      Me.Controls.Add(Me.applicationMenuStrip)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "CreditInquiry"
      Me.Text = "Credit Inquiry"
      Me.applicationMenuStrip.ResumeLayout(False)
      Me.applicationMenuStrip.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents applicationMenuStrip As System.Windows.Forms.MenuStrip
   Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents accountsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents creditBalancesButton As System.Windows.Forms.Button
   Friend WithEvents debitBalancesButton As System.Windows.Forms.Button
   Friend WithEvents zeroBalancesButton As System.Windows.Forms.Button

End Class
