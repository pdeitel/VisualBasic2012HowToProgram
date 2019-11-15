<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindTheSmallest
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
      Me.gradesListBox = New System.Windows.Forms.ListBox()
      Me.findSmallestButton = New System.Windows.Forms.Button()
      Me.createGradesButton = New System.Windows.Forms.Button()
      Me.gradesLabel = New System.Windows.Forms.Label()
      Me.smallestGradeResultLabel = New System.Windows.Forms.Label()
      Me.smallestGradeLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'gradesListBox
      '
      Me.gradesListBox.FormattingEnabled = True
      Me.gradesListBox.ItemHeight = 15
      Me.gradesListBox.Location = New System.Drawing.Point(12, 29)
      Me.gradesListBox.Name = "gradesListBox"
      Me.gradesListBox.Size = New System.Drawing.Size(82, 154)
      Me.gradesListBox.TabIndex = 22
      '
      'findSmallestButton
      '
      Me.findSmallestButton.Enabled = False
      Me.findSmallestButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.findSmallestButton.ForeColor = System.Drawing.SystemColors.ControlText
      Me.findSmallestButton.Location = New System.Drawing.Point(105, 62)
      Me.findSmallestButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.findSmallestButton.Name = "findSmallestButton"
      Me.findSmallestButton.Size = New System.Drawing.Size(98, 23)
      Me.findSmallestButton.TabIndex = 21
      Me.findSmallestButton.Text = "Find Smallest"
      '
      'createGradesButton
      '
      Me.createGradesButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.createGradesButton.Location = New System.Drawing.Point(105, 29)
      Me.createGradesButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
      Me.createGradesButton.Name = "createGradesButton"
      Me.createGradesButton.Size = New System.Drawing.Size(98, 23)
      Me.createGradesButton.TabIndex = 20
      Me.createGradesButton.Text = "Create Grades"
      '
      'gradesLabel
      '
      Me.gradesLabel.AutoSize = True
      Me.gradesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gradesLabel.Location = New System.Drawing.Point(9, 9)
      Me.gradesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.gradesLabel.Name = "gradesLabel"
      Me.gradesLabel.Size = New System.Drawing.Size(46, 15)
      Me.gradesLabel.TabIndex = 19
      Me.gradesLabel.Text = "Grades:"
      '
      'smallestGradeResultLabel
      '
      Me.smallestGradeResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.smallestGradeResultLabel.Location = New System.Drawing.Point(105, 116)
      Me.smallestGradeResultLabel.Name = "smallestGradeResultLabel"
      Me.smallestGradeResultLabel.Size = New System.Drawing.Size(98, 23)
      Me.smallestGradeResultLabel.TabIndex = 23
      Me.smallestGradeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'smallestGradeLabel
      '
      Me.smallestGradeLabel.AutoSize = True
      Me.smallestGradeLabel.Location = New System.Drawing.Point(102, 98)
      Me.smallestGradeLabel.Name = "smallestGradeLabel"
      Me.smallestGradeLabel.Size = New System.Drawing.Size(87, 15)
      Me.smallestGradeLabel.TabIndex = 24
      Me.smallestGradeLabel.Text = "Smallest grade:"
      '
      'FindTheSmallest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(216, 196)
      Me.Controls.Add(Me.smallestGradeLabel)
      Me.Controls.Add(Me.smallestGradeResultLabel)
      Me.Controls.Add(Me.gradesListBox)
      Me.Controls.Add(Me.findSmallestButton)
      Me.Controls.Add(Me.createGradesButton)
      Me.Controls.Add(Me.gradesLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "FindTheSmallest"
      Me.Text = "Find the Smallest"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents gradesListBox As System.Windows.Forms.ListBox
   Friend WithEvents findSmallestButton As System.Windows.Forms.Button
   Friend WithEvents createGradesButton As System.Windows.Forms.Button
   Friend WithEvents gradesLabel As System.Windows.Forms.Label
   Friend WithEvents smallestGradeResultLabel As System.Windows.Forms.Label
   Friend WithEvents smallestGradeLabel As System.Windows.Forms.Label

End Class
