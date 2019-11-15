<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckedListBoxTest
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
      Me.displayListBox = New System.Windows.Forms.ListBox()
      Me.itemCheckedListBox = New System.Windows.Forms.CheckedListBox()
      Me.SuspendLayout()
      '
      'displayListBox
      '
      Me.displayListBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.displayListBox.FormattingEnabled = True
      Me.displayListBox.ItemHeight = 15
      Me.displayListBox.Location = New System.Drawing.Point(168, 15)
      Me.displayListBox.Name = "displayListBox"
      Me.displayListBox.Size = New System.Drawing.Size(141, 124)
      Me.displayListBox.TabIndex = 7
      '
      'itemCheckedListBox
      '
      Me.itemCheckedListBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.itemCheckedListBox.FormattingEnabled = True
      Me.itemCheckedListBox.Items.AddRange(New Object() {"C HTP", "C++ HTP", "Internet & WWW HTP", "Java HTP", "VB 2012 HTP", "Visual C++ HTP", "Visual C# 2012 HTP"})
      Me.itemCheckedListBox.Location = New System.Drawing.Point(12, 12)
      Me.itemCheckedListBox.Name = "itemCheckedListBox"
      Me.itemCheckedListBox.Size = New System.Drawing.Size(150, 130)
      Me.itemCheckedListBox.TabIndex = 6
      '
      'CheckedListBoxTest
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(321, 155)
      Me.Controls.Add(Me.displayListBox)
      Me.Controls.Add(Me.itemCheckedListBox)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "CheckedListBoxTest"
      Me.Text = "CheckedListBox Test"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents displayListBox As System.Windows.Forms.ListBox
   Friend WithEvents itemCheckedListBox As System.Windows.Forms.CheckedListBox

End Class
