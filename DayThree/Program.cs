using System;
using System.Collections.Generic;
using System.IO;

namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            var listOfCanidates = new List<int[]> { };
            var listOfSecondCanidates = new List<int[]> { };
            var binaryNum = new int[] { };

            foreach (string put in input)
            {
                var numbers = put.Split("|");

                var listOfNumbersInBinaryNumber = new List<int> { };

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    listOfNumbersInBinaryNumber.Add(int.Parse(numbers[i]));
                }
                binaryNum = listOfNumbersInBinaryNumber.ToArray();


                listOfCanidates.Add(binaryNum);

            }

            var intArray = LengthOfBinaryNum(binaryNum);

            Decimal numberOfCanidates = listOfSecondCanidates.Count;

            int gamma = 0;

            for (int b = 0; b < binaryNum.Length; b++)
            {
                gamma = 0;
                foreach (int[] binaryNumber in listOfCanidates)
                {
                    if (binaryNumber[b] == 1)
                    {
                        intArray[b] += 1;
                    }
                }

                if (intArray[b] >= (numberOfCanidates / 2))
                {
                    gamma = 1;
                }
                
                numberOfCanidates = 0;

                foreach (int[] binaryNumber in listOfCanidates)
                {
                    if (binaryNumber[b] == gamma)
                    {
                        numberOfCanidates++;
                        listOfSecondCanidates.Add(binaryNumber);
                    }
                }

                foreach (int[] canidate in listOfCanidates)
                {
                    foreach (Decimal num in canidate)
                    {
                        Console.Write(num);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                listOfCanidates = listOfSecondCanidates;
                listOfSecondCanidates = new List<int[]> { };

            }
            Console.WriteLine("\n^^^^Top^^^^\n\n\n\n\nVVVVVVVBottomVVVVVVVV\n\n\n\n");
        }
        static int[] LengthOfBinaryNum(int[] binaryNumber)
        {
            if (binaryNumber.Length == 5)
            {
                return new int[5] { 0, 0, 0, 0, 0 };
            }
            else
            {
                return new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
        }

        static void OxigenGenorator()
        {
            var input = File.ReadAllLines("input.txt");

            var listOfCanidates = new List<int[]> { };
            var listOfSecondCanidates = new List<int[]> { };
            var binaryNum = new int[] { };

            foreach (string put in input)
            {
                var numbers = put.Split("|");

                var listOfNumbersInBinaryNumber = new List<int> { };

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    listOfNumbersInBinaryNumber.Add(int.Parse(numbers[i]));
                }
                binaryNum = listOfNumbersInBinaryNumber.ToArray();


                listOfCanidates.Add(binaryNum);

            }

            var intArray = LengthOfBinaryNum(binaryNum);

            Decimal numberOfCanidates = listOfSecondCanidates.Count;

            int gamma = 0;

            for (int b = 0; b < binaryNum.Length; b++)
            {
                gamma = 0;
                foreach (int[] binaryNumber in listOfCanidates)
                {
                    if (binaryNumber[b] == 1)
                    {
                        intArray[b] += 1;
                    }
                }

                if (intArray[b] < (numberOfCanidates / 2))
                {
                    gamma = 1;
                }
                numberOfCanidates = 0;

                foreach (int[] binaryNumber in listOfCanidates)
                {
                    if (binaryNumber[b] == gamma)
                    {
                        numberOfCanidates++;
                        listOfSecondCanidates.Add(binaryNumber);
                    }
                }

                foreach (int[] canidate in listOfCanidates)
                {
                    foreach (Decimal num in canidate)
                    {
                        Console.Write(num);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                listOfCanidates = listOfSecondCanidates;
                listOfSecondCanidates = new List<int[]> { };
            }
        }
    }
}
