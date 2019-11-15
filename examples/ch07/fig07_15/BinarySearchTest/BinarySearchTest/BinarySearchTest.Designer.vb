<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinarySearchTest
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
      Me.searchButton = New System.Windows.Forms.Button()
      Me.createDataButton = New System.Windows.Forms.Button()
      Me.resultLabel = New System.Windows.Forms.Label()
      Me.searchKeyTextBox = New System.Windows.Forms.TextBox()
      Me.searchKeyLabel = New System.Windows.Forms.Label()
      Me.dataListBox = New System.Windows.Forms.ListBox()
      Me.SuspendLayout()
      '
      'searchButton
      '
      Me.searchButton.Enabled = False
      Me.searchButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.searchButton.Location = New System.Drawing.Point(275, 121)
      Me.searchButton.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
      Me.searchButton.Name = "searchButton"
      Me.searchButton.Size = New System.Drawing.Size(100, 23)
      Me.searchButton.TabIndex = 2
      Me.searchButton.Text = "Search"
      '
      'createDataButton
      '
      Me.createDataButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.createDataButton.Location = New System.Drawing.Point(138, 12)
      Me.createDataButton.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
      Me.createDataButton.Name = "createDataButton"
      Me.createDataButton.Size = New System.Drawing.Size(100, 23)
      Me.createDataButton.TabIndex = 0
      Me.createDataButton.Text = "Create Data"
      '
      'resultLabel
      '
      Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.resultLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.resultLabel.Location = New System.Drawing.Point(138, 156)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(237, 25)
      Me.resultLabel.TabIndex = 15
      Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'searchKeyTextBox
      '
      Me.searchKeyTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.searchKeyTextBox.Location = New System.Drawing.Point(138, 121)
      Me.searchKeyTextBox.Name = "searchKeyTextBox"
      Me.searchKeyTextBox.Size = New System.Drawing.Size(131, 23)
      Me.searchKeyTextBox.TabIndex = 1
      '
      'searchKeyLabel
      '
      Me.searchKeyLabel.AutoSize = True
      Me.searchKeyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.searchKeyLabel.Location = New System.Drawing.Point(134, 103)
      Me.searchKeyLabel.Name = "searchKeyLabel"
      Me.searchKeyLabel.Size = New System.Drawing.Size(135, 15)
      Me.searchKeyLabel.TabIndex = 12
      Me.searchKeyLabel.Text = "Enter integer search key:"
      '
      'dataListBox
      '
      Me.dataListBox.FormattingEnabled = True
      Me.dataListBox.ItemHeight = 15
      Me.dataListBox.Location = New System.Drawing.Point(12, 12)
      Me.dataListBox.Name = "dataListBox"
      Me.dataListBox.Size = New System.Drawing.Size(120, 169)
      Me.dataListBox.TabIndex = 18
      '
      'BinarySearchTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(388, 192)
      Me.Controls.Add(Me.dataListBox)
      Me.Controls.Add(Me.searchButton)
      Me.Controls.Add(Me.createDataButton)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.searchKeyTextBox)
      Me.Controls.Add(Me.searchKeyLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "BinarySearchTest"
      Me.Text = "Binary Search Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents searchButton As System.Windows.Forms.Button
   Friend WithEvents createDataButton As System.Windows.Forms.Button
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents searchKeyTextBox As System.Windows.Forms.TextBox
   Friend WithEvents searchKeyLabel As System.Windows.Forms.Label
   Friend WithEvents dataListBox As System.Windows.Forms.ListBox

End Class
