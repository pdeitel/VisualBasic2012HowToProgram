' Ex. 4.6: CalculateSum.vb
' Calculates the sum of the integers from 1 to 10.
Public Class CalculateSum
   ' performs the calculation
   Private Sub CalculateSum_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      Dim sum As Integer
      Dim number As Integer

      sum = 0
      number = 1

      Do While number <= 10
         sum += number
         number += 1
      Loop

      resultLabel.Text = "The sum is: " & sum
   End Sub ' CalculateSum_Load
End Class ' CalculateSum

' **************************************************************************
' * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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