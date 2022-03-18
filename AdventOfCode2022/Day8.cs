using System;
using System.Linq;

namespace AdventOfCode2022
{
    class Day8
    {
        public static int Part1(string input)
        {
            int solution = 0;

            var valid = new[] { 2, 3, 4, 7 };

            foreach (var line in input.Split(Environment.NewLine))
            {
                var outputs = line.Split(" | ").ToArray()[1].Split(' ');
                solution += outputs.Count(s => valid.Contains(s.Length));
            }

            return solution;
        }

        public static int Part2(string input)
        {
            return 0;
        }
    }
}
