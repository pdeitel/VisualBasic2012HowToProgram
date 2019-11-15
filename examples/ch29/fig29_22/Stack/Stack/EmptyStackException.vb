' Fig. 29.20: EmptyStackException.vb
' Indicates a stack is empty
Public Class EmptyStackException
   Inherits Exception

   ' parameterless constructor
   Public Sub New()
      MyBase.New("Stack is empty")
   End Sub ' New

   ' one-parameter constructor
   Public Sub New(exception As String)
      MyBase.New(exception)
   End Sub ' New

   ' two-parameter constructor
   Public Sub New(message As String,
      innerException As Exception)

        MyBase.New(message, innerException)
    End Sub ' New
End Class ' EmptyStackException



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