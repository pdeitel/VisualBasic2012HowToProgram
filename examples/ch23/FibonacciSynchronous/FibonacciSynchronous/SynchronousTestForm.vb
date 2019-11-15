' Fig. 23.2: SynchronousTestForm.vb
' Fibonacci calculations performed sequentially
Public Class SynchronousTestForm
   ' start sequential calls to Fibonacci
   Private Sub startButton_Click(sender As Object, e As EventArgs) _
      Handles startButton.Click
      ' calculate Fibonacci (46)
      outputTextBox.Text = "Calculating Fibonacci(46)" & vbCrLf
      outputTextBox.Refresh() ' force outputTextBox to repaint

      Dim startTime1 As DateTime = DateTime.Now ' time before calculation
      Dim result1 As Long = Fibonacci(46) ' synchronous call
      Dim endTime1 As DateTime = DateTime.Now ' time after calculation

      ' display results for Fibonacci(46) 
      outputTextBox.AppendText(
         String.Format("Fibonacci(46) = {0}" & vbCrLf, result1))
      outputTextBox.AppendText(String.Format(
         "Calculation time = {0:F6} minutes" & vbCrLf & vbCrLf,
         endTime1.Subtract(startTime1).TotalMilliseconds / 60000.0))

      ' calculate Fibonacci (45)
      outputTextBox.AppendText("Calculating Fibonacci(45)" & vbCrLf)
      outputTextBox.Refresh() ' force outputTextBox to repaint
      Dim startTime2 As DateTime = DateTime.Now ' time before calculation
      Dim result2 As Long = Fibonacci(45) ' synchronous call
      Dim endTime2 As DateTime = DateTime.Now ' time after calculation

      ' display results for Fibonacci(45) 
      outputTextBox.AppendText(String.Format("Fibonacci( 45 ) = {0}" &
         vbCrLf, result2))
      outputTextBox.AppendText(String.Format(
         "Calculation time = {0:F6} minutes" & vbCrLf & vbCrLf,
         endTime2.Subtract(startTime2).TotalMilliseconds / 60000.0))

      ' show total calculation time
      outputTextBox.AppendText(String.Format(
         "Total calculation time = {0:F6} minutes" & vbCrLf,
         endTime2.Subtract(startTime1).TotalMilliseconds / 60000.0))
   End Sub ' startButton_Click

   ' Recursively calculates Fibonacci numbers
   Public Function Fibonacci(n As Long) As Long
      If n = 0 OrElse n = 1 Then
         Return n
      Else
         Return Fibonacci(n - 1) + Fibonacci(n - 2)
      End If
   End Function ' end Fibonacci
End Class ' SynchronousTestForm


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