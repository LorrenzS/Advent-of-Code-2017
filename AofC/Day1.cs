using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AofC
{
    class Day1
    {
        string input = System.IO.File.ReadAllText(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day1input.txt");

        public void Run()
        {
            int Day1Solution1 = Part1Solve();
            int Day1Solution2 = Part2Solve();
            Console.WriteLine("Day 1:");
            Console.WriteLine("     Part 1 = " + Day1Solution1);
            Console.WriteLine("     Part 2 = " + Day1Solution2);

        }

        public int Part1Solve()
        {
            var inputArray = input.ToCharArray();
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[(i + 1) % inputArray.Length])
                {
                    sum += Int32.Parse(inputArray[i].ToString());
                }
            }
            return sum;
        }
        public int Part2Solve()
        {
            var inputArray = input.ToCharArray();
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[(i + (inputArray.Length / 2)) % input.Length])
                {
                    sum += Int32.Parse(inputArray[i].ToString());
                }
            }
            return sum;
        }

    }
}
