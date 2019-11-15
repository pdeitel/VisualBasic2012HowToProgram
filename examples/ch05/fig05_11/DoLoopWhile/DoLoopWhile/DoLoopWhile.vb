' Fig. 5.11: DoLoopWhile.vb
' Do...Loop While repetition statement.
Public Class DoLoopWhile
   ' display the even Integers from 2 to 10
   Private Sub DoLoopWhile_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      Dim counter As Integer = 2 ' initialize counter

      Do
         outputLabel.Text &= counter & "  " ' display counter value
         counter += 2 ' increment counter
      Loop While counter <= 10
   End Sub ' DoLoopWhile_Load
End Class ' DoLoopWhile

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
