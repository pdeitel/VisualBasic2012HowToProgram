<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFile
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
      Me.exitButton = New System.Windows.Forms.Button()
      Me.enterButton = New System.Windows.Forms.Button()
      Me.saveButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'exitButton
      '
      Me.exitButton.Location = New System.Drawing.Point(220, 194)
      Me.exitButton.Name = "exitButton"
      Me.exitButton.Size = New System.Drawing.Size(86, 31)
      Me.exitButton.TabIndex = 42
      Me.exitButton.Text = "Exit"
      '
      'enterButton
      '
      Me.enterButton.Enabled = False
      Me.enterButton.Location = New System.Drawing.Point(124, 194)
      Me.enterButton.Name = "enterButton"
      Me.enterButton.Size = New System.Drawing.Size(86, 31)
      Me.enterButton.TabIndex = 41
      Me.enterButton.Text = "Enter"
      '
      'saveButton
      '
      Me.saveButton.Location = New System.Drawing.Point(25, 194)
      Me.saveButton.Name = "saveButton"
      Me.saveButton.Size = New System.Drawing.Size(86, 31)
      Me.saveButton.TabIndex = 40
      Me.saveButton.Text = "Save As"
      '
      'CreateFile
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(331, 240)
      Me.Controls.Add(Me.exitButton)
      Me.Controls.Add(Me.enterButton)
      Me.Controls.Add(Me.saveButton)
      Me.Name = "CreateFile"
      Me.Text = "Creating a Sequential File"
      Me.Controls.SetChildIndex(Me.accountLabel, 0)
      Me.Controls.SetChildIndex(Me.firstNameLabel, 0)
      Me.Controls.SetChildIndex(Me.lastNameLabel, 0)
      Me.Controls.SetChildIndex(Me.balanceLabel, 0)
      Me.Controls.SetChildIndex(Me.accountTextBox, 0)
      Me.Controls.SetChildIndex(Me.firstNameTextBox, 0)
      Me.Controls.SetChildIndex(Me.lastNameTextBox, 0)
      Me.Controls.SetChildIndex(Me.balanceTextBox, 0)
      Me.Controls.SetChildIndex(Me.saveButton, 0)
      Me.Controls.SetChildIndex(Me.enterButton, 0)
      Me.Controls.SetChildIndex(Me.exitButton, 0)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents exitButton As System.Windows.Forms.Button
   Private WithEvents enterButton As System.Windows.Forms.Button
   Private WithEvents saveButton As System.Windows.Forms.Button

End Class
