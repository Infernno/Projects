using System;

namespace ConsoleSharpCore
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
                args = new[] { "hui", "zhopa" };

            if (args.Length > 0)
            {
                Console.WriteLine("Args:");

                foreach (var arg in args)
                    Console.WriteLine('\t' + arg);
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
