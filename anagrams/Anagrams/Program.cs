using System.Linq;
using System;
using System.IO;
using System.Collections.Generic;

namespace Anagrams
{
    public static class Program
    {
        const string Anagram = "atelier";
        static void Main(string[] args)
        {
            var allWords = File.ReadAllLines("./mission1.txt");
            var filteredWords = allWords.Where(word => word.Length < 6).ToList();
            var anagrams = findAnagrams(filteredWords, Anagram);
        }
        static List<Array> findAnagrams(List<string> words, string anagram )
        {
            var anagrams = new List<Array>();
            
            for (int indexWord1 = 0; indexWord1 < words.Count(); indexWord1++)
            {
                for (int indexWord2 = 0; indexWord2 < indexWord1; indexWord2++)
                {
                    if ((words[indexWord1] + words[indexWord2]).Length != Anagram.Length)
                    {
                        continue;
                    }
                    else if (isAnagram(words[indexWord1], words[indexWord2], Anagram))
                    {
                        anagrams.Add(new string[] { words[indexWord1], words[indexWord2] });
                    }
                }
            }
            return anagrams;
        }
        public static bool isAnagram(string word1, string word2, string anagram)
        {
            var orderedAnagram = String.Concat(anagram.OrderBy(c=>c));
            var concatenedWords = word1 + word2;
            var orderedConcatenedWords = String.Concat(concatenedWords.OrderBy(c=>c));
            return orderedConcatenedWords == orderedAnagram;
        }
    }
}
