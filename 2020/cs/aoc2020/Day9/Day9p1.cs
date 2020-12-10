using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day9
{
    class Day9p1 : ISolver
    {
        public string Solve(string input)
        {
            List<long> nums = new List<long>();
            foreach (var s in input.Split("\r\n"))
            {
                nums.Add(long.Parse(s));
            }

            for (int i = 25; i < nums.Count; i++)
            {
                bool found = false;
                for (int l = i - 25; l < i; l++)
                {
                    for (int r = l + 1; r < i; r++)
                    {
                        if (nums[l] + nums[r] == nums[i])
                        {
                            found = true;
                            goto STOP;
                        }
                    }
                }
                STOP:
                if (!found)
                {
                    return nums[i] + "";
                }
            }

            return "";
        }
    }
}
