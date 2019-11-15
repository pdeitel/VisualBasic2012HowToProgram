' Fig. 17.2: StringMethods.vb
' Using the indexer, property Length and method CopyTo
' of class string.

Module StringMethods
   Sub Main()
      Dim string1 As String = "hello there"
      Dim characterArray() As Char = New Char(5) {}

      ' output string1
      Console.WriteLine("string1: " & Chr(34) & string1 & Chr(34))

      ' test Length property
      Console.WriteLine("Length of string1: " & string1.Length)

      ' loop through characters in string1 and display reversed
      Console.Write("The string reversed is: ")

      For i = string1.Length - 1 To 0 Step -1
         Console.Write(string1(i))
      Next i

      ' copy characters from string1 into characterArray
      string1.CopyTo(0, characterArray, 0, 5)
      Console.Write(vbCrLf & "The character array is: ")

      For i = 0 To characterArray.Length - 1
         Console.Write(characterArray(i))
      Next i

      Console.WriteLine(vbCrLf)
   End Sub ' Main
End Module ' StringMethods


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
