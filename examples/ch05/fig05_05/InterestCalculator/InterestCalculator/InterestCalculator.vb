' Fig. 5.5: InterestCalculator.vb
' Compound interest calculation using For...Next.
Public Class InterestCalculator
   ' handles Calculate Button's Click event
   Private Sub calculateButton_Click(sender As Object,
      e As EventArgs) Handles calculateButton.Click

      ' store the principal and the interest rate
      Dim principal As Decimal = Val(principalTextBox.Text)
      Dim rate As Decimal = Val(interestRateTextBox.Text)

      ' display the output header
      resultsListBox.Items.Add(
         "Year" & vbTab & "Amount on Deposit")
      Dim amount As Decimal ' amount on deposit after each year

      ' calculate amount after each year and add to resultListBox
      For yearCounter As Integer = 1 To yearsNumericUpDown.Value
         amount = principal * ((1 + rate / 100) ^ yearCounter)
         resultsListBox.Items.Add(yearCounter & vbTab &
            String.Format("{0:C}", amount))
      Next
   End Sub ' calculateButton_Click

   ' clear resultListBox when principal changes
   Private Sub principalTextBox_TextChanged(sender As Object,
      e As EventArgs) Handles principalTextBox.TextChanged
      resultsListBox.Items.Clear() ' empty ListBox when inputs change
   End Sub ' principalTextBox_TextChanged

   ' clear resultListBox when interest rate changes
   Private Sub interestRateTextBox_TextChanged(
      sender As Object,
      e As EventArgs) Handles interestRateTextBox.TextChanged
      resultsListBox.Items.Clear() ' empty ListBox when inputs change
   End Sub ' interestRateTextBox_TextChanged

   ' clear resultListBox when number of years changes
   Private Sub yearsNumericUpDown_ValueChanged(sender As Object,
      e As EventArgs) Handles yearsNumericUpDown.ValueChanged
      resultsListBox.Items.Clear() ' empty ListBox when inputs change
   End Sub ' yearsNumericUpDown_ValueChanged
End Class ' InterestCalculator

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