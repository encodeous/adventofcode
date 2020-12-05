using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace aoc2020.Day4
{
    class Day4p2 : ISolver
    {
        public string Solve(string input)
        {
            int cnt = 0;
            var lines = input.Split('\n');
            foreach (var line in lines)
            {
                var tokens = line.Split(" ");
                var dict = new Dictionary<string, string>();
                foreach (var token in tokens)
                {
                    var k = token.Split(':');
                    if (k[0] != "cid")
                    {
                        dict[k[0]] = k[1];
                    }
                }

                if (dict.Count == 7)
                {
                    bool pass = true;
                    foreach (var p in dict)
                    {
                        string k = p.Key, v = p.Value;
                        if (k == "byr")
                        {
                            int y = int.Parse(v);
                            if (y < 1920 || y > 2002)
                            {
                                pass = false;
                                break;
                            }
                        }
                        else if (k == "iyr")
                        {
                            int y = int.Parse(v);
                            if (y < 2010 || y > 2020)
                            {
                                pass = false;
                                break;
                            }
                        }
                        else if (k == "eyr")
                        {
                            int y = int.Parse(v);
                            if (y < 2020 || y > 2030)
                            {
                                pass = false;
                                break;
                            }
                        }
                        else if (k == "hgt")
                        {
                            if (v[^2..] == "cm")
                            {
                                int h = int.Parse(v[..^2]);
                                if (h < 150 || h > 193)
                                {
                                    pass = false;
                                    break;
                                }
                            }
                            else
                            {
                                int h = int.Parse(v[..^2]);
                                if (h < 59 || h > 76)
                                {
                                    pass = false;
                                    break;
                                }
                            }
                        }else if (k == "hcl")
                        {
                            var reg = new Regex("^#([0-9a-f]{6})$");
                            if (!reg.IsMatch(v))
                            {
                                pass = false;
                                break;
                            }
                        }else if (k == "ecl")
                        {
                            if (v != "amb" && v != "blu" && v != "brn" && v != "gry" && v != "grn" && v != "hzl" &&
                                v != "oth")
                            {
                                pass = false;
                                break;
                            }
                        }else if (k == "pid")
                        {
                            var reg = new Regex("^[0-9]{9}$");
                            if (!reg.IsMatch(v))
                            {
                                pass = false;
                                break;
                            }
                        }
                        else
                        {
                            pass = false;
                            break;
                        }
                    }

                    if (pass)
                    {
                        cnt++;
                    }
                }
            }

            return cnt + ""; 
        }
    }
}
