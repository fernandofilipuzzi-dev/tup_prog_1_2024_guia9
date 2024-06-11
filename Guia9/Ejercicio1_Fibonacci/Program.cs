using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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

        static int Fibonacci_Recursivo(int numero)
        {
            if (numero <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci_Recursivo(numero - 1) + Fibonacci_Recursivo(numero - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generar un listado de números primos");

            Console.Write("Desde: ");
            int desde = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Hasta: ");
            int hasta = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Console.WriteLine($"Algoritmo recursivo:  {desde} hasta {hasta} es: ");
            for (int n = desde; n <= hasta; n++)
            {
                Console.Write($"{Fibonacci_Iterativo(n)} - ");
            }

            Console.WriteLine($"\n\nAlgorimo iterativo:  {desde} hasta {hasta} es: ");
            for (int n = desde; n <= hasta; n++)
            {
                Console.Write($"{Fibonacci_Recursivo(n)} - ");
            }

            Console.ReadKey();
        }
    }
}
