<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiblingSurvey
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
      Me.submitSurveyButton = New System.Windows.Forms.Button()
      Me.noneCheckBox = New System.Windows.Forms.CheckBox()
      Me.sisterCheckBox = New System.Windows.Forms.CheckBox()
      Me.brotherCheckBox = New System.Windows.Forms.CheckBox()
      Me.instructionsLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'submitSurveyButton
      '
      Me.submitSurveyButton.Location = New System.Drawing.Point(15, 102)
      Me.submitSurveyButton.Name = "submitSurveyButton"
      Me.submitSurveyButton.Size = New System.Drawing.Size(103, 23)
      Me.submitSurveyButton.TabIndex = 9
      Me.submitSurveyButton.Text = "Submit Survey"
      Me.submitSurveyButton.UseVisualStyleBackColor = True
      '
      'noneCheckBox
      '
      Me.noneCheckBox.AutoSize = True
      Me.noneCheckBox.Location = New System.Drawing.Point(15, 77)
      Me.noneCheckBox.Name = "noneCheckBox"
      Me.noneCheckBox.Size = New System.Drawing.Size(86, 19)
      Me.noneCheckBox.TabIndex = 8
      Me.noneCheckBox.Text = "No Siblings"
      Me.noneCheckBox.UseVisualStyleBackColor = True
      '
      'sisterCheckBox
      '
      Me.sisterCheckBox.AutoSize = True
      Me.sisterCheckBox.Location = New System.Drawing.Point(15, 52)
      Me.sisterCheckBox.Name = "sisterCheckBox"
      Me.sisterCheckBox.Size = New System.Drawing.Size(67, 19)
      Me.sisterCheckBox.TabIndex = 7
      Me.sisterCheckBox.Text = "Sister(s)"
      Me.sisterCheckBox.UseVisualStyleBackColor = True
      '
      'brotherCheckBox
      '
      Me.brotherCheckBox.AutoSize = True
      Me.brotherCheckBox.Location = New System.Drawing.Point(15, 27)
      Me.brotherCheckBox.Name = "brotherCheckBox"
      Me.brotherCheckBox.Size = New System.Drawing.Size(78, 19)
      Me.brotherCheckBox.TabIndex = 6
      Me.brotherCheckBox.Text = "Brother(s)"
      Me.brotherCheckBox.UseVisualStyleBackColor = True
      '
      'instructionsLabel
      '
      Me.instructionsLabel.AutoSize = True
      Me.instructionsLabel.Location = New System.Drawing.Point(12, 9)
      Me.instructionsLabel.Name = "instructionsLabel"
      Me.instructionsLabel.Size = New System.Drawing.Size(190, 15)
      Me.instructionsLabel.TabIndex = 5
      Me.instructionsLabel.Text = "Please select the siblings you have:"
      '
      'SiblingSurvey
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(213, 138)
      Me.Controls.Add(Me.submitSurveyButton)
      Me.Controls.Add(Me.noneCheckBox)
      Me.Controls.Add(Me.sisterCheckBox)
      Me.Controls.Add(Me.brotherCheckBox)
      Me.Controls.Add(Me.instructionsLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "SiblingSurvey"
      Me.Text = "Sibling Survey"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents submitSurveyButton As System.Windows.Forms.Button
   Friend WithEvents noneCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents sisterCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents brotherCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents instructionsLabel As System.Windows.Forms.Label

End Class
