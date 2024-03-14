using System;

namespace Special
{
    class Program
    {
        private static int GetSpecial(int n)
        {

            int i = 0;
            if (n == 1) //Base case
                i = 1;
            else
                i = n * GetSpecial(n - 1); //Other possibilities
            return i;
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GetSpecial(0);
            GetSpecial(2);
        }
    }
}
