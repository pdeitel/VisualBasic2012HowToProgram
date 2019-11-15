' Fig. 18.8: Record.vb
' Class that represents a data record.
Public Class Record
   Public Property Account() As Integer ' property Account
   Public Property FirstName() As String ' property FirstName
   Public Property LastName() As String ' property LastName
   Public Property Balance() As Decimal ' property Balance

   ' parameterless constructor sets members to default values
   Public Sub New()
      MyClass.New(0, String.Empty, String.Empty, 0D)
   End Sub ' New

   ' overloaded constructor sets members to parameter values
   Public Sub New(newAccount As Integer,
      newFirstName As String, newLastName As String,
      newBalance As Decimal)

      Account = newAccount
      FirstName = newFirstName
      LastName = newLastName
      Balance = newBalance
   End Sub ' New
End Class ' Record


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