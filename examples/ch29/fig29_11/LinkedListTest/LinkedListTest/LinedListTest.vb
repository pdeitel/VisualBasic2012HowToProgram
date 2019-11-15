' Fig. 29.11: LinkedListTest.vb
' Using LinkedLists.
Module LinkedListTest
   Private colors As String() =
      {"black", "yellow", "green", "blue", "violet", "silver"}
   Private colors2 As String() =
      {"gold", "white", "brown", "blue", "gray"}

   ' set up and manipulate LinkedList objects
   Sub Main()
      Dim list1 As New LinkedList(Of String)()

      ' add elements to first LinkedList  
      For Each color In colors
         list1.AddLast(color)
      Next

      ' add elements to second LinkedList via constructor
      Dim list2 As New LinkedList(Of String)(colors2)

      Concatenate(list1, list2) ' concatenate list2 onto list1
      PrintList(list1) ' print list1 elements

      Console.WriteLine(vbNewLine &
         "Converting strings in list1 to uppercase" & vbNewLine)
      ToUppercaseStrings(list1) ' convert to uppercase string
      PrintList(list1) ' print list1 elements

      Console.WriteLine(vbNewLine &
         "Deleting strings between BLACK and BROWN" & vbNewLine)
      RemoveItemsBetween(list1, "BLACK", "BROWN")

      PrintList(list1) ' print list1 elements
      Console.WriteLine()
      PrintReversedList(list1) ' print list in reverse order
   End Sub ' Main

   ' output list contents
   Private Sub PrintList(Of T)(list As LinkedList(Of T))
      Console.WriteLine("Linked list: ")

      For Each value In list
         Console.Write("{0} ", value)
      Next

      Console.WriteLine()
   End Sub ' PrintList

   ' concatenate the second list on the end of the first list
   Private Sub Concatenate(Of T)(list1 As LinkedList(Of T),
      list2 As LinkedList(Of T))
      ' concatenate lists by copying element values
      ' in order from the second list to the first list
      For Each value In list2
         list1.AddLast(value) ' add new node
      Next
   End Sub ' Concatenate

   ' locate string objects and convert to uppercase
   Private Sub ToUppercaseStrings(list As LinkedList(Of String))
      ' iterate over the list by using the nodes
      Dim currentNode As LinkedListNode(Of String) = list.First

      While currentNode IsNot Nothing
         currentNode.Value =
            currentNode.Value.ToUpper() ' convert to uppercase
         currentNode = currentNode.Next ' get next node
      End While
   End Sub ' ToUppercaseStrings

   ' delete list items between two given items
   Private Sub RemoveItemsBetween(Of T)(list As LinkedList(Of T),
      startItem As T, endItem As T)
      ' get the nodes corresponding to the start and end item
      Dim currentNode As LinkedListNode(Of T) = list.Find(startItem)
      Dim endNode As LinkedListNode(Of T) = list.Find(endItem)

      ' remove items after the start item
      ' until we find the last item or the end of the LinkedList
      While currentNode.Next IsNot Nothing AndAlso
         Not currentNode.Next.Equals(endNode)
         ' remove next node
         list.Remove(currentNode.Next)
      End While
   End Sub ' RemoveItemsBetween

   ' print reversed list
   Private Sub PrintReversedList(Of T)(list As LinkedList(Of T))
      Console.WriteLine("Reversed List:")

      ' iterate over the list by using the nodes
      Dim currentNode As LinkedListNode(Of T) = list.Last

      While currentNode IsNot Nothing
         Console.Write("{0} ", currentNode.Value)
         currentNode = currentNode.Previous ' get previous node
      End While

      Console.WriteLine()
   End Sub ' PrintReversedList
End Module ' LinkedListTest


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