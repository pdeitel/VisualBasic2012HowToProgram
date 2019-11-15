﻿' Exercise 5.16: SavingsCalculator.vb
Public Class SavingsCalculator
   ' calculate amount in account after one year
   Private Sub calculateButton_Click(sender As Object, _
      e As EventArgs) Handles calculateButton.Click

      ' get amount on deposit
      Dim total As Integer = Val(startingAmountTextBox.Text)

      ' add $100 a month for one year
      For counter As Integer = 0 To 12
         total += 100 ' add money
      Next

      ' display total after 12 months
      resultLabel.Text = String.Format("{0:C}", total)
   End Sub ' calculateButton_Click
End Class ' SavingsCalculator

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