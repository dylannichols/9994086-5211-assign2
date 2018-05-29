using System;
using System.Collections.Generic;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};

            //List<string> fruitsArray = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"};

            foreach(var fruit in fruitsArray) {
                Console.WriteLine(fruit);
            }
        }
    }
}
