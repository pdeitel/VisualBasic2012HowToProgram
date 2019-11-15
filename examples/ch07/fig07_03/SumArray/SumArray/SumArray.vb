' Fig. 7.3: SumArray.vb
' Computing the sum of the elements in an array.
Public Class SumArray
   ' use a loop to sum the elements in an array
   Private Sub SumArray_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      Dim values() As Integer = {85, 77, 91, 44, 65, 72, 99, 84, 95, 100}
      Dim total As Integer = 0

      ' sum the array element values
      For i = 0 To values.GetUpperBound(0)
         total += values(i)
      Next

      sumLabel.Text = Convert.ToString(total)
   End Sub ' SumArray_Load
End Class ' SumArray 

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