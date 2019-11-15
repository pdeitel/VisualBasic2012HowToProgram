<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolTipDemo
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
      Me.ToolTip1 = New System.Windows.Forms.ToolTip()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(46, 15)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(80, 15)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "This is a Label"
      Me.ToolTip1.SetToolTip(Me.Label1, "Hovering over the Label")
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(132, 12)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(100, 23)
      Me.TextBox1.TabIndex = 1
      Me.TextBox1.Text = "This is a TextBox"
      Me.ToolTip1.SetToolTip(Me.TextBox1, "Hovering over the TextBox")
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(238, 11)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(115, 23)
      Me.Button1.TabIndex = 2
      Me.Button1.Text = "This is a Button"
      Me.ToolTip1.SetToolTip(Me.Button1, "Hovering over the Button")
      Me.Button1.UseVisualStyleBackColor = True
      '
      'ToolTipDemo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(399, 62)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.Label1)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "ToolTipDemo"
      Me.Text = "ToolTip Demo"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
