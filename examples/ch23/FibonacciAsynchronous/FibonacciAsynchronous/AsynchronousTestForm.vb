' Fig. 28.3: AsynchronousTestForm.vb
' Fibonacci calculations performed in separate threads
Public Class AsynchronousTestForm
   ' start asynchronous calls to Fibonacci
   Private Async Sub startButton_Click(sender As Object,
      e As EventArgs) Handles startButton.Click
      outputTextBox.Text = "Starting Task to calculate Fibonacci(46)" &
         vbCrLf

      ' create Task to perform Fibonacci(46) calculation in a thread
      Dim task1 As Task(Of TimeData) =
         Task.Run(Function() StartFibonacci(46))

      outputTextBox.AppendText(
         "Starting Task to calculate Fibonacci(45)" & vbCrLf)

      ' create Task to perform Fibonacci(45) calculation in a thread
      Dim task2 As Task(Of TimeData) =
         Task.Run(Function() StartFibonacci(45))

      Await Task.WhenAll(task1, task2) ' wait for both to complete

      ' determine time that first thread started
      Dim startTime As DateTime =
         If((task1.Result.StartTime < task2.Result.StartTime),
            task1.Result.StartTime, task2.Result.StartTime)

      ' determine time that last thread ended
      Dim endTime As DateTime =
         If((task1.Result.EndTime > task2.Result.EndTime),
            task1.Result.EndTime, task2.Result.EndTime)

      ' display total time for calculations
      outputTextBox.AppendText(String.Format(
         "Total calculation time = {0:F6} minutes" & vbCrLf,
         endTime.Subtract(startTime).TotalMilliseconds / 60000.0))
   End Sub ' startButton_Click

   ' starts a call to fibonacci and captures start/end times
   Private Function StartFibonacci(n As Integer) As TimeData
      ' create a TimeData object to store start/end times
      Dim result As New TimeData()

      AppendText(String.Format("Calculating Fibonacci({0})", n))
      result.StartTime = DateTime.Now ' time before calculation
      Dim fibonacciValue As Long = Fibonacci(n)
      result.EndTime = DateTime.Now ' time after calculation
      AppendText(String.Format("Fibonacci({0}) = {1}", n,
         fibonacciValue))
      AppendText(String.Format("Calculation time = {0:F6} minutes" &
         vbCrLf, result.EndTime.Subtract(
            result.StartTime).TotalMilliseconds / 60000.0))

      Return result
   End Function ' StartFibonacci

   ' Recursively calculates Fibonacci numbers
   Public Function Fibonacci(n As Long) As Long
      If n = 0 OrElse n = 1 Then
         Return n
      Else
         Return Fibonacci(n - 1) + Fibonacci(n - 2)
      End If
   End Function ' Fibonacci

   ' append text to outputTextBox in UI thread
   Public Sub AppendText(text As String)
      If InvokeRequired Then
         ' not GUI thread, so add to GUI thread
         Invoke(New MethodInvoker(Sub() AppendText(text)))
      Else
         ' GUI thread so append text
         outputTextBox.AppendText(text & vbCrLf)
      End If
   End Sub ' AppendText
End Class ' AsynchronousTestForm


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