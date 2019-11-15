<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileTest
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
      Me.enterLabel = New System.Windows.Forms.Label()
      Me.outputTextBox = New System.Windows.Forms.TextBox()
      Me.inputTextBox = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'enterLabel
      '
      Me.enterLabel.AutoSize = True
      Me.enterLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.enterLabel.Location = New System.Drawing.Point(12, 9)
      Me.enterLabel.Name = "enterLabel"
      Me.enterLabel.Size = New System.Drawing.Size(210, 15)
      Me.enterLabel.TabIndex = 14
      Me.enterLabel.Text = "Enter file or directory, then press Enter:"
      '
      'outputTextBox
      '
      Me.outputTextBox.Location = New System.Drawing.Point(12, 56)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.outputTextBox.Size = New System.Drawing.Size(314, 273)
      Me.outputTextBox.TabIndex = 13
      '
      'inputTextBox
      '
      Me.inputTextBox.AcceptsTab = True
      Me.inputTextBox.Location = New System.Drawing.Point(12, 27)
      Me.inputTextBox.Name = "inputTextBox"
      Me.inputTextBox.Size = New System.Drawing.Size(314, 23)
      Me.inputTextBox.TabIndex = 12
      '
      'FileTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(340, 344)
      Me.Controls.Add(Me.enterLabel)
      Me.Controls.Add(Me.outputTextBox)
      Me.Controls.Add(Me.inputTextBox)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "FileTest"
      Me.Text = "File Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents enterLabel As System.Windows.Forms.Label
   Private WithEvents outputTextBox As System.Windows.Forms.TextBox
   Private WithEvents inputTextBox As System.Windows.Forms.TextBox

End Class
