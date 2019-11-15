' Fig. 13.30: Recommendations.aspx.vb
' Creates book recommendations based on a Session object.
Partial Class Recommendations
   Inherits System.Web.UI.Page

   ' read Session items and populate ListBox with any book recommendations
   Protected Sub Page_Init(ByVal sender As Object,
      ByVal e As System.EventArgs) Handles Me.Init

      ' determine whether Session contains any information
      If Session.Count <> 0 Then
         For Each keyName In Session.Keys
            ' use keyName to display one of Session's name-value pairs
            booksListBox.Items.Add(keyName &
               " How to Program. ISBN#: " & Session(keyName))
         Next
      Else
         ' if there are no session items, no language was chosen, so
         ' display appropriate message and hide booksListBox
         recommendationsLabel.Text = "No Recommendations"
         booksListBox.Visible = False

         ' modify languageLink because no language was selected
         languageLink.Text = "Click here to choose a language"
      End If
   End Sub ' Page_Init
End Class ' Recommendations

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

