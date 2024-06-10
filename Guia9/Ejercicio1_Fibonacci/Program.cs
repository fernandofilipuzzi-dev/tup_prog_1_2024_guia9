using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Fibonacci
{
    internal class Program
    {
        static int Fibonacci_Iterativo(int numero)
        {
            int resultado = 0;
            int a1=0,a2=0;
            for (int n = 0; n <= numero; n++)
            {
                if (n <= 1) { 
                    resultado = 1; }
                else { resultado = a1 + a2; }

                a2 = a1;
                a1 = resultado;
            }

            return resultado;
        }


        static void Main(string[] args)
        {
            for (int n = 0; n < 23; n++)
            {
                Console.WriteLine("{0}", Fibonacci_Iterativo(n));
            }
            Console.ReadKey();
        }
    }
}
