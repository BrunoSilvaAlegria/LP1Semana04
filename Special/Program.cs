using System;

namespace Special
{
    class Program
    {
        /// <summary>
        /// Process the number given by the user in Main and gives out the 
        /// element correspondent to the position on the sequence chosen by
        /// the user (n)
        /// </summary>
        /// <param name="n">User chosen value</param>
        /// <returns></returns>
        private static int GetSpecial(int n)
        {
            int i;
            if (n == 0)
            {
                i = 0; //Base case 1
            }
            else if (n == 1)
            {
                i = 1; //Base case 2
            }
            else
            {   //Sequence Formation
                i = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);             
            }
            return i;
      
        }
        /// <summary>
        /// Receives a number given by the user, converts it to an integrable
        /// number and calls the method GetSpecial to process this number
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("What is the n-th number you want?\n>"); //User input
            int a = int.Parse(Console.ReadLine()); //Conversion
            //Calls the method with the asked value and writes it
            Console.WriteLine(GetSpecial(a)); 
        }
    }
}
