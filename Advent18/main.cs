using System;

namespace Advent{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Day 1
            Console.WriteLine("Day 1, part 1");
            Day1Part1 p1 = new Day1Part1();
            p1.findValue();
            Console.WriteLine("\nDay 1, part 2");
            Day1Part2 p2 = new Day1Part2();
            p2.findFreq();
            
            
            //Day 2
            Console.WriteLine("\nDay 2, part 1");
            Day2Part1 d2p1 = new Day2Part1();
            d2p1.findChecksum();
            Console.WriteLine("\nDay 2, part 2");
            Day2Part2 d2p2 = new Day2Part2();
            d2p2.findCommonText();

        }
    }
}