' Fig. 6.11: RollDice.vb
' Rolling four dice and displaying corresponding images.
Public Class RollDice
   Dim randomObject As New Random() ' create Random object

   ' display results of four rolls
   Private Sub rollButton_Click( sender As Object,
       e As EventArgs) Handles rollButton.Click
      ' method randomly assigns a face to each die
      DisplayDie(die1PictureBox)
      DisplayDie(die2PictureBox)
      DisplayDie(die3PictureBox)
      DisplayDie(die4PictureBox)
   End Sub ' rollButton_Click

   ' get a random die image
   Sub DisplayDie( diePictureBox As PictureBox)
      ' generate random integer in range 1 to 6
      Dim face As Integer = randomObject.Next(1, 7)

      ' retrieve specific die image from resources
      Dim pictureResource = My.Resources.ResourceManager.GetObject(
         String.Format("die{0}", face))

      ' convert pictureResource to type Image and display in PictureBox
      diePictureBox.Image = CType(pictureResource, Image)
   End Sub ' DisplayDie
End Class ' RollDice

' **************************************************************************
' * (C) Copyright 1992-2014  by Deitel & Associates, Inc. and               *
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