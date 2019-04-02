using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RomanBills
{
    public class Program
    {
        static void Main(string[] args)
        {
            var romansColumn = File.ReadAllLines("../mission3.txt");
            var integersColumn = convertRomansToIntegers(romansColumn);
            var difference = integersColumn.Aggregate((s1, s2) => s1 + s2);
        }

        static int[] convertRomansToIntegers(string[] lines)
        {
            var ints = new int[lines.Length];

            for (int index = 0; index < lines.Length; index++)
            {
                ints[index] = convertRomanToInteger(lines[index]);
            }

            return ints;
        }
        public static int convertRomanToInteger(string line)
        {
            if (line.Length == 0) return 0;

            var bill = new List<int>();
            for (int index = 0; index < line.Length; index++)
            {
                if (index == 0 && line[index] == '-') continue;

                if (line[index] == 'I') 
                {
                    bill.Add(1);
                    continue;
                };
                if (line[index] == 'V') 
                {
                    bill.Add(5);
                    continue;
                };
                if (line[index] == 'X') 
                {
                    bill.Add(10);
                    continue;
                };
                if (line[index] == 'L') 
                {
                    bill.Add(50);
                    continue;
                };
                if (line[index] == 'C') 
                {
                    bill.Add(100);
                    continue;
                };
                if (line[index] == 'D') 
                {
                    bill.Add(500);
                    continue;
                };
                if (line[index] == 'M') 
                {
                    bill.Add(1000);
                    continue;
                };
            }

            var result = 0;
            for (var index = 0; index < bill.Count(); index++)
            {
                if (index != bill.Count() - 1 && bill[index + 1] > bill[index])
                {
                    result -= bill[index];
                } else
                {
                    result += bill[index];
                }
            }

            if (line[0] == '-') result = result * -1;

            return result;
        }
    }
}
