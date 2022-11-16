using System;
using PasswordGeneratorLibriary;

namespace ExampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pas = new PasswordGenerator();

            while (true)
            {
                Console.Write(pas.Generate(10, 5));

                Console.Read();
            }
        }
    }
}