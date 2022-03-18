using System.Linq;

namespace AdventOfCode2022
{
    class Day6
    {
        public static int Part1(string input)
        {
            var values = input.Split(",").Select(int.Parse).ToList();

            for (int i = 0; i < 80; i++)
            {
                values = values.Select(j => j - 1).ToList();
                int newj = values.Count(j => j == -1);
                values.AddRange(Enumerable.Repeat(8, newj));
                values = values.Select(j => j == -1 ? 6 : j).ToList();
            }

            return values.Count;
        }

        public static int Part2(string input)
        {
            return 0;
        }
    }
}
