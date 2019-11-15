' Fig. 11.7: DeferredExecution.vb
' Demonstrating deferred execution and transforming objects.
Public Class DeferredExecution
   Private Sub DeferredExecution_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      ' create an array of Strings
      Dim colors() As String =
         {"aqua", "rust", "yellow", "red", "blue", "orange"}

      ' select Strings starting with "r" and convert them to uppercase
      Dim startsWithR =
        From color In colors
        Where (color.StartsWith("r"))
        Order By color
        Select color.ToUpper()

      ' display query results
      For Each item In startsWithR
         outputTextBox.AppendText(item & "    ")
      Next

      outputTextBox.AppendText(vbCrLf)

      ' modify array elements to help demonstrate deferred execution
      colors(4) = "ruby" ' change "blue" to "ruby"
      colors(5) = "rose" ' change "orange" to "rose"

      ' reexecute the query and display updated query results
      For Each item In startsWithR
         outputTextBox.AppendText(item & "    ")
      Next
   End Sub ' DeferredExecution_Load
End Class ' DeferredExecution


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
