' Fig. 23.4: FlickrViewerForm.vb
' Invoking a web service asynchronously with class WebClient
Imports System.IO
Imports System.Net

Public Class FlickrViewerForm
   ' Use your Flickr API key here--you can get one at:
   ' http://www.flickr.com/services/apps/create/apply
   Private Const KEY As String = "df21b3fe175370cffd5f256e032fb1bb"

   ' object used to invoke Flickr web service
   Private flickrClient As New WebClient()

   ' Task(Of String) that queries Flickr
   Private flickrTask As Task(Of String) = Nothing

   ' initiate asynchronous Flickr search query; 
   ' display results when query completes
   Private Async Sub searchButton_Click(sender As Object,
      e As EventArgs) Handles searchButton.Click

      ' if flickrTask already running, prompt user 
      If flickrTask IsNot Nothing AndAlso
         flickrTask.Status <> TaskStatus.RanToCompletion Then

         ' ask whether to cancel current search
         Dim result = MessageBox.Show("Cancel the current Flickr search?",
            "Are you sure?", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

         ' determine whether user wants to cancel prior search
         If result = DialogResult.No Then
            Return
         Else
            flickrClient.CancelAsync() ' cancel current search
         End If
      End If

      ' Flickr's web service URL for searches
      Dim flickrURL = String.Format("http://api.flickr.com/services" &
         "/rest/?method=flickr.photos.search&api_key={0}&tags={1}" &
         "&tag_mode=all&per_page=500&privacy_filter=1",
         KEY, inputTextBox.Text.Replace(" ", ","))

      imagesListBox.DataSource = Nothing ' remove prior data source
      imagesListBox.Items.Clear() ' clear imagesListBox
      pictureBox.Image = Nothing ' clear pictureBox
      imagesListBox.Items.Add("Loading...") ' display Loading...

      ' try to get Flickr search results
      Try
         ' invoke Flickr web service to search Flick with user's tags
         flickrTask = flickrClient.DownloadStringTaskAsync(flickrURL)

         ' await flickrTask then parse results with XDocument and LINQ
         Dim flickrXML As XDocument = XDocument.Parse(Await flickrTask)

         ' gather information on all photos
         Dim flickrPhotos =
            From photo In flickrXML.Descendants("photo")
            Let id = photo.Attribute("id").Value
            Let title = photo.Attribute("title").Value
            Let secret = photo.Attribute("secret").Value
            Let server = photo.Attribute("server").Value
            Let farm = photo.Attribute("farm").Value
            Select New FlickrResult() With
            {
               .Title = title,
               .URL = String.Format(
                  "http://farm{0}.staticflickr.com/{1}/{2}_{3}.jpg",
                  farm, server, id, secret)
            }

         imagesListBox.Items.Clear() ' clear imagesListBox

         ' set ListBox properties only if results were found
         If flickrPhotos.Any() Then
            imagesListBox.DataSource = flickrPhotos.ToList()
            imagesListBox.DisplayMember = "Title"
         Else
            ' no matches were found
            imagesListBox.Items.Add("No matches")
         End If
      Catch ex As WebException
         ' check whether Task failed
         If flickrTask.Status = TaskStatus.Faulted Then
            MessageBox.Show("Unable to get results from Flickr",
               "Flickr Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error)
         End If

         imagesListBox.Items.Clear() ' clear imagesListBox
         imagesListBox.Items.Add("Error occurred")
      End Try
   End Sub ' searchButton_Click

   ' display selected image
   Private Async Sub imagesListBox_SelectedIndexChanged(sender As Object,
      e As EventArgs) Handles imagesListBox.SelectedIndexChanged

      ' if an item is selected
      If imagesListBox.SelectedItem IsNot Nothing Then
         Dim selectedURL As String =
            CType(imagesListBox.SelectedItem, FlickrResult).URL

         ' use WebClient to get selected image's bytes asynchronously
         Dim imageClient As New WebClient()
         Dim imageBytes As Byte() =
            Await imageClient.DownloadDataTaskAsync(selectedURL)

         ' process byte array as a stream, convert to  
         ' Image and display  in pictureBox
         Dim memoryStream As New MemoryStream(imageBytes)
         pictureBox.Image = Image.FromStream(memoryStream)
      End If
   End Sub ' imagesListBox_SelectedIndexChanged
End Class


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