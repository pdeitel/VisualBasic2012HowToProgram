' Deposit.vb
' Represents a deposit ATM transaction.
Public Class Deposit
   Inherits Transaction

   Private amount As Decimal ' amount to deposit
   Private keypadHandle As Keypad ' reference to Keypad
   Private depositSlotHandle As DepositSlot ' reference to deposit slot

   ' constant representing cancel option
   Private Const CANCELED As Integer = 0

   ' Deposit constructor initializes class's instance variables
   Public Sub New(userAccountNumber As Integer,
      atmScreen As Screen, atmBankDatabase As BankDatabase,
      atmKeypad As Keypad, atmDepositSlot As DepositSlot)
        ' initialize base class variables
        MyBase.New(userAccountNumber, atmScreen, atmBankDatabase)

        ' initialize references to keypad and deposit slot
        keypadHandle = atmKeypad
        depositSlotHandle = atmDepositSlot
    End Sub ' New

    ' perform transaction; overrides Transaction's MustOverride method
    Public Overrides Sub Execute()
        amount = PromptForDepositAmount() ' get deposit amount from user

        ' check whether user entered a deposit amount or canceled
        If (amount <> CANCELED) Then
            ' request deposit envelope containing specified amount
         ScreenReference.DisplayMessage(vbCrLf &
            "Please insert a deposit envelope containing ")
            ScreenReference.DisplayDollarAmount(amount)
            ScreenReference.DisplayMessageLine(" in the deposit slot.")

            ' retrieve deposit envelope
         Dim envelopeReceived As Boolean =
            depositSlotHandle.IsDepositEnvelopeReceived()

            ' check whether deposit envelope was received
            If envelopeReceived Then
            ScreenReference.DisplayMessageLine(vbCrLf &
               "Your envelope has been received." & vbCrLf &
               "The money just deposited will not be available " &
               "until we" & vbCrLf & "verify the amount of any " &
               "enclosed cash, and any enclosed checks clear.")

                ' credit account to reflect the deposit
                BankDatabaseReference.Credit(AccountNumber, amount)
            Else
            ScreenReference.DisplayMessageLine(vbCrLf &
               "You did not insert an envelope, so the ATM has " &
               "canceled your transaction.")
            End If
        Else
         ScreenReference.DisplayMessageLine(
            vbCrLf & "Canceling transaction...")
        End If
    End Sub ' Execute

    ' prompt user to enter a deposit amount to credit
    Private Function PromptForDepositAmount() As Decimal
        ' display the prompt and receive input
      ScreenReference.DisplayMessage(vbCrLf &
         "Please input a deposit amount in CENTS (or 0 to cancel): ")
        Dim input As Integer = Convert.ToInt32(keypadHandle.GetInput())

        ' check whether the user canceled or entered a valid amount
        If (input = CANCELED) Then
            Return CANCELED
        Else
            Return Convert.ToDecimal(input / 100)
        End If
    End Function ' PromptForDepositAmount
End Class ' Deposit

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
