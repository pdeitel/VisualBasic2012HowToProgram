<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkLabelTest
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
      Me.notepadLinkLabel = New System.Windows.Forms.LinkLabel()
      Me.deitelLinkLabel = New System.Windows.Forms.LinkLabel()
      Me.cDriveLinkLabel = New System.Windows.Forms.LinkLabel()
      Me.SuspendLayout()
      '
      'notepadLinkLabel
      '
      Me.notepadLinkLabel.AutoSize = True
      Me.notepadLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.notepadLinkLabel.Location = New System.Drawing.Point(12, 57)
      Me.notepadLinkLabel.Name = "notepadLinkLabel"
      Me.notepadLinkLabel.Size = New System.Drawing.Size(117, 15)
      Me.notepadLinkLabel.TabIndex = 11
      Me.notepadLinkLabel.TabStop = True
      Me.notepadLinkLabel.Text = "Click to run Notepad"
      '
      'deitelLinkLabel
      '
      Me.deitelLinkLabel.AutoSize = True
      Me.deitelLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.deitelLinkLabel.Location = New System.Drawing.Point(12, 33)
      Me.deitelLinkLabel.Name = "deitelLinkLabel"
      Me.deitelLinkLabel.Size = New System.Drawing.Size(160, 15)
      Me.deitelLinkLabel.TabIndex = 10
      Me.deitelLinkLabel.TabStop = True
      Me.deitelLinkLabel.Text = "Click to visit www.deitel.com"
      '
      'cDriveLinkLabel
      '
      Me.cDriveLinkLabel.AutoSize = True
      Me.cDriveLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cDriveLinkLabel.Location = New System.Drawing.Point(12, 9)
      Me.cDriveLinkLabel.Name = "cDriveLinkLabel"
      Me.cDriveLinkLabel.Size = New System.Drawing.Size(107, 15)
      Me.cDriveLinkLabel.TabIndex = 9
      Me.cDriveLinkLabel.TabStop = True
      Me.cDriveLinkLabel.Text = "Click to browse C:\"
      '
      'LinkLabelTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(205, 84)
      Me.Controls.Add(Me.notepadLinkLabel)
      Me.Controls.Add(Me.deitelLinkLabel)
      Me.Controls.Add(Me.cDriveLinkLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "LinkLabelTest"
      Me.Text = "LinkLabel Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents notepadLinkLabel As System.Windows.Forms.LinkLabel
   Friend WithEvents deitelLinkLabel As System.Windows.Forms.LinkLabel
   Friend WithEvents cDriveLinkLabel As System.Windows.Forms.LinkLabel

End Class
