<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PathNavigator
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
      Me.nextButton = New System.Windows.Forms.Button()
      Me.firstChildButton = New System.Windows.Forms.Button()
      Me.parentButton = New System.Windows.Forms.Button()
      Me.treePath = New System.Windows.Forms.TreeView()
      Me.locateGroupBox = New System.Windows.Forms.GroupBox()
      Me.locateTextBox = New System.Windows.Forms.TextBox()
      Me.locateComboBox = New System.Windows.Forms.ComboBox()
      Me.previousButton = New System.Windows.Forms.Button()
      Me.navigateGroupBox = New System.Windows.Forms.GroupBox()
      Me.locateGroupBox.SuspendLayout()
      Me.navigateGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      'nextButton
      '
      Me.nextButton.Location = New System.Drawing.Point(66, 94)
      Me.nextButton.Name = "nextButton"
      Me.nextButton.Size = New System.Drawing.Size(100, 30)
      Me.nextButton.TabIndex = 2
      Me.nextButton.Text = "Next"
      '
      'firstChildButton
      '
      Me.firstChildButton.Location = New System.Drawing.Point(122, 59)
      Me.firstChildButton.Name = "firstChildButton"
      Me.firstChildButton.Size = New System.Drawing.Size(100, 30)
      Me.firstChildButton.TabIndex = 1
      Me.firstChildButton.Text = "First Child"
      '
      'parentButton
      '
      Me.parentButton.Location = New System.Drawing.Point(7, 59)
      Me.parentButton.Name = "parentButton"
      Me.parentButton.Size = New System.Drawing.Size(100, 30)
      Me.parentButton.TabIndex = 2
      Me.parentButton.Text = "Parent"
      '
      'treePath
      '
      Me.treePath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.treePath.FullRowSelect = True
      Me.treePath.HideSelection = False
      Me.treePath.Location = New System.Drawing.Point(12, 312)
      Me.treePath.Name = "treePath"
      Me.treePath.Size = New System.Drawing.Size(338, 131)
      Me.treePath.TabIndex = 14
      '
      'locateGroupBox
      '
      Me.locateGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.locateGroupBox.Controls.Add(Me.locateTextBox)
      Me.locateGroupBox.Controls.Add(Me.locateComboBox)
      Me.locateGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
      Me.locateGroupBox.Location = New System.Drawing.Point(13, 12)
      Me.locateGroupBox.Name = "locateGroupBox"
      Me.locateGroupBox.Size = New System.Drawing.Size(336, 158)
      Me.locateGroupBox.TabIndex = 12
      Me.locateGroupBox.TabStop = False
      Me.locateGroupBox.Text = "Locate Element"
      '
      'locateTextBox
      '
      Me.locateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.locateTextBox.BackColor = System.Drawing.SystemColors.Info
      Me.locateTextBox.Location = New System.Drawing.Point(6, 52)
      Me.locateTextBox.Multiline = True
      Me.locateTextBox.Name = "locateTextBox"
      Me.locateTextBox.ReadOnly = True
      Me.locateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.locateTextBox.Size = New System.Drawing.Size(324, 100)
      Me.locateTextBox.TabIndex = 2
      Me.locateTextBox.WordWrap = False
      '
      'locateComboBox
      '
      Me.locateComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.locateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.locateComboBox.FormattingEnabled = True
      Me.locateComboBox.Items.AddRange(New Object() {"/sports", "//game", "//name", "//paragraph", "//game[name='Cricket']", "//game/@id"})
      Me.locateComboBox.Location = New System.Drawing.Point(6, 21)
      Me.locateComboBox.Name = "locateComboBox"
      Me.locateComboBox.Size = New System.Drawing.Size(324, 24)
      Me.locateComboBox.TabIndex = 1
      '
      'previousButton
      '
      Me.previousButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
      Me.previousButton.Location = New System.Drawing.Point(66, 22)
      Me.previousButton.Name = "previousButton"
      Me.previousButton.Size = New System.Drawing.Size(100, 30)
      Me.previousButton.TabIndex = 0
      Me.previousButton.Text = "Previous"
      '
      'navigateGroupBox
      '
      Me.navigateGroupBox.Controls.Add(Me.nextButton)
      Me.navigateGroupBox.Controls.Add(Me.firstChildButton)
      Me.navigateGroupBox.Controls.Add(Me.parentButton)
      Me.navigateGroupBox.Controls.Add(Me.previousButton)
      Me.navigateGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
      Me.navigateGroupBox.Location = New System.Drawing.Point(65, 176)
      Me.navigateGroupBox.Name = "navigateGroupBox"
      Me.navigateGroupBox.Size = New System.Drawing.Size(232, 130)
      Me.navigateGroupBox.TabIndex = 13
      Me.navigateGroupBox.TabStop = False
      Me.navigateGroupBox.Text = "Navigation Controls"
      '
      'PathNavigator
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(362, 454)
      Me.Controls.Add(Me.treePath)
      Me.Controls.Add(Me.locateGroupBox)
      Me.Controls.Add(Me.navigateGroupBox)
      Me.Name = "PathNavigator"
      Me.Text = "Path Navigator"
      Me.locateGroupBox.ResumeLayout(False)
      Me.locateGroupBox.PerformLayout()
      Me.navigateGroupBox.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents nextButton As System.Windows.Forms.Button
   Private WithEvents firstChildButton As System.Windows.Forms.Button
   Private WithEvents parentButton As System.Windows.Forms.Button
   Private WithEvents treePath As System.Windows.Forms.TreeView
   Private WithEvents locateGroupBox As System.Windows.Forms.GroupBox
   Private WithEvents locateTextBox As System.Windows.Forms.TextBox
   Private WithEvents locateComboBox As System.Windows.Forms.ComboBox
   Private WithEvents previousButton As System.Windows.Forms.Button
   Private WithEvents navigateGroupBox As System.Windows.Forms.GroupBox

End Class
