' Fig. 7.2: InitializeArrays.vb
' Initializing array elements with an array initializer and a For...Next
Public Class InitalizeArrays
   ' initialize and display two arrays' contents
   Private Sub InitalizeArrays_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' initializer list specifies the number of elements
      ' and the value of each element                    
      Dim array1() As Integer = {32, 27, 64, 18, 95}

      ' allocate array2 based on length of array1     
      Dim array2(array1.GetUpperBound(0)) As Integer

      ' set values in array2 by a calculation
      For i = 0 To array2.GetUpperBound(0)
         array2(i) = 2 + 2 * i ' generate 2, 4, 6, ..., 10
      Next

      outputTextBox.AppendText(
         "Index " & vbTab & "Array1" & vbTab & "Array2" & vbCrLf)

      ' display values for both arrays side by side
      For i = 0 To array1.GetUpperBound(0)
         outputTextBox.AppendText(
            i & vbTab & array1(i) & vbTab & array2(i) & vbCrLf)
      Next
   End Sub ' InitalizeArrays_Load
End Class ' InitalizeArrays


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

