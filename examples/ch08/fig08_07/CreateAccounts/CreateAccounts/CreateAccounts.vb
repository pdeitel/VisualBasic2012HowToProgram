' Fig. 8.7: CreateAccounts.vb
' Program that creates a text file of account information.
Imports System.IO ' using classes from this namespace

Public Class CreateAccounts
   Dim fileWriter As StreamWriter ' writes data to text file

   ' create a new file in which accounts can be stored
   Private Sub NewToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles NewToolStripMenuItem.Click

      CloseFile() ' ensure that any prior file is closed
      Dim result As DialogResult ' stores result of Save dialog
      Dim fileName As String ' name of file to save data

      ' display dialog so user can choose the name of the file to save
      Using fileChooser As New SaveFileDialog()
         result = fileChooser.ShowDialog()
         fileName = fileChooser.FileName ' get specified file name
      End Using ' automatic call to fileChooser.Dispose() occurs here

      ' if user did not click Cancel
      If result <> Windows.Forms.DialogResult.Cancel Then
         Try
            ' open or create file for writing
            fileWriter = New StreamWriter(fileName, True)

            ' enable controls
            CloseToolStripMenuItem.Enabled = True
            addAccountButton.Enabled = True
            accountNumberTextBox.Enabled = True
            firstNameTextBox.Enabled = True
            lastNameTextBox.Enabled = True
            balanceTextBox.Enabled = True
         Catch ex As IOException
            MessageBox.Show("Error Opening File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If
   End Sub ' NewToolStripMenuItem_Click

   ' add an account to the file
   Private Sub addAccountButton_Click(sender As Object,
      e As EventArgs) Handles addAccountButton.Click

      ' determine whether TextBox account field is empty
      If accountNumberTextBox.Text <> String.Empty Then
         ' try to store record to file
         Try
            ' get account number
            Dim accountNumber As Integer =
               Convert.ToInt32(accountNumberTextBox.Text)

            If accountNumber > 0 Then ' valid account number?
               ' write record data to file separating fields by commas
               fileWriter.WriteLine(accountNumber & "," &
                  firstNameTextBox.Text & "," &
                  lastNameTextBox.Text & "," &
                  Convert.ToDecimal(balanceTextBox.Text))
            Else
               MessageBox.Show("Invalid Account Number", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
         Catch ex As IOException
            MessageBox.Show("Error Writing to File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         Catch ex As FormatException
            MessageBox.Show("Invalid account number or balance",
               "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If

      accountNumberTextBox.Clear()
      firstNameTextBox.Clear()
      lastNameTextBox.Clear()
      balanceTextBox.Clear()
      accountNumberTextBox.Focus()
   End Sub ' addAccountButton_Click

   ' close the currently open file and disable controls
   Private Sub CloseToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles CloseToolStripMenuItem.Click

      CloseFile() ' close currently open file
      CloseToolStripMenuItem.Enabled = False
      addAccountButton.Enabled = False
      accountNumberTextBox.Enabled = False
      firstNameTextBox.Enabled = False
      lastNameTextBox.Enabled = False
      balanceTextBox.Enabled = False
   End Sub ' CloseToolStripMenuItem_Click

   ' exit the application
   Private Sub ExitToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles ExitToolStripMenuItem.Click

      CloseFile() ' close the file before terminating application
      Application.Exit() ' terminate the application
   End Sub ' ExitToolStripMenuItem_Click

   ' close the file
   Sub CloseFile()
      If fileWriter IsNot Nothing Then
         Try
            fileWriter.Close() ' close StreamWriter
         Catch ex As IOException
            MessageBox.Show("Error closing file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If
   End Sub ' CloseFile
End Class ' CreateAccounts

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