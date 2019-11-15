' Fig 15.5: ShowColors.vb
' Color value and alpha demonstration.
Public Class ShowColors
   ' color for back rectangle
   Private backgroundColor As Color = Color.Wheat

   ' color for front rectangle
   Private foregroundColor As Color = Color.FromArgb(100, 0, 0, 255)

   ' override Form's OnPaint method
   Protected Overrides Sub OnPaint(e As PaintEventArgs)
      MyBase.OnPaint(e) ' call base class's OnPaint
      Dim graphicsObject As Graphics = e.Graphics ' get graphics object
      Dim textBrush As New SolidBrush(Color.Black) ' create text brush
      Dim brush As New SolidBrush(Color.White) ' create solid brush

      ' draw white background
      graphicsObject.FillRectangle(brush, 4, 4, 275, 180)

      ' display name of backgroundColor
      graphicsObject.DrawString(
         backgroundColor.Name, Me.Font, textBrush, 40, 5)

      ' set brush color and display back rectangle
      brush.Color = backgroundColor
      graphicsObject.FillRectangle(brush, 45, 20, 150, 120)

      ' display Argb values of front color
      graphicsObject.DrawString("Alpha: " & foregroundColor.A &
         " Red: " & foregroundColor.R & " Green: " &
         foregroundColor.G & " Blue: " & foregroundColor.B, Me.Font,
         textBrush, 55, 165)

      ' set brush color and display front rectangle
      brush.Color = foregroundColor
      graphicsObject.FillRectangle(brush, 65, 35, 170, 130)
   End Sub ' OnPaint

   ' change back rectangle's color
   Private Sub setColorNameButton_Click(sender As Object,
      e As EventArgs) Handles setColorNameButton.Click
      ' set backColor to color specified in text box
      backgroundColor = Color.FromName(colorNameTextBox.Text)
      Invalidate() ' refresh Form
   End Sub ' setColorNameButton_Click

   ' change front rectangle's color
   Private Sub setColorValueButton_Click(sender As Object,
      e As EventArgs) Handles setColorValueButton.Click
      ' obtain new front color from text boxes
      foregroundColor = Color.FromArgb(
         Convert.ToInt32(alphaTextBox.Text),
         Convert.ToInt32(redTextBox.Text),
         Convert.ToInt32(greenTextBox.Text),
         Convert.ToInt32(blueTextBox.Text))
      Invalidate() ' refresh Form   
   End Sub '  setColorValueButton_Click
End Class ' ShowColors

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