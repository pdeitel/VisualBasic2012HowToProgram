' Fig. 9.7: Card.vb
' Card class represents a playing card.
Public Class Card
   Private face As String ' face of card ("Ace", "Two", ...)
   Private suit As String ' suit of card ("Hearts", "Diamonds", ...)

   ' two-argument constructor initializes card's face and suit
   Public Sub New(cardFace As String, cardSuit As String)
      face = cardFace ' initialize face of card
      suit = cardSuit ' initialize suit of card
   End Sub ' New

   ' return String representation of Card, Overrides defined in Ch 10
   Public Overrides Function ToString() As String
      Return face & " of " & suit
   End Function ' ToString                       
End Class ' Card

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