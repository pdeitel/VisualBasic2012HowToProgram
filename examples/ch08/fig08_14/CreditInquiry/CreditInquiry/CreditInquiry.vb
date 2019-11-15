' Fig. 8.14: CreditInquiry.vb
' Read a file sequentially and display contents based on
' account type specified by user (credit, debit or zero balances).
Imports System.IO ' using classes from this namespace

Public Class CreditInquiry
   Dim fileName As String ' name of file containing account data

   Enum AccountType ' constants representing account types
      CREDIT
      DEBIT
      ZERO
   End Enum ' AccountTypes

   ' opens a file in which accounts are stored
   Private Sub OpenToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles OpenToolStripMenuItem.Click

      Dim result As DialogResult ' stores result of Open dialog

      ' create dialog box enabling user to open file
      Using fileChooser As New OpenFileDialog()
         result = fileChooser.ShowDialog()
         fileName = fileChooser.FileName ' get specified file name
      End Using ' automatic call to fileChooser.Dispose() occurs here

      ' if user did not click Cancel, enable Buttons
      If result <> Windows.Forms.DialogResult.Cancel Then
         creditBalancesButton.Enabled = True
         debitBalancesButton.Enabled = True
         zeroBalancesButton.Enabled = True
      End If
   End Sub ' OpenToolStripMenuItem_Click

   ' exit the application
   Private Sub ExitToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles ExitToolStripMenuItem.Click

      Application.Exit() ' terminate the application
   End Sub ' ExitToolStripMenuItem_Click

   ' display accounts with credit balances
   Private Sub creditBalancesButton_Click(sender As Object,
      e As EventArgs) Handles creditBalancesButton.Click

      DisplayAccounts(AccountType.CREDIT) ' displays credit balances
   End Sub ' creditBalancesButton_Click

   ' display accounts with debit balances
   Private Sub debitBalancesButton_Click(sender As Object,
      e As EventArgs) Handles debitBalancesButton.Click

      DisplayAccounts(AccountType.DEBIT) ' displays debit balances
   End Sub ' debitBalancesButton_Click

   ' display accounts with zero balances
   Private Sub zeroBalancesButton_Click(sender As Object,
      e As EventArgs) Handles zeroBalancesButton.Click

      DisplayAccounts(AccountType.ZERO) ' displays credit balances
   End Sub ' zeroBalancesButton_Click

   ' display accounts of specified type
   Sub DisplayAccounts(accountType As AccountType)
      Dim fileReader As StreamReader = Nothing

      ' read and display file information
      Try
         accountsTextBox.Text = "The accounts are:" & vbCrLf

         ' open file for reading
         fileReader = New StreamReader(fileName)

         ' read file and display lines that match the balance type
         Do While Not fileReader.EndOfStream ' while not end of file
            Dim line As String = fileReader.ReadLine() ' read line
            Dim fields() As String = line.Split(","c) ' split into fields

            ' get data from fields array
            Dim accountNumber As Integer = Convert.ToInt32(fields(0))
            Dim firstName As String = fields(1)
            Dim lastName As String = fields(2)
            Dim balance As Decimal = Convert.ToDecimal(fields(3))

            If ShouldDisplay(balance, accountType) Then
               accountsTextBox.AppendText(accountNumber & vbTab &
                  firstName & vbTab & lastName & vbTab &
                  String.Format("{0:C}", balance) & vbCrLf)
            End If
         Loop
      Catch ex As IOException
         MessageBox.Show("Cannot Read File", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally ' ensure that file gets closed
         If fileReader IsNot Nothing Then
            Try
               fileReader.Close() ' close StreamReader
            Catch ex As IOException
               MessageBox.Show("Error closing file", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
         End If
      End Try
   End Sub ' DisplayAccounts

   ' determine whether to display given account based on the balance
   Function ShouldDisplay(balance As Double,
      type As AccountType) As Boolean

      If balance < 0 AndAlso type = AccountType.CREDIT Then
         Return True ' record should be displayed
      ElseIf balance > 0 AndAlso type = AccountType.DEBIT Then
         Return True ' record should be displayed
      ElseIf balance = 0 AndAlso type = AccountType.ZERO Then
         Return True ' record should be displayed
      End If

      Return False ' record should not be displayed
   End Function ' ShouldDisplay
End Class ' Credit Inquiry


'**************************************************************************
'* (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
'* Pearson Education, Inc. All Rights Reserved.                           *
'*                                                                        *
'* DISCLAIMER: The authors and publisher of this book have used their     *
'* best efforts in preparing the book. These efforts include the          *
'* development, research, and testing of the theories and programs        *
'* to determine their effectiveness. The authors and publisher make       *
'* no warranty of any kind, expressed or implied, with regard to these    *
'* programs or to the documentation contained in these books. The authors *
'* and publisher shall not be liable in any event for incidental or       *
'* consequential damages in connection with, or arising out of, the       *
'* furnishing, performance, or use of these programs.                     *
'**************************************************************************