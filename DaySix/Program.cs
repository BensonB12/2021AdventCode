using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

//I DID IT 117

namespace DaySix
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("test.txt");
            var listOfFish = new List<int>();
            var list2 = new List<int>();
            foreach (string line in allLines)
            {
                var parts = line.Split(",");

                foreach (string part in parts)
                {

                    listOfFish.Add(int.Parse(part));

                }
            }

            var arrayOfFish = listOfFish.ToArray();

            for (int j = 0; j < int.Parse(args[0]); j++)
            {
                int i = 0;

                foreach (int fish in arrayOfFish)
                {
                    if (fish > 0)
                    {
                        arrayOfFish[i] -= 1;
                    }
                    else
                    {
                        arrayOfFish[i] = 6;
                        list2.Add(8);
                    }
                    i++;
                }

                foreach (int fish in arrayOfFish)
                {
                    list2.Add(fish);
                }

                arrayOfFish = list2.ToArray();
                list2 = new List<int> { };
            }

            foreach(int fish in arrayOfFish)
            {
                Console.Write(fish);
            }
            WriteLine();
            Console.WriteLine($"{arrayOfFish.Length}");

            ProgramPt2.main(args);
        }

        // static void FromAHundred(ref List<int> listOfFish)
        // {
        //     decimal eight = 0, seven = 0;
        //     var allLines = File.ReadAllLines("test.txt");

        //     foreach (string line in allLines)
        //     {
        //         var parts = line.Split(",");

        //         foreach (string part in parts)
        //         {
        //             if (int.Parse(part) == 8)
        //             {
        //                 eight++;
        //             }
        //             else if (int.Parse(part) == 7)
        //             {
        //                 seven++;
        //             }
        //             else
        //             {
        //                 listOfFish.Add(int.Parse(part));
        //             }
        //         }
        //     }

        // }

    }
}

