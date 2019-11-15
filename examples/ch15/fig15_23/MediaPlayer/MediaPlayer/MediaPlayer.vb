' Fig. 15.23: MediaPlayer.vb
' Windows Media Player control used to play media files.
Public Class MediaPlayer
   ' open new media file in Windows Media Player
   Private Sub OpenToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles OpenToolStripMenuItem.Click

      openMediaFileDialog.ShowDialog() ' allow user to select file

      ' load and play the media clip
      AxWindowsMediaPlayer1.URL = openMediaFileDialog.FileName
   End Sub ' OpenToolStripMenuItem_Click

   ' exit the program when the exit menu item is clicked
   Private Sub ExitToolStripMenuItem_Click(sender As Object,
      e As EventArgs) Handles ExitToolStripMenuItem.Click
      Application.Exit()
   End Sub ' ExitToolStripMenuItem_Click
End Class ' MediaPlayer

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
