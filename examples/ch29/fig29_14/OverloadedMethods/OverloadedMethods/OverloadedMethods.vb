' Fig. 29.14: OverloadedMethods.vb
' Using overloaded methods to print arrays of different types.
Module OverloadedMethods
   Sub Main()
      ' create arrays of Integer, Double and Char types
      Dim integerArray() As Integer = {1, 2, 3, 4, 5, 6}
      Dim doubleArray() As Double = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7}
      Dim charArray() As Char = {"H"c, "E"c, "L"c, "L"c, "O"c}

      Console.WriteLine("Array integerArray contains:")
      PrintArray(integerArray) ' pass an Integer array argument
      Console.WriteLine("Array doubleArray contains:")
      PrintArray(doubleArray) ' pass a Double array argument
      Console.WriteLine("Array charArray contains:")
      PrintArray(charArray) ' pass a Char array 
   End Sub ' Main

   ' output Integer array
   Sub PrintArray(inputArray() As Integer)
      For Each element In inputArray
         Console.Write(element.ToString() & " ")
      Next

      Console.WriteLine(vbCrLf)
   End Sub ' PrintArray

   ' output Double array
   Sub PrintArray(inputArray() As Double)
      For Each element In inputArray
         Console.Write(element.ToString() & " ")
      Next

      Console.WriteLine(vbCrLf)
   End Sub ' PrintArray

   ' output Char array
   Sub PrintArray(inputArray() As Char)
      For Each element In inputArray
         Console.Write(element.ToString() & " ")
      Next

      Console.WriteLine(vbCrLf)
   End Sub ' PrintArray
End Module ' OverloadedMethods

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