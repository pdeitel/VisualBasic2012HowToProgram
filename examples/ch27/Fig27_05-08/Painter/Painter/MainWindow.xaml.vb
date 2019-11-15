' Fig. 27.8: MainWindow.xaml.vb
' Code-behind class for Painter.
Class MainWindow
   Private diameter As Integer = 8 ' set diameter of circle
   Private brushColor As Brush = Brushes.Black ' set the color to draw in
   Private shouldErase As Boolean = False ' specify whether to erase
   Private shouldPaint As Boolean = False ' specify whether to paint

   Private Enum Sizes ' size constants for diameter of the circle
      SMALL = 4
      MEDIUM = 8
      LARGE = 10
   End Enum

   ' paints a circle on the Canvas
   Private Sub PaintCircle(circleColor As Brush,
      position As Point)

      Dim newEllipse As Ellipse = New Ellipse() ' create an Ellipse

      newEllipse.Fill = circleColor ' set Ellipse's color          
      newEllipse.Width = diameter ' set its horizontal diameter    
      newEllipse.Height = diameter ' set its vertical diameter     

      Canvas.SetTop(newEllipse, position.Y) ' set its distance from top  
      Canvas.SetLeft(newEllipse, position.X) ' set its distance from left

      paintCanvas.Children.Add(newEllipse) ' add it to the Canvas
   End Sub ' PaintCircle

   ' handles paintCanvas's MouseLeftButtonDown event
   Private Sub paintCanvas_MouseLeftButtonDown(sender As Object,
      e As MouseButtonEventArgs) _
      Handles paintCanvas.MouseLeftButtonDown

      shouldPaint = True ' OK to draw on the Canvas
   End Sub ' paintCanvas_MouseLeftButtonDown

   ' handles paintCanvas's MouseLeftButtonUp event
   Private Sub paintCanvas_MouseLeftButtonUp(sender As Object,
      e As MouseButtonEventArgs) _
      Handles paintCanvas.MouseLeftButtonUp

      shouldPaint = False ' do not draw on the Canvas
   End Sub ' paintCanvas_MouseLeftButtonUp

   ' handles paintCanvas's MouseMove event
   Private Sub paintCanvas_MouseMove(sender As Object,
      e As MouseEventArgs) _
      Handles paintCanvas.MouseMove

      If shouldPaint = True Then
         ' draw a circle in the selected color at current mouse position
         Dim mousePosition As Point = e.GetPosition(paintCanvas)
         PaintCircle(brushColor, mousePosition)
      ElseIf shouldErase = True Then
         ' erase by drawing circles of the Canvas's background color
         Dim mousePosition As Point = e.GetPosition(paintCanvas)
         PaintCircle(paintCanvas.Background, mousePosition)
      End If
   End Sub ' paintCanvas_MouseMove

   ' handles paintCanvas's MouseRightButtonDown event
   Private Sub paintCanvas_MouseRightButtonDown(sender As Object,
      e As MouseButtonEventArgs) _
      Handles paintCanvas.MouseRightButtonDown

      shouldErase = True ' OK to erase the Canvas
   End Sub ' paintCanvas_MouseRightButtonDown

   ' handles paintCanvas's MouseRightButtonUp event
   Private Sub paintCanvas_MouseRightButtonUp(sender As Object,
      e As MouseButtonEventArgs) _
      Handles paintCanvas.MouseRightButtonUp

      shouldErase = False ' do not erase the Canvas
   End Sub ' paintCanvas_MouseRightButtonUp

   ' handles Red RadioButton's Checked event
   Private Sub redRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles redRadioButton.Checked

      brushColor = Brushes.Red
   End Sub ' redRadioButton_Checked

   ' handles Blue RadioButton's Checked event
   Private Sub blueRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles blueRadioButton.Checked

      brushColor = Brushes.Blue
   End Sub ' blueRadioButton_Checked

   ' handles Green RadioButton's Checked event
   Private Sub greenRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles greenRadioButton.Checked

      brushColor = Brushes.Green
   End Sub ' greenRadioButton_Checked

   ' handles Black RadioButton's Checked event
   Private Sub blackRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles blackRadioButton.Checked

      brushColor = Brushes.Black
   End Sub ' blackRadioButton_Checked

   ' handles Small RadioButton's Checked event
   Private Sub smallRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles smallRadioButton.Checked

      diameter = Sizes.SMALL
   End Sub ' smallRadioButton_Checked

   ' handles Medium RadioButton's Checked event
   Private Sub mediumRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles mediumRadioButton.Checked

      diameter = Sizes.MEDIUM
   End Sub ' mediumRadioButton_Checked

   ' handles Large RadioButton's Checked event
   Private Sub largeRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles largeRadioButton.Checked

      diameter = Sizes.LARGE
   End Sub ' largeRadioButton_Checked

   ' handles Undo Button's Click event
   Private Sub undoButton_Click(sender As Object,
      e As RoutedEventArgs) Handles undoButton.Click

      ' if there are any shapes on the canvas
      If paintCanvas.Children.Count > 0 Then
         ' remove the last one that was added
         paintCanvas.Children.RemoveAt(paintCanvas.Children.Count - 1)
      End If
   End Sub ' undoButton_Click

   ' handles Clear Button's Click event
   Private Sub clearButton_Click(sender As Object,
      e As RoutedEventArgs) Handles clearButton.Click

      paintCanvas.Children.Clear() ' clear the canvas
   End Sub ' clearButton_Click
End Class ' MainWindow

' **************************************************************************
' * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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