<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OddNumbers
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
      Me.resultsListBox = New System.Windows.Forms.ListBox()
      Me.displayButton = New System.Windows.Forms.Button()
      Me.limitTextBox = New System.Windows.Forms.TextBox()
      Me.limitLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'resultsListBox
      '
      Me.resultsListBox.FormattingEnabled = True
      Me.resultsListBox.ItemHeight = 15
      Me.resultsListBox.Location = New System.Drawing.Point(12, 41)
      Me.resultsListBox.Name = "resultsListBox"
      Me.resultsListBox.Size = New System.Drawing.Size(223, 109)
      Me.resultsListBox.TabIndex = 7
      '
      'displayButton
      '
      Me.displayButton.Location = New System.Drawing.Point(160, 11)
      Me.displayButton.Name = "displayButton"
      Me.displayButton.Size = New System.Drawing.Size(75, 23)
      Me.displayButton.TabIndex = 6
      Me.displayButton.Text = "Display"
      Me.displayButton.UseVisualStyleBackColor = True
      '
      'limitTextBox
      '
      Me.limitTextBox.Location = New System.Drawing.Point(87, 12)
      Me.limitTextBox.Name = "limitTextBox"
      Me.limitTextBox.Size = New System.Drawing.Size(67, 23)
      Me.limitTextBox.TabIndex = 5
      '
      'limitLabel
      '
      Me.limitLabel.AutoSize = True
      Me.limitLabel.Location = New System.Drawing.Point(12, 15)
      Me.limitLabel.Name = "limitLabel"
      Me.limitLabel.Size = New System.Drawing.Size(69, 15)
      Me.limitLabel.TabIndex = 4
      Me.limitLabel.Text = "Upper limit:"
      Me.limitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'OddNumbers
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(248, 162)
      Me.Controls.Add(Me.resultsListBox)
      Me.Controls.Add(Me.displayButton)
      Me.Controls.Add(Me.limitTextBox)
      Me.Controls.Add(Me.limitLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "OddNumbers"
      Me.Text = "Odd Numbers"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents resultsListBox As System.Windows.Forms.ListBox
   Friend WithEvents displayButton As System.Windows.Forms.Button
   Friend WithEvents limitTextBox As System.Windows.Forms.TextBox
   Friend WithEvents limitLabel As System.Windows.Forms.Label

End Class
