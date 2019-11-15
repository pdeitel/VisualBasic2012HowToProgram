<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorDialogDemo
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
      Me.setBackgroundColorButton = New System.Windows.Forms.Button()
      Me.setTextColorButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'setBackgroundColorButton
      '
      Me.setBackgroundColorButton.Location = New System.Drawing.Point(12, 12)
      Me.setBackgroundColorButton.Name = "setBackgroundColorButton"
      Me.setBackgroundColorButton.Size = New System.Drawing.Size(205, 23)
      Me.setBackgroundColorButton.TabIndex = 0
      Me.setBackgroundColorButton.Text = "Set Background Color"
      Me.setBackgroundColorButton.UseVisualStyleBackColor = True
      '
      'setTextColorButton
      '
      Me.setTextColorButton.Location = New System.Drawing.Point(12, 41)
      Me.setTextColorButton.Name = "setTextColorButton"
      Me.setTextColorButton.Size = New System.Drawing.Size(205, 23)
      Me.setTextColorButton.TabIndex = 1
      Me.setTextColorButton.Text = "Set Text Color"
      Me.setTextColorButton.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(229, 76)
      Me.Controls.Add(Me.setTextColorButton)
      Me.Controls.Add(Me.setBackgroundColorButton)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Form1"
      Me.Text = "ColorDialog Demo"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents setBackgroundColorButton As System.Windows.Forms.Button
   Friend WithEvents setTextColorButton As System.Windows.Forms.Button

End Class
