using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace dayEight
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("test.txt");
            var listOfOutputs = new List<string>();
            var listOfAllTen = new List<string>();
            var listOfIndividuals = new List<string>();
            Decimal total = 0;

            foreach (string line in allLines)
            {
                var parts = line.Split("|");

                listOfAllTen.Add(parts[0]);
                listOfOutputs.Add(parts[1]);
            }

            var arrayOfOutputs = listOfOutputs.ToArray();
            int k = 0;

            foreach (string digit in listOfAllTen)
            {
                var individuals = digit.Split(" ");

                foreach (string individual in individuals)
                {
                    listOfIndividuals.Add(individual.ToString());
                }

                char[] one = new char[2] { ' ', ' ' };
                char[] six = new char[6] { ' ', ' ', ' ', ' ', ' ', ' ' };
                char[] four = new char[4] { ' ', ' ', ' ', ' ' };
                var seven = new char[3] { ' ', ' ', ' ' };
                char[] eight = new char[8] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
                var nine = new char[6] { ' ', ' ', ' ', ' ', ' ', ' ' };
                var zero = new char[] { };
                var three = new char[5] { ' ', ' ', ' ', ' ', ' ' };
                var five = new char[5] { ' ', ' ', ' ', ' ', ' ' };
                char[] two = new char[5] { ' ', ' ', ' ', ' ', ' ' };
                char[] partsCharArray;
                var listOfCharArray = new List<char[]> { };
                int m = 0;

                while (m < 10)
                {
                    foreach (string number in listOfIndividuals)
                    {
                        OtherMethod(number, ref one, ref three, ref four, ref six, ref m);
                    }
                }

                var parts = arrayOfOutputs[k].Split(" ");


                var q = new int[4] { 0, 0, 0, 0 };

                foreach (string number in parts)
                {
                    WriteLine(number);
                    WriteLine();
                    partsCharArray = number.ToCharArray();
                    Array.Sort(partsCharArray);

                    if (partsCharArray.ToString() == zero.ToString())
                    {
                        //*** Move this to the Zero Spot, and so on. Stop making it harder for yourself
                        m = 0;
                        m++;
                    }
                    if (partsCharArray.ToString() == one.ToString())
                    {
                        m = 1;
                        m++;
                    }
                    if (partsCharArray.ToString() == two.ToString())
                    {
                        m = 2;
                        m++;
                    }
                    if (partsCharArray.ToString() == three.ToString())
                    {
                        m = 3;
                        m++;
                    }
                    if (partsCharArray.ToString() == four.ToString())
                    {
                        m = 4;
                        m++;
                    }
                    if (partsCharArray.ToString() == five.ToString())
                    {
                        m = 5;
                        m++;
                    }
                    if (partsCharArray.ToString() == six.ToString())
                    {
                        m = 6;
                        m++;
                    }
                    if (partsCharArray.ToString() == seven.ToString())
                    {
                        m = 7;
                        m++;
                    }
                    if (partsCharArray.ToString() == eight.ToString())
                    {
                        m = 8;
                        m++;
                    }
                    if (partsCharArray.ToString() == nine.ToString())
                    {
                        m = 9;
                        m++;
                    }

                    total += q[0] * 1000 + q[1] * 100 + q[2] * 10 + q[3];
                }

                listOfCharArray = new List<char[]> { };
                listOfIndividuals = new List<string> { };
                k++;
            }

            WriteLine(total);
        }
        static void OtherMethod(string number, ref char[] one, ref char[] three, ref char[] four, ref char[] six, ref int m)
        {
            var q = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            char[] charArray;

            charArray = number.ToCharArray();
            Array.Sort(charArray);

            int count = 0;

            if (m < 2)
            {
                if (charArray.Length == 2)
                {
                    q[0] = 1;
                    m++;
                    one = charArray;
                }
                if (charArray.Length == 4)
                {
                    four = charArray;
                    q[0] = 4;
                    m++;
                }
            }
            else if (m < 5)
            {
                if (charArray.Length == 5)
                {
                    if (number.Contains(four[0]) && number.Contains(four[3]) && number.Contains(four[2]) && number.Contains(four[1]))
                    {
                        q[0] = 9;
                        m++;
                    }
                    else if (number.Contains(one[0]) && number.Contains(one[1]))
                    {
                        q[0] = 0;
                        m++;
                    }
                    else
                    {
                        six = charArray;
                        q[0] = 6;
                        m++;
                    }
                }

            }
            else
            {
                if (charArray.Length == 3)
                {
                    q[0] = 7;
                    m++;
                }
                else if (charArray.Length == 7)
                {
                    q[0] = 8;
                    m++;
                }
                else if ((number.Contains(one[0]) && number.Contains(one[1])))
                {
                    q[0] = 3;
                    m++;
                }
                else
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (number.Contains(six[j]))
                        {
                            count++;
                        }
                        if (count == 5)
                        {
                            q[0] = 5;
                            m++;
                        }
                    }
                }
                if (count == 4)
                {
                    q[0] = 2;
                    m++;
                }
            }

            //total += q[0] * 1000 + q[1] * 100 + q[2] * 10 + q[3];
        }
    }
}
