' Fig. 7.17: RectangularArray.vb
' Initializing and displaying a rectangular array.
Public Class RectangularArray
   ' display the contents of a rectangular array
   Private Sub RectangularArray_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      Dim values(,) As Integer = {{1, 2, 3}, {4, 5, 6}}

      ' output elements of the values array
	  For row = 0 To values.GetUpperBound(0)
         For column = 0 To values.GetUpperBound(1)
            outputTextBox.AppendText(values(row, column) & vbTab)
         Next column

         outputTextBox.AppendText(vbCrLf)
      Next row
   End Sub ' RectangularArray_Load
End Class ' RectangularArray

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
' *************************************************************************
