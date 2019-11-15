' Fig. 28.16: MainWindow.xaml.vb
' Text-To-Speech and Speech-To-Text
Imports System.Speech.Synthesis
Imports System.Speech.Recognition
Imports System.Windows

Class MainWindow
   ' listens for speech input                         
   Private WithEvents listener As New SpeechRecognizer

   ' gives the listener choices of possible input
   Private WithEvents myGrammar As Grammar

   ' sends speech output to the speakers  
   Private talker As New SpeechSynthesizer

   ' keeps track of which description is to be printed 
   Private displayString As String

   ' maps images to their descriptions                            
   Private imageDescriptions As New Dictionary(Of Image, String)

   ' maps input phrases to their descriptions                     
   Private phraseDescriptions As New Dictionary(Of String, String)

   ' initialize all the phrases, descriptions and dictionaries
   Private Sub SpeechApp_Loaded(sender As Object,
      e As RoutedEventArgs) Handles Me.Loaded

      Dim descriptions() As String = New String(6) {}
      Dim phrases() As String = New String(6) {}

      ' define the input phrases
      phrases(0) = "Good Programming Practices"
      phrases(1) = "Software Engineering Observations"
      phrases(2) = "Performance Tips"
      phrases(3) = "Portability Tips"
      phrases(4) = "Look-And-Feel Observations"
      phrases(5) = "Error-Prevention Tips"
      phrases(6) = "Common Programming Errors"

      ' add the phrases to a Choices collection
      Dim theChoices As New Choices(phrases)

      ' build a Grammar around the Choices and set up the
      ' listener to use this grammar
      myGrammar = New Grammar(New GrammarBuilder(theChoices))
      listener.Enabled = True
      listener.LoadGrammar(myGrammar)

      ' define the descriptions for each icon/phrase
      descriptions(0) = "Good Programming Practices highlight " &
         "techniques for writing programs that are clearer, more " &
         "understandable, more debuggable, and more maintainable."
      descriptions(1) = "Software Engineering Observations highlight " &
         "architectural and design issues that affect the " &
         "construction of complex software systems."
      descriptions(2) = "Performance Tips highlight opportunities " &
         "for improving program performance."
      descriptions(3) = "Portability Tips help students write " &
         "portable code that can execute on different platforms."
      descriptions(4) = "Look-and-Feel Observations highlight " &
         "graphical user interface conventions. These observations " &
         "help students design their own graphical user interfaces in " &
         "conformance with industry standards."
      descriptions(5) = "Error-Prevention Tips tell people how to " &
         "test and debug their programs. Many of the tips also " &
         "describe aspects of creating programs that " &
         "reduce the likelihood of 'bugs' and thus simplify the " &
         "testing and debugging process."
      descriptions(6) = "Common Programming Errors focus the " &
         "students' attention on errors commonly made by beginning " &
         "programmers. This helps students avoid making the same " &
         "errors. It also helps reduce the long lines outside " &
         "instructors' offices during office hours!"

      ' map each image to its corresponding description
      imageDescriptions.Add(GoodPracticesImage, descriptions(0))
      imageDescriptions.Add(ObservationsImage, descriptions(1))
      imageDescriptions.Add(PerformanceImage, descriptions(2))
      imageDescriptions.Add(PortabilityImage, descriptions(3))
      imageDescriptions.Add(LookAndFeelImage, descriptions(4))
      imageDescriptions.Add(PreventionImage, descriptions(5))
      imageDescriptions.Add(ErrorImage, descriptions(6))

      ' loop through the phrases and descriptions and map accordingly
      For index As Integer = 0 To 6
         phraseDescriptions.Add(phrases(index), descriptions(index))
      Next ' end For
   End Sub ' SpeechApp_Loaded

   ' when the user clicks on the speech-synthesis button, speak the
   ' contents of the related text box
   Private Sub SpeechButton_Click(sender As Object,
      e As RoutedEventArgs) Handles SpeechButton.Click
      talker.SpeakAsync(SpeechBox.Text)
   End Sub ' SpeechButton_Click

   ' when the user clicks on an image, set the display string and call
   ' DisplaySpeak
   Private Sub Image_MouseDown(sender As Object,
      e As Input.MouseButtonEventArgs) _
      Handles PreventionImage.MouseDown, GoodPracticesImage.MouseDown,
         LookAndFeelImage.MouseDown, PerformanceImage.MouseDown,
         PortabilityImage.MouseDown, ObservationsImage.MouseDown,
         ErrorImage.MouseDown

      ' use the image-to-description dictionary to get the appropriate
      ' description for the clicked image
      displayString = imageDescriptions(CType(sender, Image))
      DisplaySpeak()
   End Sub ' Image_MouseDown

   ' when the listener recognizes a phrase from the grammar, set the
   ' display string and call DisplaySpeak
   Private Sub myGrammar_SpeechRecognized(sender As Object,
      e As RecognitionEventArgs) Handles myGrammar.SpeechRecognized

      ' Use the phrase-to-description dictionary to get the appropriate
      ' description for the spoken phrase
      displayString = phraseDescriptions(e.Result.Text)

      ' Use the dispatcher to call displayDetails                    
      Me.Dispatcher.BeginInvoke(New Action(AddressOf DisplaySpeak))
   End Sub ' myGrammar_SpeechRecognized

   ' Set the appropriate text block to the display string
   ' and order the synthesizer to speak it
   Private Sub DisplaySpeak()
      InfoBlock.Text = displayString
      talker.SpeakAsync(displayString)
   End Sub ' DisplayDetails
End Class ' SpeechApp

' **************************************************************************
' * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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