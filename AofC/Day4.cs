using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AofC
{
    class Day4
    {
        public void Run()
        {
            int Day4Solution1 = Part1Solve();
            int Day4Solution2 = Part2Solve();
            Console.WriteLine("Day 4:");
            Console.WriteLine("     Part 1 = " + Day4Solution1);
            Console.WriteLine("     Part 2 = " + Day4Solution2);
        }


        string[] passPhrases = File.ReadAllLines(@"C:\Users\lsantiago\source\repos\AofC\AofC\InputFiles\day4input.txt");

        public int Part1Solve()
        {
            int validPassPhrasesPart1 = 0;
            foreach (string passphrase in passPhrases)
            {
                if (VerifyUniquePassPhrase(passphrase) == true)
                {
                    validPassPhrasesPart1++;
                }
            }
            return validPassPhrasesPart1;
        }

        public bool VerifyUniquePassPhrase(string passPhrase)
        {
            string[] words = passPhrase.Split(new char[0]);
            return words.Distinct().Count() == words.Length;
        }

        public int Part2Solve()
        {
            int validPassPhrasesPart2 = 0;
            foreach (string passphrase in passPhrases)
            {
                if (VerifyNotAnagrams(passphrase) == true)
                {
                    validPassPhrasesPart2++;
                }
            }
            return validPassPhrasesPart2;

        }

        public bool VerifyNotAnagrams(string passPhrase)
        {
            string[] words = passPhrase.Split(new char[0]);
            for (int a = 0; a < words.Length; a++)
            {
                words[a] = String.Concat(words[a].OrderBy(x => x));
            }
            return words.Distinct().Count() == words.Length;

        }
    }



}
