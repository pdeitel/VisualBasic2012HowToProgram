' Fig. 15.13: LinesRectanglesOvals.vb
' Demonstrating lines, rectangels and ovals.
Public Class LinesRectanglesOvals
   ' override Form OnPaint method
   Protected Overrides Sub OnPaint(e As PaintEventArgs)
      MyBase.OnPaint(e) ' call base class's OnPaint

      ' get graphics object
      Dim g As Graphics = e.Graphics
      Dim brush As New SolidBrush(Color.Blue)
      Dim pen As New Pen(Color.Black)

      ' create filled rectangle
      g.FillRectangle(brush, 90, 30, 150, 90)

      ' draw lines to connect rectangles
      g.DrawLine(pen, 90, 30, 110, 40)
      g.DrawLine(pen, 90, 120, 110, 130)
      g.DrawLine(pen, 240, 30, 260, 40)
      g.DrawLine(pen, 240, 120, 260, 130)

      ' draw top rectangle
      g.DrawRectangle(pen, 110, 40, 150, 90)

      ' set brush to red
      brush.Color = Color.Red

      ' draw base Ellipse
      g.FillEllipse(brush, 280, 75, 100, 50)

      ' draw connecting lines
      g.DrawLine(pen, 380, 55, 380, 100)
      g.DrawLine(pen, 280, 55, 280, 100)

      ' draw Ellipse outline
      g.DrawEllipse(pen, 280, 30, 100, 50)
   End Sub ' OnPaint
End Class ' LinesRectanglesOvals

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