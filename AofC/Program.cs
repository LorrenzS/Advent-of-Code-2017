﻿using System;
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
            day1.Run();

            Day2 day2 = new Day2();
            day2.Run();

            Day3 day3 = new Day3();
            day3.Run();

            Day4 day4 = new Day4();
            day4.Run();

            Day5 day5 = new Day5();
            day5.Run();

            Day6 day6 = new Day6();
            day6.Run();

            Day7 day7 = new Day7();
            day7.Run();

            Day8 day8 = new Day8();
            day8.Run();

            Console.Write("Press any key to close...");
            Console.ReadKey(true);

          
        }
    }
}