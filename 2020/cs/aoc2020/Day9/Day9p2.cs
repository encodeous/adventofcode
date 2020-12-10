using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day9
{
    class Day9p2 : ISolver
    {
        public string Solve(string input)
        {
            const int num = 57195069;
            List<long> nums = new List<long>();
            List<long> num2 = new List<long>();
            num2.Add(0);
            foreach (var s in input.Split("\r\n"))
            {
                var x = long.Parse(s);
                nums.Add(x);
                num2.Add(x + num2.Last());
            }
            long minv = long.MaxValue;
            long maxv = 0;
            for (int l = 1; l < num2.Count; l++)
            {
                for (int r = l + 1; r < num2.Count; r++)
                {
                    if (num2[r] - num2[l - 1] == num)
                    {
                        for (int i = l; i <= r; i++)
                        {
                            minv = Math.Min(minv, nums[i - 1]);
                            maxv = Math.Max(maxv, nums[i - 1]);
                        }
                    }
                }
            }

            return (maxv + minv) + "";
        }
    }
}