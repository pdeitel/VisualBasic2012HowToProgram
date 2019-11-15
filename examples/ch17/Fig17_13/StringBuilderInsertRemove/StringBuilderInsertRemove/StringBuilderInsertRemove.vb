' Fig. 17.13: StringBuilderInsertRemove.vb
' Insert and Remove methods of class StringBuilder.
Imports System.Text

Module StringBuilderInsertRemove
   Sub Main()
      Dim objectValue As Object = "hello"
      Dim stringValue As String = "good bye"
      Dim characterArray As Char() =
         {"a"c, "b"c, "c"c, "d"c, "e"c, "f"c}
      Dim booleanValue As Boolean = True
      Dim characterValue As Char = "K"c
      Dim integerValue As Integer = 7
      Dim longValue As Long = 10000000
      Dim floatValue As Single = 2.5F ' F indicates that 2.5 is a float
      Dim doubleValue As Double = 33.333
      Dim buffer As New StringBuilder()

      ' insert values into buffer
      buffer.Insert(0, objectValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, stringValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, characterArray)
      buffer.Insert(0, "  ")
      buffer.Insert(0, booleanValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, characterValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, integerValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, longValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, floatValue)
      buffer.Insert(0, "  ")
      buffer.Insert(0, doubleValue)
      buffer.Insert(0, "  ")

      Console.WriteLine("buffer after inserts: " & vbCrLf &
         buffer.ToString() & vbCrLf)

      buffer.Remove(10, 1) ' delete 2 in 2.5
      buffer.Remove(4, 4) ' delete .333 in 33.333

      Console.WriteLine("buffer after Removes:" & vbCrLf &
         buffer.ToString())
   End Sub ' Main
End Module ' StringBuilderInsertRemove


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