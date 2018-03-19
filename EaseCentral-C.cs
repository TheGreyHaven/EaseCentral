// Part One Anagram Project:
// An anagram is a type of word play, the result of rearranging the letters of a word or phrase to produce a new word or phrase,
//using all the original letters exactly once; for example orchestra can be rearranged into carthorse.

// Take an input file (e.g. words.txt) with words that are separated on new lines. Run them through a program that will print
//the group of words that are anagrams. Goal is to be able to process this relatively quickly.

// Example Input File:
// ==============
// pop
// top
// yard
// bird
// star
// sore
// rose
// pot

// Example Output (words can be in any order but they must be grouped by their matching anagrams):
// =============
// top, pot
// sore, rose

using System;
using System.Collections.Generic;
using System.Collections;


class SortAnagrams
{
    static void Main()
    {

        Dictionary<string, string> anagramDict = new Dictionary<string, string>();

        // Read in .txt file.
        string[] words = System.IO.File.ReadAllLines(@"text.txt");

        // Loop through each word in the arrayList.
        foreach (string word in words)
        {
            // Make the string into a char array so that it can be sorted.
            char[] charWord = word.ToCharArray();
            Array.Sort(charWord);

            // Make the char array back into a string so that we can add it to our dictionary.
            string sortedWord = new string(charWord);

            // If the dictionary contains the sorted word as a key add the word to the value.
            if (anagramDict.ContainsKey(sortedWord) == true)
                anagramDict[sortedWord] = anagramDict[sortedWord] + ", " + word;

            else
                anagramDict[sortedWord] = word;
        }

        foreach(KeyValuePair<string, string> entry in anagramDict)
        {
            if (entry.Value.Contains(","))
                Console.WriteLine(entry.Value);
        }
    }
}

