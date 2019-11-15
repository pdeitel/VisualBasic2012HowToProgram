' Fig. 7.5: DiceStatistics.vb
' Rolling 12 dice with frequency chart.
Public Class DiceStatistics
   Dim randomObject As New Random() ' generates random numbers
   Dim frequency(6) As Integer ' create 7-element array

   ' display result of twelve rolls
   Private Sub rollButton_Click(sender As Object,
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

      Dim total As Double = 0

      ' total the die faces (used in percentage calculations)
      For i = 1 To frequency.GetUpperBound(0)
         total += frequency(i)
      Next

      ' display frequencies of faces
      displayTextBox.Text =
         "Face" & vbTab & "Frequency" & vbTab & "Percent" & vbCrLf

      ' output frequency values--ignore element 0                                
      For i = 1 To frequency.GetUpperBound(0)
         displayTextBox.Text &= i & vbTab & frequency(i) & 
            vbTab & vbTab & String.Format("{0:P2}", 
            frequency(i) / total) & vbCrLf
      Next
   End Sub ' rollButton_Click

   ' display a single die image
   Sub DisplayDie(diePictureBox As PictureBox)
      Dim face As Integer = randomObject.Next(1, 7)

      ' retrieve specific die image from resources
      Dim pictureResource = My.Resources.ResourceManager.GetObject(
         String.Format("die{0}", face))

      ' convert pictureResource to image type and load into PictureBox
      diePictureBox.Image = CType(pictureResource, Image)

      frequency(face) += 1 ' increment appropriate frequency counter
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