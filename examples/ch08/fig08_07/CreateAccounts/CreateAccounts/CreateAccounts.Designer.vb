<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccounts
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
      Me.applicationMenuStrip = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.accountNumberLabel = New System.Windows.Forms.Label()
      Me.accountNumberTextBox = New System.Windows.Forms.TextBox()
      Me.firstNameTextBox = New System.Windows.Forms.TextBox()
      Me.firstNameLabel = New System.Windows.Forms.Label()
      Me.lastNameTextBox = New System.Windows.Forms.TextBox()
      Me.lastNameLabel = New System.Windows.Forms.Label()
      Me.balanceTextBox = New System.Windows.Forms.TextBox()
      Me.balanceLabel = New System.Windows.Forms.Label()
      Me.addAccountButton = New System.Windows.Forms.Button()
      Me.applicationMenuStrip.SuspendLayout()
      Me.SuspendLayout()
      '
      'applicationMenuStrip
      '
      Me.applicationMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
      Me.applicationMenuStrip.Location = New System.Drawing.Point(0, 0)
      Me.applicationMenuStrip.Name = "applicationMenuStrip"
      Me.applicationMenuStrip.Size = New System.Drawing.Size(231, 24)
      Me.applicationMenuStrip.TabIndex = 0
      Me.applicationMenuStrip.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'NewToolStripMenuItem
      '
      Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
      Me.NewToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.NewToolStripMenuItem.Text = "&New..."
      '
      'CloseToolStripMenuItem
      '
      Me.CloseToolStripMenuItem.Enabled = False
      Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
      Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.CloseToolStripMenuItem.Text = "&Close"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'accountNumberLabel
      '
      Me.accountNumberLabel.AutoSize = True
      Me.accountNumberLabel.Location = New System.Drawing.Point(12, 34)
      Me.accountNumberLabel.Name = "accountNumberLabel"
      Me.accountNumberLabel.Size = New System.Drawing.Size(100, 15)
      Me.accountNumberLabel.TabIndex = 1
      Me.accountNumberLabel.Text = "Account number:"
      '
      'accountNumberTextBox
      '
      Me.accountNumberTextBox.Enabled = False
      Me.accountNumberTextBox.Location = New System.Drawing.Point(118, 31)
      Me.accountNumberTextBox.Name = "accountNumberTextBox"
      Me.accountNumberTextBox.Size = New System.Drawing.Size(100, 23)
      Me.accountNumberTextBox.TabIndex = 2
      '
      'firstNameTextBox
      '
      Me.firstNameTextBox.Enabled = False
      Me.firstNameTextBox.Location = New System.Drawing.Point(118, 60)
      Me.firstNameTextBox.Name = "firstNameTextBox"
      Me.firstNameTextBox.Size = New System.Drawing.Size(100, 23)
      Me.firstNameTextBox.TabIndex = 4
      '
      'firstNameLabel
      '
      Me.firstNameLabel.AutoSize = True
      Me.firstNameLabel.Location = New System.Drawing.Point(12, 63)
      Me.firstNameLabel.Name = "firstNameLabel"
      Me.firstNameLabel.Size = New System.Drawing.Size(62, 15)
      Me.firstNameLabel.TabIndex = 3
      Me.firstNameLabel.Text = "First name"
      '
      'lastNameTextBox
      '
      Me.lastNameTextBox.Enabled = False
      Me.lastNameTextBox.Location = New System.Drawing.Point(118, 89)
      Me.lastNameTextBox.Name = "lastNameTextBox"
      Me.lastNameTextBox.Size = New System.Drawing.Size(100, 23)
      Me.lastNameTextBox.TabIndex = 6
      '
      'lastNameLabel
      '
      Me.lastNameLabel.AutoSize = True
      Me.lastNameLabel.Location = New System.Drawing.Point(12, 92)
      Me.lastNameLabel.Name = "lastNameLabel"
      Me.lastNameLabel.Size = New System.Drawing.Size(64, 15)
      Me.lastNameLabel.TabIndex = 5
      Me.lastNameLabel.Text = "Last name:"
      '
      'balanceTextBox
      '
      Me.balanceTextBox.Enabled = False
      Me.balanceTextBox.Location = New System.Drawing.Point(118, 118)
      Me.balanceTextBox.Name = "balanceTextBox"
      Me.balanceTextBox.Size = New System.Drawing.Size(100, 23)
      Me.balanceTextBox.TabIndex = 8
      '
      'balanceLabel
      '
      Me.balanceLabel.AutoSize = True
      Me.balanceLabel.Location = New System.Drawing.Point(12, 121)
      Me.balanceLabel.Name = "balanceLabel"
      Me.balanceLabel.Size = New System.Drawing.Size(51, 15)
      Me.balanceLabel.TabIndex = 7
      Me.balanceLabel.Text = "Balance:"
      '
      'addAccountButton
      '
      Me.addAccountButton.Enabled = False
      Me.addAccountButton.Location = New System.Drawing.Point(118, 147)
      Me.addAccountButton.Name = "addAccountButton"
      Me.addAccountButton.Size = New System.Drawing.Size(100, 23)
      Me.addAccountButton.TabIndex = 9
      Me.addAccountButton.Text = "Add Account"
      Me.addAccountButton.UseVisualStyleBackColor = True
      '
      'CreateAccounts
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(231, 180)
      Me.Controls.Add(Me.addAccountButton)
      Me.Controls.Add(Me.balanceTextBox)
      Me.Controls.Add(Me.balanceLabel)
      Me.Controls.Add(Me.lastNameTextBox)
      Me.Controls.Add(Me.lastNameLabel)
      Me.Controls.Add(Me.firstNameTextBox)
      Me.Controls.Add(Me.firstNameLabel)
      Me.Controls.Add(Me.accountNumberTextBox)
      Me.Controls.Add(Me.accountNumberLabel)
      Me.Controls.Add(Me.applicationMenuStrip)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.MainMenuStrip = Me.applicationMenuStrip
      Me.Name = "CreateAccounts"
      Me.Text = "Create Accounts"
      Me.applicationMenuStrip.ResumeLayout(False)
      Me.applicationMenuStrip.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents applicationMenuStrip As System.Windows.Forms.MenuStrip
   Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents accountNumberLabel As System.Windows.Forms.Label
   Friend WithEvents accountNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents firstNameLabel As System.Windows.Forms.Label
   Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents lastNameLabel As System.Windows.Forms.Label
   Friend WithEvents balanceTextBox As System.Windows.Forms.TextBox
   Friend WithEvents balanceLabel As System.Windows.Forms.Label
   Friend WithEvents addAccountButton As System.Windows.Forms.Button

End Class
