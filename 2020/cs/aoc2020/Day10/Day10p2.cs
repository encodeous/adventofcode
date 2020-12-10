using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day10
{
    class Day10p2 : ISolver
    {
        private bool[] possible = new bool[200];
        private long[] deepee = new long[200];

        public string Solve(string input)
        {
            deepee[0] = 1;
            possible[0] = true;
            var spl = input.Split("\r\n");
            
            int mv = 0;
            foreach (var k in spl)
            {
                possible[int.Parse(k)] = true;
                mv = Math.Max(mv, int.Parse(k));
            }

            for (int i = 1; i <= mv; i++)
            {
                if(!possible[i]) continue;
                for (int j = 1; j <= 3; j++)
                {
                    if (i - j >= 0 && possible[i - j])
                    {
                        deepee[i] += deepee[i - j];
                    }
                }
            }
            return deepee[mv] + "";
        }
    }
}