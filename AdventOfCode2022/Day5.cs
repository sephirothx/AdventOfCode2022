using System;
using System.Linq;

namespace AdventOfCode2022
{
    class Day5
    {
        public static int Part1(string input)
        {
            var values = input.Split(Environment.NewLine);

            var map = new int[1000, 1000];

            foreach (string s in values)
            {
                var line = s.Split(" -> ").Select(c => c.Split(",").Select(int.Parse).ToArray()).ToArray();
                int d;

                if (line[0][0] == line[1][0])
                {
                    d = (line[1][1] - line[0][1]) / Math.Abs(line[1][1] - line[0][1]);
                    for (int i = line[0][1]; i != line[1][1] + d; i += d)
                    {
                        map[i, line[0][0]]++;
                    }
                }
                else if (line[0][1] == line[1][1])
                {
                    d = (line[1][0] - line[0][0]) / Math.Abs(line[1][0] - line[0][0]);
                    for (int i = line[0][0]; i != line[1][0] + d; i += d)
                    {
                        map[line[0][1], i]++;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (map[i, j] >= 2) sum++;
                }
            }

            return sum;
        }

        public static int Part2(string input)
        {
            var values = input.Split(Environment.NewLine);

            var map = new int[1000, 1000];

            foreach (string s in values)
            {
                var line = s.Split(" -> ").Select(c => c.Split(",").Select(int.Parse).ToArray()).ToArray();

                int dx = line[1][0] == line[0][0] ? 0 : (line[1][0] - line[0][0]) / Math.Abs(line[1][0] - line[0][0]);
                int dy = line[1][1] == line[0][1] ? 0 : (line[1][1] - line[0][1]) / Math.Abs(line[1][1] - line[0][1]);

                int i = line[0][0];
                int j = line[0][1];

                while (i != line[1][0] + dx || j != line[1][1] + dy)
                {
                    map[i, j]++;
                    i += dx;
                    j += dy;
                }
            }

            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (map[i, j] >= 2) sum++;
                }
            }

            return sum;
        }
    }
}