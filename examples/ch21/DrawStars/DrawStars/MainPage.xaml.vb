' Fig. 21.7: MainPage.xaml.vb
' Applying transforms to a Polygon.
Imports Windows.UI.Xaml.Shapes
Imports Windows.UI

Partial Public NotInheritable Class MainPage
   Inherits Page
   Private random As New Random() ' for random color values
   Private star As New Polygon() ' used to define star

   ' constructor
   Public Sub New()
      Me.InitializeComponent()

      ' determine horizonal center of screen 
      Dim centerX As Integer = Convert.ToInt32(Window.Current.Bounds.Width / 2)

      ' set initial star points
      star.Points.Add(New Point(centerX, 50))
      star.Points.Add(New Point(centerX + 12, 86))
      star.Points.Add(New Point(centerX + 44, 86))
      star.Points.Add(New Point(centerX + 18, 104))
      star.Points.Add(New Point(centerX + 28, 146))
      star.Points.Add(New Point(centerX, 122))
      star.Points.Add(New Point(centerX - 28, 146))
      star.Points.Add(New Point(centerX - 18, 104))
      star.Points.Add(New Point(centerX - 44, 86))
      star.Points.Add(New Point(centerX - 12, 86))

      RotateAndDrawStars() ' draw circle of stars
   End Sub ' New

   ' draw circle of stars in random colors
   Private Sub RotateAndDrawStars()
      mainCanvas.Children.Clear() ' remove previous stars

      ' create 18 stars
      For count As Integer = 0 To 17
         Dim newStar As New Polygon() ' create a polygon object

         ' copy star.Points collection into newStar.Points
         For Each point In star.Points
            newStar.Points.Add(point)
         Next

         Dim colorValues As Byte() = New Byte(2) {} ' create a Byte array
         random.NextBytes(colorValues) ' create three random values

         ' creates a random color brush
         newStar.Fill = New SolidColorBrush(Color.FromArgb(
            255, colorValues(0), colorValues(1), colorValues(2)))

         ' apply a rotation to the shape used to rotate the star
         Dim rotate As New RotateTransform()
         rotate.CenterX = Window.Current.Bounds.Width / 2
         rotate.CenterY = Window.Current.Bounds.Height / 2
         rotate.Angle = count * 20
         newStar.RenderTransform = rotate
         mainCanvas.Children.Add(newStar)
      Next
   End Sub ' RotateAndDrawStars

   ' redraws stars in new colors each time user touches the canvas
   Private Sub mainCanvas_PointerPressed(sender As Object,
      e As PointerRoutedEventArgs)
      RotateAndDrawStars()
   End Sub ' mainCanvas_PointerPressed
End Class ' end class MainPage


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