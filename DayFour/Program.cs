using System;
using System.IO;
using System.Collections.Generic;

namespace DayFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int hit = 0;
            Decimal lowest = decimal.MaxValue;
            Decimal percent = 0;
            var listOfAllNumbers = new List<int> { };
            var allLines = File.ReadAllLines("Input.txt");

            foreach (string line in allLines)
            {
                var listOfFiveNumHor = new List<int> { };
                var fiveNumbersHor = line.Split("|");

                foreach (string singleNumHor in fiveNumbersHor)
                {
                    if (singleNumHor == "") { }
                    else
                    {
                        var singleNumber = int.Parse(singleNumHor);
                        listOfFiveNumHor.Add(singleNumber);
                        listOfAllNumbers.Add(singleNumber);

                    }
                }

                var fileContent = File.ReadAllText("numbers.txt");
                var stringOfNumbersCalled = fileContent.Split(",");
                var listOfIntNumCalled = new List<int> { };
                Decimal z = 1;

                foreach (string stringNumCalled in stringOfNumbersCalled)
                {
                    var intNumberCalled = int.Parse(stringNumCalled);
                    listOfIntNumCalled.Add(intNumberCalled);
                }
                foreach (int intNumCalled in listOfIntNumCalled)
                {
                    if (listOfFiveNumHor.Contains(intNumCalled))
                    {
                        hit++;
                        percent += z;
                    }
                    z = z * 2;
                }


                if (hit == 5)
                {


                    Console.WriteLine(line);
                    lowest = percent;

                }



                percent = 0;
                hit = 0;
            }
            CalculateColloms(listOfAllNumbers);

        }
        static void CalculateColloms(List<int> colloms)
        {
            decimal percent = 0;
            var lowest = decimal.MaxValue;
            int hit = 0;

            Console.WriteLine("Now Colloms");
            int i = 0;
            var collomArray = colloms.ToArray();

            for (int k = 0; k < (collomArray.Length / 25); k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var list = new List<int> { };
                    list.Add(collomArray[i]);
                    list.Add(collomArray[i + 5]);
                    list.Add(collomArray[i + 10]);
                    list.Add(collomArray[i + 15]);
                    list.Add(collomArray[i + 20]);

                    if ((i + 1) % 5 == 0)
                    {
                        i += 21;
                    }
                    else
                    {
                        i++;
                    }


                    var fileContent = File.ReadAllText("numbers.txt");
                    var stringOfNumbersCalled = fileContent.Split(",");
                    var listOfIntNumCalled = new List<int> { };
                    Decimal z = 1;

                    foreach (string stringNumCalled in stringOfNumbersCalled)
                    {
                        var intNumberCalled = int.Parse(stringNumCalled);
                        listOfIntNumCalled.Add(intNumberCalled);
                    }
                    foreach (int intNumCalled in listOfIntNumCalled)
                    {
                        if (list.Contains(intNumCalled))
                        {
                            hit++;
                            percent += z;
                        }
                        z = z * 2;
                    }


                    if (hit == 5)
                    {

                        foreach (int l in list)
                        {
                            Console.WriteLine(l);
                        }
                        Console.WriteLine();

                        lowest = percent;

                    }

                    
                    percent = 0;
                    hit = 0;

                }
            }
        }
    }
}

// 4512485737693
// 620507869250
// 43466850250
// 9013952249176
// 975849665176
// 1691594999176
// 9821491777176
// 6449599646176
// 154977935176
// 4964889726176
// 1636496776176
// 1249988134176
// 2721498730176
// 6080355949176
// 6660219249176
//75,0,89,56,58,40,92,47,8,6,54,96,12,66,83



//66|57|78|94|3

// 83|36|25|31|99
// 86|29|47|77|38
// 13|51|20|59|27
// 74|50||9|11|44
// 52|95|81||2|70

// 41|66|27|50|56
// 76|60|80|85|23
// |3|21|37|74|95
// |9|92|43||5|98
// 79|49|88|24|70
