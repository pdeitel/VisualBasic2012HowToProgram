' Fig. 9.14: SharedTest.vb
' Demonstrates Shared members.
Public Class SharedTest
   Private Sub SharedTest_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      outputTextBox.AppendText("Employees before instantiation: " &
         Employee.Count & vbCrLf) ' Count is a Shared property

      Dim employee1 As New Employee("Susan", "Baker") ' call constructor
      outputTextBox.AppendText(vbCrLf & "Created employee: " &
         employee1.FirstName & " " & employee1.LastName & vbCrLf &
         "Current number of Employees is: " & Employee.Count & vbCrLf)

      Dim employee2 As New Employee("Bob", "Blue") ' call constructor
      outputTextBox.AppendText(vbCrLf & "Created employee: " &
         employee2.FirstName & " " & employee2.LastName & vbCrLf &
         "Current number of Employees is: " & Employee.Count &
         vbCrLf & vbCrLf)

      outputTextBox.AppendText("Marking employees for garbage collection")
      employee1 = Nothing ' mark employee1 for garbage collection
      employee2 = Nothing ' mark employee2 for garbage collection
   End Sub ' SharedTest_Load
End Class ' SharedTest

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