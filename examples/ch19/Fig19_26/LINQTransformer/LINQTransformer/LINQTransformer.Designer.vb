<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINQTransformer
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
      Me.xmlOpenDialog = New System.Windows.Forms.OpenFileDialog()
      Me.convertButton = New System.Windows.Forms.Button()
      Me.browseButton = New System.Windows.Forms.Button()
      Me.fileTextBox = New System.Windows.Forms.TextBox()
      Me.xmlLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'convertButton
      '
      Me.convertButton.Location = New System.Drawing.Point(60, 53)
      Me.convertButton.Name = "convertButton"
      Me.convertButton.Size = New System.Drawing.Size(158, 50)
      Me.convertButton.TabIndex = 11
      Me.convertButton.Text = "Convert to HTML"
      Me.convertButton.UseVisualStyleBackColor = True
      '
      'browseButton
      '
      Me.browseButton.Location = New System.Drawing.Point(197, 24)
      Me.browseButton.Name = "browseButton"
      Me.browseButton.Size = New System.Drawing.Size(64, 23)
      Me.browseButton.TabIndex = 10
      Me.browseButton.Text = "Browse..."
      Me.browseButton.UseVisualStyleBackColor = True
      '
      'fileTextBox
      '
      Me.fileTextBox.Location = New System.Drawing.Point(12, 26)
      Me.fileTextBox.Name = "fileTextBox"
      Me.fileTextBox.Size = New System.Drawing.Size(179, 20)
      Me.fileTextBox.TabIndex = 9
      '
      'xmlLabel
      '
      Me.xmlLabel.AutoSize = True
      Me.xmlLabel.Location = New System.Drawing.Point(12, 10)
      Me.xmlLabel.Name = "xmlLabel"
      Me.xmlLabel.Size = New System.Drawing.Size(106, 13)
      Me.xmlLabel.TabIndex = 8
      Me.xmlLabel.Text = "XML file to transform:"
      '
      'LINQTransformer
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(273, 112)
      Me.Controls.Add(Me.convertButton)
      Me.Controls.Add(Me.browseButton)
      Me.Controls.Add(Me.fileTextBox)
      Me.Controls.Add(Me.xmlLabel)
      Me.Name = "LINQTransformer"
      Me.Text = "LINQ Transformer"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents xmlOpenDialog As System.Windows.Forms.OpenFileDialog
   Friend WithEvents convertButton As System.Windows.Forms.Button
   Friend WithEvents browseButton As System.Windows.Forms.Button
   Friend WithEvents fileTextBox As System.Windows.Forms.TextBox
   Friend WithEvents xmlLabel As System.Windows.Forms.Label

End Class
