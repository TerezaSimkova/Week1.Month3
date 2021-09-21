using System;
using System.Collections.Generic;

namespace Week1seondpart.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "You win some - You lose some.";

            string subs = s.Split('-')[0];

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }

        }
    }
}
