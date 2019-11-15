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
      Me.zeroButton = New System.Windows.Forms.Button()
      Me.doneButton = New System.Windows.Forms.Button()
      Me.debitButton = New System.Windows.Forms.Button()
      Me.creditButton = New System.Windows.Forms.Button()
      Me.openButton = New System.Windows.Forms.Button()
      Me.displayRichTextBox = New System.Windows.Forms.RichTextBox()
      Me.SuspendLayout()
      '
      'zeroButton
      '
      Me.zeroButton.Enabled = False
      Me.zeroButton.Location = New System.Drawing.Point(348, 138)
      Me.zeroButton.Name = "zeroButton"
      Me.zeroButton.Size = New System.Drawing.Size(107, 31)
      Me.zeroButton.TabIndex = 9
      Me.zeroButton.Text = "Zero Balances"
      '
      'doneButton
      '
      Me.doneButton.Location = New System.Drawing.Point(462, 138)
      Me.doneButton.Name = "doneButton"
      Me.doneButton.Size = New System.Drawing.Size(107, 31)
      Me.doneButton.TabIndex = 10
      Me.doneButton.Text = "Done"
      '
      'debitButton
      '
      Me.debitButton.Enabled = False
      Me.debitButton.Location = New System.Drawing.Point(236, 138)
      Me.debitButton.Name = "debitButton"
      Me.debitButton.Size = New System.Drawing.Size(107, 31)
      Me.debitButton.TabIndex = 8
      Me.debitButton.Text = "Debit Balances"
      '
      'creditButton
      '
      Me.creditButton.Enabled = False
      Me.creditButton.Location = New System.Drawing.Point(124, 138)
      Me.creditButton.Name = "creditButton"
      Me.creditButton.Size = New System.Drawing.Size(107, 31)
      Me.creditButton.TabIndex = 7
      Me.creditButton.Text = "Credit Balances"
      '
      'openButton
      '
      Me.openButton.Location = New System.Drawing.Point(12, 138)
      Me.openButton.Name = "openButton"
      Me.openButton.Size = New System.Drawing.Size(107, 31)
      Me.openButton.TabIndex = 6
      Me.openButton.Text = "Open File"
      '
      'displayRichTextBox
      '
      Me.displayRichTextBox.Location = New System.Drawing.Point(12, 12)
      Me.displayRichTextBox.Name = "displayRichTextBox"
      Me.displayRichTextBox.Size = New System.Drawing.Size(557, 120)
      Me.displayRichTextBox.TabIndex = 11
      Me.displayRichTextBox.Text = ""
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(581, 182)
      Me.Controls.Add(Me.zeroButton)
      Me.Controls.Add(Me.doneButton)
      Me.Controls.Add(Me.debitButton)
      Me.Controls.Add(Me.creditButton)
      Me.Controls.Add(Me.openButton)
      Me.Controls.Add(Me.displayRichTextBox)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Form1"
      Me.Text = "Credit Inquiry"
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents zeroButton As System.Windows.Forms.Button
   Private WithEvents doneButton As System.Windows.Forms.Button
   Private WithEvents debitButton As System.Windows.Forms.Button
   Private WithEvents creditButton As System.Windows.Forms.Button
   Private WithEvents openButton As System.Windows.Forms.Button
   Private WithEvents displayRichTextBox As System.Windows.Forms.RichTextBox

End Class
