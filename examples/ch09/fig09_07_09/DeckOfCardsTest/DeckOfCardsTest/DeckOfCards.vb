' Fig. 9.8: DeckOfCards.vb
' DeckOfCards class represents a deck of playing cards.
Public Class DeckOfCards
   Private Const NUMBER_OF_CARDS As Integer = 52 ' number of cards
   Private deck(NUMBER_OF_CARDS - 1) As Card ' array of Card objects
   Private currentCard As Integer ' index of next Card to be dealt
   Private Shared randomNumbers As New Random() ' random number generator

   ' constructor fills deck of Cards
   Public Sub New()
      Static faces() As String = {"Ace", "Two", "Three", "Four", "Five",
         "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"}
      Static suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
      currentCard = 0 ' set currentCard so first Card dealt is deck(0)

      ' populate deck array with Card objects
      For count = 0 To deck.GetUpperBound(0)
         deck(count) = New Card(faces(count Mod 13), suits(count \ 13))
      Next
   End Sub ' New

   ' shuffle deck of Cards with simple one-pass algorithm
   Public Sub Shuffle()
      ' after shuffling, dealing should start at deck(0) again
      currentCard = 0 ' reinitialize currentCard

      ' for each Card, pick another random Card and swap them
      For first = 0 To deck.GetUpperBound(0)
         ' select a random number between 0 and 51
         Dim second As Integer = randomNumbers.Next(NUMBER_OF_CARDS)

         ' swap current Card with randomly selected Card
         Dim temp As Card = deck(first) ' store copy of deck(first)
         deck(first) = deck(second) ' move deck(second) to deck(first)
         deck(second) = temp ' move original deck(first) to deck(second)
      Next
   End Sub ' Shuffle

   ' deal one Card
   Public Function DealCard() As Card
      ' determine whether Cards remain to be dealt
      If currentCard <= deck.GetUpperBound(0) Then
         Dim lastCard As Integer = currentCard ' store current card number
         currentCard += 1 ' increment current card number 
         Return deck(lastCard)
      Else
         Return Nothing ' no more cards to deal
      End If
   End Function ' DealCard
End Class ' DeckOfCards

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