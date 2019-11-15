' Fig. 14.12: PanelDemo.vb
' Displaying Buttons in a scrollable Panel.
Public Class PanelDemo
   ' display which Button was pressed
   Private Sub Button_Click(sender As Object,
      e As EventArgs) Handles Button1.Click, Button2.Click,
      Button3.Click, Button4.Click, Button5.Click, Button6.Click

      ' display the Button's text in the outputLabel
      outputLabel.Text = "You pressed: " & CType(sender, Button).Text
   End Sub ' Button_Click
End Class ' PanelDemo

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