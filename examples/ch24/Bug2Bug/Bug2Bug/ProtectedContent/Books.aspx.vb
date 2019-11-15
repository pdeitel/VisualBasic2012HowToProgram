' Fig. 24.11: Books.aspx.vb
' Code-behind file for the password-protected Books page.
Imports System.Data.Entity
Imports System.Linq

Public Class Books
   Inherits System.Web.UI.Page

   ' Entity Framework DbContext
   Private dbcontext As New BooksEntities()

   ' Load event handler for Books page
   Protected Sub Page_Load(sender As Object,
      e As EventArgs) Handles Me.Load
      ' if this is the first time the page is loading
      If (Not IsPostBack) Then
         dbcontext.Authors.Load() ' load Authors table into memory

         ' LINQ query that populates authorsDropDownList
         Dim authorsQuery =
            From author In dbcontext.Authors.Local
            Order By author.LastName, author.FirstName
            Select Name = author.LastName + ", " + author.FirstName,
               author.AuthorID

         ' specify the field used as the selected value
         authorsDropDownList.DataValueField = "AuthorID"

         ' specify the field displayed in the DropDownList
         authorsDropDownList.DataTextField = "Name"

         ' set authorsQuery as the authorsDropDownList's data source
         authorsDropDownList.DataSource = authorsQuery

         authorsDropDownList.DataBind() ' displays query results
      End If
   End Sub ' Page_Load

   ' display selected author's books
   Protected Sub authorsDropDownList_SelectedIndexChanged(
      sender As Object, e As EventArgs) _
      Handles authorsDropDownList.SelectedIndexChanged

      dbcontext.Authors.Load() ' load Authors table into memory

      ' use LINQ to get Author object for the selected author
      Dim selectedAuthor As Author =
         (From author In dbcontext.Authors.Local
          Where author.AuthorID = Convert.ToInt32(
             authorsDropDownList.SelectedValue)
          Select author).First()

      ' query to get books for the selected author
      Dim titlesQuery =
         From book In selectedAuthor.Titles
         Order By book.Title1
         Select book

      ' set titlesQuery as the titlesGridView's data source
      titlesGridView.DataSource = titlesQuery
      titlesGridView.DataBind() ' displays query results  
   End Sub ' authorsDropDownList_SelectedIndexChanged
End Class ' Books



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
