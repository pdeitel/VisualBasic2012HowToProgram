' Fig 6.16: Craps.vb
' Craps game using class Random.
Public Class Craps
   ' die-roll constants
   Enum DiceNames
      SNAKE_EYES = 2
      TREY = 3
      LUCKY_SEVEN = 7
      CRAPS = 7
      YO_LEVEN = 11
      BOX_CARS = 12
   End Enum

   Dim myPoint As Integer ' total point if not 2, 3, 12, 7 or 11
   Dim myDie1 As Integer ' die1 face
   Dim myDie2 As Integer ' die2 face
   Dim randomObject As New Random() ' generate random number

   ' begins new game and determines point
   Private Sub playButton_Click( sender As Object,
       e As EventArgs) Handles playButton.Click

      ' initialize variables for new game
      myPoint = 0
      pointGroupBox.Text = "Point"
      statusLabel.Text = String.Empty

      ' remove point-die images
      pointDie1PictureBox.Image = Nothing
      pointDie2PictureBox.Image = Nothing

      Dim sum As Integer = RollDice() ' roll dice and calculate sum

      ' check die roll
      Select Case sum
         Case DiceNames.LUCKY_SEVEN, DiceNames.YO_LEVEN
            rollButton.Enabled = False ' disable Roll button
            statusLabel.Text = "You Win!!!"
         Case DiceNames.SNAKE_EYES, DiceNames.TREY, DiceNames.BOX_CARS
            rollButton.Enabled = False ' disable Roll button
            statusLabel.Text = "Sorry. You Lose."
         Case Else
            myPoint = sum ' store the point value
            pointGroupBox.Text = "Point is " & sum
            statusLabel.Text = "Roll Again!"
            DisplayDie(pointDie1PictureBox, myDie1)
            DisplayDie(pointDie2PictureBox, myDie2)
            playButton.Enabled = False ' disable Play button
            rollButton.Enabled = True ' enable Roll button
      End Select
   End Sub ' playButton_Click

   ' determines outcome of next roll
   Private Sub rollButton_Click( sender As Object,
       e As EventArgs) Handles rollButton.Click

      Dim sum As Integer = RollDice() ' roll dice and calculate sum

      ' check outcome of roll
      If sum = myPoint Then ' win
         statusLabel.Text = "You Win!!!"
         rollButton.Enabled = False ' disable Roll button
         playButton.Enabled = True ' enable Play button
      ElseIf sum = DiceNames.CRAPS Then ' lose
         statusLabel.Text = "Sorry. You Lose."
         rollButton.Enabled = False ' disable Roll button
         playButton.Enabled = True ' enable Play button
      End If
   End Sub ' rollButton_Click

   ' display die image
   Sub DisplayDie( diePictureBox As PictureBox,
       face As Integer)

      ' retrieve specific die image from resources
      Dim pictureResource = My.Resources.ResourceManager.GetObject(
         String.Format("die{0}", face))

      ' convert pictureResource to image type and load into PictureBox
      diePictureBox.Image = CType(pictureResource, Image)
   End Sub ' DisplayDie

   ' generate random die rolls
   Function RollDice() As Integer
      ' determine random integer
      myDie1 = randomObject.Next(1, 7) ' choose value from 1 to 6
      myDie2 = randomObject.Next(1, 7) ' choose value from 1 to 6

      ' display rolls
      DisplayDie(die1PictureBox, myDie1) ' display first die
      DisplayDie(die2PictureBox, myDie2) ' display second die

      Return myDie1 + myDie2 ' return sum
   End Function ' RollDice
End Class ' Craps

' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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