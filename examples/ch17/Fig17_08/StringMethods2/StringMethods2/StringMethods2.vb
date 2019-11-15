' Fig. 17.8: StringMethods2.vb
' Demonstrating String methods Replace, ToLower, ToUpper, Trim, 
' and ToString.

Module StringMethods2
   Sub Main()
      Dim string1 As String = "cheers!"
      Dim string2 As String = "GOOD BYE "
      Dim string3 As String = "   spaces   "

      Console.WriteLine("string1 = " & Chr(34) & string1 & Chr(34) &
         vbCrLf & "string2 = " & Chr(34) & string2 & Chr(34) &
         vbCrLf & "string3 = " & Chr(34) & string3 & Chr(34))

      ' call method Replace
      Console.WriteLine(vbCrLf & "Replacing " & Chr(34) & "e" &
         Chr(34) & " with " & Chr(34) & "E" & Chr(34) &
         " in string1: " & Chr(34) & string1.Replace("e"c, "E"c) &
         Chr(34))

      ' call ToLower and ToUpper
      Console.WriteLine(vbCrLf & "string1.ToUpper() = " & Chr(34) &
         string1.ToUpper() & Chr(34) & vbCrLf &
         "string2.ToLower() = " & Chr(34) & string2.ToLower() & Chr(34))

      ' call Trim method
      Console.WriteLine(vbCrLf & "string3 after trim = " & Chr(34) &
         string3.Trim() & Chr(34))

      Console.WriteLine(vbCrLf & "string1 = " & Chr(34) & string1 &
         Chr(34))
   End Sub ' Main
End Module ' StringMethods2


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