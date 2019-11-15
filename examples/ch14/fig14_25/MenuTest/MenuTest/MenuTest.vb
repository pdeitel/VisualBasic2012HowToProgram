' Fig. 14.25: MenuTest.vb
' Using Menus to change font colors and styles.
Public Class MenuTestForm

   ' display MessageBox when About menu item is selected
   Private Sub aboutToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles aboutToolStripMenuItem.Click

      MessageBox.Show("This is an example" & vbNewLine &
         "of using menus.", "About", MessageBoxButtons.OK,
         MessageBoxIcon.Information)
   End Sub ' aboutToolStripMenuItem_Click

   ' exit program when Exit Menumenu itemItem is selected
   Private Sub exitToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles exitToolStripMenuItem.Click

      Application.Exit()
   End Sub ' exitToolStripMenuItem_Click

   ' reset checkmarks for Color menu items
   Private Sub ClearColor()
      ' clear all checkmarks
      blackToolStripMenuItem.Checked = False
      blueToolStripMenuItem.Checked = False
      redToolStripMenuItem.Checked = False
      greenToolStripMenuItem.Checked = False
   End Sub ' ClearColor

   ' update Menu state and color displayLabel black
   Private Sub blackToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles blackToolStripMenuItem.Click

      ClearColor() ' reset checkmarks for Color menu items
      displayLabel.ForeColor = Color.Black ' set Color to Black
      blackToolStripMenuItem.Checked = True
   End Sub ' blackToolStripMenuItem_Click

   ' update Menu state and color displayLabel blue
   Private Sub blueToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles blueToolStripMenuItem.Click

      ClearColor() ' reset checkmarks for Color menu items
      displayLabel.ForeColor = Color.Blue ' set Color to Blue
      blueToolStripMenuItem.Checked = True
   End Sub ' blueToolStripMenuItem_Click

   ' update Menu state and color displayLabel red
   Private Sub redToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles redToolStripMenuItem.Click

      ClearColor() ' reset checkmarks for Color menu items
      displayLabel.ForeColor = Color.Red ' set Color to Red
      redToolStripMenuItem.Checked = True
   End Sub ' redToolStripMenuItem_Click

   ' update Menu state and color displayLabel green
   Private Sub greenToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles greenToolStripMenuItem.Click

      ClearColor() ' reset checkmarks for Color menu items
      displayLabel.ForeColor = Color.Green ' set Color to Green
      greenToolStripMenuItem.Checked = True
   End Sub ' greenToolStripMenuItem_Click

   ' reset checkmarks for Font menu items
   Private Sub ClearFont()
      timesToolStripMenuItem.Checked = False
      courierToolStripMenuItem.Checked = False
      comicToolStripMenuItem.Checked = False
   End Sub ' ClearFont

   ' update Menu state and set Font to Times New Roman
   Private Sub timesToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles timesToolStripMenuItem.Click

      ClearFont() ' reset checkmarks for Font menu items
      timesToolStripMenuItem.Checked = True

      ' set Times New Roman font
      displayLabel.Font =
         New Font("Times New Roman", 14, displayLabel.Font.Style)
   End Sub ' timesToolStripMenuItem_Click

   ' update Menu state and set Font to Courier New
   Private Sub courierToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles courierToolStripMenuItem.Click

      ClearFont() ' reset checkmarks for Font menu items
      courierToolStripMenuItem.Checked = True

      ' set Courier font
      displayLabel.Font =
         New Font("Courier New", 14, displayLabel.Font.Style)
   End Sub ' courierToolStripMenuItem_Click

   ' update Menu state and set Font to Comic Sans MS
   Private Sub comicToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles comicToolStripMenuItem.Click

      ClearFont() ' reset checkmarks for Font menu items
      comicToolStripMenuItem.Checked = True

      ' set Comic Sans MS font
      displayLabel.Font =
         New Font("Comic Sans MS", 14, displayLabel.Font.Style)
   End Sub ' comicToolStripMenuItem_Click

   ' toggle checkmark and toggle bold style
   Private Sub boldToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles boldToolStripMenuItem.Click
      ' toggle menu item checkmark
      boldToolStripMenuItem.Checked = Not boldToolStripMenuItem.Checked

      ' use Xor to toggle bold, keep all other styles
      displayLabel.Font = New Font(displayLabel.Font.FontFamily, 14,
         displayLabel.Font.Style Xor FontStyle.Bold)
   End Sub ' boldToolStripMenuItem_Click

   ' toggle checkmark and toggle italic style
   Private Sub italicToolStripMenuItem_Click(
      sender As Object, e As EventArgs) _
      Handles italicToolStripMenuItem.Click
      ' toggle menu item checkmark
      italicToolStripMenuItem.Checked =
         Not italicToolStripMenuItem.Checked

      ' use Xor to toggle italic, keep all other styles
      displayLabel.Font = New Font(displayLabel.Font.FontFamily, 14,
         displayLabel.Font.Style Xor FontStyle.Italic)
   End Sub ' italicToolStripMenuItem_Click
End Class ' MenuTest

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
