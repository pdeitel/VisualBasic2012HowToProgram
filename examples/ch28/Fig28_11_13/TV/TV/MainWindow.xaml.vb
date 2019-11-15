' Fig. 28.13: MainWindow.xaml.vb
' TV GUI showing the versatility of WPF customization
Class MainWindow

   ' turns "on" the TV
   Private Sub powerCheckBox_Checked(ByVal sender As Object,
      ByVal e As RoutedEventArgs) Handles powerCheckBox.Checked

      ' render the reflection visible
      reflectionRectangle.Visibility = Windows.Visibility.Visible

      ' enable play, pause, and stop buttons
      playRadioButton.IsEnabled = True
      pauseRadioButton.IsEnabled = True
      stopRadioButton.IsEnabled = True
   End Sub ' powerCheckBox_Checked

   ' turns "off" the TV
   Private Sub powerCheckBox_Unchecked(ByVal sender As Object,
      ByVal e As RoutedEventArgs) Handles powerCheckBox.Unchecked

      videoMediaElement.Close() ' shut down the screen

      ' hide the reflection
      reflectionRectangle.Visibility = Windows.Visibility.Hidden

      ' disable the play, pause, and stop buttons
      playRadioButton.IsChecked = False
      pauseRadioButton.IsChecked = False
      stopRadioButton.IsChecked = False
      playRadioButton.IsEnabled = False
      pauseRadioButton.IsEnabled = False
      stopRadioButton.IsEnabled = False
   End Sub ' powerCheckBox_Unchecked

   ' plays the video
   Private Sub playRadioButton_Checked(ByVal sender As Object,
      ByVal e As RoutedEventArgs) Handles playRadioButton.Checked

      videoMediaElement.Play()
   End Sub ' playRadioButton_Checked

   ' pauses the video
   Private Sub pauseRadioButton_Checked(ByVal sender As Object,
      ByVal e As RoutedEventArgs) Handles pauseRadioButton.Checked

      videoMediaElement.Pause()
   End Sub ' pauseRadioButton_Checked

   ' stops the video
   Private Sub stopRadioButton_Checked(ByVal sender As Object,
      ByVal e As RoutedEventArgs) Handles stopRadioButton.Checked

      videoMediaElement.Stop()
   End Sub ' stopRadioButton_Checked
End Class

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