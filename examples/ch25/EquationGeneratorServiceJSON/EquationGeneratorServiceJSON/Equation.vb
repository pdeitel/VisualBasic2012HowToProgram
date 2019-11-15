' Fig. 25.12: Equation.vb
' Class Equation that contains information about an equation.
<DataContract()>
Public Class Equation
   <DataMember()>
   Public Property Left As Integer ' number to the left of the operator

   <DataMember()>
   Public Property Right As Integer ' number to the right of the operator

   <DataMember()>
   Public Property Result As Integer ' result of the operation

   <DataMember()>
   Public Property Operation As String ' type of the operation

   ' required default constructor
   Public Sub New()
      MyClass.New(0, 0, "add")
   End Sub ' parameterless New 

   ' three-argument constructor for class Equation
   Public Sub New(leftValue As Integer, rightValue As Integer,
      type As String)

      Left = leftValue
      Right = rightValue

      Select Case type ' perform appropriate operation
         Case "add" ' addition
            Result = Left + Right
            Operation = "+"
         Case "subtract" ' subtraction
            Result = Left - Right
            Operation = "-"
         Case "multiply" ' multiplication
            Result = Left * Right
            Operation = "*"
      End Select
   End Sub ' three-parameter New 

   ' return string representation of the Equation object
   Public Overrides Function ToString() As String
      Return Left.ToString() & " " & Operation & " " &
         Right.ToString() & " = " & Result.ToString()
   End Function ' ToString

   ' property that returns a string representing left-hand side
   <DataMember()>
   Public Property LeftHandSide As String
      Get
         Return Left.ToString() & " " & Operation & " " &
            Right.ToString()
      End Get

      Set(value As String) ' required set accessor
         ' empty body
      End Set
   End Property ' LeftHandSide

   ' property that returns a string representing right-hand side
   <DataMember()>
   Public Property RightHandSide As String
      Get
         Return Result.ToString()
      End Get

      Set(value As String) ' required set accessor
         ' empty body
      End Set
   End Property ' RightHandSide
End Class ' Equation

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
