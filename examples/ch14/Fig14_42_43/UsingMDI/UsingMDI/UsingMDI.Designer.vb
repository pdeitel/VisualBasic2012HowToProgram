<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsingMDI
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
      Me.cascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.windowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.tileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.tileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.oneToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.lavenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.purpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.yellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.oneMenuStrip = New System.Windows.Forms.MenuStrip()
      Me.oneMenuStrip.SuspendLayout()
      Me.SuspendLayout()
      '
      'cascadeToolStripMenuItem
      '
      Me.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem"
      Me.cascadeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.cascadeToolStripMenuItem.Text = "Cascade"
      '
      'windowToolStripMenuItem
      '
      Me.windowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cascadeToolStripMenuItem, Me.tileHorizontalToolStripMenuItem, Me.tileVerticalToolStripMenuItem, Me.oneToolStripSeparator})
      Me.windowToolStripMenuItem.Name = "windowToolStripMenuItem"
      Me.windowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
      Me.windowToolStripMenuItem.Text = "Window"
      '
      'tileHorizontalToolStripMenuItem
      '
      Me.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem"
      Me.tileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
      '
      'tileVerticalToolStripMenuItem
      '
      Me.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem"
      Me.tileVerticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.tileVerticalToolStripMenuItem.Text = "Tile Vertical"
      '
      'oneToolStripSeparator
      '
      Me.oneToolStripSeparator.Name = "oneToolStripSeparator"
      Me.oneToolStripSeparator.Size = New System.Drawing.Size(149, 6)
      '
      'exitToolStripMenuItem
      '
      Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
      Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.exitToolStripMenuItem.Text = "Exit"
      '
      'newToolStripMenuItem
      '
      Me.newToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lavenderToolStripMenuItem, Me.purpleToolStripMenuItem, Me.yellowToolStripMenuItem})
      Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
      Me.newToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.newToolStripMenuItem.Text = "New"
      '
      'lavenderToolStripMenuItem
      '
      Me.lavenderToolStripMenuItem.Name = "lavenderToolStripMenuItem"
      Me.lavenderToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
      Me.lavenderToolStripMenuItem.Text = "Lavender Flowers"
      '
      'purpleToolStripMenuItem
      '
      Me.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem"
      Me.purpleToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
      Me.purpleToolStripMenuItem.Text = "Purple Flowers"
      '
      'vbToolStripMenuItem
      '
      Me.yellowToolStripMenuItem.Name = "vbToolStripMenuItem"
      Me.yellowToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
      Me.yellowToolStripMenuItem.Text = "Yellow Flowers"
      '
      'fileToolStripMenuItem
      '
      Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.exitToolStripMenuItem})
      Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
      Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.fileToolStripMenuItem.Text = "File"
      '
      'oneMenuStrip
      '
      Me.oneMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.windowToolStripMenuItem})
      Me.oneMenuStrip.Location = New System.Drawing.Point(0, 0)
      Me.oneMenuStrip.MdiWindowListItem = Me.windowToolStripMenuItem
      Me.oneMenuStrip.Name = "oneMenuStrip"
      Me.oneMenuStrip.Size = New System.Drawing.Size(321, 24)
      Me.oneMenuStrip.TabIndex = 4
      Me.oneMenuStrip.Text = "oneMenuStrip"
      '
      'UsingMDI
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(321, 337)
      Me.Controls.Add(Me.oneMenuStrip)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.IsMdiContainer = True
      Me.Name = "UsingMDI"
      Me.Text = "Using MDI"
      Me.oneMenuStrip.ResumeLayout(False)
      Me.oneMenuStrip.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents windowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents oneToolStripSeparator As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents lavenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents purpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents yellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents oneMenuStrip As System.Windows.Forms.MenuStrip

End Class
