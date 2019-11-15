' Fig. 17.18: CharacterClasses.vb
' Demonstrate using character classes and quantifiers.
Imports System.Text.RegularExpressions ' regular-expression classes

Module CharacterClasses
   Sub Main()
      Dim testString As String = "abc, DEF, 123"
      Console.WriteLine("The test string is: ""{0}""", testString)

      ' find the digits is the test string
      Console.WriteLine("Match any digit")
      DisplayMatches(testString, "\d")

      ' find anything that isn't a digit
      Console.WriteLine(vbCrLf & "Match any nondigit")
      DisplayMatches(testString, "\D")

      ' find the word characters in the test string
      Console.WriteLine(vbCrLf & "Match any word character")
      DisplayMatches(testString, "\w")

      ' find sequences of word characters
      Console.WriteLine(vbCrLf &
         "Match a group of at least one word character")
      DisplayMatches(testString, "\w+")

      ' use a lazy quantifier
      Console.WriteLine(vbCrLf &
         "Match a group of at least one word character (lazy)")
      DisplayMatches(testString, "\w+?")

      ' match characters from 'a' to 'f'
      Console.WriteLine(vbCrLf & "Match anything from 'a' - 'f'")
      DisplayMatches(testString, "[a-f]")

      ' match anything that isn't in the range 'a' to 'f'
      Console.WriteLine(vbCrLf & "Match anything not from 'a' - 'f'")
      DisplayMatches(testString, "[^a-f]")

      ' match any sequence of letters in any case
      Console.WriteLine(
         vbCrLf & "Match a group of at least one letter")
      DisplayMatches(testString, "[a-zA-Z]+")

      ' use the . (dot) metacharacter to match any character
      Console.WriteLine(vbCrLf & "Match a group of any characters")
      DisplayMatches(testString, ".*")
   End Sub ' Main

   ' display the matches to a regular expression
   Private Sub DisplayMatches(
       input As String,  expression As String)

      For Each regexMatch In Regex.Matches(input, expression)
         Console.Write("{0} ", regexMatch)
      Next

      Console.WriteLine() ' move to the next line
   End Sub ' DisplayMatches
End Module ' CharacterClasses

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