﻿using System;

namespace BetterDecorator
{   /// <summary>
    /// Receives 3 arguments that are later processed and transforms them 
    /// a string surrounded by a character a certain number of times.
    /// </summary>
    class Program
    {   /// <summary>
        /// Write a string that contain a specific character that appears 
        /// n times to the left and right of the phrase.
        /// In addiction, when no arguments are given, then it will print an 
        /// error string.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                //Prints the error string 
                Console.WriteLine(Decor());
            }
            else
            {
                //Prints the string modified by the Decor method
                Console.WriteLine(Decor(args[0],char.Parse(args[1])
                ,int.Parse(args[2])));
            }
        }
        /// <summary>
        /// Receive a string, a character and an integrable and make 
        /// the character appear the same number of times as the integrable, to
        /// the left and right of the string received.
        /// </summary>
        /// <param name="s">string to be received</param>
        /// <param name="dec">character to be received</param>
        /// <param name="n">integrable to be received</param>
        /// <returns></returns>
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
        /// <summary>
        /// Method used when the user doesn't give any arguments, and it is 
        /// called in the Decor method above.
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);

        }
    }    
}