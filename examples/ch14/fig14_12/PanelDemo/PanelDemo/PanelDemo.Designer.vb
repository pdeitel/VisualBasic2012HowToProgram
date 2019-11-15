<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelDemo
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
      Me.outputLabel = New System.Windows.Forms.Label()
      Me.buttonPanel = New System.Windows.Forms.Panel()
      Me.Button6 = New System.Windows.Forms.Button()
      Me.Button5 = New System.Windows.Forms.Button()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.buttonPanel.SuspendLayout()
      Me.SuspendLayout()
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(14, 140)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(233, 27)
      Me.outputLabel.TabIndex = 0
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'buttonPanel
      '
      Me.buttonPanel.AutoScroll = True
      Me.buttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.buttonPanel.Controls.Add(Me.Button6)
      Me.buttonPanel.Controls.Add(Me.Button5)
      Me.buttonPanel.Controls.Add(Me.Button4)
      Me.buttonPanel.Controls.Add(Me.Button3)
      Me.buttonPanel.Controls.Add(Me.Button2)
      Me.buttonPanel.Controls.Add(Me.Button1)
      Me.buttonPanel.Location = New System.Drawing.Point(14, 14)
      Me.buttonPanel.Name = "buttonPanel"
      Me.buttonPanel.Size = New System.Drawing.Size(233, 115)
      Me.buttonPanel.TabIndex = 1
      '
      'Button6
      '
      Me.Button6.Location = New System.Drawing.Point(3, 171)
      Me.Button6.Name = "Button6"
      Me.Button6.Size = New System.Drawing.Size(87, 27)
      Me.Button6.TabIndex = 6
      Me.Button6.Text = "Button6"
      Me.Button6.UseVisualStyleBackColor = True
      '
      'Button5
      '
      Me.Button5.Location = New System.Drawing.Point(3, 137)
      Me.Button5.Name = "Button5"
      Me.Button5.Size = New System.Drawing.Size(87, 27)
      Me.Button5.TabIndex = 5
      Me.Button5.Text = "Button5"
      Me.Button5.UseVisualStyleBackColor = True
      '
      'Button4
      '
      Me.Button4.Location = New System.Drawing.Point(3, 104)
      Me.Button4.Name = "Button4"
      Me.Button4.Size = New System.Drawing.Size(87, 27)
      Me.Button4.TabIndex = 3
      Me.Button4.Text = "Button4"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'Button3
      '
      Me.Button3.Location = New System.Drawing.Point(3, 70)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(87, 27)
      Me.Button3.TabIndex = 2
      Me.Button3.Text = "Button3"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.Location = New System.Drawing.Point(3, 37)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(87, 27)
      Me.Button2.TabIndex = 1
      Me.Button2.Text = "Button2"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(3, 3)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(87, 27)
      Me.Button1.TabIndex = 0
      Me.Button1.Text = "Button1"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'PanelDemo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(262, 181)
      Me.Controls.Add(Me.buttonPanel)
      Me.Controls.Add(Me.outputLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "PanelDemo"
      Me.Text = "Panel Demo"
      Me.buttonPanel.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents outputLabel As System.Windows.Forms.Label
   Friend WithEvents buttonPanel As System.Windows.Forms.Panel
   Friend WithEvents Button6 As System.Windows.Forms.Button
   Friend WithEvents Button5 As System.Windows.Forms.Button
   Friend WithEvents Button4 As System.Windows.Forms.Button
   Friend WithEvents Button3 As System.Windows.Forms.Button
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
