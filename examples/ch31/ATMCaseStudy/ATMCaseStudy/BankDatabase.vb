' BankDatabase.vb
' Represents the bank account information database
Public Class BankDatabase
   Private accounts As Account() ' array of the bank's Accounts

   ' parameterless BankDatabase constructor initializes accounts
   Public Sub New()
      ' create two Account objects for testing and 
      ' place them in the accounts array
      accounts = New Account(0 To 1) {} ' create accounts array 
      accounts(0) = New Account(12345, 54321, 1000, 1200)
      accounts(1) = New Account(98765, 56789, 200, 200)
   End Sub ' New

   ' retrieve Account object containing specified account number
   Private Function GetAccount(accountNumber As Integer) As Account
      ' loop through accounts searching for matching account number
      For Each currentAccount As Account In accounts
         If currentAccount.AccountNumber = accountNumber Then
            Return currentAccount
         End If
      Next

      Return Nothing
   End Function ' GetAccount

   ' determine whether user-specified account number and PIN match 
   ' those of an account in the database
   Public Function AuthenticateUser(userAccountNumber As Integer,
      userPIN As Integer) As Boolean
        ' attempt to retrieve the account with the account number
        Dim userAccount As Account = GetAccount(userAccountNumber)

        ' if account exists, return result of Account function ValidatePIN
        If (userAccount IsNot Nothing) Then
            Return userAccount.ValidatePIN(userPIN)
        Else
            Return False ' account number not found, so return false
        End If
    End Function ' AuthenticateUser

    ' return available balance of Account with specified account number
   Public Function GetAvailableBalance(
      userAccountNumber As Integer) As Decimal
        Dim userAccount As Account = GetAccount(userAccountNumber)
        Return userAccount.AvailableBalance
    End Function ' GetAvailableBalance

    ' return total balance of Account with specified account number
   Public Function GetTotalBalance(
      userAccountNumber As Integer) As Decimal
        Dim userAccount As Account = GetAccount(userAccountNumber)
        Return userAccount.TotalBalance
    End Function ' GetTotalBalance

    ' credit an amount to Account with specified account number
   Public Sub Credit(userAccountNumber As Integer,
      amount As Decimal)
        Dim userAccount As Account = GetAccount(userAccountNumber)
        userAccount.Credit(amount)
    End Sub ' Credit

    ' debit an amount from Account with specified account number
   Public Sub Debit(userAccountNumber As Integer,
      amount As Decimal)
        Dim userAccount As Account = GetAccount(userAccountNumber)
        userAccount.Debit(amount)
    End Sub ' Debit
End Class ' BankDatabase


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
