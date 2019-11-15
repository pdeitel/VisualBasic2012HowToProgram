' Transaction.vb
' MustInherit base class Transaction represents an ATM transaction.
Public MustInherit Class Transaction
   Private accountNumberValue As Integer ' indicates account involved
   Private screenHandle As Screen ' ATM's screen
   Private bankDatabaseHandle As BankDatabase ' account info database

   ' constructor invoked by derived classes using MyBase.New
   Public Sub New(userAccount As Integer,
      userScreen As Screen, database As BankDatabase)
        accountNumberValue = userAccount
        screenHandle = userScreen
        bankDatabaseHandle = database
    End Sub ' New

    ' property AccountNumber
    Public ReadOnly Property AccountNumber() As Integer
        Get
            Return accountNumberValue
        End Get
    End Property ' AccountNumber

    ' property ScreenReference
    Public ReadOnly Property ScreenReference() As Screen
        Get
            Return screenHandle
        End Get
    End Property ' ScreenReference

    ' property BankDatabaseReference
    Public ReadOnly Property BankDatabaseReference() As BankDatabase
        Get
            Return bankDatabaseHandle
        End Get
    End Property ' BankDatabaseReference

    ' perform the transaction (overridden by each derived class)
    Public MustOverride Sub Execute()
End Class ' Transaction


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
