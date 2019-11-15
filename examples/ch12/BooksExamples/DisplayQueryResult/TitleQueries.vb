' Fig. 12.22: TitleQueries.vb
' Displaying the result of a user-selected query in a DataGridView.
Imports System.Data.Entity
Imports System.Linq

Public Class TitleQueries
   ' Entity Framework DBContext
   Private dbcontext As New BooksExamples.BooksEntities()

   ' display results of all titles query when Form loads
   Private Sub TitleQueries_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      dbcontext.Titles.Load() ' load Titles table into memory

      ' set the ComboBox to show the default query that 
      ' selects all books from the Titles table and causes the 
      ' queriesComboBox's SelectedIndexChanged event handler to execute
      queriesComboBox.SelectedIndex = 0
   End Sub ' TitleQueries_Load

   ' loads data into TitleBindingSource based on user-selected query
   Private Sub queriesComboBox_SelectedIndexChanged(sender As Object,
      ByVal e As EventArgs) Handles queriesComboBox.SelectedIndexChanged

      ' set the data displayed according to what is selected
      Select Case queriesComboBox.SelectedIndex
         Case 0 ' all titles
            ' use LINQ to order the books by title
            TitleBindingSource.DataSource =
               dbcontext.Titles.Local.OrderBy(Function(book) book.Title1)
         Case 1 ' titles with 2014 copyright
            ' use LINQ to get titles with 2014 copyright and sort them
            TitleBindingSource.DataSource =
               dbcontext.Titles.Local _
                  .Where(Function(book) book.Copyright = "2014") _
                  .OrderBy(Function(book) book.Title1)
         Case 2 ' titles ending with "How to Program"
            ' use LINQ to get titles ending with
            ' "How to Program" and sort them
            TitleBindingSource.DataSource =
               dbcontext.Titles.Local _
                  .Where(Function(book) book.Title1.EndsWith(
                     "How to Program")) _
                  .OrderBy(Function(book) book.Title1)
      End Select

      TitleBindingSource.MoveFirst() ' move to first entry
   End Sub ' queriesComboBox_SelectedIndexChanged
End Class ' TitleQueries

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