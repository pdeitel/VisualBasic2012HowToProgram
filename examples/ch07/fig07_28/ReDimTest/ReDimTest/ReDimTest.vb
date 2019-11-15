' Fig 7.28: ReDimTest.vb
' Resize an array using the ReDim statement.
Public Class ReDimTest
   ' demonstrate ReDim
   Private Sub ReDimTest_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' create and initialize two 5-element arrays
      Dim values1() As Integer = {1, 2, 3, 4, 5}
      Dim values2() As Integer = {1, 2, 3, 4, 5}

      ' display array length and the elements in array
      outputTextBox.AppendText(
         "The original array has " & values1.Length & " elements: ")
      DisplayArray(values1)

      ' change the size of the array without the Preserve keyword
      ReDim values1(6)

      ' display new array length and the elements in array
      outputTextBox.AppendText("New array (without Preserve) has " &
         values1.Length & " elements: ")
      DisplayArray(values1)

      ' change the size of the array with the Preserve keyword
      ReDim Preserve values2(6)
      values2(6) = 7 ' assign 7 to array element 6        

      ' display new array length and the elements in array
      outputTextBox.AppendText("New array (with Preserve) has " &
         values2.Length & " elements: ")
      DisplayArray(values2)
   End Sub

   ' display array elements
   Sub DisplayArray(array() As Integer)
      For Each number In array
         outputTextBox.AppendText(number & "  ")
      Next

      outputTextBox.AppendText(vbCrLf)
   End Sub ' DisplayArray
End Class ' ReDimTest

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
