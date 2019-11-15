' Fig. 12.24: JoiningTableData.vb
' Using LINQ to perform aggregate data from several tables.
Public Class JoiningTableData
   Private Sub JoiningTableData_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' Entity Framework DBContext
      Dim database As New BooksExamples.BooksEntities()

      ' get authors and ISBNs of each book they co-authored
      Dim authorsAndISBNs =
         From author In database.Authors
         From book In author.Titles
         Order By author.LastName, author.FirstName
         Select author.FirstName, author.LastName, book.ISBN

      outputTextBox.AppendText("Authors and ISBNs:")

      ' display authors and ISBNs in tabular format
      For Each element In authorsAndISBNs
         outputTextBox.AppendText(
            String.Format("{0}{1}{2,-10} {3,-10} {4,-10}", vbCrLf, vbTab,
             element.FirstName, element.LastName, element.ISBN))
      Next

      ' get authors and titles of each book they co-authored
      Dim authorsAndTitles =
         From book In database.Titles
         From author In book.Authors
         Order By author.LastName, author.FirstName, book.Title1
         Select author.FirstName, author.LastName, book.Title1

      outputTextBox.AppendText(vbCrLf & vbCrLf & "Authors and titles:")

      ' display authors and titles in tabular format
      For Each element In authorsAndTitles
         outputTextBox.AppendText(
            String.Format("{0}{1}{2,-10} {3,-10} {4}", vbCrLf, vbTab,
               element.FirstName, element.LastName, element.Title1))
      Next

      ' get authors and titles of each book 
      ' they co-authored; group by author
      Dim titlesByAuthor =
         From author In database.Authors
         Order By author.LastName, author.FirstName
         Select Name = author.FirstName & " " & author.LastName,
            Titles =
               From book In author.Titles
               Order By book.Title1
               Select book.Title1

      outputTextBox.AppendText(
         vbCrLf & vbCrLf & "Titles grouped by author:")

      ' display titles written by each author, grouped by author
      For Each author In titlesByAuthor
         ' display authors
         outputTextBox.AppendText(
            String.Format("{0}{1}{2}:", vbCrLf, vbTab, author.Name))

         ' display titles written by that author
         For Each title In author.Titles
            outputTextBox.AppendText(
               String.Format("{0}{1}{1}{2}", vbCrLf, vbTab, title))
         Next title
      Next author
   End Sub ' JoningTableData_Load
End Class ' JoiningTableData

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