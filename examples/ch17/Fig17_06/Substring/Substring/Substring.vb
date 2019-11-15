﻿' Fig. 17.6: Substring.vb
' Demonstrating the String Substring method.

Module Substring
   Sub Main()
      Dim letters As String = "abcdefghijklmabcdefghijklm"
      Dim output As String = String.Empty

      ' invoke Substring method and pass it one parameter
      Console.WriteLine("Substring from index 20 to end is " &
         Chr(34) & letters.Substring(20) & Chr(34))

      ' invoke Substring method and pass it two parameters
      Console.WriteLine("Substring from index 0 of length 6 is " &
         Chr(34) & letters.Substring(0, 6) & Chr(34))
   End Sub ' Main
End Module ' SubString


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