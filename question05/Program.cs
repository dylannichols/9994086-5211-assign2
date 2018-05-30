using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            var input = Console.ReadLine();

            var isNum = double.TryParse(input, out var number);

            if (isNum)
            {
                for (var i = 0; i < 12; i++)
                {
                    var a = i + 1;
                    var num1 = a.ToString("00");
                    var num2 = number.ToString("00");
                    Console.WriteLine($"{num1} / {num2} = {a / number}");
                }
            }
        }
    }
}
