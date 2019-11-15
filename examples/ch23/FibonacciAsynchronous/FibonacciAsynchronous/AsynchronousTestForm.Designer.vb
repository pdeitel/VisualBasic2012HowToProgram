<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsynchronousTestForm
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
      Me.startButton = New System.Windows.Forms.Button()
      Me.outputTextBox = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'startButton
      '
      Me.startButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.startButton.Location = New System.Drawing.Point(12, 30)
      Me.startButton.Name = "startButton"
      Me.startButton.Size = New System.Drawing.Size(350, 23)
      Me.startButton.TabIndex = 5
      Me.startButton.Text = "Start Asynchronous Fibonacci Calls"
      Me.startButton.UseVisualStyleBackColor = True
      '
      'outputTextBox
      '
      Me.outputTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.outputTextBox.Location = New System.Drawing.Point(13, 59)
      Me.outputTextBox.Multiline = True
      Me.outputTextBox.Name = "outputTextBox"
      Me.outputTextBox.Size = New System.Drawing.Size(349, 191)
      Me.outputTextBox.TabIndex = 4
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(13, 13)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(289, 13)
      Me.label1.TabIndex = 3
      Me.label1.Text = "Calls to Fibonacci(46) and Fibonacci(45) in separate threads"
      '
      'AsynchronousTestForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(374, 262)
      Me.Controls.Add(Me.startButton)
      Me.Controls.Add(Me.outputTextBox)
      Me.Controls.Add(Me.label1)
      Me.Name = "AsynchronousTestForm"
      Me.Text = "Asynchronous Test"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents startButton As System.Windows.Forms.Button
   Private WithEvents outputTextBox As System.Windows.Forms.TextBox
   Private WithEvents label1 As System.Windows.Forms.Label

End Class
