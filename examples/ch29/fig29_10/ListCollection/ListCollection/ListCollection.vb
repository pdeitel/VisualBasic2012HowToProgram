' Fig. 29.10: ListCollection.vb
' Generic List collection demonstration.
Module ListCollection
   Sub Main()
      Dim items As New List(Of String) ' create a new List of Strings

      items.Add("red") ' append an item to the List
      items.Insert(0, "yellow") ' insert the value at index 0

      Console.Write(
         "Display list contents with counter-controlled loop:") ' header

      ' display the colors in the list
      For i = 0 To items.Count - 1
         Console.Write(" {0}", items(i))
      Next

      ' display colors using For Each...Next in the Display method
      Display(items, vbCrLf &
         "Display list contents with For Each...Next statement:")

      items.Add("green") ' add "green" to the end of the List
      items.Add("yellow") ' add "yellow" to the end of the List
      Display(items, "List with two new elements:") ' display the List

      items.Remove("yellow") ' remove the first "yellow"
      Display(items, "Remove first instance of yellow:") ' display List

      items.RemoveAt(1) ' remove item at index 1
      Display(items, "Remove second list element (green):") ' display List

      ' check if a value is in the List
      Console.WriteLine("""red"" is {0}in the list",
         If(items.Contains("red"), String.Empty, "not "))

      ' display number of elements in the List
      Console.WriteLine("Count: {0}", items.Count)

      ' display the capacity of the List
      Console.WriteLine("Capacity: {0}", items.Capacity)
   End Sub ' Main

   ' display the List's elements on the console
   Sub Display(items As List(Of String), header As String)
      Console.Write(header) ' print header

      ' display each element in items
      For Each item In items
         Console.Write(" {0}", item)
      Next

      Console.WriteLine() ' print end of line
   End Sub ' Display
End Module ' ListCollection

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
