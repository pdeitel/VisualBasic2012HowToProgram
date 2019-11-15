' Fig. 14.20: KeyDemo.vb
' Displaying information about the key the user pressed.
Public Class KeyDemo
   ' display the character pressed using KeyChar
   Private Sub KeyDemo_KeyPress(sender As Object,
      e As KeyPressEventArgs) Handles MyBase.KeyPress

      charLabel.Text = "Key pressed: " & e.KeyChar
   End Sub ' KeyDemo_KeyPress

   ' display modifier keys, key code, key data and key value
   Private Sub KeyDemo_KeyDown(sender As Object,
      e As KeyEventArgs) Handles MyBase.KeyDown

      If e.Alt Then ' key is Alt
         keyInfoLabel.Text = "Alt: Yes" & vbCrLf
      Else ' key is not Alt
         keyInfoLabel.Text = "Alt: No" & vbCrLf
      End If

      If e.Shift Then ' key is Shift
         keyInfoLabel.Text &= "Shift: Yes" & vbCrLf
      Else ' key is not Shift
         keyInfoLabel.Text &= "Shift: No" & vbCrLf
      End If

      If e.Control Then ' key is Control
         keyInfoLabel.Text &= "Control: Yes" & vbCrLf
      Else ' key is not Control
         keyInfoLabel.Text &= "Control: No" & vbCrLf
      End If

      ' diplay key code, key data and key value
      keyInfoLabel.Text &= "KeyCode: " & e.KeyCode.ToString() &
         vbCrLf & "KeyData: " & e.KeyData.ToString() & vbCrLf &
         "KeyValue: " & e.KeyValue.ToString()
   End Sub ' KeyDemo_KeyDown

   ' clear Labels when keys are released
   Private Sub KeyDemo_KeyUp(sender As Object,
      e As KeyEventArgs) Handles MyBase.KeyUp

      charLabel.Text = String.Empty
      keyInfoLabel.Text = String.Empty
   End Sub ' KeyDemo_KeyUp
End Class ' KeyDemo

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