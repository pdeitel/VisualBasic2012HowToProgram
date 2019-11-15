' Fig. 25.9: WelcomeRESTJSONService.vb
' WCF web service that returns a welcome message through REST architecture
' and JSON format.
Public Class WelcomeRESTJSONService
   Implements IWelcomeRESTJSONService

   ' returns a welcome message
   Public Function Welcome(yourName As String) As TextMessage _
      Implements IWelcomeRESTJSONService.Welcome
      ' add welcome message to field of TextMessage object
      Dim welcomeString As New TextMessage
      welcomeString.Message =
         "Welcome to WCF Web Services with REST and JSON, " &
         yourName & "!"
      Return welcomeString
   End Function ' Welcome
End Class ' WelcomeRESTJSONService

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