' Exercise 11.7 Solution: Invoice.vb
' Invoice class.
Public Class Invoice
   ' declare variables for Invoice object
   Private quantityValue As Integer
   Private priceValue As Decimal

   ' auto-implemented property PartNumber
   Public Property PartNumber As Integer

   ' auto-implemented property PartDescription
   Public Property PartDescription As String

   ' four-argument constructor
   Public Sub New(part As Integer, description As String,
      count As Integer, pricePerItem As Decimal)
      PartNumber = part
      PartDescription = description
      Quantity = count
      Price = pricePerItem
   End Sub ' New

   ' property for quantityValue ensures value is positive
   Public Property Quantity() As Integer
      Get
         Return quantityValue
      End Get
      Set(value As Integer)
         If value > 0 Then ' determine whether quantity is positive
            quantityValue = value ' valid quantity assigned
         End If
      End Set
   End Property ' Quantity

   ' property for pricePerItemValue ensures value is positive
   Public Property Price() As Decimal
      Get
         Return priceValue
      End Get
      Set(value As Decimal)
         If value >= 0 Then ' determine whether price is non-negative
            priceValue = value ' valid price assigned
         End If
      End Set
   End Property ' Price

   ' return string containing the fields in the Invoice in a nice format
   Public Overrides Function ToString() As String
      ' left justify each field, and give large enough spaces so
      ' all the columns line up
      Return String.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
         PartNumber, PartDescription, Quantity, Price)
   End Function ' ToString
End Class ' Invoice

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
'*************************************************************************
