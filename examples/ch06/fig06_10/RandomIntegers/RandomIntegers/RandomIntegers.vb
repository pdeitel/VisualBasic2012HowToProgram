' Fig. 6.10: RandomIntegers.vb
' Random integers from 1 to 6 created by calling Random method Next.
Public Class RandomIntegers
   ' display 20 random integers
   Private Sub RandomIntegers_Load( sender As Object,
       e As EventArgs) Handles MyBase.Load

      Dim randomObject As New Random() ' create Random object
      Dim randomNumber As Integer

      ' generate 20 random numbers between 1 and 6
      For i = 1 To 20
         randomNumber = randomObject.Next(1, 7)
         outputTextBox.AppendText(randomNumber & "   ")

         If i Mod 5 = 0 Then ' is i a multiple of 5?
            outputTextBox.AppendText(vbCrLf) ' move to next line of output
         End If
      Next
   End Sub ' RandomIntegers_Load
End Class ' RandomIntegers

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
