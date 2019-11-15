' Fig. 7.4: StudentPoll.vb
' Using arrays to summarize poll results.
Public Class StudentPoll
   ' summarize and display poll results
   Private Sub StudentPoll_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' student response array (more typically, input at run time)
      Dim responses As Integer() = _
         {1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, 14}

      ' response frequency array (indices 0 through 5)
      Dim frequency(5) As Integer

      ' count frequencies
      For answer = 0 To responses.GetUpperBound(0)
         Try
            frequency(responses(answer)) += 1
         Catch ex As IndexOutOfRangeException
            MessageBox.Show(String.Format("{0}{1}responses({2}) = {3}",
               ex.Message, vbCrLf, answer, responses(answer)),
               "IndexOutOfRangeException",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
         End Try
      Next

      outputTextBox.AppendText("Rating" & vbTab & "Frequency" & vbCrLf)

      ' display output, ignore element 0 of frequency
      For rating = 1 To frequency.GetUpperBound(0)
         outputTextBox.AppendText(
            rating & vbTab & frequency(rating) & vbCrLf)
      Next
   End Sub ' StudentPoll_Load
End Class ' StudentPoll


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
