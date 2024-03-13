using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }   
        private static string Decor ( string s , char dec , int n)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
}
