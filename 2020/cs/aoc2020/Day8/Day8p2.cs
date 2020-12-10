using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day8
{
    class Day8p2 : ISolver
    {
        bool[] visited = new bool[100000];

        int IsLoop(string[] input)
        {
            Array.Fill(visited, false);
            int acc = 0;
            int cur = 0;
            while (!visited[cur] && cur < 626)
            {
                visited[cur] = true;
                var ln = input[cur].Split(" ");
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

            if (cur < 626)
            {
                return -1;
            }
            else
            {
                return acc;
            }
        }
        public string Solve(string input)
        {
            var spl = input.Split("\r\n");
            for (int i = 0; i < 626; i++)
            {
                var ln = spl[i].Split(" ");
                string op = ln[0];
                int val = int.Parse(ln[1]);
                string original = spl[i];
                if (op == "nop")
                {
                    spl[i] = "jmp " + val;
                }else if (op == "jmp")
                {
                    spl[i] = "nop " + val;
                }

                var k = IsLoop(spl);
                if (k != -1) return k + "";
                spl[i] = original;
            }

            return "";
        }
    }
}