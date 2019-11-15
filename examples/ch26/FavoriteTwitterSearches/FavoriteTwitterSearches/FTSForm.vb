' Fig. 26.8: FTSForm.vb
' Storing tagged Twitter searches in Azure Table Storage 
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Table
Imports System.Web

Public Class FTSForm
   Private groupTag As String ' used to manage group of searches

   Private storageAccount As CloudStorageAccount ' to access Azure account
   Private tableClient As CloudTableClient ' gives access to Azure tables
   Private ftsTable As CloudTable ' to interact with specific Azure table

   Public Sub New()
      InitializeComponent()

      ' gives access to the Azure storage emulator 
      storageAccount = CloudStorageAccount.DevelopmentStorageAccount

      ' create Azure table storage client
      tableClient = storageAccount.CreateCloudTableClient()

      ' get reference to Contacts table
      ftsTable = tableClient.GetTableReference("FTS")

      ' create the Contacts table if it does not already exist
      ftsTable.CreateIfNotExists()
   End Sub

   ' get group tag, enable capabilities for adding searches
   ' and load existing searches into the app
   Private Sub manageSearchesButton_Click(sender As Object,
      e As EventArgs) Handles manageSearchesButton.Click

      ' check whether groupTagTextBox is empty
      If (String.IsNullOrEmpty(groupTagTextBox.Text)) Then
         MessageBox.Show("Enter group tag ")
      Else
         addSearchGroupBox.Enabled = True
         taggedSearchesGroupBox.Enabled = True

         ' if new groupTag does not equal previous groupTag
         If (Not groupTagTextBox.Text.Equals(groupTag)) Then
            tagsListBox.DataSource = Nothing ' remove data source
            tagsListBox.Items.Clear() ' clear tasListBox
            webBrowser.Navigate(String.Empty) ' clear webBrowser

            ' get groupTag for use as Azure PartitionKey 
            groupTag = groupTagTextBox.Text

            LoadSearches() ' Load group of searches 
         End If
      End If
   End Sub

   ' access Azure table storage to load group of search
   Private Sub LoadSearches()
      Try
         ' create TableQuery to get group of searches
         Dim query As TableQuery(Of TaggedSearchEntity) =
            New TableQuery(Of TaggedSearchEntity)().
               Where(TableQuery.GenerateFilterCondition(
                  "PartitionKey", QueryComparisons.Equal, groupTag))

         ' execute query to get group of searches
         Dim searches =
            ftsTable.ExecuteQuery(Of TaggedSearchEntity)(query)

         ' Sort tags (RowKeys) alphabetically
         Dim sortedSearches =
            searches.OrderBy(Function(search) search.RowKey.ToLower())

         tagsListBox.DisplayMember = "RowKey"
         tagsListBox.DataSource = sortedSearches.ToList()
      Catch ex As Exception
         MessageBox.Show(String.Format("Load Failed: {0}", ex))
      End Try
   End Sub

   ' save a search into the Azure table for this app
   Private Sub saveSearchButton_Click(sender As Object,
      e As EventArgs) Handles saveSearchButton.Click

      ' try to save a search
      Try
         ' create a new TaggedSearchEntity to insert 
         Dim search As New TaggedSearchEntity(
            groupTag, tagTextBox.Text, queryTextBox.Text)

         ' create TableOperation to insert TaggedSearchEntity
         Dim insertSearch = TableOperation.Insert(search)

         ' execute the TableOperation to insert the new search
         ftsTable.Execute(insertSearch)

         LoadSearches() ' Reload searches and select new one

         queryTextBox.Text = String.Empty ' clear queryTextBox
         tagTextBox.Text = String.Empty ' clear tagTextBox
      Catch ex As Exception
         MessageBox.Show(String.Format("Insert Failed: {0}", ex))
      End Try
   End Sub

   ' display search results in the webBrowser control
   Private Sub tagsListBox_SelectedIndexChanged(sender As Object,
      e As EventArgs) Handles tagsListBox.SelectedIndexChanged

      ' get selected item from tagsListBox
      Dim selectedSearch As TaggedSearchEntity =
         CType(tagsListBox.SelectedItem, TaggedSearchEntity)

      If selectedSearch IsNot Nothing Then
         ' create URL representing search
         Dim urlString =
            String.Format("https://twitter.com/search?q={0}",
               HttpUtility.UrlEncode(selectedSearch.Query))

         webBrowser.Navigate(urlString) ' show results
      End If
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