<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeckOfCardsTest
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
      Me.shuffleButton = New System.Windows.Forms.Button()
      Me.dealButton = New System.Windows.Forms.Button()
      Me.card1PictureBox = New System.Windows.Forms.PictureBox()
      Me.card2PictureBox = New System.Windows.Forms.PictureBox()
      Me.card3PictureBox = New System.Windows.Forms.PictureBox()
      Me.card4PictureBox = New System.Windows.Forms.PictureBox()
      Me.card5PictureBox = New System.Windows.Forms.PictureBox()
      Me.SuspendLayout()
      '
      'shuffleButton
      '
      Me.shuffleButton.Location = New System.Drawing.Point(108, 12)
      Me.shuffleButton.Name = "shuffleButton"
      Me.shuffleButton.Size = New System.Drawing.Size(75, 23)
      Me.shuffleButton.TabIndex = 0
      Me.shuffleButton.Text = "Shuffle"
      Me.shuffleButton.UseVisualStyleBackColor = True
      '
      'dealButton
      '
      Me.dealButton.Location = New System.Drawing.Point(189, 12)
      Me.dealButton.Name = "dealButton"
      Me.dealButton.Size = New System.Drawing.Size(75, 23)
      Me.dealButton.TabIndex = 1
      Me.dealButton.Text = "Deal"
      Me.dealButton.UseVisualStyleBackColor = True
      '
      'card1PictureBox
      '
      Me.card1PictureBox.Location = New System.Drawing.Point(12, 41)
      Me.card1PictureBox.Name = "card1PictureBox"
      Me.card1PictureBox.Size = New System.Drawing.Size(65, 87)
      Me.card1PictureBox.TabIndex = 2
      Me.card1PictureBox.TabStop = False
      '
      'card2PictureBox
      '
      Me.card2PictureBox.Location = New System.Drawing.Point(83, 41)
      Me.card2PictureBox.Name = "card2PictureBox"
      Me.card2PictureBox.Size = New System.Drawing.Size(65, 87)
      Me.card2PictureBox.TabIndex = 3
      Me.card2PictureBox.TabStop = False
      '
      'card3PictureBox
      '
      Me.card3PictureBox.Location = New System.Drawing.Point(154, 41)
      Me.card3PictureBox.Name = "card3PictureBox"
      Me.card3PictureBox.Size = New System.Drawing.Size(65, 87)
      Me.card3PictureBox.TabIndex = 4
      Me.card3PictureBox.TabStop = False
      '
      'card4PictureBox
      '
      Me.card4PictureBox.Location = New System.Drawing.Point(225, 41)
      Me.card4PictureBox.Name = "card4PictureBox"
      Me.card4PictureBox.Size = New System.Drawing.Size(65, 87)
      Me.card4PictureBox.TabIndex = 5
      Me.card4PictureBox.TabStop = False
      '
      'card5PictureBox
      '
      Me.card5PictureBox.Location = New System.Drawing.Point(296, 41)
      Me.card5PictureBox.Name = "card5PictureBox"
      Me.card5PictureBox.Size = New System.Drawing.Size(65, 87)
      Me.card5PictureBox.TabIndex = 6
      Me.card5PictureBox.TabStop = False
      '
      'DeckOfCardsTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(372, 140)
      Me.Controls.Add(Me.card5PictureBox)
      Me.Controls.Add(Me.card4PictureBox)
      Me.Controls.Add(Me.card3PictureBox)
      Me.Controls.Add(Me.card2PictureBox)
      Me.Controls.Add(Me.card1PictureBox)
      Me.Controls.Add(Me.dealButton)
      Me.Controls.Add(Me.shuffleButton)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "DeckOfCardsTest"
      Me.Text = "Deck of Cards Test"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents shuffleButton As System.Windows.Forms.Button
   Friend WithEvents dealButton As System.Windows.Forms.Button
   Friend WithEvents card1PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents card2PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents card3PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents card4PictureBox As System.Windows.Forms.PictureBox
   Friend WithEvents card5PictureBox As System.Windows.Forms.PictureBox

End Class
