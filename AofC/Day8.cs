using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AofC
{
    class Day8
    {
        public void Run()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day8input.txt");
            Dictionary<string, int> registers = new Dictionary<string, int>();
            int maxValue = 0;
            int largestMaxValue = 0;
            foreach (string strs in lines)
            {
                string[] instructions = strs.Split(' ');
                if (CheckToPerform(registers, instructions))
                {
                    maxValue = PerformOperationFindMax(registers, instructions);
                    if(maxValue > largestMaxValue)
                    {
                        largestMaxValue = maxValue;
                    }
                }
            }

            Console.WriteLine("Day 8:");
            Console.WriteLine("     Part 1 = " + maxValue);
            Console.WriteLine("     Part 2 = " + largestMaxValue);
        }        

        public int GetRegisterValue(Dictionary<string,int> registers, string name)
        {
            if(!registers.ContainsKey(name))
            {
                registers[name] = 0;
            }
            return registers[name];
        }

        public bool CheckToPerform(Dictionary<string, int> registers, string[] instructions)
        {
            int registerToCompareValue = GetRegisterValue(registers, instructions[4]);
            int valueOfComparison = Int32.Parse(instructions[6]);
            if (instructions[5] == ">")
            {
                return registerToCompareValue > valueOfComparison;
            }
            else if (instructions[5] == "<")
            {
                return registerToCompareValue < valueOfComparison;
            }
            else if (instructions[5] == "==")
            {
                return registerToCompareValue == valueOfComparison;
            }
            else if (instructions[5] == "!=")
            {
                return registerToCompareValue != valueOfComparison;
            }
            else if (instructions[5] == ">=")
            {
                return registerToCompareValue >= valueOfComparison;
            }
            else if (instructions[5] == "<=")
            {
                return registerToCompareValue <= valueOfComparison;
            }
            else
            {
                return false;
            }
        }

        public int PerformOperationFindMax (Dictionary<string, int> registers, string[] instructions)
        {
            int value = Int32.Parse(instructions[2]);
            int currentValue = GetRegisterValue(registers, instructions[0]);

            if (instructions[1] == "inc")
            {
                registers[instructions[0]] = currentValue + value;
            }
            else if (instructions[1] == "dec")
            {
                registers[instructions[0]] = currentValue - value;
            }
            else
            {
                throw new InvalidOperationException();
            }
            return registers.Values.Max();
        }

    }
}
