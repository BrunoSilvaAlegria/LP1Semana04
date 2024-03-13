using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the string modified by the Decor method
            Console.WriteLine(Decor(args[0],char.Parse(args[1])
            ,int.Parse(args[2])));
        }
       
        private static string Decor (string s, char dec, int n)
        {
            //Creates the final string
            string str = "";

            for(int i=0; i<n; i++) 
            //Adds character to the beginning of the final string while i < n
            {
                str += $"{dec}";
            }
            // Adds the string itself to the final string
            str += $" {s} ";

            for(int i=0; i<n; i++) 
            //Adds character to the end of the final string while i < n
            {
                str += $"{dec}";
            }
            //Prints the final string
            return (str);
        }
    }
}