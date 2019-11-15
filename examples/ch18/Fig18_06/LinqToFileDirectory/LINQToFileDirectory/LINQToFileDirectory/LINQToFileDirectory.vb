' Fig 18.6: LINQToFileDirectory.vb
' Using LINQ to determine file types.
Imports System.IO

Public Class LINQToFileDirectory
   Private currentDirectory As String ' directory to search
   Private directoryList() As String ' subdirectories
   Private fileArray() As String ' file names

   ' store extensions found and number found
   Dim found As New Dictionary(Of String, Integer)

   ' handles the Search Directory Button's Click event
   Private Sub searchButton_Click(sender As Object,
      e As EventArgs) Handles searchButton.Click

      ' check if user specified path exists
      If pathTextBox.Text <> String.Empty AndAlso
         Not (Directory.Exists(pathTextBox.Text)) Then

         ' show error if user does not specify valid directory
         MessageBox.Show("Invalid Directory", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
      Else
         ' use current directory if no directory is specified
         If pathTextBox.Text = String.Empty Then
            currentDirectory = Directory.GetCurrentDirectory()
         Else
            currentDirectory = pathTextBox.Text ' use specified directory
         End If

         directoryTextBox.Text = currentDirectory ' display the directory

         ' clear text boxes
         pathTextBox.Clear()
         resultsTextBox.Clear()

         SearchDirectory(currentDirectory) ' search directory

         ' allow user to delete .bak files
         CleanDirectory(currentDirectory)

         ' summarize and print results
         For Each current In found.Keys
            resultsTextBox.Text &= "* Found " & found(current) &
               " " & current & " files." & vbNewLine
         Next current

         found.Clear() ' clear output for new search
      End If
   End Sub ' searchButton_Click

   ' search directory using LINQ
   Private Sub SearchDirectory(folder As String)
      ' files contained in the directory
      Dim files As String() = Directory.GetFiles(folder)

      ' subdirectories in the directory
      Dim directories As String() = Directory.GetDirectories(folder)

      ' find all file extensions in this directory
      Dim extensions =
        From file In files
         Select Path.GetExtension(file) Distinct

      ' count the number of files using each extension
      For Each extension In extensions
         Dim temporaryExtension = extension

         ' count the number of files with the extension
         Dim extensionCount =
            (From file In files
            Where Path.GetExtension(file) = temporaryExtension
            Select file).Count

         ' if the Dictionary already contains a key for the extension
         If found.ContainsKey(extension) Then
            found(extension) += extensionCount ' update the count
         Else
            found.Add(extension, extensionCount) ' add the new count
         End If
      Next

      ' recursive call to search subdirectories
      For Each subdirectory In directories
         SearchDirectory(subdirectory)
      Next
   End Sub ' SearchDirectory

   ' allow user to delete backup files (.bak)
   Private Sub CleanDirectory(folder As String)
      ' files contained in the directory
      Dim files As String() = Directory.GetFiles(folder)

      ' subdirectories in the directory
      Dim directories As String() = Directory.GetDirectories(folder)

      ' select all the backup files in this directory
      Dim backupFiles =
        From file In files
        Where (Path.GetExtension(File) = ".bak")
         Select File

      ' iterate over all the backup files (.bak)
      For Each backup In backupFiles
         ' prompt user to delete (.bak) file
         Dim result As DialogResult = MessageBox.Show(
            "Found backup file " & Path.GetFileName(backup) &
            ". Delete?", "Delete Backup", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

         ' delete file if user clicked 'yes'
         If result = Windows.Forms.DialogResult.Yes Then
            File.Delete(backup)
            found(".bak") -= 1

            ' if there are no backup files, delete key from Dictionary
            If found(".bak") = 0 Then
               found.Remove(".bak")
            End If
         End If
      Next

      ' recursive call to clean subdirectories
      For Each subdirectory In directories
         CleanDirectory(subdirectory)
      Next
   End Sub ' CleanDirectory
End Class ' LINQToFileDirectory

'**************************************************************************
'* (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
'* Pearson Education, Inc. All Rights Reserved.                           *
'*                                                                        *
'* DISCLAIMER: The authors and publisher of this book have used their     *
'* best effort s in preparing the book. These efforts include the          *
'* development, research, and testing of the theories and programs        *
'* to determine their effectiveness. The authors and publisher make       *
'* no warranty of any kind, expressed or implied, with regard to these    *
'* programs or to the documentation contained in these books. The authors *
'* and publisher shall not be liable in any event for incidental or       *
'* consequential damages in connection with, or arising out of, the       *
'* furnishing, performance, or use of these programs.                     *
'**************************************************************************