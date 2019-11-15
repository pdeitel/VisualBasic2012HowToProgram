' BalanceInquiry.vb
' Represents a balance inquiry ATM transaction
Public Class BalanceInquiry
   Inherits Transaction

   ' BalanceInquiry constructor initializes base class variables
   Public Sub New(userAccountNumber As Integer,
      atmScreen As Screen, atmBankDatabase As BankDatabase)
        MyBase.New(userAccountNumber, atmScreen, atmBankDatabase)
    End Sub ' New

    ' performs transaction; overrides Transaction's MustOverride method
    Public Overrides Sub Execute()
        ' get the available balance for the current user's Account
      Dim availableBalance As Decimal =
        BankDatabaseReference.GetAvailableBalance(AccountNumber)

        ' get the total balance for the current user's Account
      Dim totalBalance As Decimal =
        BankDatabaseReference.GetTotalBalance(AccountNumber)

        ' display the balance information on the screen
        ScreenReference.DisplayMessageLine(vbCrLf & "Balance Information:")
        ScreenReference.DisplayMessage(" - Available balance: ")
        ScreenReference.DisplayDollarAmount(availableBalance)
        ScreenReference.DisplayMessage(vbCrLf & " - Total balance: ")
        ScreenReference.DisplayDollarAmount(totalBalance)
        ScreenReference.DisplayMessageLine("")
    End Sub ' Execute
End Class ' BalanceInquiry

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
