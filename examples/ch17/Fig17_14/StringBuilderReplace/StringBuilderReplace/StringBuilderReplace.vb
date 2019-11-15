' Fig. 17.14: StringBuilderReplace.vb
' Demonstrating method Replace.
Imports System.Text

Module StringBuilderReplace
   Sub Main()
      Dim builder1 As New StringBuilder("Happy Birthday Jane")
      Dim builder2 As New StringBuilder("good bye greg")

      Console.WriteLine("Before replacements:" & vbCrLf &
         builder1.ToString() & vbCrLf & builder2.ToString())

      builder1.Replace("Jane", "Greg")
      builder2.Replace("g"c, "G"c, 0, 5)

      Console.WriteLine(vbCrLf & "After replacements:" & vbCrLf &
         builder1.ToString() & vbCrLf & builder2.ToString())
   End Sub ' Main
End Module ' StringBuilderReplace

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
