using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_GenerarNumerosPrimos
{
    internal class Program
    {
        static bool HayDidivibilidades(int numero, int divisor)
        {
            if (divisor > 1)
            {
                //agregar al inspector la expresión numero%divisor==0 al depurar
                return numero%divisor==0 || HayDidivibilidades(numero, divisor - 1);
            }
            else
                return false;
        }

        /*recordad que busco aquí si hay divisibilidades entre n y 1 - descargo evaluar n y 1*/
        static bool EsPrimoRecursivo(int numero)
        {
            return HayDidivibilidades(numero, numero-1)==false;
        }

        static bool EsPrimoIterativo(int numero)
        {
            int divisibilidades = 0;

            for (int n = 1; n <= numero; n++)
            {
               if(numero%n==0)
                    divisibilidades++;
            }

            return divisibilidades<=2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generar un listado de números primos");

            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"Algoritmo recursivo: Secuencia de números primos de 1 hasta {numero} es: ");
            for (int n = 1; n <= numero; n++)
            {
                if (EsPrimoRecursivo(n)==true)
                {
                    Console.Write($"{n} - ");
                }
            }

            Console.WriteLine($"\n\nAlgorimo iterativo: Secuencia de números primos de 1 hasta {numero} es: ");
            for (int n = 1; n <= numero; n++)
            {
                if (EsPrimoIterativo(n) == true)
                {
                    Console.Write($"{n} - ");
                }
            }

            Console.ReadKey();
        }
    }
}
