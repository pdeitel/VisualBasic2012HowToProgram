' Fig. 18.9: CreateFile.vb
' Creating and writing to a sequential-access file.
Imports System.IO
Imports BankLibrary ' imports classes from Figs. 18.7 and 18.8

Public Class CreateFile
   Private fileWriter As StreamWriter ' writes data to text file
   Private output As FileStream ' maintains connection to file

   ' event handler for Save Button
   Private Sub saveButton_Click(sender As Object,
      e As EventArgs) Handles saveButton.Click

      Dim result As DialogResult ' stores result of Save dialog
      Dim fileName As String ' name of file to save data

      ' display dialog so user can choose name of file to save
      Using fileChooser As New SaveFileDialog()
         result = fileChooser.ShowDialog()
         fileName = fileChooser.FileName ' get specified file name
      End Using ' automatic call to fileChooser.Dispose() occurs here

      ' if user did not click Cancel
      If result <> Windows.Forms.DialogResult.Cancel Then
         ' save file via FileStream if user specified file 
         Try
            ' open file with write access
            output = New FileStream(
               fileName, FileMode.OpenOrCreate, FileAccess.Write)

            ' sets file to where data is written
            fileWriter = New StreamWriter(output)

            ' disable Save button and enable Enter button
            saveButton.Enabled = False
            enterButton.Enabled = True
            ' handle exception if there is a problem opening the file
         Catch ex As IOException
            ' notify user if file does not exist
            MessageBox.Show("Error Opening File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If
   End Sub ' saveButton_Click

   ' event handler for Enter Button
   Private Sub enterButton_Click(sender As Object,
      e As EventArgs) Handles enterButton.Click
      ' store TextBox values string array
      Dim values As String() = GetTextBoxValues()

      ' Record containing TextBox values 
      Dim record As New Record()

      ' determine whether TextBox account field is empty
      If values(TextBoxIndices.ACCOUNT) <> String.Empty Then
         ' store TextBox values in Record and output Record
         Try
            ' get account number value from TextBox
            Dim accountNumber As Integer =
                Convert.ToInt32(values(TextBoxIndices.ACCOUNT))

            ' determine whether accountNumber is valid
            If accountNumber > 0 Then
               ' store TextBox fields in Record
               record.Account = accountNumber
               record.FirstName = values(TextBoxIndices.FIRST)
               record.LastName = values(TextBoxIndices.LAST)
               record.Balance =
                    Convert.ToDecimal(values(TextBoxIndices.BALANCE))

               ' write Record to file, fields separated by commas
               fileWriter.WriteLine(
                  record.Account & "," & record.FirstName & "," &
                  record.LastName & "," & record.Balance)
            Else
               ' notify user if invalid account number
               MessageBox.Show("Invalid Account Number", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ' notify user if error occurs
         Catch ex As IOException
            MessageBox.Show("Error Writing to File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         Catch ex As FormatException
            MessageBox.Show("Invalid Format", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If

      ClearTextBoxes() ' clear TextBox values
      accountTextBox.Select() ' give focus to accountTextBox
   End Sub ' enterButton_Click

   ' event handler for Exit Button
   Private Sub exitButton_Click(sender As Object,
      e As EventArgs) Handles exitButton.Click
      ' determine whether file exists
      If output IsNot Nothing Then
         Try
            fileWriter.Close() ' close StreamWriter
            ' notify user of error closing file
         Catch ex As IOException
            MessageBox.Show("Cannot close file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If

      Application.Exit()
   End Sub ' exitButton_Click
End Class ' CreateFile

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