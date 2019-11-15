' Fig. 19.21: PathNavigator.vb
' Document navigation using XNode and axis properties.
Imports System.Xml ' for XmlNodeType Enumeration
Imports System.Xml.XPath ' for XPathSelectElement extension method

Public Class PathNavigator
   Private current As XNode ' currently selected element
   Private document As XDocument ' the document to navigate
   Private tree As TreeNode ' TreeNode used by TreeView control

   ' initialize variables and TreeView control
   Private Sub PathNavigator_Load(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles MyBase.Load

      document = XDocument.Load("sports.xml") ' load sports.xml

      ' create first element representation using an XPath Expression
      current = document.XPathSelectElement("/sports")
      tree = New TreeNode(NodeText(current)) ' create root TreeNode
      treePath.Nodes.Add(tree) ' add TreeNode to TreeView
      TreeRefresh() ' reset the tree display
   End Sub ' PathNavigator_Load

   ' print the elements of the selected path
   Private Sub locateComboBox_SelectedIndexChanged(
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles locateComboBox.SelectedIndexChanged

      ' retrieve the set of elements to output
      Select Case locateComboBox.SelectedIndex
         Case 0 ' print all sports elements
            PrintElements(document.<sports>)
         Case 1 ' print all game elements
            ' could also be document.<sports>.<game>
            PrintElements(document...<game>)
         Case 2 ' print all name elements
            ' could also be document.<sports>.<game>.<name>
            PrintElements(document...<name>)
         Case 3 ' print all paragraph elements
            ' could also be document.<sports>.<game>.<paragraph>
            PrintElements(document...<paragraph>)
         Case 4 ' print game elements with a name element of "Cricket"
            ' use LINQ to XML to retrieve the correct node
            Dim cricket =
                From game In document...<game>
                Where (game.<name>.Value = "Cricket")
                Select game
            PrintElements(cricket)
         Case 5 ' print all id attributes of game
            ' could also be document.<sports>.<game>
            PrintIDs(document...<game>)
      End Select
   End Sub ' locateComboBox_SelectedIndexChanged

   ' traverse to first child
   Private Sub firstChildButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles firstChildButton.Click

      ' if current is an element and has children, move to first child
      If current.NodeType = XmlNodeType.Element AndAlso
         CType(current, XElement).Nodes().Any() Then

         current = CType(current, XElement).Nodes().First() ' first child

         ' create new TreeNode for this node with correct label
         Dim newNode As New TreeNode(NodeText(current))
         tree.Nodes.Add(newNode) ' add node to TreeNode Nodes list
         tree = newNode ' move current selection to newNode
         TreeRefresh() ' reset the tree display
      Else ' current is not an element or is an element with no children
         MessageBox.Show("Current node has no children.", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
   End Sub ' firstChildButton_Click

   ' traverse to node's parent
   Private Sub parentButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles parentButton.Click

      ' if current node is not the root, move to parent
      If current.Parent IsNot Nothing Then
         current = current.Parent ' get parent node
         tree = tree.Parent ' get parent in tree structure
         tree.Nodes.Clear() ' remove all children
         TreeRefresh() ' reset the tree display
      Else ' element has no parent (root element)
         MessageBox.Show("Current node has no parent.", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
   End Sub ' parentButton_Click

   ' traverse to previous node
   Private Sub previousButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles previousButton.Click

      ' if current node is not first, move to previous node
      If current.PreviousNode IsNot Nothing AndAlso
         current.Parent IsNot Nothing Then

         current = current.PreviousNode ' move to previous node
         Dim treeParent = tree.Parent ' get parent node
         treeParent.Nodes.Remove(tree) ' delete current node
         tree = treeParent.LastNode ' set current position for display
         TreeRefresh() ' reset the tree display
      Else ' current element is last among its siblings
         MessageBox.Show("Current node is first sibling.", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
   End Sub ' previousButton_Click

   ' traverse to next node
   Private Sub nextButton_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles nextButton.Click

      ' if current node is not last, move to next node
      If current.NextNode IsNot Nothing AndAlso
         current.Parent IsNot Nothing Then

         current = current.NextNode ' move to next node
         Dim treeParent = tree.Parent ' get parent node
         Dim newNode As New TreeNode(NodeText(current)) ' create new node
         treeParent.Nodes.Add(newNode) ' add to parent node
         tree = newNode ' set current position for display
         TreeRefresh() ' reset the tree display
      Else ' current node is last among its siblings
         MessageBox.Show("Current node is last sibling.", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
   End Sub ' nextButton_Click

   ' update TreeView control
   Private Sub TreeRefresh()
      treePath.ExpandAll() ' expand tree node in TreeView
      treePath.Refresh() ' force TreeView update
      treePath.SelectedNode = tree ' highlight current node
   End Sub ' TreeRefresh

   ' print values in the given collection
   Private Sub PrintElements(ByVal elements As IEnumerable(Of XElement))
      locateTextBox.Clear() ' clear the text area

      ' display text inside all elements
      For Each element In elements
         locateTextBox.AppendText(element.Value.Trim() & vbNewLine)
      Next
   End Sub ' PrintElements

   ' print the ID numbers of all games in elements
   Private Sub PrintIDs(ByVal elements As IEnumerable(Of XElement))
      locateTextBox.Clear() ' clear the text area

      ' display "id" attribute of all elements
      For Each element In elements
         locateTextBox.AppendText(element.@id.Trim() & vbNewLine)
      Next
   End Sub ' PrintIDs

   ' returns text used to represent an element in the tree
   Private Function NodeText(ByVal element As XNode) As String
      ' if node is an element then use its name
      If element.NodeType = XmlNodeType.Element Then
         ' represent node by tag name
         Return CType(element, XElement).Name.LocalName
      ElseIf element.NodeType = XmlNodeType.Text Then ' if node is XText
         ' represent node by text stored in Value property
         Return CType(element, XText).Value.Trim()
      Else
         ' all nodes in this example are elements or text;
         ' return a reasonable default value for other nodes
         Return element.NodeType.ToString()
      End If
   End Function ' NodeText
End Class ' PathNavigator

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
