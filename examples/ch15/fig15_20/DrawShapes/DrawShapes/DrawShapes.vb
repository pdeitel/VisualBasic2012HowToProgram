' Fig. 15.20: DrawShapes.vb
' Drawing various shapes on a Form.
Imports System.Drawing.Drawing2D

Public Class DrawShapes
   ' draw various shapes on Form
   Private Sub DrawShapes_Paint(sender As Object,
      e As PaintEventArgs) Handles Me.Paint

      Dim graphicsObject As Graphics = e.Graphics

      ' ellipse rectangle and gradient brush
      Dim drawArea1 As New Rectangle(5, 35, 30, 100)
      Dim linearBrush As New LinearGradientBrush(drawArea1, Color.Blue,
         Color.Yellow, LinearGradientMode.ForwardDiagonal)

      ' draw ellipse filled with a blue-yellow gradient
      graphicsObject.FillEllipse(linearBrush, 5, 30, 65, 100)

      ' pen and location for red outline rectangle
      Dim thickRedPen As New Pen(Color.Red, 10)
      Dim drawArea2 As New Rectangle(80, 30, 65, 100)

      ' draw thick rectangle outline in red
      graphicsObject.DrawRectangle(thickRedPen, drawArea2)

      ' bitmap texture
      Dim textureBitmap As New Bitmap(10, 10)

      ' get bitmap graphics
      Dim graphicsObject2 As Graphics = Graphics.FromImage(textureBitmap)

      ' brush and pen used throughout program
      Dim solidColorBrush As New SolidBrush(Color.Red)
      Dim coloredPen As New Pen(solidColorBrush)

      ' fill textureBitmap with yellow
      solidColorBrush.Color = Color.Yellow
      graphicsObject2.FillRectangle(solidColorBrush, 0, 0, 10, 10)

      ' draw small black rectangle in textureBitmap
      coloredPen.Color = Color.Black
      graphicsObject2.DrawRectangle(coloredPen, 1, 1, 6, 6)

      ' draw small blue rectangle in textureBitmap
      solidColorBrush.Color = Color.Blue
      graphicsObject2.FillRectangle(solidColorBrush, 1, 1, 3, 3)

      ' draw small red square in textureBitmap
      solidColorBrush.Color = Color.Red
      graphicsObject2.FillRectangle(solidColorBrush, 4, 4, 3, 3)

      ' create textured brush and 
      ' display textured rectangle
      Dim texturedBrush As New TextureBrush(textureBitmap)
      graphicsObject.FillRectangle(texturedBrush, 155, 30, 75, 100)

      ' draw pie-shaped arc in white
      coloredPen.Color = Color.White
      coloredPen.Width = 6
      graphicsObject.DrawPie(coloredPen, 240, 30, 75, 100, 0, 270)

      ' draw lines in green and yellow
      coloredPen.Color = Color.Green
      coloredPen.Width = 5
      graphicsObject.DrawLine(coloredPen, 395, 30, 320, 150)

      ' draw a rounded, dashed yellow line
      coloredPen.Color = Color.Yellow
      coloredPen.DashCap = DashCap.Round
      coloredPen.DashStyle = DashStyle.Dash
      graphicsObject.DrawLine(coloredPen, 320, 30, 395, 150)
   End Sub ' DrawShapes_Paint
End Class ' DrawShapes

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
