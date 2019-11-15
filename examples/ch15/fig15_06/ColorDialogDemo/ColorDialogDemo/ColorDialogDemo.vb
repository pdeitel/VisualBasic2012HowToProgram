' Fig. 15.6: ColorDialogDemo.vb
' ColorDialog used to change background and text color.
Public Class ColorDialogDemo
   ' create ColorDialog object
   Private Shared colorChooser As New ColorDialog()

   ' change background color
   Private Sub setBackgroundColorButton_Click(
      sender As Object, e As EventArgs) _
      Handles setBackgroundColorButton.Click

      ' show ColorDialog and get result
      colorChooser.FullOpen = True
      Dim result As DialogResult = colorChooser.ShowDialog()

      If result = Windows.Forms.DialogResult.OK Then
         Me.BackColor = colorChooser.Color ' set background color
      End If
   End Sub ' setBackgroundColorButton_Click

   ' change text color
   Private Sub setTextColorButton_Click(sender As Object,
      e As EventArgs) Handles setTextColorButton.Click

      ' get chosen color
      Dim result As DialogResult = colorChooser.ShowDialog()

      If result = Windows.Forms.DialogResult.OK Then
         setBackgroundColorButton.ForeColor = colorChooser.Color
         setTextColorButton.ForeColor = colorChooser.Color
      End If
   End Sub ' setTextColorButton_Click
End Class ' ColorDialogDemo

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
