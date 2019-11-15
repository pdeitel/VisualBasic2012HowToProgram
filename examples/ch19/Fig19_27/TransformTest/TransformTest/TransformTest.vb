' Fig. 19.27: TransformTest.vb
' Applying an XSLT style sheet to an XML Document.
Imports System.Xml.Xsl ' contains class XslCompiledTransform

Public Class TransformTest
   ' applies the transformation
   Private transformer As New XslCompiledTransform()

   ' initialize variables
   Private Sub TransformTest_Load(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles MyBase.Load

      transformer.Load("sports.xsl") ' load and compile the style sheet
   End Sub ' TransformTest_Load

   ' transform XML data on Transform XML Button Click event
   Private Sub transformButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles transformButton.Click

      ' perform the transformation and store the result in new file
      transformer.Transform("sports.xml", "sports.html")

      ' read and display the XHTML document's text in a TextBox
      consoleTextBox.Text = System.IO.File.ReadAllText("sports.html")
   End Sub ' transformButton_Click
End Class ' TransformTest

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
