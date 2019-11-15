' Fig. 4.12: ClassAverage.vb
' Counter-controlled repetition: Class-average problem.
Public Class ClassAverage
   ' places a grade in the gradesListBox
   Private Sub submitGradeButton_Click(sender As Object,
      e As EventArgs) Handles submitGradeButton.Click

      ' if the user entered a grade
      If gradeTextBox.Text <> String.Empty Then
         ' add the grade to the end of the gradesListBox
         gradesListBox.Items.Add(gradeTextBox.Text)
         gradeTextBox.Clear() ' clear the gradeTextBox
      End If
      
      gradeTextBox.Focus() ' gives the focus to the gradeTextBox
   End Sub ' submitGradeButton_Click

   ' calculates the class average based on the grades in gradesListBox
   Private Sub calculateAverageButton_Click(sender As Object,
      e As EventArgs) Handles calculateAverageButton.Click

      Dim total As Integer ' sum of grades entered by user
      Dim gradeCounter As Integer ' counter for grades 
      Dim grade As Integer ' grade input by user
      Dim average As Double ' average of grades

      ' initialization phase
      total = 0 ' set total to zero before adding grades to it
      gradeCounter = 0 ' prepare to loop

      ' processing phase
      Do While gradeCounter < gradesListBox.Items.Count
         grade = gradesListBox.Items(gradeCounter) ' get next grade
         total += grade ' add grade to total
         gradeCounter += 1 ' add 1 to gradeCounter
      Loop

      ' termination phase
      If gradeCounter <> 0 Then
         average = total / gradesListBox.Items.Count ' calculate average

         ' display total and average (with two digits of precision)
         classAverageLabel.Text = "Total of the " & gradeCounter &
            " grade(s) is " & total & vbCrLf & "Class average is " &
            String.Format("{0:F}", average)
      Else
         classAverageLabel.Text = "No grades were entered"
      End If
   End Sub ' calculateAverageButton_Click

   ' clears grades from gradeListBox and results from classAverageLabel
   Private Sub clearGradesButton_Click(sender As Object,
      e As EventArgs) Handles clearGradesButton.Click

      gradesListBox.Items.Clear() ' removes all items from gradesListBox
      classAverageLabel.Text = String.Empty ' clears classAverageLabel
   End Sub ' clearGradesButton_Click
End Class ' ClassAverage

' **************************************************************************
' * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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
