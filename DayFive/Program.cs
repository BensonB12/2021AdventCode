using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace DayFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            int j = -1;
            int final = 0;
            var listOfAlreadyOn = new List<(int, int)> { };
            var allLines = File.ReadAllLines("input.txt");
            var listOfCordTouched = new List<(int, int)> { };

            foreach (string line in allLines)
            {
                var listOfFourNum = new List<int> { };
                var fourNumbers = line.Split(" -> ");
                foreach (string number in fourNumbers)
                {
                    var fourIntNum = number.Split(",");
                    foreach (string num in fourIntNum)
                    {
                        listOfFourNum.Add(int.Parse(num));
                    }
                }
                var arrayOfFourNum = listOfFourNum.ToArray();
                if (arrayOfFourNum[0] == arrayOfFourNum[2])
                {
                    var inBetweenU = arrayOfFourNum[1] - arrayOfFourNum[3];
                    if (inBetweenU > 0)
                    {
                        for (int i = 0; i <= inBetweenU; i++)
                        {
                            listOfCordTouched.Add((arrayOfFourNum[0], arrayOfFourNum[3] + i));
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= Math.Abs(inBetweenU); i++)
                        {
                            listOfCordTouched.Add((arrayOfFourNum[0], arrayOfFourNum[1] + i));
                        }
                    }
                }
                else if (arrayOfFourNum[1] == arrayOfFourNum[3])
                {
                    var inBetweenS = arrayOfFourNum[0] - arrayOfFourNum[2];
                    if (inBetweenS > 0)
                    {
                        for (int i = 0; i <= inBetweenS; i++)
                        {
                            listOfCordTouched.Add((arrayOfFourNum[2] + i, arrayOfFourNum[1]));
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= Math.Abs(inBetweenS); i++)
                        {
                            listOfCordTouched.Add((arrayOfFourNum[0] + i, arrayOfFourNum[1]));
                        }
                    }
                }
                else
                {
                    var topDiff = arrayOfFourNum[0] - arrayOfFourNum[2];
                    var upDiff = arrayOfFourNum[1] - arrayOfFourNum[3];

                    if (topDiff > 0)
                    {
                        if (upDiff > 0)
                        {
                            for (int i = 0; i <= topDiff; i++)
                            {
                                listOfCordTouched.Add((arrayOfFourNum[2] + i, arrayOfFourNum[3] + i));
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= topDiff; i++)
                            {
                                listOfCordTouched.Add((arrayOfFourNum[2] + i, arrayOfFourNum[3] - i));
                            }
                        }
                    }
                    else
                    {
                        if (upDiff > 0)
                        {
                            for (int i = 0; i <= Math.Abs(topDiff); i++)
                            {
                                listOfCordTouched.Add((arrayOfFourNum[2] - i, arrayOfFourNum[3] + i));
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= Math.Abs(topDiff); i++)
                            {
                                listOfCordTouched.Add((arrayOfFourNum[0] + i, arrayOfFourNum[1] + i));
                            }
                        }
                    }
                }
            }
            foreach ((int, int) cord in listOfCordTouched)
            {
                j = 0;
                foreach ((int, int) cordanate in listOfCordTouched)
                {
                    if (cord == cordanate)
                    {
                        j++;
                        if (j >= 2)
                        {
                            if (listOfAlreadyOn.Contains(cord)) { }
                            else
                            {
                                listOfAlreadyOn.Add(cord);
                                final++;
                            }
                        }
                    }
                }
            }
            WriteLine(final);

            // Clear();
            // foreach((int, int) cord in listOfCordTouched)
            // {
            //     SetCursorPosition(cord.Item1, cord.Item2);
            //     Write("*");
            // }
            // SetCursorPosition(0, 30);
        }
    }
}
