' Fig 6.19: Power.vb
' Optional argument demonstration with method Power.
Public Class Power
   ' reads input and displays result
   Private Sub calculatePowerButton_Click( sender As Object,
       e As EventArgs) Handles calculatePowerButton.Click

      Dim value As Integer ' stores the result

      ' call version of Power depending on power input
      If exponentTextBox.Text <> String.Empty Then
         value = Power(Convert.ToInt32(baseTextBox.Text),
            Convert.ToInt32(exponentTextBox.Text))
      Else
         value = Power(Convert.ToInt32(baseTextBox.Text))
         exponentTextBox.Text = Convert.ToString(2)
      End If

      outputLabel.Text = Convert.ToString(value)
   End Sub ' calculatePowerButton_Click

   ' use iteration to calculate power
   Function Power( base As Integer,
      Optional  exponent As Integer = 2) As Integer

      Dim result As Integer = 1 ' initialize total 

      For i = 1 To exponent ' calculate power
         result *= base
      Next

      Return result ' return result 
   End Function ' Power

   ' clear outputLabel when user changes the base value
   Private Sub baseTextBox_TextChanged( sender As Object,
       e As EventArgs) Handles baseTextBox.TextChanged
      outputLabel.Text = String.Empty
   End Sub ' baseTextBox_TextChanged

   ' clear outputLabel when user changes the exponent value
   Private Sub exponentTextBox_TextChanged( sender As Object,
       e As EventArgs) Handles exponentTextBox.TextChanged
      outputLabel.Text = String.Empty
   End Sub ' exponentTextBox_TextChanged
End Class ' Power

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