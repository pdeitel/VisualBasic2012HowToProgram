' Fig. 17.10: StringBuilderFeatures.vb
' Demonstrating some features of class StringBuilder.
Imports System.Text

Module StringBuilderFeatures
   Sub Main()
      Dim buffer As New StringBuilder("Hello, how are you?")

      ' use Length and Capacity properties
      Console.WriteLine("buffer = " & buffer.ToString() & vbNewLine &
         "Length = " & buffer.Length & vbNewLine & "Capacity = " &
         buffer.Capacity)

      buffer.EnsureCapacity(75) ' ensure a capacity of at least 75
      Console.WriteLine(vbNewLine & "New capacity = " & buffer.Capacity)

      ' truncate StringBuilder by setting Length property
      buffer.Length = 10
      Console.Write(vbNewLine & "New length = " &
         buffer.Length & vbNewLine & "buffer = ")

      ' use StringBuilder indexer
      For i = 0 To buffer.Length - 1
         Console.Write(buffer(i))
      Next i

      Console.WriteLine()
   End Sub ' Main
End Module ' StringBuilderFeatures

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
