using System;

namespace question01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please introduce yourself:");
            Console.WriteLine("What is your first name ?");
            var fname = Console.ReadLine();

            Console.WriteLine("What is your last name ?");
            var lname = Console.ReadLine();

            Console.WriteLine(Greeting(fname, lname));
        }

        static string Greeting(string fname, string lname) {

            return $"Hello {fname} {lname} enjoy this assignemnt :-)";
        }
    }
}


