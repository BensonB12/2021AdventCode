using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace dayTen
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("input.txt");
            var list = new List<decimal>();

            foreach (string line in allLines)
            {
                decimal total = 0;
                var parts = line.Split('|');
                Array.Reverse(parts);
                
                foreach (string part in parts)
                {
                    total *= 5;
                    switch (part)
                    {
                        case "(":
                            total += 1;
                            break;
                        case "[":
                            total += 2;
                            break;
                        case "{":
                            total += 3;
                            break;
                        case "<":
                            total += 4;
                            break;
                        default:
                            break;
                    }
                }
                WriteLine(total);
                list.Add(total);
            }
            var array = list.ToArray();
            Array.Sort(array);
            WriteLine();
            foreach (decimal num in array)
            {
                WriteLine(num);
            }
            WriteLine();
            WriteLine(array[array.Length / 2]);
        }
    }
}
