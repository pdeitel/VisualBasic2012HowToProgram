' ATM.vb
' Represents an automated teller machine.
Public Class ATM
   Private userAuthenticated As Boolean ' whether user is authenticated
   Private currentAccountNumber As Integer ' user's account number
   Private screenHandle As Screen ' ATM's screen
   Private keypadHandle As Keypad ' ATM's keypad
   Private cashDispenserHandle As CashDispenser ' ATM's cash dispenser
   Private depositSlotHandle As DepositSlot ' ATM's deposit slot
   Private bankDatabaseHandle As BankDatabase ' account database

   ' enumeration constants represent main menu options
   Private Enum MenuOption
      BALANCE_INQUIRY = 1
      WITHDRAWAL
      DEPOSIT
      EXIT_ATM
   End Enum ' MenuOption

   ' parameterless constructor initializes instance variables
   Public Sub New()
      userAuthenticated = False ' user is not authenticated to start
      currentAccountNumber = 0 ' no current account number to start
      screenHandle = New Screen() ' create screen
      keypadHandle = New Keypad() ' create keypad
      cashDispenserHandle = New CashDispenser() ' create cash dispenser
      depositSlotHandle = New DepositSlot() ' create deposit slot
      bankDatabaseHandle = New BankDatabase() ' create database
   End Sub ' New

   ' start ATM
   Public Sub Run()
      ' welcome and authenticate users; perform transactions
      While (True) ' infinite loop
         ' loop while user is not yet authenticated
         While (Not userAuthenticated)
            screenHandle.DisplayMessageLine(vbCrLf & "Welcome!")
            AuthenticateUser() ' authenticate user
         End While

         PerformTransactions() ' for authenticated user
         userAuthenticated = False ' reset before next ATM session
         currentAccountNumber = 0 ' reset before next ATM session
         screenHandle.DisplayMessageLine(vbCrLf & "Thank you! Goodbye!")
      End While
   End Sub ' Run

   ' attempt to authenticate user against database
   Private Sub AuthenticateUser()
      screenHandle.DisplayMessage(vbCrLf & _
         "Please enter your account number: ")
      Dim accountNumber As Integer = keypadHandle.GetInput()
      screenHandle.DisplayMessage(vbCrLf & "Enter your PIN: ") ' prompt
      Dim pin As Integer = keypadHandle.GetInput() ' get PIN

      ' set userAuthenticated to Boolean value returned by database
      userAuthenticated = _
         bankDatabaseHandle.AuthenticateUser(accountNumber, pin)

      ' check whether authentication succeeded
      If userAuthenticated Then
         currentAccountNumber = accountNumber ' save user's account #
      Else
         screenHandle.DisplayMessageLine( _
            "Invalid account number or PIN. Please try again.")
      End If
   End Sub ' AuthenticateUser

   ' display the main menu and perform transactions
   Private Sub PerformTransactions()
      Dim currentTransaction As Transaction ' transaction being processed
      Dim userExited As Boolean = False ' user has not chosen to exit

      ' loop while user has not chosen exit option 
      While (Not userExited)
         ' show main menu and get user selection
         Dim mainMenuSelection As Integer = DisplayMainMenu()

         ' decide how to proceed based on user's menu selection
         Select Case (mainMenuSelection)
            ' user chooses to perform one of three transaction types
            Case MenuOption.BALANCE_INQUIRY, MenuOption.WITHDRAWAL, _
               MenuOption.DEPOSIT
               ' initialize as new object of chosen type
               currentTransaction = CreateTransaction(mainMenuSelection)
               currentTransaction.Execute() ' execute transaction
            Case MenuOption.EXIT_ATM ' user chose to terminate session
               screenHandle.DisplayMessageLine( _
                  vbCrLf & "Exiting the system...")
               userExited = True ' this ATM session should end
            Case Else ' user did not enter an integer from 1-4
               screenHandle.DisplayMessageLine(vbCrLf & _
                  "You did not enter a valid selection. Try again.")
         End Select
      End While
   End Sub ' PerformTransactions

   ' display the main menu and return an input selection
   Private Function DisplayMainMenu() As Integer
      screenHandle.DisplayMessageLine(vbCrLf & "Main menu:")
      screenHandle.DisplayMessageLine("1 - View my balance")
      screenHandle.DisplayMessageLine("2 - Withdraw cash")
      screenHandle.DisplayMessageLine("3 - Deposit funds")
      screenHandle.DisplayMessageLine("4 - Exit" & vbCrLf)
      screenHandle.DisplayMessage("Enter a choice: ")
      Return keypadHandle.GetInput() ' return user's selection
   End Function ' DisplayMainMenu

   ' return object of specified Transaction derived class
   Private Function CreateTransaction(type As Integer) _
      As Transaction
      Dim temp As Transaction = Nothing ' temporary Transaction object

      ' determine which type of Transaction to create
      Select Case (type)
         ' create new BalanceInquiry transaction
         Case MenuOption.BALANCE_INQUIRY
            temp = New BalanceInquiry( _
               currentAccountNumber, screenHandle, bankDatabaseHandle)
         Case MenuOption.WITHDRAWAL ' create new Withdrawal transaction
            temp = New Withdrawal(currentAccountNumber, screenHandle, _
               bankDatabaseHandle, keypadHandle, cashDispenserHandle)
         Case MenuOption.DEPOSIT ' create new Deposit transaction
            temp = New Deposit(currentAccountNumber, screenHandle, _
               bankDatabaseHandle, keypadHandle, depositSlotHandle)
      End Select

      Return temp
   End Function ' CreateTransaction
End Class ' ATM

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
