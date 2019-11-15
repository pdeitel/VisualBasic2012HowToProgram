' Fig. 33.13: MainWindow.xaml.cs
' Code-behind file for the TV GUI.
'Imports Windows.UI.Xaml
'Imports Windows.UI.Xaml.Controls

Partial Public NotInheritable Class MainPage
   Inherits Page
   Private uri As Uri ' Uri for location of video in this project

   ' constructor
   Public Sub New()
      Me.InitializeComponent()

      ' set Uri for location of video in this project
      uri = New Uri(BaseUri, "Assets\Video\media.mp4")
   End Sub ' constructor

   ' turn "on" the TV
   Private Sub powerCheckBox_Checked(sender As Object,
      e As RoutedEventArgs) Handles powerCheckBox.Checked

      ' set the videoMediaElement's Source
      videoMediaElement.Source = uri

      ' enable play, pause, and stop buttons
      playRadioButton.IsEnabled = True
      pauseRadioButton.IsEnabled = True
      stopRadioButton.IsEnabled = True
   End Sub ' powerCheckBox_Checked

   ' turn "off" the TV
   Private Sub powerCheckBox_Unchecked(sender As Object,
      e As RoutedEventArgs) Handles powerCheckBox.Unchecked

      ' remove the videoMediaElement's source
      videoMediaElement.Source = Nothing

      ' disable and uncheck the play, pause, and stop buttons
      playRadioButton.IsChecked = False
      pauseRadioButton.IsChecked = False
      stopRadioButton.IsChecked = False
      playRadioButton.IsEnabled = False
      pauseRadioButton.IsEnabled = False
      stopRadioButton.IsEnabled = False
   End Sub ' powerCheckBox_Unchecked

   ' play the video
   Private Sub playRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles playRadioButton.Checked

      videoMediaElement.Play()
   End Sub ' playRadioButton_Checked

   ' pause the video
   Private Sub pauseRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles pauseRadioButton.Checked

      videoMediaElement.Pause()
   End Sub ' pauseRadioButton_Checked

   ' stop the video
   Private Sub stopRadioButton_Checked(sender As Object,
      e As RoutedEventArgs) Handles stopRadioButton.Checked

      videoMediaElement.[Stop]()
   End Sub ' stopRadioButton_Checked
End Class ' MainPage

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