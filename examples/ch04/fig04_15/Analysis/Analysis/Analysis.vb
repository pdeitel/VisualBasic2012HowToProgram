' Fig. 4.15: Analysis.vb
' Nested control statements: Examination-results problem. 
Public Class Analysis
   ' place a result in the resultsListBox
   Private Sub submitResultButton_Click(sender As Object,
      e As EventArgs) Handles submitResultButton.Click

      If resultsListBox.Items.Count < 10 Then
         ' add the grade to the end of the resultsListbox
         resultsListBox.Items.Add(resultTextBox.Text)
         resultTextBox.Clear() ' clear the resultTextBox
         resultTextBox.Focus() ' select the resultTextBox
      End If

      ' determine whether to prevent the user from entering more results
      If resultsListBox.Items.Count = 10 Then
         submitResultButton.Enabled = False ' disables submitResultButton
         resultTextBox.Enabled = False ' disables resultTextBox
         analyzeResultsButton.Enabled = True ' enable analyzeResultsButton
      End If
   End Sub ' submitResultButton_Click

   ' analyze the results
   Private Sub analyzeResultsButton_Click(sender As Object,
      e As EventArgs) Handles analyzeResultsButton.Click

      ' initializing variables in declarations                        
      Dim passes As Integer = 0 ' number of passes                    
      Dim failures As Integer = 0 ' number of failures                
      Dim student As Integer = 0 ' student counter                    
      Dim result As String ' one exam result

      ' process 10 students using counter-controlled loop
      Do While student < 10
         result = resultsListBox.Items(student) ' get a result

         ' nested control statement                     
         If result = "P" Then
            passes += 1 ' increment number of passes    
         Else
            failures += 1 ' increment number of failures
         End If

         student += 1 ' increment student counter
      Loop

      ' display exam results
      analysisResultsLabel.Text =
         "Passed: " & passes & vbCrLf & "Failed: " & failures & vbCrLf

      ' raise tuition if more than 8 students passed
      If passes > 8 Then
         analysisResultsLabel.Text &= "Bonus to instructor!"
      End If
   End Sub ' analyzeResultsButton_Click

   ' clear the resultsListBox and analysisResultsLabel
   Private Sub clearResultsButton_Click(sender As Object,
      e As EventArgs) Handles clearResultsButton.Click

      resultsListBox.Items.Clear() ' removes all items
      analysisResultsLabel.Text = String.Empty ' clears the text
      submitResultButton.Enabled = True ' enables submitResultButton
      resultTextBox.Enabled = True ' enables resultTextBox
      analyzeResultsButton.Enabled = False ' disables analyzeResultsButton
      resultTextBox.Focus() ' select the resultTextBox
   End Sub ' clearResultsButton_Click
End Class ' Analysis

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
