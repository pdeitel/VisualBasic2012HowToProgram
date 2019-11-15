' Fig. 17.15: SharedCharMethodsForm.vb
' Demonstrates Shared character testing methods 
' from Char structure

Public Class SharedCharMethodsForm
   ' handle analyzeButton_Click
   Private Sub analyzeButton_Click(sender As Object,
       e As EventArgs) Handles analyzeButton.Click

      If inputTextBox.Text.Length = 1 Then
         ' convert String entered to type Char
         Dim character As Char = Convert.ToChar(inputTextBox.Text)
         Dim output As String

         output = "is digit: " & Char.IsDigit(character) & vbcrlf
         output &= "is letter: " & Char.IsLetter(character) & vbcrlf
         output &= "is letter or digit: " &
            Char.IsLetterOrDigit(character) & vbcrlf
         output &= "is lowercase: " & Char.IsLower(character) & vbcrlf
         output &= "is uppercase: " & Char.IsUpper(character) & vbcrlf
         output &= "to uppercase: " & Char.ToUpper(character) & vbcrlf
         output &= "to lower: " & Char.ToLower(character) & vbcrlf
         output &= "is punctuation: " &
            Char.IsPunctuation(character) & vbcrlf
         output &= "is symbol: " & Char.IsSymbol(character)
         outputTextBox.Text = output
      End If
   End Sub ' analyzeButton_Click
End Class ' SharedCharMethodsForm

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