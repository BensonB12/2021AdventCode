using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace DaySix
{
    class ProgramPt2
    {
        public static void main(string[] args)
        {
            var allLines = File.ReadAllLines("test.txt");
            var listOfFish = new List<int>();
            int iold50 = 0, iold51 = 0, iold52 = 0, iold53 = 0, iold54 = 0, iold55 = 0, iold80 = 0, iold81 = 0, iold82 = 0, iold83 = 0, iold84 = 0, iold85 = 0, iold86 = 0, iold87 = 0, iold88 = 0;
            Decimal total = 0;

            foreach (string line in allLines)
            {
                var parts = line.Split(",");

                foreach (string part in parts)
                {
                    listOfFish.Add(int.Parse(part));
                    total++;
                }
            }
            foreach (int fish in listOfFish)
            {
                if (fish == 1)
                {
                    iold55++;
                }
                if (fish == 2)
                {
                    iold54++;
                }
                if (fish == 3)
                {
                    iold53++;
                }
                if (fish == 4)
                {
                    iold52++;
                }
                if (fish == 5)
                {
                    iold51++;
                }
            }

            for(int i = 0; i < int.Parse(args[0]); i++)
            {
                if((i - 5) % 6 == 0)
                {
                    total += iold55;
                    iold55++;
                    iold83++;
                    iold85--;
                    iold50++;
                }
                if((i - 4)% 6 == 0)
                {
                    total += iold54;
                    iold54++;
                    iold82++;
                    iold84--;
                    iold55++;
                }
                if((i - 3)% 6 == 0)
                {
                    total += iold53;
                    iold53++;
                    iold81++;
                    iold83--;
                    iold54++;
                }
                if((i - 2)% 6 == 0)
                {
                    total += iold52;
                    iold52++;
                    iold80++;
                    iold82--;
                    iold53++;
                }
                if((i - 1)% 6 == 0)
                {
                    total += iold51;
                    iold51++;
                    iold80++;
                    iold81--;
                    iold52++;
                }
                if((i)% 6 == 0)
                {
                    total += iold50;
                    iold50++;
                    iold88++;
                    iold80--;
                    iold51++;
                }
                if((i - 8) % 2 == 0)
                {
                    iold51++;
                    iold88--;
                }
                if((i - 7) % 2 == 0)
                {
                    iold50++;
                    iold87--;
                }
                if((i - 6) % 2 == 0)
                {
                    iold55++;
                    iold86--;
                }
            }
            WriteLine(total);
        }
    }
}