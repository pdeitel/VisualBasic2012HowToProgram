<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediaPlayer
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediaPlayer))
      Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.openMediaFileDialog = New System.Windows.Forms.OpenFileDialog()
      Me.MenuStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'AxWindowsMediaPlayer1
      '
      Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.AxWindowsMediaPlayer1.Enabled = True
      Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 24)
      Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
      Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
      Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(331, 278)
      Me.AxWindowsMediaPlayer1.TabIndex = 0
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(331, 24)
      Me.MenuStrip1.TabIndex = 1
      Me.MenuStrip1.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'OpenToolStripMenuItem
      '
      Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
      Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.OpenToolStripMenuItem.Text = "&Open"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'openMediaFileDialog
      '
      Me.openMediaFileDialog.FileName = "OpenFileDialog1"
      '
      'MediaPlayer
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(331, 302)
      Me.Controls.Add(Me.AxWindowsMediaPlayer1)
      Me.Controls.Add(Me.MenuStrip1)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.MainMenuStrip = Me.MenuStrip1
      Me.Name = "MediaPlayer"
      Me.Text = "Media Player"
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
   Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
   Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents openMediaFileDialog As System.Windows.Forms.OpenFileDialog

End Class
