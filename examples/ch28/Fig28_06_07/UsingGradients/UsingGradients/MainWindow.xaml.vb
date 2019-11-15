' Fig. 28.7: MainWindow.xaml.vb
' Customizing gradients.
Class MainWindow
   ' change the starting color of the gradient when the user clicks
   Private Sub fromButton_Click(sender As Object, e As RoutedEventArgs) _
      Handles fromButton.Click

      ' change the color to use the ARGB values specified by user
      startGradient.Color = Color.FromArgb(
         Convert.ToByte(fromAlpha.Text),
         Convert.ToByte(fromRed.Text),
         Convert.ToByte(fromGreen.Text),
         Convert.ToByte(fromBlue.Text))
   End Sub

   ' change the ending color of the gradient when the user clicks
   Private Sub toButton_Click(sender As Object, e As RoutedEventArgs) _
      Handles toButton.Click

      ' change the color to use the ARGB values specified by user
      stopGradient.Color = Color.FromArgb(
         Convert.ToByte(toAlpha.Text),
         Convert.ToByte(toRed.Text),
         Convert.ToByte(toGreen.Text),
         Convert.ToByte(toBlue.Text))
   End Sub
End Class

'/*************************************************************************
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
'*************************************************************************/