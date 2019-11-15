' Fig. 7.12: SortArray.vb
' Sorting an array with method Array.Sort.
Public Class SortArray
   Dim integerArray(9) As Integer ' create 10-element array
   Dim randomNumber As New Random()

   ' creates random generated numbers
   Private Sub createDataButton_Click(sender As Object, 
      e As EventArgs) Handles createDataButton.Click

      originalValuesListBox.Items.Clear() ' clear originalValuesListBox
      sortedValuesListBox.Items.Clear() ' clear sortedValuesListBox

      ' create 10 random numbers and add to originalValuesListBox
	  For i = 0 To integerArray.GetUpperBound(0)
         integerArray(i) = randomNumber.Next(100)
         originalValuesListBox.Items.Add(integerArray(i))
      Next

      sortButton.Enabled = True ' enable Sort button 
   End Sub ' createDataButton_Click

   ' sorts randomly generated numbers
   Private Sub sortButton_Click(sender As Object, 
      e As EventArgs) Handles sortButton.Click

      Array.Sort(integerArray) ' sort array integerArray

      ' display sorted numbers in sortedValuesListBox
      For i = 0 To integerArray.GetUpperBound(0)
         sortedValuesListBox.Items.Add(integerArray(i))
      Next

      sortButton.Enabled = False ' disable Sort button
   End Sub ' sortButton_Click
End Class ' SortArray


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
