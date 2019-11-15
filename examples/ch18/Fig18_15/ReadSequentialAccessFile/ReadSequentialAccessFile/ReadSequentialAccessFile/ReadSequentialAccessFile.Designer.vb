<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadSequentialAccessFile
   Inherits BankLibrary.BankUIForm

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
      Me.openButton = New System.Windows.Forms.Button()
      Me.nextButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'openButton
      '
      Me.openButton.Location = New System.Drawing.Point(39, 196)
      Me.openButton.Name = "openButton"
      Me.openButton.Size = New System.Drawing.Size(116, 44)
      Me.openButton.TabIndex = 40
      Me.openButton.Text = "Open File"
      '
      'nextButton
      '
      Me.nextButton.Enabled = False
      Me.nextButton.Location = New System.Drawing.Point(172, 196)
      Me.nextButton.Name = "nextButton"
      Me.nextButton.Size = New System.Drawing.Size(119, 44)
      Me.nextButton.TabIndex = 41
      Me.nextButton.Text = "Next Record"
      '
      'ReadSequentialAccessFile
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(331, 260)
      Me.Controls.Add(Me.openButton)
      Me.Controls.Add(Me.nextButton)
      Me.Name = "ReadSequentialAccessFile"
      Me.Text = "Reading a Sequential Access File"
      Me.Controls.SetChildIndex(Me.accountLabel, 0)
      Me.Controls.SetChildIndex(Me.firstNameLabel, 0)
      Me.Controls.SetChildIndex(Me.lastNameLabel, 0)
      Me.Controls.SetChildIndex(Me.balanceLabel, 0)
      Me.Controls.SetChildIndex(Me.accountTextBox, 0)
      Me.Controls.SetChildIndex(Me.firstNameTextBox, 0)
      Me.Controls.SetChildIndex(Me.lastNameTextBox, 0)
      Me.Controls.SetChildIndex(Me.balanceTextBox, 0)
      Me.Controls.SetChildIndex(Me.nextButton, 0)
      Me.Controls.SetChildIndex(Me.openButton, 0)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents openButton As System.Windows.Forms.Button
   Private WithEvents nextButton As System.Windows.Forms.Button

End Class
