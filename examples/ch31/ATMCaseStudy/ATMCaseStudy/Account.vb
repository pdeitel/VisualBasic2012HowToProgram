' Account.vb
' Represents a bank account.
Public Class Account
   Private accountNumberValue As Integer ' account number
   Private pin As Integer ' PIN for authentication
   Private availableBalanceValue As Decimal ' available withdrawal amount
   Private totalBalanceValue As Decimal ' funds available+pending deposit

   ' constructor initializes attributes
   Public Sub New(theAccountNumber As Integer, _
      thePIN As Integer, theAvailableBalance As Decimal, _
      theTotalBalance As Decimal)
      accountNumberValue = theAccountNumber
      pin = thePIN
      availableBalanceValue = theAvailableBalance
      totalBalanceValue = theTotalBalance
   End Sub ' New

   ' property AccountNumber
   Public ReadOnly Property AccountNumber() As Integer
      Get
         Return accountNumberValue
      End Get
   End Property ' AccountNumber

   ' property AvailableBalance
   Public ReadOnly Property AvailableBalance() As Decimal
      Get
         Return availableBalanceValue
      End Get
   End Property ' AvailableBalance

   ' property TotalBalance
   Public ReadOnly Property TotalBalance() As Decimal
      Get
         Return totalBalanceValue
      End Get
   End Property ' TotalBalance

   ' determines whether a user-specified PIN matches PIN in Account
   Public Function ValidatePIN(userPIN As Integer) As Boolean
      If userPIN = pin Then
         Return True
      Else
         Return False
      End If
   End Function ' ValidatePIN

   ' credits the account (funds have not yet cleared)
   Public Sub Credit(amount As Decimal)
      totalBalanceValue += amount ' add to total balance
   End Sub ' Credit

   ' debits the account
   Public Sub Debit(amount As Decimal)
      availableBalanceValue -= amount ' subtract from available balance
      totalBalanceValue -= amount ' subtract from total balance
   End Sub ' Debit
End Class ' Account


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
