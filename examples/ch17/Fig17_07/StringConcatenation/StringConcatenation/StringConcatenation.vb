' Fig. 17.7: StringConcatenation.vb
' Demonstrating string class Concat method.

Module StringConcatenation
   Sub Main()
      Dim string1 As String = "Happy "
      Dim string2 As String = "Birthday"

      Console.WriteLine("string1 = " & Chr(34) & string1 & Chr(34) &
         vbCrLf & "string2 = " & Chr(34) & string2 & Chr(34))
      Console.WriteLine(vbCrLf &
         "Result of String.Concat( string1, string2 ) = " &
         String.Concat(string1, string2))
      Console.WriteLine("string1 after concatenation = " & string1)
   End Sub ' Main
End Module ' StringConcatenation

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