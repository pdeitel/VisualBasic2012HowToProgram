' Fig. 29.18: Stack.vb
' Generic class Stack
Public Class Stack(Of T)
   Private top As Integer ' location of the top element
   Private elements() As T ' array that stores Stack elements

   ' parameterless constructor creates a Stack of the default size
   Public Sub New()
      MyClass.New(10) ' default stack size 10 elements
   End Sub ' New

   ' constructor creates a Stack of the specified number of elements
   Public Sub New(stackSize As Integer)
      If stackSize > 0 Then ' validate stackSize
         elements = New T(stackSize - 1) {} ' create stackSize elements
      Else
         elements = New T(9) {} ' create 10 elements 
      End If

      top = -1 ' Stack initially empty
   End Sub ' New

   ' push element onto the Stack; if successful, return true
   ' otherwise, throw FullStackException
   Public Sub Push(pushValue As T)
      If top = elements.Length - 1 Then ' Stack is full
         Throw New FullStackException(String.Format(
            "Stack is full, cannot push {0}", pushValue))
      End If

      top += 1 ' increment top
      elements(top) = pushValue ' place pushValue on Stack
   End Sub ' Push

   ' return the top element if not empty
   ' else throw EmptyStackException
   Public Function Pop() As T
      If top = -1 Then ' Stack is empty
         Throw New EmptyStackException("Stack is empty, cannot pop")
      End If

      top -= 1 ' decrement top
      Return elements(top + 1) ' return top value
   End Function ' Pop 
End Class ' Stack


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