using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace AofC
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 day1 = new Day1();
            int Day1Solution1 = day1.Part1Solve();
            int Day1Solution2 = day1.Part2Solve();
            Console.WriteLine("Day 1:");
            Console.WriteLine("     Part 1 = " + Day1Solution1);
            Console.WriteLine("     Part 2 = " + Day1Solution2);

            Day2 day2 = new Day2();
            int Day2Solution1 = day2.Part1Solve();
            int Day2Solution2 = day2.Part2Solve();
            Console.WriteLine("Day 2:");
            Console.WriteLine("     Part 1 = " + Day2Solution1);
            Console.WriteLine("     Part 2 = " + Day2Solution2);

            Day3 day3 = new Day3();
            day3.Run();




            Console.Write("Press any key to close...");
            Console.ReadKey(true);

          
        }
    }
}