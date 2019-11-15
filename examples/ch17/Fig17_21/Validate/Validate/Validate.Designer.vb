<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidateForm
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
      Me.okButton = New System.Windows.Forms.Button()
      Me.phoneLabel = New System.Windows.Forms.Label()
      Me.zipCodeLabel = New System.Windows.Forms.Label()
      Me.stateLabel = New System.Windows.Forms.Label()
      Me.cityLabel = New System.Windows.Forms.Label()
      Me.addressLabel = New System.Windows.Forms.Label()
      Me.firstNameLabel = New System.Windows.Forms.Label()
      Me.lastNameLabel = New System.Windows.Forms.Label()
      Me.phoneTextBox = New System.Windows.Forms.TextBox()
      Me.zipCodeTextBox = New System.Windows.Forms.TextBox()
      Me.stateTextBox = New System.Windows.Forms.TextBox()
      Me.cityTextBox = New System.Windows.Forms.TextBox()
      Me.addressTextBox = New System.Windows.Forms.TextBox()
      Me.firstNameTextBox = New System.Windows.Forms.TextBox()
      Me.lastNameTextBox = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'okButton
      '
      Me.okButton.Location = New System.Drawing.Point(157, 245)
      Me.okButton.Name = "okButton"
      Me.okButton.Size = New System.Drawing.Size(75, 23)
      Me.okButton.TabIndex = 44
      Me.okButton.Text = "OK"
      Me.okButton.UseVisualStyleBackColor = True
      '
      'phoneLabel
      '
      Me.phoneLabel.AutoSize = True
      Me.phoneLabel.Location = New System.Drawing.Point(11, 219)
      Me.phoneLabel.Name = "phoneLabel"
      Me.phoneLabel.Size = New System.Drawing.Size(44, 15)
      Me.phoneLabel.TabIndex = 43
      Me.phoneLabel.Text = "Phone:"
      '
      'zipCodeLabel
      '
      Me.zipCodeLabel.AutoSize = True
      Me.zipCodeLabel.Location = New System.Drawing.Point(11, 185)
      Me.zipCodeLabel.Name = "zipCodeLabel"
      Me.zipCodeLabel.Size = New System.Drawing.Size(56, 15)
      Me.zipCodeLabel.TabIndex = 42
      Me.zipCodeLabel.Text = "Zip code:"
      '
      'stateLabel
      '
      Me.stateLabel.AutoSize = True
      Me.stateLabel.Location = New System.Drawing.Point(11, 151)
      Me.stateLabel.Name = "stateLabel"
      Me.stateLabel.Size = New System.Drawing.Size(36, 15)
      Me.stateLabel.TabIndex = 41
      Me.stateLabel.Text = "State:"
      '
      'cityLabel
      '
      Me.cityLabel.AutoSize = True
      Me.cityLabel.Location = New System.Drawing.Point(11, 117)
      Me.cityLabel.Name = "cityLabel"
      Me.cityLabel.Size = New System.Drawing.Size(31, 15)
      Me.cityLabel.TabIndex = 40
      Me.cityLabel.Text = "City:"
      '
      'addressLabel
      '
      Me.addressLabel.AutoSize = True
      Me.addressLabel.Location = New System.Drawing.Point(11, 83)
      Me.addressLabel.Name = "addressLabel"
      Me.addressLabel.Size = New System.Drawing.Size(52, 15)
      Me.addressLabel.TabIndex = 39
      Me.addressLabel.Text = "Address:"
      '
      'firstNameLabel
      '
      Me.firstNameLabel.AutoSize = True
      Me.firstNameLabel.Location = New System.Drawing.Point(11, 49)
      Me.firstNameLabel.Name = "firstNameLabel"
      Me.firstNameLabel.Size = New System.Drawing.Size(65, 15)
      Me.firstNameLabel.TabIndex = 38
      Me.firstNameLabel.Text = "First name:"
      '
      'lastNameLabel
      '
      Me.lastNameLabel.AutoSize = True
      Me.lastNameLabel.Location = New System.Drawing.Point(11, 15)
      Me.lastNameLabel.Name = "lastNameLabel"
      Me.lastNameLabel.Size = New System.Drawing.Size(64, 15)
      Me.lastNameLabel.TabIndex = 37
      Me.lastNameLabel.Text = "Last name:"
      '
      'phoneTextBox
      '
      Me.phoneTextBox.Location = New System.Drawing.Point(82, 216)
      Me.phoneTextBox.Name = "phoneTextBox"
      Me.phoneTextBox.Size = New System.Drawing.Size(150, 23)
      Me.phoneTextBox.TabIndex = 36
      '
      'zipCodeTextBox
      '
      Me.zipCodeTextBox.Location = New System.Drawing.Point(82, 182)
      Me.zipCodeTextBox.Name = "zipCodeTextBox"
      Me.zipCodeTextBox.Size = New System.Drawing.Size(150, 23)
      Me.zipCodeTextBox.TabIndex = 35
      '
      'stateTextBox
      '
      Me.stateTextBox.Location = New System.Drawing.Point(82, 148)
      Me.stateTextBox.Name = "stateTextBox"
      Me.stateTextBox.Size = New System.Drawing.Size(150, 23)
      Me.stateTextBox.TabIndex = 34
      '
      'cityTextBox
      '
      Me.cityTextBox.Location = New System.Drawing.Point(82, 114)
      Me.cityTextBox.Name = "cityTextBox"
      Me.cityTextBox.Size = New System.Drawing.Size(150, 23)
      Me.cityTextBox.TabIndex = 33
      '
      'addressTextBox
      '
      Me.addressTextBox.Location = New System.Drawing.Point(82, 80)
      Me.addressTextBox.Name = "addressTextBox"
      Me.addressTextBox.Size = New System.Drawing.Size(150, 23)
      Me.addressTextBox.TabIndex = 32
      '
      'firstNameTextBox
      '
      Me.firstNameTextBox.Location = New System.Drawing.Point(82, 46)
      Me.firstNameTextBox.Name = "firstNameTextBox"
      Me.firstNameTextBox.Size = New System.Drawing.Size(150, 23)
      Me.firstNameTextBox.TabIndex = 31
      '
      'lastNameTextBox
      '
      Me.lastNameTextBox.Location = New System.Drawing.Point(82, 12)
      Me.lastNameTextBox.Name = "lastNameTextBox"
      Me.lastNameTextBox.Size = New System.Drawing.Size(150, 23)
      Me.lastNameTextBox.TabIndex = 30
      '
      'Validate
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(246, 279)
      Me.Controls.Add(Me.okButton)
      Me.Controls.Add(Me.phoneLabel)
      Me.Controls.Add(Me.zipCodeLabel)
      Me.Controls.Add(Me.stateLabel)
      Me.Controls.Add(Me.cityLabel)
      Me.Controls.Add(Me.addressLabel)
      Me.Controls.Add(Me.firstNameLabel)
      Me.Controls.Add(Me.lastNameLabel)
      Me.Controls.Add(Me.phoneTextBox)
      Me.Controls.Add(Me.zipCodeTextBox)
      Me.Controls.Add(Me.stateTextBox)
      Me.Controls.Add(Me.cityTextBox)
      Me.Controls.Add(Me.addressTextBox)
      Me.Controls.Add(Me.firstNameTextBox)
      Me.Controls.Add(Me.lastNameTextBox)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Validate"
      Me.Text = "Validate"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents okButton As System.Windows.Forms.Button
   Friend WithEvents phoneLabel As System.Windows.Forms.Label
   Friend WithEvents zipCodeLabel As System.Windows.Forms.Label
   Friend WithEvents stateLabel As System.Windows.Forms.Label
   Friend WithEvents cityLabel As System.Windows.Forms.Label
   Friend WithEvents addressLabel As System.Windows.Forms.Label
   Friend WithEvents firstNameLabel As System.Windows.Forms.Label
   Friend WithEvents lastNameLabel As System.Windows.Forms.Label
   Friend WithEvents phoneTextBox As System.Windows.Forms.TextBox
   Friend WithEvents zipCodeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
   Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
   Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
   Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox

End Class
