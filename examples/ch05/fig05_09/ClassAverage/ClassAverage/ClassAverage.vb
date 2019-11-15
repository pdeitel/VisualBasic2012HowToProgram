' Fig. 5.9 ClassAverage.vb
' Counter-controlled repetition: Class-average problem.
Public Class ClassAverage
   ' variables declared in the class, but not inside the class's methods
   ' can be used in all of the class's methods
   Dim aCount As Integer ' count of A grades             
   Dim bCount As Integer ' count of B grades             
   Dim cCount As Integer ' count of C grades             
   Dim dCount As Integer ' count of D grades             
   Dim fCount As Integer ' count of F grades
   Dim perfectScoreCount As Integer ' count of perfect scores

   ' places a grade in the gradesListBox
   Private Sub submitGradeButton_Click(sender As Object,
      e As EventArgs) Handles submitGradeButton.Click

      Dim grade As Integer = Val(gradeTextBox.Text) ' get grade

      ' add the grade to the end of the gradesListBox
      gradesListBox.Items.Add(grade)
      gradeTextBox.Clear() ' clear the gradeTextBox

      ' add 1 to appropriate counter for specified grade
      Select Case grade ' determine which grade was entered
         Case 100 ' perfect score
            perfectScoreCount += 1 ' increment perfectScoreCount
            aCount += 1 ' increment aCount
         Case 90 To 99 ' grade was between 90 and 99
            aCount += 1 ' increment aCount
         Case 80 To 89 ' grade was between 80 and 89
            bCount += 1 ' increment bCount
         Case 70 To 79 ' grade was between 70 and 79
            cCount += 1 ' increment cCount
         Case 60 To 69 ' grade was between 60 and 69
            dCount += 1 ' increment dCount
         Case Else ' grade was less than 60
            fCount += 1 ' increment fCount
      End Select

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
         average = total / gradeCounter ' calculate average

         ' display total and average (with two digits of precision)
         classAverageLabel.Text = "Total of the " & gradeCounter &
            " grade(s) is " & total & vbCrLf & "Class average is " &
            String.Format("{0:F}", average) & vbCrLf & vbCrLf

         ' display summary of letter grades
         classAverageLabel.Text &=
            "Letter grade summary:" & vbCrLf & "A: " & aCount &
            vbCrLf & "B: " & bCount & vbCrLf & "C: " & cCount &
            vbCrLf & "D: " & dCount & vbCrLf & "F: " & fCount &
            vbCrLf & "Perfect scores: " & perfectScoreCount
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
