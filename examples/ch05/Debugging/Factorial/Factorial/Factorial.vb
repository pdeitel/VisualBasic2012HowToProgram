' Exercise 5.13: Factorial.vb
Public Class Factorial
   ' calculate factorial of user input number
   Private Sub calculateButton_Click(sender As Object,
      e As EventArgs) Handles calculateButton.Click

      Dim input As Integer = 0 ' user input
      Dim factorial As Integer = 1 ' holds factorial

      input = Val(numberTextBox.Text) ' get user input

      ' loop until input equals zero
      Do
         factorial *= input ' calculate factorial
         input -= 1 ' decrement counter
      Loop Until input > 1 ' test condition

      factorialResultLabel.Text = factorial ' display factorial
   End Sub ' calculateButton_Click
End Class ' Factorial


' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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