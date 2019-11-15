' Fig. 29.13: SortedDictionaryTest.vb
' Application counts the number of occurrences of each word in a String
' and stores them in a generic sorted dictionary.
Module SortedDictionaryTest
   Sub Main()
      ' create sorted dictionary based on user input
      Dim dictionary As SortedDictionary(Of String, Integer) =
         CollectWords()

      ' display sorted dictionary content
      DisplayDictionary(Dictionary)
   End Sub ' Main

   ' create sorted dictionary from user input
   Private Function CollectWords() As SortedDictionary(
      Of String, Integer)
      ' create a new sorted dictionary
      Dim dictionary As New SortedDictionary(Of String, Integer)()

      Console.WriteLine("Enter a string: ") ' prompt for user input
      Dim input As String = Console.ReadLine() ' get input

      ' split input text into tokens
      Dim words As String() = input.Split()

      ' processing input words
      For Each word In words
         Dim wordKey As String = word.ToLower() ' get word in lowercase

         ' if the dictionary contains the word
         If dictionary.ContainsKey(wordKey) Then
            dictionary(wordKey) += 1
         Else
            ' add new word with a count of 1 to the dictionary
            dictionary.Add(wordKey, 1)
         End If
      Next

      Return dictionary
   End Function ' CollectWords

   ' display dictionary content
   Private Sub DisplayDictionary(Of K, V)(
      dictionary As SortedDictionary(Of K, V))

      Console.WriteLine(vbCrLf & "Sorted dictionary contains:" &
         vbCrLf & "{0,-12}{1,-12}", "Key:", "Value:")

      ' generate output for each key in the sorted dictionary
      ' by iterating through the Keys property with a For Each statement
      For Each key In dictionary.Keys
         Console.WriteLine("{0,-12}{1,-12}", key, dictionary(key))
      Next

      Console.WriteLine(vbCrLf & "size: {0}", dictionary.Count)
   End Sub ' DisplayDictionary
End Module ' SortedDictionaryTest


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

