' Fig. 7.8: PassArray.vb
' Passing arrays and individual array elements to methods.
Public Class PassArray
   ' invoke methods to demonstrate passing arrays 
   ' and array elements to methods
   Private Sub PassArray_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      Dim array1() As Integer = {1, 2, 3, 4, 5}

      outputTextBox.AppendText(
         "EFFECTS OF PASSING AN ENTIRE ARRAY BY REFERENCE:" & vbCrLf &
         vbCrLf & "The values of the original array are:" & vbCrLf)

      ' display original elements of array1
      For i = 0 To array1.GetUpperBound(0)
         outputTextBox.AppendText(vbTab & array1(i))
      Next

      ModifyArray(array1) ' array is passed by reference
      outputTextBox.AppendText(vbCrLf &
         "The values of the modified array are:" & vbCrLf)

      ' display modified elements of array1
      For i = 0 To array1.GetUpperBound(0)
         outputTextBox.AppendText(vbTab & array1(i))
      Next

      outputTextBox.AppendText(vbCrLf & vbCrLf &
         "EFFECTS OF PASSING AN ARRAY ELEMENT BY VALUE:" & vbCrLf &
          vbCrLf & "array1(3) before ModifyElementByVal: " &
         array1(3) & vbCrLf)

      ModifyElementByVal(array1(3)) ' array element passed by value
      outputTextBox.AppendText("array1(3) after ModifyElementByVal: " &
         array1(3) & vbCrLf)
      outputTextBox.AppendText(vbCrLf & "EFFECTS OF PASSING AN " &
           "ARRAY ELEMENT BY REFERENCE: " & vbCrLf & vbCrLf &
           "array1(3) before ModifyElementByRef: " & array1(3) & vbCrLf)

      ModifyElementByRef(array1(3)) ' array element passed by reference
      outputTextBox.AppendText("array1(3) after ModifyElementByRef: " &
         array1(3))
   End Sub ' PassArray_Load

   ' method modifies array it receives (note ByVal)
   Sub ModifyArray(ByVal arrayParameter() As Integer)
      For j = 0 To arrayParameter.GetUpperBound(0)
         arrayParameter(j) *= 2 ' double the array element   
      Next
   End Sub ' ModifyArray

   ' method modifies integer passed to it
   ' original is not modified (note ByVal)
   Sub ModifyElementByVal(ByVal element As Integer)
      outputTextBox.AppendText(
         "Value received in ModifyElementByVal: " & element & vbCrLf)
      element *= 2 ' double the array element                        
      outputTextBox.AppendText(
         "Value calculated in ModifyElementByVal: " & element & vbCrLf)
   End Sub ' ModifyElementByVal

   ' method modifies integer passed to it
   ' original is modified (note ByRef)
   Sub ModifyElementByRef(ByRef element As Integer)
      outputTextBox.AppendText(
         "Value received in ModifyElementByRef: " & element & vbCrLf)
      element *= 2 ' double the array element                        
      outputTextBox.AppendText(
         "Value calculated in ModifyElementByRef: " & element & vbCrLf)
   End Sub ' ModifyElementByRef
End Class ' PassArray


' **************************************************************************
' * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************
