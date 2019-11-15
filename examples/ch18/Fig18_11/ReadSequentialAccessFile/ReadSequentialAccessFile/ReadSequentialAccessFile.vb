' Fig. 18.11: ReadSequentialAccessFileForm.vb
' Reading a sequential-access file.
Imports System.IO
Imports BankLibrary ' imports classes from Figs. 18.7 and 18.8

Public Class ReadSequentialAccessFileForm
   Private input As FileStream ' maintains connection to a file
   Private fileReader As StreamReader ' reads data from a text file

   ' invoked when user clicks the Open button
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
      If result <> DialogResult.Cancel Then
         ClearTextBoxes()

         ' create FileStream to obtain read access to file
         input = New FileStream(fileName, FileMode.Open, FileAccess.Read)

         ' set file from where data is read
         fileReader = New StreamReader(input)

         openButton.Enabled = False ' disable Open File button
         nextButton.Enabled = True ' enable Next Record button
      End If
   End Sub ' openButton_Click

   ' invoked when user clicks Next button
   Private Sub nextButton_Click(sender As Object,
      e As EventArgs) Handles nextButton.Click

      Try
         ' get next record available in file
         Dim inputRecord As String = fileReader.ReadLine()

         If inputRecord IsNot Nothing Then
            ' store individual pieces of data
            Dim inputFields() As String = inputRecord.Split(","c)

            Dim record As New Record(Convert.ToInt32(
               inputFields(0)), inputFields(1), inputFields(2),
               Convert.ToDecimal(inputFields(3)))

            ' copy string array values to TextBox values
            SetTextBoxValues(inputFields)
         Else
            fileReader.Close() ' close StreamReader
            openButton.Enabled = True ' enable Open File button
            nextButton.Enabled = False ' disable Next Record button
            ClearTextBoxes()

            ' notify user if no Records in file
            MessageBox.Show("No more records in file", String.Empty,
               MessageBoxButtons.OK, MessageBoxIcon.Information)
         End If
      Catch ex As IOException
         MessageBox.Show("Error Reading from File", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
      Catch ex As FormatException
         MessageBox.Show("Invalid Format", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub ' nextButton_Click
End Class ' ReadSequentialAccessFileForm

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