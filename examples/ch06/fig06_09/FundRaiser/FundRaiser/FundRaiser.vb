' Fig. 6.9: FundRaiser.vb
' Calculate total donations after operating expenses.
Public Class FundRaiser
   ' stores total of all donations after expenses
   Dim totalRaised As Decimal = 0

   ' calculate and display donation amount and total donations
   Private Sub donateButton_Click( sender As Object,
       e As EventArgs) Handles donateButton.Click

      ' get donation amount
      Dim donation As Decimal =
         Convert.ToDecimal(Val(donationTextBox.Text))

      ' obtain donation amount after operating costs deduction
      Dim afterCosts As Decimal = CalculateDonation(donation)

      ' display amount of donation after costs
      donationAfterExpensesLabel.Text = String.Format("{0:C}", afterCosts)

      ' update total amount of donations received
      totalRaised += afterCosts

      ' display total amount collected for charity
      totalDonationsLabel.Text = String.Format("{0:C}", totalRaised)
   End Sub ' donateButton_Click

   ' calculates donation amount after operating expenses
   Function CalculateDonation( donatedAmount As Decimal) As Decimal
      ' 17% of donation is used to cover operating costs
      Const COSTS As Decimal = 0.17D

      ' calculate amount of donation after operating expenses
      Return donatedAmount * (1D - COSTS)
   End Function ' CalculateDonation

   ' clear donationAfterExpensesLabel when user enters new donation amount
   Private Sub donationTextBox_TextChanged( sender As Object,
       e As EventArgs) Handles donationTextBox.TextChanged
      donationAfterExpensesLabel.Text = String.Empty
   End Sub ' donationTextBox_TextChanged
End Class ' FundRaiser


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