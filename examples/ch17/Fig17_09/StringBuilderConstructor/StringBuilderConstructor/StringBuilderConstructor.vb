' Fig. 17.9: StringBuilderConstructor.vb
' Demonstrating StringBuilder class constructors.
Imports System.Text

Module StringBuilderConstructor
   Sub Main()
      Dim buffer1 As New StringBuilder()
      Dim buffer2 As New StringBuilder(10)
      Dim buffer3 As New StringBuilder("hello")

      Console.WriteLine("buffer1 = " & Chr(34) & buffer1.ToString() &
         Chr(34))
      Console.WriteLine("buffer2 = " & Chr(34) & buffer2.ToString() &
         Chr(34))
      Console.WriteLine("buffer3 = " & Chr(34) & buffer3.ToString() &
         Chr(34))
   End Sub ' Main
End Module ' StringBuilderConstructor


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
