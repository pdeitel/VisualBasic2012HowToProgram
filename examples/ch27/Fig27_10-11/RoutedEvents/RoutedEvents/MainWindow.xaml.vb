' Fig. 27.11: MainWindow.xaml.vb
' Routed-events example (code-behind).
Class MainWindow
   Private bubblingEventStep As Integer = 1 ' step counter for Bubbling
   Private tunnelingLogText As String = "" ' temporary log for Tunneling
   Private tunnelingEventStep As Integer = 1 ' step counter for Tunneling

   ' MouseUp is a bubbling event
   Private Sub Bubbling(sender As Object,
      e As MouseButtonEventArgs) _
      Handles bubblingLabel.MouseLeftButtonUp,
         bubblingGroupBox.MouseLeftButtonUp

      ' execution goes from child to parent, starting at the source
      If e.Source.Equals(sender) Then
         logTextBox.Clear() ' clear logTextBox
         bubblingEventStep = 1 ' reset counter
         logTextBox.Text = "This is a bubbling event:" & vbCrLf
      End If

      ' append step number and sender
      logTextBox.Text = logTextBox.Text & "(" & bubblingEventStep &
         "):" & CType(sender, Control).Name & vbCrLf
      bubblingEventStep += 1 ' increment counter
   End Sub ' Bubbling

   ' PreviewMouseUp is a tunneling event
   Private Sub Tunneling(sender As Object,
      e As MouseButtonEventArgs) _
      Handles tunnelingLabel.PreviewMouseLeftButtonUp,
         tunnelingGroupBox.PreviewMouseLeftButtonUp

      ' append step number and sender
      tunnelingLogText = tunnelingLogText & "(" & tunnelingEventStep &
         "): " & CType(sender, Control).Name & vbCrLf
      tunnelingEventStep += 1 ' increment counter

      ' execution goes from parent to child, ending with the source
      If e.Source.Equals(sender) Then
         tunnelingLogText = "This is a tunneling event:" & vbCrLf &
         tunnelingLogText
         logTextBox.Text = tunnelingLogText ' set logTextBox text
         tunnelingLogText = "" ' clear temporary log
         tunnelingEventStep = 1 ' reset counter
      End If
   End Sub ' Tunneling
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