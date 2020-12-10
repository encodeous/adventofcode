using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aoc2020.Day5
{
    class Day5p1 : ISolver
    {
        public string Solve(string input)
        {
            var ln = input.Split("\r\n");

            var w = (from p in ln
                group p by ((Func<string, (int r, int c)>) (s =>
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
                }))(p)
                into a
                group a by a.Key.r * 8 + a.Key.c
                into b
                orderby b.Key descending
                select b.Key).ToList();

            return w[0] + "";
        }
    }
}
