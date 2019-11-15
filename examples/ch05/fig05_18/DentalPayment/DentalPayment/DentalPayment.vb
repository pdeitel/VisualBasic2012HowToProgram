' Fig. 5.18: DentalPayment.vb
' Dental Payment Calculator displays bill amount for a dental visit.
Public Class DentalPayment
   ' calculate the bill amount
   Private Sub calculateButtonClick(sender As Object,
      e As EventArgs) Handles calculateButton.Click

      ' if no name entered or no CheckBoxes checked, display message
      If (nameTextBox.Text = String.Empty) OrElse
         (Not cleaningCheckBox.Checked AndAlso
          Not xrayCheckBox.Checked AndAlso
          Not fillingCheckBox.Checked) Then

         totalCostLabel.Text = String.Empty ' clear totalResultsLabel

         ' display an error message in a dialog
         MessageBox.Show(
            "Please enter a name and check at least one item",
            "Missing Information", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
      Else ' add prices
         ' total contains amount to bill patient
         Dim total As Decimal = 0

         ' if patient had a cleaning
         If cleaningCheckBox.Checked Then
            total += Val(cleaningCostLabel.Text)
         End If

         ' if patient had a cavity filled
         If fillingCheckBox.Checked Then
            total += Val(fillingCostLabel.Text)
         End If

         ' if patient had an X-Ray taken
         If xrayCheckBox.Checked Then
            total += Val(xrayCostLabel.Text)
         End If

         ' display the total
         totalCostLabel.Text = String.Format("{0:C}", total)
      End If
   End Sub ' calculateButtonClick
End Class ' DentalPayment

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
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