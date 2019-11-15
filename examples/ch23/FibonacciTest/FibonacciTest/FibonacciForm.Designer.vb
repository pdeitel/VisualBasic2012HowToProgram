<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FibonacciForm
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
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.asyncResultLabel = New System.Windows.Forms.Label()
      Me.calculateButton = New System.Windows.Forms.Button()
      Me.inputTextBox = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.groupBox2 = New System.Windows.Forms.GroupBox()
      Me.syncResultLabel = New System.Windows.Forms.Label()
      Me.nextNumberButton = New System.Windows.Forms.Button()
      Me.displayLabel = New System.Windows.Forms.Label()
      Me.groupBox1.SuspendLayout()
      Me.groupBox2.SuspendLayout()
      Me.SuspendLayout()
      '
      'groupBox1
      '
      Me.groupBox1.Controls.Add(Me.asyncResultLabel)
      Me.groupBox1.Controls.Add(Me.calculateButton)
      Me.groupBox1.Controls.Add(Me.inputTextBox)
      Me.groupBox1.Controls.Add(Me.label1)
      Me.groupBox1.Location = New System.Drawing.Point(12, 12)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(214, 79)
      Me.groupBox1.TabIndex = 2
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "Calculate Asynchronously"
      '
      'asyncResultLabel
      '
      Me.asyncResultLabel.AutoSize = True
      Me.asyncResultLabel.Location = New System.Drawing.Point(102, 51)
      Me.asyncResultLabel.Name = "asyncResultLabel"
      Me.asyncResultLabel.Size = New System.Drawing.Size(0, 13)
      Me.asyncResultLabel.TabIndex = 3
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(11, 46)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(85, 23)
      Me.calculateButton.TabIndex = 2
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'inputTextBox
      '
      Me.inputTextBox.Location = New System.Drawing.Point(102, 20)
      Me.inputTextBox.Name = "inputTextBox"
      Me.inputTextBox.Size = New System.Drawing.Size(100, 20)
      Me.inputTextBox.TabIndex = 1
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(8, 23)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(88, 13)
      Me.label1.TabIndex = 0
      Me.label1.Text = "Get Fibonacci of:"
      '
      'groupBox2
      '
      Me.groupBox2.Controls.Add(Me.syncResultLabel)
      Me.groupBox2.Controls.Add(Me.nextNumberButton)
      Me.groupBox2.Controls.Add(Me.displayLabel)
      Me.groupBox2.Location = New System.Drawing.Point(12, 118)
      Me.groupBox2.Name = "groupBox2"
      Me.groupBox2.Size = New System.Drawing.Size(214, 84)
      Me.groupBox2.TabIndex = 3
      Me.groupBox2.TabStop = False
      Me.groupBox2.Text = "Calculate Synchronously"
      '
      'syncResultLabel
      '
      Me.syncResultLabel.AutoSize = True
      Me.syncResultLabel.Location = New System.Drawing.Point(102, 27)
      Me.syncResultLabel.Name = "syncResultLabel"
      Me.syncResultLabel.Size = New System.Drawing.Size(0, 13)
      Me.syncResultLabel.TabIndex = 6
      '
      'nextNumberButton
      '
      Me.nextNumberButton.Location = New System.Drawing.Point(11, 50)
      Me.nextNumberButton.Name = "nextNumberButton"
      Me.nextNumberButton.Size = New System.Drawing.Size(85, 23)
      Me.nextNumberButton.TabIndex = 5
      Me.nextNumberButton.Text = "Next Number"
      Me.nextNumberButton.UseVisualStyleBackColor = True
      '
      'displayLabel
      '
      Me.displayLabel.AutoSize = True
      Me.displayLabel.Location = New System.Drawing.Point(8, 27)
      Me.displayLabel.Name = "displayLabel"
      Me.displayLabel.Size = New System.Drawing.Size(0, 13)
      Me.displayLabel.TabIndex = 4
      '
      'FibonacciForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(240, 214)
      Me.Controls.Add(Me.groupBox1)
      Me.Controls.Add(Me.groupBox2)
      Me.Name = "FibonacciForm"
      Me.Text = "FibonacciNumbers"
      Me.groupBox1.ResumeLayout(False)
      Me.groupBox1.PerformLayout()
      Me.groupBox2.ResumeLayout(False)
      Me.groupBox2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
   Private WithEvents asyncResultLabel As System.Windows.Forms.Label
   Private WithEvents calculateButton As System.Windows.Forms.Button
   Private WithEvents inputTextBox As System.Windows.Forms.TextBox
   Private WithEvents label1 As System.Windows.Forms.Label
   Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
   Private WithEvents syncResultLabel As System.Windows.Forms.Label
   Private WithEvents nextNumberButton As System.Windows.Forms.Button
   Private WithEvents displayLabel As System.Windows.Forms.Label

End Class
