' Fig. 6.3: WageCalculator.vb
' Calculating and displaying an employee's pay using a method.
Public Class WageCalculator
   Const HOURS_IN_A_WEEK As Integer = 168 ' totol hours in one week
   Const HOUR_LIMIT As Integer = 40 ' maximum hours before overtime

   ' calculate and display the employee's pay
   Private Sub calculateButton_Click(sender As Object,
      e As EventArgs) Handles calculateButton.Click

      ' get hours worked and hourly wage
      Dim hoursWorked As Double = Val(hoursTextBox.Text)
      Dim hourlyWage As Decimal = Val(wageTextBox.Text)

      ' determine whether hoursWorked is less than or equal to 168
      If hoursWorked <= HOURS_IN_A_WEEK Then
         DisplayPay(hoursWorked, hourlyWage) ' calls DisplayPay Function
      Else
         MessageBox.Show("Hours worked must be less than or equal to 168",
            "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
   End Sub ' calculateButton_Click

   ' calculate and display wages
   Sub DisplayPay(hours As Double, wages As Decimal)
      Dim earnings As Decimal ' stores the total earnings

      ' determine wage amount
      If hours <= HOUR_LIMIT Then
         ' earnings for regular wages
         earnings = hours * wages
      Else
         ' regular wages for first HOUR_LIMIT hours
         earnings = HOUR_LIMIT * wages

         ' time and a half for overtime
         earnings += ((hours - HOUR_LIMIT) * (1.5 * wages))
      End If

      resultLabel.Text = String.Format("{0:C}", earnings)
   End Sub ' DisplayPay

   ' clear resultLabel when user enters new hourly wage
   Private Sub wageTextBox_TextChanged(sender As Object,
       e As EventArgs) Handles wageTextBox.TextChanged
      resultLabel.Text = String.Empty ' clear the Label
   End Sub ' wageTextBox_TextChanged

   ' clear resultLabel when user enters new hours worked
   Private Sub hoursTextBox_TextChanged(sender As Object,
      e As EventArgs) Handles hoursTextBox.TextChanged
      resultLabel.Text = String.Empty ' clear the Label
   End Sub ' hoursTextBox_TextChanged
End Class ' WageCalculator

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
