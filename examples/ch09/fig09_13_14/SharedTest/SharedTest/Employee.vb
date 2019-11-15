' Fig. 9.13: Employee.vb
' Class Employee uses Shared variable.
Public Class Employee
   Private firstNameValue As String ' employee first name
   Private lastNameValue As String ' employee last name
   Private Shared countValue As Integer ' Employee objects in memory

   ' Employee constructor
   Public Sub New(first As String, last As String)
      firstNameValue = first
      lastNameValue = last
      countValue += 1 ' increment shared count of employees
   End Sub ' New

   ' return first name
   Public ReadOnly Property FirstName() As String
      Get
         Return firstNameValue
      End Get
   End Property ' FirstName

   ' return last name
   Public ReadOnly Property LastName() As String
      Get
         Return lastNameValue
      End Get
   End Property ' LastName

   ' property Count
   Public Shared ReadOnly Property Count() As Integer
      Get
         Return countValue
      End Get
   End Property ' Count
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