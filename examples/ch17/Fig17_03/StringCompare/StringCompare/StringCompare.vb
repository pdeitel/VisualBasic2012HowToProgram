' Fig. 17.3: StringCompare.vb
' Comparing Strings

Module StringCompare
   Sub Main()
      Dim string1 As String = "hello"
      Dim string2 As String = "good bye"
      Dim string3 As String = "Happy Birthday"
      Dim string4 As String = "happy birthday"

      ' output values of four strings
      Console.WriteLine("string1 = " & Chr(34) & string1 & Chr(34) &
         vbCrLf & "string2 = " & Chr(34) & string2 & Chr(34) &
         vbCrLf & "string3 = " & Chr(34) & string3 & Chr(34) &
         vbCrLf & "string4 = " & Chr(34) & string4 & Chr(34) &
         vbCrLf)

      ' test for equality using Equals method
      If string1.Equals("hello") Then
         Console.WriteLine("string1 equals " & Chr(34) & "hello" &
            Chr(34))
      Else
         Console.WriteLine("string1 does not equal " & Chr(34) &
            "hello" & Chr(34))
      End If

      ' test for equality with =
      If string1 = "hello" Then
         Console.WriteLine("string1 equals " & Chr(34) & "hello" &
            Chr(34))
      Else
         Console.WriteLine("string1 does not equal " & Chr(34) &
            "hello" & Chr(34))
      End If

      ' test for equality comparing case
      If String.Equals(string3, string4) Then ' Shared method
         Console.WriteLine("string3 equals string4")
      Else
         Console.WriteLine("string3 does not equal string4")
      End If

      ' test CompareTo
      Console.WriteLine(vbCrLf &
         "string1.CompareTo( string2 ) is " &
         string1.CompareTo(string2) & vbCrLf &
         "string2.CompareTo( string1 ) is " &
         string2.CompareTo(string1) & vbCrLf &
         "string1.CompareTo( string1 ) is " &
         string1.CompareTo(string1) & vbCrLf &
         "string3.CompareTo( string4 ) is " &
         string3.CompareTo(string4) & vbCrLf &
         "string4.CompareTo( string3 ) is " &
         string4.CompareTo(string3) & vbCrLf)
   End Sub ' Main
End Module ' StringCompare


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