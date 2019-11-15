<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINQToFileDirectory
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
      Me.directoryLabel = New System.Windows.Forms.Label()
      Me.directoryTextBox = New System.Windows.Forms.TextBox()
      Me.resultsTextBox = New System.Windows.Forms.TextBox()
      Me.searchButton = New System.Windows.Forms.Button()
      Me.pathTextBox = New System.Windows.Forms.TextBox()
      Me.instructionsLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'directoryLabel
      '
      Me.directoryLabel.AutoSize = True
      Me.directoryLabel.Location = New System.Drawing.Point(12, 118)
      Me.directoryLabel.Name = "directoryLabel"
      Me.directoryLabel.Size = New System.Drawing.Size(58, 15)
      Me.directoryLabel.TabIndex = 24
      Me.directoryLabel.Text = "Directory:"
      '
      'directoryTextBox
      '
      Me.directoryTextBox.Location = New System.Drawing.Point(76, 115)
      Me.directoryTextBox.Name = "directoryTextBox"
      Me.directoryTextBox.ReadOnly = True
      Me.directoryTextBox.Size = New System.Drawing.Size(228, 23)
      Me.directoryTextBox.TabIndex = 23
      '
      'resultsTextBox
      '
      Me.resultsTextBox.Location = New System.Drawing.Point(12, 144)
      Me.resultsTextBox.Multiline = True
      Me.resultsTextBox.Name = "resultsTextBox"
      Me.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.resultsTextBox.Size = New System.Drawing.Size(292, 247)
      Me.resultsTextBox.TabIndex = 22
      '
      'searchButton
      '
      Me.searchButton.Location = New System.Drawing.Point(178, 56)
      Me.searchButton.Name = "searchButton"
      Me.searchButton.Size = New System.Drawing.Size(126, 29)
      Me.searchButton.TabIndex = 21
      Me.searchButton.Text = "Search Directory"
      Me.searchButton.UseVisualStyleBackColor = True
      '
      'pathTextBox
      '
      Me.pathTextBox.Location = New System.Drawing.Point(12, 27)
      Me.pathTextBox.Name = "pathTextBox"
      Me.pathTextBox.Size = New System.Drawing.Size(292, 23)
      Me.pathTextBox.TabIndex = 20
      '
      'instructionsLabel
      '
      Me.instructionsLabel.AutoSize = True
      Me.instructionsLabel.Location = New System.Drawing.Point(12, 9)
      Me.instructionsLabel.Name = "instructionsLabel"
      Me.instructionsLabel.Size = New System.Drawing.Size(115, 15)
      Me.instructionsLabel.TabIndex = 19
      Me.instructionsLabel.Text = "Enter path to search:"
      '
      'LINQToFileDirectory
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(317, 405)
      Me.Controls.Add(Me.directoryLabel)
      Me.Controls.Add(Me.directoryTextBox)
      Me.Controls.Add(Me.resultsTextBox)
      Me.Controls.Add(Me.searchButton)
      Me.Controls.Add(Me.pathTextBox)
      Me.Controls.Add(Me.instructionsLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "LINQToFileDirectory"
      Me.Text = "Search Directory"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents directoryLabel As System.Windows.Forms.Label
   Friend WithEvents directoryTextBox As System.Windows.Forms.TextBox
   Friend WithEvents resultsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents searchButton As System.Windows.Forms.Button
   Friend WithEvents pathTextBox As System.Windows.Forms.TextBox
   Friend WithEvents instructionsLabel As System.Windows.Forms.Label

End Class
