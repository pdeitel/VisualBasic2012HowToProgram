' Fig. 17.21: Validate.vb
' Validate user information using regular expressions.
Imports System.Text.RegularExpressions ' regular expression classes

Public Class ValidateForm
   ' handles OK Button's Click event
   Private Sub okButton_Click(sender As Object,
       e As EventArgs) Handles okButton.Click

      ' find blank TextBoxes and order by TabIndex
      Dim emptyBoxes =
      From control In Controls
      Where (TypeOf Control Is TextBox)
      Let box As TextBox = CType(control, TextBox)
      Where (String.IsNullOrEmpty(box.Text))
      Order By box.TabIndex
      Select box

      If emptyBoxes.Count() > 0 Then
         ' display popup box
         MessageBox.Show("Please fill in all fields",
            "Missing Information", MessageBoxButtons.OK,
            MessageBoxIcon.Error)

         emptyBoxes.First().Focus() ' set focus to first empty TextBox
      Else
         ' check for invalid input
         Select Case False
            ' last name format is invalid
            Case ValidateInput(lastNameTextBox.Text,
               "^[A-Z][a-zA-Z]*$", "Invalid last name")

               lastNameTextBox.Focus() ' focus on invalid TextBox
               ' first name format is invalid
            Case ValidateInput(firstNameTextBox.Text,
               "^[A-Z][a-zA-Z]*$", "Invalid first name")

               firstNameTextBox.Focus() ' focus on invalid TextBox
               ' address format is invalid
            Case ValidateInput(addressTextBox.Text,
               "^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$",
               "Invalid address")

               addressTextBox.Focus() ' focus on invalid TextBox
               ' city format is invalid
            Case ValidateInput(cityTextBox.Text,
               "^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", "Invalid city")

               cityTextBox.Focus() ' focus on invalid TextBox
               ' state format is invalid
            Case ValidateInput(stateTextBox.Text,
               "^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", "Invalid state")

               stateTextBox.Focus() ' focus on invalid TextBox
               ' zip code format is invalid
            Case ValidateInput(zipCodeTextBox.Text,
               "^\d{5}$", "Invalid zip code")

               zipCodeTextBox.Focus() ' focus on invalid TextBox
               ' phone number format is invalid
            Case ValidateInput(phoneTextBox.Text,
               "^[1-9]\d{2}-[1-9]\d{2}-\d{4}$", "Invalid phone number")

               phoneTextBox.Focus() ' focus on invalid TextBox
            Case Else
               ' information is valid, signal user and exit application
               Me.Hide() ' hide main window while MessageBox displays
               MessageBox.Show("Thank You!", "Information Correct",
                  MessageBoxButtons.OK, MessageBoxIcon.Information)
               Application.Exit() ' exit the application
         End Select
      End If
   End Sub ' okButton_Click

   ' use regular expressions to validate user input
   Public Function ValidateInput( input As String,
       expression As String,  message As String) As Boolean

      ' store whether the input is valid
      Dim valid As Boolean = Regex.Match(input, expression).Success

      ' if the input doesn't match the regular expression
      If Not valid Then
         ' signal user input was invalid
         MessageBox.Show(message, "Invalid Input",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      Return valid ' return whether the input is valid
   End Function ' ValidateInput
End Class ' ValidateForm

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