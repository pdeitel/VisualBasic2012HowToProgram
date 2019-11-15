' Fig. 16.2: DivideByZeroTest.vb
' FormatException and DivideByZeroException exception handlers.
Public Class DivideByZeroTest
   ' obtain 2 integers from the user 
   ' and divide numerator by denominator
   Private Sub divideButton_Click(sender As Object,
      e As EventArgs) Handles divideButton.Click

      outputLabel.Text = String.Empty ' clear Label outputLabel

      ' retrieve user input and calculate quotient
      Try
         ' Convert.ToInt32 generates FormatException
         ' if argument cannot be converted to an integer
         Dim numerator As Integer =
            Convert.ToInt32(numeratorTextBox.Text)
         Dim denominator As Integer =
            Convert.ToInt32(denominatorTextBox.Text)

         ' division generates DivideByZeroException 
         ' if denominator is 0
         Dim result As Integer = numerator \ denominator

         ' display result in outputLabel
         outputLabel.Text = result.ToString()
      Catch formatExceptionParameter As FormatException
         MessageBox.Show("You must enter two integers.",
            "Invalid Number Format", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
      Catch divideByZeroExceptionParameter As DivideByZeroException
         MessageBox.Show(divideByZeroExceptionParameter.Message,
            "Attempted to Divide by Zero", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
      End Try
   End Sub ' divideButton_Click
End Class ' DivideByZeroTest

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