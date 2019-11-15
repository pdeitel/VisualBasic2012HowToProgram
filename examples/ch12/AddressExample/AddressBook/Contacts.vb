' Fig. 12.33: Contacts.vb
' Manipulating an address book.
Imports System.Data.Entity
Imports System.Data.Entity.Validation
Imports System.Linq

Public Class Contacts
   ' LINQ to SQL data context
   Private dbcontext As AddressExample.AddressBookEntities = Nothing

   ' fill the AddressBindingSource with all rows, ordered by name
   Private Sub RefreshContacts()
      ' Displose old DbContext, if any
      If (dbcontext IsNot Nothing) Then
         dbcontext.Dispose()
      End If

      ' create new DbContext so we can reorder records based on edits
      dbcontext = New AddressExample.AddressBookEntities()

      ' use LINQ to order the Addresses table contents 
      ' by last name, then first name
      dbcontext.Addresses _
         .OrderBy(Function(entry) entry.LastName) _
         .ThenBy(Function(entry) entry.FirstName) _
         .Load()

      ' specify DataSource for AddressBindingSource
      AddressBindingSource.DataSource = dbcontext.Addresses.Local
      AddressBindingSource.MoveFirst() ' go to first result
      findTextBox.Clear() ' clear the Find TextBox
   End Sub ' RefreshContacts

   ' when the form loads, fill it with data from the database
   Private Sub Contacts_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load

      RefreshContacts() ' fill binding with data from database
   End Sub ' Contacts_Load

   ' save the changes made to the data
   Private Sub AddressBindingNavigatorSaveItem_Click(
      sender As Object, e As EventArgs) _
      Handles AddressBindingNavigatorSaveItem.Click

      Validate() ' validate input fields
      AddressBindingSource.EndEdit() ' complete current edit, if any

      ' try to save changes
      Try
         dbcontext.SaveChanges() ' write changes to database file
      Catch ex As DbEntityValidationException
         MessageBox.Show("Columns cannot be empty",
            "Entity Validation Exception")
      End Try

      RefreshContacts() ' change back to initial unfiltered data on save
   End Sub ' AddressBindingNavigatorSaveItem_Click

   ' load data for the rows with the specified
   ' last name into the AddressBindingSource
   Private Sub findButton_Click(sender As Object,
      e As EventArgs) Handles findButton.Click

      ' use LINQ to filter contacts with last names that
      ' start with findTextBox contents
      Dim lastNameQuery =
         From address In dbcontext.Addresses
         Where address.LastName.StartsWith(findTextBox.Text)
         Order By address.LastName, address.FirstName
         Select address

      ' display matching contacts
      AddressBindingSource.DataSource = lastNameQuery.ToList()
      AddressBindingSource.MoveFirst() ' go to first result

      ' don't allow add/delete when contacts are filtered
      BindingNavigatorAddNewItem.Enabled = False
      BindingNavigatorDeleteItem.Enabled = False
   End Sub ' findButton_Click

   ' reload AddressBindingSource with all rows
   Private Sub browseAllButton_Click(sender As Object,
      e As EventArgs) Handles browseAllButton.Click

      ' allow add/delete when contacts are not filtered
      BindingNavigatorAddNewItem.Enabled = True
      BindingNavigatorDeleteItem.Enabled = True
      RefreshContacts() ' change back to initial unfiltered data
   End Sub ' browseAllButton_Click
End Class ' Contacts

' **************************************************************************
' * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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
