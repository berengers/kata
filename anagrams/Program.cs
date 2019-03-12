using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace anagrams
{
  class Program
  {
    static void Main(string[] args)
    {
      string wordToFind = "Atelier".ToLower();
      string[] arrayWords = File.ReadAllLines("./static/mission1.txt");
      List<Array> matchWords = new List<Array>();

      for (int i = 0; i < arrayWords.Length; i++)
      {
        for (int j = 0; j < i; j++)
        {
          string concatText = arrayWords[i].ToLower() + arrayWords[j].ToLower();
          string letterRest = wordToFind;

          if (concatText.Length != wordToFind.Length)
            continue;

          foreach (var letter in concatText)
          {

            if (letterRest.IndexOf(letter) > -1)
            {
              letterRest = letterRest.Remove(letterRest.IndexOf(letter), 1);
            } else
            {
                break;
            }

            if (letterRest.Length == 0)
            {
              matchWords.Add(new string[2] { arrayWords[i], arrayWords[j] });
              break;
            }
          }
        }
      }
      Console.WriteLine(matchWords);
    }
  }
}
