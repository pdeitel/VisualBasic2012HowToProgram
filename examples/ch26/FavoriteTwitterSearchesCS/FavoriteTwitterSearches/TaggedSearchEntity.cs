// Fig. 31.7: TaggedSearchEntity.cs
// TableEntity that stores tagged Twitter searches
using Microsoft.WindowsAzure.Storage.Table;

namespace FavoriteTwitterSearches
{
   // class to represent a tagged search
   public class TaggedSearchEntity : TableEntity
   {
      public string Query { get; set; } // Twitter query to perform

      public TaggedSearchEntity()
      {
      } // end constructor

      public TaggedSearchEntity( string groupname, string tag,
         string query )
      {
         Query = query; // query to submit to Twitter

         // set partition key to group name for group of tagged searches
         PartitionKey = groupname;

         // set row key to tag for specific search
         RowKey = tag;
      } // end constructor
   } // end class TaggedSearchEntity
} // end namespace FavoriteTwitterSearches

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/