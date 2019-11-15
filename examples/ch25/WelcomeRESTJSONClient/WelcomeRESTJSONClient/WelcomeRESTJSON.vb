' Fig. 25.11: WelcomeRESTJSON.vb
' Client that consumes WelcomeRESTJSONService.
Imports System.IO
Imports System.Net.Http
Imports System.Runtime.Serialization.Json
Imports System.Text

Public Class WelcomeRESTJSON
   ' object to invoke the WelcomeRESTJSONService
   Private service As New HttpClient()

   ' creates welcome message from text input and web service
   Private Async Sub submitButton_Click(sender As Object,
      e As EventArgs) Handles submitButton.Click

      ' send request to WelcomeRESTJSONService
      Dim result = Await service.GetStringAsync(
         New Uri("http://localhost:49621/WelcomeRESTJSONService.svc" &
         "/welcome/" & textBox.Text))

      ' deserialize response into a TextMessage object
      Dim JSONSerializer As New DataContractJsonSerializer(
         GetType(TextMessage))
      Dim welcomeString = JSONSerializer.ReadObject(
         New MemoryStream(Encoding.Unicode.GetBytes(result)))

      ' display Message text
      MessageBox.Show(CType(welcomeString, TextMessage).Message)
   End Sub ' submitButton
End Class ' WelcomeRESTJSON

' TextMessage class representing a JSON object
<Serializable()>
Public Class TextMessage
   Public Message As String
End Class ' TextMessage

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