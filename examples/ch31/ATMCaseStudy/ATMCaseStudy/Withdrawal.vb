' Withdrawal.vb
' Class Withdrawal represents an ATM withdrawal transaction.
Public Class Withdrawal
   Inherits Transaction

   Private amount As Decimal ' amount to withdraw
   Private keypadHandle As Keypad ' reference to Keypad
   Private dispenserHandle As CashDispenser ' reference to cash dispenser

   ' constant that corresponds to menu option to cancel
   Private Const CANCELED As Integer = 6

   ' Withdrawal constructor
   Public Sub New(userAccountNumber As Integer,
      atmScreen As Screen, atmBankDatabase As BankDatabase,
      atmKeypad As Keypad, atmCashDispenser As CashDispenser)
        ' initialize base class variables
        MyBase.New(userAccountNumber, atmScreen, atmBankDatabase)

        ' initialize references to keypad and cash dispenser
        keypadHandle = atmKeypad
        dispenserHandle = atmCashDispenser
    End Sub ' New

    ' perform transaction
    Public Overrides Sub Execute()
        Dim cashDispensed As Boolean = False ' cash was not dispensed yet

        ' transaction was not canceled yet
        Dim transactionCanceled As Boolean = False

        ' loop until cash is dispensed or the user cancels
        Do
            ' obtain the chosen withdrawal amount from the user
            Dim selection As Integer = DisplayMenuOfAmounts()

            ' check whether user chose a withdrawal amount or canceled
            If (selection <> CANCELED) Then
                amount = selection ' set amount to the selected dollar amount

                ' get available balance of account involved
            Dim availableBalance As Decimal =
                BankDatabaseReference.GetAvailableBalance(AccountNumber)

                ' check whether the user has enough money in the account
                If (amount <= availableBalance) Then
                    ' check whether the cash dispenser has enough money
                    If (dispenserHandle.IsSufficientCashAvailable(amount)) Then
                        ' update the account involved to reflect withdrawal
                        BankDatabaseReference.Debit(AccountNumber, amount)

                        dispenserHandle.DispenseCash(amount) ' dispense cash
                        cashDispensed = True ' cash was dispensed

                        ' instruct user to take cash
                  ScreenReference.DisplayMessageLine(vbCrLf &
                     "Please take your cash from the cash dispenser.")
                    Else ' cash dispenser does not have enough cash
                  ScreenReference.DisplayMessageLine(vbCrLf &
                     "Insufficient cash available in the ATM." &
                     vbCrLf & vbCrLf & "Please choose a smaller amount.")
                    End If
                Else ' not enough money available in user's account
               ScreenReference.DisplayMessageLine(vbCrLf &
                  "Insufficient cash available in your account." &
                  vbCrLf & vbCrLf & "Please choose a smaller amount.")
                End If
            Else
            ScreenReference.DisplayMessageLine(
               vbCrLf & "Canceling transaction...")
                transactionCanceled = True ' user canceled the transaction
            End If
        Loop While ((Not cashDispensed) And (Not transactionCanceled))
    End Sub ' Execute

    ' display a menu of withdrawal amounts and the option to cancel;
    ' return the chosen amount or 0 if the user chooses to cancel
    Private Function DisplayMenuOfAmounts() As Integer
        Dim userChoice As Integer = 0 ' variable to store return value

        ' array of amounts to correspond to menu numbers
      Dim amounts As Integer() = New Integer() {
         0, 20, 40, 60, 100, 200}

        ' loop while no valid choice has been made
        While (userChoice = 0)
            ' display the menu
         ScreenReference.DisplayMessageLine(
            vbCrLf & "Withdrawal options:")
            ScreenReference.DisplayMessageLine("1 - $20")
            ScreenReference.DisplayMessageLine("2 - $40")
            ScreenReference.DisplayMessageLine("3 - $60")
            ScreenReference.DisplayMessageLine("4 - $100")
            ScreenReference.DisplayMessageLine("5 - $200")
            ScreenReference.DisplayMessageLine("6 - Cancel transaction")
         ScreenReference.DisplayMessage(
            vbCrLf & "Choose a withdrawal option (1-6): ")

            ' get user input through keypad
            Dim input As Integer = keypadHandle.GetInput()

            ' determine how to proceed based on the input value
            Select Case (input)
                ' if the user chose a withdrawal amount (i.e., option
                ' 1, 2, 3, 4, or 5), return the corresponding amount 
                ' from the amounts array
                Case 1 To 5
                    userChoice = amounts(input) ' save user's choice
                Case CANCELED ' the user chose to cancel
                    userChoice = CANCELED ' save user's choice
                Case Else
               ScreenReference.DisplayMessageLine(
                  vbCrLf & "Invalid selection. Try again.")
            End Select
        End While

        Return userChoice
    End Function ' DisplayMenuOfAmounts
End Class ' Withdrawal

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
