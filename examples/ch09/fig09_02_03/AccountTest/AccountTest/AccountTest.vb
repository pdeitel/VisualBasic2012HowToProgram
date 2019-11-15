' Fig. 9.3: AccountTest.vb
' Create and manipulate an Account object.
Public Class AccountTest
   Private account As New Account() ' create an Account object

   ' display the initial account balance when program executes
   Private Sub AccountTest_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      accountBalanceValueLabel.Text =
         String.Format("{0:C}", account.Balance)
   End Sub ' AccountTest_Load

   ' process a deposit
   Private Sub depositButton_Click(sender As Object,
      e As EventArgs) Handles depositButton.Click

      Try
         ' get deposit amount
         Dim depositAmount As Decimal =
            Convert.ToDecimal(inputTextBox.Text)
         account.Deposit(depositAmount) ' make the deposit
         accountBalanceValueLabel.Text =
            String.Format("{0:C}", account.Balance)
      Catch ex As ArgumentOutOfRangeException
         MessageBox.Show("Deposit amount must be positive.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

      inputTextBox.Clear() ' clear the inputTextBox
      inputTextBox.Focus() ' allow user to type in the inputTextBox
   End Sub ' depositButton_Click

   ' process a withdrawal
   Private Sub withdrawButton_Click(sender As Object,
      e As EventArgs) Handles withdrawButton.Click

      Try
         ' get withdrawal amount
         Dim withdrawalAmount As Decimal =
            Convert.ToDecimal(inputTextBox.Text)
         account.Withdraw(withdrawalAmount) ' make the withdrawal
         accountBalanceValueLabel.Text =
            String.Format("{0:C}", account.Balance)
      Catch ex As ArgumentOutOfRangeException
         MessageBox.Show("Withdrawal amount must be greater than 0 " &
            "and less than or equal to the account balance.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

      inputTextBox.Clear() ' clear the inputTextBox
      inputTextBox.Focus() ' allow user to type in the inputTextBox
   End Sub ' withdrawButton_Click
End Class ' AccountTest

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