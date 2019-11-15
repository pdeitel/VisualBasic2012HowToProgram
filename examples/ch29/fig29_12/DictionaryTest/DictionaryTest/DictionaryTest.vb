' Fig. 29.12: DictionaryTest.vb
' Application counts the number of occurrences of each word in a String
' and stores them in a dictionary.
Module DictionaryTest
   Sub Main()
      ' create dictionary based on user input
      Dim table As Dictionary(Of String, Integer) = CollectWords()

      ' display dictionary content
      DisplayDictionary(table)
   End Sub ' Main

   ' create dictionary from user input
   Private Function CollectWords() As Dictionary(Of String, Integer)
      ' create a new dictionary
      Dim table As New Dictionary(Of String, Integer)

      Console.WriteLine("Enter a string: ") ' prompt for user input
      Dim input As String = Console.ReadLine() ' get input

      ' split input text into tokens (words)
      Dim words As String() = input.Split()

      ' processing input words
      For Each word In words
         Dim wordKey As String = word.ToLower() ' get word in lowercase

         ' if the dictionary contains the word
         If table.ContainsKey(wordKey) Then
            table(wordKey) = table(wordKey) + 1
         Else
            ' add new word with a count of 1 to dictionary
            table.Add(wordKey, 1)
         End If
      Next

      Return table
   End Function ' CollectWords

   ' display dictionary content
   Private Sub DisplayDictionary(
      ByVal table As Dictionary(Of String, Integer))
      Console.WriteLine(vbCrLf & "Dictionary contains:" &
         vbCrLf & "{0,-12}{1,-12}", "Key:", "Value:")

      ' generate output for each key in dictionary by 
      ' iterating through the Keys property with a For Each statement
      For Each key In table.Keys
         Console.WriteLine("{0,-12}{1,-12}", key, table(key))
      Next

      Console.WriteLine(vbCrLf & "size: {0}", table.Count)
   End Sub ' DisplayDictionary
End Module ' DictionaryTest


'**************************************************************************
'* (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
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