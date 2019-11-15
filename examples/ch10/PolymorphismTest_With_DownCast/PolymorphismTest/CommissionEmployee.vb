' Fig. 10.x: CommmissionEmployee.vb
' CommissionEmployee class represents a commission employee.
Public Class CommissionEmployee
   Inherits Employee

   Private grossSalesValue As Decimal ' gross weekly sales             
   Private commissionRateValue As Double ' commission percentage       

   ' five-argument constructor
   Public Sub New(first As String, last As String,
      ssn As String, sales As Decimal, rate As Double)

      MyBase.New(first, last, ssn) ' pass to Employee constructor
      GrossSales = sales ' validate and store gross sales
      CommissionRate = rate ' validate and store commission rate
   End Sub ' New

   ' property GrossSales
   Public Property GrossSales() As Decimal
      Get
         Return grossSalesValue
      End Get

      Set(sales As Decimal)
         If sales >= 0D Then ' validate gross sales
            grossSalesValue = sales
         Else
            Throw New ArgumentOutOfRangeException(
               "Gross sales must be greater than or equal to 0")
         End If
      End Set
   End Property ' GrossSales

   ' property CommissionRate
   Public Property CommissionRate() As Double
      Get
         Return commissionRateValue
      End Get

      Set(rate As Double)
         If rate > 0.0 AndAlso rate < 1.0 Then ' validate rate
            commissionRateValue = rate
         Else
            Throw New ArgumentOutOfRangeException(
               "Interest rate must be greater than 0 and less than 1")
         End If
      End Set
   End Property ' CommissionRate

   ' calculate earnings
   Public Overrides Function CalculateEarnings() As Decimal
      Return Convert.ToDecimal(CommissionRate) * GrossSales
   End Function ' CalculateEarnings

   ' return String representation of CommissionEmployee object
   Public Overrides Function ToString() As String
      Return String.Format("commission employee: {0}{1}" &
         "gross sales: {2:C}{1}commission rate: {3:F}",
         MyBase.ToString(), vbCrLf, GrossSales, CommissionRate)
   End Function ' ToString
End Class ' CommissionEmployee

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