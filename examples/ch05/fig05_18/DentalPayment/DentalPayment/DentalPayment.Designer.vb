<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DentalPayment
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
      Me.xrayCheckBox = New System.Windows.Forms.CheckBox()
      Me.fillingCheckBox = New System.Windows.Forms.CheckBox()
      Me.cleaningCheckBox = New System.Windows.Forms.CheckBox()
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.totalLabel = New System.Windows.Forms.Label()
      Me.totalCostLabel = New System.Windows.Forms.Label()
      Me.xrayCostLabel = New System.Windows.Forms.Label()
      Me.fillingCostLabel = New System.Windows.Forms.Label()
      Me.cleaningCostLabel = New System.Windows.Forms.Label()
      Me.nameTextBox = New System.Windows.Forms.TextBox()
      Me.nameLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'xrayCheckBox
      '
      Me.xrayCheckBox.AutoSize = True
      Me.xrayCheckBox.Location = New System.Drawing.Point(19, 92)
      Me.xrayCheckBox.Name = "xrayCheckBox"
      Me.xrayCheckBox.Size = New System.Drawing.Size(57, 19)
      Me.xrayCheckBox.TabIndex = 22
      Me.xrayCheckBox.Text = "X-Ray"
      Me.xrayCheckBox.UseVisualStyleBackColor = True
      '
      'fillingCheckBox
      '
      Me.fillingCheckBox.AutoSize = True
      Me.fillingCheckBox.Location = New System.Drawing.Point(19, 67)
      Me.fillingCheckBox.Name = "fillingCheckBox"
      Me.fillingCheckBox.Size = New System.Drawing.Size(58, 19)
      Me.fillingCheckBox.TabIndex = 21
      Me.fillingCheckBox.Text = "Filling"
      Me.fillingCheckBox.UseVisualStyleBackColor = True
      '
      'cleaningCheckBox
      '
      Me.cleaningCheckBox.AutoSize = True
      Me.cleaningCheckBox.Location = New System.Drawing.Point(19, 42)
      Me.cleaningCheckBox.Name = "cleaningCheckBox"
      Me.cleaningCheckBox.Size = New System.Drawing.Size(73, 19)
      Me.cleaningCheckBox.TabIndex = 20
      Me.cleaningCheckBox.Text = "Cleaning"
      Me.cleaningCheckBox.UseVisualStyleBackColor = True
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(175, 11)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(75, 24)
      Me.calculateButton.TabIndex = 19
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'totalLabel
      '
      Me.totalLabel.AutoSize = True
      Me.totalLabel.Location = New System.Drawing.Point(66, 115)
      Me.totalLabel.Name = "totalLabel"
      Me.totalLabel.Size = New System.Drawing.Size(37, 15)
      Me.totalLabel.TabIndex = 18
      Me.totalLabel.Text = "Total:"
      Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'totalCostLabel
      '
      Me.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.totalCostLabel.Location = New System.Drawing.Point(109, 112)
      Me.totalCostLabel.Name = "totalCostLabel"
      Me.totalCostLabel.Size = New System.Drawing.Size(60, 21)
      Me.totalCostLabel.TabIndex = 17
      Me.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'xrayCostLabel
      '
      Me.xrayCostLabel.Location = New System.Drawing.Point(131, 88)
      Me.xrayCostLabel.Name = "xrayCostLabel"
      Me.xrayCostLabel.Size = New System.Drawing.Size(38, 24)
      Me.xrayCostLabel.TabIndex = 16
      Me.xrayCostLabel.Text = "150"
      Me.xrayCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'fillingCostLabel
      '
      Me.fillingCostLabel.Location = New System.Drawing.Point(131, 63)
      Me.fillingCostLabel.Name = "fillingCostLabel"
      Me.fillingCostLabel.Size = New System.Drawing.Size(38, 24)
      Me.fillingCostLabel.TabIndex = 15
      Me.fillingCostLabel.Text = "195"
      Me.fillingCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'cleaningCostLabel
      '
      Me.cleaningCostLabel.Location = New System.Drawing.Point(131, 38)
      Me.cleaningCostLabel.Name = "cleaningCostLabel"
      Me.cleaningCostLabel.Size = New System.Drawing.Size(38, 24)
      Me.cleaningCostLabel.TabIndex = 14
      Me.cleaningCostLabel.Text = "135"
      Me.cleaningCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'nameTextBox
      '
      Me.nameTextBox.Location = New System.Drawing.Point(69, 12)
      Me.nameTextBox.Name = "nameTextBox"
      Me.nameTextBox.Size = New System.Drawing.Size(100, 23)
      Me.nameTextBox.TabIndex = 13
      '
      'nameLabel
      '
      Me.nameLabel.AutoSize = True
      Me.nameLabel.Location = New System.Drawing.Point(16, 15)
      Me.nameLabel.Name = "nameLabel"
      Me.nameLabel.Size = New System.Drawing.Size(47, 15)
      Me.nameLabel.TabIndex = 12
      Me.nameLabel.Text = "Patient:"
      Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'DentalPayment
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(266, 146)
      Me.Controls.Add(Me.xrayCheckBox)
      Me.Controls.Add(Me.fillingCheckBox)
      Me.Controls.Add(Me.cleaningCheckBox)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.totalLabel)
      Me.Controls.Add(Me.totalCostLabel)
      Me.Controls.Add(Me.xrayCostLabel)
      Me.Controls.Add(Me.fillingCostLabel)
      Me.Controls.Add(Me.cleaningCostLabel)
      Me.Controls.Add(Me.nameTextBox)
      Me.Controls.Add(Me.nameLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "DentalPayment"
      Me.Text = "Dental Payment Calculator"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents xrayCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents fillingCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents cleaningCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents totalLabel As System.Windows.Forms.Label
   Friend WithEvents totalCostLabel As System.Windows.Forms.Label
   Friend WithEvents xrayCostLabel As System.Windows.Forms.Label
   Friend WithEvents fillingCostLabel As System.Windows.Forms.Label
   Friend WithEvents cleaningCostLabel As System.Windows.Forms.Label
   Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents nameLabel As System.Windows.Forms.Label

End Class
