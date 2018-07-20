using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AofC
{
    class Day6
    {
        public void Run()
        {
            string input = System.IO.File.ReadAllText(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day6input.txt");
            string[] splitInput = input.Split('\t').ToArray();
            int[] banks = splitInput.Select(int.Parse).ToArray();
            int Day6Solution1 = Part1Solve(banks);
            int Day6Solution2 = Part2Solve(banks);
            Console.WriteLine("Day 6:");
            Console.WriteLine("     Part 1 = " + Day6Solution1);
            Console.WriteLine("     Part 2 = " + Day6Solution2);
        }

        public int Part1Solve(int[] input)
        {
            int countCycles = 0;
            HashSet<string> configurations = new HashSet<string>();
            string firstSeen = ConvertIntArray(input);
            configurations.Add(firstSeen);
            while (true)
            {
                RedistributeBlocks(input);
                countCycles++;
                string state = ConvertIntArray(input);
                if (configurations.Contains(state) == true)
                {
                    return countCycles;
                }
                configurations.Add(state);
            }
        }

        public int Part2Solve(int[] input)
        {
            int countCycles = 0;
            int count2ndCycle = 0;
            string storeState = "";
            HashSet<string> configurations = new HashSet<string>();
            string firstSeen = ConvertIntArray(input);
            configurations.Add(firstSeen);
            while (true)
            {
                RedistributeBlocks(input);
                countCycles++;
                string state = ConvertIntArray(input);
                if (configurations.Contains(state) == true)
                {
                    storeState = state;
                    while (true)
                    {
                        RedistributeBlocks(input);
                        count2ndCycle++;
                        string secondState = ConvertIntArray(input);
                        if(secondState == state)
                        {
                            return count2ndCycle;
                        }
                    }
                }
                configurations.Add(state);
            }
        }

        public int FindLargestBank(int[] banks)
        {
            int indexOfBlock = 0;
            for(int block = 0; block < banks.Length; block++)
            {
                if(banks[block] > banks[indexOfBlock])
                {
                    indexOfBlock = block;
                }
            }
            return indexOfBlock;
        }

        public string ConvertIntArray(int[] bank)
        {
            return String.Join(" ", Array.ConvertAll(bank, s => s.ToString()));
        }

        public void RedistributeBlocks(int[] banks)
        {
            int indexOfLargest = FindLargestBank(banks);
            int largest = banks[indexOfLargest];
            banks[indexOfLargest] = 0;

            int nextBank = (indexOfLargest + 1) % banks.Length;
            for(int c =  0; c < largest; c++)
            {
                banks[nextBank]++;
                nextBank = (nextBank + 1) % banks.Length;
            }
        }
    }
}
