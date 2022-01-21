using System;
using System.IO;

namespace DayTwo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("Input.txt");  
            int depth = 0;
            int horizontal = 0;
            int aim = 0;

            foreach(string put in input)
            {
                var num = put.Split(" ");
                int number = int.Parse(num[1]);

                switch (num[0])
                {
                    case "forward":
                    horizontal += number;
                    depth += (aim * number);
                    break;
                    case "up":
                    aim -= number;
                    break;
                    case "down":
                    aim += number;
                    break;
                    default:
                    throw new Exception("wtf");
                }
            }

            Console.WriteLine(horizontal);
            Console.WriteLine(depth);
            Console.WriteLine(depth * horizontal);
        }
    }
}
