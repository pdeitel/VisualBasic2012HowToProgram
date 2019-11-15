' Fig 18.14: CreateFile.vb
' Creating a sequential-access file using serialization.
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports BankLibrary

Public Class CreateFile
   ' object for serializing Records in binary format
   Private formatter As New BinaryFormatter()
   Private output As FileStream ' stream for writing to a file

   ' handler for saveButton_Click
   Private Sub saveButton_Click(sender As Object,
      e As EventArgs) Handles saveButton.Click

      Dim result As DialogResult ' stores result of Save dialog
      Dim fileName As String ' name of file to save data

      ' create dialog box enabling user to save file
      Using fileChooser As New SaveFileDialog()
         result = fileChooser.ShowDialog()
         fileName = fileChooser.FileName ' get specified file name
      End Using

      ' if user did not click cancel
      If result <> Windows.Forms.DialogResult.Cancel Then
         ' save file via FileStream if user specified valid file
         Try
            ' open file with write access
            output = New FileStream(
               fileName, FileMode.OpenOrCreate, FileAccess.Write)

            ' disable Save button and enable Enter button
            saveButton.Enabled = False
            enterButton.Enabled = True
            ' handle exception if there is a problem opening the file
         Catch ex As IOException
            ' notify user if file does not exist
            MessageBox.Show("Error opening file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If
   End Sub ' saveButton_Click

   ' handler for enterButton_Click
   Private Sub enterButton_Click(sender As Object,
      e As EventArgs) Handles enterButton.Click
      ' store TextBox values string array
      Dim values As String() = GetTextBoxValues()

      ' Record containing TextBox values to serialize
      Dim record As New RecordSerializable()

      ' determine whether TextBox account field is empty
      If values(TextBoxIndices.ACCOUNT) <> String.Empty Then
         ' store TextBox values in Record and serialize Record
         Try
            ' get account number value from TextBox
            Dim accountNumber As Integer =
                Convert.ToInt32(values(TextBoxIndices.ACCOUNT))

            ' determine whether accountNumber is valid
            If accountNumber > 0 Then
               ' store TextBox fields in Record
               record.Account = accountNumber
               record.FirstName =
                    values(TextBoxIndices.FIRST)
               record.LastName =
                    values(TextBoxIndices.LAST)
               record.Balance =
                    Convert.ToDecimal(values(TextBoxIndices.BALANCE))

               ' write Record to FileStream ( serialize object )
               formatter.Serialize(output, record)
            Else
               ' notify user if invalid account number
               MessageBox.Show("Invalid Account Number", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ' notify user if error occurs in serialization
         Catch ex As SerializationException
            MessageBox.Show("Error Writing to File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' notify user if error occurs regarding parameter format
         Catch ex As FormatException
            MessageBox.Show("Invalid Format", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If

      ClearTextBoxes() ' clear TextBox values
   End Sub ' enterButton_Click

   ' handler for exitButton_Click
   Private Sub exitButton_Click(sender As Object,
      e As EventArgs) Handles exitButton.Click
      ' determine whether file exists
      If output IsNot Nothing Then
         ' close file
         Try
            output.Close()
            ' notify user of error closing file
         Catch ex As IOException
            MessageBox.Show("Cannot close file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      End If

      Application.Exit()
   End Sub ' enterButton_Click
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