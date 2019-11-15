' Fig. 3.27: Comparison.vb
' Comparing integers with the equality and relational operators.
Public Class Comparison
   ' compares two integers using the relational and equality operators
   Private Sub compareButton_Click(sender As Object,
      e As EventArgs) Handles compareButton.Click

      ' declare Integer variables to store user input
      Dim number1 As Integer
      Dim number2 As Integer

      number1 = number1TextBox.Text ' get first number entered by user
      number2 = number2TextBox.Text ' get second number entered by user

      If number1 = number2 Then ' number1 is equal to number2
         resultTextBox.AppendText(number1 & " = " & number2)
      End If

      If number1 <> number2 Then ' number1 is not equal to number2
         resultTextBox.AppendText(number1 & " <> " & number2)
      End If

      If number1 < number2 Then ' number1 is less than number2
         resultTextBox.AppendText(vbCrLf & number1 & " < " & number2)
      End If

      If number1 > number2 Then ' number1 is greater than number2
         resultTextBox.AppendText(vbCrLf & number1 & " > " & number2)
      End If

      ' number1 is less than or equal to number2
      If number1 <= number2 Then
         resultTextBox.AppendText(vbCrLf & number1 & " <= " & number2)
      End If

      ' number1 is greater than or equal to number2
      If number1 >= number2 Then
         resultTextBox.AppendText(vbCrLf & number1 & " >= " & number2)
      End If
   End Sub ' compareButton_Click

   ' clears resultTextBox when the user begins typing in number1TextBox
   Private Sub number1TextBox_TextChanged(sender As Object,
      e As EventArgs) Handles number1TextBox.TextChanged

      resultTextBox.Clear() ' clears the resultTextBox
   End Sub ' number1TextBox_TextChanged

   ' clears resultTextBox when the user begins typing in number2TextBox
   Private Sub number2TextBox_TextChanged(sender As Object,
      e As EventArgs) Handles number2TextBox.TextChanged

      resultTextBox.Clear() ' clears the resultTextBox
   End Sub ' number2TextBox_TextChanged
End Class ' Comparison

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
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
