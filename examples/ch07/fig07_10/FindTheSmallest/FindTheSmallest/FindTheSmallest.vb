' Fig. 7.10: FindTheSmallest.vb
' Using a For Each...Next loop to find the smallest value in an array.
Public Class FindTheSmallest
   Dim gradesArray(9) As Integer ' create 10-element array
   Dim randomNumber As New Random()

   ' creates random generated numbers
   Private Sub createGradesButton_Click(sender As Object,
      e As EventArgs) Handles createGradesButton.Click

      gradesListBox.Items.Clear() ' clear gradesListBox
      smallestGradeResultLabel.Text = String.Empty ' clear Label  

      ' create 10 random numbers and append to output
      For i = 0 To gradesArray.GetUpperBound(0)
         gradesArray(i) = randomNumber.Next(100)
         gradesListBox.Items.Add(gradesArray(i))
      Next

      findSmallestButton.Enabled = True ' enable Find Smallest button
   End Sub ' createGradesButton_Click

   ' finds smallest randomly generated number
   Private Sub findSmallestButton_Click(sender As Object,
      e As EventArgs) Handles findSmallestButton.Click

      Dim lowGrade As Integer = 100 ' start with the maximum grade value

      ' use For Each...Next to find the minimum grade
      For Each grade In gradesArray
         If grade < lowGrade Then
            lowGrade = grade ' current grade is the lowest one so far
         End If
      Next

      smallestGradeResultLabel.Text = Convert.ToString(lowGrade)
      findSmallestButton.Enabled = False ' disable Find Smallest button
   End Sub ' findSmallestButton_Click
End Class ' FindTheSmallest


' **************************************************************************
' * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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
