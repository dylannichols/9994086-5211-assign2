using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the reverse timestables (highest number first) for:");

            var number = Console.ReadLine();

            for(var i = 0; i < 12; i++) {
                var a = i + 1;
                Console.WriteLine($"{a} x {number} = {a * number}");
            }
        }
    }
}
