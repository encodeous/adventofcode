using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day7
{
    class Day7p1 : ISolver
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int cnt = 0;
        public int getLine(string s)
        {
            if (!dict.ContainsKey(s))
            { 
                dict[s] = cnt++;
            }

            return dict[s];
        }
        List<int>[] adj = new List<int>[595];
        private bool[] dp = new bool[595];

        bool solve(int x)
        {
            if (dp[x]) return true;
            foreach (var k in adj[x])
            {
                if (solve(k)) return dp[x] = true;
            }

            return dp[x];
        }
        public string Solve(string input)
        {
            
            input = input.Replace("\r\n", "");
            var colourLine = input.Split(".");
            
            foreach (var line in colourLine)
            {
                if(line == "") continue;
                var spl = line.Split(" bags contain ");
                int x = getLine(spl[0]);
                adj[x] = new List<int>();
                Regex reg = new Regex("\\d+ (\\w+ \\w+) bag");
                var mtc = reg.Matches(spl[1]);
                foreach (Match m in mtc)
                {
                    string w = m.Groups[1].Value;
                    adj[x].Add(getLine(w));
                }
            }

            dp[getLine("shiny gold")] = true;
            int cnt = 0;
            for (int i = 0; i < 594; i++)
            {
                if (solve(i))
                {
                    cnt++;
                }
            }
            return (cnt-1)+"";
        }
    }
}
