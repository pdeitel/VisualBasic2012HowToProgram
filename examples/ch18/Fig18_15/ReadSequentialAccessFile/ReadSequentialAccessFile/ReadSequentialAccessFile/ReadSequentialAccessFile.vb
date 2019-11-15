' Fig. 18.15: ReadSequentialAccessFile.vb
' Reading a sequential-access file using deserialization.
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports BankLibrary

Public Class ReadSequentialAccessFile
   ' object for deserializing record in binary format
   Private reader As New BinaryFormatter()
   Private input As FileStream ' stream for reading from a file

   ' invoked when user clicks Open button
   Private Sub openButton_Click(sender As Object,
      e As EventArgs) Handles openButton.Click

      Dim result As DialogResult ' stores result of Open dialog
      Dim fileName As String ' name of file to open 

      ' create dialog box enabling user to open file
      Using fileChooser As New OpenFileDialog()
         result = fileChooser.ShowDialog()
         fileName = fileChooser.FileName ' get specified file name
      End Using

      ' if user did not click Cancel
      If result <> Windows.Forms.DialogResult.Cancel Then
         ClearTextBoxes()

         ' create FileStream to obtain read access to file
         input = New FileStream(fileName, FileMode.Open, FileAccess.Read)

         openButton.Enabled = False ' disable Open File button
         nextButton.Enabled = True ' enable Next Record button
      End If
   End Sub ' openButton_Click

   ' invoked when user clicks Next button
   Private Sub nextButton_Click(sender As Object,
      e As EventArgs) Handles nextButton.Click
      ' deserialize record and store data in TextBoxes
      Try
         ' get next RecordSerializable available in file
         Dim record As RecordSerializable =
            CType(reader.Deserialize(input), RecordSerializable)

         ' store record values in temporary string array
         Dim values() As String = {
            record.Account.ToString(), record.FirstName.ToString(),
            record.LastName.ToString(), record.Balance.ToString()}

         ' copy string array values to TextBox values
         SetTextBoxValues(values)
         ' handle exception when there are no records in file
      Catch ex As SerializationException
         input.Close() ' close FileStream if no records in file
         openButton.Enabled = True ' enable Open File button
         nextButton.Enabled = False ' disable Next Record button

         ClearTextBoxes()

         ' notify user if no records in file
         MessageBox.Show("No more records in file", String.Empty,
            MessageBoxButtons.OK, MessageBoxIcon.Information)
      End Try
   End Sub ' nextButton_Click
End Class ' ReadSequentialAccessFile

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