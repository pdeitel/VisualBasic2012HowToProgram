<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SquareOfCharacters
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
      Me.fillCharacterLabel = New System.Windows.Forms.Label()
      Me.sideLengthLabel = New System.Windows.Forms.Label()
      Me.fillCharacterTextBox = New System.Windows.Forms.TextBox()
      Me.outputTextBox = New System.Windows.Forms.TextBox()
      Me.displaySquareButton = New System.Windows.Forms.Button()
      Me.sideLengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
      CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'fillCharacterLabel
      '
      Me.fillCharacterLabel.AutoSize = True
      Me.fillCharacterLabel.Location = New System.Drawing.Point(9, 15)
      Me.fillCharacterLabel.Name = "fillCharacterLabel"
      Me.fillCharacterLabel.Size = New System.Drawing.Size(95, 13)
      Me.fillCharacterLabel.TabIndex = 0
      Me.fillCharacterLabel.Text = "Enter fill character:"
      '
      'sideLengthLabel
      '
      Me.sideLengthLabel.AutoSize = True
      Me.sideLengthLabel.Location = New System.Drawing.Point(9, 40)
      Me.sideLengthLabel.Name = "sideLengthLabel"
      Me.sideLengthLabel.Size = New System.Drawing.Size(89, 13)
      Me.sideLengthLabel.TabIndex = 1
      Me.sideLengthLabel.Text = "Enter side length:"
      '
      'fillCharacterTextBox
      '
      Me.fillCharacterTextBox.Location = New System.Drawing.Point(110, 12)
      Me.fillCharacterTextBox.Name = "fillCharacterTextBox"
      Me.fillCharacterTextBox.Size = New System.Drawing.Size(100, 20)
      Me.fillCharacterTextBox.TabIndex = 0
      '
      'outputTextBox
      '
      Me.outputTextBox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.outputTextBox.Location = New System.Drawing.Point(12, 64)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.Size = New System.Drawing.Size(296, 244)
      Me.outputTextBox.TabIndex = 3
      '
      'displaySquareButton
      '
      Me.displaySquareButton.Location = New System.Drawing.Point(216, 12)
      Me.displaySquareButton.Name = "displaySquareButton"
      Me.displaySquareButton.Size = New System.Drawing.Size(92, 23)
      Me.displaySquareButton.TabIndex = 2
      Me.displaySquareButton.Text = "Display Square"
      Me.displaySquareButton.UseVisualStyleBackColor = True
      '
      'sideLengthNumericUpDown
      '
      Me.sideLengthNumericUpDown.Location = New System.Drawing.Point(110, 38)
      Me.sideLengthNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
      Me.sideLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
      Me.sideLengthNumericUpDown.Name = "sideLengthNumericUpDown"
      Me.sideLengthNumericUpDown.Size = New System.Drawing.Size(100, 20)
      Me.sideLengthNumericUpDown.TabIndex = 1
      Me.sideLengthNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'SquareOfCharacters
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(320, 320)
      Me.Controls.Add(Me.sideLengthNumericUpDown)
      Me.Controls.Add(Me.displaySquareButton)
      Me.Controls.Add(Me.outputTextBox)
      Me.Controls.Add(Me.fillCharacterTextBox)
      Me.Controls.Add(Me.sideLengthLabel)
      Me.Controls.Add(Me.fillCharacterLabel)
      Me.Name = "SquareOfCharacters"
      Me.Text = "Square of Characters"
      CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents fillCharacterLabel As System.Windows.Forms.Label
   Friend WithEvents sideLengthLabel As System.Windows.Forms.Label
   Friend WithEvents fillCharacterTextBox As System.Windows.Forms.TextBox
   Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents displaySquareButton As System.Windows.Forms.Button
   Friend WithEvents sideLengthNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
