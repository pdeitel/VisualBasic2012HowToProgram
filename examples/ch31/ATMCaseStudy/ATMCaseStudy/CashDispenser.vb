' CashDispenser.vb
' Represents the cash dispenser of the ATM
Public Class CashDispenser
   ' the default initial number of bills in the case dispenser
   Private Const INITIAL_COUNT As Integer = 500
   Private billCount As Integer ' number of $20 bills remaining

   ' parameterless constructor initializes billCount to INITIAL_COUNT
   Public Sub New()
      billCount = INITIAL_COUNT ' set billCount to INITIAL_COUNT
   End Sub ' New

   ' simulates dispensing of specified amount of cash
   Public Sub DispenseCash(amount As Decimal)
      ' number of $20 bills required
      Dim billsRequired As Integer = (Convert.ToInt32(amount) \ 20)
      billCount -= billsRequired
   End Sub ' DispenseCash

   ' indicates whether cash dispenser can dispense desired amount
   Public Function IsSufficientCashAvailable(amount As Decimal) _
      As Boolean
      ' number of $20 bills required
      Dim billsRequired As Integer = (Convert.ToInt32(amount) \ 20)

      If (billCount >= billsRequired) Then
         Return True ' enough bills available
      Else
         Return False ' not enough bills available
      End If
   End Function ' IsSufficientCashAvailable
End Class ' CashDispenser

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
