' Fig. 14.18: Painter.vb
' Using the mouse to draw on a Form.
Public Class Painter
   Private shouldPaint As Boolean = False ' determines whether to paint

   ' should paint when mouse button is pressed down
   Private Sub Painter_MouseDown(sender As Object,
      e As MouseEventArgs) Handles MyBase.MouseDown
      shouldPaint = True
   End Sub ' Painter_MouseDown

   ' stop painting when mouse button is released
   Private Sub Painter_MouseUp(sender As Object,
      e As MouseEventArgs) Handles MyBase.MouseUp
      shouldPaint = False
   End Sub ' Painter_MouseUp

   ' draw circle whenever mouse moves with its button held down 
   Private Sub Painter_MouseMove(sender As Object,
      e As MouseEventArgs) Handles MyBase.MouseMove
      ' check if mouse button is being pressed                  
      If (shouldPaint) Then
         ' draw a circle where the mouse pointer is present     
         Using g As Graphics = CreateGraphics()
            g.FillEllipse(
               New SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4)
         End Using
      End If
   End Sub ' Painter_MouseMove                                    
End Class ' Painter


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