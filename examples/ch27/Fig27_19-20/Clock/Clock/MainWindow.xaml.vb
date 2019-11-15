' Fig. 27.20: MainWindow.xaml.vb
' Creating custom windows and using timers (code-behind).
Class MainWindow

   ' create a timer to control clock
   Private WithEvents timer As New Windows.Threading.DispatcherTimer()

   ' enable timer when window is loaded
   Private Sub clockWindow_Loaded(sender As Object,
      e As RoutedEventArgs) Handles clockWindow.Loaded

      timer.Interval = New TimeSpan(0, 0, 1) ' tick every second
      timer.IsEnabled = True ' enable timer                     
   End Sub ' clockWindow_Loaded

   ' drag Window when the left mouse button is held down
   Private Sub clockWindow_MouseLeftButtonDown(sender As Object,
      e As MouseButtonEventArgs) _
      Handles clockWindow.MouseLeftButtonDown

      Me.DragMove() ' moves the window
   End Sub ' clockWindow_MouseLeftButtonDown

   ' update the time every time the timer ticks
   Private Sub timer_Tick(sender As Object,
      e As System.EventArgs) Handles Timer.Tick

      Dim currentTime As Date = Date.Now ' get the current time

      ' display the time as hh:mm:ss
      timeTextBox.Text = currentTime.ToLongTimeString()
   End Sub ' timer_Tick
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