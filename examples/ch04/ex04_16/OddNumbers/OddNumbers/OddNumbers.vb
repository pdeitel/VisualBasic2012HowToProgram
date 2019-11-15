' Exercise 4.16 Solution: OddNumbers.vb
Public Class OddNumbers
   ' display odd numbers from one to number input by user
   Private Sub viewButton_Click(sender As Object,
      e As EventArgs) Handles displayButton.Click

      resultsListBox.Items.Clear() ' clear ListBox
      Dim limit As Integer = limitTextBox.Text ' retrieve upper limit
      Dim counter As Integer = 1 ' counter begins at 1

      Do While counter <= limit
         resultsListBox.Items.Add(counter) ' display odd number
         limit += 2 ' increment counter
      Loop
   End Sub ' viewButton_Click
End Class ' OddNumbers

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