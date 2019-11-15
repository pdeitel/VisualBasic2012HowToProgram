' Fig. 10.13: PolymorphismTest.vb
' Employee hierarchy test program.
Public Class PolymorphismTest
   Private Sub PolymorphismTest_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' create derived-class objects                                     
      Dim salariedEmployee As New SalariedEmployee(
         "John", "Smith", "111-11-1111", 800D)
      Dim commissionEmployee As New CommissionEmployee(
         "Sue", "Jones", "333-33-3333", 10000D, 0.06)
      Dim basePlusCommissionEmployee As New BasePlusCommissionEmployee(
         "Bob", "Lewis", "444-44-4444", 5000D, 0.04, 300D)

      ' display each employee’s info nonpolymorphically
      outputTextBox1.AppendText(
         "Employees processed individually:" & vbCrLf & vbCrLf &
         String.Format("{0}{1}earned: {2:C}{1}{1}",
            salariedEmployee.ToString(), vbCrLf,
            salariedEmployee.CalculateEarnings()) &
         String.Format("{0}{1}earned: {2:C}{1}{1}",
            commissionEmployee.ToString(), vbCrLf,
            commissionEmployee.CalculateEarnings()) &
         String.Format("{0}{1}earned: {2:C}",
            basePlusCommissionEmployee.ToString(), vbCrLf,
            basePlusCommissionEmployee.CalculateEarnings()))

      ' create three-element Employee array                              
      Dim employees() As Employee = {salariedEmployee,
         commissionEmployee, basePlusCommissionEmployee}

      outputTextBox2.AppendText(
         "Employees processed polymorphically:" & vbCrLf & vbCrLf)

      ' polymorphically process each element in array employees
      For Each currentEmployee In employees
         outputTextBox2.AppendText(
            String.Format("{0}{1}earned {2:C}{1}{1}",
            currentEmployee.ToString(), vbCrLf,
            currentEmployee.CalculateEarnings()))
      Next
   End Sub ' PolymorphismTest_Load
End Class ' PolymorphismTest

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