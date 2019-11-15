<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlagQuiz
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
      Me.submitButton = New System.Windows.Forms.Button()
      Me.countriesComboBox = New System.Windows.Forms.ComboBox()
      Me.flagPictureBox = New System.Windows.Forms.PictureBox()
      Me.selectCountryLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'submitButton
      '
      Me.submitButton.Location = New System.Drawing.Point(98, 59)
      Me.submitButton.Name = "submitButton"
      Me.submitButton.Size = New System.Drawing.Size(121, 24)
      Me.submitButton.TabIndex = 7
      Me.submitButton.Text = "Submit"
      Me.submitButton.UseVisualStyleBackColor = True
      '
      'countriesComboBox
      '
      Me.countriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.countriesComboBox.FormattingEnabled = True
      Me.countriesComboBox.IntegralHeight = False
      Me.countriesComboBox.Location = New System.Drawing.Point(98, 27)
      Me.countriesComboBox.MaxDropDownItems = 4
      Me.countriesComboBox.Name = "countriesComboBox"
      Me.countriesComboBox.Size = New System.Drawing.Size(121, 23)
      Me.countriesComboBox.TabIndex = 6
      '
      'flagPictureBox
      '
      Me.flagPictureBox.Location = New System.Drawing.Point(12, 27)
      Me.flagPictureBox.Name = "flagPictureBox"
      Me.flagPictureBox.Size = New System.Drawing.Size(80, 56)
      Me.flagPictureBox.TabIndex = 0
      Me.flagPictureBox.TabStop = False
      '
      'selectCountryLabel
      '
      Me.selectCountryLabel.AutoSize = True
      Me.selectCountryLabel.Location = New System.Drawing.Point(95, 9)
      Me.selectCountryLabel.Name = "selectCountryLabel"
      Me.selectCountryLabel.Size = New System.Drawing.Size(85, 15)
      Me.selectCountryLabel.TabIndex = 10
      Me.selectCountryLabel.Text = "Select country:"
      '
      'FlagQuiz
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(231, 94)
      Me.Controls.Add(Me.flagPictureBox)
      Me.Controls.Add(Me.submitButton)
      Me.Controls.Add(Me.countriesComboBox)
      Me.Controls.Add(Me.selectCountryLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "FlagQuiz"
      Me.Text = "Flag Quiz"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents submitButton As System.Windows.Forms.Button
   Friend WithEvents countriesComboBox As System.Windows.Forms.ComboBox
   Friend WithEvents flagPictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents selectCountryLabel As System.Windows.Forms.Label

End Class
