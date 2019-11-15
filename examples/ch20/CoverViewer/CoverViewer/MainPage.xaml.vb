' Fig. 20.18: MainPage.xaml.vb
' Using data binding
Imports System.Collections.Generic
Imports Windows.UI.Xaml.Controls

Partial Public NotInheritable Class MainPage
   Inherits Page
   Private books As New List(Of Book)() ' list of Book objects

   Public Sub New()
      Me.InitializeComponent()

      ' add Book objects to the List
      books.Add(New Book("C How to Program", "013299044X",
         "assets/images/small/chtp.jpg", "assets/images/large/chtp.jpg"))
      books.Add(New Book("C++ How to Program", "0133378713",
         "assets/images/small/cpphtp.jpg",
         "assets/images/large/cpphtp.jpg"))
      books.Add(New Book("Internet and World Wide Web How to Program",
         "0132151006", "assets/images/small/iw3htp.jpg",
         "assets/images/large/iw3htp.jpg"))
      books.Add(New Book("Java How to Program", "0132940949",
         "assets/images/small/jhtp.jpg", "assets/images/large/jhtp.jpg"))
      books.Add(New Book("Visual Basic How to Program", "0133406954",
         "assets/images/small/vbhtp.jpg", "assets/images/large/vbhtp.jpg"))
      books.Add(New Book("Visual C# How to Program", "0133379337",
         "assets/images/small/vcshtp.jpg",
         "assets/images/large/vcshtp.jpg"))

      booksListView.ItemsSource = books ' bind data to the list
      booksListView.SelectedIndex = 0 ' select first item in ListView
   End Sub ' end constructor
End Class ' end class MainPage

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