<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTSForm
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
      Me.components = New System.ComponentModel.Container()
      Me.taggedSearchesGroupBox = New System.Windows.Forms.GroupBox()
      Me.webBrowser = New System.Windows.Forms.WebBrowser()
      Me.tagsListBox = New System.Windows.Forms.ListBox()
      Me.saveSearchButton = New System.Windows.Forms.Button()
      Me.tagTextBox = New System.Windows.Forms.TextBox()
      Me.queryTextBox = New System.Windows.Forms.TextBox()
      Me.label3 = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.pictureBox1 = New System.Windows.Forms.PictureBox()
      Me.addSearchGroupBox = New System.Windows.Forms.GroupBox()
      Me.manageSearchesButton = New System.Windows.Forms.Button()
      Me.groupTagTextBox = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.taggedSearchesGroupBox.SuspendLayout()
      CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.addSearchGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      'taggedSearchesGroupBox
      '
      Me.taggedSearchesGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.taggedSearchesGroupBox.Controls.Add(Me.webBrowser)
      Me.taggedSearchesGroupBox.Controls.Add(Me.tagsListBox)
      Me.taggedSearchesGroupBox.Enabled = False
      Me.taggedSearchesGroupBox.Location = New System.Drawing.Point(12, 146)
      Me.taggedSearchesGroupBox.Name = "taggedSearchesGroupBox"
      Me.taggedSearchesGroupBox.Size = New System.Drawing.Size(612, 344)
      Me.taggedSearchesGroupBox.TabIndex = 16
      Me.taggedSearchesGroupBox.TabStop = False
      Me.taggedSearchesGroupBox.Text = "Tagged Searches"
      '
      'webBrowser
      '
      Me.webBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.webBrowser.Location = New System.Drawing.Point(131, 20)
      Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
      Me.webBrowser.Name = "webBrowser"
      Me.webBrowser.Size = New System.Drawing.Size(475, 316)
      Me.webBrowser.TabIndex = 3
      '
      'tagsListBox
      '
      Me.tagsListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.tagsListBox.FormattingEnabled = True
      Me.tagsListBox.Location = New System.Drawing.Point(7, 20)
      Me.tagsListBox.Name = "tagsListBox"
      Me.tagsListBox.Size = New System.Drawing.Size(118, 316)
      Me.tagsListBox.TabIndex = 0
      '
      'saveSearchButton
      '
      Me.saveSearchButton.Location = New System.Drawing.Point(372, 71)
      Me.saveSearchButton.Name = "saveSearchButton"
      Me.saveSearchButton.Size = New System.Drawing.Size(88, 23)
      Me.saveSearchButton.TabIndex = 8
      Me.saveSearchButton.Text = "Save Search"
      Me.saveSearchButton.UseVisualStyleBackColor = True
      '
      'tagTextBox
      '
      Me.tagTextBox.Location = New System.Drawing.Point(112, 45)
      Me.tagTextBox.Name = "tagTextBox"
      Me.tagTextBox.Size = New System.Drawing.Size(348, 20)
      Me.tagTextBox.TabIndex = 5
      '
      'queryTextBox
      '
      Me.queryTextBox.Location = New System.Drawing.Point(112, 19)
      Me.queryTextBox.Name = "queryTextBox"
      Me.queryTextBox.Size = New System.Drawing.Size(348, 20)
      Me.queryTextBox.TabIndex = 4
      '
      'label3
      '
      Me.label3.AutoSize = True
      Me.label3.Location = New System.Drawing.Point(22, 48)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(84, 13)
      Me.label3.TabIndex = 1
      Me.label3.Text = "Tag your search"
      '
      'label2
      '
      Me.label2.AutoSize = True
      Me.label2.Location = New System.Drawing.Point(3, 22)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(103, 13)
      Me.label2.TabIndex = 0
      Me.label2.Text = "Twitter search query"
      '
      'pictureBox1
      '
      Me.pictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pictureBox1.Location = New System.Drawing.Point(484, 10)
      Me.pictureBox1.Name = "pictureBox1"
      Me.pictureBox1.Size = New System.Drawing.Size(140, 130)
      Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.pictureBox1.TabIndex = 17
      Me.pictureBox1.TabStop = False
      '
      'addSearchGroupBox
      '
      Me.addSearchGroupBox.Controls.Add(Me.saveSearchButton)
      Me.addSearchGroupBox.Controls.Add(Me.tagTextBox)
      Me.addSearchGroupBox.Controls.Add(Me.queryTextBox)
      Me.addSearchGroupBox.Controls.Add(Me.label3)
      Me.addSearchGroupBox.Controls.Add(Me.label2)
      Me.addSearchGroupBox.Enabled = False
      Me.addSearchGroupBox.Location = New System.Drawing.Point(12, 39)
      Me.addSearchGroupBox.Name = "addSearchGroupBox"
      Me.addSearchGroupBox.Size = New System.Drawing.Size(466, 101)
      Me.addSearchGroupBox.TabIndex = 15
      Me.addSearchGroupBox.TabStop = False
      Me.addSearchGroupBox.Text = "Add a Search"
      '
      'manageSearchesButton
      '
      Me.manageSearchesButton.Location = New System.Drawing.Point(365, 10)
      Me.manageSearchesButton.Name = "manageSearchesButton"
      Me.manageSearchesButton.Size = New System.Drawing.Size(113, 23)
      Me.manageSearchesButton.TabIndex = 14
      Me.manageSearchesButton.Text = "Manage Searches"
      Me.manageSearchesButton.UseVisualStyleBackColor = True
      '
      'groupTagTextBox
      '
      Me.groupTagTextBox.Location = New System.Drawing.Point(98, 12)
      Me.groupTagTextBox.Name = "groupTagTextBox"
      Me.groupTagTextBox.Size = New System.Drawing.Size(261, 20)
      Me.groupTagTextBox.TabIndex = 13
      Me.toolTip1.SetToolTip(Me.groupTagTextBox, "The tag you enter here is used to locate a group of searches. You can have many s" & _
        "eparate groups.")
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(12, 15)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(80, 13)
      Me.label1.TabIndex = 12
      Me.label1.Text = "Enter group tag"
      '
      'FTSForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(636, 500)
      Me.Controls.Add(Me.taggedSearchesGroupBox)
      Me.Controls.Add(Me.pictureBox1)
      Me.Controls.Add(Me.addSearchGroupBox)
      Me.Controls.Add(Me.manageSearchesButton)
      Me.Controls.Add(Me.groupTagTextBox)
      Me.Controls.Add(Me.label1)
      Me.Name = "FTSForm"
      Me.Text = "Favorite Twitter Searches"
      Me.taggedSearchesGroupBox.ResumeLayout(False)
      CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.addSearchGroupBox.ResumeLayout(False)
      Me.addSearchGroupBox.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents taggedSearchesGroupBox As System.Windows.Forms.GroupBox
   Private WithEvents webBrowser As System.Windows.Forms.WebBrowser
   Private WithEvents tagsListBox As System.Windows.Forms.ListBox
   Private WithEvents saveSearchButton As System.Windows.Forms.Button
   Private WithEvents tagTextBox As System.Windows.Forms.TextBox
   Private WithEvents queryTextBox As System.Windows.Forms.TextBox
   Private WithEvents label3 As System.Windows.Forms.Label
   Private WithEvents label2 As System.Windows.Forms.Label
   Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
   Private WithEvents addSearchGroupBox As System.Windows.Forms.GroupBox
   Private WithEvents manageSearchesButton As System.Windows.Forms.Button
   Private WithEvents groupTagTextBox As System.Windows.Forms.TextBox
   Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
   Private WithEvents label1 As System.Windows.Forms.Label

End Class
