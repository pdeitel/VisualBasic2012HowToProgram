<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTestForm
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
      Me.timesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuStrip = New System.Windows.Forms.MenuStrip()
      Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.formatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.colorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.blackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.blueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.redToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.greenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.fontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.courierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.comicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.dashToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
      Me.boldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.italicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.displayLabel = New System.Windows.Forms.Label()
      Me.menuStrip.SuspendLayout()
      Me.SuspendLayout()
      '
      'timesToolStripMenuItem
      '
      Me.timesToolStripMenuItem.Checked = True
      Me.timesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
      Me.timesToolStripMenuItem.Name = "timesToolStripMenuItem"
      Me.timesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
      Me.timesToolStripMenuItem.Text = "Times New Roman"
      '
      'menuStrip
      '
      Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.formatToolStripMenuItem})
      Me.menuStrip.Location = New System.Drawing.Point(0, 0)
      Me.menuStrip.Name = "menuStrip"
      Me.menuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
      Me.menuStrip.Size = New System.Drawing.Size(368, 24)
      Me.menuStrip.TabIndex = 12
      Me.menuStrip.Text = "menuStrip1"
      '
      'fileToolStripMenuItem
      '
      Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem, Me.exitToolStripMenuItem})
      Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
      Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.fileToolStripMenuItem.Text = "File"
      '
      'aboutToolStripMenuItem
      '
      Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
      Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.aboutToolStripMenuItem.Text = "About"
      '
      'exitToolStripMenuItem
      '
      Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
      Me.exitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.exitToolStripMenuItem.Text = "Exit"
      '
      'formatToolStripMenuItem
      '
      Me.formatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.colorToolStripMenuItem, Me.fontToolStripMenuItem})
      Me.formatToolStripMenuItem.Name = "formatToolStripMenuItem"
      Me.formatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
      Me.formatToolStripMenuItem.Text = "Format"
      '
      'colorToolStripMenuItem
      '
      Me.colorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.blackToolStripMenuItem, Me.blueToolStripMenuItem, Me.redToolStripMenuItem, Me.greenToolStripMenuItem})
      Me.colorToolStripMenuItem.Name = "colorToolStripMenuItem"
      Me.colorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
      Me.colorToolStripMenuItem.Text = "Color"
      '
      'blackToolStripMenuItem
      '
      Me.blackToolStripMenuItem.Checked = True
      Me.blackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
      Me.blackToolStripMenuItem.Name = "blackToolStripMenuItem"
      Me.blackToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
      Me.blackToolStripMenuItem.Text = "Black"
      '
      'blueToolStripMenuItem
      '
      Me.blueToolStripMenuItem.Name = "blueToolStripMenuItem"
      Me.blueToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
      Me.blueToolStripMenuItem.Text = "Blue"
      '
      'redToolStripMenuItem
      '
      Me.redToolStripMenuItem.Name = "redToolStripMenuItem"
      Me.redToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
      Me.redToolStripMenuItem.Text = "Red"
      '
      'greenToolStripMenuItem
      '
      Me.greenToolStripMenuItem.Name = "greenToolStripMenuItem"
      Me.greenToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
      Me.greenToolStripMenuItem.Text = "Green"
      '
      'fontToolStripMenuItem
      '
      Me.fontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.timesToolStripMenuItem, Me.courierToolStripMenuItem, Me.comicToolStripMenuItem, Me.dashToolStripMenuItem, Me.boldToolStripMenuItem, Me.italicToolStripMenuItem})
      Me.fontToolStripMenuItem.Name = "fontToolStripMenuItem"
      Me.fontToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
      Me.fontToolStripMenuItem.Text = "Font"
      '
      'courierToolStripMenuItem
      '
      Me.courierToolStripMenuItem.Name = "courierToolStripMenuItem"
      Me.courierToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
      Me.courierToolStripMenuItem.Text = "Courier New"
      '
      'comicToolStripMenuItem
      '
      Me.comicToolStripMenuItem.Name = "comicToolStripMenuItem"
      Me.comicToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
      Me.comicToolStripMenuItem.Text = "Comic Sans MS"
      '
      'dashToolStripMenuItem
      '
      Me.dashToolStripMenuItem.Name = "dashToolStripMenuItem"
      Me.dashToolStripMenuItem.Size = New System.Drawing.Size(171, 6)
      '
      'boldToolStripMenuItem
      '
      Me.boldToolStripMenuItem.Name = "boldToolStripMenuItem"
      Me.boldToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
      Me.boldToolStripMenuItem.Text = "Bold"
      '
      'italicToolStripMenuItem
      '
      Me.italicToolStripMenuItem.Name = "italicToolStripMenuItem"
      Me.italicToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
      Me.italicToolStripMenuItem.Text = "Italic"
      '
      'displayLabel
      '
      Me.displayLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.displayLabel.Location = New System.Drawing.Point(12, 29)
      Me.displayLabel.Name = "displayLabel"
      Me.displayLabel.Size = New System.Drawing.Size(342, 103)
      Me.displayLabel.TabIndex = 13
      Me.displayLabel.Text = "Use the Format menu to change the appearance of this text."
      '
      'MenuTestForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(368, 141)
      Me.Controls.Add(Me.menuStrip)
      Me.Controls.Add(Me.displayLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "MenuTestForm"
      Me.Text = "Menu Test"
      Me.menuStrip.ResumeLayout(False)
      Me.menuStrip.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents timesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
   Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents formatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents colorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents blackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents blueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents redToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents greenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents fontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents courierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents comicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents dashToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents boldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents italicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents displayLabel As System.Windows.Forms.Label

End Class
