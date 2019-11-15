' Fig. 16.5: Properties.vb
' Exception properties and stack unwinding.
Module Properties
   Sub Main()
      ' call Method1; any Exception generated is caught
      ' in the catch block that follows
      Try
         Method1()
      Catch exceptionParameter As Exception
         ' output the string representation of the Exception, then output
         ' properties Message, StackTrace and InnerException
		 Console.WriteLine("exceptionParameter.ToString: " &
            vbCrLf & "{0}" & vbCrLf,
            exceptionParameter.ToString())
         Console.WriteLine("exceptionParameter.Message: " &
            vbCrLf & "{0}" & vbCrLf,
            exceptionParameter.Message)
         Console.WriteLine("exceptionParameter.StackTrace: " &
            vbCrLf & "{0}" & vbCrLf,
            exceptionParameter.StackTrace)
         Console.WriteLine("exceptionParameter.InnerException: " &
            vbCrLf & "{0}" & vbCrLf,
            exceptionParameter.InnerException.ToString())
      End Try
   End Sub ' Main

   ' calls Method2
   Sub Method1()
      Method2()
   End Sub ' Method1

   ' calls Method3
   Sub Method2()
      Method3()
   End Sub ' Method2

   ' throws an Exception containing an InnerException
   Sub Method3()
      ' attempt to convert string to integer
      Try
         Convert.ToInt32("Not an integer")
      Catch formatExceptionParameter As FormatException
         ' wrap FormatException in new Exception
         Throw New Exception("Exception occurred in Method3",
            formatExceptionParameter)
      End Try
   End Sub ' Method3
End Module ' Properties

'**************************************************************************
'* (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
'* Pearson Education, Inc. All Rights Reserved.                           *
'*                                                                        *
'* DISCLAIMER: The authors and publisher of this book have used their     *
'* best efforts in preparing the book. These efforts include the          *
'* development, research, and testing of the theories and programs        *
'* to determine their effectiveness. The authors and publisher make       *'
'* no warranty of any kind, expressed or implied, with regard to these    *
'* programs or to the documentation contained in these books. The authors *
'* and publisher shall not be liable in any event for incidental or       *
'* consequential damages in connection with, or arising out of, the       *
'* furnishing, performance, or use of these programs.                     *
'**************************************************************************