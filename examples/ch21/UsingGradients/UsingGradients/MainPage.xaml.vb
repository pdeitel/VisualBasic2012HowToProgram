' Fig. 21.5: MainPage.xaml.vb
' Customizing gradients.
Imports Windows.UI

Partial Public NotInheritable Class MainPage
   Inherits Page

   ' change the starting color of the gradient when the user clicks
   Private Sub startColorButton_Click(sender As Object,
      e As RoutedEventArgs) Handles startColorButton.Click

      ' change the color to use the ARGB values specified by user
      firstStop.Color = Color.FromArgb(Convert.ToByte(fromAlpha.Text),
         Convert.ToByte(fromRed.Text), Convert.ToByte(fromGreen.Text),
         Convert.ToByte(fromBlue.Text))
   End Sub ' startColorButton_Click

   ' change the ending color of the gradient when the user clicks
   Private Sub endColorButton_Click(sender As Object,
      e As RoutedEventArgs) Handles endColorButton.Click

      ' change the color to use the ARGB values specified by user
      secondStop.Color = Color.FromArgb(Convert.ToByte(toAlpha.Text),
         Convert.ToByte(toRed.Text), Convert.ToByte(toGreen.Text),
         Convert.ToByte(toBlue.Text))
   End Sub ' endColorButton_Click
End Class ' MainPage

'************************************************************************
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
'************************************************************************