<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankUIForm
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
      Me.balanceTextBox = New System.Windows.Forms.TextBox()
      Me.lastNameTextBox = New System.Windows.Forms.TextBox()
      Me.firstNameTextBox = New System.Windows.Forms.TextBox()
      Me.accountTextBox = New System.Windows.Forms.TextBox()
      Me.balanceLabel = New System.Windows.Forms.Label()
      Me.lastNameLabel = New System.Windows.Forms.Label()
      Me.firstNameLabel = New System.Windows.Forms.Label()
      Me.accountLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'balanceTextBox
      '
      Me.balanceTextBox.Location = New System.Drawing.Point(136, 152)
      Me.balanceTextBox.Name = "balanceTextBox"
      Me.balanceTextBox.Size = New System.Drawing.Size(153, 23)
      Me.balanceTextBox.TabIndex = 39
      '
      'lastNameTextBox
      '
      Me.lastNameTextBox.Location = New System.Drawing.Point(136, 106)
      Me.lastNameTextBox.Name = "lastNameTextBox"
      Me.lastNameTextBox.Size = New System.Drawing.Size(153, 23)
      Me.lastNameTextBox.TabIndex = 38
      '
      'firstNameTextBox
      '
      Me.firstNameTextBox.Location = New System.Drawing.Point(136, 59)
      Me.firstNameTextBox.Name = "firstNameTextBox"
      Me.firstNameTextBox.Size = New System.Drawing.Size(153, 23)
      Me.firstNameTextBox.TabIndex = 37
      '
      'accountTextBox
      '
      Me.accountTextBox.Location = New System.Drawing.Point(136, 12)
      Me.accountTextBox.Name = "accountTextBox"
      Me.accountTextBox.Size = New System.Drawing.Size(153, 23)
      Me.accountTextBox.TabIndex = 36
      '
      'balanceLabel
      '
      Me.balanceLabel.AutoSize = True
      Me.balanceLabel.Location = New System.Drawing.Point(36, 155)
      Me.balanceLabel.Name = "balanceLabel"
      Me.balanceLabel.Size = New System.Drawing.Size(48, 15)
      Me.balanceLabel.TabIndex = 35
      Me.balanceLabel.Text = "Balance"
      '
      'lastNameLabel
      '
      Me.lastNameLabel.AutoSize = True
      Me.lastNameLabel.Location = New System.Drawing.Point(36, 113)
      Me.lastNameLabel.Name = "lastNameLabel"
      Me.lastNameLabel.Size = New System.Drawing.Size(63, 15)
      Me.lastNameLabel.TabIndex = 34
      Me.lastNameLabel.Text = "Last Name"
      '
      'firstNameLabel
      '
      Me.firstNameLabel.AutoSize = True
      Me.firstNameLabel.Location = New System.Drawing.Point(37, 66)
      Me.firstNameLabel.Name = "firstNameLabel"
      Me.firstNameLabel.Size = New System.Drawing.Size(64, 15)
      Me.firstNameLabel.TabIndex = 33
      Me.firstNameLabel.Text = "First Name"
      '
      'accountLabel
      '
      Me.accountLabel.AutoSize = True
      Me.accountLabel.Location = New System.Drawing.Point(37, 21)
      Me.accountLabel.Name = "accountLabel"
      Me.accountLabel.Size = New System.Drawing.Size(52, 15)
      Me.accountLabel.TabIndex = 32
      Me.accountLabel.Text = "Account"
      '
      'BankUIForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(325, 269)
      Me.Controls.Add(Me.balanceTextBox)
      Me.Controls.Add(Me.lastNameTextBox)
      Me.Controls.Add(Me.firstNameTextBox)
      Me.Controls.Add(Me.accountTextBox)
      Me.Controls.Add(Me.balanceLabel)
      Me.Controls.Add(Me.lastNameLabel)
      Me.Controls.Add(Me.firstNameLabel)
      Me.Controls.Add(Me.accountLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "BankUIForm"
      Me.Text = "BankUIForm"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Public WithEvents balanceTextBox As System.Windows.Forms.TextBox
   Public WithEvents lastNameTextBox As System.Windows.Forms.TextBox
   Public WithEvents firstNameTextBox As System.Windows.Forms.TextBox
   Public WithEvents accountTextBox As System.Windows.Forms.TextBox
   Public WithEvents balanceLabel As System.Windows.Forms.Label
   Public WithEvents lastNameLabel As System.Windows.Forms.Label
   Public WithEvents firstNameLabel As System.Windows.Forms.Label
   Public WithEvents accountLabel As System.Windows.Forms.Label
End Class
