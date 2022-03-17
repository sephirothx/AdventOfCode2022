using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    class Program
    {
        private static void Main()
        {
            string input = File.ReadAllText("inputs/input.txt");

            Console.WriteLine(Day2.Part1(input));
            Console.WriteLine(Day2.Part2(input));
        }
    }

    class Day2
    {
        public static int Part1(string input)
        {
            var values = input.Split(Environment.NewLine).Select(l => l.Split(' ')).ToArray();

            int d = 0;
            int p = 0;

            foreach (string[] s in values)
            {
                switch (s[0])
                {
                case "forward":
                    p += int.Parse(s[1]);
                    break;

                case "down":
                    d += int.Parse(s[1]);
                    break;

                case "up":
                    d -= int.Parse(s[1]);
                    break;
                }
            }

            return d * p;
        }

        public static int Part2(string input)
        {
            var values = input.Split(Environment.NewLine).Select(l => l.Split(' ')).ToArray();

            int d = 0;
            int p = 0;
            int a = 0;

            foreach (string[] s in values)
            {
                int x = int.Parse(s[1]);
                switch (s[0])
                {
                case "forward":
                    p += x;
                    d += a * x;
                    break;

                case "down":
                    a += x;
                    break;

                case "up":
                    a -= x;
                    break;
                }
            }

            return d * p;
        }
    }
}
