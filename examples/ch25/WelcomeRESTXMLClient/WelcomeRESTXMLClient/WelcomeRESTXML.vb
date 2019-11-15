' Fig. 25.7: WelcomeRESTXML.vb
' Client that consumes the WelcomeRESTXMLService.
Imports System.Net.Http
Imports System.Xml.Linq
Imports <xmlns="http://schemas.microsoft.com/2003/10/Serialization/">

Public Class WelcomeRESTXML
   ' object to invoke the WelcomeRESTXMLService
   Private service As New HttpClient()

   ' get user input and pass it to the web service
   Private Async Sub submitButton_Click(sender As Object,
      e As EventArgs) Handles submitButton.Click

      ' send request to WelcomeRESTXMLService
      Dim result = Await service.GetStringAsync(
         New Uri("http://localhost:51282/WelcomeRESTXMLService.svc/" &
            "welcome/" & textBox.Text))

      ' parse the returned XML  
      Dim xmlResponse = XDocument.Parse(result)

      ' use XML axis property to access the <string> element's value
      MessageBox.Show(xmlResponse.<string>.Value)
   End Sub ' submitButton_Click
End Class ' WelcomeRESTXML

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