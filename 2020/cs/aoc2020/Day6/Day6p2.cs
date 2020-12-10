using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aoc2020.Day6
{
    class Day6p2 : ISolver
    {
        public string Solve(string input)
        {
            var grps = input.Split("\r\n\r\n");
            int sum = 0;
            foreach (var k in grps)
            {
                int[] freq = new int[26];
                var j = k.Split("\r\n");
                foreach (var s in j)
                {
                    foreach (var c in s)
                    {
                        freq[c - 'a']++;
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    if (freq[i] == j.Length) sum++;
                }
            }
            return sum + "";
        }
    }
}