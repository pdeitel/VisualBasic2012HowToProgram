﻿' Fig. 25.17: MathTutorForm.vb
' Math tutor using EquationGeneratorServiceJSON to create equations.
Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization.Json

Public Class MathTutorForm
   Private operation As String = "add" ' the default operation
   Private level As Integer = 1 ' the default difficulty level
   Private currentEquation As Equation ' represents the Equation
   Private service As New HttpClient() ' used to invoke service

   ' generates a new equation when user clicks button
   Private Async Sub generateButton_Click(sender As Object,
      e As EventArgs) Handles generateButton.Click

      ' send request to EquationGeneratorServiceJSON
      Dim response = Await service.GetStringAsync(New Uri(
         "http://localhost:50186/EquationGeneratorService.svc/equation/" &
         operation & "/" & level))

      ' deserialize response into an equation object
      Dim JSONSerializer As New DataContractJsonSerializer(
         GetType(Equation))
      currentEquation = CType(JSONSerializer.ReadObject(
         New MemoryStream(Encoding.Unicode.GetBytes(response))), Equation)

      ' display left side of equation
      questionLabel.Text = currentEquation.LeftHandSide
      okButton.Enabled = True ' enable okButton
      answerTextBox.Enabled = True ' enable answerTextBox
   End Sub ' generateButton_Click

   ' check user's answer
   Private Sub okButton_Click(sender As Object,
      e As EventArgs) Handles okButton.Click
      ' determine correct result from Equation object
      Dim answer As Integer = currentEquation.Result

      If Not String.IsNullOrEmpty(answerTextBox.Text) Then
         ' get user's answer
         Dim userAnswer As Integer = Convert.ToInt32(answerTextBox.Text)

         ' determine whether user's answer is correct
         If answer = userAnswer Then
            questionLabel.Text = String.Empty ' clear question
            answerTextBox.Clear() ' clear answer
            okButton.Enabled = False ' disable OK button
            MessageBox.Show("Correct! Good job!")
         Else
            MessageBox.Show("Incorrect. Try again.")
         End If
      End If
   End Sub ' okButton_Click

   ' set the operation to addition
   Private Sub additionRadioButton_CheckedChanged(
      sender As Object, e As EventArgs) _
      Handles additionRadioButton.CheckedChanged
      operation = "add"
   End Sub ' additionRadioButton_CheckedChanged

   ' set the operation to subtraction
   Private Sub subtractionRadioButton_CheckedChanged(
      sender As Object, e As EventArgs) _
      Handles subtractionRadioButton.CheckedChanged
      operation = "subtract"
   End Sub ' subtractionRadioButton_CheckedChanged

   ' set the operation to multiplication
   Private Sub multiplicationRadioButton_CheckedChanged(
      sender As Object, e As EventArgs) _
      Handles multiplicationRadioButton.CheckedChanged
      operation = "multiply"
   End Sub ' multiplicationRadioButton_CheckedChanged

   ' set difficulty level to 1
   Private Sub levelOneRadioButton_CheckedChanged(
      sender As Object, e As EventArgs) _
      Handles levelOneRadioButton.CheckedChanged
      level = 1
   End Sub ' levelOneRadioButton_CheckedChanged

   ' set difficulty level to 2
   Private Sub levelTwoRadioButton_CheckedChanged(
      sender As Object, e As EventArgs) _
      Handles levelTwoRadioButton.CheckedChanged
      level = 2
   End Sub ' levelTwoRadioButton_CheckedChanged

   ' set difficulty level to 3
   Private Sub levelThreeRadioButton_CheckedChanged(
      sender As Object, e As EventArgs) _
      Handles levelThreeRadioButton.CheckedChanged
      level = 3
   End Sub ' levelThreeRadioButton_CheckedChanged
End Class ' MathTutorForm

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
