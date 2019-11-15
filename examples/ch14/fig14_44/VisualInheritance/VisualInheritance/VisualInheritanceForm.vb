' Fig. 14.44: VisualInheritanceForm.vb
' Base Form for use with visual inheritance.
Public Class VisualInheritanceForm
   ' display MessageBox when Button is clicked
   Private Sub learnMoreButton_Click(sender As Object,
      e As EventArgs) Handles learnMoreButton.Click

      MessageBox.Show(
         "Bugs, Bugs, Bugs is a product of Deitel & Associates, Inc.",
         "Learn More", MessageBoxButtons.OK,
         MessageBoxIcon.Information)
   End Sub ' learnMoreButton_Click
End Class ' VisualInheritanceForm

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


