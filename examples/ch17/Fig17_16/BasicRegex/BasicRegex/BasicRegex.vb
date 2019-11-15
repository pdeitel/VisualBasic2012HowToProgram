' Fig. 17.16: BasicRegex.vb
' Demonstrate basic regular expressions.
Imports System.Text.RegularExpressions ' regular-expression classes

Module BasicRegex
   Sub Main()
      Dim testString As String =
         "regular expressions are sometimes called regex or regexp"
      Console.WriteLine("The test string is:" & vbCrLf &
         "   """ & testString & """")
      Console.Write("Match 'e' in the test string: ")

      ' match 'e' in the test string
      Dim expression As New Regex("e")
      Console.WriteLine(expression.Match(testString))
      Console.Write("Match every 'e' in the test string: ")

      ' match 'e' multiple times in the test string
      For Each myMatch In expression.Matches(testString)
         Console.Write("{0} ", myMatch)
      Next

      Console.Write(vbCrLf & "Match ""regex"" in the test string: ")

      ' match 'regex' in the test string
      For Each myMatch In Regex.Matches(testString, "regex")
         Console.Write("{0} ", myMatch)
      Next

      Console.Write(vbCrLf &
         "Match ""regex"" or ""regexp"" using an optional 'p': ")

      ' use the ? quantifier to include an optional 'p'
      For Each myMatch In Regex.Matches(testString, "regexp?")
         Console.Write("{0} ", myMatch)
      Next

      ' use alternation to match either 'cat' or 'hat'
      expression = New Regex("(c|h)at")
      Console.WriteLine(vbCrLf &
         """hat cat"" matches {0}, but ""cat hat"" matches {1}",
         expression.Match("hat cat"), expression.Match("cat hat"))
   End Sub ' Main
End Module ' BasicRegex

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