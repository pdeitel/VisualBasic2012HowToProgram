' Fig. 23.1: FibonacciForm.vb
' Performing a compute-intensive calculation from a GUI app
Public Class FibonacciForm
   Private n1 As Long = 0 ' initialize with first Fibonacci number
   Private n2 As Long = 1 ' initialize with second Fibonacci number
   Private count As Integer = 1 ' current Fibonacci number to display

   ' start an async Task to calculate specified Fibonacci number
   Private Async Sub calculateButton_Click(sender As Object,
      e As EventArgs) Handles calculateButton.Click
      ' retrieve user's input as an integer
      Dim number As Integer = Convert.ToInt32(inputTextBox.Text)

      asyncResultLabel.Text = "Calculating..."

      ' Task to perform Fibonacci calculation in separate thread
      Dim fibonacciTask As Task(Of Long) =
         Task.Run(Function() Fibonacci(number))

      ' wait for Task in separate thread to complete 
      Await fibonacciTask

      ' display result after Task in separate thread completes
      asyncResultLabel.Text = fibonacciTask.Result.ToString()
   End Sub ' calculateButton_Click

   ' calculate next Fibonacci number iteratively
   Private Sub nextNumberButton_Click(sender As Object,
      e As EventArgs) Handles nextNumberButton.Click
      ' calculate the next Fibonacci number 
      Dim temp As Long = n1 + n2 ' calculate next Fibonacci number
      n1 = n2 ' store prior Fibonacci number in n1
      n2 = temp ' store new Fibonacci
      count += 1

      ' display the next Fibonacci number
      displayLabel.Text = String.Format("Fibonacci of {0}:", count)
      syncResultLabel.Text = n2.ToString()
   End Sub ' nextNumberButton_Click

   ' recursive Fibonacci; calculates nth Fibonacci number
   Public Function Fibonacci(n As Long) As Long
      If n = 0 OrElse n = 1 Then
         Return n
      Else
         Return Fibonacci(n - 1) + Fibonacci(n - 2)
      End If
   End Function ' Fibonacci
End Class ' FibonacciForm

'************************************************************************
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
'************************************************************************