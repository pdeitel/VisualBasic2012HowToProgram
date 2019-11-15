' Fig. 7.7: FlagQuiz.vb
' Using an array of Strings to represent quiz answers.
Public Class FlagQuiz
   ' String array stores country names
   Dim countries() As String = {"Australia", "Brazil", "China", "Italy",
      "Russia", "South Africa", "Spain", "United States"}
   Dim randomObject As New Random()

   ' Boolean array tracks which flags have been displayed
   Dim used(countries.GetUpperBound(0)) As Boolean ' all False by default

   Dim count As Integer = 1 ' number of flags shown
   Dim country As String ' current flag's country

   ' handles Flag Quiz Form's Load event
   Private Sub FlagQuizForm_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' display country names in ComboBox
      countriesComboBox.DataSource = countries

      DisplayFlag() ' display first flag in PictureBox
   End Sub ' FlagQuizForm_Load

   ' handles Submit Button's Click event
   Private Sub submitButton_Click(sender As Object,
      e As EventArgs) Handles submitButton.Click

      ' verify user's answer
      If countriesComboBox.Text = country Then
         MessageBox.Show("Correct!", "Correct Answer")
      Else
         MessageBox.Show("The correct answer is " & country,
            "Incorrect Answer")
      End If

      ' inform user if quiz is over
      If count >= countries.Length Then ' quiz is over
         countriesComboBox.Enabled = False
         submitButton.Enabled = False
      Else ' quiz is not over
         DisplayFlag() ' display next flag
         countriesComboBox.SelectedIndex = 0 ' select first ComboBox entry
         count += 1 ' update number of flags shown
      End If
   End Sub ' submitButton_Click

   ' return an unused random number
   Function GetUniqueRandomNumber() As Integer
      Dim randomNumber As Integer

      Do ' generate random numbers until unused flag is found
         randomNumber = randomObject.Next(0, used.Length)
      Loop Until used(randomNumber) = False

      used(randomNumber) = True ' indicate that flag has been used
      Return randomNumber ' return index for new flag
   End Function ' GetUniqueRandomNumber

   ' display random flag in PictureBox
   Sub DisplayFlag()
      ' unique index ensures that a flag is used no more than once
      Dim randomNumber As Integer = GetUniqueRandomNumber()

      country = countries(randomNumber) ' get country name

      ' get image resource--remove spaces from country name
      Dim pictureResource = My.Resources.ResourceManager.GetObject(
         country.Replace(" ", ""))
      flagPictureBox.Image = CType(pictureResource, Image) ' display flag
   End Sub ' DisplayFlag
End Class ' FlagQuiz

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