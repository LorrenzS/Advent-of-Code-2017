using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AofC
{
    class Day2
    {
        public void Run()
        {
            int Day2Solution1 = Part1Solve();
            int Day2Solution2 = Part2Solve();
            Console.WriteLine("Day 2:");
            Console.WriteLine("     Part 1 = " + Day2Solution1);
            Console.WriteLine("     Part 2 = " + Day2Solution2);
        }


        public int Part1Solve()
        {
            string [] readText = File.ReadAllLines(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day2input.txt");
            int totalSum = 0;
            int sum = 0;
            int lowest = int.MaxValue;
            int highest = int.MinValue;

            foreach (string stringLine in readText)
            {
                int[] intArray = Array.ConvertAll(stringLine.Split('\t'), int.Parse);
                for (int a = 0; a < intArray.Length; a++)
                {
                    if(intArray[a] < lowest)
                    {
                        lowest = intArray[a];
                    }
                    if(intArray[a] > highest)
                    {
                        highest = intArray[a];
                    }
                }
                sum = highest - lowest;
                totalSum = totalSum + sum;
                lowest = int.MaxValue;
                highest = int.MinValue;
                sum = 0;
            }
            return totalSum; 
        }

        public int Part2Solve()
        {
            string[] readText = File.ReadAllLines(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day2input.txt");
            int sum = 0;
            foreach (string stringLine in readText)
            {
                int[] intArray = Array.ConvertAll(stringLine.Split('\t'), int.Parse);
                for(int a = 0; a < intArray.Length; a++)
                {
                    for(int b = a + 1; b < intArray.Length; b++)
                    {
                        if (intArray[a] % intArray[b] == 0)
                        {
                            sum = sum + (intArray[a] / intArray[b]);
                        }
                        else if (intArray[b] % intArray[a] == 0)
                        {
                            sum = sum + (intArray[b] / intArray[a]);
                        }
                    }
                }
            }
            return sum;
        }
    }
}
