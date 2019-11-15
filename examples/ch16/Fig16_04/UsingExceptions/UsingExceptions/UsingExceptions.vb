' Fig. 16.4: UsingExceptions.vb
' Using Finally blocks demonstrates that Finally always executes.
Module UsingExceptions
   Sub Main()
      ' Case 1: No exceptions occur in called method
      Console.WriteLine("Calling DoesNotThrowException")
      DoesNotThrowException()

      ' Case 2: Exception occurs and is caught in called method
      Console.WriteLine(vbCrLf & "Calling ThrowExceptionWithCatch")
      ThrowExceptionWithCatch()

      ' Case 3: Exception occurs, but is not caught in called method 
      ' because there is no catch block.
      Console.WriteLine(vbCrLf & "Calling ThrowExceptionWithoutCatch")

      ' call ThrowExceptionWithoutCatch
      Try
         ThrowExceptionWithoutCatch()
      Catch
         Console.WriteLine("Caught exception from " &
            "ThrowExceptionWithoutCatch in Main")
      End Try

      ' Case 4: Exception occurs and is caught in called method,
      ' then rethrown to caller.
      Console.WriteLine(vbCrLf & "Calling ThrowExceptionCatchRethrow")

      ' call ThrowExceptionCatchRethrow
      Try
         ThrowExceptionCatchRethrow()
      Catch
         Console.WriteLine("Caught exception from " &
            "ThrowExceptionCatchRethrow in Main")
      End Try
   End Sub ' Main

   ' no exceptions thrown
   Sub DoesNotThrowException()
      ' try block does not throw any exceptions 
      Try
         Console.WriteLine("In DoesNotThrowException")
      Catch
         Console.WriteLine("This catch never executes")
      Finally
         Console.WriteLine("finally executed in DoesNotThrowException")
      End Try

      Console.WriteLine("End of DoesNotThrowException")
   End Sub ' DoesNotThrowException

   ' throws exception and catches it locally
   Sub ThrowExceptionWithCatch()
      ' try block throws exception
      Try
         Console.WriteLine("In ThrowExceptionWithCatch")
         Throw New Exception("Exception in ThrowExceptionWithCatch")
      Catch exceptionParameter As Exception
         Console.WriteLine("Message: " & exceptionParameter.Message)
      Finally
         Console.WriteLine("finally executed in ThrowExceptionWithCatch")
      End Try

      Console.WriteLine("End of ThrowExceptionWithCatch")
   End Sub ' ThrowExceptionWithCatch

   ' throws exception and does not catch it locally
   Sub ThrowExceptionWithoutCatch()
      ' throw exception, but do not catch it
      Try
         Console.WriteLine("In ThrowExceptionWithoutCatch")
         Throw New Exception("Exception in ThrowExceptionWithoutCatch")
      Finally
         Console.WriteLine("finally executed in " &
            "ThrowExceptionWithoutCatch")
      End Try

      ' unreachable code; logic error 
      Console.WriteLine("End of ThrowExceptionWithoutCatch")
   End Sub ' ThrowExceptionWithoutCatch

   ' throws exception, catches it and rethrows it
   Sub ThrowExceptionCatchRethrow()
      ' try block throws exception
      Try
         Console.WriteLine("In ThrowExceptionCatchRethrow")
         Throw New Exception("Exception in ThrowExceptionCatchRethrow")
      Catch exceptionParameter As Exception
         Console.WriteLine("Message: " & exceptionParameter.Message)

         ' rethrow exception for further processing
         Throw

         ' code placed here would be unreachable; logic error
      Finally
         Console.WriteLine("finally executed in " &
            "ThrowExceptionCatchRethrow")
      End Try

      ' any code placed here is never reached
      Console.WriteLine("End of ThrowExceptionCatchRethrow")
   End Sub ' ThrowExceptionCatchRethrow
End Module ' UsingExceptions

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