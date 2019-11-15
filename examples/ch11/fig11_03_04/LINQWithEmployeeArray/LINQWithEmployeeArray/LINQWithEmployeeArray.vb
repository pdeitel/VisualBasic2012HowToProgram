' Fig. 11.4: LINQWithEmployeeArray.vb
' LINQ to Objects using an array of Employee objects.
Public Class LINQWithEmployeeArray
   Private Sub LINQWithEmployeeArray_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' initialize array of employees
      Dim employees() As Employee = {
         New Employee("Jason", "Red", 5000D),
         New Employee("Ashley", "Green", 7600D),
         New Employee("Matthew", "Indigo", 3587.5D),
         New Employee("James", "Indigo", 4700.77D),
         New Employee("Luke", "Indigo", 6200D),
         New Employee("Jason", "Blue", 3200D),
         New Employee("Wendy", "Brown", 4236.4D)} ' end initializer list

      ' display all employees
      outputTextBox.AppendText(String.Format(
         "Original array:{0}", vbCrLf))
      For Each element In employees
         outputTextBox.AppendText(
            String.Format("   {0}{1}", element, vbCrLf))
      Next

      ' filter a range of salaries using AndAlso in a LINQ query
      Dim between4K6K =
         From employee In employees
         Where (employee.MonthlySalary >= 4000D AndAlso
            employee.MonthlySalary <= 6000D)
         Select employee

      ' display employees making between 4000 and 6000 per month
      outputTextBox.AppendText(String.Format(
         "{0}Employees earning in the range {1:C}-{2:C} per month:{0}",
         vbCrLf, 4000, 6000))
      For Each element In between4K6K
         outputTextBox.AppendText(
            String.Format("   {0}{1}", element, vbCrLf))
      Next

      ' order the employees by last name, then first name with LINQ
      Dim nameSorted =
         From employee In employees
         Order By employee.LastName, employee.FirstName
         Select employee

      ' attempt to display the first result of the above LINQ query
      outputTextBox.AppendText(String.Format(
         "{0}First employee when sorted by name:{0}", vbCrLf))

      If nameSorted.Count() > 0 Then
         outputTextBox.AppendText(nameSorted.First().ToString() & vbCrLf)
      Else
         outputTextBox.AppendText("not found" & vbCrLf)
      End If

      ' use LINQ's Distinct clause to select unique last names
      Dim lastNames =
         From employee In employees
         Select employee.LastName
         Distinct

      ' display unique last names
      outputTextBox.AppendText(String.Format(
         "{0}Unique employee last names:{0}", vbCrLf))
      For Each element In lastNames
         outputTextBox.AppendText(
            String.Format("   {0}{1}", element, vbCrLf))
      Next

      ' use LINQ to select first and last names
      Dim names =
         From employee In employees
         Select employee.FirstName, employee.LastName

      ' display first and last names
      outputTextBox.AppendText(String.Format(
         "{0}Names only:{0}", vbCrLf))
      For Each element In names
         outputTextBox.AppendText(
            String.Format("   {0}{1}", element, vbCrLf))
      Next
   End Sub ' LINQWithEmployeeArray_Load
End Class ' LINQWithEmployeeArray






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
