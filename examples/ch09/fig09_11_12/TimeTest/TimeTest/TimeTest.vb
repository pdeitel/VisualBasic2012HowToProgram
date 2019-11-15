' Fig. 9.12: TimeTest.vb
' Accessing data via properties.
Public Class TimeTest
   Dim time As New Time() ' construct Time with zero arguments

   ' invoked when user clicks the Add 1 to Second button
   Private Sub addSecondButton_Click(sender As Object,
      e As EventArgs) Handles incrementSecondButton.Click

      time.Second = (time.Second + 1) Mod 60 ' add 1 to Second

      ' add one minute if 60 seconds have passed
      If time.Second = 0 Then
         time.Minute = (time.Minute + 1) Mod 60 ' add 1 to Minute

         ' add one hour if 60 minutes have passed
         If time.Minute = 0 Then
            time.Hour = (time.Hour + 1) Mod 24 ' add 1 to Hour
         End If
      End If

      UpdateDisplay() ' update the TextBoxes and output Labels
   End Sub ' addSecondButton_Click

   ' set time based on TextBox values
   Private Sub setTimeButton_Click(sender As Object,
      e As EventArgs) Handles setTimeButton.Click

      ' ensure that hour, minute and second are in range
      Try
         If setHourTextBox.Text <> String.Empty Then
            time.Hour = Convert.ToInt32(setHourTextBox.Text)
         End If

         If setMinuteTextBox.Text <> String.Empty Then
            time.Minute = Convert.ToInt32(setMinuteTextBox.Text)
         End If

         If setSecondTextBox.Text <> String.Empty Then
            time.Second = Convert.ToInt32(setSecondTextBox.Text)
         End If
      Catch ex As ArgumentOutOfRangeException
         MessageBox.Show("The hour, minute or second was out of range",
            "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

      UpdateDisplay() ' update the TextBoxes and output Labels
   End Sub ' setTimeButton_Click

   ' update time display
   Private Sub UpdateDisplay()
      setHourTextBox.Text = Convert.ToString(time.Hour)
      setMinuteTextBox.Text = Convert.ToString(time.Minute)
      setSecondTextBox.Text = Convert.ToString(time.Second)
      output1Label.Text = ("Hour: " & time.Hour & "; Minute: " &
      time.Minute & "; Second: " & time.Second)
      output2Label.Text = ("Standard time is: " & time.ToString() &
      "; Universal Time is: " & time.ToUniversalString())
   End Sub ' UpdateDisplay
End Class ' TimeTest


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