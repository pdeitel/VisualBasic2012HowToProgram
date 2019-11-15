' Fig. 7.20: GradeReport.vb
' Grade Book using a rectangular array.
Public Class GradeReport
   Dim grades(9, 2) As Integer ' stores 10 students' grades on 3 tests
   Dim studentCount As Integer = 0 ' number of students entered

   ' display heading in gradeListBox
   Private Sub GradeReport_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load
      ' headings row for gradesListBox
      gradesListBox.Items.Add(vbTab & vbTab & "Test 1" & vbTab &
         "Test 2" & vbTab & "Test 3" & vbTab & "Average")
   End Sub

   ' process one student's grades
   Private Sub submitButton_Click(sender As Object,
      e As EventArgs) Handles submitButton.Click

      ' retrieve the student's grades
      grades(studentCount, 0) = Convert.ToInt32(test1TextBox.Text)
      grades(studentCount, 1) = Convert.ToInt32(test2TextBox.Text)
      grades(studentCount, 2) = Convert.ToInt32(test3TextBox.Text)

      ' begin creating String containing the student's grades and average
      Dim output As String = "Student " & studentCount & vbTab

      ' append each test grade to the output
      For column = 0 To grades.GetUpperBound(1)
         ' if the Letter RadioButton is checked
         If letterRadioButton.Checked = True Then
            ' append letter grade to the output
            output &= vbTab & LetterGrade(grades(studentCount, column))
         Else
            ' append number grade to the output
            output &= vbTab & grades(studentCount, column)
         End If
      Next

      ' append the student's test average to the output
      output &= vbTab & CalculateStudentAverage(studentCount)

      gradesListBox.Items.Add(output) ' add output to the ListBox
      studentCount += 1 ' update number of students entered
      averageLabel.Text = CalculateClassAverage() ' display class average
      DisplayBarChart() ' display the current grade distribution

      ' clear the input TextBoxes and set focus to first TextBox
      test1TextBox.Clear()
      test2TextBox.Clear()
      test3TextBox.Clear()
      test1TextBox.Focus()

      ' limit number of students
      If studentCount = grades.GetUpperBound(0) + 1 Then
         inputGradesGroupBox.Enabled = False ' disable GroupBox's controls
      End If
   End Sub ' submitButton_Click

   ' handles Numeric and Letter RadioButtons' CheckChanged events
   Private Sub RadioButton_CheckedChanged(sender As Object,
      e As EventArgs) _
      Handles numericRadioButton.CheckedChanged,
         letterRadioButton.CheckedChanged

      ' if there are grades to display, call DisplayClassGrades
      If studentCount > 0 Then
         DisplayClassGrades()
      End If
   End Sub ' RadioButton_CheckedChanged

   ' calculates a student's test average
   Function CalculateStudentAverage(row As Integer) As String
      Dim gradeTotal As Integer = 0 ' student's total grade

      ' sum the grades for the student
      For column = 0 To grades.GetUpperBound(1)
         gradeTotal += grades(row, column)
      Next

      Dim studentAverage As String = String.Empty ' output string

      ' calculate the student's test average
      If letterRadioButton.Checked = True Then
         studentAverage =
            LetterGrade(gradeTotal / (grades.GetUpperBound(1) + 1))
      Else
         studentAverage = String.Format("{0:F}",
            (gradeTotal / (grades.GetUpperBound(1) + 1)))
      End If

      Return studentAverage ' return the student's average
   End Function ' CalculateStudentAverage

   ' calculates the class average
   Function CalculateClassAverage() As String
      Dim classTotal As Integer = 0 ' class's total grade

      ' loop through all rows that currently contain grades
      For row = 0 To studentCount - 1
         ' loop through all columns
         For column = 0 To grades.GetUpperBound(1)
            classTotal += grades(row, column) ' add grade to total
         Next column
      Next row

      Dim classAverage As String = String.Empty ' output string

      ' if the Letter RadioButton is checked, return letter grade
      If letterRadioButton.Checked = True Then
         classAverage = LetterGrade(classTotal /
            (studentCount * (grades.GetUpperBound(1) + 1)))
      Else ' return numeric grade
         classAverage = String.Format("{0:F}", (classTotal /
            (studentCount * (grades.GetUpperBound(1) + 1))))
      End If

      Return classAverage ' return the class average
   End Function ' CalculateClassAverage

   ' determines a letter grade corresponding to a numeric grade
   Function LetterGrade(grade As Double) As String
      Dim output As String ' the letter grade to return

      ' determine the correct letter grade
      Select Case grade
         Case Is >= 90
            output = "A"
         Case Is >= 80
            output = "B"
         Case Is >= 70
            output = "C"
         Case Is >= 60
            output = "D"
         Case Else
            output = "F"
      End Select

      Return output ' return the letter grade
   End Function ' LetterGrade

   ' display the grades for all students entered
   Sub DisplayClassGrades()
      gradesListBox.Items.Clear() ' clear the ListBox

      ' add the header to the ListBox
      gradesListBox.Items.Add(vbTab & vbTab & "Test 1" & vbTab &
         "Test 2" & vbTab & "Test 3" & vbTab & "Average")

      ' loop through all the rows
      For row = 0 To studentCount - 1
         Dim output As String = "Student " & row & vbTab

         ' loop through all the columns
         For column = 0 To grades.GetUpperBound(1)
            If letterRadioButton.Checked = True Then
               ' add letter grade to output string
               output &= vbTab & LetterGrade(grades(row, column))
            Else
               ' add number grade to output string
               output &= vbTab & (grades(row, column))
            End If
         Next column

         ' add the student's average to the output
         output &= vbTab & CalculateStudentAverage(row)

         ' add the output to the ListBox
         gradesListBox.Items.Add(output)
      Next row

      ' update the class average
      averageLabel.Text = CalculateClassAverage()
   End Sub ' DisplayClassGrades

   ' display a bar chart of the grade distribution
   Sub DisplayBarChart()
      barChartListBox.Items.Clear() ' remove current items

      ' stores frequency of grades in each range of 10 grades
      Dim frequency(10) As Integer

      ' for each grade, increment the appropriate frequency
      For row = 0 To studentCount - 1
         For column = 0 To grades.GetUpperBound(1)
            frequency(grades(row, column) \ 10) += 1
         Next column
      Next row

      ' for each grade frequency, display bar of asterisks
      For count = 0 To frequency.GetUpperBound(0)
         Dim bar As String ' stores the label and bar

         ' create bar label ( "00-09: ", ..., "90-99: ", "100: " )
         If count = 10 Then
            bar = String.Format("{0, 5:D}: ", 100)
         Else
            bar = String.Format("{0, 2:D2}-{1, 2:D2}: ",
               count * 10, count * 10 + 9)
         End If

         ' append bar of asterisks
         For stars = 1 To frequency(count)
            bar &= ("*")
         Next

         barChartListBox.Items.Add(bar) ' display bar
      Next count
   End Sub ' DisplayBarChart
End Class ' GradeReport

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