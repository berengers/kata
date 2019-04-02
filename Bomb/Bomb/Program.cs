using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace bomb
{
  public class Program
  {
    static void Main(string[] args)
    {
      var lines = File.ReadAllLines("./mission2.txt").Where( x => x.Length > 0 ).ToList();
      var combinaisons = getCombinaisons(lines);
      var codes = convertToStringCombi(combinaisons);
      var solution = findSolution(codes);

      if (solution != 0)
      {
        Console.WriteLine($"The good combinaison is : {solution}");
      }
    }

    public static int findSolution(string[] codes)
    {
      for (int i = 0; i < codes.Length; i++)
      {
        var result = (
          Char.GetNumericValue(codes[i][8]) +
          2 * Char.GetNumericValue(codes[i][7]) +
          3 * Char.GetNumericValue(codes[i][6]) +
          4 * Char.GetNumericValue(codes[i][5]) +
          5 * Char.GetNumericValue(codes[i][4]) +
          6 * Char.GetNumericValue(codes[i][3]) +
          7 * Char.GetNumericValue(codes[i][2]) +
          8 * Char.GetNumericValue(codes[i][1]) +
          9 * Char.GetNumericValue(codes[i][0])
          ) % 11 == 0;

        if (result)
        {
          return Int32.Parse(codes[i]);
        }
      }
      return 0;
    }

    public static string[] convertToStringCombi(List<string> combinaisons)
    {
      var numbers = new string[10] {
        " _ " +
        "| |" +
        "|_|",

        "   " +
        "  |" +
        "  |",

        " _ " +
        " _|" +
        "|_ ",

        " _ " +
        " _|" +
        " _|",

        "   " +
        "|_|" +
        "  |",

        " _ " +
        "|_ " +
        " _|",

        " _ " +
        "|_ " +
        "|_|",

        " _ " +
        "  |" +
        "  |",

        " _ " +
        "|_|" +
        "|_|",

        " _ " +
        "|_|" +
        " _|",
      };
      var strCombinaisons = new string[combinaisons.Count];

      for (int i = 0; i < combinaisons.Count; i++)
      {
        var strInt = orderCombi(combinaisons[i]);
        for (int j = 0; j < 9; j++)
        {
          for (int k = 0; k <= 9; k++)
          {
            if (numbers[k] == strInt.Substring(j*9, 9))
            {
              strCombinaisons[i] += k;
            }
            else
            {

            }
          }
        }
      }
      return strCombinaisons;
    }

    static string orderCombi(string combi)
    {
      var str = combi.Substring(0, 3) + combi.Substring(27, 3) + combi.Substring(54, 3)
      + combi.Substring(3, 3) + combi.Substring(30, 3) + combi.Substring(57, 3)
      + combi.Substring(6, 3) + combi.Substring(33, 3) + combi.Substring(60, 3)
      + combi.Substring(9, 3) + combi.Substring(36, 3) + combi.Substring(63, 3)
      + combi.Substring(12, 3) + combi.Substring(39, 3) + combi.Substring(66, 3)
      + combi.Substring(15, 3) + combi.Substring(42, 3) + combi.Substring(69, 3)
      + combi.Substring(18, 3) + combi.Substring(45, 3) + combi.Substring(72, 3)
      + combi.Substring(21, 3) + combi.Substring(48, 3) + combi.Substring(75, 3)
      + combi.Substring(24, 3) + combi.Substring(51, 3) + combi.Substring(78, 3);
      return str;
    }
    static List<String> getCombinaisons(List<string> lines) {
      var list = new List<String>();
      
      var count = 0;
      var combinaison = "";
      for (int i = 0; i < lines.Count(); i++)
      {
        if (i == 0 || i % 3 > 0)
        {
          count++;
        }
        else {
          list.Add(combinaison);
          count = 0;
          combinaison = "";
        }
        
        combinaison += lines[i];
      }

      return list;
    }
  }
}
