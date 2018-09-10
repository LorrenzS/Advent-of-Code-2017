using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AofC
{
    class Day7
    {
        public void Run()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day7input.txt");
            string Day7Solution1 = Part1Solve(lines);
            var Day7Solution2 = Part2Solve(lines);

            Console.WriteLine("Day 7:");
            Console.WriteLine("     Part 1 = " + Day7Solution1);
            Console.WriteLine("     Part 2 = " + Day7Solution2);
        }

        public DiscNode CreateNewOrGetExistingDisc(List<DiscNode> towerOfDiscs, string name)
        {
            DiscNode disc = towerOfDiscs.SingleOrDefault(d => d.Name == name);
            if (disc == null)
            {
                disc = new DiscNode { Name = name, Children = new List<DiscNode>() };
                towerOfDiscs.Add(disc);
            }
            return disc;

        }

        public string Part1Solve (string [] lines)
        {
            List<DiscNode> towerOfDiscs = new List<DiscNode>();
            foreach(string line in lines)
            {
                string name = GetDiscName(line);
                DiscNode disc = CreateNewOrGetExistingDisc(towerOfDiscs, name);
                CreateBalanceOnDisc(line, disc, towerOfDiscs);
            }
            DiscNode root = towerOfDiscs.Where(ti => ti.Parent == null).Single();
            return root.Name;
        }

        public int Part2Solve (string[] lines)
        {
            List<DiscNode> towerOfDiscs = new List<DiscNode>();
            foreach (string line in lines)
            {
                string name = GetDiscName(line);
                DiscNode disc = CreateNewOrGetExistingDisc(towerOfDiscs, name);
                CreateBalanceOnDisc(line, disc, towerOfDiscs);
            }
            DiscNode root = towerOfDiscs.Where(ti => ti.Parent == null).Single();
            return root.Weight;
        }

        public string[] GetChildrenNames (string line)
        {
            int start = line.IndexOf('>');
            if (start == -1)
            {
                return null;
            }
            string childrenDiscNames = line.Substring(start + 2);
            childrenDiscNames = childrenDiscNames.Replace(" ", "");
            string[] childNames = childrenDiscNames.Split(',');
            return childNames;
        }

        public void CreateBalanceOnDisc (string line, DiscNode disc, List<DiscNode> towerOfDiscs)
        {
            string[] childNames = GetChildrenNames(line);
            if (childNames == null)
            {
                return;
            }
            foreach (string childName in childNames)
            {
                DiscNode child = CreateNewOrGetExistingDisc(towerOfDiscs, childName);
                disc.Children.Add(child);
                child.Parent = disc;
            }
        }

        public string GetDiscName(string line)
        {
            string name = line.Split()[0];
            return name;
        }

        public class DiscNode {
            public string Name { get; set; }
            public int Weight { get; set; }
            public List<DiscNode> Children { get; set; }
            public DiscNode Parent { get; set; }
            public bool CheckBalance() {
                if (Children.Count() == 0)
                {
                    return true;
                }
                else
                {
                    int[] weights = Children.Select(c => c.Weight).ToArray();
                    return weights.Min() != weights.Max();
                }
            }
        }
    }
}
