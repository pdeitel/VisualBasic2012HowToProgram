' Fig. 14.35: CheckedListBoxTest.vb
' Using the checked ListBox to add items to a display ListBox
Public Class CheckedListBoxTest
   ' add an item to or remove an item from displayListBox
   Private Sub itemCheckedListBox_ItemCheck(
      sender As Object, e As ItemCheckEventArgs) _
      Handles itemCheckedListBox.ItemCheck

      ' obtain selected item
      Dim item As String = itemCheckedListBox.SelectedItem.ToString()

      ' if the selected item is checked add it to displayListBox; 
      ' otherwise, remove it from displayListBox
      If e.NewValue = CheckState.Checked Then
         displayListBox.Items.Add(item)
      Else
         displayListBox.Items.Remove(item)
      End If
   End Sub ' itemCheckedListBox_ItemCheck
End Class ' CheckedListBoxTest

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
' * furnishing, performance, or use of thes`e programs.                     *
' **************************************************************************
