' Fig. 4.9: PowerOf2.vb
' Calculates 2 raised to the exponent entered by the user.
Public Class PowerOf2
   ' calculates 2 raised to the exponent entered by the user.
   Private Sub calculateButton_Click(sender As Object,
      e As EventArgs) Handles calculateButton.Click

      Dim exponent As Integer = exponentTextBox.Text ' get the exponent
      Dim result As Integer ' stores the calculation result

      result = 2 ' number to raise to a power
      result ^= exponent ' same as result = result ^ exponent
      resultLabel.Text = "result = 2" & vbCrLf &
         "result ^= " & exponent & ": " & result & vbCrLf & vbCrLf

      result = 2 ' reset result to 2 for next calculation
      result = result ^ exponent ' same as result ^= exponent
      resultLabel.Text &= "result = 2" & vbCrLf &
         "result = result ^ " & exponent & ": " & result
   End Sub ' calculateButton_Click

   ' clear results when user types in the exponentTextBox
   Private Sub exponentTextBox_TextChanged(sender As Object,
      e As EventArgs) Handles exponentTextBox.TextChanged
      resultLabel.Text = String.Empty ' clears the resultLabel's text
   End Sub ' exponentTextBox_TextChanged 
End Class ' PowerOf2


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
