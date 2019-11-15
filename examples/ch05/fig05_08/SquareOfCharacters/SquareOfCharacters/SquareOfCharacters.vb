' Fig. 5.8: SquareOfCharacters.vb
' Nested repetition statements used to display a square of characters.
Public Class SquareOfCharacters
   ' display a square of characters
   Private Sub displaySquareButton_Click(sender As System.Object,
      e As System.EventArgs) Handles displaySquareButton.Click

      outputTextBox.Clear() ' clears the output

      ' get the fill character and side length
      Dim fillCharacter As String = fillCharacterTextBox.Text
      Dim sideLength As Integer = sideLengthNumericUpDown.Value

      ' this For...Next controls the row being displayed
      For row As Integer = 1 To sideLength
         ' this For...Next controls the column being displayed;
         ' this loop is nested in the For...Next at lines 15-24
         For column As Integer = 1 To sideLength
            ' display fill character and a space
            outputTextBox.AppendText(fillCharacter & " ")
         Next column

         outputTextBox.AppendText(vbCrLf) ' move to next line
      Next row
   End Sub ' displaySquareButton_Click

   ' clear outputTextBox when the fill character is changed by the user
   Private Sub fillCharacterTextBox_TextChanged(
      sender As System.Object, e As System.EventArgs) _
      Handles fillCharacterTextBox.TextChanged
      outputTextBox.Clear() ' clears the output
   End Sub ' fillCharacterTextBox_TextChanged

   ' clear outputTextBox when the side length is changed by the user
   Private Sub sideLengthNumericUpDown_ValueChanged(
      sender As System.Object, e As System.EventArgs) _
      Handles sideLengthNumericUpDown.ValueChanged
      outputTextBox.Clear() ' clears the output
   End Sub ' sideLengthNumericUpDown_ValueChanged
End Class ' TextBox_TextChanged

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