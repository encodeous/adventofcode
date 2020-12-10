using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day8
{
    class Day8p1 : ISolver
    {
        bool[] visited = new bool[100000];
        public string Solve(string input)
        {
            int acc = 0;
            var instr = input.Split("\r\n");
            int cur = 0;
            while (!visited[cur])
            {
                visited[cur] = true;
                var ln = instr[cur].Split(" ");
                string op = ln[0];
                int val = int.Parse(ln[1]);
                if (op == "nop") cur++;
                if (op == "acc")
                {
                    acc += val;
                    cur++;
                }

                if (op == "jmp")
                {
                    cur += val;
                }
            }

            return acc + "";
        }
    }
}
