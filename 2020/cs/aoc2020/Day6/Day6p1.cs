using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aoc2020.Day6
{
    class Day6p1 : ISolver
    {
        public string Solve(string input)
        {
            var grps = input.Split("\r\n\r\n");
            int sum = 0;
            foreach (var k in grps)
            {
                var p = k.Replace("\r\n", "");
                sum += p.ToCharArray().Distinct().Count();
            }
            return sum + "";
        }
    }
}
