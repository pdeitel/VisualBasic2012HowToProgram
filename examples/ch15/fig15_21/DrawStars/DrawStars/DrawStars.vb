' Fig. 15.21: DrawStars.vb
' Using paths to draw stars on the Form.
Imports System.Drawing.Drawing2D

Public Class DrawStars
   ' create path and draw stars along it
   Private Sub DrawStars_Paint(sender As Object,
      e As PaintEventArgs) Handles Me.Paint

      Dim graphicsObject As Graphics = e.Graphics
      Dim random As New Random()
      Dim brush As New SolidBrush(Color.DarkMagenta)

      ' x and y points of the path
      Dim xPoints() As Integer = {55, 67, 109, 73, 83, 55, 27, 37, 1, 43}
      Dim yPoints() As Integer = {0, 36, 36, 54, 96, 72, 96, 54, 36, 36}

      ' create graphics path for star
      Dim star As New GraphicsPath()

      ' create a star from a series of points
      For i As Integer = 0 To 8 Step 2
         star.AddLine(xPoints(i), yPoints(i),
            xPoints(i + 1), yPoints(i + 1))
      Next

      star.CloseFigure() ' close the shape

      ' translate the origin to (150, 150)
      graphicsObject.TranslateTransform(150, 150)

      ' rotate the origin and draw the stars in random colors
      For i As Integer = 1 To 18
         graphicsObject.RotateTransform(20)

         brush.Color = Color.FromArgb(random.Next(200, 255),
            random.Next(255), random.Next(255), random.Next(255))

         graphicsObject.FillPath(brush, star)
      Next
   End Sub ' DrawStars_Paint
End Class ' DrawStars

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
