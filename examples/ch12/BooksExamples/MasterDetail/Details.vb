' Fig. 12.31: Details.vb
' Using a DataGridView to display details based on a selection.
Imports System.Data.Entity
Imports System.Linq

Public Class Details
   ' Entity Framework DBContext
   Private dbcontext As New BooksExamples.BooksEntities()

   ' initialize data sources when the Form is loaded
   Private Sub Details_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' load Authors table ordered by LastName then FirstName
      dbcontext.Authors _
         .OrderBy(Function(author) author.LastName) _
         .ThenBy(Function(author) author.FirstName) _
         .Load()

      ' specify DataSource for AuthorBindingSource
      AuthorBindingSource.DataSource = dbcontext.Authors.Local
   End Sub ' Details_Load
End Class ' Details

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
