' Fig. 17.1: StringConstructor.vb
' Demonstrating String class constructors.

Module StringConstructor
   Sub Main()
      Dim characterArray() As Char =
         {"b"c, "i"c, "r"c, "t"c, "h"c, " "c, "d"c, "a"c, "y"c}

      ' string initialization
      Dim originalString As String = "Welcome to VB programming!"
      Dim string1 As String = originalString
      Dim string2 As New String(characterArray)
      Dim string3 As New String(characterArray, 6, 3)
      Dim string4 As New String("C"c, 5)

      Console.WriteLine("string1 = " & Chr(34) & string1 & Chr(34) &
         vbCrLf & "string2 = " & Chr(34) & string2 & Chr(34) &
         vbCrLf & "string3 = " & Chr(34) & string3 & Chr(34) &
         vbCrLf & "string4 = " & Chr(34) & string4 & Chr(34) &
         vbCrLf)
   End Sub ' Main
End Module ' StringConstructor


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
