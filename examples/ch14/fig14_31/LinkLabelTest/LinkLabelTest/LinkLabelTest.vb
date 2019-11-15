' Fig. 14.31: LinkLabelTestForm.vb
' Using LinkLabels to create hyperlinks.
Public Class LinkLabelTest
   ' browse C:\ drive
   Private Sub cDriveLinkLabel_LinkClicked(sender As Object,
      e As LinkLabelLinkClickedEventArgs) _
      Handles cDriveLinkLabel.LinkClicked

      cDriveLinkLabel.LinkVisited = True ' change LinkColor after click
      Process.Start("C:\")
   End Sub ' cDriveLinkLabel_LinkClicked

   ' browse www.deitel.com in the default web browser
   Private Sub deitelLinkLabel_LinkClicked(sender As Object,
      e As LinkLabelLinkClickedEventArgs) _
      Handles deitelLinkLabel.LinkClicked

      deitelLinkLabel.LinkVisited = True ' change LinkColor after click
      Process.Start("http://www.deitel.com")
   End Sub ' deitelLinkLabel_LinkClicked

   ' run the Notepad application
   Private Sub notepadLinkLabel_LinkClicked(sender As Object,
      e As LinkLabelLinkClickedEventArgs) _
      Handles notepadLinkLabel.LinkClicked

      notepadLinkLabel.LinkVisited = True ' change LinkColor after click
      Process.Start("notepad")
   End Sub ' notepadLinkLabel_LinkClicked
End Class ' LinkLabelTest

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
