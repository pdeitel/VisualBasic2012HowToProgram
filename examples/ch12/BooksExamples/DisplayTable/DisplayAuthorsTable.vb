' Fig. 22.20: DisplayAuthorsTable.vb
' Displaying data from a database table in a DataGridView.
Imports System.Data.Entity
Imports System.Data.Entity.Validation

Public Class DisplayAuthorsTable
   ' Entity Framework DBContext
   Private dbcontext As New BooksExamples.BooksEntities()

   ' load data from database into DataGridView
   Private Sub DisplayAuthorsTable_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' load Authors table ordered by LastName then FirstName
      With dbcontext.Authors
         .OrderBy(Function(currentAuthor) currentAuthor.LastName)
         .ThenBy(Function(currentAuthor) currentAuthor.FirstName)
         .Load()
      End With

      ' specify DataSource for AuthorBindingSource
      AuthorBindingSource.DataSource = dbcontext.Authors.Local
   End Sub ' DisplayAuthorsTable_Load

   ' click event handler for the Save Button in the 
   ' BindingNavigator saves the changes made to the data
   Private Sub AuthorBindingNavigatorSaveItem_Click(sender As Object,
      e As EventArgs) Handles AuthorBindingNavigatorSaveItem.Click

      Validate() ' validate the input fields
      AuthorBindingSource.EndEdit() ' complete current edit, if any

      ' try to save changes
      Try
         dbcontext.SaveChanges() ' write changes to database file
      Catch ex As DbEntityValidationException
         MessageBox.Show("FirstName and LastName must contain values",
            "Entity Validation Exception")
      End Try
   End Sub ' AuthorBindingNavigatorSaveItem_Click
End Class ' DisplayAuthorsTable

'**************************************************************************
'* (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
'* Pearson Education, Inc. All Rights Reserved.                           *
'*                                                                        *
'* DISCLAIMER: The authors and publisher of this book have used their     *
'* best efforts in preparing the book. These efforts include the          *
'* development, research, and testing of the theories and programs        *
'* to determine their effectiveness. The authors and publisher make       *
'* no warranty of any kind, expressed or implied, with regard to these    *
'* programs or to the documentation contained in these books. The authors *
'* and publisher shall not be liable in any event for incidental or       *
'* consequential damages in connection with, or arising out of, the       *
'* furnishing, performance, or use of these programs.                     *
'**************************************************************************
