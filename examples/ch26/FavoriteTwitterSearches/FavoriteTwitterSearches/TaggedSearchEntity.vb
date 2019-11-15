' Fig. 26.7: TaggedSearchEntity.vb
' TableEntity that stores tagged Twitter searches
Imports Microsoft.WindowsAzure.Storage.Table

Public Class TaggedSearchEntity
   Inherits TableEntity

   Public Property Query As String

   Public Sub New()

   End Sub

   Public Sub New(groupname As String, tag As String,
      queryParam As String)

      Query = queryParam ' query to submit to Twitter

      ' set partition key to group name for group of tagged searches
      PartitionKey = groupname

      ' set row key to tag for specific search
      RowKey = tag
   End Sub
End Class

'/**************************************************************************
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
' **************************************************************************/