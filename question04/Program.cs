using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the reverse timestables (highest number first) for:");

            var input = Console.ReadLine();

            var isNum = int.TryParse(input, out var number);

            if (isNum)
            {
                for (var i = 12; i > 0; i--)
                {
                    var a = i;
                    Console.WriteLine($"{a} x {number} = {a * number}");
                }
            }
        }
    }
}
