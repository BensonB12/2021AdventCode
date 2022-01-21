using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace daySeven
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("input.txt");
            var list = new List<int>();
            decimal feul = 0;
            int chosenNum = 0;
            foreach (string line in allLines)
            {
                var parts = line.Split(",");

                foreach (string part in parts)
                {
                    list.Add(int.Parse(part));
                }
            }
            var array = list.ToArray();

            int avg = (int) Queryable.Average(array.AsQueryable());


            
            WriteLine(avg);
            chosenNum = avg;

            foreach(int crab in list)
            {
                int moves =Math.Abs(crab - chosenNum);
                feul += (moves * (moves + 1)) / 2;
            }

            WriteLine(feul);
        }
    }
}
