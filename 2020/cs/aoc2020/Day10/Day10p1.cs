using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day10
{
    class Day10p1 : ISolver
    {
        public string Solve(string input)
        {
            var spl = input.Split("\r\n");
            var li = new List<int>();
            foreach (var k in spl)
            {
                li.Add(int.Parse(k));
            }

            li.Sort();

            int onecnt = 0, threecnt = 1;
            int cur = 0;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i] - cur == 1)
                {
                    onecnt++;
                }
                if (li[i] - cur == 3)
                {
                    threecnt++;
                }

                cur = li[i];
            }

            return (onecnt * threecnt) + "";
        }
    }
}
