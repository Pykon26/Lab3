using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("El número debe ser mayor a 1.");
            }
            else
            {
                long resultado = MultiplicarRecursivamente(numero);
                Console.WriteLine("El resultado final es: " + resultado);
            }
        }

        static long MultiplicarRecursivamente(long numero)
        {
            if (numero > 100000000)
            {
                return numero;
            }

            long nuevoNumero = numero * numero;
            Console.WriteLine("Resultado de la iteración: " + nuevoNumero);

            return MultiplicarRecursivamente(nuevoNumero);
        }

    }
}
