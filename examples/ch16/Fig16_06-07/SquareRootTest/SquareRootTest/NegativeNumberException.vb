' Fig. 16.6: NegativeNumberException.vb
' Exception derived class thrown when a program performs an illegal 
' operation on a negative number.
Public Class NegativeNumberException
   Inherits Exception
   ' default constructor
   Public Sub New()
      MyBase.New("Illegal operation for a negative number")
   End Sub ' New

   ' constructor for customizing error message
   Public Sub New(messageValue As String)
      MyBase.New(messageValue)
   End Sub ' New

   ' constructor for customizing the exception's error
   ' message and specifying the InnerException object
   Public Sub New(messageValue As String, inner As Exception)
      MyBase.New(messageValue, inner)
   End Sub ' New
End Class ' NegativeNumberException


'**************************************************************************
'* (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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