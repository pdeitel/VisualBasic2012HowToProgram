' Fig. 27.16: MainWindow.xaml.vb
' Color chooser app showing the use of styles (code-behind).
Class MainWindow

   ' runs on initialization; sets the initial value of alpha
   Private Sub Init(sender As Object, e As EventArgs) _
      Handles Me.Initialized
      alphaSlider.Value = 255
   End Sub 'Init

   ' handles the ValueChanged event for the Sliders
   Private Sub slider_ValueChanged(sender As Object,
      e As RoutedPropertyChangedEventArgs(Of Double))

      ' generate new color
      Dim backgroundColor As New SolidColorBrush()
      backgroundColor.Color = Color.FromArgb(CByte(alphaSlider.Value),
         CByte(redSlider.Value), CByte(greenSlider.Value),
         CByte(blueSlider.Value))

      ' set colorLabel's background to new color
      colorLabel.Background = backgroundColor
   End Sub ' slider_ValueChanged
End Class ' MainWindow

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