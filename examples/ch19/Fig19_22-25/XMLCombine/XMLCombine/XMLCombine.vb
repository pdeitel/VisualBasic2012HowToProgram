' Fig. 19.22: XMLCombine.vb
' Transforming an XML document and splicing its contents with another.
Imports <xmlns:old="http://www.deitel.com/employeesold">
Imports <xmlns="http://www.deitel.com/employeesnew">

Module XMLCombine
   Sub Main()
      ' do processing in a Try block to catch errors
      Try
         ' attempt to load files
         Dim newDocument = XDocument.Load("employeesNew.xml")
         Dim oldDocument = XDocument.Load("employeesOld.xml")

         ' convert from old to new format
         oldDocument = Transform(oldDocument)

         ' combine documents and write to output file
         SaveFinalDocument(newDocument, oldDocument)

         ' tell user we succeeded
         Console.WriteLine("Documents successfully combined.")
      Catch ' catch everything
         ' inform the user that there was a problem combining
         Console.WriteLine("Files could not be combined.")
         Console.WriteLine("This was probably caused by an I/O error.")
      End Try
   End Sub ' Main

   ' convert the given XDocument in the old format to the new format
   Private Function Transform(ByVal document As XDocument) As XDocument
      ' use a LINQ query, embedded in an XML literal, to fill the new
      ' XML root with the correct data; the values within each employee
      ' listing become attributes in the new document
      Dim newDocumentRoot =
         <employeelist>
            <%= From employee In document.Root.Elements()
               Select
               <employee name=
                  <%= employee.<old:firstname>.Value &
                     " " & employee.<old:lastname>.Value %>
                  salary=<%= employee.<old:salary>.Value %>/>
            %>
         </employeelist>

      Return New XDocument(newDocumentRoot) ' return transformed document
   End Function ' Transform

   ' take two validated XDocuments and combine
   ' them into one, then save to output.xml
   Private Sub SaveFinalDocument(ByVal document1 As XDocument,
      ByVal document2 As XDocument)

      ' create root element, and fill with the elements
      ' contained in the roots of both documents
      Dim root =
         <employeelist>
            <%= document1.Root.Elements() %>
            <%= document2.Root.Elements() %>
         </employeelist>

      Dim finalDocument As New XDocument(root) ' create new document
      finalDocument.Save("output.xml") ' save document to file
   End Sub ' SaveFinalDocument
End Module ' XMLCombine

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
