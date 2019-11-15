' Fig. 15.8 FontDemo.vb
' Fonts and FontStyles.
Public Class FontDemo
   ' demonstrate various font and style settings
   Protected Overrides Sub OnPaint(e As PaintEventArgs)
      MyBase.OnPaint(e) ' call base class's OnPaint
      Dim graphicsObject As Graphics = e.Graphics
      Dim brush As New SolidBrush(Color.DarkBlue)

      ' arial, 12 pt bold
      Dim style As FontStyle = FontStyle.Bold
      Dim arial As New Font("Arial", 12, style)

      ' times new roman, 12 pt regular
      style = FontStyle.Regular
      Dim timesNewRoman As New Font("Times New Roman", 12, style)

      ' courier new, 16 pt bold and italic
      style = FontStyle.Bold Or FontStyle.Italic
      Dim courierNew As New Font("Courier New", 16, style)

      ' tahoma, 18 pt strikeout
      style = FontStyle.Strikeout
      Dim tahoma As New Font("Tahoma", 18, style)

      graphicsObject.DrawString(arial.Name &
         " 12 point bold.", arial, brush, 10, 10)

      graphicsObject.DrawString(timesNewRoman.Name &
         " 12 point plain.", timesNewRoman, brush, 10, 30)

      graphicsObject.DrawString(courierNew.Name &
         " 16 point bold and italic.", courierNew, brush, 10, 50)

      graphicsObject.DrawString(tahoma.Name &
         " 18 point strikeout.", tahoma, brush, 10, 70)
   End Sub ' OnPaint
End Class ' FontDemo

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
