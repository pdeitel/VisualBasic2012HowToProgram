' Fig. 10.x: SalariedEmployee.vb
' SalariedEmployee class inherits Employee
Public Class SalariedEmployee
   Inherits Employee

   Private weeklySalaryValue As Decimal ' employee's weekly salary

   ' four-argument constructor
   Public Sub New(first As String, last As String,
      ssn As String, salary As Decimal)

      MyBase.New(first, last, ssn) ' pass to Employee constructor
      WeeklySalary = salary ' validate and store salary
   End Sub ' New

   ' property WeeklySalary
   Public Property WeeklySalary() As Decimal
      Get
         Return weeklySalaryValue
      End Get

      Set(salary As Decimal)
         If salary >= 0D Then ' validate salary
            weeklySalaryValue = salary
         Else
            Throw New ArgumentOutOfRangeException(
               "Salary must be greater than or equal to 0")
         End If
      End Set
   End Property ' WeeklySalary

   ' calculate earnings; override abstract method CalculateEarnings
   Public Overrides Function CalculateEarnings() As Decimal
      Return WeeklySalary
   End Function ' CalculateEarnings                                

   ' return String representation of SalariedEmployee object           
   Public Overrides Function ToString() As String
      Return String.Format(
         "salaried employee: {0}{1}weekly salary: {2:C}", 
         MyBase.ToString(), vbCrLf, WeeklySalary)
   End Function ' ToString 
End Class ' SalariedEmployee

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