' Fig. 19.20: XDocumentTestForm.vb
' Reading an XML document and displaying it in a TextBox.
Imports System.Xml.Linq ' import namespace for XDocument and XElement

Public Class XDocumentTest
   ' read XML document and display its content
   Private Sub XDocumentTest_Load(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles MyBase.Load

      ' load the XML file into an XDocument
      Dim xmlFile = XDocument.Load("article.xml")
      Dim indent As Integer = 0 ' no indentation for root element
      PrintElement(xmlFile.Root, indent) ' print elements recursively
   End Sub ' XDocumentTest_Load

   ' print an element (and its children, if any) in the TextBox
   Private Sub PrintElement(ByVal element As XElement,
      ByVal indentLevel As Integer)

      Dim name = element.Name.LocalName ' element name without namespace

      ' display the element's name within its tag
      IndentOutput(indentLevel) ' add correct amount of indentation
      outputTextBox.AppendText("<" & name & ">" & vbCrLf)

      ' check for child elements and print value if none contained
      If element.HasElements Then
         ' print all child elements
         For Each child In element.Elements()
            ' print the contained element at the next indentation level
            PrintElement(child, indentLevel + 1)
         Next
      Else
         ' increase the indentation amount for text elements
         IndentOutput(indentLevel + 1)

         ' display the text inside this element
         outputTextBox.AppendText(element.Value.Trim() & vbCrLf)
      End If

      ' display end tag
      IndentOutput(indentLevel)
      outputTextBox.AppendText("</" & name & ">" & vbCrLf)
   End Sub ' PrintElement

   ' add the specified amount of indentation to the current line
   Private Sub IndentOutput(ByVal number As Integer)
      For i = 1 To number
         outputTextBox.AppendText("   ")
      Next
   End Sub ' IndentOutput
End Class ' XDocumentTest

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
