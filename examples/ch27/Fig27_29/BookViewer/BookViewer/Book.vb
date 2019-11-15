' Book.vb
' Class representing a book.
Public Class Book
   Public Property Title As String ' book title
   Public Property ISBN As String ' book ISBN number
   Public Property ThumbImage As String ' thumbnail image source
   Public Property LargeImage As String ' source of book cover's fullsize image

   Public Sub New(title__1 As String, isbn__2 As String, thumb As String, large As String)
      Title = title__1
      ISBN = isbn__2
      ThumbImage = thumb
      LargeImage = large
   End Sub ' end constructor
End Class ' end class Book



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