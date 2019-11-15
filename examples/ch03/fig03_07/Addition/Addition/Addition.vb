' Fig. 3.7: Addition.vb
' Addition program that adds two integers entered by the user.
Public Class Addition
   ' adds two integers and displays the result
    Private Sub addButton_Click(sender As Object,
       e As EventArgs) Handles addButton.Click

        Dim number1 As Integer ' first number entered by the user
        Dim number2 As Integer ' second number entered by the user
        Dim total As Integer ' sum of the two integers

        number1 = number1TextBox.Text ' get the first number entered 
        number2 = number2TextBox.Text ' get the second number entered
        total = number1 + number2 ' add the two numbers
        resultLabel.Text = "The sum is " & total ' display the total
    End Sub ' addButton_Click
End Class ' Addition

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************
