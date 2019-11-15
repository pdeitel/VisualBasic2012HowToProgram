<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XDocumentTest
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
      Me.outputTextBox = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'outputTextBox
      '
      Me.outputTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.outputTextBox.BackColor = System.Drawing.Color.White
      Me.outputTextBox.Font = New System.Drawing.Font("Courier New", 8.25!)
      Me.outputTextBox.Location = New System.Drawing.Point(13, 13)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.ReadOnly = True
      Me.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.outputTextBox.Size = New System.Drawing.Size(453, 378)
      Me.outputTextBox.TabIndex = 3
      Me.outputTextBox.TabStop = False
      Me.outputTextBox.WordWrap = False
      '
      'XDocumentTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(478, 404)
      Me.Controls.Add(Me.outputTextBox)
      Me.Name = "XDocumentTest"
      Me.Text = "XDocument Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents outputTextBox As System.Windows.Forms.TextBox

End Class
