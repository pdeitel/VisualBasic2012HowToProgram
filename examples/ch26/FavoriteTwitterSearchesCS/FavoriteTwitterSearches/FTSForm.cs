// Fig. 31.8: FTSForm.cs
// Storing tagged Twitter searches in Azure Table Storage 
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace FavoriteTwitterSearches
{
   public partial class FTSForm : Form
   {
      private string groupTag; // used to manage group of searches

      CloudStorageAccount storageAccount; // used to access Azure account
      CloudTableClient tableClient; // gives access to Azure tables
      CloudTable ftsTable; // used to interact with specific Azure table

      public FTSForm()
      {
         InitializeComponent();

         // gives access to the Azure storage emulator 
         storageAccount = CloudStorageAccount.DevelopmentStorageAccount;

         // create Azure table storage client
         tableClient = storageAccount.CreateCloudTableClient();

         // get reference to Contacts table
         ftsTable = tableClient.GetTableReference( "FTS" );

         // create the Contacts table if it does not already exist
         ftsTable.CreateIfNotExists();
      } // end constructor

      // get group tag, enable capabilities for adding searches
      // and load existing searches into the app
      private void manageSearchesButton_Click( 
         object sender, EventArgs e )
      {
         // check whether groupTagTextBox is empty
         if ( string.IsNullOrEmpty( groupTagTextBox.Text ) )
         {
            MessageBox.Show( "Enter group tag " );
         } // end if
         else
         {
            addSearchGroupBox.Enabled = true;
            taggedSearchesGroupBox.Enabled = true;

            // if new groupTag does not equal previous groupTag
            if ( !groupTagTextBox.Text.Equals( groupTag ) )
            {
               tagsListBox.DataSource = null; // remove data source
               tagsListBox.Items.Clear(); // clear tasListBox
               webBrowser.Navigate( string.Empty ); // clear webBrowser

               // get groupTag for use as Azure PartitionKey 
               groupTag = groupTagTextBox.Text;

               LoadSearches(); // Load group of searches 
            } // end if
         } // end else
      } // end method manageSearchesButton_Click

      // access Azure table storage to load group of search
      private void LoadSearches()
      {
         try
         {
            // create TableQuery to get group of searches
            TableQuery<TaggedSearchEntity> query =
               new TableQuery<TaggedSearchEntity>().
                  Where( TableQuery.GenerateFilterCondition(
                     "PartitionKey", QueryComparisons.Equal, 
                     groupTag ) );

            // execute query to get group of searches
            var searches = 
               ftsTable.ExecuteQuery<TaggedSearchEntity>( query );

            // Sort tags (RowKeys) alphabetically
            var sortedSearches = 
               searches.OrderBy( search => search.RowKey.ToLower() );

            tagsListBox.DisplayMember = "RowKey";
            tagsListBox.DataSource = sortedSearches.ToList();
         } // end try
         catch ( Exception exception )
         {
            MessageBox.Show(
               String.Format( "Load Failed: {0}", exception ) );
         } // end catch      
      } // end method LoadSearches
      
      // save a search into the Azure table for this app
      private void saveSearchButton_Click( object sender, EventArgs e )
      {
         // try to save a search
         try
         {
            // create a new TaggedSearchEntity to insert 
            TaggedSearchEntity search = new TaggedSearchEntity(
               groupTag, tagTextBox.Text, queryTextBox.Text );

            // create TableOperation to insert TaggedSearchEntity
            TableOperation insertSearch = TableOperation.Insert( search );

            // execute the TableOperation to insert the new search
            ftsTable.Execute( insertSearch );

            LoadSearches(); // Reload searches and select new one

            queryTextBox.Text = string.Empty; // clear queryTextBox
            tagTextBox.Text = string.Empty; // clear tagTextBox
         } // end try
         catch ( Exception exception )
         {
            MessageBox.Show( 
               String.Format( "Insert Failed: {0}", exception ) );
         } // end catch
      } // end method saveSearchButton_Click

      // display search results in the webBrowser control
      private void tagsListBox_SelectedIndexChanged( 
         object sender, EventArgs e )
      {
         // get selected item from tagsListBox
         TaggedSearchEntity selectedSearch =
            ( TaggedSearchEntity ) tagsListBox.SelectedItem;

         if ( selectedSearch != null )
         {
            // create URL representing search
            String urlString = String.Format(
               "https://twitter.com/search?q={0}",
               HttpUtility.UrlEncode( selectedSearch.Query ) );

            webBrowser.Navigate( urlString ); // show results
         } // end if
      } // end method tagsListBox_SelectedIndexChanged
   } // end class FTSForm
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