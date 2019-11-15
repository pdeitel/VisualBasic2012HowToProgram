' Fig. 9.9: DeckOfCardsTest.vb
' Card shuffling and dealing app.
Public Class DeckOfCardsTest
   Private deck As New DeckOfCards() ' create the deck of cards

   ' shuffle the deck when user clicks the Shuffle Button
   Private Sub shuffleButton_Click(sender As Object,
      e As EventArgs) Handles shuffleButton.Click

      deck.Shuffle() ' shuffles the deck
      card1PictureBox.Image = Nothing ' clear image
      card2PictureBox.Image = Nothing ' clear image
      card3PictureBox.Image = Nothing ' clear image
      card4PictureBox.Image = Nothing ' clear image
      card5PictureBox.Image = Nothing ' clear image
      dealButton.Enabled = True ' allow user to click the Deal Button
      MessageBox.Show("Deck is shuffled")
   End Sub ' shuffleButton_Click

   ' deal five cards
   Private Sub dealButton_Click(sender As Object,
      e As EventArgs) Handles dealButton.Click

      card1PictureBox.Image = GetCardImage(deck.DealCard())
      card2PictureBox.Image = GetCardImage(deck.DealCard())
      card3PictureBox.Image = GetCardImage(deck.DealCard())
      card4PictureBox.Image = GetCardImage(deck.DealCard())
      card5PictureBox.Image = GetCardImage(deck.DealCard())
   End Sub ' dealButton_Click

   ' return an image for the Card argument
   Private Function GetCardImage(card As Card) As Image
      If card IsNot Nothing Then
         ' retrieve specific card image from resources
         Dim pictureResource = My.Resources.ResourceManager.GetObject(
           card.ToString().Replace(" ", ""))
         Return CType(pictureResource, Image) ' return Image
      Else
         dealButton.Enabled = False ' disable the Deal Button
         Return Nothing ' no more cards
      End If
   End Function ' GetCardImage
End Class ' DeckOfCardsTest

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
