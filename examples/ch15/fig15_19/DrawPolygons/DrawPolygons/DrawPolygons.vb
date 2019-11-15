' Fig. 15.19: DrawPolygons.vb
' Demonstrating polygons.
Public Class DrawPolygons
   ' Paint event handler
   Private Sub DrawPolygons_Paint(sender As Object,
      e As PaintEventArgs) Handles Me.Paint

      ' get graphics object 
      Dim graphicsObject As Graphics = e.Graphics

      Dim points1() As Point = {New Point(20, 20), New Point(10, 150),
         New Point(100, 100), New Point(50, 75)}
      Dim points2() As Point = {New Point(120, 20), New Point(110, 150),
         New Point(200, 100), New Point(150, 75)}
      Dim points3() As Point = {New Point(220, 20), New Point(210, 150),
         New Point(300, 100), New Point(250, 75)}

      ' initialize default pen and brush
      Dim pen As New Pen(Color.DarkBlue)
      Dim brush As New SolidBrush(Color.DarkBlue)

      graphicsObject.DrawLines(pen, points1)
      graphicsObject.DrawPolygon(pen, points2)
      graphicsObject.FillPolygon(brush, points3)
   End Sub ' DrawPolygons_Paint
End Class ' DrawPolygons

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
