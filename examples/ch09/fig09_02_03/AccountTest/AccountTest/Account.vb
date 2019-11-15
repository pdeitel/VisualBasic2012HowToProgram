' Fig. 9.2: Account.vb
' Account class for maintaining a bank account balance.
Public Class Account
   Private balanceValue As Decimal ' instance variable stores the balance

   ' constructor initializes balanceValue
   Public Sub New(Optional initialBalance As Decimal = 0D)
      ' if initialBalance is less than 0, throw an exception
      If initialBalance < 0D Then
         Throw New ArgumentOutOfRangeException(
            "Initial balance must be greater than or equal to 0.")
      End If

      balanceValue = initialBalance ' initialize balanceValue
   End Sub ' New

   ' deposit money to the account
   Public Sub Deposit(depositAmount As Decimal)
      ' if depositAmount is less than or equal to 0, throw an exception
      If depositAmount <= 0D Then
         Throw New ArgumentOutOfRangeException(
            "Deposit amount must be positive.")
      End If

      balanceValue += depositAmount ' add depositAmount to balanceValue
   End Sub ' Deposit

   ' withdraw money from the account
   Public Sub Withdraw(withdrawalAmount As Decimal)
      ' if withdrawalAmount is greater than Balance, throw an exception
      If withdrawalAmount > Balance Then ' invokes lines 45-47
         Throw New ArgumentOutOfRangeException(
            "Withdrawal amount must be less than or equal to balance.")
      ElseIf withdrawalAmount <= 0D Then
         Throw New ArgumentOutOfRangeException(
            "Withrawal amount must be positive.")
      End If

      ' subtract withdrawalAmount from balanceValue
      balanceValue -= withdrawalAmount
   End Sub ' Withdraw

   ' return the current balance
   Public ReadOnly Property Balance As Decimal
      Get
         Return balanceValue
      End Get
   End Property ' Balance
End Class ' Account

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