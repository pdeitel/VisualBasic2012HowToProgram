' Fig. 14.42: UsingMDI.vb
' MDI parent and child windows.
Public Class UsingMDI
   ' create Lavender Flowers image window
   Private Sub lavenderToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles lavenderToolStripMenuItem.Click
      ' create new child
      Dim child As New ChildForm("Lavender Flowers",
         "lavenderflowers")
      child.MdiParent = Me ' set parent
      child.Show() ' display child
   End Sub ' lavenderToolStripMenuItem_Click

   ' create Purple Flowers image window
   Private Sub purpleToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles purpleToolStripMenuItem.Click
      ' create new child
      Dim child As New ChildForm("Purple Flowers",
         "purpleflowers")
      child.MdiParent = Me ' set parent
      child.Show() ' display child
   End Sub ' purpleToolStripMenuItem_Click

   ' create Yellow Flowers image window
   Private Sub yellowToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles yellowToolStripMenuItem.Click
      ' create new child
      Dim child As New ChildForm("Yellow Flowers",
         "yellowflowers")
      child.MdiParent = Me ' set parent
      child.Show() ' display child
   End Sub ' yellowToolStripMenuItem_Click

   ' exit application
   Private Sub exitToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles exitToolStripMenuItem.Click

      Application.Exit()
   End Sub ' exitToolStripMenuItem_Click

   ' set Cascade layout
   Private Sub cascadeToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles cascadeToolStripMenuItem.Click

      Me.LayoutMdi(MdiLayout.Cascade)
   End Sub ' cascadeToolStripMenuItem_Click

   ' set TileHorizontal layout
   Private Sub tileHorizontalToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles tileHorizontalToolStripMenuItem.Click

      Me.LayoutMdi(MdiLayout.TileHorizontal)
   End Sub ' tileHorizontalToolStripMenuItem_Click

   ' set TileVertical layout
   Private Sub tileVerticalToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles tileVerticalToolStripMenuItem.Click

      Me.LayoutMdi(MdiLayout.TileVertical)
   End Sub ' tileVerticalToolStripMenuItem_Click
End Class ' UsingMDI

' **************************************************************************
' * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************


