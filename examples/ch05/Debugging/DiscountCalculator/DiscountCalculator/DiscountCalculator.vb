' Exercise 5.19: Discount.vb
Public Class DiscountCalculator
   ' display user's discount
   Private Sub viewDiscountButton_Click(sender As Object, 
      e As EventArgs) Handles viewDiscountButton.Click

      Dim total As Integer = Val(amountTextBox.Text) ' get amount spent
      Dim output As String = String.Empty ' displays discount

      Select Case total
         Case Is > 200 ' user spent over $200
         Case 50 To 99 ' user spent between $50-99
            output = "Your discount is: 2%"
         Case 100 To 150 ' user spent between $100-150
            output = "Your discount is: 5%"
         Case 150 To 200 ' use spent between $150-199
            output = "Your discount is: 10%"
         Case Is > 200 ' user spent over $200
            output = "Your discount is: 15%"
         Case Else ' user spent less than $50
            output = "No discount"
      End Select

      ' display discount to user
      MessageBox.Show(output, "Discount", 
         MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub ' viewDiscountButton_Click
End Class ' DiscountCalculator

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