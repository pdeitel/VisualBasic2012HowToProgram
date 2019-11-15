' Fig. 18.7: BankUIForm.vb
' Base class for GUIs in our file-processing apps.
Imports System.Windows.Forms

Public Class BankUIForm
   ' number of TextBoxes on Form
   Protected TextBoxCount As Integer = 4

   ' enumeration constants specify TextBox indices
   Public Enum TextBoxIndices
      ACCOUNT
      FIRST
      LAST
      BALANCE
   End Enum ' TextBoxIndices

   ' clear all TextBoxes
   Public Sub ClearTextBoxes()
      ' iterate through every Control on form
      For Each guiControl In Controls
         ' determine whether Control is TextBox
         If TypeOf guiControl Is TextBox Then
            ' clear Text property (set to empty string)
            CType(guiControl, TextBox).Text = String.Empty
         End If
      Next
   End Sub ' ClearTextBoxes

   ' set text box values to string array values
   Public Sub SetTextBoxValues(values() As String)
      ' determine whether string array has correct length
      If values.Length <> TextBoxCount Then
         ' throw exception if not correct length
         Throw New ArgumentException(
            "There must be " & (TextBoxCount) &
            " strings in the array")
         ' set array values if array has correct length
      Else
         ' set array values to text box values
         accountTextBox.Text = values(TextBoxIndices.ACCOUNT)
         firstNameTextBox.Text = values(TextBoxIndices.FIRST)
         lastNameTextBox.Text = values(TextBoxIndices.LAST)
         balanceTextBox.Text = values(TextBoxIndices.BALANCE)
      End If
   End Sub ' SetTextBoxValues

   ' return text box values as string array
   Public Function GetTextBoxValues() As String()
      Dim values(TextBoxCount) As String

      ' copy text box fields to string array
      values(TextBoxIndices.ACCOUNT) = accountTextBox.Text
      values(TextBoxIndices.FIRST) = firstNameTextBox.Text
      values(TextBoxIndices.LAST) = lastNameTextBox.Text
      values(TextBoxIndices.BALANCE) = balanceTextBox.Text

      Return values
   End Function ' GetTextBoxValues
End Class ' BankUIForm

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