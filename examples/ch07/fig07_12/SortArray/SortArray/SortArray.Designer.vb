<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SortArray
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
      Me.sortButton = New System.Windows.Forms.Button()
      Me.createDataButton = New System.Windows.Forms.Button()
      Me.sortedValuesLabel = New System.Windows.Forms.Label()
      Me.originalValuesLabel = New System.Windows.Forms.Label()
      Me.originalValuesListBox = New System.Windows.Forms.ListBox()
      Me.sortedValuesListBox = New System.Windows.Forms.ListBox()
      Me.SuspendLayout()
      '
      'sortButton
      '
      Me.sortButton.Enabled = False
      Me.sortButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.sortButton.ForeColor = System.Drawing.SystemColors.ControlText
      Me.sortButton.Location = New System.Drawing.Point(198, 62)
      Me.sortButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.sortButton.Name = "sortButton"
      Me.sortButton.Size = New System.Drawing.Size(87, 23)
      Me.sortButton.TabIndex = 17
      Me.sortButton.Text = "Sort"
      '
      'createDataButton
      '
      Me.createDataButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.createDataButton.Location = New System.Drawing.Point(198, 29)
      Me.createDataButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.createDataButton.Name = "createDataButton"
      Me.createDataButton.Size = New System.Drawing.Size(87, 23)
      Me.createDataButton.TabIndex = 16
      Me.createDataButton.Text = "Create Data"
      '
      'sortedValuesLabel
      '
      Me.sortedValuesLabel.AutoSize = True
      Me.sortedValuesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.sortedValuesLabel.Location = New System.Drawing.Point(105, 9)
      Me.sortedValuesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.sortedValuesLabel.Name = "sortedValuesLabel"
      Me.sortedValuesLabel.Size = New System.Drawing.Size(77, 15)
      Me.sortedValuesLabel.TabIndex = 13
      Me.sortedValuesLabel.Text = "Sorted values"
      '
      'originalValuesLabel
      '
      Me.originalValuesLabel.AutoSize = True
      Me.originalValuesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.originalValuesLabel.Location = New System.Drawing.Point(10, 9)
      Me.originalValuesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.originalValuesLabel.Name = "originalValuesLabel"
      Me.originalValuesLabel.Size = New System.Drawing.Size(85, 15)
      Me.originalValuesLabel.TabIndex = 12
      Me.originalValuesLabel.Text = "Original values"
      '
      'originalValuesListBox
      '
      Me.originalValuesListBox.FormattingEnabled = True
      Me.originalValuesListBox.ItemHeight = 15
      Me.originalValuesListBox.Location = New System.Drawing.Point(13, 29)
      Me.originalValuesListBox.Name = "originalValuesListBox"
      Me.originalValuesListBox.Size = New System.Drawing.Size(82, 154)
      Me.originalValuesListBox.TabIndex = 18
      '
      'sortedValuesListBox
      '
      Me.sortedValuesListBox.FormattingEnabled = True
      Me.sortedValuesListBox.ItemHeight = 15
      Me.sortedValuesListBox.Location = New System.Drawing.Point(108, 29)
      Me.sortedValuesListBox.Name = "sortedValuesListBox"
      Me.sortedValuesListBox.Size = New System.Drawing.Size(83, 154)
      Me.sortedValuesListBox.TabIndex = 19
      '
      'SortArray
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(297, 194)
      Me.Controls.Add(Me.sortedValuesListBox)
      Me.Controls.Add(Me.originalValuesListBox)
      Me.Controls.Add(Me.sortButton)
      Me.Controls.Add(Me.createDataButton)
      Me.Controls.Add(Me.sortedValuesLabel)
      Me.Controls.Add(Me.originalValuesLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "SortArray"
      Me.Text = "Sort Array"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents sortButton As System.Windows.Forms.Button
   Friend WithEvents createDataButton As System.Windows.Forms.Button
   Friend WithEvents sortedValuesLabel As System.Windows.Forms.Label
   Friend WithEvents originalValuesLabel As System.Windows.Forms.Label
   Friend WithEvents originalValuesListBox As System.Windows.Forms.ListBox
   Friend WithEvents sortedValuesListBox As System.Windows.Forms.ListBox

End Class
