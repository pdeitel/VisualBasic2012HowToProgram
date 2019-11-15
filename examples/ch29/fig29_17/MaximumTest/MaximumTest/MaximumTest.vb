' Fig. 29.17: MaximumTest.vb
' Generic method Maximum with a type constraint on its type parameter.
Module MaximumTest
   Sub Main()
      Console.WriteLine("Maximum of {0}, {1} and {2} is {3}" &
         vbCrLf, 3, 4, 5, Maximum(3, 4, 5))
      Console.WriteLine("Maximum of {0}, {1} and {2} is {3}" &
         vbCrLf, 6.6, 8.8, 7.7, Maximum(6.6, 8.8, 7.7))
      Console.WriteLine("Maximum of {0}, {1} and {2} is {3}" &
         vbCrLf, "pear", "apple", "orange",
         Maximum("pear", "apple", "orange"))
   End Sub ' Main

   ' generic function determines the
   ' largest of the IComparable objects
   Public Function Maximum(Of T As IComparable(Of T)) _
      (x As T, y As T, z As T) As T
      Dim max As T = x ' assume x is initially the largest

      ' compare y with max
      If y.CompareTo(max) > 0 Then
         max = y ' y is the largest so far
      End If

      ' compare z with max
      If z.CompareTo(max) > 0 Then
         max = z ' z is the largest
      End If

      Return max ' return largest object
   End Function ' Maximum
End Module ' MaximumTest


'**************************************************************************
'* (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
'* Pearson Education, Inc. All Rights Reserved.                            *
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
