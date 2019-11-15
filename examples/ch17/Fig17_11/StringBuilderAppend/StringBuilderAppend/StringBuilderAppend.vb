' Fig. 17.11: StringBuilderAppend.vb
' Demonstrating StringBuilder Append methods.
Imports System.Text

Module StringBuilderAppend
   Sub Main()
      Dim objectValue As Object = "hello"
      Dim stringValue As String = "good bye"
      Dim characterArray As Char() = {"a"c, "b"c, "c"c, "d"c, "e"c, "f"c}
      Dim booleanValue As Boolean = True
      Dim characterValue As Char = "Z"c
      Dim integerValue As Integer = 7
      Dim longValue As Long = 1000000
      Dim floatValue As Single = 2.5F ' F indicates that 2.5 is a float
      Dim doubleValue As Double = 33.333
      Dim buffer As New StringBuilder()

      ' use method Append to append values to buffer
      buffer.Append(objectValue)
      buffer.Append("  ")
      buffer.Append(stringValue)
      buffer.Append("  ")
      buffer.Append(characterArray)
      buffer.Append("  ")
      buffer.Append(characterArray, 0, 3)
      buffer.Append("  ")
      buffer.Append(booleanValue)
      buffer.Append("  ")
      buffer.Append(characterValue)
      buffer.Append("  ")
      buffer.Append(integerValue)
      buffer.Append("  ")
      buffer.Append(longValue)
      buffer.Append("  ")
      buffer.Append(floatValue)
      buffer.Append("  ")
      buffer.Append(doubleValue)

      Console.WriteLine("buffer = " & buffer.ToString() & vbCrLf)
   End Sub ' Main
End Module ' StringBuilderAppend


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