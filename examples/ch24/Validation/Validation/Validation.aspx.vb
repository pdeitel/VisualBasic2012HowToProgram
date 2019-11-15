' Fig. 13.26: Validation.aspx.vb
' Code-behind file for the form demonstrating validation controls.
Public Class Validation
   Inherits System.Web.UI.Page

   Protected Sub Page_Load(ByVal sender As Object,
     ByVal e As System.EventArgs) Handles Me.Load
      ' disable unobtrusive validation
      UnobtrusiveValidationMode =
         System.Web.UI.UnobtrusiveValidationMode.None

      ' if this is not the first time the page is loading
      ' (i.e., the user has already submitted form data)
      If IsPostBack Then
         Validate() ' validate the form

         If IsValid Then
            ' retrieve the values submitted by the user
            Dim name As String = nameTextBox.Text
            Dim email As String = emailTextBox.Text
            Dim phone As String = phoneTextBox.Text

            ' create a table indicating the submitted values
            outputLabel.Text = "Thank you for your submission<br/>" &
               "We received the following information:<br/>"
            outputLabel.Text &=
               String.Format("Name: {0}{1}E-mail:{2}{1}Phone:{3}",
                  name, "<br/>", email, phone)
            outputLabel.Visible = True ' display the output message
         End If
      End If
   End Sub ' Page_Load
End Class ' Validation

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

