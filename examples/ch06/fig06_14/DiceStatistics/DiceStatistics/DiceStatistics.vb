' Fig. 6.14: DiceStatistics.vb
' Rolling 12 dice with frequency chart.
Public Class DiceStatistics
   Dim randomObject As New Random() ' generate random number
   Dim ones As Integer = 0 ' count of die face 1
   Dim twos As Integer = 0 ' count of die face 2
   Dim threes As Integer = 0 ' count of die face 3
   Dim fours As Integer = 0 ' count of die face 4
   Dim fives As Integer = 0 ' count of die face 5
   Dim sixes As Integer = 0 ' count of die face 6

   ' display result of twelve rolls
   Private Sub rollButton_Click( sender As Object,
       e As EventArgs) Handles rollButton.Click

      ' display 12 randomly selected die faces
      DisplayDie(die1PictureBox)
      DisplayDie(die2PictureBox)
      DisplayDie(die3PictureBox)
      DisplayDie(die4PictureBox)
      DisplayDie(die5PictureBox)
      DisplayDie(die6PictureBox)
      DisplayDie(die7PictureBox)
      DisplayDie(die8PictureBox)
      DisplayDie(die9PictureBox)
      DisplayDie(die10PictureBox)
      DisplayDie(die11PictureBox)
      DisplayDie(die12PictureBox)

      Dim total As Integer = ones + twos + threes + fours + fives + sixes

      ' display frequencies of faces
      displayTextBox.Text =
         "Face" & vbTab & "Frequency" & vbTab & "Percent" & vbCrLf &
         "1" & vbTab & ones & vbTab & vbTab &
         String.Format("{0:P2}", ones / total) & vbCrLf &
         "2" & vbTab & twos & vbTab & vbTab &
         String.Format("{0:P2}", twos / total) & vbCrLf &
         "3" & vbTab & threes & vbTab & vbTab &
         String.Format("{0:P2}", threes / total) & vbCrLf &
         "4" & vbTab & fours & vbTab & vbTab &
         String.Format("{0:P2}", fours / total) & vbCrLf &
         "5" & vbTab & fives & vbTab & vbTab &
         String.Format("{0:P2}", fives / total) & vbCrLf &
         "6" & vbTab & sixes & vbTab & vbTab &
         String.Format("{0:P2}", sixes / total)
   End Sub ' rollButton_Click

   ' display a single die image
   Sub DisplayDie( diePictureBox As PictureBox)
      Dim face As Integer = randomObject.Next(1, 7)

      ' retrieve specific die image from resources
      Dim pictureResource = My.Resources.ResourceManager.GetObject(
         String.Format("die{0}", face))

      ' convert pictureResource to image type and load into PictureBox
      diePictureBox.Image = CType(pictureResource, Image)

      ' maintain count of die faces
      Select Case face
         Case 1 ' die face 1
            ones += 1
         Case 2 ' die face 2
            twos += 1
         Case 3 ' die face 3
            threes += 1
         Case 4 ' die face 4
            fours += 1
         Case 5 ' die face 5
            fives += 1
         Case 6 ' die face 6
            sixes += 1
      End Select
   End Sub ' DisplayDie
End Class ' DiceStatistics

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