' Fig. 17.4: StringStartEnd.vb
' Demonstrating StartsWith and EndsWith methods.

Module StringStartEnd
   Sub Main()
      Dim strings As String() =
         {"started", "starting", "ended", "ending"}

      ' test every string to see if it starts with "st"
      For Each element In Strings
         If element.StartsWith("st") Then
            Console.WriteLine(Chr(34) & element & Chr(34) &
               " starts with " & Chr(34) & "st" & Chr(34))
         End If
      Next

      Console.WriteLine()

      ' test every string to see if it ends with "ed"
      For Each element In Strings
         If element.EndsWith("ed") Then
            Console.WriteLine(Chr(34) & element & Chr(34) &
               " ends with " & Chr(34) & "ed" & Chr(34))
         End If
      Next

      Console.WriteLine()
   End Sub ' Main
End Module ' StringStartEnd


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