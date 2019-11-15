<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountCalculator
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
      Me.amountLabel = New System.Windows.Forms.Label()
      Me.amountTextBox = New System.Windows.Forms.TextBox()
      Me.viewDiscountButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'amountLabel
      '
      Me.amountLabel.AutoSize = True
      Me.amountLabel.Location = New System.Drawing.Point(12, 16)
      Me.amountLabel.Name = "amountLabel"
      Me.amountLabel.Size = New System.Drawing.Size(82, 15)
      Me.amountLabel.TabIndex = 0
      Me.amountLabel.Text = "Enter amount:"
      '
      'amountTextBox
      '
      Me.amountTextBox.Location = New System.Drawing.Point(102, 12)
      Me.amountTextBox.Name = "amountTextBox"
      Me.amountTextBox.Size = New System.Drawing.Size(100, 23)
      Me.amountTextBox.TabIndex = 1
      '
      'viewDiscountButton
      '
      Me.viewDiscountButton.Location = New System.Drawing.Point(208, 12)
      Me.viewDiscountButton.Name = "viewDiscountButton"
      Me.viewDiscountButton.Size = New System.Drawing.Size(96, 23)
      Me.viewDiscountButton.TabIndex = 2
      Me.viewDiscountButton.Text = "View Discount"
      Me.viewDiscountButton.UseVisualStyleBackColor = True
      '
      'DiscountCalculator
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(318, 47)
      Me.Controls.Add(Me.viewDiscountButton)
      Me.Controls.Add(Me.amountTextBox)
      Me.Controls.Add(Me.amountLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "DiscountCalculator"
      Me.Text = "Discount Calculator"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents amountLabel As System.Windows.Forms.Label
   Friend WithEvents amountTextBox As System.Windows.Forms.TextBox
   Friend WithEvents viewDiscountButton As System.Windows.Forms.Button

End Class
