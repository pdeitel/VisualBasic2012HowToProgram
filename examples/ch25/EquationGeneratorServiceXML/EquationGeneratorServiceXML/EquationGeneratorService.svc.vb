' Fig. 25.14: EquationGeneratorService.vb
' WCF REST service to create random equations based on a
' specified operation and difficulty level.
Public Class EquationGeneratorService
   Implements IEquationGeneratorService
   ' method to generate a math equation
   Public Function GenerateEquation(operation As String,
      level As String) As Equation _
      Implements IEquationGeneratorService.GenerateEquation

      ' convert level from String to Integer
      Dim digits = Convert.ToInt32(level)

      ' calculate maximum and minimum number to be used
      Dim maximum As Integer = Convert.ToInt32(Math.Pow(10, digits))
      Dim minimum As Integer = Convert.ToInt32(Math.Pow(10, digits - 1))

      Dim randomObject As New Random() ' used to generate random numbers

      ' create Equation consisting of two random
      ' numbers in the range minimum to maximum 
      Dim newEquation As New Equation(
         randomObject.Next(minimum, maximum),
         randomObject.Next(minimum, maximum), operation)

      Return newEquation
   End Function ' GenerateEquation
End Class ' EquationGeneratorService

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
