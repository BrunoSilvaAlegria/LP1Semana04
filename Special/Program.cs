using System;

namespace Special
{
    class Program
    {
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
            {
                i = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);                
            }
            return i;
      
        }
        static void Main(string[] args)
        {
            Console.Write("What is the n-th number you want?\n>");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(a));
        }
    }
}
