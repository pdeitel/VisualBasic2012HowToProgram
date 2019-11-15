' Fig. 18.12: CreditInquiry.vb
' Read a file sequentially and display contents based on
' account type specified by user (credit, debit or zero balances).
Imports System.IO
Imports BankLibrary

Public Class CreditInquiry
   ' name of file that stores credit, debit and zero balances
   Private fileName As String

   ' invoked when user clicks Open File button
   Private Sub openButton_Click(sender As Object,
      e As EventArgs) Handles openButton.Click

      Dim result As DialogResult ' stores result of Open dialog

      ' create dialog box enabling user to open file
      Using fileChooser As New OpenFileDialog()
         result = fileChooser.ShowDialog()
         fileName = fileChooser.FileName ' get name from user
      End Using

      ' if user did not click Cancel
      If result <> Windows.Forms.DialogResult.Cancel Then
         ' enable all GUI buttons, except for Open File button
         openButton.Enabled = False
         creditButton.Enabled = True
         debitButton.Enabled = True
         zeroButton.Enabled = True
      End If
   End Sub ' openButton_Click

   ' invoked when user clicks credit balances,
   ' debit balances or zero balances button
   Private Sub getBalances_Click(
      sender As Object, e As EventArgs) _
      Handles creditButton.Click, zeroButton.Click, debitButton.Click

      ' delegate variable used to check a balance against
      ' a certain condition
      Dim balanceChooser As Func(Of Decimal, Boolean)

      ' convert sender explicitly to object of type button
      Dim senderButton As Button = CType(sender, Button)

      ' determine the condition the account balances must satisfy
      Select Case senderButton.Text
         Case "Credit Balances" ' positive balances
            balanceChooser =
               Function(balance As Decimal) balance > 0D
         Case "Debit Balances" ' negative balances
            balanceChooser =
               Function(balance As Decimal) balance < 0D
         Case Else ' zero balances
            balanceChooser =
               Function(balance As Decimal) balance = 0D
      End Select

      ' read and display file information
      Try
         displayRichTextBox.Text = "The accounts are:" & vbCrLf

         ' select records that match account type
         Dim balanceQuery =
            From line In File.ReadAllLines(fileName)
            Let creditInfo As String() = line.Split(","c)
            Where (balanceChooser(Convert.ToDecimal(creditInfo(3))))
            Select New Record With
            {
               .Account = Convert.ToInt32(creditInfo(0)),
               .FirstName = creditInfo(1),
               .LastName = creditInfo(2),
               .Balance = Convert.ToDecimal(creditInfo(3))
            } ' end LINQ query that selects Record objects

         Dim output As String = String.Empty ' hold output String

         ' display each selected Record
         For Each creditRecord In balanceQuery
            output &=
               creditRecord.Account & vbTab &
               creditRecord.FirstName & vbTab &
               creditRecord.LastName & vbTab

            output &=
               String.Format("{0:C}", creditRecord.Balance) & vbCrLf
         Next

         displayRichTextBox.AppendText(output) ' copy output to screen

         ' handle exception when file cannot be read
      Catch ex As IOException
         MessageBox.Show("Cannot Read File", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub ' getBalances_Click

   ' invoked when user clicks Done button
   Private Sub doneButton_Click(sender As Object,
      e As EventArgs) Handles doneButton.Click

      Application.Exit()
   End Sub ' doneButton_Click
End Class ' CreditInquiry

'**************************************************************************
'* (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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