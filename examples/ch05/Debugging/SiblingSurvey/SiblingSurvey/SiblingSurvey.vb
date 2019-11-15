' Exercise 5.9: SiblingSurvey.vb
Public Class SiblingSurvey
   Private Sub submitButtonClick(sender As System.Object,
      e As System.EventArgs) Handles submitSurveyButton.Click

      ' check combinations of brothers, sisters and no siblings
      If (noneCheckBox.Checked = True) AndAlso
         (brotherCheckBox.Checked = True AndAlso
         sisterCheckBox.Checked = True) Then

         MessageBox.Show("Selected combination is not possible",
            "Invalid Input", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
      ElseIf brotherCheckBox.Checked = True OrElse
         sisterCheckBox.Checked = True Then

         MessageBox.Show("You have brothers and sisters",
            "Siblings", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
      ElseIf brotherCheckBox.Checked = True Then
         MessageBox.Show("You have at least one brother",
            "Siblings", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
      ElseIf sisterCheckBox.Checked = True Then
         MessageBox.Show("You have at least one sister",
            "Siblings", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
      Else
         MessageBox.Show("You have no siblings",
            "Siblings", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
      End If
   End Sub ' submitButtonClick
End Class ' SiblingSurveyForm


' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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