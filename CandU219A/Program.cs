using System;

namespace CandU219A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int X = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter another optional number \n" +
                "Or press 'Enter to continue");

            string Y = (Console.ReadLine());

            if (string.IsNullOrEmpty(Y))
            {

                Class219A.MathOP(X);
                Console.ReadLine();
            }
            else
            {
                int Z = Convert.ToInt16(Y);
                Class219A.MathOP(X, Z);
                Console.ReadLine();
            }
        }
    }
}




