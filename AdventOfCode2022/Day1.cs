using System;
using System.Linq;

namespace AdventOfCode2022
{
    class Day1
    {
        public static int Part1(string input)
        {
            var values = input.Split(Environment.NewLine).Select(int.Parse).ToArray();

            return values.Zip(values[1..]).Count(pair => pair.Second > pair.First);
        }

        public static int Part2(string input)
        {
            var values = input.Split(Environment.NewLine).Select(int.Parse).ToArray();
            int sum    = values[..3].Sum();
            int i      = 1;

            int result = 0;

            while (i + 3 <= values.Length)
            {
                Console.WriteLine(sum);

                int nextSum = values[i..(i + 3)].Sum();
                result += nextSum > sum ? 1 : 0;

                sum = nextSum;
                i++;
            }

            return result;
        }
    }
}
