' Fig. 14.47: AnimationDemo.vb
' Animating images with a Timer component.
Public Class AnimationDemo
   Private currentImage As Integer = 0 ' current image number
   Private Const TOTAL_IMAGES = 30 ' total number of images

   ' display next image
   Private Sub animationTimer_Tick(sender As Object,
      e As EventArgs) Handles animationTimer.Tick

      ' get the resource representing the image
      Dim pictureResource =
         My.Resources.ResourceManager.GetObject("deitel" & currentImage)

      ' convert pictureResource to type Image and load into PictureBox
      logoPictureBox.Image = CType(pictureResource, Image)

      ' increment currentImage
      currentImage = (currentImage + 1) Mod TOTAL_IMAGES
   End Sub ' animationTimer_Tick
End Class ' AnimationDemo


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