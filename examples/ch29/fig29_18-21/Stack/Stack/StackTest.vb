' Fig. 29.21: StackTest.vb
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

      TestPushDouble() ' push doubles onto doubleStack
      TestPopDouble() ' pop doubles from doubleStack
      TestPushInteger() ' push integers onto integerStack
      TestPopInteger() ' pop integers from integerStack
   End Sub ' Main

   ' test Push method with doubleStack
   Sub TestPushDouble()
      ' push elements onto stack
      Try
         Console.WriteLine(vbCrLf &
            "Pushing elements onto doubleStack")

         ' push elements onto stack
         For Each element As Double In doubleElements
            Console.Write("{0:F1} ", element)
            doubleStack.Push(element) ' push onto doubleStack
         Next element
      Catch exception As FullStackException
         Console.Error.WriteLine()
         Console.Error.WriteLine("Message: " & exception.Message)
         Console.Error.WriteLine(exception.StackTrace)
      End Try
   End Sub ' TestPushDouble

   ' test Pop method with doubleStack
   Sub TestPopDouble()
      ' pop elements from stack
      Try
         Console.WriteLine(vbCrLf &
            "Popping elements from doubleStack")
         Dim popValue As Double ' store element removed from stack

         ' remove all elements from Stack
         While True
            popValue = doubleStack.Pop() ' pop from doubleStack
            Console.Write("{0:F1} ", popValue)
         End While
      Catch exception As EmptyStackException
         Console.Error.WriteLine()
         Console.Error.WriteLine("Message: " & exception.Message)
         Console.Error.WriteLine(exception.StackTrace)
      End Try
   End Sub ' TestPopDouble

   ' test Push method with integerStack
   Sub TestPushInteger()
      ' push elements onto stack
      Try
         Console.WriteLine(vbCrLf &
            "Pushing elements onto integerStack")

         ' push elements onto stack
         For Each element As Integer In integerElements
            Console.Write("{0} ", element)
            integerStack.Push(element) ' push onto integerStack
         Next element
      Catch exception As FullStackException
         Console.Error.WriteLine()
         Console.Error.WriteLine("Message: " & exception.Message)
         Console.Error.WriteLine(exception.StackTrace)
      End Try
   End Sub ' TestPushInteger

   ' test Pop method with integerStack
   Sub TestPopInteger()
      ' pop elements from stack
      Try
         Console.WriteLine(vbCrLf &
            "Popping elements from integerStack")
         Dim popValue As Integer ' store element removed from stack

         ' remove all elements from Stack
         While True
            popValue = integerStack.Pop() ' pop from integerStack
            Console.Write("{0} ", popValue)
         End While
      Catch exception As EmptyStackException
         Console.Error.WriteLine()
         Console.Error.WriteLine("Message: " & exception.Message)
         Console.Error.WriteLine(exception.StackTrace)
      End Try
   End Sub ' TestPopInteger
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