using System;
using System.Collections.Generic;
using System.Text;

namespace aoc2020.Day4
{
    class Day4p1 : ISolver
    {
        public string Solve(string input)
        {
            int cnt = 0;
            var lines = input.Split('\n');
            foreach (var line in lines)
            {
                var tokens = line.Split(" ");
                HashSet<string> requiredItems = new HashSet<string>();
                foreach (var token in tokens)
                {
                    string a = token.Split(':')[0];
                    if (a != "cid")
                    {
                        requiredItems.Add(a);
                    }
                }

                if (requiredItems.Count == 7) cnt++;
            }

            return cnt + ""; 
        }
    }
}
