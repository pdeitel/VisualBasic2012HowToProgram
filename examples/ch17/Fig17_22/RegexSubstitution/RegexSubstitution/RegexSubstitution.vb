' Fig. 17.24: RegexSubstitution.vb
' Using Regex methods Replace and Split.
Imports System.Text.RegularExpressions ' regular expression classes

Module RegexSubstitution
   Sub Main()
      Dim testString1 As String =
         "This sentence ends in 5 stars *****"
      Dim testString2 As String = "1, 2, 3, 4, 5, 6, 7, 8"
      Dim testRegex1 As New Regex("\d")
      Dim output As String = String.Empty

      Console.WriteLine("First test string: " & testString1)

      ' replace every '*' with a '^' and display the result
      testString1 = Regex.Replace(testString1, "\*", "^")
      Console.WriteLine("^ substituted for *: " & testString1)

      ' replace the word "starts" with "carets" and display the result
      testString1 = Regex.Replace(testString1, "stars", "carets")
      Console.WriteLine("""carets"" substituted for ""stars"": " &
         testString1)

      ' replace every word with "word" and display the result
      Console.WriteLine("Every word replaced by ""word"": " &
         Regex.Replace(testString1, "\w+", "word"))

      Console.WriteLine(vbCrLf & "Second test string: " & testString2)

      ' replace the first three digits with the word "digit"
      Console.WriteLine("Replace first 3 digits by ""digit"": " &
         testRegex1.Replace(testString2, "digit", 3))

      Console.Write("string split at commas [")

      ' split the string into individual strings, each containing a digit
      Dim result As String() = Regex.Split(testString2, ",\s")

      ' add each digit to the output string
      For Each resultString In result
         output &= """" & resultString & """, "
      Next

      ' Delete ", " at the end of output string
      Console.WriteLine(output.Substring(0, output.Length - 2) & "]")
   End Sub ' Main
End Module ' RegexSubstitution

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