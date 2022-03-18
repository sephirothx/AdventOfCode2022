using System;
using System.Linq;

namespace AdventOfCode2022
{
    class Day7
    {
        public static int Part1(string input)
        {
            var values = input.Split(',').Select(int.Parse).ToArray();

            int min = values.Min();
            int max = values.Max();

            int solution = int.MaxValue;

            for (int i = min; i <= max; i++)
            {
                int fuel = values.Sum(c => Math.Abs(c - i));
                solution = Math.Min(solution, fuel);
            }

            return solution;
        }

        public static int Part2(string input)
        {
            var values = input.Split(',').Select(int.Parse).ToArray();

            int min = values.Min();
            int max = values.Max();

            int solution = int.MaxValue;

            for (int i = min; i <= max; i++)
            {
                int fuel = values.Sum(c =>
                {
                    int dist = Math.Abs(c - i);
                    return dist * (dist + 1) / 2;
                });
                solution = Math.Min(solution, fuel);
            }

            return solution;
        }
    }
}
