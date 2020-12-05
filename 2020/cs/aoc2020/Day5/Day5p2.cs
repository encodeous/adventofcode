using System;
using System.Collections.Generic;
using System.Text;

namespace aoc2020.Day5
{
    class Day5p2 : ISolver
    {
        (int r, int c) ParseTuple(string s)
        {
            int lr = 0, rr = 127;
            int lc = 0, rc = 7;
            foreach (var c in s)
            {
                if (c == 'F')
                {
                    rr = (lr + rr) / 2;
                }
                else if (c == 'B')
                {
                    lr = (lr + rr + 1) / 2;
                }
                else if (c == 'L')
                {
                    rc = (lc + rc) / 2;
                }
                else if (c == 'R')
                {
                    lc = (lc + rc + 1) / 2;
                }
            }

            return (lr, lc);
        }
        public string Solve(string input)
        {
            var ln = input.Split("\r\n");
            var arr = new bool[971];
            foreach (var s in ln)
            {
                var k = ParseTuple(s);
                arr[k.r * 8 + k.c] = true;
            }

            for (int i = 1; i < 970; i++)
            {
                if (!arr[i] && arr[i - 1] && arr[i + 1])
                {
                    return i + "";
                }
            }

            return "";
        }
    }
}