<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoiningTableData
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
      Me.outputTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.outputTextBox.Location = New System.Drawing.Point(12, 12)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.outputTextBox.Size = New System.Drawing.Size(635, 278)
      Me.outputTextBox.TabIndex = 2
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(659, 302)
      Me.Controls.Add(Me.outputTextBox)
      Me.Name = "Form1"
      Me.Text = "Joining Tables with LINQ"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents outputTextBox As System.Windows.Forms.TextBox

End Class
