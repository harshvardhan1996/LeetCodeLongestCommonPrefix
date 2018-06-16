using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "leets", "leetcode", "leet", "leeds" };
            Console.WriteLine("Longest Common Prefix is : " + LongestCommonPrefix(strs));
            Console.ReadKey();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string longest = "";
            int minimumLength = MinimumLengthString(strs);


            for (int i = 0; i < minimumLength; i++)
            {
                char current = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != current)
                        return longest;
                }
                longest += current;

            }
            return longest;
        }
        public static int MinimumLengthString(string[] strs)
        {
            int min = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < min)
                    min = strs[i].Length;
            }

            return min;
        }
    }
}
