' Fig. 5.1: ForCounter.vb
' Counter-controlled repetition with the For…Next statement.
Public Class ForCounter
   ' display the even Integers from 2 to 10
   Private Sub ForCounter_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' initialization, repetition condition and             
      ' incrementing are all included in the For...Next statement
      For counter As Integer = 2 To 10 Step 2
         ' append counter value to outputLabel's Text property
         outputLabel.Text &= counter & "  " ' display counter
      Next
   End Sub ' ForCounter_Load
End Class ' ForCounter

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
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
