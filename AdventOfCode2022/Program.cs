using System;
using System.IO;

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
}
