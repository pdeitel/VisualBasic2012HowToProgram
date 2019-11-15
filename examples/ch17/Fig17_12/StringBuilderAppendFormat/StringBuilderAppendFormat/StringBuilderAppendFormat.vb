' Fig. 17.12: StringBuilderAppendFormat.vb
' Demonstrating method AppendFormat.
Imports System.Text

Module StringBuilderAppendFormat
   Sub Main()
      Dim buffer As New StringBuilder()

      ' formatted string
      Dim string1 As String = "This {0} costs: {1:C}." & vbCrLf

      ' string1 argument array
      Dim objectArray(2) As Object

      objectArray(0) = "car"
      objectArray(1) = 1234.56

      ' append to buffer formatted string with argument
      buffer.AppendFormat(string1, objectArray)

      ' formatted string
      Dim string2 As String = "Number:{0:d3}." & vbCrLf &
         "Number right aligned with spaces:{0, 4}." & vbCrLf &
         "Number left aligned with spaces:{0, -4}."

      ' append to buffer formatted string with argument
      buffer.AppendFormat(string2, 5)

      ' display formatted strings
      Console.WriteLine(buffer.ToString())
   End Sub ' Main
End Module ' StringBuilderAppendFormat


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