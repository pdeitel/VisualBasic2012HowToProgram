' MainPage.xaml.vb
' Calculates bills using 15% and custom percentage tips
Imports System.Windows ' for event handler argument classes
Imports System.Windows.Controls ' for event handler argument classes
Imports Microsoft.Phone.Controls ' for base class PhoneApplicationPage

Partial Public Class MainPage
   Inherits PhoneApplicationPage

   Private billAmount As Decimal = 0D ' amount entered by the user
   Private customTipPercent As Decimal = 0.18D ' custom tip percentage

   ' Constructor
   Public Sub New()
      InitializeComponent()
   End Sub

   ' executes when app has loaded
   Private Sub PhoneApplicationPage_Loaded(sender As Object,
      e As RoutedEventArgs)
      ' update GUI based on billAmount and customTipPercent 
      update15PercentTip() ' update the 15% tip TextBlocks
      updateCustomTip() ' update the custom tip TextBlocks
      customTipPercentSlider.Value = 0.18 ' initial value
      customTipPercentSlider.Maximum = 0.3 ' maximum value
      amountTextBox.Focus() ' give amountTextBox the focus
   End Sub ' PhoneApplicationPage_Loaded

   ' updates 15% tip TextBlocks
   Private Sub update15PercentTip()
      ' calculate 15% tip and total
      Dim fifteenPercentTip As Decimal = billAmount * 0.15D
      Dim fifteenPercentTotal As Decimal = billAmount + fifteenPercentTip

      ' display 15% tip and total formatted as currency
      tip15TextBlock.Text = String.Format("{0:C}", fifteenPercentTip)
      total15TextBlock.Text = String.Format("{0:C}", fifteenPercentTotal)
   End Sub ' update15PercentTip

   ' updates the custom tip and total TextBlocks
   Private Sub updateCustomTip()
      ' show customTipPercent in percentCustomTextBlock formatted as %
      percentCustomTextBlock.Text =
         String.Format("{0:P0}", customTipPercent)

      ' calculate the custom tip and total
      Dim customTip As Decimal = billAmount * customTipPercent
      Dim customTotal As Decimal = billAmount + customTip

      ' display custom tip and total formatted as currency
      tipCustomTextBlock.Text = String.Format("{0:C}", customTip)
      totalCustomTextBlock.Text = String.Format("{0:C}", customTotal)
   End Sub ' updateCustomTip

   ' updates 15% tip and total when user enters text in amountTextBox
   Private Sub amountTextBox_TextChanged(sender As Object,
      e As TextChangedEventArgs)

      ' convert amountTextBox's text to a Decimal
      Try
         billAmount = Convert.ToDecimal(amountTextBox.Text)
      Catch exception As FormatException
         billAmount = 0D ' default if an exception occurs
      End Try

      ' display currency formatted bill amount
      update15PercentTip() ' update the 15% tip TextBlocks
      updateCustomTip() ' update the custom tip TextBlocks
   End Sub ' amountTextBox_TextChanged

   ' updates custom tip and total when used changes slider value
   Private Sub customTipPercentSlider_ValueChanged(sender As Object,
      e As RoutedPropertyChangedEventArgs(Of Double))

      ' sets customTipPercent to position of the Slider's thumb
      customTipPercent =
         Math.Round(Convert.ToDecimal(customTipPercentSlider.Value), 2)
      updateCustomTip() ' update the custom tip TextBlocks
   End Sub ' customTipPercentSlider_ValueChanged

   ' force amountTextBox to keep the focus so keypad remains on screen
   Private Sub amountTextBox_LostFocus(sender As Object,
      e As RoutedEventArgs)

      amountTextBox.Focus()
   End Sub ' amountTextBox_LostFocus
End Class ' MainPage

'************************************************************************
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
'************************************************************************