' Fig. 25.2: WelcomeRESTXMLService.vb
' WCF web service that returns a welcome message using REST architecture
' and XML data format.
Public Class WelcomeRESTXMLService
   Implements IWelcomeRESTXMLService

   ' returns a welcome message
   Public Function Welcome(yourName As String) As String _
      Implements IWelcomeRESTXMLService.Welcome

      Return "Welcome to WCF Web Services with REST and XML, " &
         yourName & "!"
   End Function ' Welcome
End Class ' WelcomeRESTXMLService

'**************************************************************************
'* (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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