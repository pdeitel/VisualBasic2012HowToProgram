' Fig. 19.26: LINQTransformer.vb
' Transforming an XML document to XHTML using XML literals.
Public Class LINQTransformer
   ' open the file dialog for the file to be converted
   Private Sub browseButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles browseButton.Click

      ' make sure the user clicks OK
      If xmlOpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
         ' user clicked OK
         fileTextBox.Text = xmlOpenDialog.FileName
      End If
   End Sub ' browseButton_Click

   ' convert the specified file to XHTML
   Private Sub convertButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles convertButton.Click

      Dim document As XElement = Nothing

      ' attempt to load the XML document
      Try
         document = XElement.Load(fileTextBox.Text)
      Catch ex As Exception
         MessageBox.Show("Error: File could not be read.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
         Return ' loading failed, give up
      End Try

      Dim totalPages As Integer = 0 ' store total pages in document

      ' determine the number of total pages in the document;
      ' the Descendants method is used because the frontmatter
      ' elements are one level down from the other chapters
      For Each section In document.<chapters>.Descendants()
         totalPages += Convert.ToInt32(section.@pages)
      Next

      ' define the XHTML document
      Dim xhtmlPage As XElement =
         <html>
            <head>
               <title>
                  ISBN <%= document.@isbn & "-" &
                          document.<title>.Value %>
               </title>
            </head>

            <body>
               <h1 style="color: blue">
                  <%= document.<title>.Value %></h1>
               <h2 style="color: blue">
                  by <%= document.<author>.<firstName>.Value & " " &
                        document.<author>.<lastName>.Value %>
               </h2>

               <table style="border-style: groove; 
                  background-color: gold">
                  <!-- use a LINQ query to create table rows for -->
                  <!-- each <frontMatter> element in the document; -->
                  <!-- this row contains a column for name and a -->
                  <!-- column for pages -->
                  <%= From element In
                     document.<chapters>.<frontMatter>.Elements()
                     Select
                     <tr>
                        <td style="text-align: right">
                           <%= element.Name.LocalName %>
                        </td>

                        <td>
                           <!-- retrieve the pages attribute -->
                           <!-- from the element -->
                           ( <%= element.@pages & " pages" %> )
                        </td>
                     </tr> %>

                  <!-- the Order By clause sorts the chapters -->
                  <!-- by their @number attribute -->
                  <%= From chapter In document.<chapters>.<chapter>
                     Order By Convert.ToInt32(chapter.@number)
                     Select
                     <tr>
                        <td style="text-align: right">
                           Chapter <%= chapter.@number %>
                        </td>

                        <td>
                           <%= chapter.Value & " ( " &
                              chapter.@pages & " pages )" %>
                        </td>
                     </tr> %>
                  <%= From appendix In document.<chapters>.<appendix>
                     Order By appendix.@number
                     Select
                     <tr>
                        <td style="text-align: right">
                           Appendix <%= appendix.@number %>
                        </td>

                        <td>
                           <%= appendix.Value & " ( " &
                              appendix.@pages & " pages )" %>
                        </td>
                     </tr> %>
               </table>

               <br/><p style="color: blue">Pages: 
                     <%= totalPages %>
                  <br/>Media Type: <%= document.<media>.@type %></p>
            </body>
         </html>

      xhtmlPage.Save("final.html") ' save the XHTML document

      ' open XHTML page in web browser
      System.Diagnostics.Process.Start("IExplore",
         Application.StartupPath & "\final.html")
   End Sub ' convertButton_Click
End Class ' LinqTransformer

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
