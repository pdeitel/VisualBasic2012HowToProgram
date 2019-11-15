' Fig. 11.2: LINQWithArrayOfIntegers.vb
' LINQ to Objects using an Integer array.
Public Class LINQWithArrayOfIntegers
   ' test several LINQ queries
   Private Sub LINQWithArrayOfIntegers_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' create an integer array
      Dim values() As Integer = {2, 9, 5, 0, 3, 7, 1, 4, 8, 6}

      ' display each element, separated by spaces
      outputTextBox.AppendText(String.Format(
         "Original array:{0}", vbCrLf))
      For Each element In values
         outputTextBox.AppendText("   " & element)
      Next

      ' LINQ query that obtains values greater than 4 from the array
      Dim filtered =
        From value In values
        Where (value > 4)
        Select value

      ' display filtered results
      outputTextBox.AppendText(String.Format(
         "{0}{0}Array values greater than 4:{0}", vbCrLf))
      For Each element In filtered
         outputTextBox.AppendText("   " & element)
      Next

      ' use Order By clause to sort original array in ascending order
      Dim sorted =
         From value In values
         Order By value
         Select value

      ' display sorted results
      outputTextBox.AppendText(String.Format(
         "{0}{0}Original array, sorted:{0}", vbCrLf))
      For Each element In sorted
         outputTextBox.AppendText("   " & element)
      Next

      ' sort the filtered results into descending order
      Dim sortFilteredResults =
         From value In filtered
         Order By value Descending
         Select value

      ' display the sorted results
      outputTextBox.AppendText(String.Format(
         "{0}{0}Values greater than 4, descending order (chained):{0}",
         vbCrLf))
      For Each element In sortFilteredResults
         outputTextBox.AppendText("   " & element)
      Next

      ' filter original array and sort in descending order
      Dim sortAndFilter =
         From value In values
         Where value > 4
         Order By value Descending
         Select value

      ' display the filtered and sorted results
      outputTextBox.AppendText(String.Format(
         "{0}{0}Values greater than 4, descending order (one query):{0}",
         vbCrLf))
      For Each element In sortAndFilter
         outputTextBox.AppendText("   " & element)
      Next
   End Sub ' LINQWithArrayOfIntegers_Load
End Class ' LINQWithArrayOfIntegers


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
