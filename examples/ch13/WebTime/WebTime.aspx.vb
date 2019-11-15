' Fig. 13.20: WebTime.aspx.vb
' Code-behind file for a page that displays the current time.
Partial Class WebTime
   Inherits System.Web.UI.Page

   ' initializes the contents of the page
   Protected Sub Page_Init(ByVal sender As Object,
       ByVal e As System.EventArgs) Handles Me.Init

      ' display the server's current time in timeLabel  
      timeLabel.Text = DateTime.Now.ToString("hh:mm:ss")
   End Sub ' Page_Init
End Class ' WebTime

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
