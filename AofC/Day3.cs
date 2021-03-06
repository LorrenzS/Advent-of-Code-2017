﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AofC
{
    class Day3
    {
        public void Run()
        {
            const int target = 312051;
            int Day5Solution1 = Part1Solve(target);
            Console.WriteLine("Day 3:");
            Console.WriteLine("     Part 1: " + Day5Solution1);
        }

        public int Part1Solve(int target)
        {
            FindTargetXY(target, out int x, out int y);
            int distanceToCenter = (Math.Abs(x) + Math.Abs(y));
            return distanceToCenter;
        }

        private void FindTargetXY(int target, out int x, out int y)
        {
            int i = 1;
            x = 0;
            y = 0;
            int maxX = 0;
            int maxY = 0;
            int minX = 0;
            int minY = 0;

            while (true)
            {
                // Right
                while (x <= maxX)
                {
                    x++;
                    if (++i == target) return;
                }
                maxX = x;

                // Up
                while (y <= maxY)
                {
                    y++;
                    if (++i == target) return;
                }
                maxY = y;

                // Left
                while (x >= minX)
                {
                    x--;
                    if (++i == target) return;
                }
                minX = x;

                // Down
                while (y >= minY)
                {
                    y--;
                    if (++i == target) return;
                }
                minY = y;
            }
        }
    }
}
