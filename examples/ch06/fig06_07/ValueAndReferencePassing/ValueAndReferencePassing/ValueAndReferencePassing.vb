' Fig. 6.7: ValueAndReferencePassing.vb
' Passing arguments by value and by reference.
Public Class ValueAndReferencePassing
   ' call methods SquareByValue and SquareByReference
   Private Sub squareButton_Click(sender As Object,
      e As EventArgs) Handles squareButton.Click
      ' get user input and convert it to an Integer value
      Dim number1 As Integer = Convert.ToInt32(squareTextBox.Text)

      outputTextBox.AppendText(
         "Passing a value-type argument by value:" & vbCrLf)
      outputTextBox.AppendText(String.Format(
         "Before calling SquareByValue, number1 is {0}{1}",
         number1, vbCrLf))
      SquareByValue(number1)  ' passes number1 by value
      outputTextBox.AppendText(String.Format(
         "After returning from SquareByValue, number1 is {0}{1}{1}",
         number1, vbCrLf))

      Dim number2 As Integer = Convert.ToInt32(squareTextBox.Text)

      outputTextBox.AppendText(
         "Passing a value-type argument by reference:" & vbCrLf)
      outputTextBox.AppendText(String.Format(
         "Before calling SquareByReference, number2 is {0}{1}",
         number2, vbCrLf))
      SquareByReference(number2) ' passes number2 by reference
      outputTextBox.AppendText(String.Format(
         "After returning from SquareByReference, number2 is {0}{1}{1}",
         number2, vbCrLf))

      Dim number3 As Integer = Convert.ToInt32(squareTextBox.Text)

      outputTextBox.AppendText("Passing a value-type argument" &
         " by reference, but in parentheses:" & vbCrLf)
      outputTextBox.AppendText(String.Format("Before calling " &
         "SquareByReference using parentheses, number3 is {0}{1}",
         number3, vbCrLf))
      SquareByReference((number3)) ' passes number3 by value
      outputTextBox.AppendText(String.Format("After returning from " &
         "SquareByReference, number3 is {0}", number3))
   End Sub ' squareButton_Click

   ' squares number by value (note ByVal keyword)
   Sub SquareByValue(ByVal number As Integer)
      outputTextBox.AppendText(String.Format(
         "After entering SquareByValue, number is {0}{1}",
         number, vbCrLf))
      number *= number
      outputTextBox.AppendText(String.Format(
         "Before exiting SquareByValue, number is {0}{1}",
         number, vbCrLf))
   End Sub ' SquareByValue

   ' squares number by reference (note ByRef keyword)
   Sub SquareByReference(ByRef number As Integer)
      outputTextBox.AppendText(String.Format(
         "After entering SquareByReference, number is {0}{1}",
         number, vbCrLf))
      number *= number
      outputTextBox.AppendText(String.Format(
         "Before exiting SquareByReference, number is {0}{1}",
         number, vbCrLf))
   End Sub ' SquareByReference

   ' clear the outputTextBox when squareTextBox's value changes
   Private Sub squareTextBox_TextChanged(sender As Object,
      e As EventArgs) Handles squareTextBox.TextChanged
      outputTextBox.Text = String.Empty
   End Sub ' squareTextBox_TextChanged
End Class ' ValueAndReferencePassing

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