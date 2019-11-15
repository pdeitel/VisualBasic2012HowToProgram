' Fig. 10.6: InheritanceTest.vb
' Testing derived class BasePlusCommissionEmployee.
Public Class InheritanceTest
   ' demonstrate class BasePlusCommissionEmployee
   Private Sub InheritanceTest_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' instantiate BasePlusCommissionEmployee object
      Dim employee As New BasePlusCommissionEmployee(
         "Bob", "Lewis", "333-33-3333", 5000D, 0.04, 300D)

      ' get base-salaried commission employee data
      outputTextBox.AppendText(
         "Employee information obtained by properties:" & vbCrLf &
         "First name is " & employee.FirstName & vbCrLf &
         "Last name is " & employee.LastName & vbCrLf &
         "Social Security Number is " & employee.SocialSecurityNumber &
         vbCrLf & "Gross sales is " &
         String.Format("{0:C}", employee.GrossSales) & vbCrLf &
         "Commission rate is " &
         String.Format("{0:F}", employee.CommissionRate) & vbCrLf &
         "Base salary is " & String.Format("{0:C}", employee.BaseSalary))

      ' display the employee's earnings
      outputTextBox.AppendText(vbCrLf & vbCrLf & "Earnings: " &
         String.Format("{0:C}", employee.CalculateEarnings()))

      ' modify properties
      employee.GrossSales = 10000D ' set gross sales
      employee.CommissionRate = 0.05 ' set commission rate
      employee.BaseSalary = 1000D ' set base salary

      ' get new employee information
      outputTextBox.AppendText(vbCrLf & vbCrLf &
         "Updated employee information returned by ToString: " &
         vbCrLf & employee.ToString())

      ' display the employee's earnings
      outputTextBox.AppendText(vbCrLf & vbCrLf & "Earnings: " &
         String.Format("{0:C}", employee.CalculateEarnings()))
   End Sub ' InheritanceTest_Load
End Class ' InheritanceTest

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