using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022
{
    class Day3
    {
        public static int Part1(string input)
        {
            var values = input.Split(Environment.NewLine);

            int gamma   = 0;
            int epsilon = 0;

            for (int i = 0; i < values[0].Length; i++)
            {
                gamma   <<= 1;
                epsilon <<= 1;

                int ones  = values.Count(s => s[i] == '1');
                int zeros = values.Count(s => s[i] == '0');

                gamma   += ones > zeros ? 1 : 0;
                epsilon += ones > zeros ? 0 : 1;
            }

            return gamma * epsilon;
        }

        public static int Part2(string input)
        {
            var values = input.Split(Environment.NewLine).ToArray();

            return Oxygen(values) * Co2(values);
        }

        private static int Oxygen(string[] values)
        {
            var tmp = new List<string>(values);

            for (int i = 0; i < values[0].Length && tmp.Count != 1; i++)
            {
                int ones  = tmp.Count(s => s[i] == '1');
                int zeros = tmp.Count(s => s[i] == '0');

                tmp.RemoveAll(s => s[i] == (ones >= zeros ? '0' : '1'));
            }

            return Convert.ToInt32(tmp.First(), 2);
        }

        private static int Co2(string[] values)
        {
            var tmp = new List<string>(values);

            for (int i = 0; i < values[0].Length && tmp.Count != 1; i++)
            {
                int ones  = tmp.Count(s => s[i] == '1');
                int zeros = tmp.Count(s => s[i] == '0');

                tmp.RemoveAll(s => s[i] == (ones >= zeros ? '1' : '0'));
            }

            return Convert.ToInt32(tmp.First(), 2);
        }
    }
}