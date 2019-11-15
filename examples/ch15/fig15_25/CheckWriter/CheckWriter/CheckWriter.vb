' Fig. 15.24: CheckWriter.vb
' Printing a paycheck.
Imports System.Drawing.Printing

Public Class CheckWriter
   ' PrintPage event raised for each page to be printed
   Private Sub printDocument_PrintPage(sender As Object,
      e As Drawing.Printing.PrintPageEventArgs) _
      Handles printDocument.PrintPage

      Dim fontObject As Font ' variable to store the font

      ' store a control's x- and y-coordinates
      Dim yPosition As Integer
      Dim xPosition As Integer

      ' represent the left margin of the page
      Dim leftMargin As Integer = e.MarginBounds.Left

      ' represent the top margin of the page
      Dim topMargin As Integer = e.MarginBounds.Top

      ' store a control's text
      Dim controlText As String = Nothing

      ' iterate over the controls on the Form,
      ' printing the text displayed in each control
      For Each controlObject In Me.Controls
         ' do not print Buttons
         If Not (TypeOf controlObject Is Button) Then
            controlText = controlObject.Text

            Select Case controlObject.Name
               Case "dateTimePicker" ' underline the date
                  fontObject = New Font("Segoe UI", 9.0F,
                     FontStyle.Underline)
               Case "amountTextBox" ' draw a box around the amount
                  e.Graphics.DrawRectangle(Pens.Black,
                     amountTextBox.Location.X + leftMargin,
                     amountTextBox.Location.Y + topMargin - 2,
                     amountTextBox.Width, amountTextBox.Height)
                  fontObject = controlObject.Font ' default font
               Case Else
                  fontObject = controlObject.Font ' default font
            End Select

            ' set the string positions relative to the page margins
            xPosition = leftMargin + controlObject.Location.X
            yPosition = topMargin + controlObject.Location.Y

            ' draw the text in a graphics object
            e.Graphics.DrawString(controlText, fontObject,
               Brushes.Black, xPosition, yPosition)
         End If
      Next controlObject

      ' draw a line for the payee's name
      e.Graphics.DrawLine(Pens.Black,
         payeeTextBox.Location.X + leftMargin,
         payeeTextBox.Location.Y + topMargin + 15,
         payeeTextBox.Location.X + payeeTextBox.Width + leftMargin,
         payeeTextBox.Location.Y + topMargin + 15)

      ' draw a line for the amount
      e.Graphics.DrawLine(Pens.Black,
         dollarsTextBox.Location.X + leftMargin,
         dollarsTextBox.Location.Y + topMargin + 15,
         dollarsTextBox.Location.X + dollarsTextBox.Width + leftMargin,
         dollarsTextBox.Location.Y + topMargin + 15)

      ' draw the memo line
      e.Graphics.DrawLine(Pens.Black,
         memoTextBox.Location.X + leftMargin,
         memoTextBox.Location.Y + topMargin + 15,
         memoTextBox.Location.X + memoTextBox.Width + leftMargin,
         memoTextBox.Location.Y + topMargin + 15)

      ' draw a box around the check
      e.Graphics.DrawRectangle(Pens.Black, leftMargin,
         topMargin, Me.Width, Me.Height - 60)
   End Sub ' document_PrintPage

   ' print the document
   Private Sub printButton_Click(sender As Object,
      e As EventArgs) Handles printButton.Click

      ' if no printers are installed, display an error message
      If PrinterSettings.InstalledPrinters.Count = 0 Then
         ErrorMessage()
      Else
         printDocument.Print() ' print the document
      End If
   End Sub ' printButton_Click

   ' display the document in a print preview dialog
   Private Sub previewButton_Click(sender As Object,
      e As EventArgs) Handles previewButton.Click

      ' if no printers are installed, display an error message
      If PrinterSettings.InstalledPrinters.Count = 0 Then
         ErrorMessage()
      Else
         printPreviewDialog.Document = printDocument ' specify document
         printPreviewDialog.ShowDialog() ' show print preview dialog
      End If
   End Sub ' previewButton_Click

   ' display an error message to the user
   Sub ErrorMessage()
      MessageBox.Show("No printers installed. You must " &
         "have a printer installed to preview or print the document.",
         "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
   End Sub ' ErrorMessage
End Class ' CheckWriter

' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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