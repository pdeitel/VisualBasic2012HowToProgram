' Fig. 15.17: DrawArcs.vb
' Drawing various arcs on a Form.
Public Class DrawArcs
   ' draw arcs
   Private Sub DrawArcs_Paint(sender As Object,
      e As PaintEventArgs) Handles Me.Paint
      ' get graphics object
      Dim graphicsObject As Graphics = e.Graphics
      Dim rectangle1 As New Rectangle(15, 35, 80, 80)
      Dim brush1 As New SolidBrush(Color.Firebrick)
      Dim pen1 As New Pen(brush1, 1)
      Dim brush2 As New SolidBrush(Color.DarkBlue)
      Dim pen2 As New Pen(brush2, 1)

      ' start at 0 and sweep 360 degrees
      graphicsObject.DrawRectangle(pen1, rectangle1)
      graphicsObject.DrawArc(pen2, rectangle1, 0, 360)

      ' start at 0 and sweep 110 degrees
      rectangle1.Location = New Point(100, 35)
      graphicsObject.DrawRectangle(pen1, rectangle1)
      graphicsObject.DrawArc(pen2, rectangle1, 0, 110)

      ' start at 0 and sweep -270 degrees
      rectangle1.Location = New Point(185, 35)
      graphicsObject.DrawRectangle(pen1, rectangle1)
      graphicsObject.DrawArc(pen2, rectangle1, 0, -270)

      ' start at 0 and sweep 360 degrees
      rectangle1.Location = New Point(15, 120)
      rectangle1.Size = New Size(80, 40)
      graphicsObject.DrawRectangle(pen1, rectangle1)
      graphicsObject.FillPie(brush2, rectangle1, 0, 360)

      ' start at 270 and sweep -90 degrees
      rectangle1.Location = New Point(100, 120)
      graphicsObject.DrawRectangle(pen1, rectangle1)
      graphicsObject.FillPie(brush2, rectangle1, 270, -90)

      ' start at 0 and sweep -270 degrees
      rectangle1.Location = New Point(185, 120)
      graphicsObject.DrawRectangle(pen1, rectangle1)
      graphicsObject.FillPie(brush2, rectangle1, 0, -270)
   End Sub ' DrawArcs_Paint
End Class ' DrawArcs

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