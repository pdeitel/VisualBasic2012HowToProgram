' Fig. 15.22: ScaleImage.vb
' Displaying and resizing an image
Public Class ScaleImage
   Private imageValue As Image
   Private graphicsObject As Graphics

   ' load the image and obtain the Graphics object
   Private Sub ScaleImage_Load(sender As Object,
      e As EventArgs) Handles Me.Load

      Dim pictureResource =
         My.Resources.ResourceManager.GetObject("yellowflowers")

      imageValue = CType(pictureResource, Image)
      graphicsObject = Me.CreateGraphics()
   End Sub ' ScaleImage_Load

   ' get NumericUpDown values and use to size image
   Private Sub NumericUpDown_ValueChanged(sender As Object,
      e As EventArgs) _
      Handles widthNumericUpDown.ValueChanged,
         heightNumericUpDown.ValueChanged

      ' clear the Form then draw the image
      graphicsObject.Clear(Me.BackColor)
      graphicsObject.DrawImage(imageValue, 5, 5,
         widthNumericUpDown.Value, heightNumericUpDown.Value)
   End Sub ' NumericUpDown_ValueChanged
End Class ' ScaleImage


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
