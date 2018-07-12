using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AofC
{
    class Day5
    {
        public void Run()
        {
            string[] numberListString = File.ReadAllLines(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day5input.txt");
            int Day5Solution1 = Part1Solve(numberListString);
            int Day5Solution2 = Part2Solve(numberListString);

            Console.WriteLine("Day 5:");
            Console.WriteLine("     Part 1 = " + Day5Solution1);
            Console.WriteLine("     Part 2 = " + Day5Solution2);

        }


        public int Part1Solve(string[] numberListString)
        {
            var numberList = numberListString.Select(int.Parse).ToArray();

            var index = 0;
            var steps = 0;

            while (index >= 0 && index < numberList.Length)
            {
                var v = numberList[index];
                index += numberList[index];
                numberList[index - v]++;
                steps++;
            }
            return steps;
        }

        public int Part2Solve(string[] numberListString)
        {
            var numberList = numberListString.Select(int.Parse).ToArray();
            var index = 0;
            var steps = 0;

            while (index>=0 && index < numberList.Length)
            {
                var v = numberList[index];
                index += numberList[index];
                if(v >= 3)
                {
                    numberList[index - v]--;
                }
                else
                {
                    numberList[index - v]++;
                }
                steps++;
            }
            return steps;
        }
    }
}
