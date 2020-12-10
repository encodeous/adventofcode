using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day7
{
    class Day7p2 : ISolver
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
        List<(int x, long cnt)>[] adj = new List<(int, long)>[595];
        private long[] dp = new long[595];

        long solve(int x)
        {
            if (dp[x] != 0) return dp[x];
            long total = 1;
            foreach (var k in adj[x])
            {
                total += solve(k.x) * k.cnt;
            }

            return dp[x] = total;
        }
        public string Solve(string input)
        {

            input = input.Replace("\r\n", "");
            var colourLine = input.Split(".");

            foreach (var line in colourLine)
            {
                if (line == "") continue;
                var spl = line.Split(" bags contain ");
                int x = getLine(spl[0]);
                adj[x] = new List<(int,long)>();
                Regex reg = new Regex("(\\d+) (\\w+ \\w+) bag");
                var mtc = reg.Matches(spl[1]);
                foreach (Match m in mtc)
                {
                    string w = m.Groups[2].Value;
                    adj[x].Add((getLine(w), int.Parse(m.Groups[1].Value)));
                }
            }

            return solve(getLine("shiny gold")) - 1 + "";
        }
    }
}