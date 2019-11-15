' Fig. 6.17: MethodOverloading.vb
' Using overloaded methods.
Public Class MethodOverloading
   ' call overloaded functions
   Private Sub MethodOverloading_Load( sender As Object,
       e As EventArgs) Handles MyBase.Load

      ' call the overloaded Square methods and display the results
      outputLabel.Text =
         "The square of Integer 7 is " & Square(7) & vbCrLf &
         "The square of Double 7.5 is " & Square(7.5)
   End Sub ' MethodOverloading_Load

   ' method Square takes an Integer and returns an Integer
   Function Square( value As Integer) As Integer
      Return Convert.ToInt32(value ^ 2)
   End Function ' Square

   ' method Square takes a Double and returns a Double
   Function Square( value As Double) As Double
      Return value ^ 2
   End Function ' Square
End Class ' MethodOverloading

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