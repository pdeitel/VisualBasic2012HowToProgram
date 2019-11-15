' Fig. 16.7: SquareRootTest.vb
' SquareRootForm throws an exception if a negative number is entered.
Public Class SquareRootForm
   ' computes square root of parameter; throws 
   ' NegativeNumberException if parameter is negative
   Public Function SquareRoot(value As Double) As Double
      ' if negative operand, throw NegativeNumberException
      If value < 0.0 Then
         Throw New NegativeNumberException(
            "Square root of negative number not permitted")
      Else
         Return Math.Sqrt(value) ' compute square root
      End If
   End Function ' SquareRoot

   ' obtain user input, convert to double, calculate square root
   Private Sub squareRootButton_Click(sender As Object,
      e As EventArgs) Handles squareRootButton.Click

      outputLabel.Text = String.Empty ' clear outputLabel

      ' catch any NegativeNumberException thrown
      Try
         Dim result As Double =
         SquareRoot(Convert.ToDouble(inputTextBox.Text))

         outputLabel.Text = result.ToString()
      Catch formatExceptionParameter As FormatException
         MessageBox.Show(formatExceptionParameter.Message,
            "Invalid Number Format", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
      Catch negativeNumberExceptionParameter As NegativeNumberException
         MessageBox.Show(negativeNumberExceptionParameter.Message,
            "Invalid Operation", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
      End Try
   End Sub ' squareRootButton_Click
End Class ' SquareRootTest


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