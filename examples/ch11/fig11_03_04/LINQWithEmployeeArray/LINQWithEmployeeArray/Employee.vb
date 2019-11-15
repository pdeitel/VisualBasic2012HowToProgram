' Fig. 11.3: Employee.vb
' Employee class with FirstName, LastName and MonthlySalary properties.
Public Class Employee
   Public Property LastName As String  ' employee's last name
   Public Property FirstName As String ' employee's first name
   Private monthlySalaryValue As Decimal ' monthly salary of employee

   ' constructor initializes first name, last name and monthly salary
   Public Sub New(first As String, last As String,
      salary As Decimal)

      FirstName = first ' calls FirstName property's Set accessor
      LastName = last ' calls LastName property's Set accessor
      MonthlySalary = salary ' calls MonthlySalary property's Set accessor
   End Sub ' New

   ' property that gets and sets the employee's monthly salary
   Public Property MonthlySalary() As Decimal
      Get
         Return monthlySalaryValue
      End Get

      Set(value As Decimal)
         If value >= 0 Then ' if salary is non-negative
            monthlySalaryValue = value
         Else
            Throw New ArgumentOutOfRangeException(
               "Salary must be greater than or equal to 0")
         End If
      End Set
   End Property ' MonthlySalary

   ' return a String containing the employee's information
   Public Overrides Function ToString() As String
      Return String.Format("{0,-10} {1,-10} {2,10:C}",
         FirstName, LastName, MonthlySalary)
   End Function ' ToString
End Class ' Employee

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
