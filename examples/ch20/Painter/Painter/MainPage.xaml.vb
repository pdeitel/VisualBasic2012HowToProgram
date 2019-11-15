' Fig. 20.13: MainWindow.xaml.vb
' Code-behind for MainWindow.xaml.
Imports Windows.UI ' Colors class with predefined colors 
Imports Windows.UI.Input ' types related to event handling
Imports Windows.UI.Xaml ' types that support XAML
Imports Windows.UI.Xaml.Controls ' XAML GUI controls and supporting types
Imports Windows.UI.Xaml.Input ' types related to event handling
Imports Windows.UI.Xaml.Media ' graphics and multimedia capabilities
Imports Windows.UI.Xaml.Shapes ' Ellipse class and other shapes

Partial Public NotInheritable Class MainPage
   Inherits Page

   Private diameter As Sizes = Sizes.MEDIUM ' set diameter of circle
   Private brushColor As New SolidColorBrush(Colors.Black) ' drawing color
   Private shouldPaint As Boolean = False ' specify whether to paint

   Private Enum Sizes ' size constants for diameter of the circle
      SMALL = 5
      MEDIUM = 15
      LARGE = 30
   End Enum

   ' paints a circle on the Canvas
   Private Sub PaintCircle(circleColor As Brush, point As PointerPoint)
      Dim newEllipse As New Ellipse() ' create an Ellipse   
      newEllipse.Fill = circleColor ' set Ellipse's color      
      newEllipse.Width = Convert.ToInt32(diameter) ' horizontal diameter
      newEllipse.Height = Convert.ToInt32(diameter) ' vertical diameter 

      ' set the Ellipse's position            
      Canvas.SetTop(newEllipse, point.Position.Y)
      Canvas.SetLeft(newEllipse, point.Position.X)

      paintCanvas.Children.Add(newEllipse)
   End Sub ' end method PaintCircle

   ' user chose red 
   Private Sub redRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles redRadioButton.Checked
      brushColor = New SolidColorBrush(Colors.Red)
   End Sub ' end method redRadioButton_Checked

   ' user chose blue
   Private Sub blueRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles blueRadioButton.Checked
      brushColor = New SolidColorBrush(Colors.Blue)
   End Sub ' end method blueRadioButton_Checked

   ' user chose green
   Private Sub greenRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles greenRadioButton.Checked
      brushColor = New SolidColorBrush(Colors.Green)
   End Sub ' end method greenRadioButton_Checked

   ' user chose black
   Private Sub blackRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles blackRadioButton.Checked
      brushColor = New SolidColorBrush(Colors.Black)
   End Sub ' end method blackRadioButton_Checked

   ' user chose small brush size
   Private Sub smallRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles smallRadioButton.Checked
      diameter = Sizes.SMALL
   End Sub ' end method smallRadioButton_Checked

   ' user chose medium brush size
   Private Sub mediumRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles mediumRadioButton.Checked
      diameter = Sizes.MEDIUM
   End Sub ' end method mediumRadioButton_Checked

   ' user chose large brush size
   Private Sub largeRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles largeRadioButton.Checked
      diameter = Sizes.LARGE
   End Sub ' end method largeRadioButton_Checked

   ' remove last ellipse that was added to the paintCanvas
   Private Sub undoButton_Click(sender As Object,
      e As RoutedEventArgs) Handles undoButton.Click
      Dim count As Integer = paintCanvas.Children.Count

      ' if there are any shapes on Canvas remove the last one added
      If count > 0 Then
         paintCanvas.Children.RemoveAt(count - 1)
      End If
   End Sub ' end method undoButton_Click

   ' deletes the entire drawing
   Private Sub deleteButton_Click(sender As Object,
      e As RoutedEventArgs) Handles deleteButton.Click
      paintCanvas.Children.Clear() ' clear the canvas
   End Sub ' end method deleteButton_Click

   ' handles paintCanvas's PointerPressed event
   Private Sub paintCanvas_PointerPressed(sender As Object,
      e As PointerRoutedEventArgs) Handles paintCanvas.PointerPressed
      shouldPaint = True ' the user is drawing
   End Sub ' end method paintCanvas_PointerPressed

   ' handles paintCanvas's PointerMoved event
   Private Sub paintCanvas_PointerMoved(sender As Object,
      e As PointerRoutedEventArgs) Handles paintCanvas.PointerMoved

      If shouldPaint Then
         ' draw a circle of selected color at current pointer position
         Dim pointerPosition As PointerPoint =
            e.GetCurrentPoint(paintCanvas)
         PaintCircle(brushColor, pointerPosition)
      End If
   End Sub ' end method paintCanvas_PointerMoved

   ' handles paintCanvas's PointerReleased event
   Private Sub paintCanvas_PointerReleased(sender As Object,
      e As PointerRoutedEventArgs) Handles paintCanvas.PointerReleased
      shouldPaint = False ' the user finished drawing
   End Sub ' end method paintCanvas_PointerReleased

   ' handles paintCanvas's PointerCanceled event
   Private Sub paintCanvas_PointerCanceled(sender As Object,
      e As PointerRoutedEventArgs) Handles paintCanvas.PointerCanceled
      shouldPaint = False ' the user finished drawing
   End Sub ' end method paintCanvas_PointerCanceled

   ' handles paintCanvas's PointerCaptureLost event
   Private Sub paintCanvas_PointerCaptureLost(sender As Object,
      e As PointerRoutedEventArgs) Handles paintCanvas.PointerCaptureLost
      shouldPaint = False ' the user finished drawing
   End Sub ' end method paintCanvas_PointerCaptureLost

   ' handles paintCanvas's PointerExited event
   Private Sub paintCanvas_PointerExited(sender As Object,
      e As PointerRoutedEventArgs) Handles paintCanvas.PointerExited
      shouldPaint = False ' the user finished drawing
   End Sub ' end method paintCanvas_PointerExited
End Class ' end class MainPage

'*************************************************************************
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
' *************************************************************************
