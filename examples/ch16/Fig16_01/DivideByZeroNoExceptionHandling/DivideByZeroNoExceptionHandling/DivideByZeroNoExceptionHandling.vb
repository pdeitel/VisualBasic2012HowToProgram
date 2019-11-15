' Fig. 16.1: DivideByZeroNoExceptionHandling.vb
' Integer division without exception handling.
Module DivideByZeroNoExceptionHandling
   Sub Main()
      ' get numerator and denominator
      Console.Write("Please enter an integer numerator: ")
      Dim numerator As Integer = Convert.ToInt32(Console.ReadLine())
      Console.Write("Please enter an integer denominator: ")
      Dim denominator As Integer = Convert.ToInt32(Console.ReadLine())

      ' divide the two integers, then display the result
      Dim result As Integer = numerator \ denominator
      Console.WriteLine(vbCrLf &
         "Result: {0:D} \ {1:D} = {2:D}", numerator, denominator, result)
   End Sub ' Main
End Module ' DivideByZeroNoExceptionHandling

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
