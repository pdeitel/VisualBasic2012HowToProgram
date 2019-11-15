<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlickrViewerForm
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
      Me.imagesListBox = New System.Windows.Forms.ListBox()
      Me.searchButton = New System.Windows.Forms.Button()
      Me.pictureBox = New System.Windows.Forms.PictureBox()
      Me.inputTextBox = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'imagesListBox
      '
      Me.imagesListBox.FormattingEnabled = True
      Me.imagesListBox.Location = New System.Drawing.Point(15, 40)
      Me.imagesListBox.Name = "imagesListBox"
      Me.imagesListBox.Size = New System.Drawing.Size(142, 524)
      Me.imagesListBox.TabIndex = 10
      '
      'searchButton
      '
      Me.searchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.searchButton.Location = New System.Drawing.Point(597, 11)
      Me.searchButton.Name = "searchButton"
      Me.searchButton.Size = New System.Drawing.Size(70, 23)
      Me.searchButton.TabIndex = 9
      Me.searchButton.Text = "Search"
      Me.searchButton.UseVisualStyleBackColor = True
      '
      'pictureBox
      '
      Me.pictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pictureBox.Location = New System.Drawing.Point(163, 40)
      Me.pictureBox.Name = "pictureBox"
      Me.pictureBox.Size = New System.Drawing.Size(503, 524)
      Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.pictureBox.TabIndex = 8
      Me.pictureBox.TabStop = False
      '
      'inputTextBox
      '
      Me.inputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.inputTextBox.Location = New System.Drawing.Point(163, 13)
      Me.inputTextBox.Name = "inputTextBox"
      Me.inputTextBox.Size = New System.Drawing.Size(428, 20)
      Me.inputTextBox.TabIndex = 7
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(12, 16)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(145, 13)
      Me.label1.TabIndex = 6
      Me.label1.Text = "Enter Flickr search tags here:"
      '
      'FlickrViewerForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(679, 574)
      Me.Controls.Add(Me.imagesListBox)
      Me.Controls.Add(Me.searchButton)
      Me.Controls.Add(Me.pictureBox)
      Me.Controls.Add(Me.inputTextBox)
      Me.Controls.Add(Me.label1)
      Me.Name = "FlickrViewerForm"
      Me.Text = "Flickr Viewer"
      CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents imagesListBox As System.Windows.Forms.ListBox
   Private WithEvents searchButton As System.Windows.Forms.Button
   Private WithEvents pictureBox As System.Windows.Forms.PictureBox
   Private WithEvents inputTextBox As System.Windows.Forms.TextBox
   Private WithEvents label1 As System.Windows.Forms.Label

End Class
