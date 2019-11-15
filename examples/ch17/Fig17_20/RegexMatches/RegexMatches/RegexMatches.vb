' Fig. 17.20: RegexMatches.vb
' A more complex regular expression.
Imports System.Text.RegularExpressions ' regular-expression classes

Module RegexMatches
   Sub Main()
      ' create a regular expression
      Dim expression As New Regex("J.*\d[\d-[4]]-\d\d-\d\d")

      Dim testString As String =
         "Jane's Birthday is 05-12-75" & vbNewLine &
         "Dave's Birthday is 11-04-68" & vbNewLine &
         "John's Birthday is 04-28-73" & vbNewLine &
         "Joe's Birthday is 12-17-77"

      ' print out all matches to the regular expression
      For Each regexMatch In expression.Matches(testString)
         Console.WriteLine(regexMatch)
      Next
   End Sub ' Main
End Module ' RegexMatches

' **************************************************************************
' * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************