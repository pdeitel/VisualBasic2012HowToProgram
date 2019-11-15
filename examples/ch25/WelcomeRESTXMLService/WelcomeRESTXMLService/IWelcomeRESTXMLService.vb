' Fig. 25.1: IWelcomeRESTXMLService.vb
' WCF web service interface. A class that implements this interface
' returns a welcome message through REST architecture and XML data format.
'Imports System.ServiceModel.Web

<ServiceContract()>
Public Interface IWelcomeRESTXMLService
   ' returns a welcome message
   <OperationContract()>
   <WebGet(UriTemplate:="welcome/{yourName}")>
   Function Welcome(ByVal yourName As String) As String
End Interface ' IWelcomeRESTXMLService

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