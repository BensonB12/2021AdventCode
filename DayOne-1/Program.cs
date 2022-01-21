using System;
using System.IO;
using System.Collections.Generic;

namespace DayOne_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("Input.txt");

            var list = new List<double>();

            int l = 0;
            foreach(string line in input)
            {
                if(double.Parse(input[l]) == 7422)
                {
                    break;
                }
                for (int k = 0; k < 3; k++)
                {
                    double letter = double.Parse(input[l]) + double.Parse(input[l + 1]) + double.Parse(input[l + 2]);
                    list.Add(letter);
                }
                l++;
            }

            double j = 200000;
            int i = 0;

            foreach (double number in list)
            {
                double num = number;

                if (num > j)
                {
                    i++;
                }

                j = number;
            }
            Console.WriteLine(i);
        }
    }
}
