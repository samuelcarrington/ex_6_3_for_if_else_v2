using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_3_for_if_else_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6-3  Write a program that calculates N!/K! 
            for given N and K (1<K<N). (Chapter 6, Exercise 6)
             */

            Console.WriteLine("Calculates N!/K! for given N and K, (1 < K < N).");

            Console.WriteLine("N=");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("K=");
            int K = int.Parse(Console.ReadLine());

            if ((1 < K) && (K < N))
            {

                //Calculate N! = 1*2* ... *N
                decimal Nfactrial = 1;
                for (int i = 1; i <= N; i++)
                {
                    Nfactrial *= i;
                }

                //Calculate K! = 1*2* ... *N
                decimal Kfactrial = 1;
                for (int i = 1; i <= K; i++)
                {
                    Kfactrial *= i;
                }

                // Calculate N!/K!
                decimal num = Nfactrial / Kfactrial;
                Console.WriteLine("N!/K! = " + num);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error,(1 < K < N)");
                Console.ReadKey();
            }

            /*Multiply the numbers from K+1 to N (think why this is correct). 
            You may check the properties of the factorial function in Wikipedia: 
            http://en.wikipedia.org/wiki/Factorial. */
            /*
            if ((1 < K) && (K < N))
            {
                for (int i = 0; i <= N; i++)
                {
                    //Multiply the numbers from K+1 to N 

                }

            }
            */





        }
    }
}
