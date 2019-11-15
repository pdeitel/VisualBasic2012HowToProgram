' Fig. 28.9: MainWindow.xaml.vb
' Applying transforms to a Polygon.
Class MainWindow
   Public Sub New()
      InitializeComponent()

      Dim random As New Random() ' get random values for colors

      ' create 18 more stars
      For count As Integer = 0 To 18
         Dim newStar As New Polygon() ' create a polygon object
         newStar.Points = star.Points ' copy the points collection

         Dim colorValues(3) As Byte ' create a Byte array
         random.NextBytes(colorValues) ' create four random values
         newStar.Fill = New SolidColorBrush(Color.FromArgb(
            colorValues(0), colorValues(1), colorValues(2),
            colorValues(3))) ' creates a random color brush

         ' apply a rotation to the shape
         Dim rotate As New RotateTransform(count * 20, 150, 150)
         newStar.RenderTransform = rotate
         mainCanvas.Children.Add(newStar)
      Next
   End Sub
End Class

'/*************************************************************************
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
'*************************************************************************/