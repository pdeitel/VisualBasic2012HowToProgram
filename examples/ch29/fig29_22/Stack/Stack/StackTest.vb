' Fig. 29.22: StackTest.vb
' Stack generic class test program.
Module StackTest
   ' create arrays of doubles and integers
   Dim doubleElements() As Double = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6}
   Dim integerElements() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}

   Dim doubleStack As Stack(Of Double) ' stack stores double objects
   Dim integerStack As Stack(Of Integer) ' stack stores integer objects

   Sub Main()
      doubleStack = New Stack(Of Double)(5) ' Stack of doubles
      integerStack = New Stack(Of Integer)(10) ' Stack of integers

      ' push doubles onto doubleStack
      TestPush("doubleStack", doubleStack, doubleElements)
      ' pop doubles from doubleStack
      TestPop("doubleStack", doubleStack)
      ' push integers onto integerStack
      TestPush("integerStack", integerStack, integerElements)
      ' pop integers from integerStack
      TestPop("integerStack", integerStack)
   End Sub ' Main

   Sub TestPush(Of T)(name As String, stack As Stack(Of T),
      elements() As T)
      ' push elements onto stack
      Try
         Console.WriteLine(vbCrLf & "Pushing elements onto " & name)

         ' push elements onto stack
         For Each element As T In elements
            Console.Write("{0} ", element)
            stack.Push(element) ' push onto stack
         Next element
      Catch exception As FullStackException
         Console.Error.WriteLine()
         Console.Error.WriteLine("Message: " & exception.Message)
         Console.Error.WriteLine(exception.StackTrace)
      End Try
   End Sub ' TestPush

   Sub TestPop(Of T)(name As String, stack As Stack(Of T))
      ' pop elements off stack
      Try
         Console.WriteLine(vbCrLf & "Popping elements from " & name)

         Dim popValue As T ' store element removed from stack

         ' remove all elements from Stack
         While True
            popValue = stack.Pop() ' pop from stack
            Console.Write("{0} ", popValue)
         End While
      Catch exception As EmptyStackException
         Console.Error.WriteLine()
         Console.Error.WriteLine("Message: " & exception.Message)
         Console.Error.WriteLine(exception.StackTrace)
      End Try
   End Sub ' TestPop
End Module ' StackTest


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