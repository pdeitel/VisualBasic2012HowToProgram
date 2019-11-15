' Fig. 17.5: StringIndexMethods.vb
' Using string searching methods.

Module StringIndexMethods
   Sub Main()
      Dim letters As String = "abcdefghijklmabcdefghijklm"
      Dim searchLetters As Char() = {"c"c, "a"c, "$"c}

      ' test IndexOf to find a character in a string
      Console.WriteLine("First 'c' is located at index " &
         letters.IndexOf("c"c))
      Console.WriteLine("First 'a' starting at 1 is located at index " &
         letters.IndexOf("a"c, 1))
      Console.WriteLine("First '$' in the 5 positions starting at 3 " &
         "is located at index " & letters.IndexOf("$"c, 3, 5))

      ' test LastIndexOf to find a character in a string
      Console.WriteLine(vbCrLf & "Last 'c' is located at index " &
         letters.LastIndexOf("c"c))
      Console.WriteLine("Last 'a' up to position 25 is located at " &
         "index " & letters.LastIndexOf("a"c, 25))
      Console.WriteLine("Last '$' in the 5 positions starting at 15 " &
         "is located at index " & letters.LastIndexOf("$"c, 15, 5))

      ' test IndexOf to find a substring in a string
      Console.WriteLine(vbCrLf & "First " & Chr(34) & "def" &
         Chr(34) & " is located at index " & letters.IndexOf("def"))
      Console.WriteLine("First " & Chr(34) & "def" & Chr(34) &
         " starting at 7 is located at " & "index " &
         letters.IndexOf("def", 7))
      Console.WriteLine("First " & Chr(34) & "hello" & Chr(34) &
         " in the 15 positions starting at 5 is located at index " &
         letters.IndexOf("hello", 5, 15))

      ' test LastIndexOf to find a substring in a string
      Console.WriteLine(vbCrLf & "Last " & Chr(34) & "def" &
         Chr(34) & " is located at index " & letters.LastIndexOf("def"))
      Console.WriteLine("Last " & Chr(34) & "def" & Chr(34) &
         " up to position 25 is located at index " &
         letters.LastIndexOf("def", 25))
      Console.WriteLine("Last " & Chr(34) & "hello" & Chr(34) &
         " in the 15 positions ending at 20 is located at index " &
         letters.LastIndexOf("hello", 20, 15))

      ' test IndexOfAny to find first occurrence of character in array
      Console.WriteLine(vbCrLf & "First 'c', 'a' or '$' is " &
         "located at index " & letters.IndexOfAny(searchLetters))
      Console.WriteLine("First 'c', 'a' or '$' starting at 7 is " &
         "located at index " & letters.IndexOfAny(searchLetters, 7))
      Console.WriteLine("First 'c', 'a' or '$' in the 5 positions " &
         "starting at 7 is located at index " &
         letters.IndexOfAny(searchLetters, 7, 5))

      ' test LastIndexOfAny to find last occurrence of character
      ' in array
      Console.WriteLine(vbCrLf & "Last 'c', 'a' or '$' is " &
         "located at index " & letters.LastIndexOfAny(searchLetters))
      Console.WriteLine("Last 'c', 'a' or '$' up to position 1 is " &
         "located at index " & letters.LastIndexOfAny(searchLetters, 1))
      Console.WriteLine("Last 'c', 'a' or '$' in the 5 positions " &
         "ending at 25 is located at index " &
         letters.LastIndexOfAny(searchLetters, 25, 5))
   End Sub ' Main
End Module ' StringIndexMethods


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
