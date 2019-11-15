' Fig. 9.11: Time.vb
' Time class with Hour, Minute and Second properties.
Public Class Time
   ' declare Integer instance variables for the hour, minute and second
   Private hourValue As Integer ' 0 - 23
   Private minuteValue As Integer ' 0 - 59
   Private secondValue As Integer ' 0 - 59

   ' Time constructor with hour, minute and second as optional parameters
   Public Sub New(Optional h As Integer = 12,
      Optional m As Integer = 0, Optional s As Integer = 0)
      SetTime(h, m, s) ' call SetTime with three arguments
   End Sub ' New

   ' Time constructor: another Time object supplied
   Public Sub New(t As Time)
      SetTime(t.hourValue, t.minuteValue, t.secondValue)
   End Sub ' New

   ' set a new time value using universal time, check validity of the data
   Public Sub SetTime(h As Integer, m As Integer, s As Integer)

      Hour = h ' Set accessor validates the hour
      Minute = m ' Set accessor validates the minute
      Second = s ' Set accessor validates the second
   End Sub ' SetTime

   ' property Hour                                              
   Public Property Hour() As Integer
      Get ' return hourValue                                    
         Return hourValue
      End Get

      Set(value As Integer) ' set hourValue
         If (value >= 0 AndAlso value < 24) Then ' in range 0-23?
            hourValue = value ' value is valid
         Else ' invalid hour
            Throw New ArgumentOutOfRangeException("hour must be 0-23")
         End If
      End Set
   End Property ' Hour

   ' property Minute                                            
   Public Property Minute() As Integer
      Get ' return minuteValue                                  
         Return minuteValue
      End Get

      Set(value As Integer) ' set minuteValue
         If (value >= 0 AndAlso value < 60) Then ' in range 0-59?
            minuteValue = value ' value is valid
         Else ' invalid minute
            Throw New ArgumentOutOfRangeException("minute must be 0-59")
         End If
      End Set
   End Property ' Minute                                        

   ' property Second                                            
   Public Property Second() As Integer
      Get ' return secondValue                                  
         Return secondValue
      End Get

      Set(value As Integer) ' set secondValue
         If (value >= 0 AndAlso value < 60) Then ' in range 0-59?
            secondValue = value ' value is valid
         Else ' invalid second
            Throw New ArgumentOutOfRangeException("second must be 0-59")
         End If
      End Set
   End Property ' Second      

   ' return Time as a String in universal-time (24-hour clock) format
   Public Function ToUniversalString() As String
      Return String.Format("{0}:{1:D2}:{2:D2}", Hour, Minute, Second)
   End Function ' ToUniversalString

   ' return Time as a String in standard-time (12-hour clock) format
   Public Overrides Function ToString() As String
      Dim suffix As String ' AM or PM suffix
      Dim standardHour As Integer ' a standard hour in the range 1-12

      ' determine whether the 12-hour clock suffix should be AM or PM
      If Hour < 12 Then
         suffix = "AM"
      Else
         suffix = "PM"
      End If

      ' convert hour from universal-time format to standard-time format
      If (Hour = 12 OrElse Hour = 0) Then
         standardHour = 12 ' noon or midnight
      Else
         standardHour = Hour Mod 12 ' 1 through 11, AM or PM
      End If

      Return String.Format("{0}:{1:D2}:{2:D2} {3}",
         standardHour, Minute, Second, suffix)
   End Function ' ToString
End Class ' Time


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