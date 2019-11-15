' Screen.vb
' Represents the screen of the ATM
Public Class Screen
   ' displays a message without a terminating carriage return
   Public Sub DisplayMessage(message As String)
      Console.Write(message)
   End Sub ' DisplayMessage

   ' display a message with a terminating carriage return
   Public Sub DisplayMessageLine(message As String)
      Console.WriteLine(message)
   End Sub ' DisplayMessageLine

   ' display a dollar amount
   Public Sub DisplayDollarAmount(amount As Decimal)
      Console.Write("{0:C}", amount)
   End Sub ' DisplayDollarAmount
End Class ' Screen

' **************************************************************************
' * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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
