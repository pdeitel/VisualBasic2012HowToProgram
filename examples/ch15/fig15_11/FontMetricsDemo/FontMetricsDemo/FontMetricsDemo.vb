' Fig 15.11: FontMetricsDemo.vb
' Displaying font metric information
Public Class FontMetricsDemo
   ' displays font information
   Protected Overrides Sub OnPaint(e As PaintEventArgs)
      MyBase.OnPaint(e) ' call base class's OnPaint
      Dim graphicsObject As Graphics = e.Graphics
      Dim brush As New SolidBrush(Color.DarkBlue)

      ' Arial font metrics
      Dim arial As New Font("Arial", 10)
      Dim family As FontFamily = arial.FontFamily

      ' display Arial font metrics
      graphicsObject.DrawString("Current Font: " &
         arial.ToString(), arial, brush, 10, 10)

      graphicsObject.DrawString("Ascent: " &
         family.GetCellAscent(FontStyle.Regular), arial, brush, 10, 30)

      graphicsObject.DrawString("Descent: " &
         family.GetCellDescent(FontStyle.Regular), arial, brush, 10, 50)

      graphicsObject.DrawString("Height: " &
         family.GetEmHeight(FontStyle.Regular), arial, brush, 10, 70)

      graphicsObject.DrawString("Leading: " &
         family.GetLineSpacing(FontStyle.Regular), arial, brush, 10, 90)

      ' display Sans Serif font metrics
      Dim sanSerif As New Font("Microsoft Sans Serif",
         12, FontStyle.Italic)
      family = sanSerif.FontFamily

      graphicsObject.DrawString("Current Font: " &
         sanSerif.ToString(), sanSerif, brush, 10, 130)

      graphicsObject.DrawString("Ascent: " &
         family.GetCellAscent(FontStyle.Regular),
         sanSerif, brush, 10, 150)

      graphicsObject.DrawString("Descent: " &
         family.GetCellDescent(FontStyle.Regular),
         sanSerif, brush, 10, 170)

      graphicsObject.DrawString("Height: " &
         family.GetEmHeight(FontStyle.Regular), sanSerif, brush, 10, 190)

      graphicsObject.DrawString("Leading: " &
         family.GetLineSpacing(FontStyle.Regular),
         sanSerif, brush, 10, 210)
   End Sub ' OnPaint
End Class ' FontMetricsDemo

'**************************************************************************
'* (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
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
