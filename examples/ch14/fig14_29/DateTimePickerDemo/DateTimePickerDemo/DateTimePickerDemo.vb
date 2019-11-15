' Fig. 14.29: DateTimePickerDemo.vb
' Using a DateTimePicker to select a drop off date.
Public Class DateTimePickerDemo
   ' set DateTimePicker's MinDate and MaxDate properties
   Private Sub DateTimePickerDemo_Load(sender As Object,
      e As EventArgs) Handles MyBase.Load
      ' user cannot select days before today
      dropOffDateTimePicker.MinDate = DateTime.Today

      ' user can select days up to one year from now
      dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1)
   End Sub ' DateTimePickerDemo_Load

   ' display delivery date
   Private Sub dropOffDateTimePicker_ValueChanged(
      sender As Object, e As EventArgs) _
      Handles dropOffDateTimePicker.ValueChanged

      Dim dropOffDate As DateTime = dropOffDateTimePicker.Value

      ' add an extra day when items are dropped off Friday-Sunday
      If dropOffDate.DayOfWeek = DayOfWeek.Friday Or
         dropOffDate.DayOfWeek = DayOfWeek.Saturday Or
         dropOffDate.DayOfWeek = DayOfWeek.Sunday Then
         ' estimate three days for delivery
         outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString()
      Else ' otherwise estimate only two days for delivery
         outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString()
      End If
   End Sub ' dropOffDateTimePicker_ValueChanged
End Class ' DateTimePickerDemo


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
