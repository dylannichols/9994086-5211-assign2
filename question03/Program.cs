using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};

            //List<string> fruitsArray = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"};

            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach(var fruit in fruitsArray) {
                Console.WriteLine(fruit);
            }

            sw.Stop();
            Debug.WriteLine($"Time to run: {sw.Elapsed}");
        }
    }
}
